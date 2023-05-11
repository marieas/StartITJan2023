
using annetNamespace;

var socialMediaAccounts = new List<Profile>();
InitializeAccounts();

//Innlogget bruker
var mainProfile = new Profile("Kåre", 25, "single");
RunShit();

void RunShit()
{
    bool isRunning = true;
    while (isRunning)
    {
        PrintMenu();
        Console.Beep();
        Console.WriteLine();
        var input = Console.ReadLine();

        if (input == "1")
        {
            AddFriendMenu();
        }
        else if (input == "2")
        {
            RemoveUserMenu();
        }
        else if (input == "3")
        {
            mainProfile.PrintFriends();
        }
        else if (input == "4")
        {
            PrintFriendInfoMenu();
        }
        else
        {
            isRunning = false;
        }
    }
}
void PrintMenu()
{
    Console.WriteLine($"Welcome to Friendface {mainProfile.Name}");
    Console.WriteLine("1. Add friend");
    Console.WriteLine("2. Remove friend");
    Console.WriteLine("3. Print friends");
    Console.WriteLine("4. Show friend info");
}
void RemoveUserMenu()
{
    Console.WriteLine("Please select the user you want to remove");
    mainProfile.PrintFriends();
    var chosenIndex = int.Parse(Console.ReadLine());
    mainProfile.RemoveFriend(chosenIndex);
}

void PrintUsers()
{
    for (var i = 0; i < socialMediaAccounts.Count; i++)
    {
        Console.WriteLine($"{i} {socialMediaAccounts[i].Name}");
    }
}
void AddFriendMenu()
{
    Console.WriteLine("Please select the user you want to add");
    PrintUsers();
    var chosenIndex = int.Parse(Console.ReadLine());
    var profileToAdd = socialMediaAccounts[chosenIndex];
    mainProfile.AddFriend(profileToAdd);
}
void PrintFriendInfoMenu()
{
    mainProfile.PrintFriends();
    var profileIndex = int.Parse(Console.ReadLine());
    var selectedFriend = mainProfile.GetSelectedFriend(profileIndex);
    selectedFriend.PrintProfileInfo();
}
void InitializeAccounts()
{
    socialMediaAccounts.Add(new Profile("Bjarne", 25, "single"));
    socialMediaAccounts.Add(new Profile("Kurt", 25, "single"));
    socialMediaAccounts.Add(new Profile("Stig", 25, "single"));
    socialMediaAccounts.Add(new Profile("Nils", 25, "single"));
}