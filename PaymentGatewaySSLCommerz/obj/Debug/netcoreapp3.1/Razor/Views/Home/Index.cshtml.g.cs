#pragma checksum "H:\Stored In GitHub\PaymentGatewaySSLCommerz\PaymentGatewaySSLCommerz\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d076b46aa60db5a9b69890624673264bcbf4414c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "H:\Stored In GitHub\PaymentGatewaySSLCommerz\PaymentGatewaySSLCommerz\Views\_ViewImports.cshtml"
using PaymentGatewaySSLCommerz;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "H:\Stored In GitHub\PaymentGatewaySSLCommerz\PaymentGatewaySSLCommerz\Views\_ViewImports.cshtml"
using PaymentGatewaySSLCommerz.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d076b46aa60db5a9b69890624673264bcbf4414c", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"768c5826688ac01e65df110d71828a1b98968ae7", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/styles.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Home/CheckoutDetails"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/main.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "H:\Stored In GitHub\PaymentGatewaySSLCommerz\PaymentGatewaySSLCommerz\Views\Home\Index.cshtml"
  
	ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<link href=\'https://fonts.googleapis.com/css?family=Open+Sans:400,600,700\' rel=\'stylesheet\' type=\'text/css\'>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "d076b46aa60db5a9b69890624673264bcbf4414c5838", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<style>
	.stats-container {
		width: 100% !important;
	}

	#cart {
		margin-top: 20px !important;
	}

	.cart-item {
		width: auto !important;
	}

	#grid-selector {
		width: 1025px !important;
	}

	.sideBox {
		height: 450px;
		overflow: scroll;
	}

	#grid {
		width: 1005px !important;
		height: 468px !important;
		overflow: scroll;
	}

	::-webkit-scrollbar {
		width: 0px;
		background: transparent; /* make scrollbar transparent */
	}
</style>
<div id=""wrapper"">
	<div class=""cart-icon-top"">
	</div>

	<div class=""cart-icon-bottom"">
	</div>

	");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d076b46aa60db5a9b69890624673264bcbf4414c7627", async() => {
                WriteLiteral(@"
		<input type=""submit"" id=""checkout"" value=""Go To Cart"" />

		<div id=""sidebar"">
			<h3>CART</h3>
			<div id=""cart"">
				<span class=""empty"">No items in cart.</span>
			</div>

			<div class=""sideBox"">
				<h3>CATEGORIES</h3>
				<div class=""checklist categories"">
					<ul>
						<li><a");
                BeginWriteAttribute("href", " href=\"", 1178, "\"", 1185, 0);
                EndWriteAttribute();
                WriteLiteral("><span></span>New Arivals</a></li>\r\n\t\t\t\t\t\t<li><a");
                BeginWriteAttribute("href", " href=\"", 1234, "\"", 1241, 0);
                EndWriteAttribute();
                WriteLiteral("><span></span>Accesories</a></li>\r\n\t\t\t\t\t\t<li><a");
                BeginWriteAttribute("href", " href=\"", 1289, "\"", 1296, 0);
                EndWriteAttribute();
                WriteLiteral("><span></span>Bags</a></li>\r\n\t\t\t\t\t\t<li><a");
                BeginWriteAttribute("href", " href=\"", 1338, "\"", 1345, 0);
                EndWriteAttribute();
                WriteLiteral("><span></span>Dressed</a></li>\r\n\t\t\t\t\t\t<li><a");
                BeginWriteAttribute("href", " href=\"", 1390, "\"", 1397, 0);
                EndWriteAttribute();
                WriteLiteral("><span></span>Jackets</a></li>\r\n\t\t\t\t\t\t<li><a");
                BeginWriteAttribute("href", " href=\"", 1442, "\"", 1449, 0);
                EndWriteAttribute();
                WriteLiteral("><span></span>jewelry</a></li>\r\n\t\t\t\t\t\t<li><a");
                BeginWriteAttribute("href", " href=\"", 1494, "\"", 1501, 0);
                EndWriteAttribute();
                WriteLiteral("><span></span>Shoes</a></li>\r\n\t\t\t\t\t\t<li><a");
                BeginWriteAttribute("href", " href=\"", 1544, "\"", 1551, 0);
                EndWriteAttribute();
                WriteLiteral("><span></span>Shirts</a></li>\r\n\t\t\t\t\t\t<li><a");
                BeginWriteAttribute("href", " href=\"", 1595, "\"", 1602, 0);
                EndWriteAttribute();
                WriteLiteral("><span></span>Sweaters</a></li>\r\n\t\t\t\t\t\t<li><a");
                BeginWriteAttribute("href", " href=\"", 1648, "\"", 1655, 0);
                EndWriteAttribute();
                WriteLiteral("><span></span>T-shirts</a></li>\r\n\t\t\t\t\t</ul>\r\n\t\t\t\t</div>\r\n\r\n\t\t\t\t<h3>COLORS</h3>\r\n\t\t\t\t<div class=\"checklist colors\">\r\n\t\t\t\t\t<ul>\r\n\t\t\t\t\t\t<li><a");
                BeginWriteAttribute("href", " href=\"", 1795, "\"", 1802, 0);
                EndWriteAttribute();
                WriteLiteral("><span></span>Beige</a></li>\r\n\t\t\t\t\t\t<li><a");
                BeginWriteAttribute("href", " href=\"", 1845, "\"", 1852, 0);
                EndWriteAttribute();
                WriteLiteral("><span style=\"background:#222\"></span>Black</a></li>\r\n\t\t\t\t\t\t<li><a");
                BeginWriteAttribute("href", " href=\"", 1919, "\"", 1926, 0);
                EndWriteAttribute();
                WriteLiteral("><span style=\"background:#6e8cd5\"></span>Blue</a></li>\r\n\t\t\t\t\t\t<li><a");
                BeginWriteAttribute("href", " href=\"", 1995, "\"", 2002, 0);
                EndWriteAttribute();
                WriteLiteral("><span style=\"background:#f56060\"></span>Brown</a></li>\r\n\t\t\t\t\t\t<li><a");
                BeginWriteAttribute("href", " href=\"", 2072, "\"", 2079, 0);
                EndWriteAttribute();
                WriteLiteral("><span style=\"background:#44c28d\"></span>Green</a></li>\r\n\t\t\t\t\t</ul>\r\n\r\n\t\t\t\t\t<ul>\r\n\t\t\t\t\t\t<li><a");
                BeginWriteAttribute("href", " href=\"", 2174, "\"", 2181, 0);
                EndWriteAttribute();
                WriteLiteral("><span style=\"background:#999\"></span>Grey</a></li>\r\n\t\t\t\t\t\t<li><a");
                BeginWriteAttribute("href", " href=\"", 2247, "\"", 2254, 0);
                EndWriteAttribute();
                WriteLiteral("><span style=\"background:#f79858\"></span>Orange</a></li>\r\n\t\t\t\t\t\t<li><a");
                BeginWriteAttribute("href", " href=\"", 2325, "\"", 2332, 0);
                EndWriteAttribute();
                WriteLiteral("><span style=\"background:#b27ef8\"></span>Purple</a></li>\r\n\t\t\t\t\t\t<li><a");
                BeginWriteAttribute("href", " href=\"", 2403, "\"", 2410, 0);
                EndWriteAttribute();
                WriteLiteral("><span style=\"background:#f56060\"></span>Red</a></li>\r\n\t\t\t\t\t\t<li><a");
                BeginWriteAttribute("href", " href=\"", 2478, "\"", 2485, 0);
                EndWriteAttribute();
                WriteLiteral("><span style=\"background:#fff;border: 1px solid #e8e9eb;width:13px;height:13px;\"></span>White</a></li>\r\n\t\t\t\t\t</ul>\r\n\t\t\t\t</div>\r\n\r\n\t\t\t\t<h3>SIZES</h3>\r\n\t\t\t\t<div class=\"checklist sizes\">\r\n\t\t\t\t\t<ul>\r\n\t\t\t\t\t\t<li><a");
                BeginWriteAttribute("href", " href=\"", 2694, "\"", 2701, 0);
                EndWriteAttribute();
                WriteLiteral("><span></span>XS</a></li>\r\n\t\t\t\t\t\t<li><a");
                BeginWriteAttribute("href", " href=\"", 2741, "\"", 2748, 0);
                EndWriteAttribute();
                WriteLiteral("><span></span>S</a></li>\r\n\t\t\t\t\t\t<li><a");
                BeginWriteAttribute("href", " href=\"", 2787, "\"", 2794, 0);
                EndWriteAttribute();
                WriteLiteral("><span></span>M</a></li>\r\n\t\t\t\t\t</ul>\r\n\r\n\t\t\t\t\t<ul>\r\n\t\t\t\t\t\t<li><a");
                BeginWriteAttribute("href", " href=\"", 2858, "\"", 2865, 0);
                EndWriteAttribute();
                WriteLiteral("><span></span>L</a></li>\r\n\t\t\t\t\t\t<li><a");
                BeginWriteAttribute("href", " href=\"", 2904, "\"", 2911, 0);
                EndWriteAttribute();
                WriteLiteral("><span></span>XL</a></li>\r\n\t\t\t\t\t\t<li><a");
                BeginWriteAttribute("href", " href=\"", 2951, "\"", 2958, 0);
                EndWriteAttribute();
                WriteLiteral("><span></span>XXL</a></li>\r\n\t\t\t\t\t</ul>\r\n\t\t\t\t</div>\r\n\r\n\t\t\t\t<h3>PRICE RANGE</h3>\r\n\t\t\t\t<img src=\"https://s3-us-west-2.amazonaws.com/s.cdpn.io/245657/price-range.png\"");
                BeginWriteAttribute("alt", " alt=\"", 3121, "\"", 3127, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n\t\t\t</div>\r\n\t\t</div>\r\n\t");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\t<div id=\"grid-selector\">\r\n\t\t<div id=\"grid-menu\">\r\n\t\t\tView:\r\n\t\t\t<ul>\r\n\t\t\t\t<li class=\"largeGrid\"><a");
            BeginWriteAttribute("href", " href=\"", 3264, "\"", 3271, 0);
            EndWriteAttribute();
            WriteLiteral("></a></li>\r\n\t\t\t\t<li class=\"smallGrid\"><a class=\"active\"");
            BeginWriteAttribute("href", " href=\"", 3327, "\"", 3334, 0);
            EndWriteAttribute();
            WriteLiteral("></a></li>\r\n\t\t\t</ul>\r\n\t\t</div>\r\n\r\n\t\tShowing 1–50 of 50 results\r\n\t</div>\r\n\r\n\r\n\t<div id=\"grid\">\r\n");
#nullable restore
#line 128 "H:\Stored In GitHub\PaymentGatewaySSLCommerz\PaymentGatewaySSLCommerz\Views\Home\Index.cshtml"
         foreach (var item in Model.cartItems)
		{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t<div class=\"product\">\r\n\t\t\t\t<div class=\"info-large\">\r\n\t\t\t\t\t<h4>");
#nullable restore
#line 132 "H:\Stored In GitHub\PaymentGatewaySSLCommerz\PaymentGatewaySSLCommerz\Views\Home\Index.cshtml"
                   Write(item.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n\t\t\t\t\t<div class=\"sku\">\r\n\t\t\t\t\t\tPRODUCT SKU: <strong>");
#nullable restore
#line 134 "H:\Stored In GitHub\PaymentGatewaySSLCommerz\PaymentGatewaySSLCommerz\Views\Home\Index.cshtml"
                                        Write(item.code);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n\t\t\t\t\t</div>\r\n\r\n\t\t\t\t\t<div class=\"price-big\">\r\n\t\t\t\t\t\t<span>$");
#nullable restore
#line 138 "H:\Stored In GitHub\PaymentGatewaySSLCommerz\PaymentGatewaySSLCommerz\Views\Home\Index.cshtml"
                          Write(item.prevPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> $<span class=\"price\">");
#nullable restore
#line 138 "H:\Stored In GitHub\PaymentGatewaySSLCommerz\PaymentGatewaySSLCommerz\Views\Home\Index.cshtml"
                                                                      Write(item.price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n\t\t\t\t\t</div>\r\n\r\n\t\t\t\t\t<h3>COLORS</h3>\r\n\t\t\t\t\t<div class=\"colors-large\">\r\n\t\t\t\t\t\t<ul>\r\n\t\t\t\t\t\t\t<li><a");
            BeginWriteAttribute("href", " href=\"", 3848, "\"", 3855, 0);
            EndWriteAttribute();
            WriteLiteral(" style=\"background:#222\"><span></span></a></li>\r\n\t\t\t\t\t\t\t<li><a");
            BeginWriteAttribute("href", " href=\"", 3918, "\"", 3925, 0);
            EndWriteAttribute();
            WriteLiteral(" style=\"background:#6e8cd5\"><span></span></a></li>\r\n\t\t\t\t\t\t\t<li><a");
            BeginWriteAttribute("href", " href=\"", 3991, "\"", 3998, 0);
            EndWriteAttribute();
            WriteLiteral(" style=\"background:#f56060\"><span></span></a></li>\r\n\t\t\t\t\t\t\t<li><a");
            BeginWriteAttribute("href", " href=\"", 4064, "\"", 4071, 0);
            EndWriteAttribute();
            WriteLiteral(@" style=""background:#44c28d""><span></span></a></li>
						</ul>
					</div>

					<h3>SIZE</h3>
					<div class=""sizes-large"">
						<span>XS</span>
						<span>S</span>
						<span>M</span>
						<span>L</span>
						<span>XL</span>
						<span>XXL</span>
					</div>

					<button class=""add-cart-large"">Add To Cart</button>

				</div>
				<div class=""make3D"">
					<div class=""product-front"">
						<div class=""shadow""></div>
						<img");
            BeginWriteAttribute("src", " src=\"", 4531, "\"", 4546, 1);
#nullable restore
#line 167 "H:\Stored In GitHub\PaymentGatewaySSLCommerz\PaymentGatewaySSLCommerz\Views\Home\Index.cshtml"
WriteAttributeValue("", 4537, item.url, 4537, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 4547, "\"", 4553, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n\r\n\t\t\t\t\t\t<div class=\"image_overlay\"></div>\r\n\t\t\t\t\t\t<div class=\"add_to_cart\">Add to cart</div>\r\n\t\t\t\t\t\t<div class=\"view_gallery\">View gallery</div>\r\n\t\t\t\t\t\t<div class=\"stats\">\r\n\t\t\t\t\t\t\t<div class=\"stats-container\">\r\n\t\t\t\t\t\t\t\t<span class=\"product_price\">$");
#nullable restore
#line 174 "H:\Stored In GitHub\PaymentGatewaySSLCommerz\PaymentGatewaySSLCommerz\Views\Home\Index.cshtml"
                                                        Write(item.price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n\t\t\t\t\t\t\t\t<span class=\"product_name\">");
#nullable restore
#line 175 "H:\Stored In GitHub\PaymentGatewaySSLCommerz\PaymentGatewaySSLCommerz\Views\Home\Index.cshtml"
                                                      Write(item.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n\t\t\t\t\t\t\t\t<p>");
#nullable restore
#line 176 "H:\Stored In GitHub\PaymentGatewaySSLCommerz\PaymentGatewaySSLCommerz\Views\Home\Index.cshtml"
                              Write(item.tag);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>

								<div class=""product-options"">
									<strong>SIZES</strong>
									<span>XS, S, M, L, XL, XXL</span>
									<strong>COLORS</strong>
									<div class=""colors"">
										<div class=""c-blue""><span></span></div>
										<div class=""c-red""><span></span></div>
										<div class=""c-white""><span></span></div>
										<div class=""c-green""><span></span></div>
									</div>
								</div>
							</div>
						</div>
					</div>

					<div class=""product-back"">
						<div class=""shadow""></div>
						<div class=""carousel"">
							<ul class=""carousel-container"">
");
#nullable restore
#line 197 "H:\Stored In GitHub\PaymentGatewaySSLCommerz\PaymentGatewaySSLCommerz\Views\Home\Index.cshtml"
                                 for (int i = 0; i < 10; i++)
								{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t\t<li><img");
            BeginWriteAttribute("src", " src=\"", 5575, "\"", 5620, 2);
            WriteAttributeValue("", 5581, "https://picsum.photos/200/300?random=", 5581, 37, true);
#nullable restore
#line 199 "H:\Stored In GitHub\PaymentGatewaySSLCommerz\PaymentGatewaySSLCommerz\Views\Home\Index.cshtml"
WriteAttributeValue("", 5618, i, 5618, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 5621, "\"", 5627, 0);
            EndWriteAttribute();
            WriteLiteral(" /></li>\r\n");
#nullable restore
#line 200 "H:\Stored In GitHub\PaymentGatewaySSLCommerz\PaymentGatewaySSLCommerz\Views\Home\Index.cshtml"
								}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"							</ul>
							<div class=""arrows-perspective"">
								<div class=""carouselPrev"">
									<div class=""y""></div>
									<div class=""x""></div>
								</div>
								<div class=""carouselNext"">
									<div class=""y""></div>
									<div class=""x""></div>
								</div>
							</div>
						</div>
						<div class=""flip-back"">
							<div class=""cy""></div>
							<div class=""cx""></div>
						</div>
					</div>
				</div>
			</div>
");
#nullable restore
#line 220 "H:\Stored In GitHub\PaymentGatewaySSLCommerz\PaymentGatewaySSLCommerz\Views\Home\Index.cshtml"
		}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t</div>\r\n</div>\r\n<script src=\"https://ajax.googleapis.com/ajax/libs/jquery/1.11.2/jquery.min.js\"></script>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d076b46aa60db5a9b69890624673264bcbf4414c23546", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
