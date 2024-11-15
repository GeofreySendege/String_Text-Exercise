using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Text__Exercise
{
	internal class PascalClass
	{
		// Exercise4 
		/*  Input  a few words and summarize in PascalCase  format 
         *  Not yet working 
         *  
        */
		public static void PascalCase()
		{
			Console.WriteLine("Enter few separated words ");
			var inPut = Console.ReadLine();
			if (string.IsNullOrWhiteSpace(inPut))
			{
				Console.WriteLine("Invalid Input:");
				return;
			}
			// otherwise split sentence into segments of words and save each segment at a string in an array 
			// each index will hold a text and later join the segments together
			//  how do i keep track of  the gaps between words 
			// think of  spliting string with indexOf() method check examples 14 in lessons
			/// 
			var index1 = inPut.IndexOf(' ');
			var firstword = inPut.Substring(0, index1);
			var secondword = inPut.Substring(index1 + 1);
			Console.WriteLine("First word: " + firstword);
			Console.WriteLine("Second word: " + secondword);

			///
			var words = inPut.Split(' '); //  split words into segments and save them in an array 

			var outString = "";
			// Figure out how to combine the words without cutting them out 
			foreach (var word in words)
			{
				var upperCaseFirstLetter = word.Substring(0, 1).ToUpper();
				var restOfString = word.Substring(1);
				outString +=  upperCaseFirstLetter + restOfString;
			}

			Console.WriteLine(outString);
			// need to remove the space between Geofrey and Sendege
			// Think alittle bit more how to combine the words without cutting them 

			//for (int i = 0; i < combinedWords.Count - 1; i++)
			//{
			//	var joinedWord = combinedWords[i] + combinedWords[i + 1];
			//	Console.WriteLine("Joined word2:" + joinedWord);
			//}
		}
	}
}
