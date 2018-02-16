using System;
using System.Numerics;

namespace LINQModule
{
	public class Program
	{
		static void Main(string[] args)
		{
			//FibonacciFinder ff = new FibonacciFinder();
			//ff.FindFibonacci();
			Program pr = new Program();

			Operator op = new Operator();
			//pr.ArrayPrinter(op.FibonacciArray);

			Console.WriteLine("Is any number divide by 5: " + op.DivideByFive());
			Console.WriteLine("Numbers who divide by sum of values: " + op.NumberDivideByValues());
			Console.WriteLine($"There is {op.IsSimple()} simple numbers");
			Console.WriteLine("Quarter roots:");
			//foreach (var VARIABLE in op.SortArrBySecondNumber())
			//{
			//	Console.WriteLine(VARIABLE);
			//}
			op.SortArrBySecondNumber();


			Console.ReadLine();
		}

		public void ArrayPrinter(BigInteger[] array)
		{
			foreach (var item in array)
			{
				Console.WriteLine(item);
			}
		}
	}
}
