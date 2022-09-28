using Data.Models;
using Data.Services.EntityManager;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Net;
using System.Net.Mail;

namespace EcommerceWebSite.Areas.CONTACT.Controllers
{
    [Area("CONTACT")]
    public class ContactController : Controller
    {
        [Route("/iletisim")]
        public IActionResult Contact()
        {
            return View();
        }
        [HttpPost]
        [Route("/iletisim")]
        public IActionResult Contact(Talep talep)
        {
            if(ModelState.IsValid)
            {
                TalepManager.Instance.TAdd(talep);
                MailMessage mail = new MailMessage();
                mail.To.Add("omerkacamakk98@gmail.com");
                mail.From = new MailAddress(talep.GondericiEmail);
                mail.Subject = $"E-Ticaret sitenizden mesaj var Konu : {talep.Konu}";
                mail.Body = $"Sayın yetkili {talep.GondericiEmail} adresinden size ulaşan bir mesaj var. <br> {talep.Description}";
                mail.IsBodyHtml = true;
                SmtpClient smtp = new SmtpClient();
                smtp.Credentials = new NetworkCredential("omerkacamakk98@gmail.com", "Omerkacamak1905@");
                smtp.Port = 587;
                smtp.Host = "smtp.gmail.com";
                smtp.EnableSsl=true;
               // smtp.DeliveryMethod = Mail.SmptDeliveryMethod
                try
                {
                    smtp.Send(mail);
                    TempData["mesaj"] = "Mesajınız iletilmiştir en kısa zamanda geri dönüş sağlanacaktır";
                }
                catch (Exception ex)
                {

                    TempData["mesaj"] ="Mail gönderilemedi. Hata: "+ ex.Message;
                }
            }
            return View();
        }
    }
}
