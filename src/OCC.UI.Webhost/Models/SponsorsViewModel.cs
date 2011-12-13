using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OCC.UI.Webhost.Models
{
    public class SponsorsViewModel
    {
        public int ID { get; set; }

        public string ImageUrl { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string WebsiteUrl { get; set; }

        public string SponsorshipLevel { get; set; }
    }
}