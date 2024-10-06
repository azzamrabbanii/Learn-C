

using System;


namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {

            Random RandomNumber = new Random(); //im not really sure what this line does :/. But it a nessacarry line to make a random number generator
            int TargetNum = RandomNumber.Next(0, 20); // generate a random number from the interval 0 to 20

            int GuessAttempt = 0; //This will be used to loop the coding. Where the value of "GuessAttempt" will increase by 1 everytime the user guess the wrong number

            while (GuessAttempt <= 10) //The code will keep asking the user until the value of "GuessAttempt" is equal to 10. where if its equal to 10, it will automatically stop

            {

                Console.WriteLine("Please input a number: ");

                int NumGuess = Convert.ToInt32(Console.ReadLine());

                if (NumGuess < TargetNum)

                {

                    Console.WriteLine("your guessing number is too low :(");

                    GuessAttempt++; //increase the value of "GuessAttempt" by 1

                }

                else if (NumGuess > TargetNum)

                {

                    Console.WriteLine("Your guessing number is too high :(");

                    GuessAttempt++; //increase the value of "GuessAttempt" by 1

                }

                else

                {

                    Console.WriteLine("You guessed the right number :)");

                    break; //This will automatically stop the coding when the user guess the right number. 

                }

            }

        }
    }
}