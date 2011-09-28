﻿namespace OCC.Service.Webhost.Models
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    [DataContract]
    public class Event
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string TwitterHashTag { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        public string Location { get; set; }

        public string Address1 { get; set; }

        public string Address2 { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string Zip { get; set; }

        public virtual IList<Announcement> Announcements { get; set; }

        public virtual IList<Session> Sessions { get; set; }

        public virtual IList<Sponsor> Sponsors { get; set; }

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