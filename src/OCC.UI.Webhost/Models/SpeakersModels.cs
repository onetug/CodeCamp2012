namespace OCC.UI.Webhost.Models
{
    using System;
    using System.Collections.Generic;

    public class Speaker
    {
        public int ID { get; set; }

        public string Email { get; set; }

        public string Name { get; set; }

        public string Title { get; set; }

        public string Bio { get; set; }

        public string WebSite { get; set; }

        public string Blog { get; set; }

        public string TwitterHandle { get; set; }
    }

    public class SpeakerViewModel
    {
        public IList<Speaker> Speakers { get; set; }

        public SpeakerViewModel()
        {
            Speakers = new List<Speaker>();
        }
    }
}