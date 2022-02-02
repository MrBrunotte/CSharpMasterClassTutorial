# Object Oriented Programming

## Class

- A class is a blue print of an object
- It has actions/abilities, so called member functions or methods
- It has propeties, member variables
- Inheritance possible
- can be used like a Datatype (e.g. String is a class, string is variable type)


### Object

Properties are:
- Wheels
- Doors
- Color
etc...

Abilities are
- Drive
- Break
- Open Window

Inheritance
- Dog < Boston terrier < black

## 71 - Our first Class
#### Program.cs
    class Program
    {
        static void Main(string[] args)
        {
            // create an ojbect of my class
            // create an instance of the class Human
            Human stefan = new Human();
            // access public variable from outside, and i can change it
            stefan.firstName = "Stefan";
            // Call methods of the class
            stefan.IntroduceMyself();
            Human michael = new Human();
            michael.IntroduceMyself();


            //Challenge
            Console.WriteLine("\n----- Challenge -----");
            HumanChallenge fullname = new HumanChallenge();
            fullname.firstNameCh = "Stefan";
            fullname.lastNameCh = "Brunotte";
            fullname.IntroduceMyselfChallenge();

            Console.Read();
        }
    }

#### Human.cs 
    // this class is a blueprint for a datatype
    class Human
    {
        //member variables protected and can only be used in the Human class
        string firstNameProtected;
        // member variable not protected
        public string firstName = "Michael";

        // member method
        public void IntroduceMyself()
        {
            Console.WriteLine($"Hi, my name is {firstName}");
        }
    }

    class HumanChallenge
    {
        // Create a public variable lastName of type string
        // Change the IntroduceMyself() method so it tells the whole name
        // Create two objects with full information about themself - firstName and lastName

        public string firstNameCh;
        public string lastNameCh;

        public void IntroduceMyselfChallenge()
        {
            Console.WriteLine($"Hello, my full name is: {firstNameCh} {lastNameCh}");
        }
    }

## 72 - Using Constructors
##### Program class 
    class Program
    {
        static void Main(string[] args)
        {
            Human stefan = new Human("stefan", "Brunotte");
            stefan.IntroduceMyself();
            Human viggo = new Human("Viggo", "Brunotte");
            viggo.IntroduceMyself();

            Console.Read();
        }
    }

##### Human class
    class Human
        {
            // with the constructor the fields dont need to be public any more
            string firstName;
            string lastName;

            // constructor with same name as class
            public Human(string myFirstName, string lastName)
            {
                // two ways to set the variables
                firstName = myFirstName;
                this.lastName = lastName;
            }
            public void IntroduceMyself()
            {
                Console.WriteLine($"Hi, my name is {firstName} {lastName}");
            }
        }

##### Challenge
Add two more member variables to "HumanChallenge" - eyeColor and age
adjust the constructor, so it requires all of the four variables to be used when
creating an object of this class
create two objects of type HumanChallenge.

----- Challenge -----

- Hi there, my name is: Stefan Brunotte and I am 49 years old and have blue eyes!
- Hi there, my name is: Viggo Brunotte and I am 3 years old and have brown eyes!

##### Program class
    static void Main(string[] args)
        {
            //Challenge
            Console.WriteLine("\n----- Challenge -----");
            HumanChallenge dad = new HumanChallenge("Stefan", "Brunotte", "blue", 49);
            HumanChallenge son = new HumanChallenge("Viggo", "Brunotte", "brown", 3);
            dad.IntroduceMyself();
            son.IntroduceMyself();

            Console.Read();
        }

##### HumanChallenge class
    class HumanChallenge
    {
        /* Add two more member variables to "HumanChallenge" - eyeColor and age
         * adjust the constructor, so it requires all of the four variables to be used when
         * creating an object of this class
         * create two objects of type HumanChallenge
         */

        string firstNameCh;
        string lastNameCh;
        string eyeColorCh;
        int ageCh;

        public HumanChallenge(string firstName, string lastName, string eyeColor, int age)
        {
            this.firstNameCh = firstName;
            this.lastNameCh = lastName;
            this.eyeColorCh = eyeColor;
            this.ageCh = age;
        }

        public void IntroduceMyself()
        {
            if (ageCh <= 1)
            Console.WriteLine($"Hi there, my name is: {firstNameCh} {lastNameCh} and I am {ageCh} year old and have {eyeColorCh} eyes!"); 
            else
            Console.WriteLine($"Hi there, my name is: {firstNameCh} {lastNameCh} and I am {ageCh} years old and have {eyeColorCh} eyes!");
        }
    }

## 73 - Using Multiple Constructors (overloaded)
###### Program.cs
A constructor can be parameterized or non-parameterized (default).
To have multiple constructors we need to change the constructors signature!

    class Program
    {
        static void Main(string[] args)
        {
            Human basic = new Human();
            Console.WriteLine("Datatype ==> " + basic.GetType());
            // Overloaded parameterized constructor 1
            Human stefan = new Human("stefan", "Brunotte", "blue", 49);
            stefan.IntroduceMyself();
            // Overloaded parameterized constructor 2
            Human viggo = new Human("Viggo", "Brunotte", "brown", 1);
            viggo.IntroduceMyself();

            Console.Read();
        }
    }
###### Human.cs

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

## 74 - Access Modifiers
C# provides four types of access modifiers: private, public, protected, internal, and two combinations: protected-internal and private-protected.

##### Private Access Modifier - available in "this" class or struct only
Objects that implement private access modifiers are accessible only inside a class or a structure. As a result, we can’t access them outside the class they are created

##### Public Access Modifier - no restriction
Objects that implement public access modifiers are accessible from everywhere in our project. Therefore, there are no accessibility restrictions

##### Protected Access Modifier - Inside the class and all derived classes
The protected keyword implies that the object is accessible inside the class and in all classes that derive from that class.

##### Internal Access Modifier - In its own assembly
The internal keyword specifies that the object is accessible only inside its own assembly but not in other assemblies

##### Protected Internal Access Modifier
The protected internal access modifier is a combination of protected and internal. As a result, we can access the protected internal member only in the same assembly or in a derived class in other assemblies (projects)

##### Private Protected Access Modifier
The private protected access modifier is a combination of private and protected keywords. We can access members inside the containing class or in a class that derives from a containing class, but only in the same assembly(project). Therefore, if we try to access it from another assembly, we will get an error

## 75, 75 - Properties
