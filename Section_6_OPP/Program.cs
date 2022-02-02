using System;

namespace Section_6_OPP
{
    class Program
    {
        static void Main(string[] args)
        {
            Box box = new Box();
            box.SetLength(5);
            box.height = 4;
            box.width = 5;
            box.DispalyInfo();

            Console.Read();
        }
    }
}
