namespace TimeNamespace
 {
   using System;
 
   public class Time
   {
       private int hour;
       private int minute;
       private int second;
 
       public void SetHour(int h)
       {
           if(h < 0 || h > 23)
           {
               Console.Out.Write("Invalid hour.");
               Console.Out.WriteLine(" Setting hour to 0.");
               hour = 0;
           }
           else
               hour = h;
       }
       
       public int GetHour()
       {
           return hour;
       }


	public void SetMinute(int m)
       {
           if(m < 0 || m > 60)
           {
               Console.Out.Write("Invalid minute.");
               Console.Out.WriteLine(" Setting minute to 0.");
               minute = 0;
           }
           else
               minute = m;
       }
       
       public int GetMinute()
       {
           return minute;
       }

	public void SetSecond(int s)
       {
           if(s < 0 || s > 60)
           {
               Console.Out.Write("Invalid second.");
               Console.Out.WriteLine(" Setting second to 0.");
               second = 0;
           }
           else
               second = s;
       }
       
       public int GetSecond()
       {
           return second;
       }


	public void addSecond()
	{
	second++;
	if (second==60)
		{
		
		second=0;
		addMinute();
		}
	}

	public void addMinute()
	{
	minute++;
	if (minute==60)
		{
		
		minute=0;
		addHour();
		}
	}


	public void addHour()
	{
	hour++;
	if (hour==24)
		{
		
		hour=0;
		
		}
	}


	public void DisplayCivilian()
	{

		if(hour<=12)
			{
			
			Console.Out.WriteLine(hour + ":" + minute + ":" + second + " AM");
			}

			else
			Console.Out.WriteLine(hour - 12 + ":" + minute + ":" + second + " PM");

	}


	public void DisplayMilitary()
	{

		
		Console.Out.WriteLine(hour + ":"+ minute + ":" + second);
			
	}
 

	public bool Equals(Time t)
	{

	if (t.GetHour()==hour && t.GetMinute()==minute && t.GetSecond() == second)
		return true;
		else
		return false;
	}
























   }
 }