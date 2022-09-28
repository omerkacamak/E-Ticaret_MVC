

using Data.Models;
using Data.Services.EntityManager;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace EcommerceWebSite.Controllers
{
    public class LoginController : Controller
    {
        [Route("/girisyap")]
        public IActionResult Index()
        {

            return View();
        }
        [HttpPost]
        [Route("/girisyap")]
        public async Task<IActionResult> IndexAsync(string name,string password)
        {
            var kisi = CustomerManager.Instance.GetOne1(i => i.FirstName == name && i.Password == password);
            if(kisi != null)
            {
                var claims = new List<Claim>();
                claims.Add(new Claim("username", name));
                claims.Add(new Claim("password", password));
                claims.Add(new Claim(ClaimTypes.NameIdentifier, name));
                claims.Add(new Claim(ClaimTypes.Name, name));
                claims.Add(new Claim("writerid",kisi.CustomerID.ToString()));
                var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);

                await HttpContext.SignInAsync(claimsPrincipal);
                var giris = new GirisZamani() { CustomerID = kisi.CustomerID ,girisTarihi=System.DateTime.Now,Status=true };
                GirisZamaniManager.Instance.TAdd(giris);
              
                return RedirectToAction("Index", "Home", new {area="HOMEPAGE"});
            }
            else
            {
                var hata = "Kullanıcı Adı Veya Şifre Hatalı! Tekrar Deneyin";
                TempData["hata"] = hata;
                
            }
            return View();

        }

        [Route("/cikis")]
        public async Task<IActionResult> LogOut()
        {
            GirisZamaniManager gm = new GirisZamaniManager(new EfGirisZamaniDal());
            var user = HttpContext.User.Claims.FirstOrDefault(c => c.Type == "writerid").Value;
            var userid = Convert.ToInt32(user);
            var giris = gm.GetOne1(i=>i.CustomerID==userid && i.Status==true);
           if(giris!=null)
            {
                giris.Status = false;
                giris.cikisTarihi = System.DateTime.Now;
                gm.TUpdate(giris);
            }
            await HttpContext.SignOutAsync();
            return Redirect("/girisyap");
        }
    }
}
