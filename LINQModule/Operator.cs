using System;
using System.Linq;
using System.Numerics;


namespace LINQModule
{
	class Operator
	{
		public BigInteger[] FibonacciArray = new BigInteger[200] ;
		public BigInteger[] SquareRoots = new BigInteger[200];
		public Operator()
		{
			FibonacciArray[0] = FibonacciArray[1] = 1;

			for (int i = 2; i < FibonacciArray.Length; i++)
			{
				FibonacciArray[i] = FibonacciArray[i - 1] + FibonacciArray[i - 2];
			}
		}


		public BigInteger SumOfNumber(BigInteger number)
		{
			BigInteger sum = 0;
			while (number > 0)
			{
				sum += number % 10;
				number /= 10;
			}

			return sum;
		}

		public bool DivideByFive()
		{
			var test = FibonacciArray.Any(t => t % 5 == 0);
			return test;
		}

		public int NumberDivideByValues()
		{
			int result = 0;
			result = FibonacciArray.Count(t => t % SumOfNumber(t) == 0 );
			return result;
		}



		public int IsSimple()
		{
			int counter = 0;
			for (int i = 0; i < 200; i++)
			{
				for (int j = 2; j < FibonacciArray[i] / 2; j++)
				{
					if (!(FibonacciArray[i] % j == 0))
					{
						counter++;
						break;
					}
					else break;
				}
			}

			return counter;
		}

		public bool IsContains(BigInteger number, int matcher)
		{
			while (number > 0)
			{
				if (number % 10 == matcher)
				{
					return true;
				}
				number /= 10;
			}

			return false;
		}

		public BigInteger[] SquareRootFinder()
		{
			for (int i = 0; i < FibonacciArray.Length; i++)
			{
				if (IsContains(FibonacciArray[i], 2))
				{
					SquareRoots[i] = (BigInteger) Math.Exp(BigInteger.Log(FibonacciArray[i]) / 2);//get from google
					//Console.WriteLine($"'{i}'" + SquareRoots[i]);
				}
			}
			return SquareRoots;
		}

		//public void SortArrBySecondNumber()
		//{
		//	var orderedNumbers = from i in FibonacciArray
		//		orderby i.IsEven
		//		select i;
		//	foreach (BigInteger i in orderedNumbers)
		//		Console.WriteLine(i);
		//	//BigInteger[] sortedNumbers = FibonacciArray.OrderBy(i => i);
			
		//}

	}
}
