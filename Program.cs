using System;
namespace DrawTriangle
{
    static class Program
    {
        // Global variables
        const string symbol = "*";
        static readonly Random random = new Random();

        // Main method
        static void Main(string[] args)
        {
            bool exit = false;
            while (!exit)
            {
                int menuChoice = Menu();
                if (menuChoice == 1)
                {
                    GetFull();
                }
                else if (menuChoice == 2)
                {
                    GetPartial();
                }
                else if (menuChoice == 3)
                {
                    exit = true;
                }
                else
                {
                    System.Console.WriteLine("Invalid input, please try again.");
                }
            }
            System.Console.WriteLine("Thank you for using my program :) ");
        }

        // Display menu and get user input
        static int Menu()
        {
            System.Console.WriteLine("What type of triangle would you like to display?");
            System.Console.WriteLine("  - Enter 1 to generate a full triangle");
            System.Console.WriteLine("  - Enter 2 to generate a partial triangle");
            System.Console.WriteLine("  - Enter 3 to exit the program");
            string input = Console.ReadLine();
            if (!int.TryParse(input, out int choice))
            {
                choice = 0;
            }
            return choice;
        }
        // Generate a full triangle
        static void GetFull()
        {
            int length = random.Next(3, 10);
            int i = 0;
            while (i < length)
            {
                bool symbolPresent = false;
                for (int j = 0; j <= i; j++)
                {
                System.Console.Write(symbol);
                symbolPresent = true;
                }
                if (symbolPresent)
                {
                    System.Console.WriteLine();
                }
                i++;
            }
        }
        // Generate a partial triangle
       static void GetPartial()
       {
            int length = random.Next(3, 10);
            int height = random.Next(3, length+1); //length has to be 1 more than height
            for (int i = 0; i < height; i++)
            {
                bool symbolPresent = false;
                for (int j = 0; j <= i; j++)
                {
                    if (random.Next(2) == 0 || j == i)
                    {
                        System.Console.Write(symbol);
                        symbolPresent = true;
                    }
                    else
                    {
                        System.Console.Write(" ");
                    }
                }
                if (!symbolPresent) //prevents blank triangle being made
                {
                    System.Console.Write(symbol);
                }
                System.Console.WriteLine();
            }
        }
    }
}