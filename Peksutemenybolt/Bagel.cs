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

		public override string GetDescription()
		{
			return $"A termék neve: {name}\nFeltét: {topping}\nKalória: {calories} kcal\nÁra: {price} Ft\n";
		}

		public override void IncreasePrice(double amount)
		{
			price += 30;
		}
	}
}
