# NOTES SECTION THREE

### METHODS AND FUNCTIONS
How to structure my code.

- Intro to Functions/Methods

#### METHOD:
A method is a code block that contains a series of statements. A program causes the
statements to be executed by calling the method and specifying any required method 
arguments. in C#, every executed instruction is performed in the context of a method.
The Main method is the entry point for every C# application and it is called by the
Common language runtime (CLR) when the program is started.

Syntax of a Method

    <Access Specifier><Return Type><Method Name>(Parameter List) 
                { 
                    Method Body
                }

https://www.tutorialspoint.com/csharp/csharp_methods.htm
- Access Specifier −  This determines the visibility of a variable or a method from another class.
- Return type −       A method may return a value. The return type is the data type of the value the 
                    method returns. If the method is not returning any values, 
                    then the return type is void.
- Method name −       Method name is a unique identifier and it is case sensitive. 
                    It cannot be same as any other identifier declared in the class.
- Parameter list −    Enclosed between parentheses, the parameters are used to pass and receive data 
                    from a method. The parameter list refers to the type, order, and number of the 
                    parameters of a method. Parameters are optional; that is, a method may contain 
                    no parameters.
- Method body −       This contains the set of instructions needed to complete the required activity.

## 37 - void Methods

    static void Main(string[] args)
            {
                WriteSomething();
                WriteSomethingSpecific("I am anther argument and called from a method");
                Console.Read();
            }
            // assess modifier (static) return type method name (parameter list seperated with comma)
            // needs to be static because the Main() is static!
            public static void WriteSomething()
            {
                Console.WriteLine("I am called from a method");
            }
            public static void WriteSomethingSpecific(string myText)
            {
                Console.WriteLine(myText);
            }

## 38 - Methods With Return Value And Parameters

    class Program
        {
            static void Main(string[] args)
            {
                //int result = Add(15, 32);
                Console.WriteLine(Add(Add(3, 10), Add(2, 5)));
                Console.WriteLine(Add(15, 32));
                Console.WriteLine(Multiply(1, 2.2));
                Console.WriteLine(Devide(1.0, 2.0));
                Console.WriteLine(FullName("Stefan", "Brunotte"));
                Console.Read();
            }
            public static int Add(int num1, int num2)
            {
                return num1 + num2;
            }
            private static double Devide(double num1, double num2)
            {
                return num1 / num2;
            }

            public static double Multiply(double doubleNum1, double doubleNum2)
            {
                return doubleNum1 * doubleNum2;
            }

            public static string FullName(string firstName, string lastName)
            {
                return firstName + " " + lastName;
            }
        }

## 39 - Challenge 3.1 

    static void Main(string[] args)
            {
                string friend = "Stefan";
                string friend2 = "Viggo";
                string friend3 = "Rebecca";
                Console.WriteLine("Without returning anything - Void");
                GreetFriendVoid(friend);
                GreetFriendVoid(friend2);
                GreetFriendVoid(friend3);

                Console.WriteLine("\nWith Return statement");
                Console.WriteLine(GreetFriend(friend));
                Console.WriteLine(GreetFriend(friend2));
                Console.WriteLine(GreetFriend(friend3));
           
                Console.WriteLine("\nWith multiple paramaters");
                GreetFriendManyThreeNames(friend, friend2, friend3);

                Console.Read();
            }
            public static void GreetFriendVoid(string name)
            {
                Console.WriteLine($"Hi {name}, my friend!");
            }
            public static string GreetFriend(string name)
            {
                return $"Hi {name}, my friend!";
            }

            public static void GreetFriendManyThreeNames(string name1, string name2, string name3)
            {
                Console.WriteLine($"Hi {name1}, my friend");
                Console.WriteLine($"Hi {name2}, my friend");
                Console.WriteLine($"Hi {name3}, my friend");
            }

## 41 - User input

    static void Main(string[] args)
            {

                Console.WriteLine(AddUserInput());

                Console.Read();
            }
            public static int AddUserInput()
            {
                Console.Write("Please type a number: ");
                string input1 = Console.ReadLine();
                Console.Write("Please type a second number: ");
                string input2 = Console.ReadLine();

                int num1 = int.Parse(input1);
                int num2 = int.Parse(input2);

                int result = num1 + num2;

                return result;
            }

## 42 - Try Catch Finally

    static void Main(string[] args)
            {
                Console.Write("Please enter a number: ");
                string userInput = Console.ReadLine();
                Console.Write("Please enter a second number: ");
                string userInput2 = Console.ReadLine();

                try
                {
                    int userInputAsInt = int.Parse(userInput);
                    int userInputAsInt2 = int.Parse(userInput2);
                    int result = userInputAsInt / userInputAsInt2;
                    Console.WriteLine($"You divided {userInputAsInt} / {userInputAsInt2} and the result is: {result}");
                }
                catch (DivideByZeroException)
                {
                    //throw;
                    Console.WriteLine("Format exception, you cannot divide 0/0!");
                }
                catch (FormatException)
                {
                    //throw;
                    Console.WriteLine("Format exception, please enter the correct type next time");
                }
                catch (OverflowException)
                {
                    //throw;
                    Console.WriteLine("Format exception, the number is to large or to small for the type integer");
                }
                catch (ArgumentNullException)
                {
                    //throw;
                    Console.WriteLine("Format exception, you need to enter a numbeer");
                }
                finally
                {
                    // this is were you can close a connection or file etc...
                    Console.WriteLine("This is called anyways!");
                }

                Console.Read();
            }

## 43 - Operators

    static void Main(string[] args)
            {
                int num1 = 5;
                int num2 = 3;
                int num3;

                // unary opeators mulitplies it with - 1
                num3 = -num1;
                Console.WriteLine($"num3 is {num3}");

                bool isSunny = true;
                Console.WriteLine($"\nIs it sunny? {!isSunny}"); // negates isSunny to false

                //Increment operators
                int num = 0;
                num++;
                Console.WriteLine($"\nnum is {num}");
                Console.WriteLine($"num is {++num}"); // post increments before
                Console.WriteLine($"num is {num++}");   // pre increments after
                Console.WriteLine($"num is {num}");

                // decrement operators
                num--;
                Console.WriteLine($"\nnum is {num}");
                Console.WriteLine($"num is {--num}"); // post decrements before
                Console.WriteLine($"num is {num--}");   // pre deccrements after
                Console.WriteLine($"num is {num}");

                int result;
                Console.Write($"\nnum1 is: {num1}, num2 is {num2}");
                result = num1 + num2;
                Console.WriteLine($"Result of num1 + num2 is: {result}");

                result = num1 - num2;
                Console.WriteLine($"Result of num1 - num2 is: {result}");

                result = num1 / num2;
                Console.WriteLine($"Result of num1 / num2 is: {result}");

                result = num1 * num2;
                Console.WriteLine($"Result of num1 * num2 is: {result}");
            
                result = num1 % num2;
                Console.WriteLine($"Result of reminder of num1 % num2 is: {result}");

                // relational and type operators
                bool isLower;
                isLower = num1 < num2;
                Console.WriteLine($"Is num1 < num2?: {isLower}");
                isLower = num1 > num2;
                Console.WriteLine($"Is num1 > num2?: {isLower}");

                // equality operator
                bool isEqual;
                isEqual = num1 == num2;
                Console.WriteLine($"Is num1 = num2?: {isEqual}");
                isEqual = num1 != num2;
                Console.WriteLine($"Is num1 != num2?: {isEqual}");

                // conditional operators - AND &&
                bool isLowerAndSunny;
                isLowerAndSunny = isLower && isSunny; // condition 1 AND condition 2
                Console.WriteLine($"Is isLower: ({isLower}) AND isSunny ({isSunny}) True??: \t{isLowerAndSunny}");

                // comparative operator - OR || (both conditions have to be true!)
                isLowerAndSunny = isLower || isSunny; // condition 1 AND condition 2
                Console.WriteLine($"Is isLower: ({isLower}) OR isSunny ({isSunny}) True??: \t{isLowerAndSunny}");

                Console.Read();


