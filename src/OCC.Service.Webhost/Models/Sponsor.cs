namespace OCC.Service.Webhost.Models
{
    using System.Runtime.Serialization;

    [DataContract]
    public class Sponsor
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string SponsorshipLevel { get; set; }

        public string ImageUrl { get; set; }
    }
}