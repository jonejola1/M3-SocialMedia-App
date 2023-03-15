
using static UserPromt.UserPromts;

namespace M3_SocialMedia_App
{
    public class FriendFace
    {
        static string username = "";


        public static List<string> friendList = new List<string>();


        public static void LoginPromt()
        {
            username = AskName("Enter your name to login to FriendFace.");
            Console.WriteLine("Welcome to FriendFace " + username);

            actionPromt();
        }

        public static void actionPromt()
        {
            var actionPromtInput = PrintAction();

            ActionHandler(actionPromtInput);
        }

        static void ActionHandler(string userInput)
        {
            switch (userInput)
            {
                case "1":
                    AddFriend();
                    break;
                case "2":
                    RemoveFriend();
                    break;
                case "3":
                    ShowFriendList();
                    break;
                case "4":
                    ShowFriendInfo();
                    break;
                case "n":
                    break;
                default:
                    Console.WriteLine("invalid input, try again!");
                    actionPromt();
                    break;
            }
        }

        private static void AddFriend()
        {
            string userFriendInput = AddFriendPromt();

            friendList.Add(userFriendInput);

            string continueCheck = FriendAddedPromt(userFriendInput);

            if (continueCheck == "y" || continueCheck == "Y") AddFriend();

            actionPromt();
        }

        private static void RemoveFriend()
        {
            if (friendList.Count == 0)
            {
                Console.WriteLine("There are no more people in your friendList to remove");
                Console.ReadLine();
                actionPromt();
            }

            Console.WriteLine("Who do you want to remove:");
            var i = 0;
            foreach (var friend in friendList)
            {
                Console.WriteLine(i + ": " + friend);
                i++;
            }

            RemoveFriendPromt();
        }
        private static void ShowFriendList()
        {
            var i = 0;
            foreach (var friend in friendList)
            {
                Console.WriteLine(i + ": " + friend);
                i += 1;
            }

            ShowFriendsPromt();
        }

        private static void ShowFriendInfo()
        {
            if (friendList.Count == 0)
            {
                Console.WriteLine("There are no friends in you friendList");
                Console.WriteLine("Press any Key to continue!");
                Console.ReadLine();
                actionPromt();
            }

            Console.WriteLine("Which person do you want to inspect?");

            var i = 0;
            foreach (var friend in friendList)
            {
                Console.WriteLine(i + ": " + friend);
                i++;
            }

            Console.WriteLine("or go back with 'n'");

            string userInput = Console.ReadLine();
            if (userInput == "n" || userInput == "N") actionPromt();

            switch (userInput)
            {
                case "0":
                    Console.WriteLine(friendList[0] + ": lover of sports and like to take a beer in the pub when im feeling for it.");
                    GoBack();
                    break;
                case "1":
                    Console.WriteLine(friendList[1] + ": You will see the fragments when i explode");
                    GoBack();
                    break;
                case "2":
                    Console.WriteLine(friendList[1] + ": Hey there!");
                    GoBack();
                    break;
                case "3":
                    Console.WriteLine(friendList[1] + ": likes to play games in my spare time, and enjoys a cold shower after gym");
                    GoBack();
                    break;
            }
            static void GoBack()
            {
                Console.WriteLine("press a key to go back");
                Console.ReadKey();
                ShowFriendInfo();
            }

        }
    }
}
