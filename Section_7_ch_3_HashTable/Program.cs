using System;
using System.Collections;

namespace Section_7_ch_3_HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. create a hashtable called studentHashTable
            Hashtable studentHashTable = new Hashtable();
            //2. create a students array with index 5
            Student[] students = new Student[5];
            students[0] = new Student(1, "Denis", 88);
            students[1] = new Student(2, "Olaf", 97);
            students[2] = new Student(3, "Ragner", 65);
            students[3] = new Student(1, "Louise", 73);
            students[4] = new Student(5, "Levi", 58);

            //3. foreach loop that adds the students to the Hashtable
            foreach (Student s in students)
            {
                if (!studentHashTable.ContainsKey(s.ID))
                {
                    studentHashTable.Add(s.ID, s);
                    Console.WriteLine($"Student with ID {s.ID} was added.\n");
                }
                else
                {
                    Console.WriteLine($"Sorry! A student with the same ID already exists (ID: {s.ID}\n");
                }
            }
            Console.Read();
        }
    }

}
