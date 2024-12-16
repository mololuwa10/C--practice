using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C__practice.LINQ
{
    public class Where
    {
        // Covers the Where operation with examples and comparisons to traditional filtering.

        // Concept: This filters data based on a condition, only returning items that match.

        // Real-world Example: If you have a list of users and want to find only the ones who are active, you’d use Where to filter for that condition.
        // Problem Solving: Great for narrowing down data before processing it further, so you don’t handle unnecessary information.
        readonly List<int> numbers = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];

        private void WhereOperationTraditional()
        {
            // Traditional filtering
            List<int> evenNumbersTraditional = [];
            foreach (var number in numbers)
            {
                if (number % 2 == 0)
                {
                    evenNumbersTraditional.Add(number);
                }
            }
            Console.WriteLine(
                "Traditional Even Numbers: " + string.Join(", ", evenNumbersTraditional)
            );
        }

        private void WhereOperationLinq()
        {
            // Linq Filtering
            var evenNumbersLINQ = numbers.Where(n => n % 2 == 0);
            Console.WriteLine("LINQ Even Numbers: " + string.Join(", ", evenNumbersLINQ));
        }

        // Where Exercises
        public void FilterPositiveNumbers()
        {
            List<int> numbers = [-5, 2, -3, 8, -1, 10];

            var positiveNumbers = numbers.Where(n => n > 0);
            Console.WriteLine("Positive Numbers: " + string.Join(", ", positiveNumbers));
        }

        public void FilterShortStrings()
        {
            List<string> words = ["apple", "banana", "car", "dog", "elephant", "frog"];

            var shortWords = words.Where(w => w.Length < 4);
            Console.WriteLine("Short Words: " + string.Join(", ", shortWords));
        }

        public void FilterEvenIndexedElements()
        {
            List<int> numbers = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];

            var evenIndexedElements = numbers.Where((n, index) => index % 2 == 0);
            Console.WriteLine("Even Indexed Elements: " + string.Join(", ", evenIndexedElements));
        }

        public static void FilterExpensiveProducts()
        {
            List<Product> products =
            [
                new Product { Name = "Laptop", Price = 1200 },
                new Product { Name = "Phone", Price = 800 },
                new Product { Name = "Tablet", Price = 600 },
                new Product { Name = "Headphones", Price = 150 },
            ];

            var expensiveProducts = products.Where(p => p.Price > 500).Select(p => p.Name);
            Console.WriteLine("Expensive Products: " + string.Join(", ", expensiveProducts));
        }

        class Product
        {
            public string? Name { get; set; }
            public decimal? Price { get; set; }
        }

        public static void FilterPeopleOver18()
        {
            List<Person> people =
            [
                new Person { Name = "Alice", Age = 25 },
                new Person { Name = "Bob", Age = 17 },
                new Person { Name = "Charlie", Age = 30 },
                new Person { Name = "David", Age = 16 },
            ];

            var adultsOver18 = people.Where(p => p.Age > 18).Select(p => p.Name);
            Console.WriteLine("Adults over 18: " + string.Join(", ", adultsOver18));
        }

        class Person
        {
            public string? Name { get; set; }
            public int Age { get; set; }
        }

        public static void FilterPalindromes()
        {
            List<string> words = ["racecar", "hello", "level", "world", "deified"];

            var wordIsPalindrome = words.Where(w => w.SequenceEqual(w.Reverse()));
            Console.WriteLine("Palindromes: " + string.Join(", ", wordIsPalindrome));
        }
    }
}
