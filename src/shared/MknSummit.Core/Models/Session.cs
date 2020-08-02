using System;
using System.Collections.Generic;

namespace MknSummit.Core.Models
{
    public class Session
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public List<string> Tags { get; set; }
        public List<Speaker> Speakers { get; set; }
        public string SlidesUrl { get; set; }

        public Session()
        {
            Tags = new List<string>();
            Speakers = new List<Speaker>();
        }

        public static Session Create(
                string title
                , string description
                , List<string> tags
                , List<Speaker> speakers
                , string slidesUrl) =>
                new Session
                {
                    Title = title,
                    Description = description,
                    Tags = tags,
                    Speakers = speakers,
                    SlidesUrl = slidesUrl
                };
    }
}