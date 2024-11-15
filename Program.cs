using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace String_Text__Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // EnterNumSeparatedCommas(); // Exercise 1
            checkForDuplicateNumber(); //Exercise 2
            // timeCheck();  // Exercise3 
            //PascalCase(); // Exercise 4
            //PascalClass.PascalCase();
        }

        // Exercise3  check valid time  
        // trouble shoot why  iam only getting invalid time.( try to use  the debug mode ) 

        public static void timeCheck()
        {

            Console.WriteLine("Please input current time in 24hr format");

            var currentTime = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(currentTime))
            {
                Console.WriteLine("Invalid Time:");
                return;  // do nothing 
            }
            // else continue and split  input string into parts 
            var segmentTime = currentTime.Split(':');

            // segnments or parts should not  be more than two , check if user inputs more  ot longer string 
            if (segmentTime.Length != 2)  //   if there are more segments or parts of time scenario not allowed
            {
                Console.WriteLine("Invalid Time:");
                return;
            }

            // otherwise break  and convert each segment saved in the array in to integers 

            var hour = int.Parse(segmentTime[0]);   // first  index is  segment for hour 
            var min = int.Parse(segmentTime[1]);   // second  index is segment for minutes

            // find  and check for the  valid time range 
            if ((hour >= 0 && hour <= 23) && (min >= 0 && min >= 59))
            {
                Console.WriteLine("Valid time");
            }
            else
            {
                Console.WriteLine("Invalid time");
            }

        }

        // Exercise 2: programe that prompts a user enter a few numbers , checks if any duplicate number , if yes output the duplicate

        public static void checkForDuplicateNumber()
        {
            string[] elements;
            var list = new List<int>();

            Console.WriteLine("Please enter a few numbers separated by '-' sign:");
            var inputStr = Console.ReadLine();
            if ((!string.IsNullOrEmpty(inputStr)))
            {
                elements = inputStr.Split('-'); // split the string and save it to an array of strings
                foreach (string element in elements)   // iterate through array and convert each element to integers and save it in a list
                {

                    list.Add(int.Parse(element)); // add  each converted  number to list of numbers 
                }
                // compare the numbers in the list and check if there is any duplicate
                //  compare the  consective numbers if they are equal display duplicate

                var listOfUniqueNumbers = new List<int>();
                if (list.Count <1)
                {
                    return;
                }
                for (int i = 0; i < list.Count - 1; i++)
                {
                    var number = list[i];
                    if (listOfUniqueNumbers.Contains(number))
                    {
                        Console.WriteLine("Duplicate number");
                        return;
                    }
                    //else
                    //{
					//	listOfUniqueNumbers.Add(number);
					//}
					// is equivalent to
					listOfUniqueNumbers.Add(number);

				}

			}

            Console.WriteLine("Non duplicate");

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
            for (int i = 1; i < listofNumbers.Count; i++) //  making sure that total number of objects or size of list´does not exceed
                                                              //  total number of indexes since always index start at 0  list[0]
            {
                var difference = listofNumbers[i] - listofNumbers[i - 1]; // finding the difference between two indexes should be always 1
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



}
