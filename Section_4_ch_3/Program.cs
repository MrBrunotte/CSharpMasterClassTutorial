using System;

namespace Section_4_ch_3
{
    class Program
    {
        /* 
         * We have studied ternary operators and their usage so here is a small challenge for you. 
         * Let's create a smallapplication that takes a temperature value as input and checks 
         * if the input is an integer or not.
         * If the input value is not an integer value, it should print to the console "Not a valid Temperature".
           And if the input value is the valid integer then it should work as mentioned below.
           If input temperature value is <=15 it should write "it is too cold here" to the console.
           If input temperature value is >= 16 and is <=28 it should write "it is ok" to the console.
           If the input temperature value is > 28 it should write "it is hot here" to the console.
        */
        static void Main(string[] args)
        {
            int inputTemperature = 0;
            string temperatureMessage = string.Empty;
            string inputValue = string.Empty;

            // Input from user stored in a string variable
            Console.Write("Whats the current temp?: ");
            inputValue = Console.ReadLine();

            // Validate the input with TryParse()
            bool validInteger = int.TryParse(inputValue, out inputTemperature);

            if (validInteger)
            {
                temperatureMessage = inputTemperature <= 15 ? "It is cold here!" : (inputTemperature >= 16 && inputTemperature <= 28) ? "It is varm here" : inputTemperature > 28 ? "It is hot here" : "";
                
                Console.WriteLine(temperatureMessage);

                //temperatureMessage = inputTemperature <= 15 ?
                //    //True case
                //    "It is cold here!" :
                //    // false case and nested ternary
                //    // condition
                //    (inputTemperature >= 16 && inputTemperature <= 28) ?
                //    // true
                //    "It is varm here" :
                //    // false
                //    inputTemperature > 28 ? 
                //    // true
                //    "It is hot here" : 
                //    // false
                     
                //Console.WriteLine(temperatureMessage);
            }
            else
                Console.WriteLine("Not a valid temperature!");
 
            Console.Read();
        }
    }
}
