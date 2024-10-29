using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace C__practice.DSA.Day3
{
	public class ArrayExercises
	{
		public int [] TwoSum(int[] nums, int target) 
		{
			for (int i = 0; i < nums.Length; i++)
			{
				for (int j = i + 1; j < nums.Length; j++)
				{
					if (nums[i] + nums[j] == target)
					{
						return [i, j];
					}
				}
			}
			return [];
		}
		
		public bool IsAnagram(string s, string t) {
			// check if the length is not equal, return false
			if(s.Length != t.Length) 
			{
				return false;
			}
			
			// convert the string to char array
			char[] sArray = s.ToLower().ToCharArray();
			char[] tArray = t.ToLower().ToCharArray();
			
			// sort the char array
			Array.Sort(sArray);
			Array.Sort(tArray);
			
			// compare the char array
			return sArray.SequenceEqual(tArray);
		}
		
		// Valid palindrome
		public bool IsPalindromeUsingConventionalMethod(string s)
		{
			// remove all non-alphanumeric characters
			Regex rgx = new Regex("[^a-zA-Z0-9]");
			
			// convert the string to lowercase
			var lowercaseString = s.ToLower();
			
			// remove all non-alphanumeric characters
			lowercaseString = rgx.Replace(lowercaseString, "");
			
			// check if the string is a palindrome
			int left = 0;
			int right = lowercaseString.Length - 1;
			
			while (left < right) 
			{
				if (lowercaseString[left] != lowercaseString[right]) 
				{
					return false;
				}
				left++;
				right--;
			}

			return true;
		}
		
		public bool IsPalindromeUsingLinq(string s) 
		{
			var lowercaseString = Regex.Replace(s.ToLower(), "[^a-zA-Z0-9]", "");

			return lowercaseString.SequenceEqual(lowercaseString.Reverse());
		}
	}
}