namespace OCC.Service.Webhost.Services
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    [DataContract]
    public class Event
    {
        [DataMember]
        public int ID { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Description { get; set; }

        [DataMember]
        public string TwitterHashTag { get; set; }

        [DataMember]
        public DateTime StartTime { get; set; }

        [DataMember]
        public DateTime EndTime { get; set; }

        [DataMember]
        public string Location { get; set; }

        [DataMember]
        public string Address1 { get; set; }

        [DataMember]
        public string Address2 { get; set; }

        [DataMember]
        public string City { get; set; }

        [DataMember]
        public string State { get; set; }

        [DataMember]
        public string Zip { get; set; }

        [DataMember]
        public virtual IList<Announcement> Announcements { get; set; }

        [DataMember]
        public virtual IList<Session> Sessions { get; set; }

        [DataMember]
        public virtual IList<Sponsor> Sponsors { get; set; }

        [DataMember]
        public virtual IList<Person> Attendees { get; set; }

        public Event()
        {
            Announcements = new List<Announcement>();
            Sessions = new List<Session>();
            Sponsors = new List<Sponsor>();
            Attendees = new List<Person>();
        }
    }
}