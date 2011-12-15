﻿namespace OCC.Data
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class OCCDB : DbContext
    {
        public OCCDB() : base("OCC2012") 
        { 
        
        }

        public DbSet<Event> Events { get; set; }

        public DbSet<Track> Tracks { get; set; }

        public DbSet<Session> Sessions { get; set; }

        public DbSet<Person> People { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Announcement>()
            //    .HasRequired(a => a.Event)
            //    .WithMany(e => e.Announcements)
            //    .HasForeignKey(a => a.FK_Event);

            Database.SetInitializer<OCCDB>(new OCCDBInitializer());
        }
    }

    public class OCCDBInitializer : DropCreateDatabaseAlways<OCCDB>
    {
        protected override void Seed(OCCDB context)
        {
            Person p1 = new Person() 
            { 
                ID = 1, 
                FirstName = "ONETUG", 
                LastName = "Admin", 
                Email = "core@onetug.org" 
            };

            Person p2 = new Person() 
            { 
                ID = 2, 
                FirstName = "John", 
                LastName = "Smith", 
                Email = "john@onetug.org" 
            };

            Person p3 = new Person() 
            { 
                ID = 3, 
                FirstName = "Brian", 
                LastName = "Hall", 
                Email = "brian@onetug.org" 
            };

            Person p4 = new Person() 
            { 
                ID = 4, 
                FirstName = "Zdravko", 
                LastName = "Danev", 
                Email = "z@onetug.org" 
            };

            Person p5 = new Person() 
            { 
                ID = 5, 
                FirstName = "Esteban", 
                LastName = "Garcia", 
                Email = "esteban@onetug.org" 
            };

            Event occ2011 = new Event() 
            { 
                ID = 1, 
                Name = "Orlando Code Camp 2011", 
                StartTime = new DateTime(2011, 03, 21), 
                EndTime = new DateTime(2011, 02, 21),
                Address1 = "Seminole State College",
                Address2 = "100 College Dr",
                City = "Sanford",
                State = "FL",
                Zip = "32746"
            };

            Event occ2012 = new Event()
            { 
                ID = 2, 
                Name = "Orlando Code Camp 2012", 
                StartTime = new DateTime(2012, 03, 25), 
                EndTime = new DateTime(2012, 03, 25),
                Address1 = "Seminole State College",
                Address2 = "100 College Str",
                City = "Sanford",
                State = "FL",
                Zip = "32746"
            };

            occ2011.Announcements.Add(new Announcement() { ID = 1, Title = "Call for speakers", Subtitle = "by ONETUG", Content = "This is the first announcement.", PublishDate = new DateTime(2012, 1, 1) });
            occ2011.Announcements.Add(new Announcement() { ID = 2, Title = "Call for volunteers", Subtitle = "by ONETUG", Content = "This is the second announcement.", PublishDate = new DateTime(2012, 2, 1) });
            occ2011.Announcements.Add(new Announcement() { ID = 3, Title = "Call for attendees", Subtitle = "by ONETUG", Content = "This is the third announcement.", PublishDate = new DateTime(2012, 3, 1) });
            occ2012.Announcements.Add(new Announcement() { ID = 4, Title = "Call for speakers", Subtitle = "by ONETUG", Content = "This is the first announcement.", PublishDate = new DateTime(2012, 1, 1) });
            occ2012.Announcements.Add(new Announcement() { ID = 5, Title = "Call for volunteers", Subtitle = "by ONETUG", Content = "This is the second announcement.", PublishDate = new DateTime(2012, 2, 1) });
            occ2012.Announcements.Add(new Announcement() { ID = 6, Title = "Call for attendees", Subtitle = "by ONETUG", Content = "This is the third announcement.", PublishDate = new DateTime(2012, 3, 1) });

            Track t1 = new Track { ID = 11, Name = "Windows Phone 7", Description = "Windows Phone 7 development" };
            Track t2 = new Track { ID = 12, Name = "Windows 8", Description = "Windows 8 development" };
            Track t3 = new Track { ID = 13, Name = "Architecture", Description = "Architecture, P and P" };

            t1.Sessions.Add(new Session() { ID = 1, Name = "Silverlight for WP7", Description = "Introduction in Silverlight programming with windows phone 7", Speaker = p2 });
            t1.Sessions.Add(new Session() { ID = 2, Name = "XNA for WP7", Description = "Introduction in XNA programming with windows phone 7", Speaker = p3 });
            t2.Sessions.Add(new Session() { ID = 3, Name = "Intro in Win 8", Description = "Introduction in Windows 8", Speaker = p4 });
            t3.Sessions.Add(new Session() { ID = 4, Name = "P & P", Description = "Patterns and practices", Speaker = p5 });

            occ2012.Tracks.Add(t1);
            occ2012.Tracks.Add(t2);
            occ2012.Tracks.Add(t3);

            context.People.Add(p1);
            context.People.Add(p2);
            context.People.Add(p3);
            context.People.Add(p4);
            context.People.Add(p5);

            context.Events.Add(occ2011);
            context.Events.Add(occ2012);

            context.SaveChanges();
        }
    }
}