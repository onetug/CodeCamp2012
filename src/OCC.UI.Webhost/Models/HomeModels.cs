namespace OCC.UI.Webhost.Models
{
    using System.Collections.Generic;

    public class Announcement
    {
        public string Title { get; set; }

        public string Subtitle { get; set; }

        public string Content { get; set; }
    }

    public class HomeModel
    {
        public IList<Announcement> Announcements { get; set; }

        public HomeModel()
        {
            Announcements = new List<Announcement>();
        }
    }
}