using System;
 

class Assignment8
{

	public static void Main()
	{
		String strNumber;
		double number, total;

		number=0;
		total=0;
		while (number!= 999)
		{
			Console.Out.WriteLine("Input a number");
			strNumber = Console.ReadLine();
			number = Convert.ToDouble(strNumber);
			total = total + number;

		}
		

		if (number==999)

		{
		double result;
		result = total-999;	
			
			Console.Out.WriteLine("The sum of all numbers is :  " + result);
		}	
		

	}

}


			