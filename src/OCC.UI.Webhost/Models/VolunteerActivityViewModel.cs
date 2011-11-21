using System;
using System.Collections.Generic;

namespace OCC.UI.Webhost.Models
{
    public class VolunteerActivityViewModel
    {
        public string ActivityName { get; set; }
        public DateTimeOffset ActivityTimeStart { get; set; }
        public IList<VolunteerViewModel> Volunteers { get; set; }
    }
}