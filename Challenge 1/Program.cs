using System;

namespace Challenge_1_section_2
{
    // Challenge 1 – String and its methods
    /*Declare a string variable and don’t assign any value to it.

    Print on the console “Please enter your name and press enter”. Y
    You can then enter your name or any other valid string like “tutorials.eu”.

    Assign that entered string to the string variable which you have declared initially.

    1. The program should write on the console that string in Uppercase in the first line,
    2. then the same string in Lowercase in the second line.
    3. In the third line, it writes on the console the string with no trailing or preceding 
       white space like if string entered as “ tutorials.eu ” it should be written on the 
       console as “tutorials.eu”. 
    4. And in the last line, it should write the Substring of the entered string on the console. 
    */
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            Console.Write("Please enter your name with a couple of spaces before and after and press enter: ");
            name = Console.ReadLine();
            Console.WriteLine($"\n1. Uppercase: {name.ToUpper()}");
            Console.WriteLine($"\n2. Lowercase: {name.ToLower()}");
            Console.WriteLine($"\n3a. With trailing spaces (not trimed): {name}");
            Console.WriteLine($"3. No trailing spaces (trimed): {name.Trim()}");
            Console.WriteLine($"\n4. Substring: {name.Substring(3)}");

            Console.Read();
        }
    }
}
