using System;
using System.Collections.Generic;

namespace MknSummit.Core.Models
{
    public class Session
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public List<string> Tags { get; set; }
        public Speaker Speaker { get; set; }
        public string SlidesUrl { get; set; }

        public Session()
        {
            Tags = new List<string>();
        }
    }
}