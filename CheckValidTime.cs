using System;

public class CheckValidTime
{
	public CheckValidTime()
	{
	}

    // Exercise3  check valid time  
    // trouble shoot why  iam only getting invalid time.( try to use  the debug mode ) 

    public static void timeCheck()
    {

        Console.WriteLine("Please input current time in 24hr format");

        var currentTime = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(currentTime))
        {
            Console.WriteLine("Invalid Time1:");
            return;  // do nothing 
        }
        // else continue and split  input string into parts 
        var segmentTime = currentTime.Split(':');

        // segnments or parts should not  be more than two , check if user inputs more  ot longer string 
        if (segmentTime.Length != 2)  //   if there are more segments or parts of time scenario not allowed
        {
            Console.WriteLine("Invalid Time2:");
            return;
        }

        // otherwise break  and convert each segment saved in the array in to integers 

        var hour = int.Parse(segmentTime[0]);   // first  index is  segment for hour 
        var min = int.Parse(segmentTime[1]);   // second  index is segment for minutes

        // find  and check for the  valid time range 
        if ((hour >= 0 && hour <= 23) && (min >= 0 && min <= 59))
        {
            Console.WriteLine("Valid time3");
        }
        else
        {
            Console.WriteLine("Invalid time4");
        }

    }




}
