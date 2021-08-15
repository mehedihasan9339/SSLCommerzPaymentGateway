using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaymentGatewaySSLCommerz.Models
{
	public class CartItemsViewModel
	{
		public int id { get; set; }
		public string name { get; set; }
		public string code { get; set; }
		public string tag { get; set; }
		public string url { get; set; }
		public decimal? prevPrice { get; set; }
		public decimal? price { get; set; }
	}
}
