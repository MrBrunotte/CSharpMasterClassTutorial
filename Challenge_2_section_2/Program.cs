using System;

namespace Challenge_2_section_2
{
    // Challenge Strings and its methods 2
    /*
     * 1. This application asks the user to input a string in the first line like “Enter a string here: ”.
     *    In the Second Line, it should ask for the character to search in the string which you have 
     *    entered in the first line like “Enter the character to search: ”
     *    On the third line, it should write the index of the first occurrence of the searched 
     *    character from the string.
     * 
     * Now on concatenation...
     * 
     * 2. It should then ask to enter the first name and once the name is written and the enter button 
     *    is pressed, it should ask to enter the last name.
     * 
     *    It should then show your full name printed in a single line like in my case the output will 
     *    be "Denis Panjuta". Output can be different in your case. Try to store the full name in a 
     *    variable, before displaying it.
     */
    class Program
    {
        static void Main(string[] args)
        {
            string userInputString; 
            char searchInput; // char because we are only asking for one character
            string firstName;
            string lastName;
            string fullName;
            int searchIndex;
            Console.WriteLine("--- Part ONE ---");
            Console.Write("Enter a string here: ");
            userInputString = Console.ReadLine();

            Console.Write("\nEnter a character and find out if it is in your string: ");
            //Console.WriteLine(userInputString.IndexOf(Console.ReadLine()));
            searchInput = Console.ReadLine()[0]; // get me the first occurance only! [0]
            // gets the index of the character from the string
            searchIndex = userInputString.IndexOf(searchInput);
            if (searchIndex < 0)
            {
                Console.WriteLine($"You searched for: {searchInput}, that character is not in the string!");
            }
            else
            {
            Console.WriteLine($"Index of character: The character: {searchInput}, in your string is at postition: {searchIndex}.");
            }

            Console.WriteLine("\n--- Part TWO ---");
            Console.Write("\nEnter your first name: ");
            firstName = Console.ReadLine();
            Console.Write("Enter your last name: ");
            lastName = Console.ReadLine();
            //Console.WriteLine($"Your full name is: {firstName} {lastName}");
            fullName = string.Concat(firstName, " ", lastName);
            Console.WriteLine($"Your full name concatinated is: {fullName}");

            Console.Read();
        }
    }
}
