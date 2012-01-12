using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NamedOptionalParams
{
	class Program
	{
		static void Main(string[] args)
		{
			// Call the Named parameters example
			myNamedParamExample(stateName: "Washington", zipCode: 98121, cityName: "Seattle");
			myNamedParamExample(cityName: "San Francisco", zipCode: 94109, stateName: "California");
			myNamedParamExample(zipCode: 94109, cityName: "New York", stateName: "New York State");

			// Call the optional parameters example
			myOpptionalParamFunc(15);
			myOpptionalParamFunc(10, 2.71828d);
			myOpptionalParamFunc(10, 2.71828d, "a different string");
			//myOpptionalParamFunc(10, "a different string");
			
			Console.ReadLine();
		}

		static void myOpptionalParamFunc(int param1, double param2 = 3.14159d, string param3 = "placeholder string")
		{
			Console.WriteLine("Called with: \n\tparam1 {0}, \n\tparam2 {1}, \n\tparam3 {2}", param1, param2, param3);
		}

		static void myNamedParamExample(string cityName, string stateName, int zipCode)
		{
			Console.WriteLine("Arguments passed: \n\tcityName is {0}, \n\tstateName is {1}, \n\tzipCode is {2}", cityName, stateName, zipCode);
		}
	}
}
