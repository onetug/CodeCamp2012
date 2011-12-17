namespace OCC.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Session
    {
        public int ID { get; set; }

        [ForeignKey("Track")]
        public int TrackID { get; set; }

        //[ForeignKey("Timeslot")]
        //public int TimeslotID { get; set; }

        [ForeignKey("Speaker")]
        public int SpeakerID { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(2000)]
        public string Description { get; set; }

        public Person Speaker { get; set; }

        public Track Track { get; set; }

        //public Timeslot Timeslot { get; set; }

        public int Level { get; set; }

        [StringLength(100)]
        public string Location { get; set; }

        public ICollection<SessionAttendee> Attendees { get; set; }

        public Session()
        {
            Attendees = new List<SessionAttendee>();
        }
    }
}