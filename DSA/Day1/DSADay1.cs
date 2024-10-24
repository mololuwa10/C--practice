using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C__practice.DSA.Day1
{
	public class DSADay1
	{
		public void FibonacciMethod() 
		{
			int firstNumber = 0;
			int secondNumber = 1;
			
			for (int i = 0; i < 18; i++) 
			{
				int newFibonacciNumber = firstNumber + secondNumber;
				Console.WriteLine(newFibonacciNumber);
				secondNumber = firstNumber;
				firstNumber = newFibonacciNumber;
			}
		}
	}
}