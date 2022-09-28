using Data.Models;
using Data.Services.EntityManager;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EcommerceWebSite.Areas.ORDER.Controllers
{
    [Area("ORDER")]

    
    public class OrderController : Controller
    {

        #region ViewBag tanımları
        public void ViewBags()
        {
            var user1 = HttpContext.User.Claims.FirstOrDefault(c => c.Type == "writerid").Value;
            var userid1 = Convert.ToInt32(user1);
            var kullanici = CustomerManager.Instance.GetById(userid1);
            ViewBag.kullanici = kullanici;
            List<SelectListItem> paymentTur = (from x in PaymentManager.Instance.GetList()
                                               select new SelectListItem
                                               {
                                                   Text = x.PaymentType,
                                                   Value = x.PaymentID.ToString()
                                               }).ToList();

            ViewBag.payment = paymentTur;
        }
        #endregion

        [Route("/siparis")]
        [Authorize]
        public IActionResult Order()
        {

            var user = HttpContext.User.Claims.FirstOrDefault(c => c.Type == "writerid").Value;
            var userid = Convert.ToInt32(user);

            ViewBags();
           



            var sepetim = ShoppingCartManager.Instance.getOneWithItems1(i => i.Status == true && i.CustomerID == userid);
            ViewBag.sepetisNull = sepetim == null;

            if (sepetim != null)
            {
                var sepetItemler = sepetim.ShoppingCartItems;
                TempData["sepetItems"] = sepetItemler;
              //  ViewBag.sepetPrice = sepetim.toplamFiyat();

                #region Payment list seçimi için select list item oluşturma
                List<SelectListItem> payment = (from x in PaymentManager.Instance.GetList()

                                                select new SelectListItem
                                                {
                                                    Text = x.PaymentType,
                                                    Value = x.PaymentID.ToString()
                                                }
                                                                        ).ToList();
                #endregion

                ViewBag.select = payment;
                return View();
            }
            else
            {
                return Redirect("/anasayfa");
            }

            //jsonresult ile buraya giremezsiniz diye gönder 



        }
        [HttpPost]
        [Route("/siparis")]

        [Authorize]
        public IActionResult Order(Order order)
        {
            var user = HttpContext.User.Claims.FirstOrDefault(c => c.Type == "writerid").Value;
            var userid = Convert.ToInt32(user);
            var sepetim = ShoppingCartManager.Instance.getOneWithItems1(i => i.Status == true && i.CustomerID == userid);//giriş yapan kul. ve aktif sepet
            
            if (ModelState.IsValid)
            {


                order.OrderStatus = true;
                order.TeslimDurumu = false;
                order.CustomerID = userid;
                // order.OrderAddress = "ayazma mahallesi";
                order.ToplamFiyat = sepetim.totalPrice;
                order.OrderCreateDate = DateTime.Now;
                OrderManager.Instance.TAdd(order);
                Console.WriteLine("-->**  " + order.OrderID);
                //var yeniOrder = OrderManager.Instance.GetById(22);
                foreach (var item in sepetim.ShoppingCartItems)
                {
                    OrderDetail orderDetail = new OrderDetail
                    {
                        Adet = item.Adet,
                        OrderID = order.OrderID,
                        ProductItemID = item.ProductItemID
                    };
                    OrderDetailManager.Instance.TAdd(orderDetail);
                }
                sepetim.Status = false; //sepeti false yaptığımız için yeni sepet üszerinden artık sipariş olacak
                ShoppingCartManager.Instance.TUpdate(sepetim);



                return Redirect("/anasayfa");
            }



            ViewBags();
            var sepetItemler = sepetim.ShoppingCartItems;
            TempData["sepetItems"] = sepetItemler;
           // ViewBag.sepetPrice = sepetim.toplamFiyat();
            return View();

        }
    }
}
