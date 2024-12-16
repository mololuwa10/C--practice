using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace C__practice.StringMethods
{
	public class StringExercises
	{
		public String SentenceReverse(String sentence)
		{
			// String sentence = "The quick brown fox jumps over the lazy dog";
			// String[] words = sentence.Split(" ");
			// Console.WriteLine(string.Join(" ", sentence.Split(" ").Reverse()));

			String reversedSentence = string.Join(" ", sentence.Split(" ").Reverse());
			Console.WriteLine(reversedSentence);
			return reversedSentence;
		}

		public String RemoveDuplicates(String words)
		{
			String removedDuplicates = new string(words.ToCharArray().Distinct().ToArray());
			Console.WriteLine(removedDuplicates);
			return removedDuplicates;
		}

		public String TitleCaseConverter(String sentence)
		{
			// String sentence = "The quick brown fox jumps over the lazy dog";
			// string[] words = sentence.Split(" ");
			// for (int i = 0; i < words.Length; i++)
			// {
			// 	words[i] = char.ToUpper(words[i][0]) + words[i][1..];
			// }
			// String convertedString = string.Join(" ", words);
			// Console.WriteLine(convertedString);
			// return convertedString;

			// Easier approach
			String convertedString = string.Join(
				" ",
				sentence
					.Split(" ")
					.Select(word => char.ToUpper(word[0]) + word.Substring(1).ToLower())
			);
			Console.WriteLine(convertedString);
			return convertedString;
		}

		public String HighsAndLows(String numbers)
		{
			// lONG WAY
			// Get the highest and lowest number in a string of numbers
			// String [] numberArray = numbers.Split(" ");
			// int highest = int.Parse(numberArray[0]);
			// int lowest = int.Parse(numberArray[0]);

			// for (int i = 0; i < numberArray.Length; i++) {
			// 	if (int.Parse(numberArray[i]) > highest) {
			// 		highest = int.Parse(numberArray[i]);
			// 	}
			// 	if (int.Parse(numberArray[i]) < lowest) {
			// 		lowest = int.Parse(numberArray[i]);
			// 	}
			// }
			// Console.WriteLine($"The highest number is {highest} and the lowest number is {lowest}");

			var numbersList = numbers.Split(" ").Select(int.Parse);
			Console.WriteLine(numbersList.Max() + " " + numbersList.Min());
			return numbersList.Max() + " " + numbersList.Min();
		}

		public Double DistanceBetweenPoints(Point a, Point b)
		{
			return Math.Sqrt(Math.Pow(b.X - a.X, 2) + Math.Pow(b.Y - a.Y, 2));
		}

		public class Point
		{
			public double X { get; set; }
			public double Y { get; set; }
		}

		public static long RowSumOddNumbers(long n)
		{
			return n * n * n;
		}

		public static String AreYouPlayingBanjo(string name)
		{
			// name.Contains(".")
			return name.ToLower().StartsWith("r")
				? name + " plays banjo"
				: name + " does not play banjo";
		}

		public static string ReverseString()
		{
			string str = "Hello";
			char[] sArray = str.ToCharArray();
			Array.Reverse(sArray);
			return new string(sArray);
		}

		public List<List<string>> GroupAnagrams(string[] strs)
		{
			var res = new Dictionary<string, List<string>>();
			foreach (string word in strs)
			{
				char[] sArray = word.ToCharArray();
				Array.Sort(sArray);
				string sortedString = new(sArray);
				if (!res.ContainsKey(sortedString))
				{
					res[sortedString] = new List<string>();
				}
				res[sortedString].Add(word);
			}

			return [.. res.Values];
		}

		public int RemoveDuplicates(int[] nums)
		{
			if (nums.Length == 0)
			{
				return 0;
			}
			Array.Sort(nums);
			
			

			return 0;
		}

		public static string BreakCamelCase(string str)
		{
			return string.Join(" ", str.Select(c => char.IsUpper(c) ? " " + c : c.ToString()));
		}

		public string[] Solution(string str)
		{
			// Complete the solution so that it splits the string into pairs of two characters.
			// If the string contains an odd number of characters
			// then it should replace the missing second character of the final pair with an underscore ('_').
			// var conventionalSplit = str.Split(" ");

			// var splittedString = str.Select((x, i) => i % 2 == 0 ? str.Substring(i, 2) : "_").ToArray();
			// if (str.Length % 2 == 0)
			// {
			// 	return splittedString;
			// }
			var result = str.Split([' '], 2);
			return [];
		}
	}
}
