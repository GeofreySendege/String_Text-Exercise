using System;
using System.Collections.Generic;

public class ConsecutiveNumEx1
{
    public ConsecutiveNumEx1()
    {
    }

    /* Exercise1: Program inputs a string of numbers separated by '-' and verifys if numbers are consecutive or not
     * check if input string is not empty, 
     * Get hold of the input String, split it and save all each split part in string array[]
     * using a foreach loop, iterate through the string array , convert each element into integer
     * Create a list  where to save each converted integer
     * since the size of the list of integers is known, use  a for loop by comparing if the numbers are consecutive
     * For a number to be consecutive the difference of  the corresponding index must be 1
     */

    public static void EnterNumSeparatedCommas()
    {
        string[] elements; // string array that contains all the split string of numbers 

        while (true)  //  i  donnt need a while loop because its basicall one line of string of numbers ( remove the while loop when get time
        {
            Console.WriteLine(" Program that checks if numbers are consecutive");
            Console.WriteLine(" Enter numbers seperated with '-'");
            var inPut = Console.ReadLine();
            if (!string.IsNullOrEmpty(inPut))  // check the string 
            {
                elements = inPut.Split('-'); // split the input string,  it can be a comma; can be hythen - etc
                break;
            }
            Console.WriteLine("invalid string");
        }
        var listofNumbers = new List<int>();   //  created a list  to save all the converted numbers

        foreach (var element in elements)
        {
            listofNumbers.Add(int.Parse(element)); // coonvert each string to integers,save numbers to a list
        }

        if (listofNumbers.Count < 2)  // making sure that list not less than 2 inorder to make the comparison
        {
            return;   // simple write return with nothing more automatically it will execute and return nothing if numbers less than2 
        }
        for (int i = 0; i < listofNumbers.Count - 1; i++) //  remember to change the comment
                                                          // 
        {
            var difference = listofNumbers[i + 1] - listofNumbers[i]; // difference between two indexes should be always 1
            if (difference != 1)    //  dealing with scenario  if the difference is not equal to 1 , return not
            {
                Console.WriteLine(" Sorry Not Consecutive Numbers  ");
                return;   // basically return what the method  outputs in this case do nothing
            }
        }

        Console.WriteLine(" Super Consecutive Numbers"); // its put out the for loop because if u put it inside forloop , this output will be 
                                                  // shown on the console window 6 times which is not  nice 

        // just testing the size or number of objects in the list 
        var sizeOfList = listofNumbers.Count;
        Console.WriteLine("Total size list:" + sizeOfList);

    }

    /*
        foreach (var item in elements)
        {
            //Console.WriteLine("Print out the strings:" + item); // skip printing out the string 
        }
        */

    // Console.WriteLine("Check if numbers were separated:"); // skip test line
    /*
     foreach (var number in listofNumbers)
     {
         Console.WriteLine("Print separated Numbers:" + number); // 

     }*/



}
