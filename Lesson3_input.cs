// Lesson3
// Use of ReadLine to read user input and convert the user input
// for mathematical operations

public class Favorites
{
	// the program begins inside Main
	public static void Main()
	{	
		//get input from user
		System.Console.Out.Write("Enter the first number:  ");
		string num1String = System.Console.ReadLine();
		double num1= System.Convert.ToDouble(num1String);

		System.Console.Out.Write("Enter the second number:  ");
		string num2String = System.Console.ReadLine();
		double num2 = System.Convert.ToDouble(num2String);

		// calculate the sum
		double sum = num1 + num2;

		// display the result
		System.Console.Out.WriteLine (" The sum is  " + sum);

	} 
} 


