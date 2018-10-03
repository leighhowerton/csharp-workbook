using System;
					
public class Program
{
	public static void Main()
	{
		string name = "";
		int age = 0;
		int year = 0;
		string eyes = "";
		int height = 0;
		
		Console.WriteLine("Please enter your name: ");
		name = Console.ReadLine();
		Console.WriteLine("Please enter your age: ");
		age = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Please enter the year: ");
		year = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Please enter your eye color: ");
		eyes = Console.ReadLine();
		Console.WriteLine("Please enter your height in feet: ");
		height = Convert.ToInt32(Console.ReadLine());
		
		Console.WriteLine("Hello! My name is {0} and I am {1} years old. I was born in {2}. I have {3} eyes. I am {4} feet tall.", name, age, year-age, eyes, height);
	}
}