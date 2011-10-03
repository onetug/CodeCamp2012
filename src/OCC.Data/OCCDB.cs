namespace OCC.Data
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class OCCDB : DbContext
    {
        public DbSet<Event> Events { get; set; }

        public DbSet<Person> People { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Announcement>()
                .HasRequired(a => a.Event)
                .WithMany(e => e.Announcements)
                .HasForeignKey(a => a.FK_Event);

            Database.SetInitializer<OCCDB>(new OCCDBInitializer());
        }
    }

    public class OCCDBInitializer : DropCreateDatabaseAlways<OCCDB>
    {
        protected override void Seed(OCCDB context)
        {
            context.People.Add(new Person() { ID = 1, FirstName = "ONETUG", LastName = "Admin", Email = "core@onetug.org" });
            context.People.Add(new Person() { ID = 2, FirstName = "John", LastName = "Smith", Email = "john@onetug.org" });
            context.People.Add(new Person() { ID = 2, FirstName = "Brian", LastName = "Hall", Email = "brian@onetug.org" });
            context.People.Add(new Person() { ID = 2, FirstName = "Zdravko", LastName = "Danev", Email = "z@onetug.org" });

            context.Events.Add(new Event() { ID = 1, Name = "Orlando Code Camp 2011", StartTime = new DateTime(2011, 03, 21), EndTime = new DateTime(2011, 02, 21) });

            context.Events.Add(new Event() { ID = 2, Name = "Orlando Code Camp 2012", StartTime = new DateTime(2012, 03, 25), EndTime = new DateTime(2012, 03, 25) });

            context.Events.Find(2).Announcements.Add(new Announcement() { ID = 7, Title = "First Announcement", Subtitle = "by ONETUG", Content = "This is the first announcement.", PublishDate = new DateTime(2012, 1, 1) });
            context.Events.Find(2).Announcements.Add(new Announcement() { ID = 8, Title = "Second Announcement", Subtitle = "by ONETUG", Content = "This is the second announcement.", PublishDate = new DateTime(2012, 2, 1) });
            context.Events.Find(2).Announcements.Add(new Announcement() { ID = 9, Title = "Third Announcement", Subtitle = "by ONETUG", Content = "This is the third announcement.", PublishDate = new DateTime(2012, 3, 1) });

            context.SaveChanges();
        }
    }
}