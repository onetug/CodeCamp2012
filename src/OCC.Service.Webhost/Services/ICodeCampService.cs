using System.Web.Security;

namespace OCC.Service.Webhost.Services
{
    using System;
    using System.Collections.Generic;
    using System.ServiceModel;

    [ServiceContract]
    public interface ICodeCampService
    {
        // Person

        [OperationContract]
        void RegisterPerson(Person person);

        [OperationContract]
        Models.Person Login(Person person);

        [OperationContract]
        void ChangePassword(int personId, string oldPassword, string newPassword);

        [OperationContract]
        void UpdatePerson(Person person);

        [OperationContract]
        void DeletePerson(int personId);

        [OperationContract]
        Models.Person FindPersonByEmail(string email);

        // Events

        [OperationContract]
        IList<Event> GetEvents(DateTime fromDate, DateTime toDate);

        [OperationContract]
        void CreateEvent(Event _event);
        
        [OperationContract]
        Event GetEvent(int idEvent);

        [OperationContract]
        void UpdateEvent(Event _event);

        // ...

        [OperationContract]
        IList<Announcement> GetAnnouncements(int idEvent);

        [OperationContract]
        IList<Session> GetSessions(int idEvent);

        [OperationContract]
        IList<Person> GetSpeakers(int idEvent);

        [OperationContract]
        IList<Sponsor> GetSponsors(int idEvent);
    }
}