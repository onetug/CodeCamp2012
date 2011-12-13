namespace OCC.UI.Webhost.Models
{
    using System.Collections.Generic;

    public class Track
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public IList<Session> Sessions { get; set; }

        public Track()
        {
            Sessions = new List<Session>();
        }
    }
}