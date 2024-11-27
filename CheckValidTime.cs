using System;

public class CheckValidTime
{
    public CheckValidTime()
    {
    }
    // Exercise3  check valid time  
    public static void timeCheck()
    {
        Console.WriteLine("Next: Keep track of valid time:");
        Console.WriteLine("Please input current time in 24hr format");
        var currentTime = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(currentTime))
        {
            Console.WriteLine("Invalid Time1:");
            return;  // do nothing  basically return what the method retuns which is void.
        }
        // else continue and split  input string into parts 
        var segmentTime = currentTime.Split(':');
        // segnments or parts should not  be more than two , check if user inputs more  ot longer string 
        if (segmentTime.Length != 2)  //   if there are more segments or parts of time scenario not allowed
        {
            Console.WriteLine("Sorry Time format does not exist:");
            return;
        }
        // otherwise break  and convert each segment saved in the array in to integers 
        var hour = int.Parse(segmentTime[0]);   // first  index is  segment for hour 
        var min = int.Parse(segmentTime[1]);   // second  index is segment for minutes

        // find  and check for the  valid time range 
        if ((hour >= 0 && hour <= 23) && (min >= 0 && min <= 59))
        {
            Console.WriteLine("Valid time within full day range");
        }
        else
        {
            Console.WriteLine(" Sorry out of day range: Invalid time4");
        }
    }

}
