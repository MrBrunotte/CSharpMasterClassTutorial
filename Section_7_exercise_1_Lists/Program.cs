using System;
using System.Collections.Generic;

namespace Section_7_exercise_1_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> allInts = new List<int> { 100,105, 110, 115, 120, 125, 130, 135, 140, 145, 150, 155, 160, 165, 170 };

            Console.WriteLine("Returns list of only even numbers from 100 to 170:");
            ReturnEvenList(allInts);
            
            Console.Read();
        }

        public static void ReturnEvenList(List<int> numbers)
        {
            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    Console.WriteLine(number);
                }
            }
        }
    }
}
