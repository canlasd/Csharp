using System;
 
 public class Lesson4
 {
      public static void Main()
      {
            string strFirst, strSecond;
            int first, second, result;
 
            Console.Out.Write("Enter a number: ");
            strFirst = Console.ReadLine();
            first = Convert.ToInt32(strFirst);
 
            Console.Out.Write("Enter a second number: ");
            strSecond = Console.ReadLine();
            second = Convert.ToInt32(strSecond);
 
            result = Sum(first, second);
 
            Console.Out.WriteLine("The sum is: " + result);
      }
 
      public static int Sum(int number1, int number2)
      {
            int answer = number1 + number2;
            return answer;
      }
 }

