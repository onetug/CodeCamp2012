namespace OCC.UI.Webhost.Controllers
{
    using System.Web.Mvc;

    using OCC.UI.Webhost.Models;

    public class SessionController : BaseController
    {
        //
        // GET: /Session/

        public ActionResult Index()
        {
            return View("Details");
        }

        //
        // GET: /Session/Details/5

        public ActionResult Details(int id)
        {
            var session = service.GetSession(id);

            Session model = new Session()
            {
                ID = session.ID,
                Name = session.Name,
                Description = session.Description,
                Speaker = session.Speaker,
                SpeakerID = session.SpeakerID
            };

            return View(model);
        }

        //
        // GET: /Session/Create

        public ActionResult Create()
        {
            return View("Details");
        } 

        //
        // POST: /Session/Create

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
                return View("Details");
            }
        }
        
        //
        // GET: /Session/Edit/5
 
        public ActionResult Edit(int id)
        {
            return View("Details");
        }

        //
        // POST: /Session/Edit/5

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
                return View("Details");
            }
        }

        //
        // GET: /Session/Delete/5
 
        public ActionResult Delete(int id)
        {
            return View("Details");
        }

        //
        // POST: /Session/Delete/5

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
                return View("Details");
            }
        }
    }
}
