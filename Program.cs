using System;

namespace COMP003A.Assignment5
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayWelcome();  //method call

            string userName = "Alex";
            int userAge = 20;
            DisplayUserInfo(userName, userAge);
            int sum = CalculateSum(7, 8);
        }




        //methods _______
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to Module 5!");
        }

        static void DisplayUserInfo(string name, int age)
        {
            Console.WriteLine($"Name: {name}, Age: {age}");
        }

        static int CalculateSum(int a, int b)
        {
            return a + b;
        }

        static void DisplayNumber()
        {
            // Console.WriteLine(number); // cannot be accessed here.
        }
    }

}