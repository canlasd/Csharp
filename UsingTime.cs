
using System;
 using TimeNamespace;
 
 public class UsingTime
 {
   public static void Main()
   {
       	Time myTime = new Time();
       	Time yourTime = new Time();
       	myTime.SetHour(5);
       	myTime.SetMinute(35);
      	myTime.SetSecond(44);

	myTime.DisplayCivilian();
	myTime.addSecond();
	myTime.DisplayCivilian();
	myTime.DisplayMilitary();
       



   }
 } 
		
			
			