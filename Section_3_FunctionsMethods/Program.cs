using System;

namespace Section_3_FunctionsMethods
{
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
   
}
