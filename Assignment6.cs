using System;
 
 class SelectionExample
 {
      public static void Main( )
      {
            string grade;
            double score;
            
 
            Console.Out.Write("Input Your Grade  :  ");
            grade = Console.ReadLine();
            score = Convert.ToDouble(grade);
 
            
            if (score >= 90 && score<=100)
		
                  Console.Out.Write("You received an A");
		
            else if (score >= 80 && score<=89)
		
		Console.Out.Write("You received an B");
		
	    else if (score >= 70 && score<=79)
		
		Console.Out.Write("You received an C");
		
	    else if (score >= 60 && score<=69)
		
		Console.Out.Write("You received an D");
		
	    else if (score < 60)
		
		Console.Out.Write("You received an F");
		
						
            
      }
 } 