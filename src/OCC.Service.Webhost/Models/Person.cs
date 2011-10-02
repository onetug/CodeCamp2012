namespace OCC.Service.Webhost.Models
{
    using System.Collections.Generic;

    public class Person
    {
        public int ID { get; set; }

        public string Email { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Title { get; set; }

        public string Bio { get; set; }

        public string Website { get; set; }

        public string Blog { get; set; }

        public string Twitter { get; set; }

        public string PasswordHash { get; set; }

        public string ImageUrl { get; set; }

        public bool IsAdmin { get; set; }

        public virtual IList<Session> Agenda { get; set; }

        public Person()
        {
            Agenda = new List<Session>();
        }
    }
}