using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Conversion
{
	class Program
	{
		static void Main(string[] args)
		{
			int i = 800000;
			short x = 5;
			float f = 20.0f;

			//i = x;

			x = (short)i;
			Console.WriteLine("The value of x is {0}", x);

			f = i;

			i = (int)f;

			Console.ReadLine();
		}
	}
}
