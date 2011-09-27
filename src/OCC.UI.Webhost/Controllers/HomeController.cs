namespace OCC.UI.Webhost.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;

    using OCC.UI.Webhost.Models;

    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            HomeModel model = new HomeModel();

            ViewBag.Message = "Orlando CodeCamp 2012";

            using (CodeCampService.CodeCampServiceClient client = new CodeCampService.CodeCampServiceClient())
            {
                var announcements = client.GetAnnouncements();
                foreach (var a in announcements)
                    model.Announcements.Add(new Announcement() { Title = a.Title, Subtitle = a.Subtitle, Content = a.Content });
            }

            return View(model);
        }

        public ActionResult About()
        {
            return View();
        }
    }
}