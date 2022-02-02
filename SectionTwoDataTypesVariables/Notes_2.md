# Nameing Convention

### Coding Standards

- Class, methtod :        GetSalary, use nounse like Program, 
- method arguments:       firstName, use verbs for methods
- Variable names:         No abriviations, easy to read   userFirstName
- Variables:              Use string, int, bool, instead of String Int32 Boolean
- Underscores:            Try do avoid underscores exept for some variables:  _login


- Reasonable Variable Name - Base the name that describes its use!
    int age;
    int userAge;
          
- Proper Method Name
    void CheckInternetConnections() {}
           
- Comments
    Use propper comments that describe the code
           
    // Single line comments
        // a bool to check if user is logged in
        bool isUserLoggedIn = true;
    *//* Mulitline comments
        These methods are responsible for storing 
        user data and connecting to the database  
               
    /// XML documentation comments
        ///<summary>
        //This method is very cool
        ///</summary>
        void CoolMethod(){ //cool code }

#### Value Types ----

Data types can be categorized into two categories based on how they occupy memory location

##### VALUE TYPE
Value type as the name suggests is a data type which when declared and assigned a value,
holds the value DIRECTLY on its own memory space
Uses the heap to store the value
Value types are: int, float, long, double, char, bool, decimal (the simple data types).

        int z = 234; // this is stored in RAM memory

##### REFERENCE TYPE
Reference type is a variable type which instead of storing the value in memory directly
stored the MEMORY LOCATION of the actual data.
The variable here stores the memory reference of the data and not the data directly.
Refernce data types are: string, class, Array (basically more complex data types that need more space)
when we copy this refrence type of data type it will just copy the memory address
of the data so we will then have two variables pointing to the same data.

              
##### Variables
Declaring a variable

    string firstName;
    int num1;

Declaring multiple variables at once

    int num3, num4, num5;

Assigning a value to the variable

    num1 = 50;
    Console.WriteLine(num1);

Declaring and initalizing a variable

    int num2 = 23;
    int sum = num1 + num2;

Concatination

    Console.WriteLine("num1 is " + num1 + " num2 " + num2);

Double

    double d1 = 3.1415;
    double d2 = 5.1;

    double doubledDiv = d1 / d2;
    Console.WriteLine("d1/d2=: " + doubledDiv);

Float

    float f1 = 3.1415f;
    float f2 = 5.1f;
    float fDiv = f1 / f2;
    Console.WriteLine("d1/d2=: " + fDiv);

    double dIDiv = d1 / num1;
    int dIDivInt = d1 / num1; // cannot divide a double with int!
    Console.WriteLine("d1/d2=: " + dIDiv);


##### Conversion Implicit & Explisit conversion
    double myDouble = 13.37;
    int myInt;

    // Implicit conversion from smaller to bigger types
    int num = 1235487;
    long bigNum = num;
    float myFloat = 13.37f;
    double myNewDouble = myFloat;

    // Cast double to int: Explicit conversion!
    myInt = (int)myDouble;
    Console.WriteLine(myInt);

    // TypeConversion - Convert string to int32 etc
    string stringNum = "55";
    myInt = Convert.ToInt32(stringNum);
    Console.WriteLine($"stringNum type: {stringNum} - {stringNum.GetType()}");
    Console.WriteLine($"myInt type: {myInt} - {myInt.GetType()}");

    stringNum = myFloat.ToString();
    Console.WriteLine(stringNum);

    // Bool type conversion
    bool isShining = false;
    string myBoolString = isShining.ToString();
    Console.WriteLine($"Is the sun shining? {myBoolString}");

##### Parsing a String to an Int 
    string myString = "15"; // can only be digits otherwise we will get an exception
    string mySecondString = "13";
    string result = myString + mySecondString;
    Console.WriteLine($"Adding two string variables: {result}\n");

    int num1 = Int32.Parse(myString);
    int num2 = Int32.Parse(mySecondString);
    int intResult = num1 + num2;
    Console.WriteLine($"Adding two parsed to Int32 string variables: {intResult}");

#####  String manipulation ----
    int age = 49;
    string name = "Stefan";
    string town = "Stockholm";

    // 1. string concatination
    Console.WriteLine("String concationation");
    Console.WriteLine("Hello my name is " + name + " I am " + age + " years old.");

    // 2. string formating - uses index
    Console.WriteLine("\nString Formating");
    Console.WriteLine("Hello my name is {0}, I am {1} years old and I live in {2}.", name, age, town);
            
    // 3. string Intepolation
    Console.WriteLine("\nString Interpolation $");
    Console.WriteLine($"Hello my name is {name} and I am {age} years old. I live in {town}.");

    // 4. Verbatim strings
    // verbatim strings start with @ and tells the compiler to take the string
    // literally and ignore spaces and escape characters line \n

    // useful when you for example want to write a file path:
    // C:\Users\brunoste\OneDrive - Prog-It Oy\Skrivbordet\Egna saker
    Console.WriteLine("\nVerbatim strings");
    Console.WriteLine(@"File path ==> C:\Users\brunoste\OneDrive - Prog-It Oy\Skrivbordet\Egna saker");
    Console.WriteLine();
    Console.WriteLine(@"Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. 
     aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nul pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.");

##### String and its methods ----

SubString(Int32) - Is used to get the Substring from the string, starting from the specified index.
Trim() - is used to trim all leading and trailing white spaces from the string.
IndexOf(string) - Is used to get the first occurrence of the string character inside the string.
              
String.Format method is used to insert the object or variable value inside any string.
with the String.Format we can replace the value in the specified format.

    string firstName = "Stefan";
    string lastName = "Brunotte";
    string trim = "      Trims away whitespace bofore and after     ";

    string fullName = string.Concat(firstName, " ",lastName);
    Console.WriteLine(fullName);
    Console.WriteLine(fullName.Substring(3));
    Console.WriteLine(fullName.ToLower());
    Console.WriteLine(trim);
    Console.WriteLine(trim.Trim());
    Console.WriteLine(fullName.IndexOf('e'));
    Console.WriteLine(string.IsNullOrWhiteSpace(firstName));

    Console.WriteLine();

    Console.WriteLine(String.Format("StringFormat () ==> My name is {0}", fullName));


