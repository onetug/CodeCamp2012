namespace OCC.UI.Webhost.Models
{
    using System.Collections.Generic;

    public class Session
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public string Speaker { get; set; }

    }

    public class Track
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public IList<Session> Sessions { get; set; }

        public Track()
        {
            Sessions = new List<Session>();
        }
    }

    public class SessionViewModel
    {
        public IList<Track> Tracks { get; set; }

        public SessionViewModel()
        {
            Tracks = new List<Track>();
        }
    }
}