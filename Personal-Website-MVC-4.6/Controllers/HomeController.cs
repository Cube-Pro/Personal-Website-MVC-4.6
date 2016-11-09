using Personal_Website_MVC_4._6.Models.HomeViewModels;
using Personal_Website_MVC_4._6.Models.SiteViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DemoTools;

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
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}