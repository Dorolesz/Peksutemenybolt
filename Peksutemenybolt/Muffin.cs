using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peksutemenybolt
{
	internal class Muffin : BakedGood
	{
		private string flavor { get; set; }

		public Muffin(string flavor, string name, double price, int calories) : base(name, price, calories)
		{
			this.flavor = flavor;
		}

		public override string GetDescription()
		{
			return $"A termék neve: {name}\nAroma: {flavor}\nKalória: {calories} kcal\nÁra: {price} Ft\n";
		}

		public override void IncreasePrice(double amount)
		{
			price *= 1.10;
		}
	}
}
