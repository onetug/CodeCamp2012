namespace OCC.Service.Webhost.Tools
{
    using System.Reflection;

    using OCC.Service.Webhost.Services;

    public static class Mapper
    {
        public static void CopyProperties(object from, object to)
        {
            foreach (PropertyInfo source in from.GetType().GetProperties())
            {
                PropertyInfo target = to.GetType().GetProperty(source.Name);

                if (target != null)
                {
                    if (source.PropertyType.FullName == target.PropertyType.FullName)
                    {
                        var v = source.GetValue(from, null);
                        target.SetValue(to, v, null);
                    }
                    else
                    {
                        var a = source.GetValue(from, null);
                        var b = target.GetValue(to, null);

                        CopyProperties(a, b);
                    }
                }
            }
        }

        public static Event AsEvent(this OCC.Data.Event e)
        {
            Event result = new Event()
            {
                ID = e.ID,
                Name = e.Name,
                Description = e.Description,
                TwitterHashTag = e.TwitterHashTag,
                StartTime = e.StartTime,
                EndTime = e.EndTime,
                Location = e.Location,
                Address1 = e.Address1,
                Address2 = e.Address2,
                City = e.City,
                State = e.State,
                Zip = e.Zip
            };

            //  TODO: copy collections if not null

            return result;
        }

        public static Track AsTrack(this OCC.Data.Track t)
        {
            Track track = new Track()
            {
                ID = t.ID,
                Name = t.Name,
                Description = t.Description
            };

            return track;
        }

        public static Track AsTrackWithSessions(this OCC.Data.Track t)
        {
            Track track = new Track()
            {
                ID = t.ID,
                Name = t.Name,
                Description = t.Description
            };

            foreach (var sesion in t.Sessions)
                track.Sessions.Add(sesion.AsSession());

            return track;
        }

        public static Session AsSession(this OCC.Data.Session s)
        {
            Session session = new Session()
            {
                ID = s.ID,
                Name = s.Name,
                Description = s.Description,
                Location = s.Location,
                Speaker = s.Speaker.FirstName + " " + s.Speaker.LastName,
                SpeakerID = s.Speaker.ID
                // starttime, endtime, level
            };

            return session;
        }

        public static Speaker AsSpeaker(this OCC.Data.Person p)
        {
            Speaker speaker = new Speaker()
            {
                ID = p.ID,
                Email = p.Email,
                Name = p.FirstName + " " + p.LastName,
                Title = p.Title,
                Bio = p.Bio,
                Website = p.Website,
                Blog = p.Blog,
                Twitter = p.Twitter,
                ImageUrl = p.ImageUrl
            };

            // TODO: copy sessions

            return speaker;
        }
    }
}