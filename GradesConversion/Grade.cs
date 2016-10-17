using System;

namespace Grades
{
	class Grades
	{
		static void Main(string[] args)
		{
			string grade, input;

			Console.WriteLine("What is your grade?");
			input = Console.ReadLine();
			grade = input;

			switch (grade)
			{
				case "A":
					Console.WriteLine("You got the score between 70-100");
					break;
				case "B":
					Console.WriteLine("You got the score between 60-69");
					break;
				case "C":
					Console.WriteLine("You got the score between 50-59");
					break;
				case "D":
					Console.WriteLine("You got the score between 40=49");
					break;
				case "F":
					Console.WriteLine("You got the score between 0-39");
					break;
				default:
					Console.WriteLine("Weird grade");
					break;

			}
		}
	}
}