using Personal_Website_MVC_4._6.Models.HomeViewModels;
using Personal_Website_MVC_4._6.Models.SiteViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Personal_Website_MVC_4._6.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            var siteProfile = new PersonProfile
            {
                FirstName = "Lorin",
                LastName = "Hart",
                Email = "L.Mark.Hart@gmail.com",
                BioDetails = "",
                BioImagePath = "",
                SkillsList = new string[] {"Cold Fusion", "MySQL", "MSSQL", "PHP"},


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