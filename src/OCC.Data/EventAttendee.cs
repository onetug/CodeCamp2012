namespace OCC.Data
{
    public class EventAttendee
    {
        public int ID { get; set; }

        public Event Event { get; set; }

        public Person Person { get; set; }
    }
}