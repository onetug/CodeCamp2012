using System;
using System.Collections.Generic;

namespace OCC.UI.Webhost.Models
{
    public class SessionViewModel
    {
        public IList<SpeakerViewModel> Speakers { get; set; }
        public string Description { get; set; }
        public DateTimeOffset StartTime { get; set; }
    }
}