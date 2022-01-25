using System;
using System.Collections.Generic;

namespace Section_3_FunctionsMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 5;
            int num2 = 3;
            int num3;

            // unary opeators mulitplies it with - 1
            num3 = -num1;
            Console.WriteLine($"num3 is {num3}");

            bool isSunny = true;
            Console.WriteLine($"\nIs it sunny? {!isSunny}"); // negates isSunny to false

            //Increment operators
            int num = 0;
            num++;
            Console.WriteLine($"\nnum is {num}");
            Console.WriteLine($"num is {++num}"); // post increments before
            Console.WriteLine($"num is {num++}");   // pre increments after
            Console.WriteLine($"num is {num}");

            // decrement operators
            num--;
            Console.WriteLine($"\nnum is {num}");
            Console.WriteLine($"num is {--num}"); // post decrements before
            Console.WriteLine($"num is {num--}");   // pre deccrements after
            Console.WriteLine($"num is {num}");

            int result;
            Console.Write($"\nnum1 is: {num1}, num2 is {num2}");
            result = num1 + num2;
            Console.WriteLine($"Result of num1 + num2 is: {result}");

            result = num1 - num2;
            Console.WriteLine($"Result of num1 - num2 is: {result}");

            result = num1 / num2;
            Console.WriteLine($"Result of num1 / num2 is: {result}");

            result = num1 * num2;
            Console.WriteLine($"Result of num1 * num2 is: {result}");
            
            result = num1 % num2;
            Console.WriteLine($"Result of reminder of num1 % num2 is: {result}");

            // relational and type operators
            bool isLower;
            isLower = num1 < num2;
            Console.WriteLine($"Is num1 < num2?: {isLower}");
            isLower = num1 > num2;
            Console.WriteLine($"Is num1 > num2?: {isLower}");

            // equality operator
            bool isEqual;
            isEqual = num1 == num2;
            Console.WriteLine($"Is num1 = num2?: {isEqual}");
            isEqual = num1 != num2;
            Console.WriteLine($"Is num1 != num2?: {isEqual}");

            // conditional operators - AND &&
            bool isLowerAndSunny;
            isLowerAndSunny = isLower && isSunny; // condition 1 AND condition 2
            Console.WriteLine($"Is isLower: ({isLower}) AND isSunny ({isSunny}) True??: \t{isLowerAndSunny}");

            // comparative operator - OR || (both conditions have to be true!)
            isLowerAndSunny = isLower || isSunny; // condition 1 AND condition 2
            Console.WriteLine($"Is isLower: ({isLower}) OR isSunny ({isSunny}) True??: \t{isLowerAndSunny}");

            Console.Read();
        }
    }
   
}
