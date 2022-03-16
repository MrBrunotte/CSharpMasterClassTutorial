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

1. playing field named - matrix

       // the playfield type char is the most resource efficient
        static char[,] matrix =
        {
            {'1','2','3' },
            {'4','5','6' },
            {'7','8','9' }
        };

to be continued...

## 91 - jagged arrays

    {
            // Create a jagged array, whith 3 "friends array", in which to family members should be stored
            // Introduce family members from different families to each other via console

            string[] callesFamilj = new string[] { "Calle", "Faye", "Jasper", "Zach" };
            string[] christinesFamilj = new string[] { "Christine", "Janine", "Marcel" };
            string[][] familyMembers = new string[][]
            {
                new string[]{"Stefan", "Viggo"},
                christinesFamilj,
                new string[]{"Ruth", "Jolie", "Xavier"},
                callesFamilj
            };

            Console.WriteLine("Introduce Stefan to Marcel");
            Console.WriteLine($"Hi {familyMembers[0][0]}, I would like to introduce {familyMembers[1][2]} to you!\n");
            Console.WriteLine("Introduce Jasper to Janine");
            Console.WriteLine($"Hi {callesFamilj[2]}, this is {christinesFamilj[1]}!\n");
            Console.WriteLine("Introduce Viggo to Ruth");
            Console.WriteLine($"Hi {familyMembers[0][1]}, I would like to introduce your Omi {familyMembers[2][0]} to you!\n");
            Console.WriteLine("Introduce jolie to Xavier");
            Console.WriteLine($"Hi {familyMembers[2][1]}, meet {familyMembers[2][2]}!\n");

            Console.Read();
        }

## 93 - using arrays as parameters


        static void Main(string[] args) 
            {
                int[] studentsGrades = new int[] { 2, 3, 5, 5, 4, 3, 3, 2, 5, 1 };
                double averageResult = GetAverage(studentsGrades);

                foreach (int grade in studentsGrades)
                {
                    Console.Write($"{grade}, ");
                }

                Console.WriteLine($"\nThe average is: {averageResult}");

                Console.Read();
            }

            static double GetAverage(int[] gradesArray)
            {
                int size = gradesArray.Length;
                double average;
                int sum = 0;

                for (int i = 0; i < size; i++)
                {
                    sum += gradesArray[i];
                }
                average = (double)sum / (double)size;
                return average;
            }
        }

### Challenge

1. Create the method - with an int[] as parameter. The method loops through an array and ads 2 to each loop.

        public static void HowHappyAreYou(int[] happyScore)
            {
                for (int i = 0; i < happyScore.Length; i++)
                {
                    happyScore[i] += 2;
                }
            }

2. Create an array of type int in the main method and call the "HowHappyAreYou" method with the array as argument. Next you use a foreach loop to print the array to the console.


        // Challenge - Create an array of happiness in the main method and assign 5 values to it.
        // Create a method which has an array of type int as its parameter.
        // This method should increase the argument given by 2, for each entry.
        // call this method in the main method and use "happiness" as the argument.
        // create a foreach loop in the main method to write all values onto the console.
        
        static void Main(string[] args) 
        {
             int[] happiness = { 10, 8, 12, 5, 9 };

            HowHappyAreYou(happiness);

            foreach (int happy in happiness)
            {
                Console.WriteLine(happy);
            }

            Console.Read();
        }
        public static void HowHappyAreYou(int[] happyScore)
        {
            int sum = 0;
            for (int i = 0; i < happyScore.Length; i++)
            {
                happyScore[i] += 2;
            }
        }

## 95 - Params keyword

Params keyword lets you specify any number of parameters into a method

    class Program
    { 
        static void Main(string[] args) 
        {
            int price = 50;
            float pi = 3.14f;
            char at = '@';
            string book = "The Hobbit";

            ParamsMethod2(price, pi, at, book);
            ParamsMethod("This ", "is ", "a ", "long ", "string", "...");
            Console.Read();
        } 
        public static void ParamsMethod(params string[] sentence)
        {
            for (int i = 0; i < sentence.Length; i++)
            {
                Console.Write(sentence[i] + " ");
            }
        }
        public static void ParamsMethod2(params object[] objectStuff)
        {
            // foreach loop to go through the array of objects
            foreach (object obj in objectStuff)
            {
                Console.Write(obj + " ");
            }
            Console.WriteLine();
        }
    }

## 96 - Getting the min value of many given numbers using params keyword

Using the MaxValue constant to pass in more than 2 numbers, We create our own method for this MinV2

    static void Main(string[] args)
        {
            int min = MinV2(1, 5, 8, 5, 6, 915, -15, 245, 25, -452578987); // int type so cannot be outside the range
            Console.WriteLine($"The minimum value is: {min}");
            Console.Read();
        }
        public static int MinV2(params int[] numbers)
        {
            int min = int.MaxValue;

            foreach (int number in numbers)
            {
                if (number < min)
                {
                    min = number;
                }
            }
            return min;
        }

## 97 - Overview Generic and Nono-Generic Collections

- Collections are classes that we can use to store a collection of objects
- Not limited to one type of objects
- No size constraints, it can grow in size as we add more elements
- collections use .Count (Arrays uses .Length) 

### Why do we need Collections?


We use them to store, manage and manipulate groups of objects more effiently...

- Adding objects to the collection
- Deleting
- Replacing
- Searching
- Copying

### Types of Collections - Non-generic & Generic

##### Non-generic

Non-generic can store any type of objects and it is located in teh System.Collections namespace

    // Non-Generic Collection examples

            int num1 = 5;
            float num2 = 2.45f;
            string name = "Viggo";
            ArrayList myArrList = new ArrayList();

            // Different types in the same collection
            myArrList.Add(num1);    // -int
            myArrList.Add(num2);    // -float
            myArrList.Add(name);    // -string

            foreach (object element in myArrList)
            {
                Console.WriteLine(element + " ");
                Console.WriteLine(element.GetType() + " \n");
            }

##### Generic

Limited to one type of objects and is located in teh System.Collections.Generic namespace. We use the Generic types when we only need one type of object.

        // Generic Collection examples
            string animal1 = "Cat";
            string animal2 = "Dog";
            string animal3 = "Flamingo";

            // Can only hold one type so we must specify the type wen creating our List<string>
            List<string> myGenericList = new List<string>();

## 98 - ArraLists - Non-Generic (multiple types of objects)

    static void Main(string[] args)
        {
            // declaring an ArraList with undefiened amount of objects
            ArrayList myArrayList = new ArrayList();
            // declaring an ArraList with defiened amount of objects
            ArrayList myArrayList2 = new ArrayList(100);

            myArrayList.Add(25);
            myArrayList.Add("Hello");
            myArrayList.Add(13.37);
            myArrayList.Add(13);
            myArrayList.Add(258);
            myArrayList.Add(25.3);
            myArrayList.Add(25.31);

            // Delets element with specific value from myArrayList
            myArrayList.Remove(13);

            // delete element at specific index
            myArrayList.RemoveAt(0);

            //
            Console.WriteLine($"number of elements i myArrayList: {myArrayList.Count}");

            double sum = 0;

            foreach (object obj in myArrayList)
            {
                if (obj is int)
                {
                    sum += Convert.ToDouble(obj);
                }
                else if (obj is double)
                {
                    sum += (double)obj;
                }
                else if (obj is string)
                {
                    Console.WriteLine($"This element is of type string: {obj}");
                }
            }
            Console.WriteLine($"The sum of the numbers are: {sum}");
            Console.Read();
        }

## 99 - Lists

A flexible way to work with sets of objects/values. Compared to arrays, the group objects/values you work with can grow and shrink dynamically. 
A collection is a class and it requires an instance of the class before adding elements to that collection.
For collections that only contain one data type use the System.Collections.Generic namespace.

List declaration examples:

    // List declaration
            var numbers = new List<int>();      //list of type int without values
            var numbers2 = new List<int> { 1, 5, 35, 100 }; //List of type int with values

            // Adding and removing values
            numbers.Add(7);                     //adds an integer with value 7 to the numbers list
            numbers.Remove(7);                  //removes an integer with value 7 from the numbers list
            numbers.RemoveAt(2);                //removes an integer at index 2 from the numbers list
            int value = numbers2[1];             // stores the value 5 in the int variable value
            numbers.Clear();                    // clear the list from values

            foreach (int element in numbers2)
            {
                Console.WriteLine(element);
            }

            for (int i = 0; i < numbers2.Count; i++)
            {
                Console.WriteLine(i);
            }

#### Coding exercise 1 Lists

Write a method that returns a list of even integer numbers between 100 and 170 (inclusive)

    class Program
    {
        static void Main(string[] args)
        {
            List<int> allInts = new List<int> { 100,105, 110, 115, 120, 125, 130, 135, 140, 145, 150, 155, 160, 165, 170 };

            Console.WriteLine("Returns a list of even numbers from 100 to 170 from the allInts list:");
            ReturnEvenList(allInts);
            
            Console.Read();
        }

        public static void ReturnEvenList(List<int> numbers)
        {
            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    Console.WriteLine(number);
                }
            }
        }
    }
    

## Hashtables - a collection that stores (Keys, Values) pairs

    class Program
    {
        // Key - Value pair - Hashtables can have different values
        // Auto - car
        static void Main(string[] args)
        {
            // create a Hashtabel 
            Hashtable studentsTable = new Hashtable();

            Student stud1 = new Student(1, "Maria", 98);
            Student stud2 = new Student(2, "Jason", 76);
            Student stud3 = new Student(3, "Clara", 43);
            Student stud4 = new Student(4, "Steve", 55);
            Student stud5 = new Student(5, "Peter", 99);

            // store data in the Hashtable
            studentsTable.Add(stud1.Id, stud1);
            studentsTable.Add(stud2.Id, stud2);
            studentsTable.Add(stud3.Id, stud3);
            studentsTable.Add(stud4.Id, stud4);
            studentsTable.Add(stud5.Id, stud5);

            //retrieve data from the Hashtable with known ID
            Student StoredStudent1 = (Student)studentsTable[stud1.Id];

            // Retrieves all valus from Hashtable
            foreach (DictionaryEntry student in studentsTable)
            {
                Student temp = (Student)student.Value;
                Console.WriteLine($"Student ID: {temp.Id}, " +
                                  $"\nName: {temp.Name}, " +
                                  $"\nGPA: {temp.GPA}");
            }
            Console.WriteLine("--------- Simplify the foreach loop ----------");
            foreach (Student value in studentsTable.Values)
            {
                Console.WriteLine($"Student ID: {value.Id}, " +
                                  $"\nName: {value.Name}, " +
                                  $"\nGPA: {value.GPA}");
            }
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine($"Student ID: {StoredStudent1.Id}, \nName: {StoredStudent1.Name}, \nGPA: {StoredStudent1.GPA}");

            Console.Read();
        }

    }
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float GPA { get; set; }

        public Student(int id, string name, float gpa)
        {
            Id = id;
            Name = name;
            GPA = gpa;
        }
    }

## 102 - dictionaries
Dictionaries use Key-Value pair. 
1. In this video we create a class of Employees with several properties. The Salary is a readonly property and it calcules the salary for each role based on the Rate.
2. We create a list of Employees from the Employe class (Role, Name, Age, Rate)
3. Create the emplyeesDirectory and add the list to the directory
4. ContainsKey() method
5. TryGetValue() method
6. ElementAt() method (using Linq)



        class Program
        {
            // key - value
            // Auto - car
            static void Main(string[] args)
        {
            // List of employees
            Employee[] employees =
            {
                new Employee("CEO", "Stefan", 95, 200),
                new Employee("Manager", "Viggo", 35, 25),
                new Employee("HR", "Calle", 32, 21),
                new Employee("Secretary", "Märta", 28, 18),
                new Employee("Lead Developer", "Peter", 55, 35),
                new Employee("Intern", "Dino", 22, 8),
            };

            // create Dictionary employeesDirectory
            Dictionary<string, Employee> employeesDirectory = new Dictionary<string, Employee>();

            // Add each key (role) and valye (Employee list object) into the Dictionary employeesDirectory
            foreach (Employee emp in employees)
            {
                employeesDirectory.Add(emp.Role, emp);
            }
            Console.WriteLine("Roles:\nCEO\nManager\nHR\nSecretary\nLead Developer\nIntern\n");

            // Example with ContainsKey()
            Console.Write("What employee role do you want info about?: ");
            string key = Console.ReadLine();
            Console.WriteLine("\n----- ContainsKey(key) -----\n");
            if (employeesDirectory.ContainsKey(key))
            {
            // fetch data from the dictionary
            Employee empl = employeesDirectory[key];
            Console.WriteLine($"Employee name: {empl.Name}, Role: {empl.Role}, Salary: {empl.Salary}");
            }
            else
            {
                Console.WriteLine("This key does not exist");
            }


            // Example with TryGetValue()
            Employee result = null;

            Console.Write("\nWhat employee role do you want info about?: ");
            string keyValue = Console.ReadLine();

            Console.WriteLine("\n----- TryGetValue() -----\n");
            if (employeesDirectory.TryGetValue(keyValue, out result))
            {
                Console.WriteLine($"Value for {keyValue} retrieved");
                Console.WriteLine($"Employee name: {result.Name}");
                Console.WriteLine($"Employee Role: {result.Role}");
                Console.WriteLine($"Employee Age: {result.Age}");
                Console.WriteLine($"Employee Salary: {result.Salary}");
            }
            else
            {
                Console.WriteLine("The key does not exist!");
            }

            Console.ReadKey();

            Console.WriteLine("\n----- ElementAt(i) -----\n");
            for (int i = 0; i < employeesDirectory.Count; i++)
            {
                //Using ElementAt(i) to return the key-value pair stored at index i
                KeyValuePair<string, Employee> keyValuePair = employeesDirectory.ElementAt(i);
                //print the key
                Console.WriteLine($"Key: {keyValuePair.Key}, at index postion {i}");
                // storing the value in an employee object
                Employee employeeValues = keyValuePair.Value;
                // printing the properties of the employee object
                Console.WriteLine($"Employee Name: {employeeValues.Name}, Employee Role: {employeeValues.Role}, Employee Age: {employeeValues.Age}, Employee Salary: {employeeValues.Salary}\n");
            }

            Console.Read();
        }
        }
        class Employee
        {
            public string Role { get; set; }
            public string Name { get; set; }
            public int Age { get; set; }
            public float Rate { get; set; }
            public float Salary { get { return Rate * 8 * 5 * 4 * 12; } }

            public Employee(string role, string name, int age, float rate)
            {
                Role = role;
                Name = name;
                Age = age;
                Rate = rate;
            }
        }

## 103 - Editing and removing Entries in a Dictionary

        class Program
    {
        // key - value
        // Auto - car
        static void Main(string[] args)
        {
            // List of employees
            Employee[] employees =
            {
                new Employee("CEO", "Stefan", 95, 200),
                new Employee("Manager", "Viggo", 35, 25),
                new Employee("HR", "Calle", 32, 21),
                new Employee("Secretary", "Märta", 28, 18),
                new Employee("Lead Developer", "Peter", 55, 35),
                new Employee("Intern", "Dino", 22, 8),
            };

            // create Dictionary employeesDirectory
            Dictionary<string, Employee> employeesDirectory = new Dictionary<string, Employee>();

            // Add each key (role) and valye (Employee list object) into the Dictionary employeesDirectory
            foreach (Employee emp in employees)
            {
                employeesDirectory.Add(emp.Role, emp);
            }

            Console.WriteLine("\n----- Update specific key (HR) -----");
            Console.WriteLine($"Old value at HR: {employeesDirectory.ElementAt(2).Value.Name}");
            // Update specific Key
            string keyToUpdate = "HR";
            if (employeesDirectory.ContainsKey(keyToUpdate))
            {
                    employeesDirectory[keyToUpdate] = new Employee("HR", "Elena", 26, 18);
                    Console.WriteLine($"New value at HR: {employeesDirectory.ElementAt(2).Value.Name}");
            }
            else
            {
                Console.WriteLine($"There is no such key ({keyToUpdate}) in the dictionary");
            }

            //Remove 
            Console.WriteLine("\n----- Remove specific key -----");
            Console.WriteLine($"Number of elements in directory before: {employeesDirectory.Count()}");
            Console.WriteLine("Dictionary before");
            for (int i = 0; i < employeesDirectory.Count; i++)
            {
                //Using ElementAt(i) to return the key-value pair stored at index i
                KeyValuePair<string, Employee> keyValuePair = employeesDirectory.ElementAt(i);
                // storing the value in an employee object
                Employee employeeValues = keyValuePair.Value;
                // printing the properties of the employee object
                Console.WriteLine($"Employee Name: {employeeValues.Name}, Employee Role: {employeeValues.Role}, Employee Age: {employeeValues.Age}, Employee Salary: {employeeValues.Salary}");
            }
            
           // Console.WriteLine($"Dictionary with role Intern: {employeesDirectory}.");
            // Remove specific Key
            string keyToRemove = "Intern";
            if (employeesDirectory.Remove(keyToRemove))
            {
                Console.WriteLine($"\nKey that was removed: {keyToRemove}\n");
                Console.WriteLine($"New index value: {employeesDirectory.Count()}");
            }
            else
            {
                Console.WriteLine($"\nThere is no such key to remove ({keyToRemove}) in the dictionary\n");
            }
            // prints the dictionary
            for (int i = 0; i < employeesDirectory.Count; i++)
            {
                //Using ElementAt(i) to return the key-value pair stored at index i
                KeyValuePair<string, Employee> keyValuePair = employeesDirectory.ElementAt(i);
                // storing the value in an employee object
                Employee employeeValues = keyValuePair.Value;
                // printing the properties of the employee object
                Console.WriteLine($"Employee Name: {employeeValues.Name}, Employee Role: {employeeValues.Role}, Employee Age: {employeeValues.Age}, Employee Salary: {employeeValues.Salary}");
            }
            Console.Read();
        }
    }
    class Employee
    {
        public string Role { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public float Rate { get; set; }
        public float Salary { get { return Rate * 8 * 5 * 4 * 12; } }

        public Employee(string role, string name, int age, float rate)
        {
            Role = role;
            Name = name;
            Age = age;
            Rate = rate;
        }
    }

## 104 Stacks and Queues

### The Stack - LIFO

Stores the data in the form of a stack

- Data can be added/removed from top
- Can't access the elements in the middle
- LIFO - Last In, First Out 

#### Stacks in programming

- Reversing data (from 1-9 to 9-1)
- Web browser back button
- Undo/redo buttons

#### Stack operations

- push - Push(object obj) - Add data to the stack.
- Pop - Object Pop() - Remove data from the top of the stack
- Peek - Peek() - Reurns the data object from the top of the stack without removing it.

### Queues - FIFO

- Data can be added from the rear (back) and removed from the front (like airport queues)
- Cant access the elements in the middle
- FIFO - First In, First Out

#### Queues in programming

- OS IO requests, mouse movements
- Managing web requests in a server (handling congestions)
- Qeuing input in video games

##### Queues operations

- Enqueue(Object obj) - From the rear (back of the queue)
- Object Dequeue() - Remove data from the front
- Object Peek() - Returning the object from the front of the queue without removing it.

## 105 - Stacks in C#
From the System.Collections.Generic namespace so the stack can only be of one type (Generic). You cannot pop and item from and empty stack!

    static void Main(string[] args)
        {
            // Defining a new stack
            Stack<int> stack = new Stack<int>();
            int poppedValue;
            // Can't pop from empty stack, so good Idea to check first!
            if (stack.Count > 0)
            {
                poppedValue = stack.Pop();
                Console.WriteLine($"Popped value: {poppedValue}");
            }
            else
            {
                Console.WriteLine("You can not pop from an empty stack!");
            }

            // add element to top of stack
            stack.Push(5);
            stack.Push(99);
            stack.Push(500);
            Console.WriteLine($"Top value of the stack: {stack.Peek()}");
            // Look at the top element without removing it - Peek()
            Console.WriteLine("Peek()");
            stack.Push(1);
            Console.WriteLine($"Top value of the stack: {stack.Peek()}");
            stack.Push(8);
            Console.WriteLine($"Top value of the stack: {stack.Peek()}");
            stack.Push(-56);
            Console.WriteLine($"Top value of the stack: {stack.Peek()}");
            stack.Push(15015);
            Console.WriteLine($"Top value of the stack: {stack.Peek()}");

            // Remove last item - pop()
            Console.WriteLine("\nPop()");
            Console.WriteLine($"Top value of the stack: {stack.Peek()}");
            poppedValue = stack.Pop();
            Console.WriteLine($"Removed value: {poppedValue}");
            Console.WriteLine($"Top value of the stack: {stack.Peek()}");

            Stack<int> stackNumber = new Stack<int>();
            stackNumber.Push(99);
            stackNumber.Push(55);
            stackNumber.Push(66);
            stackNumber.Push(11);

            

            Console.WriteLine($"Initial count: {stackNumber.Count()}");
            while (stackNumber.Count > 0)
            {

                Console.WriteLine($"Last number in stack: {stackNumber.Peek()}");
                Console.WriteLine($"Number removed from the stack (LIFO): {stackNumber.Pop()}");
                Console.WriteLine($"Initial count: {stackNumber.Count()}");
            }


            Console.WriteLine("#### Reverse order ####");
            int[] numbers = new int[] { 8, 2, 3, 4, 5, 7, 8, 9, 2 };
            // define a new stack to reverse order
            Stack<int> myStack = new Stack<int>();

            Console.WriteLine("The numbers in the array are: ");
            //foreach loop
            foreach (int num in numbers)
            {
                // print the num
                Console.Write($"{num}, ");
                // push it into myStack
                myStack.Push(num);
            }

            Console.WriteLine("\nThe numbers in reverse: ");
            while (myStack.Count>0)
            {
                // pop it and store it in a variable
                int number = myStack.Pop();
                // print the value we pop
                Console.Write($"{number}, ");
            }

            Console.Read();
        }

## 106 Queues

    class Program
    {
        static void Main(string[] args)
        {
            // define a queue
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);

            // printing the element at the front of the queue, the first value will be shown (1)
            queue.Enqueue(5);
            queue.Enqueue(7);
            queue.Enqueue(6);
            queue.Enqueue(99);
            Console.WriteLine($"The value at the front of the queue is: {queue.Peek()}");
            queue.Enqueue(2);
            Console.WriteLine($"First value in the queue is: {queue.Peek()}");
            queue.Enqueue(3);
            // removes number 1
            int queueItem = queue.Dequeue();
            Console.WriteLine($"New first item now: {queue.Peek()}");
            Console.WriteLine($"\nFirst value in the queue is: {queue.Peek()}");

            while (queue.Count > 0)
            {
                Console.WriteLine($"The front value {queue.Dequeue()} was remove from the queue.");
                Console.WriteLine($"Current queue count is: {queue.Count}");
            }

            Console.WriteLine("\n#### EXAMPLE QUEUE ####");
            Queue<Order> ordersQueue = new Queue<Order>();

            foreach (Order order in RecieveOrdersFromBranch1())
            {
                ordersQueue.Enqueue(order);
            }
            foreach (Order order in RecieveOrdersFromBranch2())
            {
                ordersQueue.Enqueue(order);
            }

            // as long as the order at the front of the que is not empty
            while (ordersQueue.Count>0)
            {
            // store it in a variable called currentOrder
            Order currentOrder = ordersQueue.Dequeue();
            //Processor the order
            currentOrder.processOrder();
            }

            Console.Read();
        }
        static Order[] RecieveOrdersFromBranch1()
        {
            // creating new orders
            Order[] orders = new Order[]
            {
                new Order(1,5),
                new Order(2,4),
                new Order(6,1)
            };
            return orders;
        }
        static Order[] RecieveOrdersFromBranch2()
        {
            // creating new orders
            Order[] orders = new Order[]
            {
                new Order(3,5),
                new Order(4,4),
                new Order(5,10)
            };
            return orders;
        }
    }
    class Order
    {
        public int ID { get; set; }
        public int OrderQty { get; set; }
        public Order(int id, int orderQty)
        {
            ID = id;
            OrderQty = orderQty;
        }
        public void processOrder()
        {
            Console.WriteLine($"Order: {ID} processed!");
        }
    }

