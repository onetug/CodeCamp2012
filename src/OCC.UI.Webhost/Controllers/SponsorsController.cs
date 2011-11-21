using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OCC.UI.Webhost.Controllers
{
    public class SponsorsController : Controller
    {
        //
        // GET: /Sponsors/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SponsorInFocus()
        {
            return View("Index");
        }

    }
}
