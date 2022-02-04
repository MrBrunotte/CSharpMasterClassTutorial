using System;

namespace Section_7_ch_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean valid = false;
            string inputValueType;

            Console.WriteLine("----- Challenge 1 section 7 -----\n");
            Console.Write("Enter a value: ");
            string inputValue = Console.ReadLine();
            Console.WriteLine("Select the Data type to validate the input you have entered");
            Console.WriteLine("Press 1 for String\n" +
                              "Press 2 for Integer\n" +
                              "Press 3 for Boolean");
            Console.Write("Enter your option: ");
            int inputType = Convert.ToInt32(Console.ReadLine());
            
            switch (inputType)
            {
                case 1:
                    // check for string
                    valid = IsAllAlphabetic(inputValue);
                    inputValueType = "string";
                    break;

                case 2:
                    int retValue = 0;
                    // check for integer
                    valid = int.TryParse(inputValue, out retValue);
                    inputValueType = "Integer";
                    break;

                case 3:
                    bool retFlag = false;
                    //Check for boolean
                    valid = bool.TryParse(inputValue, out retFlag);
                    inputValueType = "Boolean";
                    break;

                default:
                    inputValueType = "unknown input";
                    Console.WriteLine("Not able to detect the input type, something is wrong!");
                    break;

            }
            Console.WriteLine($"You have enterd a value: {inputValue}");
                if (valid)
                {
                    Console.WriteLine($"It's not a valid {inputValueType}");
                }
                else
                {
                    Console.WriteLine($"It's not a valid {inputValueType}");
                }
            Console.Read();
        }

        /// <summary>
        /// function to check if the input string only contains letters in string format
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        static bool IsAllAlphabetic(string value)
        {
            foreach (char c in value)
            {
                if (!char.IsLetter(c))
                {
                    return false;
                }
            }
                return true;
        }
    }
}
