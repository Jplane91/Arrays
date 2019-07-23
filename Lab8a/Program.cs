using System;

namespace Lab8
{
    class Program
    {

        static void Main(string[] args)

        {
            string[] names = { "Jake", "Chris", "Jess", "Paula", "Levi"};
            string[] hometown = { "Flushing", "Flint", "Ferndale", "Livonia", "Novi"};
            string[] favortieFood = { "Steak", "Pizza", "Hamburger", "Pasta", "Burrito" };
         
            int input = 1;
            AskforStudent(names);
            AskForMoreInfo(input, hometown, favortieFood);
        }

        public static int AskforStudent(string[] names)
        {
            Console.WriteLine("Enter in a number 1-5");
            int nameInput = int.Parse(Console.ReadLine());
            nameInput = nameInput - 1;
            Console.WriteLine("You have chosen " + names[nameInput]);
            return nameInput;
        }

        //Asks user to enter in what else they want to know about the sudent

        public static void AskForMoreInfo(int nameInput, string[] hometown, string[] favoritefood)
        {
            bool askAgainLoop = true;
            while (askAgainLoop) //Setting up a loop to keep asking for more info, until user declines
            {


                Console.WriteLine("What would you like to know about the student?\n(Enter hometown, favorite food, or none)");
                string moreInfo = Console.ReadLine().ToLower();

                switch (moreInfo)
                {
                    case "hometown":
                        Console.WriteLine("Their hometown is " + hometown[nameInput]);
                        break;

                    case "favorite food":
                        Console.WriteLine("Their favorite food is " + favoritefood[nameInput]);
                        break;

                    case "none":
                        Console.WriteLine("Have a good day");
                        askAgainLoop = false;
                        break;

                    default:
                        Console.WriteLine("That wasn't a valid option");
                        continue;
                }

                Console.WriteLine("Would you like to know more");
                string evenMoreInfo = Console.ReadLine();
                if (evenMoreInfo == "yes")
                {
                    askAgainLoop = true;
                }

                else
                {
                    Console.WriteLine("Have a good day");
                    Console.ReadKey();

                }

            }

        }


    }
}
