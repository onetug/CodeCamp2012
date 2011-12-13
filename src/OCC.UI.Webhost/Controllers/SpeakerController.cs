namespace OCC.UI.Webhost.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;

    public class SpeakerController : BaseController
    {
        //
        // GET: /Speaker/

        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /Speaker/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Speaker/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Speaker/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        
        //
        // GET: /Speaker/Edit/5
 
        public ActionResult Edit(int id)
        {
            // TODO: var speaker = service.GetSpeaker(id);
            // TODO: return View(speaker);

            return View();
        }

        //
        // POST: /Speaker/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
 
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Speaker/Delete/5
 
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Speaker/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
 
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
