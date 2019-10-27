using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_Fibonacci
{
	class FibRecur
	{
		//My name is Adrian Bulanadi, yes this is my computer
		public static ulong FibRecursion(ulong x)
		{
			ulong fibNum = 0;
			if (x <= 1)
			{
				return x;
			}
			else
			{
				fibNum = FibRecursion(x - 1) + FibRecursion(x - 2);
			}
			return fibNum;
		}
	}
}
