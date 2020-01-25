using System;
using System.Collections.Generic;
using System.Text;

namespace XFChallenge3.Models
{
	public class Product
	{
		public string Name { get; set; }

		public string Description { get; set; }

		public List<Image> Images { get; set; }

		public string Price { get; set; }
		public string SalePrice { get; set; }

		public bool Sale { get; set; }

		public bool Favourite { get; set; }
	}
}
