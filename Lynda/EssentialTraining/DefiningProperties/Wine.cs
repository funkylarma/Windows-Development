using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefiningProperties
{
	class Wine
	{
		//Class variables
		private string Name;
		private int year;
		private string Apellation;
		private decimal wholesalePrice;
		private const decimal retailMarkup = 1.35m;

		//Price property
		public decimal Price
		{
			get
			{
				return wholesalePrice * retailMarkup;
			}

			set
			{
				wholesalePrice = value;
			}
		}

		//MenuDescription property
		public string MenuDescription
		{
			//Only a getter for this property, which is generated from private fields
			get
			{
				return year.ToString() + " " + Name + " " + Apellation;
			}
		}

		//Constructor method
		public Wine(int y, string sName, string sApp, decimal wp)
		{
			Name = sName;
			year = y;
			Apellation = sApp;
			wholesalePrice = wp;
		}
	}
}
