using System;

namespace Section_2_DataTypesVariables
{
    class Program
    {
        // Constants are immutable values which are known at compile time
        // and do not change for the life of the program.

        // constants are usually Fields! (variables outside the methods inside the class)

        const double PI = 3.14159265359;
        const int weeks = 52, months = 12;
        const string myBirthday = "17.02.1972";
        static void Main(string[] args)
        {
            Console.WriteLine($"I was born on the: {myBirthday}");



            Console.Read();
        }
    }
}
