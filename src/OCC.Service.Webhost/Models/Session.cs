namespace OCC.Service.Webhost.Models
{
    using System;

    public class Session
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public string Track { get; set; }

        public string Description { get; set; }

        public Person Speaker { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        public string Location { get; set; }
    }
}