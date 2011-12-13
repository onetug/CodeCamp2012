namespace OCC.UI.Webhost.Controllers
{
    using System;
    using System.Web.Mvc;

    using OCC.UI.Webhost.CodeCampService;
    
    public abstract class BaseController : Controller
    {
        /*note: The idea here is that all controllers will inheirit from this one which will give the 
         * ability to give a model to the _Layout view as well as other things. -Brian Hall-*/

        protected ICodeCampService service;

        public BaseController(ICodeCampService service)
        {
            this.service = service;
        }

        public BaseController()
            : this(new CodeCampServiceClient())
        {
        }
    }
}
