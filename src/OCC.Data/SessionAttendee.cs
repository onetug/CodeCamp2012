namespace OCC.Data
{
    using System.ComponentModel.DataAnnotations;

    public class SessionAttendee
    {
        public int ID { get; set; }

        public Session Session { get; set; }

        public Person Person { get; set; }

        public int Rating { get; set; }

        [StringLength(2000)]
        public string Comment { get; set; }
    }
}