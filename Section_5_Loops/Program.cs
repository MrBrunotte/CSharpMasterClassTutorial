using System;

namespace Section_5_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "0";
            int currentScore = 0;
            int count = 0;
            int total = 0;
            double average = 0;

            while (true)
            {
                Console.WriteLine($"Number of added scores: {currentScore}");
                Console.WriteLine($"Number of added scores: 0");
                Console.WriteLine("Enter your score: ");
                Console.WriteLine($"Current numer of scores: {count}");
                Console.WriteLine("Enter -1 when you want to see the average score.");
                input = Console.ReadLine();

                // to exit the program
                if (input == "-1")
                {
                    Console.WriteLine("------------------------");
                    average = (double)total / (double)count;
                    Console.WriteLine($"The average score is: {average}");
                    break;
                }

                if (int.TryParse(input, out currentScore) && currentScore > 0 && currentScore <= 20)
                {
                    // add the current score to total
                    total += currentScore;
                }
                else
                {
                    if (input != "-1")
                    {
                        Console.WriteLine("You did not enter a valid score, try again.");
                    }
                    continue;
                }
                // add 1 to count
                count++;
            }
                Console.Read();
        }
    }
}
