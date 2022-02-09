# ---- Collections ----

## 81 - Basics of Arrays, ArrayLists and Lists

##### Array
 - Store a fixed size sequentila collection of elements
 - ONLY of the same type
 - You can create Arrays of all types
 - Great to store a collection of data
 - Zero-based

##### Declaring an Array

    dataType[] arrayName;
    int[] grades;

##### Initializing an Array

    dataType[] arrayName =  new dataType[amountOfEntries];
    int[] grades = new int[5];

##### Assigning values to an Array

    arrayName[index] = value;
    grades[0] = 5;
    grades[6] = 12;

## 82 - Declaring and initalizing Arrays and the Length property

    static void Main(string[] args)
        {
            int[] grades = new int[5];

            grades[0] = 20;
            grades[1] = 15;
            grades[2] = 18;
            grades[3] = 9;
            grades[4] = 5;

            Console.WriteLine($"Grade at index 0: {grades[0]}");
            grades[0] = 45;
            Console.WriteLine($"New grade at index 0: {grades[0]}\n");

            Console.WriteLine($"Original grade at index 4: {grades[4]}");
            Console.Write("\nEnter a new grade for index 4: ");
            // assign new grade at index 4
            grades[4] = int.Parse(Console.ReadLine());
            Console.WriteLine($"\nNew grade at index 4: {grades[4]}");

            // other way to declare and initialize an Array
            int[] gradesOfMathStudentsA = { 5, 99, 25, 36, 42 };

            // third way
            int[] gradesOfMathStudentsB = new int[] { 15, 20, 18, 14,11,10};

            // Use the Length property to get the length of the values in the Array
            Console.WriteLine($"Length of A students: {gradesOfMathStudentsA.Length}"); 
            Console.WriteLine($"Length of B students: {gradesOfMathStudentsB.Length}"); 

            Console.Read();
        }

## 83 - foreach loop
    static void Main(string[] args)
        {
            int[] nums = new int[10];

            for (int i = 0; i < 10; i++)
            {
                nums[i] = i + 10;
                Console.WriteLine($"Element {i} = {nums[i]}");
            }
            Console.WriteLine("\nWe use the Length property to avoid out of range exeption");
            for (int j = 0; j < nums.Length; j++)
            {
                Console.WriteLine($"Element {j} = {nums[j]}");
            }
            Console.WriteLine("\nWe can also use a foreach loop to not get an exeption");
            Console.WriteLine("We need to add a counter here");
            int counter = 0;
            foreach (int num in nums)
            {
                Console.WriteLine($"Element {counter} = {num}");
                counter++;
            }

            Console.WriteLine();
            // CHALLENGE - Create an Array with 5 friends
            // Create a foreach loop which greats them all

            string[] friends = new string[] { "Viggo", "Rebecca", "Pappa", "Erik", "Calle" };

            foreach (string friend in friends)
            {
                Console.WriteLine($"Greetings {friend}!");
            }

            Console.Read();
        }

## 84 - Foreach Loops and Switch statement challenge - Folder Section_7_ch__1

Create an application that takes 2 input values.
1. Any input value (1st input)
2. Asks the data type of the input value. (2nd input).

It will print to the console the options like below to take input for the 2nd input value:
- Press 1 for String
- Press 2 for integer
- Press 3 for Boolean

If the input value for the 2nd input is 1 then the application should check that if the entered 1st input is a valid string or not. 

Hereby we even want to check, if it is a complete alphabetic entry (so no numbers accepted)

If the input value for the 2nd input is 2 then the application should check if the entered 1st input is a valid integer or not.

Based on the input the 1st value and the selection of data type using the 2nd input, the application should return whether the entered 1st value is of data type selected by the user or not.

Please make sure to use a switch statement. To check the valid string you can write your custom logic.

For example:

<i>

Enter a value: {here you can enter any value}
Select the Data type to validate the input you have entered.

- Press 1 for String
- Press 2 for Integer
- Press 3 for Boolean

Here, if you enter 1 it should return below message

"You have entered a value: Denis Panjuta -
It is a valid: String"

Here, if you enter 2 it should return below message

"You have entered a value: Denis Panjuta -
It is an invalid: Integer"
</i>

## 86 - Multi Dimensional Arrays
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

## 87 - Nested for loops and 2d arrays

    static void Main(string[] args)
        {
            // cannot change any values in the foreach loop!
            foreach (int num in matrix)
            {
                Console.Write(num + " ");
            }

            Console.WriteLine("\nThis is our 2D matrix array printed using a nested for loop");
            // Nested for loop - We can change values in the loop with for loops!
            // Outer for loop
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                // Inner for loop
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[2, 1] = 8888888;
                    Console.Write(matrix[i,j] + " ");
                }
            }


            Console.Read();
        }

        // static collection since we are using it in the Main()
        static int[,] matrix =
        {
            {1,2,3},
            {4,5,6},
            {7,8,9}
        };
    }

## 88, 89 - Nested for loops part two

    // static collection since we are using it in the Main()
        /*
         * position index nr
         
            {00,01,02},     
            {10,11,12},
            {20,21,22}
         
         */
        static int[,] matrix =
        {
            {1,2,3},
            {4,5,6},
            {7,8,9}
        };
        static void Main(string[] args)
        {
            // cannot change any values in the foreach loop!
            Console.WriteLine("Print the odd numbers in the matrix");
            foreach (int num in matrix)
            {
                Console.Write(num + " ");
            }

            // Nested for loop - We can change values in the loop with for loops!
            // Outer for loop
            Console.WriteLine("\nPrints the diagonal numbers: 1 5 9");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                // Inner for loop
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i == j)
                    {
                    Console.Write(matrix[i,j]);
                    }
                    else
                        Console.Write("-");
                }
                Console.WriteLine("");
            }

            Console.WriteLine("\nPrints the diagonal numbers: 1 5 9 with only one for loop!");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                // prints the numbers 1=1, 5=5, 9=9
                Console.Write  (matrix[i,i] + " ");
            }

            Console.WriteLine("\nPrints the diagonal numbers: 3 5 7 nested for loop");
            // This only works if it a matrix 2x2, 3x3, 4x4 if 2x3, 4x5 etc
            for (int i = 0, j = 2; i < matrix.GetLength(0); i++, j--)
            {
                Console.Write(matrix[i,j] + " ");
            }


            Console.Read();
        }

## 90 - TicTacToe challenge

#### What do I need?

1. playing field the matrix
2. while loop to keep the game running
3. 