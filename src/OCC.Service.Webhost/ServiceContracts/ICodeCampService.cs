﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using OCC.Service.Webhost.Models;

namespace OCC.Service.Webhost
{
    [ServiceContract]
    public interface ICodeCampService
    {
        // Person

        [OperationContract]
        void RegisterPerson(Person person);

        [OperationContract]
        Person Login(string email, string password);

        [OperationContract]
        void ChangePassword(int idPerson, string oldPassword, string newPassword);

        [OperationContract]
        void UpdatePerson(Person person);

        [OperationContract]
        void DeletePerson(int idPerson);

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