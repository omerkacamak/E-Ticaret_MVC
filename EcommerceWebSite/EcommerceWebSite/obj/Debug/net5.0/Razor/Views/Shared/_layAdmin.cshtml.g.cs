#pragma checksum "C:\Users\omerk\source\repos\EcommerceWebSite\EcommerceWebSite\Views\Shared\_layAdmin.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "21093d747626edab8c0f4c88e0ad860beb94d400"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__layAdmin), @"mvc.1.0.view", @"/Views/Shared/_layAdmin.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"21093d747626edab8c0f4c88e0ad860beb94d400", @"/Views/Shared/_layAdmin.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d67d00845226c173192c91a6803c97dc886da3fe", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__layAdmin : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("hold-transition sidebar-mini"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "21093d747626edab8c0f4c88e0ad860beb94d4004367", async() => {
                WriteLiteral(@"
    <meta charset=""utf-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
    <title>Admin | MyEcommerce</title>

    <!-- Google Font: Source Sans Pro -->
    <link rel=""stylesheet"" href=""https://fonts.googleapis.com/css?family=Source+Sans+Pro:300,400,400i,700&display=fallback"">
    <!-- Font Awesome -->
    <link rel=""stylesheet"" href=""/admin/plugins/fontawesome-free/css/all.min.css"">
    <!-- Theme style -->
    <link rel=""stylesheet"" href=""/admin/dist/css/adminlte.min.css"">
    
    
    <link rel=""stylesheet"" href=""/admin/plugins/datatables-bs4/css/dataTables.bootstrap4.min.css"">
  <link rel=""stylesheet"" href=""/admin/plugins/datatables-responsive/css/responsive.bootstrap4.min.css"">
  <link rel=""stylesheet"" href=""/admin/plugins/datatables-buttons/css/buttons.bootstrap4.min.css"">
  ");
#nullable restore
#line 21 "C:\Users\omerk\source\repos\EcommerceWebSite\EcommerceWebSite\Views\Shared\_layAdmin.cshtml"
Write(RenderSection("style",false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "21093d747626edab8c0f4c88e0ad860beb94d4006449", async() => {
                WriteLiteral(@"
    <div class=""wrapper"">
        <!-- Navbar -->
        <nav class=""main-header navbar navbar-expand navbar-white navbar-light"">
            <!-- Left navbar links -->
            <ul class=""navbar-nav"">
                <li class=""nav-item"">
                    <a class=""nav-link"" data-widget=""pushmenu"" href=""#"" role=""button""><i class=""fas fa-bars""></i></a>
                </li>
                <li class=""nav-item d-none d-sm-inline-block"">
                    <a href=""../../index3.html"" class=""nav-link"">Home</a>
                </li>
                <li class=""nav-item d-none d-sm-inline-block"">
                    <a href=""#"" class=""nav-link"">Contact</a>
                </li>
            </ul>

            <!-- Right navbar links -->
            <ul class=""navbar-nav ml-auto"">
                <!-- Navbar Search -->
                <li class=""nav-item"">
                    <a class=""nav-link"" data-widget=""navbar-search"" href=""#"" role=""button"">
                        <i class=""fas fa");
                WriteLiteral("-search\"></i>\r\n                    </a>\r\n                    <div class=\"navbar-search-block\">\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "21093d747626edab8c0f4c88e0ad860beb94d4007935", async() => {
                    WriteLiteral(@"
                            <div class=""input-group input-group-sm"">
                                <input class=""form-control form-control-navbar"" type=""search"" placeholder=""Search"" aria-label=""Search"">
                                <div class=""input-group-append"">
                                    <button class=""btn btn-navbar"" type=""submit"">
                                        <i class=""fas fa-search""></i>
                                    </button>
                                    <button class=""btn btn-navbar"" type=""button"" data-widget=""navbar-search"">
                                        <i class=""fas fa-times""></i>
                                    </button>
                                </div>
                            </div>
                        ");
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
                </li>

                <!-- Messages Dropdown Menu -->
                <li class=""nav-item dropdown"">
                    <a class=""nav-link"" data-toggle=""dropdown"" href=""#"">
                        <i class=""far fa-comments""></i>
                        <span class=""badge badge-danger navbar-badge"">3</span>
                    </a>
                    <div class=""dropdown-menu dropdown-menu-lg dropdown-menu-right"">
                        <a href=""#"" class=""dropdown-item"">
                            <!-- Message Start -->
                            <div class=""media"">
                                <img src=""/admin/dist/img/user1-128x128.jpg"" alt=""User Avatar"" class=""img-size-50 mr-3 img-circle"">
                                <div class=""media-body"">
                                    <h3 class=""dropdown-item-title"">
                                        Brad Diesel
                                        <span class=""float-right text-sm t");
                WriteLiteral(@"ext-danger""><i class=""fas fa-star""></i></span>
                                    </h3>
                                    <p class=""text-sm"">Call me whenever you can...</p>
                                    <p class=""text-sm text-muted""><i class=""far fa-clock mr-1""></i> 4 Hours Ago</p>
                                </div>
                            </div>
                            <!-- Message End -->
                        </a>
                        <div class=""dropdown-divider""></div>
                        <a href=""#"" class=""dropdown-item"">
                            <!-- Message Start -->
                            <div class=""media"">
                                <img src=""/admin/dist/img/user8-128x128.jpg"" alt=""User Avatar"" class=""img-size-50 img-circle mr-3"">
                                <div class=""media-body"">
                                    <h3 class=""dropdown-item-title"">
                                        John Pierce
                                   ");
                WriteLiteral(@"     <span class=""float-right text-sm text-muted""><i class=""fas fa-star""></i></span>
                                    </h3>
                                    <p class=""text-sm"">I got your message bro</p>
                                    <p class=""text-sm text-muted""><i class=""far fa-clock mr-1""></i> 4 Hours Ago</p>
                                </div>
                            </div>
                            <!-- Message End -->
                        </a>
                        <div class=""dropdown-divider""></div>
                        <a href=""#"" class=""dropdown-item"">
                            <!-- Message Start -->
                            <div class=""media"">
                                <img src=""/admin/dist/img/user3-128x128.jpg"" alt=""User Avatar"" class=""img-size-50 img-circle mr-3"">
                                <div class=""media-body"">
                                    <h3 class=""dropdown-item-title"">
                                        Nora Silvester");
                WriteLiteral(@"
                                        <span class=""float-right text-sm text-warning""><i class=""fas fa-star""></i></span>
                                    </h3>
                                    <p class=""text-sm"">The subject goes here</p>
                                    <p class=""text-sm text-muted""><i class=""far fa-clock mr-1""></i> 4 Hours Ago</p>
                                </div>
                            </div>
                            <!-- Message End -->
                        </a>
                        <div class=""dropdown-divider""></div>
                        <a href=""#"" class=""dropdown-item dropdown-footer"">See All Messages</a>
                    </div>
                </li>
                <!-- Notifications Dropdown Menu -->
                <li class=""nav-item dropdown"">
                    <a class=""nav-link"" data-toggle=""dropdown"" href=""#"">
                        <i class=""far fa-bell""></i>
                        <span class=""badge badge-warning navbar-");
                WriteLiteral(@"badge"">15</span>
                    </a>
                    <div class=""dropdown-menu dropdown-menu-lg dropdown-menu-right"">
                        <span class=""dropdown-item dropdown-header"">15 Notifications</span>
                        <div class=""dropdown-divider""></div>
                        <a href=""#"" class=""dropdown-item"">
                            <i class=""fas fa-envelope mr-2""></i> 4 new messages
                            <span class=""float-right text-muted text-sm"">3 mins</span>
                        </a>
                        <div class=""dropdown-divider""></div>
                        <a href=""#"" class=""dropdown-item"">
                            <i class=""fas fa-users mr-2""></i> 8 friend requests
                            <span class=""float-right text-muted text-sm"">12 hours</span>
                        </a>
                        <div class=""dropdown-divider""></div>
                        <a href=""#"" class=""dropdown-item"">
                            <i clas");
                WriteLiteral(@"s=""fas fa-file mr-2""></i> 3 new reports
                            <span class=""float-right text-muted text-sm"">2 days</span>
                        </a>
                        <div class=""dropdown-divider""></div>
                        <a href=""#"" class=""dropdown-item dropdown-footer"">See All Notifications</a>
                    </div>
                </li>
                <li class=""nav-item"">
                    <a class=""nav-link"" data-widget=""fullscreen"" href=""#"" role=""button"">
                        <i class=""fas fa-expand-arrows-alt""></i>
                    </a>
                </li>
                <li class=""nav-item"">
                    <a class=""nav-link"" data-widget=""control-sidebar"" data-slide=""true"" href=""#"" role=""button"">
                        <i class=""fas fa-th-large""></i>
                    </a>
                </li>
            </ul>
        </nav>
        <!-- /.navbar -->
        <!-- Main Sidebar Container -->
        <aside class=""main-sidebar sidebar-dar");
                WriteLiteral(@"k-primary elevation-4"">
            <!-- Brand Logo -->
            <a href=""index3.html"" class=""brand-link"">
                <img src=""/admin/dist/img/AdminLTELogo.png"" alt=""AdminLTE Logo"" class=""brand-image img-circle elevation-3"" style=""opacity: .8"">
                <span class=""brand-text font-weight-light"">MyEcommerce</span>
            </a>

            <!-- Sidebar -->
            <div class=""sidebar"">
                <!-- Sidebar user panel (optional) -->
                <div class=""user-panel mt-3 pb-3 mb-3 d-flex"">
                    <div class=""image"">
                        <img src=""/admin/dist/img/user2-160x160.jpg"" class=""img-circle elevation-2"" alt=""User Image"">
                    </div>
                    <div class=""info"">
                        <a href=""#"" class=""d-block"">Admin</a>
                    </div>
                </div>

                <!-- SidebarSearch Form -->
                <div class=""form-inline"">
                    <div class=""input-group"" data");
                WriteLiteral(@"-widget=""sidebar-search"">
                        <input class=""form-control form-control-sidebar"" type=""search"" placeholder=""Search"" aria-label=""Search"">
                        <div class=""input-group-append"">
                            <button class=""btn btn-sidebar"">
                                <i class=""fas fa-search fa-fw""></i>
                            </button>
                        </div>
                    </div>
                </div>

                <!-- Sidebar Menu -->
                <nav class=""mt-2"">
                    <ul class=""nav nav-pills nav-sidebar flex-column"" data-widget=""treeview"" role=""menu"" data-accordion=""false"">
                        <!-- Add icons to the links using the .nav-icon class
                             with font-awesome or any other icon font library -->
                        <li class=""nav-item menu-open"">
                            <a href=""/admin"" class=""nav-link active"">
                                <i class=""nav-icon fas fa-");
                WriteLiteral(@"tachometer-alt""></i>
                                <p>
                                    Dashboard
                                    <i class=""right fas fa-angle-left""></i>
                                </p>
                            </a>

                        </li>
                        <!--??R??NLER-->
                        <li class=""nav-item"">
                            <a href=""#"" class=""nav-link"">
                                <i class=""nav-icon fas fa-shirt""></i>
                                <p>
                                    ??r??nler
                                    <i class=""fas fa-angle-left right""></i>

                                </p>
                            </a>
                            <ul class=""nav nav-treeview"">
                                <li class=""nav-item"">
                                    <a href=""/admin/anaurun"" class=""nav-link"">
                                        <i class=""far fa-circle nav-icon""></i>
            ");
                WriteLiteral(@"                            <p>Ana ??r??n Listesi</p>
                                    </a>
                                </li>
                                <li class=""nav-item"">
                                    <a href=""/admin/urunler"" class=""nav-link"">
                                        <i class=""far fa-circle nav-icon""></i>
                                        <p>??r??n ??tem Listesi</p>
                                    </a>
                                </li>
                                <li class=""nav-item"">
                                    <a href=""pages/layout/top-nav-sidebar.html"" class=""nav-link"">
                                        <i class=""far fa-circle nav-icon""></i>
                                        <p>En ??ok Sat??lanlar</p>
                                    </a>
                                </li>



                            </ul>
                        </li>
                        <li class=""nav-item"">
                            ");
                WriteLiteral(@"<a href=""#"" class=""nav-link"">
                                <i class=""nav-icon fas fa-copy""></i>
                                <p>
                                    Sipari??ler
                                    <i class=""fas fa-angle-left right""></i>
                                    <span class=""badge badge-info right""></span>
                                </p>
                            </a>
                            <ul class=""nav nav-treeview"">
                                <li class=""nav-item"">
                                    <a href=""pages/layout/top-nav.html"" class=""nav-link"">
                                        <i class=""far fa-circle nav-icon""></i>
                                        <p>Top Navigation</p>
                                    </a>
                                </li>

                            </ul>
                        </li>
                        <li class=""nav-item"">
                            <a href=""#"" class=""nav-link"">
    ");
                WriteLiteral(@"                            <i class=""nav-icon fas fa-chart-pie""></i>
                                <p>
                                    M????teriler
                                    <i class=""right fas fa-angle-left""></i>
                                </p>
                            </a>
                            <ul class=""nav nav-treeview"">
                                <li class=""nav-item"">
                                    <a href=""pages/charts/chartjs.html"" class=""nav-link"">
                                        <i class=""far fa-circle nav-icon""></i>
                                        <p>ChartJS</p>
                                    </a>
                                </li>

                            </ul>
                        </li>
                        <li class=""nav-item"">
                            <a href=""#"" class=""nav-link"">
                                <i class=""nav-icon fas fa-tree""></i>
                                <p>
                ");
                WriteLiteral(@"                    ??statistikler
                                    <i class=""fas fa-angle-left right""></i>
                                </p>
                            </a>
                            <ul class=""nav nav-treeview"">
                                <li class=""nav-item"">
                                    <a href=""pages/UI/general.html"" class=""nav-link"">
                                        <i class=""far fa-circle nav-icon""></i>
                                        <p>General</p>
                                    </a>
                                </li>
                                <li class=""nav-item"">
                                    <a href=""pages/UI/icons.html"" class=""nav-link"">
                                        <i class=""far fa-circle nav-icon""></i>
                                        <p>Icons</p>
                                    </a>
                                </li>
                                <li class=""nav-item"">
            ");
                WriteLiteral(@"                        <a href=""pages/UI/buttons.html"" class=""nav-link"">
                                        <i class=""far fa-circle nav-icon""></i>
                                        <p>Buttons</p>
                                    </a>
                                </li>
                                <li class=""nav-item"">
                                    <a href=""pages/UI/sliders.html"" class=""nav-link"">
                                        <i class=""far fa-circle nav-icon""></i>
                                        <p>Sliders</p>
                                    </a>
                                </li>
                                <li class=""nav-item"">
                                    <a href=""pages/UI/modals.html"" class=""nav-link"">
                                        <i class=""far fa-circle nav-icon""></i>
                                        <p>Modals & Alerts</p>
                                    </a>
                                </li>
       ");
                WriteLiteral(@"                         <li class=""nav-item"">
                                    <a href=""pages/UI/navbar.html"" class=""nav-link"">
                                        <i class=""far fa-circle nav-icon""></i>
                                        <p>Navbar & Tabs</p>
                                    </a>
                                </li>
                                <li class=""nav-item"">
                                    <a href=""pages/UI/timeline.html"" class=""nav-link"">
                                        <i class=""far fa-circle nav-icon""></i>
                                        <p>Timeline</p>
                                    </a>
                                </li>
                                <li class=""nav-item"">
                                    <a href=""pages/UI/ribbons.html"" class=""nav-link"">
                                        <i class=""far fa-circle nav-icon""></i>
                                        <p>Ribbons</p>
                            ");
                WriteLiteral(@"        </a>
                                </li>
                            </ul>
                        </li>


                    </ul>
                </nav>
                <!-- /.sidebar-menu -->
            </div>
            <!-- /.sidebar -->
        </aside>

        <!-- Content Wrapper. Contains page content -->
        <div class=""content-wrapper"">
            <!-- Content Header (Page header) -->
            <section class=""content-header"">
                <div class=""container-fluid"">
                    <div class=""row mb-2"">
                        <div class=""col-sm-6"">
                            <h1>Simple Tables</h1>
                        </div>
                        <div class=""col-sm-6"">
                            <ol class=""breadcrumb float-sm-right"">
                                <li class=""breadcrumb-item""><a href=""#"">Home</a></li>
                                <li class=""breadcrumb-item active"">Simple Tables</li>
                            </o");
                WriteLiteral(@"l>
                        </div>
                    </div>
                </div><!-- /.container-fluid -->
            </section>

            <!-- Main content -->
            <section class=""content"">
                <div class=""container-fluid"">
                    ");
#nullable restore
#line 370 "C:\Users\omerk\source\repos\EcommerceWebSite\EcommerceWebSite\Views\Shared\_layAdmin.cshtml"
               Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                </div><!-- /.container-fluid -->
            </section>
            <!-- /.content -->
        </div>
        <!-- /.content-wrapper -->
        <footer class=""main-footer"">
            <div class=""float-right d-none d-sm-block"">
                <b>Version</b> 3.1.0
            </div>
            <strong>Copyright &copy; 2014-2021 <a href=""https://adminlte.io"">AdminLTE.io</a>.</strong> All rights reserved.
        </footer>

        <!-- Control Sidebar -->
        <aside class=""control-sidebar control-sidebar-dark"">
            <!-- Control sidebar content goes here -->
        </aside>
        <!-- /.control-sidebar -->
    </div>
    <!-- ./wrapper -->
    

    <!-- jQuery -->
    <script src=""/admin/plugins/jquery/jquery.min.js""></script>
    <!-- Bootstrap 4 -->
    <script src=""/admin/plugins/bootstrap/js/bootstrap.bundle.min.js""></script>

    <!--DATA TABLE SCRIPTTT-->
    <script src=""/admin/plugins/datatables/jquery.dataTables.min.js""></script>
<script ");
                WriteLiteral(@"src=""/admin/plugins/datatables-bs4/js/dataTables.bootstrap4.min.js""></script>
<script src=""/admin/plugins/datatables-responsive/js/dataTables.responsive.min.js""></script>
<script src=""/admin/plugins/datatables-responsive/js/responsive.bootstrap4.min.js""></script>
<script src=""/admin/plugins/datatables-buttons/js/dataTables.buttons.min.js""></script>
<script src=""/admin/plugins/datatables-buttons/js/buttons.bootstrap4.min.js""></script>
<script src=""/admin/plugins/jszip/jszip.min.js""></script>
<script src=""/admin/plugins/pdfmake/pdfmake.min.js""></script>
<script src=""/admin/plugins/pdfmake/vfs_fonts.js""></script>
<script src=""/admin/plugins/datatables-buttons/js/buttons.html5.min.js""></script>
<script src=""/admin/plugins/datatables-buttons/js/buttons.print.min.js""></script>
<script src=""/admin/plugins/datatables-buttons/js/buttons.colVis.min.js""></script>
    <!--DATA TABLE SCRIPTTT-->




    <!-- AdminLTE App -->
    <script src=""/admin/dist/js/adminlte.min.js""></script>
    <!-- AdminLTE for");
                WriteLiteral(" demo purposes -->\r\n    <script src=\"/admin/dist/js/demo.js\"></script>\r\n    ");
#nullable restore
#line 419 "C:\Users\omerk\source\repos\EcommerceWebSite\EcommerceWebSite\Views\Shared\_layAdmin.cshtml"
Write(RenderSection("script",false));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
    <script>
         $(function () {
    $(""#example1"").DataTable({
      ""responsive"": true, ""lengthChange"": false, ""autoWidth"": false,
      ""buttons"": [""copy"", ""csv"", ""excel"", ""pdf"", ""print"", ""colvis""]
    }).buttons().container().appendTo('#example1_wrapper .col-md-6:eq(0)');
    $('#example2').DataTable({
      ""paging"": true,
      ""lengthChange"": false,
      ""searching"": false,
      ""ordering"": true,
      ""info"": true,
      ""autoWidth"": false,
      ""responsive"": true,
    });
  });
    </script>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
