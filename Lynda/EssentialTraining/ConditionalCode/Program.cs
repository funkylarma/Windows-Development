using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConditionalCode
{
	class Program
	{
		static void Main(string[] args)
		{
			int theVal = 49;

			if ((theVal == 50) || (theVal == 49))
			{
				Console.WriteLine("theVal is 50 or 49");
			}
			else if (theVal == 51)
			{
				Console.WriteLine("theVal is 51");
			}
			else
			{
				Console.WriteLine("theVal is something else");
			}
			
			Console.ReadLine();
		}
	}
}
