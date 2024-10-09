using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peksutemenybolt
{
	internal class Croissant : BakedGood
	{
		private int butterContent { get; set; }

		public Croissant(int butterContent, string name, double price, int calories) : base(name, price, calories)
		{
			this.butterContent = butterContent;
		}

		public override string GetDescription()
		{
			return $"A termék neve: {name}\nVajtartalma: {butterContent}\nKalóriája: {calories}\nÁra: {price}";
		}
		public override void IncreasePrice(double amount)
		{
			throw new NotImplementedException();
		}
	}
}
