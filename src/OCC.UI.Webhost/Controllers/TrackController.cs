using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OCC.UI.Webhost.Models;

namespace OCC.UI.Webhost.Controllers
{
    public class TrackController : BaseController
    {
        //
        // GET: /Track/

        public ActionResult Index(int eventID)
        {
            var tracks = service.GetTracks(eventID);

            List<Track> model = new List<Track>();
            foreach (var track in tracks)
                model.Add(new Track() { ID = track.ID, Name = track.Name, Description = track.Description });

            return View(model);
        }

        //
        // GET: /Track/Details/5

        public ActionResult Details(int id)
        {
            var track = service.GetTrack(id);

            Track model = new Track() { ID = track.ID, Name = track.Name, Description = track.Description };

            return View(model);
        }

        //
        // GET: /Track/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Track/Create

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
        // GET: /Track/Edit/5
 
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Track/Edit/5

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
        // GET: /Track/Delete/5
 
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Track/Delete/5

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
