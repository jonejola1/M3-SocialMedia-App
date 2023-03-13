using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace M3_SocialMedia_App
{
    public class FriendFace
    {
        public string username = "";

        static List<string> friendList = new List<string>();


        public static char continueCheck { get; set; }

        public static void LoginPromt()
        {
            Console.WriteLine("Enter your name to login to FriendFace.");
            string username = Console.ReadLine();

            Console.WriteLine("Welcome to FriendFace " + username);

            actionPromt();
        }

        static void actionPromt()
        {
            Console.WriteLine("1: Add Friend");
            Console.WriteLine("2: Remove Friend");
            Console.WriteLine("3: Show Friend list");
            Console.WriteLine("4: More Info about friend");

            Console.WriteLine("Input number for action:");
            int actionPromtUserInput = Convert.ToInt32(Console.ReadLine());

            actionHandler(actionPromtUserInput);
        }

        static void actionHandler(int userInput)
        {
            switch (userInput)
            {
                case 1:
                    addFriend();
                    break;
                case 2:
                    removeFriend();
                    break;
                case 3:
                    showFriendList();
                    break;
                case 4:
                    showFriendInfo();
                    break;
                default:
                    break;
            }

        }

        static void addFriend()
        {
            Console.WriteLine("What is your friend's name? ");
            string userFriendInput = Console.ReadLine();

            friendList.Add(userFriendInput);


            Console.WriteLine(userFriendInput + " is added in your friend list.");
            Console.WriteLine();
            Console.WriteLine("Do you want to find a new friend y/n");
            var continueCheck = Console.ReadLine();

            if (continueCheck == "y" || continueCheck == "Y")
            {
                addFriend();
            }

            actionPromt();
        }

        static void removeFriend()
        {
            if (friendList.Count == 0) 
            {
                Console.WriteLine("There are no more people in your friendList to remove");
                Console.ReadLine();
                actionPromt();
            }
            Console.WriteLine("what friend do you want to remove:");
            foreach (var friend in friendList)
            {
                int i = 0;
                Console.WriteLine(i + ": " + friend);
                i++;
            }

            Console.WriteLine("Input the friend you want to remove");
            Console.WriteLine("n for cancel");
            var removeFriendInput = Console.ReadLine();


            if (removeFriendInput == "n")
            {
                actionPromt();
            }
            if (removeFriendInput < friendList.length) { }

            friendList.Remove(removeFriendInput);

            Console.WriteLine("Do you want to remove more friends y/n");
            char continueInput = Convert.ToChar(Console.ReadLine());
            if (continueInput == 'n' || continueInput == 'N')
            {
                actionPromt();
            }

            removeFriend();
        }
        static void showFriendList()
        {
            foreach (var friend in friendList)
            {
                int i = 0;
                Console.WriteLine(i + ": " + friend);
                i += 1;
            }
            Console.WriteLine("Return to main 'n'");
            char continueInput = Convert.ToChar(Console.ReadLine());

            if (continueInput == 'n' || continueInput == 'N')
            {
                actionPromt();
            }
        }

        static void showFriendInfo()
        {
            if (friendList.Count == 0)
            {
                Console.WriteLine("There are no friends in you friendList");
                Console.WriteLine("Press any Key to continue!");
                Console.ReadLine();
                actionPromt();
            }
            Console.WriteLine("Which status do you want to inspect?");

            foreach (var friend in friendList)
            {
                int i = 0;
                Console.WriteLine(i + ": " + friend);
                i++;

            }

            Console.WriteLine("or go back with 'n'");

            var userInput = Console.ReadLine();
            if (userInput == "n" || userInput == "N")
            {
                actionPromt();
            }

            int profileInput = Convert.ToInt32(userInput);

            switch (profileInput)
            {
                case 0:
                    Console.WriteLine(friendList[0] + ": lover of sports and like to take a beer in the pub when im feeling for it.");
                    goBack();
                    break;
                case 1:
                    Console.WriteLine(friendList[1] + ": You will see the fragments when i explode");
                    goBack();
                    break;
                case 2:
                    Console.WriteLine(friendList[1] + ": Hey there!");
                    goBack();
                    break;
                case 3:
                    Console.WriteLine(friendList[1] + ": likes to play games in my sparetime, and enjoys a cold shower after gym");
                    goBack();
                    break;
            }
            void goBack()
            {
                Console.WriteLine("press a key to go back");
                Console.ReadKey();
                showFriendInfo();
            }

        }
    }
}
