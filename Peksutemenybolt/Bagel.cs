using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peksutemenybolt
{
	internal class Bagel : BakedGood
	{
		private string topping { get; set; }

		public Bagel(string topping, string name, double prize, int calories) : base(name, prize, calories)
		{
			this.topping = topping;
		}
	}
}
