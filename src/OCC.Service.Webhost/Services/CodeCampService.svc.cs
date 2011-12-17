namespace OCC.Service.Webhost.Services
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using OCC.Data;
    using OCC.Service.Webhost.Tools;

    public class CodeCampService : ICodeCampService
    {
        // Person

        public void RegisterPerson(Person person)
        {
            using (var db = new OCCDB())
            {
                var pTo = new OCC.Data.Person();
                Mapper.CopyProperties(person, pTo);
                //TODO OFC - Uncomment persistence calls
                // db.People.Add(pTo);
                // db.SaveChanges();
            }
        }

        public Person Login(Person person)
        {
            Person dcAttendee = default(Person);
            //TODO OFC - Uncomment Login statements
            //using (var db = new OCCDB())
            //{
            //    var bcAttendee = 
            //        db.People
            //          .SingleOrDefault(p => 
            //                           p.Email == person.Email &&
            //                           p.PasswordHash == person.PasswordHash);
                
            //    if (bcAttendee != null)
            //    {
            //        dcAttendee = new Person();
            //        Mapper.CopyProperties(bcAttendee, dcAttendee);
            //    }   
            //}
            return dcAttendee;
        }

        public Person FindPersonByEmail(string email)
        {
            Person dcAttendee = default(Person);
            //TODO OFC - Uncomment attendee lookup.
            //using (var db = new OCCDB())
            //{
            //    var bcAttendee = db.People
            //        .SingleOrDefault(p => p.Email == email);

            //    if (bcAttendee != null)
            //    {
            //        dcAttendee = new Person();
            //        Mapper.CopyProperties(bcAttendee, dcAttendee);
            //    }
            //}
            return dcAttendee;
        }

        public void ChangePassword(int id, string oldPassord, string newPassword)
        {
            throw new NotImplementedException();
        }

        public void UpdatePerson(Person person)
        {
            throw new NotImplementedException();
        }

        public void DeletePerson(int personId)
        {
            throw new NotImplementedException();
        }
        
        // Events

        public IList<Event> GetEvents(DateTime fromDate, DateTime toDate)
        {
            throw new NotImplementedException();
        }

        public void CreateEvent(Event _event)
        {
            throw new NotImplementedException();
        }

        public Event GetEvent(int eventId)
        {
            using (OCCDB db = new OCCDB())
            {
                var e = db.Events.Find(eventId);

                if (e == null)
                    throw new ArgumentException("Event not found");

                return e.AsEvent();
            }
        }

        public void UpdateEvent(Event event_)
        {
            using (OCCDB db = new OCCDB())
            {
                var e = db.Events.Find(event_.ID);

                e.Name = event_.Name;
                e.Description  = event_.Description;
                e.TwitterHashTag  = event_.TwitterHashTag;
                e.StartTime  = event_.StartTime;
                e.EndTime  = event_.EndTime;
                e.Location  = event_.Location;
                e.Address1  = event_.Address1;
                e.Address2  = event_.Address2;
                e.City  = event_.City;
                e.State  = event_.State;
                e.Zip = event_.Zip;

                db.SaveChanges();
            }
        }

        // Track

        public Track GetTrack(int id)
        {
            using (OCCDB db = new OCCDB())
            {
                var t = db.Tracks.Find(id);
                return t.AsTrack();
            }
        }

        public void AddTrack(Track track)
        {
            using (OCCDB db = new OCCDB())
            {
                Data.Track t = new Data.Track()
                {
                    EventID = track.EventID,
                    Name = track.Name,
                    Description = track.Description
                };

                db.Tracks.Add(t);

                db.SaveChanges();
            }
        }

        public void UpdateTrack(Track track)
        {
            using (OCCDB db = new OCCDB())
            {
                var t = db.Tracks.Find(track.ID);

                t.Name = track.Name;
                t.Description = track.Description;

                db.SaveChanges();
            }
        }

        public void DeleteTrack(int id)
        {
            using (OCCDB db = new OCCDB())
            {
                Data.Track track = (from t in db.Tracks.Include("Sessions") where t.ID == id select t).FirstOrDefault();

                if (track.Sessions.Count > 0)
                    throw new Exception("Can't delete a track that contains sessions!");

                db.Tracks.Remove(track);

                db.SaveChanges();
            }
        }

        public IList<Track> GetTracks(int eventId)
        {
            using (OCCDB db = new OCCDB())
            {
                var e = db.Events.Find(eventId);

                if (e == null)
                    throw new ArgumentException("Event not found");

                List<Track> result = new List<Track>();
                foreach (var track in e.Tracks)
                    result.Add(track.AsTrack());

                return result;
            }
        }

        public IList<Track> GetTracksWithSessions(int eventId)
        {
            using (OCCDB db = new OCCDB())
            {
                var e = (from x in db.Events.Include("Tracks.Sessions.Speaker")// .Include("Tracks.Sessions.Speaker")
                         where x.ID == eventId
                         select x).FirstOrDefault();

                if (e == null)
                    throw new ArgumentException("Event not found");

                List<Track> result = new List<Track>();
                foreach (var track in e.Tracks)
                    result.Add(track.AsTrackWithSessions());

                return result;
            }
        }

        // Session

        public Session GetSession(int id)
        {
            using (OCCDB db = new OCCDB())
            {
                var s = (from x in db.Sessions.Include("Speaker")
                         where x.ID == id
                         select x).FirstOrDefault();

                if (s == null) throw new ArgumentException("Session not found");

                return s.AsSession();
            }
        }

        // Speaker

        public Speaker GetSpeaker(int id)
        {
            using (OCCDB db = new OCCDB())
            {
                var s = (from x in db.People
                         where x.ID == id
                         select x).FirstOrDefault();

                if (s == null) throw new ArgumentException("Session not found");

                return s.AsSpeaker();
            }
        }

        // ... 

        public IList<Announcement> GetAnnouncements(int eventId)
        {
            using (OCCDB db = new OCCDB())
            {
                var result = new List<Announcement>();

                foreach (var announcement in db.Events.Find(eventId).Announcements)
                {
                    var a = new Announcement();
                    Mapper.CopyProperties(announcement, a);
                    result.Add(a);
                }

                return result;
            }
        }

        public IList<Session> GetSessions(int idEvent)
        {
            throw new NotImplementedException();

            //using (OCCDB db = new OCCDB())
            //{
            //    var sessions = db.Events.Find(idEvent).Sessions
            //        .OrderBy(s => s.Track)
            //        .OrderBy(s => s.StartTime)
            //        .ToList();

            //    var result = new List<Session>();

            //    foreach (var session in sessions)
            //    {
            //        Session s = new Session();
            //        Mapper.CopyProperties(session, s);
            //        result.Add(s);
            //    }

            //    return result;
            //}
        }

        public IList<Person> GetSpeakers(int idEvent)
        {
            //using (OCCDB db = new OCCDB())
            //{
            //    var speakers = (from session in db.Events.Find(idEvent).Sessions
            //            select session.Speaker)
            //            .Distinct()
            //            .OrderBy(s => s.FirstName + " " + s.LastName)
            //            .ToList();

            //    var result = new List<Person>();

            //    foreach (var speaker in speakers)
            //    {
            //        Person s = new Person();
            //        Mapper.CopyProperties(speaker, s);
            //        result.Add(s);
            //    }

            //    return result;
            //}

            List<Person> result = new List<Person>();
            result.Add(new Person() { ID = 1, FirstName = "John", LastName = "Smith" });
            result.Add(new Person() { ID = 2, FirstName = "Peter", LastName = "Smith" });
            result.Add(new Person() { ID = 3, FirstName = "Bob", LastName = "Smith" });
            return result;
        }

        public IList<Person> GetVolunteers(int idEvent)
        {
            List<Person> result = new List<Person>();
            result.Add(new Person() { ID = 1, FirstName = "John", LastName = "Jones" });
            result.Add(new Person() { ID = 2, FirstName = "Peter", LastName = "Jones" });
            result.Add(new Person() { ID = 3, FirstName = "Bob", LastName = "Jones" });
            return result;
        }

        public IList<Sponsor> GetSponsors(int idEvent)
        {
            var results = new List<Sponsor>();

            results.Add(new Sponsor { ID = 1, Name = "Microsoft" });
            results.Add(new Sponsor { ID = 2, Name = "DevExpress" });

            return results;
        }
    }
}