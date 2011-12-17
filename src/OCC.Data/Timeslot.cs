namespace OCC.Data
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Timeslot
    {
        public int ID { get; set; }

        [ForeignKey("Event")]
        public int EventID { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        public DateTime? StartTime { get; set; }

        public DateTime? EndTime { get; set; }

        public Event Event { get; set; }
    }
}
