using Personal_Website_MVC_4._6.Models.HomeViewModels;
using Personal_Website_MVC_4._6.Models.SiteViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DemoTools;

using MVCEmail.Models;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace Personal_Website_MVC_4._6.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var details = new DemoFill();

            var siteProfile = new PersonProfile
            {
                FirstName = "Lorin",
                LastName = "Hart",
                Email = "L.Mark.Hart@gmail.com",
                BioDetails = details.FillWithLatinText(250),
                BioImagePath = "/include/images/biopic.jpg",
                SkillsList = new string[] { "Computer Programmer", "Entrepreneur", "Business Consultant", "Children's Author" },
                Title = "",
                ShortBiio = details.FillWithLatinText(75),
                PersonalQuote = "If you dont know what I'm doing, how do you know I'm wrong?",
                QuoteAuthor = "Lorin M. Hart"



            };

            ViewBag.SiteName = "Lorin Hart";
            ViewBag.Copyright = "Offical Site of Lorin M. Hart";
            ViewBag.Maintenance = 3;

            

            return View(siteProfile);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Title = "Contact";
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Contact(EmailModel model)
        {
            ViewBag.Message = "Your contact page.";
            if (ModelState.IsValid)
            {
                var body = "<p>Email From: {0} ({1})</p><p>Message:</p><p>{2}</p>";
                var message = new MailMessage();
                message.To.Add(new MailAddress("xxxx"));  // replace with valid value 
                message.From = new MailAddress("xxxx");  // replace with valid value
                message.Subject = "Your email subject";
                message.Body = string.Format(body, model.FromName, model.FromEmail, model.Message);
                message.IsBodyHtml = true;

                using (var smtp = new SmtpClient())
                {
                    var credential = new NetworkCredential
                    {
                        UserName = "xxxx",  // replace with valid value
                        Password = "xxxx"  // replace with valid value
                    };
                    smtp.Credentials = credential;
                    smtp.Host = "smtp.gmail.com";
                    smtp.Port = 587;
                    smtp.EnableSsl = true;
                    await smtp.SendMailAsync(message);
                    return RedirectToAction("Sent");
                }
            }
            return View(model);
        }




        public ActionResult Sent()
        {
            return View();
        }
    }
}