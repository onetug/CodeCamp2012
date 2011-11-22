namespace OCC.UI.Webhost.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;

    using OCC.UI.Webhost.Models;

    //
    // GET: /Sessions/

    public class SessionsController : AbstractController
    {

        public ActionResult Index(int eventid)
        {
            ViewBag.Message = "Code Camp";

            SessionsModel model = new SessionsModel();

            model.Tracks.Add(new Track() { Name = "Track 1" });

            model.Tracks[0].Sessions.Add(new Session() { Name = "Session 1-1" });
            model.Tracks[0].Sessions.Add(new Session() { Name = "Session 1-2" });
            model.Tracks[0].Sessions.Add(new Session() { Name = "Session 1-3" });

            model.Tracks.Add(new Track() { Name = "Track 2" });

            model.Tracks[1].Sessions.Add(new Session() { Name = "Session 2-1" });
            model.Tracks[1].Sessions.Add(new Session() { Name = "Session 2-2" });
            model.Tracks[1].Sessions.Add(new Session() { Name = "Session 2-3" });

            model.Tracks.Add(new Track() { Name = "Track 3" });

            model.Tracks[2].Sessions.Add(new Session() { Name = "Session 3-1" });
            model.Tracks[2].Sessions.Add(new Session() { Name = "Session 3-2" });
            model.Tracks[2].Sessions.Add(new Session() { Name = "Session 3-3" });

            return View(model);
        }
    }
}
