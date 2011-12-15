namespace OCC.UI.Webhost.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;

    using OCC.UI.Webhost.Models;
    
    //
    // GET: /Home/

    public class HomeController : BaseController
    {
        public ActionResult Index(int eventid)
        {
            var event_ = service.GetEvent(eventid);
            ViewBag.Message = event_.Name;

            List<Announcement> model = new List<Announcement>();
            var announcements = service.GetAnnouncements(eventid);
            foreach (var a in announcements)
                model.Add(new Announcement { Title = a.Title, Subtitle = a.Subtitle, Content = a.Content });

            return View(model);
        }

        public ActionResult Speakers(int eventid)
        {
            var speakers = service.GetSpeakers(eventid);

            List<Speaker> model = new List<Speaker>();
            foreach (var speaker in speakers)
                model.Add(new Speaker() { ID = speaker.ID, Name = speaker.FirstName + " " + speaker.LastName });

            return View(model);
        }

        public ActionResult Agenda(int eventid)
        {
            var tracks = service.GetTracksWithSessions(eventid);

            List<Track> model = new List<Track>();
            foreach (var track in tracks)
            {
                Track t = new Track() { ID = track.ID, Name = track.Name, Description = track.Description };

                foreach (var session in track.Sessions)
                    t.Sessions.Add(new Session()
                    {
                        ID = session.ID,
                        Name = session.Name,
                        Description = session.Description,
                        Speaker = session.Speaker,
                        SpeakerID = session.SpeakerID
                    });

                model.Add(t);
            }

            //model.Add(new Track() { Name = "Track 1" });

            //model[0].Sessions.Add(new Session() { Name = "Session 1-1" });
            //model[0].Sessions.Add(new Session() { Name = "Session 1-2" });
            //model[0].Sessions.Add(new Session() { Name = "Session 1-3" });

            //model.Add(new Track() { Name = "Track 2" });

            //model[1].Sessions.Add(new Session() { Name = "Session 2-1" });
            //model[1].Sessions.Add(new Session() { Name = "Session 2-2" });
            //model[1].Sessions.Add(new Session() { Name = "Session 2-3" });

            //model.Add(new Track() { Name = "Track 3" });

            //model[2].Sessions.Add(new Session() { Name = "Session 3-1" });
            //model[2].Sessions.Add(new Session() { Name = "Session 3-2" });
            //model[2].Sessions.Add(new Session() { Name = "Session 3-3" });

            return View(model);
        }

        public ActionResult Sponsors(int eventid)
        {
            var sponsors = service.GetSponsors(eventid);

            List<Sponsor> model = new List<Sponsor>();
            foreach (var sponsor in sponsors)
                model.Add(new Sponsor() 
                { 
                    ID = sponsor.ID, 
                    Name = sponsor.Name, 
                    Description = sponsor.Description, 
                    ImageUrl = sponsor.ImageUrl, 
                    SponsorshipLevel = sponsor.SponsorshipLevel, 
                    WebsiteUrl = sponsor.WebsiteUrl 
                });

            return View(model);
        }

        public ActionResult Volunteers(int eventid)
        {
            var volunteers = service.GetVolunteers(eventid);

            List<Volunteer> model = new List<Volunteer>();
            foreach (var volunteer in volunteers)
                model.Add(new Volunteer() 
                {
                    ID = volunteer.ID,
                    Name = volunteer.FirstName + " " + volunteer.LastName
                });

            return View(model);
        }

        public ActionResult Venue(int eventid)
        {
            var event_ = service.GetEvent(eventid);

            Event model = new Event()
            {
                ID = event_.ID,
                Name = event_.Name,
                Description = event_.Description,
                TwitterHashTag = event_.TwitterHashTag,
                StartTime = event_.StartTime,
                EndTime = event_.EndTime,
                Location = event_.Location,
                Address1 = event_.Address1,
                Address2 = event_.Address2,
                City = event_.City,
                State = event_.State,
                Zip = event_.Zip
            };

            return View(model);
        }
    }
}