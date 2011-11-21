using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OCC.UI.Webhost.Models
{
    public class AgendaViewModel
    {
        public IList<string> Tracks { get; set; }
        public IList<string> Sessions { get; set; }
    }
}