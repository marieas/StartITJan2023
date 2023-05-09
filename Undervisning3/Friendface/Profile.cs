using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace annetNamespace
{
    public class Profile
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string RelationshipStatus { get; set; }
        public string Address { get; set; }
        public List<Profile> Friends { get; set; }
     
        public Profile(string name)
        {
            Name = name;
            Friends = new List<Profile>();
        }
        public void AddFriend(Profile friendToAdd)
        {
            Friends.Add(friendToAdd);
        }

        public void RemoveFriend()
        {

        }

    }
}
