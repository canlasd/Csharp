using System;
 

class Lesson7
{

	public static void Main()
	{
		String strLetter;
		char letter;

		Console.Out.WriteLine("Enter your Letter Grade:  ");
		strLetter = Console.ReadLine();
		letter = Convert.ToChar(strLetter);

		Console.Out.WriteLine("Your grade is " + getMessageSwitch(letter));
	}

	public static String getMessageSwitch(char grade)

	{
	
		String message;
		switch (grade)

		{

			case 'a':
			case 'A':
				message = "Outstanding";
				break;

			case 'c':
			case 'C':
				message = "Average";
				break;

			case 'f':
			case 'F':
				message = "Poor";
				break;

			default:
				message = " : an error occurred";
				break;

		}
		return message;

	}

}


			