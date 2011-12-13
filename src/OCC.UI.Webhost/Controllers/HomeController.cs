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

    public class HomeController : BaseController
    {
        public ActionResult Index(int eventid)
        {
            HomeModel model = new HomeModel();

            var event_ = service.GetEvent(eventid);
            ViewBag.Message = event_.Name;

            var announcements = service.GetAnnouncements(eventid);
            foreach (var a in announcements)
                model.Announcements.Add(new AnnouncementViewModel { Title = a.Title, Subtitle = a.Subtitle, Content = a.Content });

            return View(model);
        }

        public ActionResult About()
        {
            return View();
        }
    }
}