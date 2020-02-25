using System;

namespace Mastermind
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables to hold the randomly generated sequence for Mastermind
            int ran1, ran2, ran3, ran4;
            
            //keeps track of how many guesses the player has left.
            int turnCounter = 0;

            Boolean gameWon = false;

            Console.WriteLine("Welcome to Mastermind");

            //determines the 4 number sequence to be guessed
            Random r = new Random();
            ran1 = r.Next(1, 7);
            ran2 = r.Next(1, 7);
            ran3 = r.Next(1, 7);
            ran4 = r.Next(1, 7);

            Console.WriteLine("4 digit input with numbers 1-6 have been determined.");

            //enters a while loop that the player will not exit unless they guess the correct sequence or 
            //run out of guesses.
            while (turnCounter < 10)
            {
                //calls the guess processes method to be returned as a boolean type variable 
                gameWon = Program.guessProcess(ran1, ran2, ran3, ran4);

                //determines if the player has won the game or not 
                if(gameWon == true)
                {
                    //breaks from the loop if they have won 
                    break;
                }

                //keeps track of the remaining guesses the player has 
                turnCounter++;
                Console.WriteLine("You have " + (10 - turnCounter) + " guesses remaining.");
                Console.WriteLine();
            }

            //displays either a victory or defeat message depending on if the player has won or not 
         if (gameWon == true)
            {
                Console.WriteLine("Congratulations, you have guessed the correct code, it was " + ran1 + ran2 + ran3 + ran4);
            }
         else
            {
                Console.WriteLine("You lost :(, the correct input was " + ran1 + ran2 + ran3 + ran4);
            }
        }

        //allows the user to guess the hidden sequence of numbers. Takes the random sequence as parameters
       private static Boolean guessProcess(int ran1, int ran2, int ran3, int ran4)
        {
            //displays the + and - signs for correct guesses
            string correctPositions = "";

            int userInput;

            //the separated user guess will be held in these variables 
            int user1, user2, user3, user4;

            //keeps track of the right numbers and positions guessed
            int correct = 0;

            Console.WriteLine("Enter your four digit guess (Only enter 4 digits and numbers between 1-6)");

            //Takes user input and converts it into an integer 
            userInput = Convert.ToInt32(Console.ReadLine());

            //takes the user input and separates it into 4 different digits
            user1 = userInput / 1000;
            userInput = userInput - (user1 * 1000);
            user2 = userInput / 100;
            userInput = userInput - (user2 * 100);
            user3 = userInput / 10;
            userInput = userInput - (user3 * 10);
            user4 = userInput % 10;

            //if/else statements to determine if the numbers entered are correct guesses 
            if (user1 == ran1)
            {
                correctPositions = correctPositions + "+";
                correct++;
            }
            else if (user1 == ran2 || user1 == ran3 || user1 == ran4)
            {
                correctPositions = correctPositions + "-";
            }

            if (user2 == ran2)
            {
                correctPositions = correctPositions + "+";
                correct++;
            }
            else if (user2 == ran1 || user2 == ran3 || user2 == ran4)
            {
                correctPositions = correctPositions + "-";
            }

            if (user3 == ran3)
            {
                correctPositions = correctPositions + "+";
                correct++;
            }
            else if (user3 == ran1 || user3 == ran2 || user3 == ran4)
            {
                correctPositions = correctPositions + "-";
            }

            if (user4 == ran4)
            {
                correctPositions = correctPositions + "+";
                correct++;
            }
            else if (user4 == ran1 || user4 == ran2 || user4 == ran3)
            {
                correctPositions = correctPositions + "-";
            }

            Console.WriteLine("Your result " + correctPositions);

            //if the user has guessed all 4 numbers in the right position, then the method will return true 
            if (correct == 4)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
