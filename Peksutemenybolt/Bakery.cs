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

		public void AddProducts(BakedGood product)
		{
			products.Add(product);
		}

		public void DisplayProducts()
		{
			foreach (var product in products)
			{
				Console.WriteLine(product.GetDescription());
			}
		}

		public void CalculateTotalCalories()
		{
			int totalCalories = products.Sum(product => product.Calories);
			Console.WriteLine($"Összes kalória: {totalCalories} kcal"); 
		}

		public void CalculateTotalPrice()
		{
			double totalPrice = products.Sum(product => product.Price);
            Console.WriteLine($"Összes ár: {totalPrice} Ft");
        }

	}
}
