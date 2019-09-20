using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assgiment1
{
	class Program
	{
		static void Main(string[] args)
		{

			int a = 1, b = 128;
			SelfDividingNumbers(a, b);

			//int n2 = 5;
			//printSeries(n2);

			int n3 = 3;
			printTriangle(n3);

			Console.ReadLine();

		}

		public static void SelfDividingNumbers(int x, int y)
		{
			try
			{
				// extracting all the number between given argument into an array
				int[] allnumbers = new int[Math.Abs(y - x) + 1];

				int temp1 = x;
				for (int j = 0; j < Math.Abs(y - x) + 1; j++)
				{
					allnumbers[j] = temp1;
					temp1++;
				}

				for (int i = 0; i < allnumbers.Length; i++)
				{
					if (checkEachNum(allnumbers[i]))
					{
						Console.WriteLine(allnumbers[i]);
					}
				}

				bool checkEachNum(int num)
				{
					int temp2 = num;

					while (temp2 > 0)
					{
						int digit;
						digit = temp2 % 10;
						if (!chcekDiv(num, digit))
							return false;

						temp2 = temp2 / 10;
					}

					return true;

				}

				bool chcekDiv(int n, int digit)
				{
					return (digit != 0 && n % digit == 0);
				}

			}
			catch
			{
				Console.WriteLine("Exception occured while computing printSelfDividingNumbers()");

			}
			


		}

		//public static void printSeries(int n)
		//{
		//	try
		//	{
		//		for (int i = 1; i <= 5; i++)
		//		{
		//			for(int j = 0; j < i; j++)
		//			{

		//			}
		//		}



		//	}
		//	catch
		//	{
		//		Console.WriteLine("Exception occured while computing printSeries()");
		//	}
		//}


		public static void printTriangle(int n)
		{
			try
			{
				//print 5 lines
				for(int i = n; i > 0; i--)
				{
					for (int space = 0; space < n -i; ++space)
					{
						Console.Write(" ");
					}

					for (int j = 1; j <= i*2 -1; ++j)
					{

						Console.Write("*");
						
					}

					for (int z = 0; z < i - 1; ++z)
						Console.Write("*");

					
					Console.WriteLine();
				}
			}
			catch
			{
				Console.WriteLine("Exception occured while computing printTriangle()");
			}
		}


	}
}
