using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace LINQModule
{
	public static class BigIntegerExtended
	{
		private static BigInteger SumOfNumber(this BigInteger number)
		{
			BigInteger sum = 0;
			while (number > 0)
			{
				sum += number % 10;
				number /= 10;
			}

			return sum;
		}

		public static bool DivideBySumOfValues(this BigInteger number)
		{

			return number % SumOfNumber(number) == 0;
		}
	}
}
