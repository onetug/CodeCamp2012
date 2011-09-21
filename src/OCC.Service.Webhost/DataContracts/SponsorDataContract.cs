namespace OCC.Service.Webhost.DataContracts
{
    using System.Collections.Generic;
    using OCC.Service.Webhost.Models;
    using System.Runtime.Serialization;

    [DataContract]
    public class SponsorDataContract
    {

        [DataMember]
        public IList<Sponsor> Sponsors { get; set; }
    }
}