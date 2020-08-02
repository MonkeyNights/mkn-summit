using System;

namespace MknSummit.Core.Models
{
    public class SocialMedia
    {
        public string Url { get; set; }
        public int Type
        {
            get
            {
                return Url switch
                {
                    string tw when tw.Contains("twitter", StringComparison.InvariantCultureIgnoreCase) => 1,
                    string fb when fb.Contains("facebook", StringComparison.InvariantCultureIgnoreCase) => 2,
                    string gh when gh.Contains("github", StringComparison.InvariantCultureIgnoreCase) => 3,
                    string lk when lk.Contains("linkedin", StringComparison.InvariantCultureIgnoreCase) => 4,
                    _ => 0,
                };
            }
        }
    }
}


