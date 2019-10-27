using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_Fibonacci
{
	public class FibMatrix
	{
		//My name is Adrian Bulanadi, yes this is my computer
		public static ulong Matrix(ulong n)
		{
			ulong[,] F = new ulong[,] { { 1, 1 }, { 1, 0 } };
			//if n == 0, fib value is 0, so return as such
			if(n == 0)
			{
				return 0;
			}
			//helper function to calculate powers of the matrix
			Power(F, n - 1);

			return F[0, 0];
		}

		static void Multiply(ulong[,] F, ulong[,] M)
		{
			ulong x = F[0, 0] * M[0, 0] + F[0, 1] * M[1, 0];
			ulong y = F[0, 0] * M[0, 1] + F[0, 1] * M[1, 1];
			ulong z = F[1, 0] * M[0, 0] + F[1, 1] * M[1, 0];
			ulong w = F[1, 0] * M[0, 1] + F[1, 1] * M[1, 1];

			F[0, 0] = x;
			F[0, 1] = y;
			F[1, 0] = z;
			F[1, 1] = w;
		}

		static void Power(ulong[,] F, ulong n)
		{
			if (n == 0 || n == 1)
			{
				return;
			}

			ulong[,] M = new ulong[,]{{1, 1}, {1, 0}};

			Power(F, n / 2);
			//helper function to multiply the matrices
			Multiply(F, F);

			if (n % 2 != 0)
			{
				Multiply(F, M);
			}
		}
	}
}
