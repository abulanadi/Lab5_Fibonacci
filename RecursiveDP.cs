using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_Fibonacci
{
	public class RecursiveDP
	{
		//My name is Adrian Bulanadi, yes this is my computer
		public static ulong FibRecurDP(ulong x)
		{
			ulong[] fibResultsCache = new ulong[x+2];
			ulong[] fibResultsAvailable = new ulong[x+2];
			for(int i = 2; i < fibResultsAvailable.Length; i++)
			{
				fibResultsAvailable[i] = 0;
			}
			fibResultsCache[0] = 1;
			fibResultsCache[1] = 1;

			ulong result = FibRecursiveWithCache(x);
			return result;

			ulong FibRecursiveWithCache(ulong y)
			{
				if (y <= 1)
				{
					return y;
				}
				else if(fibResultsAvailable[y] == 1)
				{
					return fibResultsCache[y];
				}
				else
				{
					ulong result2 = FibRecursiveWithCache(y - 1) + FibRecursiveWithCache(y - 2);
					fibResultsCache[y] = result2;
					fibResultsAvailable[y] = 1;
					return result2;
				}



			}
		}
	}
}
