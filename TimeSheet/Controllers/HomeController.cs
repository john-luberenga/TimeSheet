using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TimeSheet.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        [Authorize]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult RegionDropDown()
        {
            List<string> items = new List<string>();
            items.Add("Please select");
            items.Add("Central");
            items.Add("Eastern");
            items.Add("Northern");
            items.Add("Western");
            SelectList region = new SelectList(items);
            ViewData["Region"] = region;
            return View();
        }

        public JsonResult GetDistricts(string region)
        {
            List<string> states = new List<string>();
            switch (region)
            {
                case "Central":
                    states.Add("California");
                    states.Add("Florida");
                    states.Add("Ohio");
                    break;
                case "Eastern":
                    //add UK states here
                    break;
                case "Nothern":
                    //add India states hete
                    break;
                case "Western":
                    //add India states hete
                    break;
            }
            return Json(states);
        }
    }
}