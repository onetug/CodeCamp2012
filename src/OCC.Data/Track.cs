namespace OCC.Data
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Track
    {
        public int ID { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(2000)]
        public string Description { get; set; }

        public List<Session> Sessions { get; set; }

        public Track()
        {
            Sessions = new List<Session>();
        }
    }
}