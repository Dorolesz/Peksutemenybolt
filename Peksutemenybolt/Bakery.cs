using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Peksutemenybolt
{
	internal class Bakery
	{
		private string name { get; set;  }
		private List<BakedGood> products { get; set; }

		public Bakery(string name)
		{
			this.name = name;
			products = new List<BakedGood>();
		}

		public void AddProducts(string product)
		{
			products.Add(BakedGood(product));
		}

		public void DisplayProducts()
		{
			Console.WriteLine(products);
		}

		public void CalculateTotalCalories()
		{
			Console.WriteLine(); 
		}

		public void CalculateTotalPrice()
		{
			;
		}

	}
}
