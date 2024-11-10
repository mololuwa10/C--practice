using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C__practice.LINQ
{
	public class Select
	{
		// Focuses on Select and how it simplifies projections.
		
		// Concept: This projects each element into a new form or structure.
		
		// Real-world Example: If you have a list of products and want only their names (not all properties), use Select.

		// Problem Solving: Helps create simpler views of complex objects or retrieve only specific data from a collection.
		private readonly List<int> numbers = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
		private List<int> squares = [];
		
		private void SelectOperationTraditional() 
		{
			foreach(var number in numbers) 
			{
				squares.Add(number * number);
			}
		}
		
		private void SelectOperationLinq() 
		{
			squares = numbers.Select(n => n * n).ToList();
		}
		
		// Select Exercises
		public void SelectSquares() 
		{
			List<int> numbers = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
			List<int> numberSquares = numbers.Select(n => n * n).ToList();
			
			Console.WriteLine("Squares: " + string.Join(", ", numberSquares));
		}
	}
}