#pragma checksum "C:\Users\omerk\source\repos\EcommerceWebSite\EcommerceWebSite\Areas\ORDER\Views\Order\Order.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0a016e54818a31049c734fd2f2547b84ea997d37"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_ORDER_Views_Order_Order), @"mvc.1.0.view", @"/Areas/ORDER/Views/Order/Order.cshtml")]
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
#line 1 "C:\Users\omerk\source\repos\EcommerceWebSite\EcommerceWebSite\Areas\ORDER\Views\Order\Order.cshtml"
using Data.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0a016e54818a31049c734fd2f2547b84ea997d37", @"/Areas/ORDER/Views/Order/Order.cshtml")]
    #nullable restore
    public class Areas_ORDER_Views_Order_Order : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Order>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\omerk\source\repos\EcommerceWebSite\EcommerceWebSite\Areas\ORDER\Views\Order\Order.cshtml"
  
    ViewData["Title"] = "Order";
    Layout = "~/Views/Shared/_AnaLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- Breadcrumb Section Begin -->
<section class=""breadcrumb-option"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-12"">
                <div class=""breadcrumb__text"">
                    <h4>Sipariş</h4>
                    <div class=""breadcrumb__links"">
                        <a href=""/anasayfa"">Ana Sayfa</a>

                        <span>Sipariş</span>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>
<!-- Breadcrumb Section End -->
<!-- Checkout Section Begin -->

<section class=""checkout spad"">
    <div class=""container"">
        <div class=""checkout__form"">
            <form method=""post"" action=""/siparis"">
                <div class=""row"">
                    <div class=""col-lg-8 col-md-6"">

                        <h6 class=""checkout__title"">Ödeme Bilgileri</h6>
");
#nullable restore
#line 37 "C:\Users\omerk\source\repos\EcommerceWebSite\EcommerceWebSite\Areas\ORDER\Views\Order\Order.cshtml"
                          
                            var c = ViewBag.kullanici as Customer;
                        

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <div class=\"checkout__input\">\r\n\r\n                            <div class=\"row\">\r\n\r\n                                <div class=\"col-6\">\r\n                                    ");
#nullable restore
#line 46 "C:\Users\omerk\source\repos\EcommerceWebSite\EcommerceWebSite\Areas\ORDER\Views\Order\Order.cshtml"
                               Write(Html.Label("İsim"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    <input type=\"text\" readonly");
            BeginWriteAttribute("value", " value=\"", 1440, "\"", 1460, 1);
#nullable restore
#line 47 "C:\Users\omerk\source\repos\EcommerceWebSite\EcommerceWebSite\Areas\ORDER\Views\Order\Order.cshtml"
WriteAttributeValue("", 1448, c.FirstName, 1448, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                                    ");
#nullable restore
#line 48 "C:\Users\omerk\source\repos\EcommerceWebSite\EcommerceWebSite\Areas\ORDER\Views\Order\Order.cshtml"
                               Write(Html.Label("Soyisim"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    <input type=\"text\" readonly");
            BeginWriteAttribute("value", " value=\"", 1589, "\"", 1608, 1);
#nullable restore
#line 49 "C:\Users\omerk\source\repos\EcommerceWebSite\EcommerceWebSite\Areas\ORDER\Views\Order\Order.cshtml"
WriteAttributeValue("", 1597, c.LastName, 1597, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                                </div>\r\n                                <div class=\"col-6\">\r\n                                    ");
#nullable restore
#line 52 "C:\Users\omerk\source\repos\EcommerceWebSite\EcommerceWebSite\Areas\ORDER\Views\Order\Order.cshtml"
                               Write(Html.Label("Email"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    <input type=\"text\" readonly");
            BeginWriteAttribute("value", " value=\"", 1828, "\"", 1844, 1);
#nullable restore
#line 53 "C:\Users\omerk\source\repos\EcommerceWebSite\EcommerceWebSite\Areas\ORDER\Views\Order\Order.cshtml"
WriteAttributeValue("", 1836, c.Email, 1836, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                                    ");
#nullable restore
#line 54 "C:\Users\omerk\source\repos\EcommerceWebSite\EcommerceWebSite\Areas\ORDER\Views\Order\Order.cshtml"
                               Write(Html.Label("Telefon"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    <input type=\"text\" readonly");
            BeginWriteAttribute("value", " value=\"", 1973, "\"", 1989, 1);
#nullable restore
#line 55 "C:\Users\omerk\source\repos\EcommerceWebSite\EcommerceWebSite\Areas\ORDER\Views\Order\Order.cshtml"
WriteAttributeValue("", 1981, c.Phone, 1981, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n\r\n                                </div>\r\n\r\n\r\n                                <div class=\"col-12\">\r\n\r\n                                    ");
#nullable restore
#line 62 "C:\Users\omerk\source\repos\EcommerceWebSite\EcommerceWebSite\Areas\ORDER\Views\Order\Order.cshtml"
                               Write(Html.Label("Adres"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    ");
#nullable restore
#line 63 "C:\Users\omerk\source\repos\EcommerceWebSite\EcommerceWebSite\Areas\ORDER\Views\Order\Order.cshtml"
                               Write(Html.TextAreaFor(i=>i.OrderAddress,new{placeholder="adress",@class="form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    ");
#nullable restore
#line 64 "C:\Users\omerk\source\repos\EcommerceWebSite\EcommerceWebSite\Areas\ORDER\Views\Order\Order.cshtml"
                               Write(Html.ValidationMessageFor(i=>i.OrderAddress));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </div>\r\n\r\n                                <div class=\"col-12 mt-4\">\r\n                                    ");
#nullable restore
#line 68 "C:\Users\omerk\source\repos\EcommerceWebSite\EcommerceWebSite\Areas\ORDER\Views\Order\Order.cshtml"
                               Write(Html.DropDownListFor(x=>x.PaymentID,(List<SelectListItem>)ViewBag.payment,new{@class=""}));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                   
                                </div>
                            </div>




                        </div>


                    </div>
                    <div class=""col-lg-4 col-md-6"">
                        <div class=""checkout__order"">
                            <h4 class=""order__title"">Siparişiniz</h4>
                            <div class=""checkout__order__products"">Ürün <span>Fiyat</span></div>
                            <ul class=""checkout__total__products"">
");
#nullable restore
#line 85 "C:\Users\omerk\source\repos\EcommerceWebSite\EcommerceWebSite\Areas\ORDER\Views\Order\Order.cshtml"
                                  
                                    var i = 0;
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 88 "C:\Users\omerk\source\repos\EcommerceWebSite\EcommerceWebSite\Areas\ORDER\Views\Order\Order.cshtml"
                                 if (TempData["sepetItems"] != null)
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 90 "C:\Users\omerk\source\repos\EcommerceWebSite\EcommerceWebSite\Areas\ORDER\Views\Order\Order.cshtml"
                                     foreach (var item in (List<ShoppingCartItems>)TempData["sepetItems"])
                                    {

                                        i++;

                                        var adetPrice = item.ProductItem.new_price * item.Adet;


#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <li> <b> ");
#nullable restore
#line 97 "C:\Users\omerk\source\repos\EcommerceWebSite\EcommerceWebSite\Areas\ORDER\Views\Order\Order.cshtml"
                                            Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral(" -  ");
#nullable restore
#line 97 "C:\Users\omerk\source\repos\EcommerceWebSite\EcommerceWebSite\Areas\ORDER\Views\Order\Order.cshtml"
                                                  Write(item.ProductItem.Product.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" (x ");
#nullable restore
#line 97 "C:\Users\omerk\source\repos\EcommerceWebSite\EcommerceWebSite\Areas\ORDER\Views\Order\Order.cshtml"
                                                                                           Write(item.Adet);

#line default
#line hidden
#nullable disable
            WriteLiteral(") --- ");
#nullable restore
#line 97 "C:\Users\omerk\source\repos\EcommerceWebSite\EcommerceWebSite\Areas\ORDER\Views\Order\Order.cshtml"
                                                                                                           Write(adetPrice.ToString("C0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </b> </li>\r\n");
#nullable restore
#line 98 "C:\Users\omerk\source\repos\EcommerceWebSite\EcommerceWebSite\Areas\ORDER\Views\Order\Order.cshtml"
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 98 "C:\Users\omerk\source\repos\EcommerceWebSite\EcommerceWebSite\Areas\ORDER\Views\Order\Order.cshtml"
                                     
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </ul>\r\n                            <ul class=\"checkout__total__all\">\r\n");
#nullable restore
#line 103 "C:\Users\omerk\source\repos\EcommerceWebSite\EcommerceWebSite\Areas\ORDER\Views\Order\Order.cshtml"
                                 if (ViewBag.sepetPrice != null)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <li>Toplam <span>");
#nullable restore
#line 105 "C:\Users\omerk\source\repos\EcommerceWebSite\EcommerceWebSite\Areas\ORDER\Views\Order\Order.cshtml"
                                                Write(ViewBag.sepetPrice.ToString("C0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></li>\r\n");
#nullable restore
#line 106 "C:\Users\omerk\source\repos\EcommerceWebSite\EcommerceWebSite\Areas\ORDER\Views\Order\Order.cshtml"

                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            </ul>

                            <div class=""checkout__input__checkbox"">
                                <label for=""payment"">
                                    Check Payment
                                    <input type=""checkbox"" id=""payment"">
                                    <span class=""checkmark""></span>
                                </label>
                            </div>
                            <div class=""checkout__input__checkbox"">
                                <label for=""paypal"">
                                    Paypal
                                    <input type=""checkbox"" id=""paypal"">
                                    <span class=""checkmark""></span>
                                </label>
                            </div>
                            <button type=""submit"" class=""site-btn"">Sipariş Ver</button>
                            <a href=""/sepet"" class=""btn btn-dark"">Sepete Dön</a>
                        </div>
 ");
            WriteLiteral("                   </div>\r\n                </div>\r\n            </form>\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n");
            WriteLiteral("\r\n\r\n\r\n<!-- Checkout Section End -->\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Order> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
