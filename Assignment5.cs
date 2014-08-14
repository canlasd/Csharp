using System;

public class CheckBook
{

  public static void Main()
  {
	double start=0.0, add=0.0, subtract=0.0, end=0.0;

	Console.Out.WriteLine("Input starting balance,");
	getValue(ref start);

	Console.Out.WriteLine("\n Input total deposits,");
	getValue(ref add);

	Console.Out.WriteLine("\n Input total withdrawals,");
	getValue(ref subtract);

	balanceBook(start, add, subtract, ref end);

	Console.Out.WriteLine("The ending balance is $" + end);
  }

  public static void getValue(ref double input)
  {
     String strValue;

     // Get input from the user
     System.Console.Out.Write("Enter a value: ");
     strValue = System.Console.ReadLine();
     input = Convert.ToDouble(strValue);
  }

  public static void balanceBook(double beginning, double deposits, double withdrawals, ref double ending)
  {
     ending = beginning + deposits - withdrawals;
  }

}

