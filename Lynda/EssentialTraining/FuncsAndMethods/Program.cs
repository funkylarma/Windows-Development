using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FuncsAndMethods
{
	class Program
	{
		static void Main(string[] args)
		{
			int result1;
			int arg1 = 25;

			result1 = formula(arg1);
			Console.WriteLine("The result is: {0}", result1);
			
			Console.ReadLine();
		}

		static int formula(int theVal)
		{
			return (theVal * 2) / 3 + 15;
		}

	}
}
