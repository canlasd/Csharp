using System;
 

class Lesson8
{

	public static void Main()
	{
		String strNumber;
		int number, count;

		Console.Out.WriteLine("How many times do you want to say hello?");
		strNumber = Console.ReadLine();
		number = Convert.ToInt32(strNumber);

		count = 1;

		while (count <= number)
		{
			Console.Out.WriteLine("Hello");
			count = count +1;

		}

	}

}


			