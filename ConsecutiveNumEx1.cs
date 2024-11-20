using System;
using System.Collections.Generic;

public class ConsecutiveNumEx1
{
	public ConsecutiveNumEx1()
	{
	}

    // exercise 1 , separate string of numbers and con
    public static void EnterNumSeparatedCommas()
    {
        string[] elements; // string array that contains all the split string of numbers 

        while (true)  //  i  donnt need a while loop because its basicall one line of string of numbers ( remove the while loop when get time
        {
            Console.WriteLine(" Enter numbers separated with hythen - sign");
            var inPut = Console.ReadLine();
            if (!string.IsNullOrEmpty(inPut))  // check the string 
            {
                elements = inPut.Split('-'); // split the input string,  it can be a comma; can be hythen - etc
                break;
            }
            Console.WriteLine("invalid string");
        }

        foreach (var item in elements)
        {
            Console.WriteLine("Print out the strings:" + item);
        }

        var listofNumbers = new List<int>();   //  created a list  to save all the converted numbers

        foreach (var element in elements)
        {
            listofNumbers.Add(int.Parse(element));
        }

        Console.WriteLine("Check if numbers were separated:");

        foreach (var number in listofNumbers)
        {
            Console.WriteLine("Print separated Numbers:" + number);

        }

        if (listofNumbers.Count < 2)  // making sure that list not less than 2 inorder to make the comparison
        {
            return;   // simple write return with nothing more automatically it will execute and return nothing if numbers less than2 
        }
        for (int i = 0; i < listofNumbers.Count - 1; i++) //  remember to change the comment
                                                          // 
        {
            var difference = listofNumbers[i + 1] - listofNumbers[i]; // finding the difference between two indexes should be always 1
            if (difference != 1)    //  dealing with scenario  if the difference is not equal to 1 , return not
                                    //  consecutive others always conesective nunmber
            {
                Console.WriteLine("Not consecutive ");
                return;
            }
        }

        Console.WriteLine("consecutive"); // its put out the for loop because if u put it inside forloop , this output will be 
                                          // shown on the console window 6 times which is not  nice 

        // just testing the size or number of objects in the list 
        var sizeOfList = listofNumbers.Count;
        Console.WriteLine("Total size list:" + sizeOfList);

    }




}
