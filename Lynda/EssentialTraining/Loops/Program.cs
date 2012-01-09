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

			//Basic while loop
			Console.WriteLine("Basic while() loop:");
			while (myVal < 20)
			{
				Console.WriteLine("myVal is currently {0}", myVal);
				//careful! Always make sure that the loop has some way to exit or you'll end up with an Infinite Loop!
				myVal +=3;
			}
			Console.WriteLine();
			
			Console.ReadLine();
		}
	}
}
