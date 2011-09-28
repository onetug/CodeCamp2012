namespace OCC.Service.Webhost.Services
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using OCC.Service.Webhost.Models;
    using OCC.Service.Webhost.Tools;

    public class CodeCampService : ICodeCampService
    {
        // Person

        public void RegisterPerson(Person person)
        {
            throw new NotImplementedException();
        }

        public Person Login(string email, string password)
        {
            return new Person() { ID = 1, FirstName = "John", LastName = "Smith", Email = email, Title = "Developer", Bio = "John's bio" };
        }

        public void ChangePassword(int id, string oldPassord, string newPassword)
        {
            throw new NotImplementedException();
        }

        public void UpdatePerson(Person person)
        {
            throw new NotImplementedException();
        }

        public void DeletePerson(int idPerson)
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

        public Event GetEvent(int idEvent)
        {
            using (OCCDB db = new OCCDB())
            {
                var e = db.Events.Find(idEvent);
                var result = new Event();
                Mapper.CopyProperties(e, result);

                return result;
            }
        }

        public void UpdateEvent(Event _event)
        {
            throw new NotImplementedException();
        }

        // ... 

        public IList<Announcement> GetAnnouncements(int idEvent)
        {
            using (OCCDB db = new OCCDB())
            {
                var result = new List<Announcement>();

                result.Add(new Announcement() { Title = "First Announcement", Subtitle = "by ONETUG", Content = "This is the first announcement." });
                result.Add(new Announcement() { Title = "Second Announcement", Subtitle = "by ONETUG", Content = "This is the second announcement." });
                result.Add(new Announcement() { Title = "Third Announcement", Subtitle = "by ONETUG", Content = "This is the third announcement." });

                return result;
            }
        }

        public IList<Session> GetSessions(int idEvent)
        {
            using (OCCDB db = new OCCDB())
            {
                var sessions = db.Events.Find(idEvent).Sessions
                    .OrderBy(s => s.Track)
                    .OrderBy(s => s.StartTime)
                    .ToList();

                var result = new List<Session>();

                foreach (var session in sessions)
                {
                    Session s = new Session();
                    Mapper.CopyProperties(session, s);
                    result.Add(s);
                }

                return result;
            }
        }

        public IList<Person> GetSpeakers(int idEvent)
        {
            using (OCCDB db = new OCCDB())
            {
                var speakers = (from session in db.Events.Find(idEvent).Sessions
                        select session.Speaker)
                        .Distinct()
                        .OrderBy(s => s.FirstName + " " + s.LastName)
                        .ToList();

                var result = new List<Person>();

                foreach (var speaker in speakers)
                {
                    Person s = new Person();
                    Mapper.CopyProperties(speaker, s);
                    result.Add(s);
                }

                return result;
            }
        }

        public IList<Sponsor> GetSponsors(int idEvent)
        {
            var sponsorList = new List<Sponsor>(2);

            sponsorList.Add(new Sponsor { Name = "Microsoft" });
            sponsorList.Add(new Sponsor { Name = "DevExpress" });

            return sponsorList;
        }
    }
}