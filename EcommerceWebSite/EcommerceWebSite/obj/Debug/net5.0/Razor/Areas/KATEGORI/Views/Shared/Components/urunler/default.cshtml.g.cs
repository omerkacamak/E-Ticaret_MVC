#pragma checksum "C:\Users\omerk\source\repos\EcommerceWebSite\EcommerceWebSite\Areas\KATEGORI\Views\Shared\Components\urunler\default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "220e5aff99c939269e4b0e6f225698b8777bcaec"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_KATEGORI_Views_Shared_Components_urunler_default), @"mvc.1.0.view", @"/Areas/KATEGORI/Views/Shared/Components/urunler/default.cshtml")]
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
#line 1 "C:\Users\omerk\source\repos\EcommerceWebSite\EcommerceWebSite\Areas\KATEGORI\Views\Shared\Components\urunler\default.cshtml"
using Data.Models.WriteSql;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\omerk\source\repos\EcommerceWebSite\EcommerceWebSite\Areas\KATEGORI\Views\Shared\Components\urunler\default.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\omerk\source\repos\EcommerceWebSite\EcommerceWebSite\Areas\KATEGORI\Views\Shared\Components\urunler\default.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"220e5aff99c939269e4b0e6f225698b8777bcaec", @"/Areas/KATEGORI/Views/Shared/Components/urunler/default.cshtml")]
    #nullable restore
    public class Areas_KATEGORI_Views_Shared_Components_urunler_default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IPagedList<ProductItemSql>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n\n\n\n");
#nullable restore
#line 9 "C:\Users\omerk\source\repos\EcommerceWebSite\EcommerceWebSite\Areas\KATEGORI\Views\Shared\Components\urunler\default.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"col-lg-4 col-md-6 col-sm-6\">\n        <div class=\"product__item sale\">\n            <div class=\"product__item__pic \" style=\"background-image:url(/img/product/product-3.jpg)\">\n");
#nullable restore
#line 14 "C:\Users\omerk\source\repos\EcommerceWebSite\EcommerceWebSite\Areas\KATEGORI\Views\Shared\Components\urunler\default.cshtml"
                 if (@item.DiscountStatus == true)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <span class=\"label\">İNDİRİM</span>\n");
#nullable restore
#line 17 "C:\Users\omerk\source\repos\EcommerceWebSite\EcommerceWebSite\Areas\KATEGORI\Views\Shared\Components\urunler\default.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <ul class=\"product__hover\">\n                    <li><a href=\"#\"><img src=\"/img/icon/heart.png\"");
            BeginWriteAttribute("alt", " alt=\"", 587, "\"", 593, 0);
            EndWriteAttribute();
            WriteLiteral("></a></li>\n                    <li>\n                        <a");
            BeginWriteAttribute("href", " href=\"", 656, "\"", 686, 2);
            WriteAttributeValue("", 663, "/urun/", 663, 6, true);
#nullable restore
#line 21 "C:\Users\omerk\source\repos\EcommerceWebSite\EcommerceWebSite\Areas\KATEGORI\Views\Shared\Components\urunler\default.cshtml"
WriteAttributeValue("", 669, item.ProductName, 669, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><img src=\"/img/icon/compare.png\"");
            BeginWriteAttribute("alt", " alt=\"", 720, "\"", 726, 0);
            EndWriteAttribute();
            WriteLiteral("> <span>Ürüne Git</span></a>\n                    </li>\n                    <li><a href=\"#\"><img src=\"/img/icon/search.png\"");
            BeginWriteAttribute("alt", " alt=\"", 849, "\"", 855, 0);
            EndWriteAttribute();
            WriteLiteral("></a></li>\n                </ul>\n            </div>\n            <div class=\"product__item__text\">\n                <h6>");
#nullable restore
#line 27 "C:\Users\omerk\source\repos\EcommerceWebSite\EcommerceWebSite\Areas\KATEGORI\Views\Shared\Components\urunler\default.cshtml"
               Write(item.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\n                <a");
            BeginWriteAttribute("onclick", " onclick=\"", 1015, "\"", 1055, 3);
            WriteAttributeValue("", 1025, "sepetekle(", 1025, 10, true);
#nullable restore
#line 28 "C:\Users\omerk\source\repos\EcommerceWebSite\EcommerceWebSite\Areas\KATEGORI\Views\Shared\Components\urunler\default.cshtml"
WriteAttributeValue("", 1035, item.ProductItemID, 1035, 19, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1054, ")", 1054, 1, true);
            EndWriteAttribute();
            WriteLiteral(@" class=""add-cart"">+ Sepete Ekle</a>
                <div class=""rating"">
                    <i class=""fa fa-star""></i>
                    <i class=""fa fa-star""></i>
                    <i class=""fa fa-star""></i>
                    <i class=""fa fa-star-o""></i>
                    <i class=""fa fa-star-o""></i>
                </div>
                <h5>");
#nullable restore
#line 36 "C:\Users\omerk\source\repos\EcommerceWebSite\EcommerceWebSite\Areas\KATEGORI\Views\Shared\Components\urunler\default.cshtml"
               Write(item.new_price.ToString("C0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h5>
                <div class=""product__color__select"">
                    <label for=""pc-7"">
                        <input type=""radio"" id=""pc-7"">
                    </label>
                    <label class=""active black"" for=""pc-8"">
                        <input type=""radio"" id=""pc-8"">
                    </label>
                    <label class=""grey"" for=""pc-9"">
                        <input type=""radio"" id=""pc-9"">
                    </label>
                </div>
            </div>
        </div>
    </div>
");
#nullable restore
#line 51 "C:\Users\omerk\source\repos\EcommerceWebSite\EcommerceWebSite\Areas\KATEGORI\Views\Shared\Components\urunler\default.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"




<script>
    function sepetekle(id) {
        
            $.ajax({
                type: ""GET"",
                url: ""/SHOPPINGCART/Home/AddCart?id="" + id + ""&adet=1"",
                success: function(data) {
                    // sayfadaki sepet sayısı değişebilir
                    //document.getElementById(""pricespan"").innerHTML = data;
                    alert(data)
                }
            });

        
    }



</script>





");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IPagedList<ProductItemSql>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591