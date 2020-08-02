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
        public Dictionary<SocialMedia, string> SocialProfiles { get; private set; }

        public CommunityPerson()
        {
            SocialProfiles = new Dictionary<SocialMedia, string>();
        }

        public static CommunityPerson Create(
                string name
                , string avatar
                , string bio
                , string position
                , Dictionary<SocialMedia, string> socialProfiles) =>
                new CommunityPerson
                {
                    Name = name,
                    Avatar = avatar,
                    Bio = bio,
                    Position = position,
                    SocialProfiles = socialProfiles
                };
    }
}
