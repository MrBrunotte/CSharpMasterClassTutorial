using System;

namespace Section_7_ch_2_jaggedArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a jagged array, whith 3 "friends array", in which to family members should be stored
            // Introduce family members from different families to each other via console

            string[] callesFamilj = new string[] { "Calle", "Faye", "Jasper", "Zach" };
            string[] christinesFamilj = new string[] { "Christine", "Janine", "Marcel" };
            string[][] familyMembers = new string[][]
            {
                new string[]{"Stefan", "Viggo"},            // column 0 row 0,1
                christinesFamilj,                           // row 0,1,2,3 (we are looking directly in the array)
                new string[]{"Ruth", "Jolie", "Xavier"},    // column 2 row 0,1,2
                callesFamilj                                // row 0,1,2 (we are looking directly in the array)
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
    }
}
