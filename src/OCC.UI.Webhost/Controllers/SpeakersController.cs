﻿namespace OCC.UI.Webhost.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;

    using OCC.UI.Webhost.Models;

    public class SpeakersController : AbstractController
    {
        //
        // GET: /Speakers/

        public ActionResult Index(int eventid)
        {
            SpeakersModel model = new SpeakersModel();

            model.Speakers.Add(new Speaker() { Name = "John Smith" });
            model.Speakers.Add(new Speaker() { Name = "Peter Smith" });
            model.Speakers.Add(new Speaker() { Name = "Bob Smith" });

            return View(model);
        }
    }
}