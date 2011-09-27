namespace OCC.Service.Webhost.Models
{
    using System.Runtime.Serialization;

    [DataContract]
    public class Announcement
    {
        [DataMember]
        public string Title { get; set; }

        [DataMember]
        public string Subtitle { get; set; }

        [DataMember]
        public string Content { get; set; }
    }
}