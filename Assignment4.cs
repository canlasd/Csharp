using System;
 
 public class Lesson4
 {
      public static void Main()
      {
            string sideFirst, sideSecond;
            double result, first, second;
 
            Console.Out.Write("Enter a number: ");
            sideFirst = Console.ReadLine();
            first = Convert.ToDouble(sideFirst);
 
            Console.Out.Write("Enter a second number: ");
            sideSecond = Console.ReadLine();
            second = Convert.ToDouble(sideSecond);
 
            result = calcHypotenuse(first, second);
 
            Console.Out.WriteLine("The hypotenuse is: " + result);
      }
 
      public static double calcHypotenuse(double number1, double number2)
      {
            double answer = Math.Sqrt(Math.Pow(number1,2) + Math.Pow(number2,2));
            return answer;
      }
 }

