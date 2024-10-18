using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace C__practice.StringMethods
{
	public class StringMethods
	{
		String name = "Mololuwa";
		// Getting the length of the string
		public void GetLength() 
		{
			// Console.WriteLine(name.Length);
		}
		
		public void GetToUpperAndLower() 
		{
			// Console.WriteLine(name.ToUpper());
			// Console.WriteLine(name.ToLower());
		}
		
		public void TrimMethods() 
		{
			String name = "   Mololuwa   ";
			// Trim 
			Console.WriteLine(name);
			Console.WriteLine(name.Trim());
			
			// TrimStart
			Console.WriteLine(name.TrimStart());
			
			// TrimEnd
			Console.WriteLine(name.TrimEnd());
		}
		
		public void SearchingMethods() 
		{
			String sentence = "Learning C# is fun!";
			// Contains
			Console.WriteLine(sentence.Contains("C#"));
			
			// StartsWith
			Console.WriteLine(sentence.StartsWith("Learning"));
			
			// EndsWith
			Console.WriteLine(sentence.EndsWith("fun!"));
			
			// IndexOf
			Console.WriteLine(sentence.IndexOf("Learning"));
			
			// LastIndexOf
			Console.WriteLine(sentence.LastIndexOf("C#"));
			
			// Replace
			Console.WriteLine(sentence.Replace("C#", "Java"));
			
			// Split
			// Console.WriteLine(sentence.Split(" "));
			
			// Substring
			Console.WriteLine(sentence.Substring(8, 3));
		}
		
		public void ManipulationMethods() 
		{
			String firstname = "Mololuwa";
			String lastname = "Segilola";
			// Concat
			Console.WriteLine($"{firstname} {lastname}");
			Console.WriteLine(firstname + " " + lastname);
			// Console.WriteLine(firstname.Concat(lastname));

			// Replace
			Console.WriteLine(firstname.Replace("Mololuwa", "Michael"));

			// Insert
			Console.WriteLine(firstname.Insert(0, "Mr. "));
			
			// Remove
			Console.WriteLine(firstname.Remove(0, 2));
		}
		
		public void FormatMethods() 
		{
			String name = "Mololuwa";
			Console.WriteLine(name.PadLeft(5));
			
			Console.WriteLine(name.PadRight(5));
			
			String template = "Hello, {0}! You have {1} new {2}.";
			String result = string.Format(template, name, 4, "games");
			Console.WriteLine(result);
		}
	}
}