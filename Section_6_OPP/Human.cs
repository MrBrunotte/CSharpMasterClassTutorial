using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section_6_OPP
{
    class Human
    {
        string firstName;
        string lastName;
        string eyeColor;
        int age;

        //default contstructor
        public Human()
        {
            Console.WriteLine("Constructor called, object created!");
        }
        //Overloaded constructor 1
        public Human(string firstName, string lastName, string eyeColor)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.eyeColor = eyeColor;
        }
        //Overloaded constructor 2
        public Human(string firstName, string lastName, string eyeColor, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.eyeColor = eyeColor;
            this.age = age;
        }
        public void IntroduceMyself()
        {
            if (age <= 1)
            {
                Console.WriteLine($"Hi, my name is {firstName} {lastName} and my eye color is {eyeColor}");
            }
            else
            {
                Console.WriteLine($"Hi, my name is {firstName} {lastName} and my eye color is {eyeColor} and I am {age} years old.");
            }
                
        }
    }
}
