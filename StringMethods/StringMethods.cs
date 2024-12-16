using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace C__practice.StringMethods
{
    public class StringMethods
    {
        string name = "Mololuwa";

        // Getting the length of the string
        public void GetLength()
        {
            int lengthOfString = name.Length;
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

        public void SplitStrings()
        {
            string phrase = "The quick brown fox jumps over the lazy dog";

            string[] splittedPhrase = phrase.Split(" "); // Split the string

            Console.WriteLine(splittedPhrase[0]); // Print the first word
            for (int i = 0; i < splittedPhrase.Length; i++)
            {
                Console.WriteLine(splittedPhrase[i]); // Print the rest of the words
            }
            // Console.WriteLine(splittedPhrase);
        }

        public void EmptyOrNullCheck()
        {
            string name = "Mololuwa";
            Console.WriteLine(name == null);
            Console.WriteLine(name == "");
            Console.WriteLine(string.IsNullOrEmpty(name));
            Console.WriteLine(string.IsNullOrWhiteSpace(name));
        }
    }

    public static class StringExtensions
    {
        public static bool IsUpperCase(this string text)
        {
            return text == text.ToUpper();
        }
    }
}
