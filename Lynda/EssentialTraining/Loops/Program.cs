using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Loops
{
	class Program
	{
		static void Main(string[] args)
		{
			int myVal = 20;

			//The for loop
			Console.WriteLine("The for() loop:");
			for (int i = 0; i < myVal; i += 5)
			{
				Console.WriteLine("i is currently {0}", i);
			}
			Console.WriteLine();
			
			Console.ReadLine();
		}
	}
}
