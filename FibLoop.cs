using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_Fibonacci
{
	class FibLoop
	{
		//My name is Adrian Bulanadi, yes this is my computer
		public static ulong FibLooping(ulong x)
		{
			ulong[] fibStorage = new ulong[x + 2];
			fibStorage[0] = 0;
			fibStorage[1] = 1;

			for (ulong i = 2; i <= x; i++)
			{
				fibStorage[i] = fibStorage[i - 1] + fibStorage[i - 2];
			}
			return fibStorage[x];
		}
	}
}
