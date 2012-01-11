using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UsingStructs
{
	public struct Point
	{
		private int xCoord;
		private int yCoord;

		public Point(int x, int y)
		{
			xCoord = x;
			yCoord = y;
		}

		public int x
		{
			get { return xCoord; }
			set { xCoord = value; }
		}

		public int y
		{
			get { return yCoord; }
			set { yCoord = value; }
		}
	}
	
	class Program
	{
		static void Main(string[] args)
		{
			Point p1 = new Point(100, 100);

			Point p2 = new Point();
			p2.x = 50;
			p2.y = 75;

			Console.ReadLine();
		}
	}
}
