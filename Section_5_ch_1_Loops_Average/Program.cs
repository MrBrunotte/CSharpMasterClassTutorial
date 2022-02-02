using System;

namespace Section_5_ch_1_Loops_Average
{
    class Program
    {
        /* Imagine you are a developer and get a job in which you need to create a program for a teacher. 
         * He needs a program written in c# that calculates the average score of his students. 
         * 
         * So he wants to be able to enter each score individually and then get the final average 
         * score once he enters -1. 
         * 
         * So the tool should check if the entry is a number and should add that to the sum. 
         * 
         * Finally once he is done entering scores, the program should write onto the console what the 
         * average score is. 
         * The numbers entered should only be between 0 and 20. 
         * 
         * Make sure the program doesn't crash if the teacher enters an incorrect value.
         * 
         * Test your program thoroughly.*/
        static void Main(string[] args)
        {
            string inputString = "0";
            int currentNumber = 0;
            int count = 0;
            int total = 0;

            while (inputString != "-1")
            {
                Console.WriteLine($"Number of scores submitted: {currentNumber}");
                Console.WriteLine("Please enter a score: ");
                Console.WriteLine($"Current number of entries: {count}");
                Console.WriteLine("Enter -1 when you want to find out the average of your scores!");
                inputString = Console.ReadLine();

                // to exit the program, must be first otherwise it will not break the loop
                if (inputString == "-1")
                {
                    Console.WriteLine("-------------------------------");
                    // calculate score average
                    double average = (double)total / (double)count;
                    Console.WriteLine($"The average of your score is: {average}");
                    break;
                }


                if (int.TryParse(inputString, out currentNumber) && currentNumber > 0 && currentNumber <= 20)
                {
                    total += currentNumber;
                }
                else
                {
                    if (inputString != "-1")
                    {
                        Console.WriteLine("Please enter a value between 1-20\n");
                    }
                    continue;
                }

                count++;
            }
                Console.ReadLine();
        }
    }
}
