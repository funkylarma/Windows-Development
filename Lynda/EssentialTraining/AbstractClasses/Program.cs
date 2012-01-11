using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractClasses
{
	abstract class myBaseClass
	{
		public abstract int myMethod(int arg1, int arg2);
	}

	class myDerivedClass : myBaseClass
	{
		public override int myMethod(int arg1, int arg2)
		{
			return arg1 + arg2;
		}
	}
	
	class Program
	{
		static void Main(string[] args)
		{
			myDerivedClass mdc = new myDerivedClass();
			int result = mdc.myMethod(5,6);
			Console.WriteLine("{0}", result);

			Console.ReadLine();
		}
	}
}
