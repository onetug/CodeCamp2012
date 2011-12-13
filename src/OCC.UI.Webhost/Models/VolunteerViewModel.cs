namespace OCC.UI.Webhost.Models
{
    using System.Collections.Generic;

    public class VolunteerViewModel
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public IList<VolunteerActivityViewModel> VolunteerActivities { get; set; }
    }
}