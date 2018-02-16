using System.Numerics;
namespace LINQModule
{
	class FibonacciFinder
	{
		public BigInteger[] FindFibonacci()
		{
			BigInteger[] fibonacciArray = new BigInteger[200];
			fibonacciArray[0] = fibonacciArray[1] = 1;

			for (int i = 2; i < fibonacciArray.Length; i++)
			{
				fibonacciArray[i] = fibonacciArray[i - 1] + fibonacciArray[i - 2];
			}

			return fibonacciArray;
		}
	}
}
