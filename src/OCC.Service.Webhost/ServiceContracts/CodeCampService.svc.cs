namespace OCC.Service.Webhost
{
    using System.Collections.Generic;
    using OCC.Service.Webhost.Models;

    public class CodeCampService : ICodeCampService
    {

        public IList<Sponsor> GetAllSponsors()
        {
            var sponsorList = new List<Sponsor>(2);

            sponsorList.Add(new Sponsor {Name = "Microsoft"});
            sponsorList.Add(new Sponsor {Name = "DevExpress"});
            
            return sponsorList;
        }
    }
}
