using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C__practice.ArrayMethods
{
	public class ArrayLearning
	{
        readonly int[] numbers = [10, 20, 30, 40, 50];
		
		public void ArrayBasic() 
		{
			// Display the content of the array
			// for (int i = 0; i < numbers.Length; i++)
			// {
			// 	Console.WriteLine(numbers[i]);		
			// }
			foreach(var item in numbers)
			{
				Console.WriteLine(item.ToString());
			}
		}
	}
}