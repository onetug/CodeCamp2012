using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OCC.UI.Webhost.Controllers
{
    public abstract class AbstractController : Controller
    {
        /*note: The idea here is that all controllers will inheirit from this one which will give the 
         * ability to give a model to the _Layout view as well as other things. -Brian Hall-*/
    }
}
