namespace OCC.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Session
    {
        public int ID { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(2000)]
        public string Description { get; set; }

        public Person Speaker { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        [StringLength(100)]
        public string Location { get; set; }

        public ICollection<SessionAttendee> Attendees { get; set; }

        public Session()
        {
            Attendees = new List<SessionAttendee>();
        }
    }
}