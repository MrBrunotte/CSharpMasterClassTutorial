using System;

namespace Challenge_3_section_2
{
    // Challenge 3 Datatypes and Variables
    /* Now that you know how to declare and initialize Variables, please go ahead and create a 
     * variable for each of the primitive datatypes. (Leave the Object datatype out)
     * And also please initialize each variable with a working value.
     * Then create two values of type string. 
     * The first one should say "I control text"
     * The second one should be a whole number.
     * Then use the Parse method in order to convert that string to an integer.
     * Add each an output for each of the variables and WriteLine it onto the console. (WriteLineLine)
     */
    class Program
    {
        static void Main(string[] args)
        {
            // Primitive data types
            byte myByte = 254;          // 0-255
            sbyte mySByte = -126;       // -128 to 127
            int myInt = 4954874;        // -2,147,483,648 to 2,147,483,647
            uint myUInt = 0;            // 0 to 4294967295
            short myShort = 32767;      // -32,768 to 32,767
            ushort myUShort = 65535;    // 0 to 65535
            long myLong = 922337203;    // -9223372036854775808 to 9223372036854775807
            ulong myULong = 18446744;   // 0 to 18446744073709551615
            float myFloat = 3.14f;      // -3.402823e38 to 3.402823e38 must have F or f at the end!
            double myDouble = 1.79;     // -1.79769313486232e308 to 1.79769313486232e308
            char myChar = 'S';          // Unicode symbols used in text
            bool myBool = true;         // true/false
            string myString = "Stefan"; // A number of characters
            decimal myDecimal = 4.4578m; // ±1.0 × 10e−28 to ±7.9 × 10e28 must have M or m at the end!

            string textControl = "I control text";
            string textNumber = "123456";
            int parsedTextNumber = Int32.Parse(textNumber);

            Console.WriteLine("--- Primitive data types ---");
            Console.WriteLine(myByte);
            Console.WriteLine(myByte.GetType());
            Console.WriteLine(mySByte);
            Console.WriteLine(mySByte.GetType());
            Console.WriteLine(myInt);
            Console.WriteLine(myInt.GetType());
            Console.WriteLine(myUInt);
            Console.WriteLine(myUInt.GetType());
            Console.WriteLine(myShort);
            Console.WriteLine(myShort.GetType());
            Console.WriteLine(myUShort);
            Console.WriteLine(myUShort.GetType());
            Console.WriteLine(myLong);
            Console.WriteLine(myLong.GetType());
            Console.WriteLine(myULong);
            Console.WriteLine(myULong.GetType());
            Console.WriteLine(myFloat);
            Console.WriteLine(myFloat.GetType());
            Console.WriteLine(myDouble);
            Console.WriteLine(myDouble.GetType());
            Console.WriteLine(myChar);
            Console.WriteLine(myChar.GetType());
            Console.WriteLine(myBool);
            Console.WriteLine(myBool.GetType());
            Console.WriteLine(myString);
            Console.WriteLine(myString.GetType());
            Console.WriteLine(myDecimal);
            Console.WriteLine(myDecimal.GetType());
            Console.WriteLine(textControl);
            Console.WriteLine(textControl.GetType());
            Console.WriteLine(textNumber);
            Console.WriteLine(textNumber.GetType());
            Console.WriteLine(parsedTextNumber);
            Console.WriteLine(parsedTextNumber.GetType()); ;

            Console.Read();
        }
    }
}
