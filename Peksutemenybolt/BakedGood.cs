using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peksutemenybolt
{
	abstract class BakedGood
	{
		private string name;
		private double price;
		private int calories;

		public BakedGood(string name, double price, int calories) 
		{
			this.name = name;
			this.price = price;
			this.calories = calories;
		}

		public abstract string GetDescription();
		public abstract void IncreasePrice(double amount);
	}
}
