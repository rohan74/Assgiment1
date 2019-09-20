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
			Console.ReadLine();
			//add
		}

		public static void SelfDividingNumbers(int x, int y)
		{
			int[] allnumbers = new int[Math.Abs(y - x) +1];
			int temp1 = x;
			for (int j = 0; j < Math.Abs(y-x)+1; j++)
			{
				allnumbers[j] = temp1;
				temp1++;
			}

			for(int i = 0; i < allnumbers.Length; i++)
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

	}
}
