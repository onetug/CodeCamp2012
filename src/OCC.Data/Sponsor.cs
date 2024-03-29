﻿namespace OCC.Data
{
    using System.ComponentModel.DataAnnotations;

    public class Sponsor
    {
        public int ID { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(2000)]
        public string Description { get; set; }

        [StringLength(100)]
        public string SponsorshipLevel { get; set; }

        [StringLength(100)]
        public string ImageUrl { get; set; }

        [StringLength(100)]
        public string WebsiteUrl { get; set; }
    }
}