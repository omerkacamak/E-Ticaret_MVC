#pragma checksum "C:\Users\omerk\source\repos\EcommerceWebSite\EcommerceWebSite\Areas\PRODUCT\Views\Shared\Components\sizeColorPrice\default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eb74cbc6433761795893777a8ee0a61e520b34ef"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_PRODUCT_Views_Shared_Components_sizeColorPrice_default), @"mvc.1.0.view", @"/Areas/PRODUCT/Views/Shared/Components/sizeColorPrice/default.cshtml")]
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
#line 1 "C:\Users\omerk\source\repos\EcommerceWebSite\EcommerceWebSite\Areas\PRODUCT\Views\Shared\Components\sizeColorPrice\default.cshtml"
using Data.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb74cbc6433761795893777a8ee0a61e520b34ef", @"/Areas/PRODUCT/Views/Shared/Components/sizeColorPrice/default.cshtml")]
    #nullable restore
    public class Areas_PRODUCT_Views_Shared_Components_sizeColorPrice_default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductItem>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<form method=\"post\" action=\"/sepetpost\">\r\n  \r\n\r\n\r\n\r\n<h3>");
#nullable restore
#line 10 "C:\Users\omerk\source\repos\EcommerceWebSite\EcommerceWebSite\Areas\PRODUCT\Views\Shared\Components\sizeColorPrice\default.cshtml"
Write(Model.new_price.ToString("C0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span>");
#nullable restore
#line 10 "C:\Users\omerk\source\repos\EcommerceWebSite\EcommerceWebSite\Areas\PRODUCT\Views\Shared\Components\sizeColorPrice\default.cshtml"
                                           if (Model.DiscountStatus == true) 
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\omerk\source\repos\EcommerceWebSite\EcommerceWebSite\Areas\PRODUCT\Views\Shared\Components\sizeColorPrice\default.cshtml"
       Write(Model.old_price.ToString("C0"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\omerk\source\repos\EcommerceWebSite\EcommerceWebSite\Areas\PRODUCT\Views\Shared\Components\sizeColorPrice\default.cshtml"
                                           
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></h3>\r\n\r\n\r\n</form>\r\n\r\n");
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