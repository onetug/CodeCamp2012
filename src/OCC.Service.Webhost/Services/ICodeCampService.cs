namespace OCC.Service.Webhost.Services
{
    using System;
    using System.Collections.Generic;
    using System.ServiceModel;

    [ServiceContract(Namespace = "http://onetug.org/2012/CodeCampService")]
    public interface ICodeCampService
    {
        // Person

        [OperationContract]
        void RegisterPerson(Person person);

        [OperationContract]
        Person Login(Person person);

        [OperationContract]
        void ChangePassword(int personId, string oldPassword, string newPassword);

        [OperationContract]
        void UpdatePerson(Person person);

        [OperationContract]
        void DeletePerson(int personId);

        [OperationContract]
        Person FindPersonByEmail(string email);

        // Events

        [OperationContract]
        IList<Event> GetEvents(DateTime fromDate, DateTime toDate);

        [OperationContract]
        void CreateEvent(Event _event);
        
        [OperationContract]
        Event GetEvent(int idEvent);

        [OperationContract]
        void UpdateEvent(Event _event);

        // Track

        [OperationContract]
        Track GetTrack(int id);

        [OperationContract]
        IList<Track> GetTracks(int idEvent);

        [OperationContract]
        IList<Track> GetTracksWithSessions(int idEvent);

        // Session

        [OperationContract]
        Session GetSession(int id);

        // Speaker

        [OperationContract]
        Speaker GetSpeaker(int id);

        // ...

        [OperationContract]
        IList<Announcement> GetAnnouncements(int idEvent);

        [OperationContract]
        IList<Session> GetSessions(int idEvent);

        [OperationContract]
        IList<Person> GetSpeakers(int idEvent);

        [OperationContract]
        IList<Person> GetVolunteers(int idEvent);

        [OperationContract]
        IList<Sponsor> GetSponsors(int idEvent);
    }
}