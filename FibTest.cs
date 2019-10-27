using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;

namespace Lab5_Fibonacci
{
	class FibTest
	{
		//My name is Adrian Bulanadi, yes this is my computer
		string resultsFolderPath = "C:\\Users\\Adria\\School Stuff\\CSC482\\Lab5";
		static double numberOfTrials = 10;
		Stopwatch stopwatch = new Stopwatch();
		double nanoSecs = 0;
		public void TestRecursive(string resultFile, ulong inputValue)
		{
			Console.WriteLine("Input X\t\tAvg Time (ns)\t\tN (bits)\t\tFib(x)");

			for (ulong i = 0; i <= inputValue; i++)
			{
				for (int trial = 0; trial <= numberOfTrials; trial++)
				{
					stopwatch.Restart();
					FibRecur.FibRecursion(i);
					stopwatch.Stop();
					nanoSecs += stopwatch.Elapsed.TotalMilliseconds * 1000000;
				}
				double averageTrialTime = nanoSecs / numberOfTrials;
				double bitSize = Math.Floor(Math.Log(i, 2)) + 1;
				ulong fibResult = FibRecur.FibRecursion(i);

				Console.WriteLine("{0,-5}\t{1,16}\t\t{2,5}\t\t{3,10}", i, averageTrialTime, bitSize, fibResult);

				using (StreamWriter outputFile = new StreamWriter(Path.Combine(resultsFolderPath, resultFile), true))
				{
					outputFile.WriteLine("{0,-5} {1,16} {2,5} {3,10}", i, averageTrialTime, bitSize, fibResult);
				}
			}
			

		}

		public void TestRecursiveDP(string resultFile, ulong inputValue)
		{
			Console.WriteLine("Input X\t\tAvg Time (ns)\t\tN (bits)\t\tFib(x)");

			for (ulong i = 0; i <= inputValue; i++)
			{
				for (int trial = 0; trial <= numberOfTrials; trial++)
				{
					stopwatch.Restart();
					RecursiveDP.FibRecurDP(i);
					stopwatch.Stop();
					nanoSecs += stopwatch.Elapsed.TotalMilliseconds * 1000000;
				}
				double averageTrialTime = nanoSecs / numberOfTrials;
				double bitSize = Math.Floor(Math.Log(i, 2)) + 1;
				ulong fibResult = RecursiveDP.FibRecurDP(i);

				Console.WriteLine("{0,-5}\t{1,16}\t\t{2,5}\t\t{3,10}", i, averageTrialTime, bitSize, fibResult);

				using (StreamWriter outputFile = new StreamWriter(Path.Combine(resultsFolderPath, resultFile), true))
				{
					outputFile.WriteLine("{0,-5} {1,16} {2,5} {3,10}", i, averageTrialTime, bitSize, fibResult);
				}
			}
		}

		public void TestLoop(string resultFile, ulong inputValue)
		{
			Console.WriteLine("Input X\t\tAvg Time (ns)\t\tN (bits)\t\tFib(x)");

			for (ulong i = 0; i <= inputValue; i++)
			{
				for (int trial = 0; trial <= numberOfTrials; trial++)
				{
					stopwatch.Restart();
					FibLoop.FibLooping(i);
					stopwatch.Stop();
					nanoSecs += stopwatch.Elapsed.TotalMilliseconds * 1000000;
				}
				double averageTrialTime = nanoSecs / numberOfTrials;
				double bitSize = Math.Floor(Math.Log(i, 2)) + 1;
				ulong fibResult = FibLoop.FibLooping(i);

				Console.WriteLine("{0,-5}\t{1,16}\t\t{2,5}\t\t{3,10}", i, averageTrialTime, bitSize, fibResult);

				using (StreamWriter outputFile = new StreamWriter(Path.Combine(resultsFolderPath, resultFile), true))
				{
					outputFile.WriteLine("{0,-5} {1,16} {2,5} {3,10}", i, averageTrialTime, bitSize, fibResult);
				}
			}
		}
		
		public void TestMatrix(string resultFile, ulong inputValue)
		{
			Console.WriteLine("Input X\t\tAvg Time (ns)\t\tN (bits)\t\tFib(x)");

			for (ulong i = 0; i <= inputValue; i++)
			{
				for (int trial = 0; trial <= numberOfTrials; trial++)
				{
					stopwatch.Restart();
					FibMatrix.Matrix(i);
					stopwatch.Stop();
					nanoSecs += stopwatch.Elapsed.TotalMilliseconds * 1000000;
				}
				double averageTrialTime = nanoSecs / numberOfTrials;
				double bitSize = Math.Floor(Math.Log(i, 2)) + 1;
				ulong fibResult = FibMatrix.Matrix(i);

				Console.WriteLine("{0,-5}\t{1,16}\t\t{2,5}\t\t{3,10}", i, averageTrialTime, bitSize, fibResult);

				using (StreamWriter outputFile = new StreamWriter(Path.Combine(resultsFolderPath, resultFile), true))
				{
					outputFile.WriteLine("{0,-5} {1,16} {2,5} {3,10}", i, averageTrialTime, bitSize, fibResult);
				}
			}
		}

	}
}
