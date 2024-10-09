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

		public Muffin(string flavor)
		{
			this.flavor = flavor;
		}
	}
}
