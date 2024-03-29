﻿using System;
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

			int a = 1, b = 22;
			SelfDividingNumbers(a, b);

			int n2 = 5;
			printSeries(n2);

			int n3 = 3;
			printTriangle(n3);

			int[] J = new int[] { 1, 3 };
			int[] S = new int[] { 1, 3, 3, 2, 2, 2, 2, 2 };
			int r4 = numJewelsInStones(J, S);
			Console.WriteLine(r4);

			//int[] arr1 = new int[] { 1, 2, 5, 6, 7, 8, 9 };
			//int[] arr2 = new int[] { 1, 2, 3, 4, 5 };
			//int[] r5 = getLargestCommonSubArray(arr1, arr2);
			//Console.WriteLine(r5);


			Console.ReadLine();

		}

		public static void SelfDividingNumbers(int x, int y)
		{
			try
			{
				//extracting all the number between given argument into an array
				int[] allnumbers = new int[Math.Abs(y - x) + 1];

				// temp1 is used to assign value to allnumbers array
				int temp1 = x;
				for (int j = 0; j < Math.Abs(y - x) + 1; j++)
				{
					allnumbers[j] = temp1;
					temp1++;
				}

				// check if values of allnumbers array are selfdivisible
				for (int i = 0; i < allnumbers.Length; i++)
				{
					//if selfdivisible print on console
					if (checkEachNum(allnumbers[i]))
					{
						Console.WriteLine(allnumbers[i]);
					}
				}

				bool checkEachNum(int num)
				{
					int temp2 = num;

					//grab digit of each number
					while (temp2 > 0)
					{
						int digit;
						digit = temp2 % 10;
						// check if the digit is didvisble by the number or retuen false
						if (!chcekDiv(num, digit))
							return false;

						temp2 = temp2 / 10;
					}

					return true;

				}

				// return true if the digit is divisble by number
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

		public static void printSeries(int n)
		{
			try
			{
				//initialize num to 1
				int num = 1;
				//first loop check to print number of element to print
				for (int i = 1; i <= n;)
				{
					//second loop check number of times num variable and print num to be printed
					for (int j = 0; j < num; j++)
					{
						Console.WriteLine(num);
					}
					i = i + num;
					num++;

				}
			}
			catch
			{
				Console.WriteLine("Exception occured while computing printSeries()");
			}
		}


		public static void printTriangle(int n)
		{
			try
			{
				//print n lines
				for (int i = n; i > 0; i--)
				{
					// print spaces to form the triange
					for (int space = 0; space < n - i; ++space)
					{
						Console.Write(" ");
					}

					for (int j = 1; j <= i * 2 - 1; ++j)
					{

						Console.Write("*");

					}

					Console.WriteLine();
				}
			}
			catch
			{
				Console.WriteLine("Exception occured while computing printTriangle()");
			}
		}

		public static int numJewelsInStones(int[] J, int[] S)
		{
			try
			{
				// intialize count to count the numbers of the jewels 
				int count = 0;
				//checking jewel and stone array
				foreach (int jewel in J)
				{
					foreach (int stone in S)
					{
						//when jewel and stone are equal increment count
						if (jewel == stone)
							count++;
					}
				}
				return count;
			}
			catch
			{
				Console.WriteLine("Exception occured while computing numJewelsInStones()");
			}

			return 0;
		}

		//public static int[] getLargestCommonSubArray(int[] a, int[] b)
		//{
		//	try
		//	{
		//		int[,] cache = new int[a.Length + 1, b.Length + 1];

		//		int max = 0;

		//		for (int i = 0; i <= a.Length; i++)
		//		{
		//			for (int j = 0; j <= b.Length; j++)
		//			{
		//				if (a[i] == b[j])
		//				{
		//					if ( i == 0 || j == 0)
		//					{
		//						cache[i,j] = 1;
		//					}
		//					else
		//					{
		//						cache[i,j] = cache[i - 1,j - 1] + 1;
		//					}
		//					if (cache[i, j] > max)
		//						max = cache[i, j];

		//				}
		//			}
		//		}
		//		Console.WriteLine(max);
		//		return cache;
		//	}
		//	catch
		//	{
		//		Console.WriteLine("Exception occured while computing getLargestCommonSubArray()");
		//	}

		//	return null; // return the actual array
		//}

	}
}
