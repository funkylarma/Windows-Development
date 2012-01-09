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
			//int myVal = 20;

			//Using the continue and break keywords
			Console.WriteLine("Using break and continue");
			for (int i = 0; i < 10; i++)
			{
				if (i == 5)
				{
					continue; //skip the rest of the loop
				}

				if (i == 9)
				{
					break;
				}

				Console.WriteLine("i is currently {0}", i);
			}
			
			Console.ReadLine();
		}
	}
}