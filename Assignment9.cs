using System;
using System.Collections;
 

class Assignment9
{

	public static void Main()
	{
		String strNumber;
		int number=0;
		int total=0;
		int count=0;
		
		int[] array1 = new int[100];
		while (number!= 999 || array1.Length>100)
		{
			Console.Out.WriteLine("Input a number");
			strNumber = Console.ReadLine();
			number = Convert.ToInt32(strNumber);
			total=total+number;
			array1[count]=number;
			count++;
			

		}
		

		if (number==999 || array1.Length>100)

		{
		double result;
		result = (total-999)/(count-1);	
			
			Console.Out.WriteLine("The ave of all numbers is :  " + result);
		}	
		

	}

}


			