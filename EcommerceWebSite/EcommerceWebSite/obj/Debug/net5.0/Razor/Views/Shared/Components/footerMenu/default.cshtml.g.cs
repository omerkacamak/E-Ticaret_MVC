#pragma checksum "C:\Users\omerk\source\repos\EcommerceWebSite\EcommerceWebSite\Views\Shared\Components\footerMenu\default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "99a972390b108eb452bc77a71f1249711d906205"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_footerMenu_default), @"mvc.1.0.view", @"/Views/Shared/Components/footerMenu/default.cshtml")]
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
#line 1 "C:\Users\omerk\source\repos\EcommerceWebSite\EcommerceWebSite\Views\_ViewImports.cshtml"
using EcommerceWebSite;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\omerk\source\repos\EcommerceWebSite\EcommerceWebSite\Views\_ViewImports.cshtml"
using EcommerceWebSite.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\omerk\source\repos\EcommerceWebSite\EcommerceWebSite\Views\Shared\Components\footerMenu\default.cshtml"
using Data.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"99a972390b108eb452bc77a71f1249711d906205", @"/Views/Shared/Components/footerMenu/default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d67d00845226c173192c91a6803c97dc886da3fe", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_footerMenu_default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<MainCategory>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<footer class=""footer"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-3 col-md-6 col-sm-6"">
                    <div class=""footer__about"">
                        <div class=""footer__logo"">
                            <a href=""#""><img src=""img/footer-logo.png""");
            BeginWriteAttribute("alt", " alt=\"", 365, "\"", 371, 0);
            EndWriteAttribute();
            WriteLiteral("></a>\r\n                        </div>\r\n                        <p>");
#nullable restore
#line 11 "C:\Users\omerk\source\repos\EcommerceWebSite\EcommerceWebSite\Views\Shared\Components\footerMenu\default.cshtml"
                      Write(TempData["about"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <a href=\"#\"><img src=\"img/payment.png\"");
            BeginWriteAttribute("alt", " alt=\"", 524, "\"", 530, 0);
            EndWriteAttribute();
            WriteLiteral("></a>\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-lg-2 offset-lg-1 col-md-3 col-sm-6\">\r\n                    <div class=\"footer__widget\">\r\n                        <h6>Kategoriler</h6>\r\n                        <ul>\r\n");
#nullable restore
#line 19 "C:\Users\omerk\source\repos\EcommerceWebSite\EcommerceWebSite\Views\Shared\Components\footerMenu\default.cshtml"
                            foreach (var item in Model)
                          {

#line default
#line hidden
#nullable disable
            WriteLiteral("                               <li><a href=\"#\">");
#nullable restore
#line 21 "C:\Users\omerk\source\repos\EcommerceWebSite\EcommerceWebSite\Views\Shared\Components\footerMenu\default.cshtml"
                                          Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\n");
#nullable restore
#line 22 "C:\Users\omerk\source\repos\EcommerceWebSite\EcommerceWebSite\Views\Shared\Components\footerMenu\default.cshtml"
                          }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            
                        </ul>
                    </div>
                </div>
                <div class=""col-lg-2 col-md-3 col-sm-6"">
                    <div class=""footer__widget"">
                        <h6>Shopping</h6>
                        <ul>
                            <li><a href=""#"">Contact Us</a></li>
                            <li><a href=""#"">Payment Methods</a></li>
                            <li><a href=""#"">Delivary</a></li>
                            <li><a href=""#"">Return & Exchanges</a></li>
                        </ul>
                    </div>
                </div>
                <div class=""col-lg-3 offset-lg-1 col-md-6 col-sm-6"">
                    <div class=""footer__widget"">
                        <h6>NewLetter</h6>
                        <div class=""footer__newslatter"">
                            <p>Be the first to know about new arrivals, look books, sales & promos!</p>
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "99a972390b108eb452bc77a71f1249711d9062057209", async() => {
                WriteLiteral("\r\n                                <input type=\"text\" placeholder=\"Your email\">\r\n                                <button type=\"submit\"><span class=\"icon_mail_alt\"></span></button>\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        </div>
                    </div>
                </div>
            </div>
            <div class=""row"">
                <div class=""col-lg-12 text-center"">
                    <div class=""footer__copyright__text"">
                        <!-- Link back to Colorlib can't be removed. Template is licensed under CC BY 3.0. -->
                        <p>Copyright ©
                            <script>
                                document.write(new Date().getFullYear());
                            </script>2020
                            All rights reserved | This template is made with <i class=""fa fa-heart-o""
                            aria-hidden=""true""></i> by <a href=""https://colorlib.com"" target=""_blank"">Colorlib</a>
                        </p>
                        <!-- Link back to Colorlib can't be removed. Template is licensed under CC BY 3.0. -->
                    </div>
                </div>
            </div>
        </div>
    </footer>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<MainCategory>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
