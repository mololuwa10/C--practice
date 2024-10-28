using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C__practice.DSA.Day3
{
	public class DSAArrayOperations
	{
		readonly int[] numbers = [140, 24, 33, 42, 55, 67, 72, 81, 9, 10];

		// Traversing the array
		public void TraverseArray()
		{
			// Print out the values from beginning to end regardless of order
			for (int i = 0; i < numbers.Length; i++)
			{
				Console.WriteLine(numbers[i]);
			}
			
			// Print out the values from end to beginning
			for (int i = numbers.Length - 1; i >= 0; i--)
			{
				Console.WriteLine(numbers[i]);
			}
		}

		// Sorting the array
		public void SortArray()
		{
			// C# provides an Array.sort(arr) expression to use to sort an array in ascending order
			Array.Sort(numbers);

			// Print out the sorted array
			Console.WriteLine("Sorted array:");
			for (int i = 0; i < numbers.Length; i++)
			{
				Console.WriteLine(numbers[i]);
			}
		}

		// Inserting in the array
		public void InsertInArray()
		{
			// Since array is fixed, you need to create a new array and increase the length of the array
			int[] newNumbers = new int[numbers.Length + 1];

			// Copy all the elements from the old array to the new array
			for (int i = 0; i < numbers.Length; i++)
			{
				newNumbers[i] = numbers[i];
			}

			// Insert the element at the end of the new array
			newNumbers[numbers.Length] = 100;

			// print the new array
			Console.WriteLine("New Array List: ");
			for (int i = 0; i < newNumbers.Length; i++)
			{
				Console.WriteLine(newNumbers[i]);
			}
		}

		public void DeleteFromArray()
		{
			int elementToDelete = 55; // Element to delete
			
			// New Array with one less element
			int[] newNumbers = new int[numbers.Length - 1];
			
			// Index to keep track of new array
			int index = 0;

			// Copy elements to new array, skipping the one to delete
			foreach (int num in numbers)
			{
				if (num != elementToDelete)
				{
					newNumbers[index] = num;
					index++;
				}
			}

			// Display the new array
			Console.WriteLine("New Array List:");
			foreach (int num in newNumbers)
			{
				Console.WriteLine(num);
			}
		}
	}
}
