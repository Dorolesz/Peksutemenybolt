using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peksutemenybolt
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Bakery bakery = new Bakery("Pékség");

			bakery.AddProducts(new Bagel("Szezánmag", "Bagel", 180, 250));
			bakery.AddProducts(new Croissant(20, "Croissant", 230, 300));
			bakery.AddProducts(new Muffin("Csokoládé", "Muffin", 200, 350));

			bakery.DisplayProducts();
			bakery.CalculateTotalCalories();
			bakery.CalculateTotalPrice();

            Console.ReadKey();
        }
	}
}
