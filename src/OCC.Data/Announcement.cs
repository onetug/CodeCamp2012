namespace OCC.Data
{
    using System;
    // using System.Data.Entity.ModelConfiguration;
    using System.ComponentModel.DataAnnotations;

    public class Announcement
    {
        public int ID { get; set; }

        [StringLength(100)]
        public string Title { get; set; }

        [StringLength(100)]
        public string Subtitle { get; set; }

        [StringLength(2000)]
        public string Content { get; set; }

        public DateTime PublishDate { get; set; }

        // public int FK_Event { get; set; }

        // public virtual Event Event { get; set; }
    }

    //public class AnnouncementConfiguration : EntityTypeConfiguration<Announcement>
    //{
    //    internal AnnouncementConfiguration()
    //    {
    //        this.HasRequired(a => a.Event)
    //            .WithMany(e => e.Announcements)
    //            .HasForeignKey(a => a.FK_Event);
    //    }
    //}
}