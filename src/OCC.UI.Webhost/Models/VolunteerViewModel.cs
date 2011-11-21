using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OCC.UI.Webhost.Models
{
    public class VolunteerViewModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public IList<VolunteerActivityViewModel> VolunteerActivities { get; set; }
    }
}