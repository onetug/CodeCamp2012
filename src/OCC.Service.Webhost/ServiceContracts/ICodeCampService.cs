using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using OCC.Service.Webhost.Models;

namespace OCC.Service.Webhost
{
    [ServiceContract]
    public interface ICodeCampService
    {
        [OperationContract]
        IList<Sponsor> GetAllSponsors();

        [OperationContract]
        IList<Announcement> GetAnnouncements();
    }
}
