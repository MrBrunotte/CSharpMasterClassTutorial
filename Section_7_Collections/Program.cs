using System;
using System.Collections;
using System.Collections.Generic;

namespace Section_7_Collections
{
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
                                  $"\nName: {temp.Name}, \nGPA: {temp.GPA}");
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
}
