using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MethodOverriding
{
	class baseClass
	{
		public virtual void doSomething()
		{
			Console.WriteLine("This is the baseClass saying Hi!");
		}
	}

	class subClass : baseClass
	{
		public override void doSomething()
		{
			base.doSomething();
			Console.WriteLine("This is the subClass saying Hi!");
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			subClass obj1 = new subClass();

			obj1.doSomething();

			Console.ReadLine();
		}
	}
}
