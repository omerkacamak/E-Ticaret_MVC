#pragma checksum "C:\Users\omerk\source\repos\EcommerceWebSite\EcommerceWebSite\Areas\AdminUrunler\Views\Shared\Components\urunGuncelle\default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "41689e55ae190134236684855bdcdc8ff78c9489"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_AdminUrunler_Views_Shared_Components_urunGuncelle_default), @"mvc.1.0.view", @"/Areas/AdminUrunler/Views/Shared/Components/urunGuncelle/default.cshtml")]
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
#line 1 "C:\Users\omerk\source\repos\EcommerceWebSite\EcommerceWebSite\Areas\AdminUrunler\Views\Shared\Components\urunGuncelle\default.cshtml"
using Data.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"41689e55ae190134236684855bdcdc8ff78c9489", @"/Areas/AdminUrunler/Views/Shared/Components/urunGuncelle/default.cshtml")]
    #nullable restore
    public class Areas_AdminUrunler_Views_Shared_Components_urunGuncelle_default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductItem>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n\r\n\r\n<form action=\"/admin/updateUrun\" method=\"POST\">\r\n<div class=\"card card-danger\">\r\n              \r\n              <div class=\"card-body\">\r\n                <div class=\"row\">\r\n                  <div class=\"col-6\">\r\n                     ");
#nullable restore
#line 13 "C:\Users\omerk\source\repos\EcommerceWebSite\EcommerceWebSite\Areas\AdminUrunler\Views\Shared\Components\urunGuncelle\default.cshtml"
                Write(Html.Label("Ürün Adı"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n                    ");
#nullable restore
#line 16 "C:\Users\omerk\source\repos\EcommerceWebSite\EcommerceWebSite\Areas\AdminUrunler\Views\Shared\Components\urunGuncelle\default.cshtml"
               Write(Html.DropDownListFor(i=>i.ProductID,(List<SelectListItem>)ViewBag.urunAdi,new{@class="form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                  </div>\r\n                   <div class=\"col-6\">\r\n                     ");
#nullable restore
#line 19 "C:\Users\omerk\source\repos\EcommerceWebSite\EcommerceWebSite\Areas\AdminUrunler\Views\Shared\Components\urunGuncelle\default.cshtml"
                Write(Html.Label("Ürün item"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 20 "C:\Users\omerk\source\repos\EcommerceWebSite\EcommerceWebSite\Areas\AdminUrunler\Views\Shared\Components\urunGuncelle\default.cshtml"
               Write(Html.TextBoxFor(i=>i.ProductItemID, new{@class="form-control",@readonly="readonly"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                  </div>\r\n                  <div class=\"col-6\">\r\n                    ");
#nullable restore
#line 23 "C:\Users\omerk\source\repos\EcommerceWebSite\EcommerceWebSite\Areas\AdminUrunler\Views\Shared\Components\urunGuncelle\default.cshtml"
               Write(Html.Label("Size"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 24 "C:\Users\omerk\source\repos\EcommerceWebSite\EcommerceWebSite\Areas\AdminUrunler\Views\Shared\Components\urunGuncelle\default.cshtml"
               Write(Html.TextBoxFor(i=>i.Size, new{@class="form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                  </div>\r\n                   <div class=\"col-6\">\r\n                    ");
#nullable restore
#line 27 "C:\Users\omerk\source\repos\EcommerceWebSite\EcommerceWebSite\Areas\AdminUrunler\Views\Shared\Components\urunGuncelle\default.cshtml"
               Write(Html.Label("Renk"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 28 "C:\Users\omerk\source\repos\EcommerceWebSite\EcommerceWebSite\Areas\AdminUrunler\Views\Shared\Components\urunGuncelle\default.cshtml"
               Write(Html.TextBoxFor(i=>i.Color, new{@class="form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                  </div>\r\n                    <div class=\"col-6\">\r\n                     ");
#nullable restore
#line 31 "C:\Users\omerk\source\repos\EcommerceWebSite\EcommerceWebSite\Areas\AdminUrunler\Views\Shared\Components\urunGuncelle\default.cshtml"
                Write(Html.Label("İndirim Durumu"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 32 "C:\Users\omerk\source\repos\EcommerceWebSite\EcommerceWebSite\Areas\AdminUrunler\Views\Shared\Components\urunGuncelle\default.cshtml"
               Write(Html.TextBoxFor(i=>i.DiscountStatus, new{@class="form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                  </div>\r\n                   <div class=\"col-6\">\r\n                     ");
#nullable restore
#line 35 "C:\Users\omerk\source\repos\EcommerceWebSite\EcommerceWebSite\Areas\AdminUrunler\Views\Shared\Components\urunGuncelle\default.cshtml"
                Write(Html.Label("İndirim Yüzdesi"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 36 "C:\Users\omerk\source\repos\EcommerceWebSite\EcommerceWebSite\Areas\AdminUrunler\Views\Shared\Components\urunGuncelle\default.cshtml"
               Write(Html.TextBoxFor(i=>i.Discount, new{@class="form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                  </div>\r\n                   <div class=\"col-6\">\r\n                     ");
#nullable restore
#line 39 "C:\Users\omerk\source\repos\EcommerceWebSite\EcommerceWebSite\Areas\AdminUrunler\Views\Shared\Components\urunGuncelle\default.cshtml"
                Write(Html.Label("İndirimsiz Fiyat"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 40 "C:\Users\omerk\source\repos\EcommerceWebSite\EcommerceWebSite\Areas\AdminUrunler\Views\Shared\Components\urunGuncelle\default.cshtml"
               Write(Html.TextBoxFor(i=>i.price, new{@class="form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                  </div>\r\n                 \r\n                   <div class=\"col-6\">\r\n                     ");
#nullable restore
#line 44 "C:\Users\omerk\source\repos\EcommerceWebSite\EcommerceWebSite\Areas\AdminUrunler\Views\Shared\Components\urunGuncelle\default.cshtml"
                Write(Html.Label("Stok Adedi"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 45 "C:\Users\omerk\source\repos\EcommerceWebSite\EcommerceWebSite\Areas\AdminUrunler\Views\Shared\Components\urunGuncelle\default.cshtml"
               Write(Html.TextBoxFor(i=>i.StokAdedi, new{@class="form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                  </div>\r\n                   <div class=\"col-6\">\r\n                     ");
#nullable restore
#line 48 "C:\Users\omerk\source\repos\EcommerceWebSite\EcommerceWebSite\Areas\AdminUrunler\Views\Shared\Components\urunGuncelle\default.cshtml"
                Write(Html.Label("Satılan Miktar"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 49 "C:\Users\omerk\source\repos\EcommerceWebSite\EcommerceWebSite\Areas\AdminUrunler\Views\Shared\Components\urunGuncelle\default.cshtml"
               Write(Html.TextBoxFor(i=>i.SatilanMiktar, new{@class="form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                  </div>\r\n                   <div class=\"col-6\">\r\n                     ");
#nullable restore
#line 52 "C:\Users\omerk\source\repos\EcommerceWebSite\EcommerceWebSite\Areas\AdminUrunler\Views\Shared\Components\urunGuncelle\default.cshtml"
                Write(Html.Label("Durumu"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 53 "C:\Users\omerk\source\repos\EcommerceWebSite\EcommerceWebSite\Areas\AdminUrunler\Views\Shared\Components\urunGuncelle\default.cshtml"
               Write(Html.TextBoxFor(i=>i.status, new{@class="form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                  </div>\r\n                   \r\n\r\n\r\n                   \r\n                  \r\n\r\n                   ");
#nullable restore
#line 61 "C:\Users\omerk\source\repos\EcommerceWebSite\EcommerceWebSite\Areas\AdminUrunler\Views\Shared\Components\urunGuncelle\default.cshtml"
              Write(Html.HiddenFor(i=>i.new_price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                   ");
#nullable restore
#line 62 "C:\Users\omerk\source\repos\EcommerceWebSite\EcommerceWebSite\Areas\AdminUrunler\Views\Shared\Components\urunGuncelle\default.cshtml"
              Write(Html.HiddenFor(i=>i.old_price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                   ");
#nullable restore
#line 63 "C:\Users\omerk\source\repos\EcommerceWebSite\EcommerceWebSite\Areas\AdminUrunler\Views\Shared\Components\urunGuncelle\default.cshtml"
              Write(Html.HiddenFor(i=>i.CreatedTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                   ");
#nullable restore
#line 64 "C:\Users\omerk\source\repos\EcommerceWebSite\EcommerceWebSite\Areas\AdminUrunler\Views\Shared\Components\urunGuncelle\default.cshtml"
              Write(Html.HiddenFor(i=>i.image));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                   ");
#nullable restore
#line 65 "C:\Users\omerk\source\repos\EcommerceWebSite\EcommerceWebSite\Areas\AdminUrunler\Views\Shared\Components\urunGuncelle\default.cshtml"
              Write(Html.HiddenFor(i=>i.ProductCategoryID));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                  
                   
                </div>
              </div>
              <!-- /.card-body -->
            </div>
             <button class=""btn btn-success"" type=""submit"">
                 Kaydet
                </button>
</form>








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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductItem> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591