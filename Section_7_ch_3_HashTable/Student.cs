using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section_7_ch_3_HashTable
{
    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int GPA { get; set; }

        public Student(int id, string name, int gpa)
        {
            ID = id;
            Name = name;
            GPA = gpa;
        }
    }
}
