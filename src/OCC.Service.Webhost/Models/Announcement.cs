﻿namespace OCC.Service.Webhost.Models
{
    using System;

    public class Announcement
    {
        public int ID { get; set; }

        public string Title { get; set; }

        public string Subtitle { get; set; }

        public string Content { get; set; }

        public DateTime PublishDate { get; set; }
    }
}