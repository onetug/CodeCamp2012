namespace OCC.UI.Webhost.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;

    using OCC.UI.Webhost.Models;
    
    //
    // GET: /Home/

    public class HomeController : Controller
    {
        public ActionResult Index(int eventid)
        {
            HomeModel model = new HomeModel();

            using (CodeCampService.CodeCampServiceClient client = new CodeCampService.CodeCampServiceClient())
            {
                var e = client.GetEvent(eventid);
                ViewBag.Message = e.Name;

                var announcements = client.GetAnnouncements(eventid);
                foreach (var a in announcements)
                    model.Announcements.Add(new AnnouncementViewModel { Title = a.Title, Subtitle = a.Subtitle, Content = a.Content });
            }

            return View(model);
        }

        public ActionResult About()
        {
            return View();
        }
    }
}