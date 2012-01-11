using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UsingExceptions
{
	class Program
	{
		static void Main(string[] args)
		{
			int x = 10;
			int y = 0;
			int result;

			try
			{
				result = x / y;
				Console.WriteLine("The result is: {0}", result);
			}

			catch
			{
				Console.WriteLine("An error occured! Better check the code!");
			}

			finally
			{
				Console.WriteLine("Just procing that this code always runs.");
			}

			Console.ReadLine();
		}
	}
}
