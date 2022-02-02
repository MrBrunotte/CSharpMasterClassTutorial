# Making Decisions in C# || If, switch etc...

## 47 - Introduktion to Decision Making in C#

static void Main(string[] args)
        {
            Console.Write("Enter the temperature: ");
            int temperature = int.Parse(Console.ReadLine());
            if (temperature < 20)
            {
                Console.WriteLine("Its cold, put on your coat!");
            }
            else if (temperature== 20)
            {
                Console.WriteLine("Its 20 degrees Celcius outside!");
            }
            else
            {
                Console.WriteLine("Its warm outside!");
            }

            Console.Read();
        }

## 48 - TryParse()

You can parse numeric data types as int, float, double etc

Parsing to an int
string int = "128"          WORKS
string int = "128xyz"       FAILS

Parsing to an float
string int = "12.82"          WORKS
string int = "12.82xyz"       FAILS

static void Main(string[] args)
        {
            // TryParse
            string numberAsString = "128";
            int parsedValue;

            // The returned boolean is true when parsing was successful
            bool success = int.TryParse(numberAsString, out parsedValue);

            if (success)
                Console.WriteLine($"Parsing int successful - number is {parsedValue}");
            else
                Console.WriteLine("Parsing int failed!");

            // TryParse - float
            string numberAsStringFloat = "129";
            float parsedFloatValue;
            // The returned boolean is true when parsing was successful
            bool successFloat = float.TryParse(numberAsStringFloat, out parsedFloatValue);

            if (successFloat)
                Console.WriteLine($"Parsing float successful - number is {parsedFloatValue}");
            else
                Console.WriteLine("Parsing float failed!");

            Console.Read();
        }

## 49 - IF and Else If + TryParse

static void Main(string[] args)
        {
            Console.Write("Enter the temperature: ");
            string temp = Console.ReadLine();
            int temperature;
            int number;
            bool userEnteredANumber = int.TryParse(temp, out number);

            if(userEnteredANumber)
            {
                temperature = number;
            }
            else
            {
                temperature = 0;
                Console.WriteLine("Value entered, was no number. 0 set as temperature");

            }

            if (temperature < 20)
            {
                Console.WriteLine("Its cold, put on your coat!");
            }
            else if (temperature == 20)
            {
                Console.WriteLine("Its 20 degrees Celcius outside!");
            }
            else
            {
                Console.WriteLine("Its warm outside!");
            }

            Console.Read();
        }

## 51 - Challenge

/* Create a user Login System, where the user can first register and then Login in. 
         * The Program should check if the user has entered the correct username and password, 
         * when login in (so the same ones that he used when registering).
         * 
         * As we haven't covered storing data yet, just create the program in a way, that 
         * registering and logging in, happen in the same execution of it.
         * 
         * User If statements and User Input and Methods to solve the challenge.
         */

         ---- solution 1 ----
static void Main(string[] args)
        {
            // without Method - Only if statements
            string name;
            string userName;
            string password;
            string userNameInput;
            string passwordInput;
            Console.WriteLine("---- USER LOGIN ----");
            Console.Write("Register your username: ");
            userName = Console.ReadLine();
            Console.Write("Register your password: ");
            password = Console.ReadLine();

            Console.Write("\nEnter your username: ");
            userNameInput = Console.ReadLine();
            Console.Write("Enter your password: ");
            passwordInput = Console.ReadLine();

            if (userName == userNameInput && password == passwordInput)
            {
                Console.WriteLine($"\nHi there {userName}, you are now logged in!");
            }
            else
            {
                Console.WriteLine("\nSorry, your username and password don't match!");
            }
            Console.Read();
        }

        ----- Better Solution ----
        static string userName;
        static string password;
        static void Main(string[] args)
        {
            Register();
            Login();
            Console.Read();
        }

        public static void Register()
        {
            Console.WriteLine("---- REGISTER ----");
            Console.Write("Enter a username: ");
            userName = Console.ReadLine();
            Console.Write("Enter a password: ");
            password = Console.ReadLine();
            Console.WriteLine($"Your credentials are: {userName} & {password}");
        }

        public static void Login()
        {
            Console.WriteLine("\n---- LOGIN ----");
            Console.Write("Enter your username: ");

            if (userName == Console.ReadLine())
            {
                Console.Write("Enter your password: ");
                if (password == Console.ReadLine())
                {
                Console.WriteLine("You are now logged in!");
                }
                else
                {
                    Console.WriteLine("Wrong password, loggin failed!");
                }
            }
            else
            {
                Console.WriteLine("Wrong username, loggin failed!");
            }
        }

## 53 - Switch statement
static void Main(string[] args)
        {
            Console.WriteLine("\n---- switch with int ----");
            Console.Write("How old are you? ");
            int age = int.Parse(Console.ReadLine());

            switch (age)
            {
                case 15:
                    Console.WriteLine("To young to get in to the club!");
                    break;
                case 21:
                    Console.WriteLine("You are old enough to get in to the club!");
                    break;
                case 49:
                    Console.WriteLine("You are the perfect age, the ladies will love you!");
                    break;
            }

            Console.WriteLine("\n---- if-statement ----");
            Console.Write("Enter your age: ");
            int age1 = int.Parse(Console.ReadLine());
            if (age1 <= 15)
            {
                    Console.WriteLine("To young to get in to the club!");
            }
            else if (age1 >= 21 && age1 <=48)
            {
                    Console.WriteLine("You are old enough to get in to the club!");
            }
            else if (age1 == 49)
            {
                Console.WriteLine("You are the perfect age, the ladies will love you!");
            }
            else
            {
                Console.WriteLine("You are so old you can do anyting you want!!");
            }
            Console.WriteLine("\n---- switch with strings ----");
            
            Console.Write("Enter your username: ");
            string username = Console.ReadLine();
            switch (username)
            {
                case "Stefan":
                    Console.WriteLine("Username is Stefan");
                    break;
                case "root":
                    Console.WriteLine("Username is root");
                    break;
                default:
                    Console.WriteLine("Username is Unknown");
                    break;
            }
            Console.Read();
        }

## 54 - Challenge If statements 2

// global variables
        static int highScore = 55;
        static string highScoreplayer = "Viggo";

        static void Main(string[] args)
        {
            ScoreCheck(1, "");
            Console.Read();
        }
        
        public static void ScoreCheck(int score, string playerName)
        {
            Console.Write("Enter your name: ");
            playerName = Console.ReadLine();
            Console.Write("Enter you new score: ");
            score = int.Parse(Console.ReadLine());
            Console.WriteLine($"\nCurrent highscore: {highScore} held by: {highScoreplayer}");

            if (score > highScore)
            {
                // update the new highscore and who holds it.
                highScore = score;
                highScoreplayer = playerName;

                Console.WriteLine($"New highscore is {score}!!!!");
                Console.WriteLine($"New highscore holder is {playerName}, CONGRATULATIONS!!!!");
            }
            else if (score == highScore)
            {
                Console.WriteLine($"Your score was: {score}");
                Console.WriteLine($"The current highscore is {highScore}, this is a tie!! ");
            }
            else
            {
                Console.WriteLine($"The old highscore of {highScore} could not be broken");
            }
            Console.WriteLine($"\nNew highscore: {highScore} held by: {highScoreplayer}");
        }

## 56 - Enhanced if statements - Ternary Operator

static void Main(string[] args)
        {
            // Ternary operator - one if statement in one row
            /* condition ? first_expression : second_expression
             * condition has to be either true or false
             * The condition operator is right - associative
             * the expression a ? b : c ? d :e
             * is evaluated as a? b : (c ? d : e)
             * not as (a ? b : c)? d: e
             * The conditional operator cannot be overloaded
             */

            int temperature = -5;
            string stateOfMatter;
            if (temperature < 0)
                stateOfMatter = "solid";
            else if (temperature >= 100)
            {
                stateOfMatter = "gas";
            }
            else
                stateOfMatter = "liquid";
            Console.WriteLine($"State of matter is {stateOfMatter}");

            // Ternary operator
            temperature += 30;

            stateOfMatter = temperature < 0 ? "solid" : "liquid";

            Console.WriteLine($"State of matter is {stateOfMatter}");

            // Ternary operator as a if/else statement
            temperature = 100;

            stateOfMatter = temperature >= 100 ? "gas" : temperature < 0 ? "solid" : "liquid";

            Console.WriteLine($"State of matter is {stateOfMatter}");
            Console.Read();
        }

## 57, 58 - Ternary Challenge

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

