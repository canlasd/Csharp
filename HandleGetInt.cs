using System;
	
	public class HandleGetInt
	{
		public static void Main()
		{
			String strNum;
			int number;
			Console.Out.Write("enter a whole number:  ");
			strNum = Console.ReadLine();

			try
			{
				number = Convert.ToInt32(strNum);
			}

			catch (Exception e)

			{

				Console.Out.WriteLine("Invalid whole number, 1 is used.");
				number = 1;

			}


			Console.Out.WriteLine("\n\nYour number was" + number);

			}

	}