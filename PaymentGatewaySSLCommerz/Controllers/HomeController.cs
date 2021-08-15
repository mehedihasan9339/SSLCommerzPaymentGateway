using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PaymentGatewaySSLCommerz.Models;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Threading.Tasks;

namespace PaymentGatewaySSLCommerz.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;

		public HomeController(ILogger<HomeController> logger)
		{
			_logger = logger;
		}

        public IActionResult Index()
        {
            var data = new List<CartItemsViewModel>();
			for (int i = 1; i <= 50; i++)
			{
                data.Add(new CartItemsViewModel
                {
                    id = i,
                    name = "Product_" + i,
                    tag = "Summer dress",
                    code = "2556" + i,
                    prevPrice = 40 + i,
                    price = 35 + i,
                    url = "https://picsum.photos/200/300?random=" + i
                });
			}
            var model = new ProductViewModel
            {
                cartItems = data
            };

            return View(model);
        }

        public IActionResult CheckoutDetails(ProductViewModel model)
		{
            var data = new List<ProductViewModel>();
			for (int i = 0; i < model.name.Length; i++)
			{
                data.Add(new ProductViewModel
                {
                    pname = model.name[i],
                    pprice = model.price[i],
                    purl = model.url[i],
                });
			}
            
            return View(data);
		}

        [HttpPost]
        public IActionResult Checkout(ProductViewModel model)
        {
            var productName = "";
            decimal price = 0;
            for (int i = 0; i < model.name.Length; i++)
            {
                productName += model.name[i] + ",";
                price += model.price[i] * model.qty[i];
            }

            var baseUrl = Request.Scheme + "://" + Request.Host;

            NameValueCollection data = new NameValueCollection();
            data.Add("total_amount", $"{price}");
            data.Add("tran_id", "TRAN-123456");
            data.Add("success_url", baseUrl + "/Home/CeckoutConfirmation");
            data.Add("fail_url", baseUrl + "/Home/CeckoutConfirmation");
            data.Add("cancel_url", baseUrl + "/Home/CeckoutCancelled");

            data.Add("version", "3.00");
            data.Add("cus_name", "ABC XY");
            data.Add("cus_email", "abc.xyz@mail.co");
            data.Add("cus_add1", "Address Line On");
            data.Add("cus_add2", "Address Line Tw");
            data.Add("cus_city", "City Nam");
            data.Add("cus_state", "State Nam");
            data.Add("cus_postcode", "Post Code");
            data.Add("cus_country", "Country");
            data.Add("cus_phone", "01735626326");
            data.Add("cus_fax", "0171111111");
            data.Add("ship_name", "ABC XY");
            data.Add("ship_add1", "Address Line On");
            data.Add("ship_add2", "Address Line Tw");
            data.Add("ship_city", "City Name");
            data.Add("ship_state", "State Name");
            data.Add("ship_postcode", "Post Code");
            data.Add("ship_country", "Country");
            data.Add("value_a", "ref00");
            data.Add("value_b", "ref00");
            data.Add("value_c", "ref00");
            data.Add("value_d", "ref00");
            data.Add("shipping_method", "NO");
            data.Add("num_of_item", "1");
            data.Add("product_name", $"{productName}");
            data.Add("product_profile", "general");
            data.Add("product_category", "Demo");


            //we can get from email notificaton
            var storeId = "sslde60fa99b624ea8";
            var storePassword = "sslde60fa99b624ea8@ssl";
            var isSandboxMood = true;

            SSLCommerzGatewayProcessor sslcz = new SSLCommerzGatewayProcessor(storeId, storePassword, isSandboxMood);

            string response = sslcz.InitiateTransaction(data);
            return Redirect(response);
        }


        public IActionResult CeckoutConfirmation()
        {
            if (!(!String.IsNullOrEmpty(Request.Form["status"]) && Request.Form["status"] == "VALID"))
            {
                ViewBag.SuccessInfo = "There some error while processing your payment. Please try again.";
                return View();
            }

            string TrxID = Request.Form["tran_id"];
            // AMOUNT and Currency FROM DB FOR THIS TRANSACTION
            string amount = Request.Form["amount"];
            string currency = "BDT";

            var storeId = "sslde60fa99b624ea8";
            var storePassword = "sslde60fa99b624ea8@ssl";

            SSLCommerzGatewayProcessor sslcz = new SSLCommerzGatewayProcessor(storeId, storePassword, true);
            var resonse = sslcz.OrderValidate(TrxID, amount, currency, Request);

            ViewBag.amount = amount;
            ViewBag.status = resonse;
            ViewBag.currency = currency;

            return View();
        }
        //public IActionResult CheckoutFailed()
        //{
        //    ViewBag.FailInfo = "There some error while processing your payment. Please try again.";
        //    return View();
        //}
        public IActionResult CheckoutCancel()
        {
            ViewBag.CancelInfo = "Your payment has been cancel";
            return View();
        }
    }
}
