
using static M3_SocialMedia_App.FriendFace;

namespace M3_SocialMedia_App
{
    public abstract class UserPromts
    {
        public static string? AskName(string question)
        {
            Console.WriteLine(question);
            return Console.ReadLine();
        }

        public static string? PrintAction()
        {
            Console.WriteLine("1: Add Friend");
            Console.WriteLine("2: Remove Friend");
            Console.WriteLine("3: Show Friend list");
            Console.WriteLine("4: More Info about friend");

            Console.WriteLine("Input number for action:");
            Console.WriteLine("or 'n' to exit");

            return Console.ReadLine();

        }

        public static string? AddFriendPromt()
        {
            Console.WriteLine("What is your friend's name? ");
            Console.WriteLine("Enter empty value to cancel");
            return Console.ReadLine();
        }

        public static void cancelAddFriend()
        {
            Console.WriteLine("cancelled action");
            Console.WriteLine("press any key to continue");
            ActionPromt();
        }

        public static string? FriendAddedPromt(string name)
        {
            Console.WriteLine(name + " is added in your friend list.");
            Console.WriteLine();
            Console.WriteLine("Do you want to find a new friend y/n");

            return Console.ReadLine();
        }

        public static void RemoveFriendPromt()
        {
            Console.WriteLine("Input the person you want to remove");
            Console.WriteLine("n for cancel");
            var removeFriendInput = Console.ReadLine();

            if (removeFriendInput is "n" or "N") ActionPromt();

            var friendIndex = Convert.ToInt32(removeFriendInput);
            FriendList.RemoveAt(friendIndex);

            Console.WriteLine(FriendList[friendIndex] + " har blitt fjernet fra listen.");
            Console.WriteLine("press any button to continue.");
            Console.ReadLine();

            ActionPromt();
        }

        public static void ShowFriendsPromt()
        {
            Console.WriteLine("Return to main 'n'");
            var continueInput = Console.ReadLine();

            if (continueInput is "n" or "N") ActionPromt();
        }

    }
}
