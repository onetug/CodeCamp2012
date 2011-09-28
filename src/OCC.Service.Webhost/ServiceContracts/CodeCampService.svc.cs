namespace OCC.Service.Webhost
{
    using System;
    using System.Collections.Generic;

    using OCC.Service.Webhost.Models;

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
            throw new NotImplementedException();
        }

        public void UpdateEvent(Event _event)
        {
            throw new NotImplementedException();
        }

        // ... 

        public IList<Announcement> GetAnnouncements(int idEvent)
        {
            var result = new List<Announcement>();
            
            result.Add(new Announcement() { Title = "First Announcement", Subtitle = "by ONETUG", Content = "This is the first announcement." });
            result.Add(new Announcement() { Title = "Second Announcement", Subtitle = "by ONETUG", Content = "This is the second announcement." });
            result.Add(new Announcement() { Title = "Third Announcement", Subtitle = "by ONETUG", Content = "This is the third announcement." });
            
            return result;
        }

        public IList<Session> GetSessions(int idEvent)
        {
            throw new NotImplementedException();
        }

        public IList<Person> GetSpeakers(int idEvent)
        {
            throw new NotImplementedException();
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