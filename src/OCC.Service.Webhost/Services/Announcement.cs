﻿namespace OCC.Service.Webhost.Services
{
    using System;
    using System.Runtime.Serialization;

    [DataContract]
    public class Announcement
    {
        [DataMember]
        public int ID { get; set; }

        [DataMember]
        public string Title { get; set; }

        [DataMember]
        public string Subtitle { get; set; }

        [DataMember]
        public string Content { get; set; }

        [DataMember]
        public DateTime PublishDate { get; set; }
    }
}