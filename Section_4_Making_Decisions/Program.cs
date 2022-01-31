using System;

namespace Section_4_Making_Decisions
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ternary operator - one if statement in one row
            /* condition ? first_expression : second_expression
             * condition has to be either true or false
             * The condition operator is right - associative
             * the expression a ? b : c ? d :e
             * is evaluated as a? b : (c ? d : e)
             * not as (a ? b : c)? d: e
             * The conditional operator cannot be overloaded
             */

            int temperature = -5;
            string stateOfMatter;
            if (temperature < 0)
                stateOfMatter = "solid";
            else if (temperature >= 100)
            {
                stateOfMatter = "gas";
            }
            else
                stateOfMatter = "liquid";
            Console.WriteLine($"State of matter is {stateOfMatter}");

            // Ternary operator
            temperature += 30;

            stateOfMatter = temperature < 0 ? "solid" : "liquid";

            Console.WriteLine($"State of matter is {stateOfMatter}");

            // Ternary operator as a if/else statement
            temperature = 100;

            stateOfMatter = temperature >= 100 ? "gas" : temperature < 0 ? "solid" : "liquid";

            Console.WriteLine($"State of matter is {stateOfMatter}");
            Console.Read();
        }
    }
}
