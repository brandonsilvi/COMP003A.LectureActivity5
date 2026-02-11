using System;

namespace COMP003A.LectureActivity5
{
    class Program
    {
        static void Main(string[] args)
        {// The scope improves the programs safety by making variables local and avoids naming conflicts. 
            DisplayWelcome();  //method call

            string userName = "Alex";
            int userAge = 20;
            DisplayUserInfo(userName, userAge);
            int sum = CalculateSum(7, 8);
            Console.WriteLine($"The sum is: {sum}");

            if (true)
            { //variables declared within the {} do not exist outside the {} shielding us from accidental misuse.
                int blockVar = 100;
                Console.WriteLine(blockVar); //blockVar can only exist inside the if block
            }

            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine(i);
            }
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
        { //Method variables are not accessible in Main since each method has its own scope.
            return a + b;
        }

        static void DisplayNumber()
        {
            // Console.WriteLine(number); // cannot be accessed here.
        }
    }

}