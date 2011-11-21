using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OCC.UI.Webhost.Models
{
    public class SpeakerViewModel
    {
        public string SpeakerFirstName { get; set; }
        public string SpeakerLastName { get; set; }
        public IList<SessionViewModel> Sessions { get; set; }
    }
}