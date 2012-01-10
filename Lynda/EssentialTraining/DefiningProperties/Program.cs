using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefiningProperties
{
	class Program
	{
		static void Main(string[] args)
		{
			//Create some new Wine objects
			Wine w1 = new Wine(2003, "Chateau Ste. Michelle Merlot", "Seven Hills", 23.50m);
			Wine w2 = new Wine(2005, "Mark Ryan Dissident", "Ciel du Cheval", 40.00m);

			//Write out the property values
			//Note that in these cases we are using the 
			Console.WriteLine("Wine 1: {0}, {1}", w1.MenuDescription, w1.Price);
			Console.WriteLine("Wine 2: {0}, {1}", w2.MenuDescription, w2.Price);
			Console.WriteLine();

			//Change the wholesale price of one of the wines using the setter
			w2.Price = 45.0m;

			//Write out the wine description, note how the retail price automatically changes
			Console.WriteLine("Wine 2: {0}, {1}", w2.MenuDescription, w2.Price);

			Console.ReadLine();
		}
	}
}
