using System;

namespace Section_7_Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare and intialize a two dimensional array - Two ways do declare and initialize
            string[,] twoDString_1 = new string[2, 3] { { "one", "two", "three" }, { "four", "five", "six" } };
            string[,] twoDString_2 = new string[3, 2] { { "one", "two", }, { "three", "four" }, { "five", "six" } };
            int[,] twoD2 = { { 1, 2 }, { 3, 4 } };

            int[,] twoD = new int[,]
            {
                {1,2,3},    // row 0
                {4,5,6},    // row 1
                {7,8,9},    // row 2
            };
            Console.WriteLine("---- 2D ----");
            Console.WriteLine($"Central value is: {twoD[1, 1]}");
            Console.WriteLine($"7 : {twoD[2, 0]}");


            // three dimensional array
            string[,,] threeD = new string[,,]
            {
                {
                    {"000", "001"},
                    {"010", "011"},
                    {"020 - Stefan", "010 - Viggo"}
                },
                {
                    {"100", "101"},
                    {"110", "111"},
                    {"120", "121 - Last row"}
                }
            };
            Console.WriteLine("\n---- 3D ----");
            Console.WriteLine($"value 010 is: {threeD[0, 1, 0]}");
            Console.WriteLine($"value Stefan is: {threeD[0, 2, 0]}"); // column 0, row 2, index 0
            Console.WriteLine($"value Viggo is: {threeD[0, 2, 1]}"); // column 0, row 2, index 1
            Console.WriteLine($"value Last row is: {threeD[1, 2, 1]}"); //column 1, row 2, index 1

            Console.WriteLine("\n----- Find length of Array Property: Length -----");
            Console.WriteLine($"Length of array called twoD: {twoD.Length}");
            
            Console.WriteLine("\n----- Find dimension of Array Property: Rank -----");
            Console.WriteLine($"Length of array called twoD: {twoD.Rank}");
            Console.WriteLine($"Length of array called threeD: {threeD.Rank}");

            Console.WriteLine("\n ----- challenge - Change \"four\" to Chicken -----"); 
            string[,] arrayChallenge_Chicken = new string[2, 3] { { "one", "two", "three" }, { "four", "five", "six" } };
            Console.WriteLine($"Inital value for row 1 index 0 --> {arrayChallenge_Chicken[1, 0]}");
            Console.WriteLine($"New value for row 1 index 0 --> {arrayChallenge_Chicken[1, 0] = "Chicken"}");

            Console.Read();
        }
    }
}
