namespace OCC.UI.Webhost.Models
{
    using System;
    using System.Collections.Generic;

    public class VolunteerActivityViewModel
    {
        public string ActivityName { get; set; }

        public DateTimeOffset ActivityTimeStart { get; set; }

        public IList<VolunteerViewModel> Volunteers { get; set; }
    }
}