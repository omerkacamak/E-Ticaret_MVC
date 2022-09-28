using Data.Models;
using Data.Services.EntityManager;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace EcommerceWebSite.Areas.SHOPPINGCART.Controllers
{
    [Area("SHOPPINGCART")]
    public class HomeController : Controller
    {
        [Route("/sepet")]
        [Authorize]
        public IActionResult Sepet()
        {
            
            var user = HttpContext.User.Claims.FirstOrDefault(c => c.Type == "writerid").Value;
            var userid = Convert.ToInt32(user);
            var sepetim = ShoppingCartManager.Instance.getOneWithItems1(i => i.Status == true && i.CustomerID == userid);
            if(sepetim != null)
            {
                decimal total = 0;
                foreach (var item in sepetim.ShoppingCartItems)
                {
                    total += item.ProductItem.new_price * item.Adet;
                }
                ViewBag.total = total;
            }
           


            return View(sepetim);
        }
        [HttpGet]
        
       

        public IActionResult AddCart(int id,int adet) // sepet oluşturup sepetin içine itemleri koyar!! sepetin statusunu kontrol eder
        {
            if(adet==0) { adet = 1; }

            var productw = ProductItemManager.Instance.GetById(id);
            if (User.Identity.IsAuthenticated)
            {
                var user = HttpContext.User.Claims.FirstOrDefault(c => c.Type == "writerid").Value;
                var userid = Convert.ToInt32(user);
                var sepet = ShoppingCartManager.Instance.GetOne1(i => i.Status == true && i.CustomerID == userid);
                if (sepet != null)
                {

                    ShoppingCartItems cartItem2 = new ShoppingCartItems()
                    {
                        ProductItemID = productw.ProductItemID,
                        ShoppingCartID = sepet.ShoppingCartID,
                        Adet=adet
                        
                    };
                    ShoppingCartItemManager.Instance.TAdd(cartItem2);
                   

                }

                else
                {
                    ShoppingCart cart = new ShoppingCart()
                    {
                        CustomerID = userid,
                        CreatedTime = DateTime.Now,
                        SepetKodu = "44",
                        Status = true,

                    };
                    ShoppingCartManager.Instance.TAdd(cart);
                    var sepet2 = ShoppingCartManager.Instance.GetOne1(i => i.Status == true && i.CustomerID == userid);
                    ShoppingCartItems cartItem = new ShoppingCartItems()
                    {
                        ProductItemID = productw.ProductItemID,
                        ShoppingCartID = sepet2.ShoppingCartID,

                    };
                    ShoppingCartItemManager.Instance.TAdd(cartItem);
                    
                }
                return Json("Ürün başarıyla sepete eklendi");
            }

            else
            {
                return Json("Lütfen önce kayıt olun");
            }
            
        }
        

        public IActionResult UpdateCart (int shopitemid,int adet) // sepet sayfasında adeti değiştirdikçe tetiklenecek olan action: adeti sepet sayfasından alacaz
        {
            var shoppingCartItem = ShoppingCartItemManager.Instance.GetById(shopitemid);
            shoppingCartItem.Adet = adet;
            ShoppingCartItemManager.Instance.TUpdate(shoppingCartItem);
            var sepetim = ShoppingCartManager.Instance.getOneWithItems1(i => i.ShoppingCartID==shoppingCartItem.ShoppingCartID);
            if (sepetim != null)
            {

              //  var total = sepetim.toplamFiyat();
                ShoppingCartManager.Instance.TUpdate(sepetim);
            }
           

            
            return Ok();
        }

        
        public IActionResult DeleteCartItem(int id)
        {
            var cartItem = ShoppingCartItemManager.Instance.GetById(id);
            var cartItemid = cartItem.ShoppingCartID; // silinen cart itemin id'sini tutalım

            ShoppingCartItemManager.Instance.TDelete(cartItem); // sil
            var sepet = ShoppingCartManager.Instance.getOneWithItems1(i=>i.ShoppingCartID==cartItemid); // fiyat güncelleme işlemi için cartı seç.
           // var totalPrice = sepet.toplamFiyat(); //Sepetin toplam tutarını değiştiri.
            ShoppingCartManager.Instance.TUpdate(sepet);
             return Ok();
        }

    }
}
