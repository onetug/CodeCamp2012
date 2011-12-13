namespace OCC.UI.Webhost.Controllers
{
    using System;
    using System.Web.Mvc;

    public class SponsorsController : BaseController
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
