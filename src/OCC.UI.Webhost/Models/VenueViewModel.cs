using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OCC.UI.Webhost.Models
{
    // Z: merge this into the event class???

    public class VenueViewModel
    {
        public string LocationName { get; set; }

        public string Address { get; set; }

        public string StateAbbreviation { get; set; }

        public int ZipCode { get; set; }
    }
}