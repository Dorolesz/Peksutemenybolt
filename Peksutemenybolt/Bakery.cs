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
		private string name;
		private List<BakedGood> products;

		public Bakery(string name)
		{
			this.name = name;
			products = new List<BakedGood>();
		}

		public void AddProducts(BakedGood product)
		{
			products.Add(product);
		}

		public List<BakedGood> GetProducts() 
		{
			return products; 
		}

		public void DisplayProducts()
		{
            Console.WriteLine($"Pékség neve: {name}\nKínálat:");
            foreach (var product in products)
			{
				Console.WriteLine(product.GetDescription());
			}
		}

		public int CalculateTotalCalories()
		{
			return products.Sum(product => product.Calories);
			//Console.WriteLine($"Összes kalória: {totalCalories} kcal"); 
		}

		public decimal CalculateTotalPrice()
		{
			return (decimal)products.Sum(product => (decimal)product.Price);
            //Console.WriteLine($"Összes ár: {totalPrice} Ft");
        }

	}
}
