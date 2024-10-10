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

			bakery.AddProducts(new Croissant(20, "Kifli", (double)150m, 300));
			bakery.AddProducts(new Muffin("Csokoládé", "Muffin", (double)200m, 350));
			bakery.AddProducts(new Bagel("Szezámmag", "Bagel", (double)180m, 250));

			bakery.DisplayProducts();

			decimal totalPrice = bakery.CalculateTotalPrice();
			int totalCalories = bakery.CalculateTotalCalories();

            Console.WriteLine($"\nÖsszes ár: {totalPrice} Ft");
            Console.WriteLine($"Összes kakória: {totalCalories} kcal");

            Console.WriteLine("\nÁrak emelése...\n");

            foreach (var product in bakery.GetProducts())
            {
				product.IncreasePrice(0);
            }

			bakery.DisplayProducts();

			totalPrice = bakery.CalculateTotalPrice();
			totalCalories = bakery.CalculateTotalCalories();

            Console.WriteLine($"\nÖsszes ár: {totalPrice}");
            Console.WriteLine($"Összes kalória: {totalCalories} kcal");

            Console.ReadKey();
        }
	}
}
