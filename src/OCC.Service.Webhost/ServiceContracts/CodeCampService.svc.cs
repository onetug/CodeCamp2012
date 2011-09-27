namespace OCC.Service.Webhost
{
    using System.Collections.Generic;
    using OCC.Service.Webhost.Models;

    public class CodeCampService : ICodeCampService
    {
        public IList<Announcement> GetAnnouncements()
        {
            var result = new List<Announcement>();
            
            result.Add(new Announcement() { Title = "First Announcement", Subtitle = "by ONETUG", Content = "This is the first announcement." });
            result.Add(new Announcement() { Title = "Second Announcement", Subtitle = "by ONETUG", Content = "This is the second announcement." });
            result.Add(new Announcement() { Title = "Third Announcement", Subtitle = "by ONETUG", Content = "This is the third announcement." });
            
            return result;
        }

        public IList<Sponsor> GetAllSponsors()
        {
            var sponsorList = new List<Sponsor>(2);

            sponsorList.Add(new Sponsor {Name = "Microsoft"});
            sponsorList.Add(new Sponsor {Name = "DevExpress"});
            
            return sponsorList;
        }
    }
}