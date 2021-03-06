# LOOPS

## 61 - Basics of loops

    // Loop types
    /*
        * for loop
        * while loop (check then go)
        * do while loop (do first then check)
        * foreach loop (run through an array or list)
        */

    // for loop
    for (start value; condition; increment)
    {
        //code body
    }

    // while loop use with numbers or bools
    counterVariable = 0;
    while (condition)
    {
        // execute your code
        counterVariable++;
    }

    // do while loop - do something as long as condition is met
    counterVariable = 0;
    do
    {
        //execute your code
        counterVariable++;
    } while (condition);

    // foreach loop
    foreach (var item in collection)
    {
        // execute code more in later chapters
    }

## 62 - for loops

    static void Main(string[] args)
    {
        Console.Write("prints 0-9: ");
        for (int counter = 0; counter < 10; counter++)
        {
            Console.Write(counter + ", ");
        }

        Console.Write("\nPrints 5-10: ");
        for (int counter = 5; counter <= 10; counter++)
        {
            Console.Write(counter + ", ");
        }

        Console.Write("\nPrints the odd numbers: ");
        for (int counter = 1; counter < 10; counter += 2)
        {
            Console.Write(counter + ", ");
        }

        Console.ReadLine();
    }

## 63 Do while loop

    static void Main(string[] args)
    {
        int counter = 15;
        // 16
        do
        {
            Console.WriteLine(counter);
            counter++;
        } while (counter < 5);
        // 17
        do
        {
            counter++;
            Console.WriteLine(counter);
        } while (counter < 5);

        // check lenght of text while carachters are less than 20
        int lengthOfText = 0;
        string wholeText = "";
        do
        {
            Console.Write("Please enter the name of your friend: ");
            string nameOfAFriend = Console.ReadLine();
            int currentLength = nameOfAFriend.Length;
            lengthOfText += currentLength;
            wholeText += nameOfAFriend + ", ";

        } while (lengthOfText < 20);
        Console.WriteLine(($"Thanks, that was enough! You wrote {wholeText}"));

        Console.Read();
    }

## 64 - While loop
    static void Main(string[] args)
    {
        // While loop
        int counter = 0;
        string enteredText = "";

        while (enteredText.Equals(""))
        {
            Console.WriteLine("Please press enter to increase amount by one and press any other key to stop and exit");
            enteredText = Console.ReadLine();
            counter++;
            Console.WriteLine("Current people count {0}", counter);
        }
        Console.WriteLine($"{counter} people are in the bus, press enter to exit!");
        Console.Read();
    }

## 65 - Break and continue

    static void Main(string[] args)
    {
        for (int counter = 0; counter < 10; counter++)
        {
            if (counter %2 == 0)
            {
                Console.WriteLine("Next number is odd!");
                continue;
            }
            if (counter == 7)
            {
                Console.WriteLine(counter);
                Console.WriteLine("We stop at 7");
                break;
            }
            if (counter == 5)
            {
                Console.WriteLine("We skip nr 5!");
                continue;
            }
            Console.WriteLine(counter);
        }
        Console.Read();
    }

## 66 - Challenge - Loop 1 Average

    class Program
    {
        /* Imagine you are a developer and get a job in which you need to create a program for a teacher. 
            * He needs a program written in c# that calculates the average score of his students. 
            * 
            * So he wants to be able to enter each score individually and then get the final average 
            * score once he enters -1. 
            * 
            * So the tool should check if the entry is a number and should add that to the sum. 
            * 
            * Finally once he is done entering scores, the program should write onto the console what the 
            * average score is. 
            * The numbers entered should only be between 0 and 20. 
            * 
            * Make sure the program doesn't crash if the teacher enters an incorrect value.
            * 
            * Test your program thoroughly.*/
        static void Main(string[] args)
        {
            string inputString = "0";
            int currentNumber = 0;
            int count = 0;
            int total = 0;

            // while this is true run the loop
            while (inputString != "-1")
            {
                Console.WriteLine($"Number of scores submitted: {currentNumber}");
                Console.WriteLine("Please enter a score: ");
                Console.WriteLine($"Current number of entries: {count}");
                Console.WriteLine("Enter -1 when you want to find out the average of your scores!");
                inputString = Console.ReadLine();

                // to exit the program, must be first otherwise it will not break the loop
                if (inputString == "-1")
                {
                    Console.WriteLine("-------------------------------");
                    // calculate score average from total and 
                    double average = (double)total / (double)count;
                    Console.WriteLine($"The average of your score is: {average}");
                    // break out of the loop
                    break;
                }

                // if inputString is a number between 0 and 20 (including 20)
                // add the number to the int total variable
                if (int.TryParse(inputString, out currentNumber) && currentNumber > 0 && currentNumber <= 20)
                {
                    // add the currentNumber to total
                    total += currentNumber;
                }
                else
                {
                    // If any string apart from "-1" then write the message, and continue the while loop
                    if (inputString != "-1")
                    {
                        Console.WriteLine("Please enter a value between 1-20");
                    }
                    // continue the loop
                    continue;
                }
                // add 1 to count (count the number of loops completed)
                count++;
            }
                Console.ReadLine();
        }
    }
