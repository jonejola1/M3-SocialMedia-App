using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static M3_SocialMedia_App.FriendFace;

namespace UserPromt
{
    public static class UserPromts
    {
        public static string AskName(string question)
        {
            Console.WriteLine(question);
            return Console.ReadLine();
        }

        public static string PrintAction()
        {
            Console.WriteLine("1: Add Friend");
            Console.WriteLine("2: Remove Friend");
            Console.WriteLine("3: Show Friend list");
            Console.WriteLine("4: More Info about friend");

            Console.WriteLine("Input number for action:");
            Console.WriteLine("or 'n' to exit");

            return Console.ReadLine();

        }

        public static string AddFriendPromt()
        {
            Console.WriteLine("What is your friend's name? ");
            return Console.ReadLine();
        }

        public static string FriendAddedPromt(string Name)
        {
            Console.WriteLine(Name + " is added in your friend list.");
            Console.WriteLine();
            Console.WriteLine("Do you want to find a new friend y/n");

            return Console.ReadLine();
        }

        public static void RemoveFriendPromt()
        {
            Console.WriteLine("Input the person you want to remove");
            Console.WriteLine("n for cancel");
            string removeFriendInput = Console.ReadLine();

            if (removeFriendInput == "n") actionPromt();

            int friendIndex = Convert.ToInt32(removeFriendInput);
            friendList.RemoveAt(friendIndex);

            Console.WriteLine(friendList[friendIndex] + " har blitt fjernet fra listen.");
            Console.WriteLine("press any button to continue.");
            Console.ReadLine();

            actionPromt();
        }

        public static void ShowFriendsPromt()
        {
            Console.WriteLine("Return to main 'n'");
            string continueInput = Console.ReadLine();

            if (continueInput == "n" || continueInput == "N") actionPromt();
        }

    }
}
