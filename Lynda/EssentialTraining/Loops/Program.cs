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
			int myVal = 15;

			//The do-while loop
			Console.WriteLine("The do-while() loop:");
			do
			{
				Console.WriteLine("myVal is currently {0}", myVal);
				myVal += 3;
			} while (myVal < 20);
			Console.WriteLine();
			
			Console.ReadLine();
		}
	}
}
