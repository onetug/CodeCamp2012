namespace OCC.Service.Webhost.Models
{
    using System.Data.Entity;
    using System.Linq;

    public class OCCDB : DbContext
    {
        public DbSet<Event> Events { get; set; }

        public DbSet<Person> People { get; set; }
    }
}