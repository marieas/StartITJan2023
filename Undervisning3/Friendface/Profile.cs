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
     
        public Profile(string name, int age, string relationshipstatus)
        {
            Name = name;
            Friends = new List<Profile>();
            Age = age;
            RelationshipStatus = relationshipstatus;
        }

        public void PrintProfileInfo()
        {
            Console.WriteLine($"Name: {Name} Age: {Age} Relationshipstatus {RelationshipStatus}");
        }

        public void PrintFriends()
        {
            for (var i = 0; i < Friends.Count; i++)
            {
                Console.WriteLine($"{i} {Friends[i].Name}");
            }
        }
        public void AddFriend(Profile friendToAdd)
        {
            Friends.Add(friendToAdd);
        }

        public void RemoveFriend(int index)
        {
            Friends.RemoveAt(index);
        }

        public Profile GetSelectedFriend(int index)
        {
            var friend = Friends[index];
            return friend;
        }

    }
}
