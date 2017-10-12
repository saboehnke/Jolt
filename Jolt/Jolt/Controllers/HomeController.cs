using Jolt.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;

namespace Jolt.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Services()
        {
            return View();
        }

        public ActionResult Gallery()
        {
            return View();
        }

        public ActionResult Signs()
        {
            return View();
        }

        [HttpGet]
        public ActionResult SubmitQuoteForm(QuoteFormModel qfm)
        {
            try
            {
                var email = ConfigurationManager.AppSettings["Email"];
                var password = ConfigurationManager.AppSettings["Password"];
                MailAddress from = new MailAddress(email, "JOLT CC");
                MailAddress to = new MailAddress(email, "JOLT CC");
                MailMessage message = new MailMessage(from, to);
                message.Subject = "JOLT Custom Sign Quote";
                message.Body = string.Format("Email: {0}\r\n\r\n"
                                           + "Material: {1}\r\n\r\n"
                                           + "Dimensions: {2}\" x {3}\"\r\n\r\n"
                                           + "Description: {4}", qfm.Email, qfm.Material, qfm.Width, qfm.Height, qfm.Description);
                message.Priority = MailPriority.High;
                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.EnableSsl = true;
                smtp.Port = 25;
                smtp.Credentials = new System.Net.NetworkCredential(email, password);
                //smtp.Send(message);
                TempData["QuoteMessage"] = "Quote submission successful!";
            }
            catch (Exception ex)
            {
                TempData["QuoteError"] = "There was an issue submitting your request. Please try again later.";
            }
            return RedirectToAction("Signs");
        }
    }
}