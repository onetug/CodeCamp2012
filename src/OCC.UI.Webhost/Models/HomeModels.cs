namespace OCC.UI.Webhost.Models
{
    using System.Collections.Generic;

    public class HomeModel
    {
        public IList<AnnouncementViewModel> Announcements { get; set; }

        public HomeModel()
        {
            Announcements = new List<AnnouncementViewModel>();
        }
    }
}