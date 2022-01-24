using System;

namespace Challenge_1_section_3
{
    /* Challenge - Methods
     * create three variables with names of your friends.
     * create a Method "GreetFriend" which writes something like: 
     * "Hi Frank, my friend!" onto the console, once it is called.
     * Where "Frank" should be replaced with the Name behind the argument 
     * given to the Method when it's called. So the method will need a parameter 
     * (decide which DataType will be best). 
     * 
     * Greet all your three friends.
     */
    class Program
    {
        static void Main(string[] args)
        {
            string friend = "Stefan";
            string friend2 = "Viggo";
            string friend3 = "Rebecca";
            Console.WriteLine("Without returning anything - Void");
            GreetFriendVoid(friend);
            GreetFriendVoid(friend2);
            GreetFriendVoid(friend3);

            Console.WriteLine("\nWith Return statement");
            Console.WriteLine(GreetFriend(friend));
            Console.WriteLine(GreetFriend(friend2));
            Console.WriteLine(GreetFriend(friend3));
           
            Console.WriteLine("\nWith multiple paramaters");
            GreetFriendManyThreeNames(friend, friend2, friend3);

            Console.Read();
        }
        public static void GreetFriendVoid(string name)
        {
            Console.WriteLine($"Hi {name}, my friend!");
        }
        public static string GreetFriend(string name)
        {
            return $"Hi {name}, my friend!";
        }

        public static void GreetFriendManyThreeNames(string name1, string name2, string name3)
        {
            Console.WriteLine($"Hi {name1}, my friend");
            Console.WriteLine($"Hi {name2}, my friend");
            Console.WriteLine($"Hi {name3}, my friend");
        }
    }
}
