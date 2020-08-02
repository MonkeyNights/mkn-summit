using System;
using System.Collections.Generic;

namespace MknSummit.Core.Models
{
    public class Speaker : CommunityPerson { }
    public class Organizer : CommunityPerson { }

    public class CommunityPerson
    {
        public string Name { get; private set; }
        public string Avatar { get; private set; }
        public string Bio { get; private set; }
        public string Position { get; private set; }
        public List<SocialMedia> SocialProfiles { get; private set; }

        public CommunityPerson()
        {
            SocialProfiles = new List<SocialMedia>();
        }
    }
}
