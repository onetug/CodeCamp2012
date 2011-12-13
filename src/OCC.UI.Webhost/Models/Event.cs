namespace OCC.UI.Webhost.Models
{
    using System;

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
    }
}