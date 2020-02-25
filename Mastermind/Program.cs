using System;

namespace Mastermind
{
    class Program
    {
        static void Main(string[] args)
        {
            int ran1, ran2, ran3, ran4;
            int userInput;
            int user1, user2, user3, user4;
            string correctPositions = "";
            Console.WriteLine("Welcome to Mastermind");

            Random r = new Random();
            ran1 = r.Next(1, 7);
            ran2 = r.Next(1, 7);
            ran3 = r.Next(1, 7);
            ran4 = r.Next(1, 7);

            Console.WriteLine("4 digit input with numbers 1-6 have been determined.");
            Console.WriteLine("The input is " +ran1+ran2+ran3+ran4);
            Console.WriteLine("Enter your four digit guess");
            userInput = Convert.ToInt32(Console.ReadLine());
         
            user1 = userInput / 1000;
            userInput = userInput - (user1 * 1000);
            user2 = userInput / 100;
            userInput = userInput - (user2 * 100);
            user3 = userInput / 10;
            userInput = userInput - (user3 * 10);
            user4 = userInput % 10;

            Console.WriteLine("The output is " + user1 + " " + user2 + " " + user3 + " " + user4);
            if(user1 == ran1)
            {
                correctPositions = correctPositions + "+";   
            }
            else if(user1 == ran2 || user1 == ran3 || user1 == ran4)
            {
                correctPositions = correctPositions + "-";
            }

            if(user2 == ran2)
            {
                correctPositions = correctPositions + "+";
            }
            else if(user2 == ran1 || user2 == ran3 || user2 == ran4)
            {
                correctPositions = correctPositions + "-";
            }

            if(user3 == ran3)
            {
               correctPositions = correctPositions + "+";
            }
            else if (user3 == ran1 || user3 == ran2 || user3 == ran4)
            {
                correctPositions = correctPositions + "-";
            }

            if (user4 == ran4)
            {
                correctPositions = correctPositions + "+";
            }
            else if (user4 == ran1 || user4 == ran2 || user4 == ran3)
            {
                correctPositions = correctPositions + "-";
            }

            Console.WriteLine(correctPositions);
        }
    }
}
