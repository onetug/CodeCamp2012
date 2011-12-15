namespace OCC.Service.Webhost.Services
{
    using System;
    using System.Runtime.Serialization;

    [DataContract]
    public class Session
    {
        [DataMember]
        public int ID { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Track { get; set; }

        [DataMember]
        public string Description { get; set; }

        [DataMember]
        public string Speaker { get; set; }

        [DataMember]
        public int SpeakerID { get; set; }

        [DataMember]
        public DateTime StartTime { get; set; }

        [DataMember]
        public DateTime EndTime { get; set; }

        [DataMember]
        public string Location { get; set; }
    }
}