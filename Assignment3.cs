// Assignment3
// Ask user to input length and width of room (in feet).
// Ask user to input the cosst of carpet per square foot (in dollars and cents)


public class CarpetCost
{
	// the program begins inside Main
	public static void Main()
	{	
		//get input from user
		System.Console.Out.Write("Enter the width of the room in feet:  ");
		string num1String = System.Console.ReadLine();
		double num1= System.Convert.ToDouble(num1String);

		System.Console.Out.Write("Enter the length of the room in feet:  ");
		string num2String = System.Console.ReadLine();
		double num2 = System.Convert.ToDouble(num2String);

		System.Console.Out.Write("Enter the cost of carpet / sq ft:  ");
		string num3String = System.Console.ReadLine();
		double num3 = System.Convert.ToDouble(num3String);





		// calculate the area
		double area = num1*num2;

		// calculate the cost per square feet
		double cost = area*num3;

		// display the result
		System.Console.Out.WriteLine (" The total floor area is  " + area + " square feet");
		System.Console.Out.WriteLine (" The total cost of carpeting is  " + "$"+ area );

	} 
} 


