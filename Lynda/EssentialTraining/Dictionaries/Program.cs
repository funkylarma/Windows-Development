using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Dictionaries
{
	class Program
	{
		static void Main(string[] args)
		{
			Hashtable myHT = new Hashtable();

			myHT.Add("SFO", "San Francisco Aitport");
			myHT.Add("SEA", "Seattle Tacoma Airport");
			myHT["IAD"] = "Washington Dulles Aitport";

			Console.WriteLine("Value for key {0} is {1}", "SEA", myHT["SEA"]);
			Console.WriteLine("There are {0} items", myHT.Count);

			myHT.Remove("SFO");
			if (myHT.ContainsKey("SFO"))
			{
				Console.WriteLine("Value for key {0} is {1}","SFO", myHT["SFO"]);
			}

			Console.ReadLine();
		}
	}
}
