using System;

namespace week2_2practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int grade = 0;
            Console.WriteLine("Hello! Please enter a number.");
            String input = Console.ReadLine();
            grade = Convert.ToInt32(input);

            if(grade >= 90){
                Console.WriteLine("You made an A!");
            } else if (grade >= 80){
                Console.WriteLine("You made a B!");
            } else if (grade >= 70){
                Console.WriteLine("You made a C!");
            } else {
                Console.WriteLine("You failed the exam.");
            }



            Console.WriteLine("That's all.");
        }
    }
}
