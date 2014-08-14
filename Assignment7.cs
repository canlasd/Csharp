using System;
 

class Assignment7
{

	public static void Main()
	{
		String year, choice;
		int number, use;

		Console.Out.WriteLine("Enter your Year Number:  ");
		year = Console.ReadLine();
		number = Convert.ToInt32(year);
		if (number<1||number>3)
		Console.Out.WriteLine("Invalid Input  ");
		

		Console.Out.WriteLine("Press I to use if statement or C to use case statement");
		choice = Console.ReadLine();
		use = Convert.ToChar(choice);

		if (use=='I' || use=='i')
		getRankIf(number);
		else
		if (use=='C' || use=='c')
		getRankSwitch(number);
		else
		Console.Out.WriteLine("Invalid Input  ");
				
	}

	public static void getRankSwitch(int number1)

	{
	
		
		switch (number1)

		{

			case 1:
				Console.Out.WriteLine("Class Rank:  Freshman  ");
				break;
			
			case 2:
				Console.Out.WriteLine("Class Rank:  Sophomore  ");
				break;

			case 3:
				Console.Out.WriteLine("Class Rank:  Junior  ");
				break;
			
			default:
				Console.Out.WriteLine("Error Occurred ");
				break;

		}
		

	}


	public static void getRankIf(int number2)

	{
	
		if (number2==1)
		Console.Out.WriteLine("Class Rank:  Freshman  ");
		else if (number2==2)
		Console.Out.WriteLine("Class Rank:  Sophomore  ");
		else if (number2==3)
		Console.Out.WriteLine("Class Rank:  Junior  ");
		else
		Console.Out.WriteLine("Error occurred  ");
		
		
		

	}

}


			