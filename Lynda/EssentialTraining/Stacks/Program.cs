using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Stacks
{
	class Program
	{
		static void Main(string[] args)
		{
			Stack myStack = new Stack();

			myStack.Push("item 1");
			myStack.Push("item 2");
			myStack.Push("item 3");
			Console.WriteLine("{0} Items on the stack", myStack.Count);

			//Have a peek at the top item
			Console.WriteLine("{0}", myStack.Peek());

			myStack.Pop();
			Console.WriteLine("{0}", myStack.Peek());

			myStack.Clear();
			Console.WriteLine("{0} Items on the stack", myStack.Count);

			Console.ReadLine();
		}
	}
}
