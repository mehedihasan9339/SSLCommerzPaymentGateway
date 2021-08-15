using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaymentGatewaySSLCommerz.Models
{
	public class ProductViewModel
	{
		public string[] name { get; set; }
		public decimal[] price { get; set; }
		public string[] url { get; set; }
		public int[] qty { get; set; }

		public string pname { get; set; }
		public string purl { get; set; }
		public decimal pprice { get; set; }

		public IEnumerable<CartItemsViewModel> cartItems { get; set; }
	}
}
