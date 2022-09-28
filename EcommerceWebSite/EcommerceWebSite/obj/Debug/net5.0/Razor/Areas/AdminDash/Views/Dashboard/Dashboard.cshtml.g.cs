#pragma checksum "C:\Users\omerk\source\repos\EcommerceWebSite\EcommerceWebSite\Areas\AdminDash\Views\Dashboard\Dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "27e6df78e86fb57a9e307f1e512b957c6889c4ff"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_AdminDash_Views_Dashboard_Dashboard), @"mvc.1.0.view", @"/Areas/AdminDash/Views/Dashboard/Dashboard.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"27e6df78e86fb57a9e307f1e512b957c6889c4ff", @"/Areas/AdminDash/Views/Dashboard/Dashboard.cshtml")]
    #nullable restore
    public class Areas_AdminDash_Views_Dashboard_Dashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\omerk\source\repos\EcommerceWebSite\EcommerceWebSite\Areas\AdminDash\Views\Dashboard\Dashboard.cshtml"
  
    ViewData["Title"] = "Dashboard";
    Layout = "~/Views/Shared/_layAdmin.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<!--Toplam Musteri Toplam ürün vs-->\r\n<div class=\"row\">\r\n    <div class=\"col-lg-3 col-6\">\r\n        <!-- small box -->\r\n        <div class=\"small-box bg-info\">\r\n            <div class=\"inner\">\r\n                <h3>");
#nullable restore
#line 11 "C:\Users\omerk\source\repos\EcommerceWebSite\EcommerceWebSite\Areas\AdminDash\Views\Dashboard\Dashboard.cshtml"
               Write(ViewBag.toplamMusteri);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>

                <p>Toplam Ürün</p>
            </div>
            <div class=""icon"">
                <i class=""ion ion-bag""></i>
            </div>
            <a href=""#"" class=""small-box-footer"">Daha Fazla <i class=""fas fa-arrow-circle-right""></i></a>
        </div>
    </div>
    <!-- ./col -->
    <div class=""col-lg-3 col-6"">
        <!-- small box -->
        <div class=""small-box bg-success"">
            <div class=""inner"">
                <h3>");
#nullable restore
#line 26 "C:\Users\omerk\source\repos\EcommerceWebSite\EcommerceWebSite\Areas\AdminDash\Views\Dashboard\Dashboard.cshtml"
               Write(ViewBag.toplamKullanici);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<sup style=""font-size: 20px""></sup></h3>

                <p>Üye</p>
            </div>
            <div class=""icon"">
                <i class=""ion ion-stats-bars""></i>
            </div>
            <a href=""#"" class=""small-box-footer"">More info <i class=""fas fa-arrow-circle-right""></i></a>
        </div>
    </div>
    <!-- ./col -->
    <div class=""col-lg-3 col-6"">
        <!-- small box -->
        <div class=""small-box bg-warning"">
            <div class=""inner"">
                <h3>");
#nullable restore
#line 41 "C:\Users\omerk\source\repos\EcommerceWebSite\EcommerceWebSite\Areas\AdminDash\Views\Dashboard\Dashboard.cshtml"
               Write(ViewBag.bugunMusteri);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>

                <p>Bugünkü Üyeler</p>
            </div>
            <div class=""icon"">
                <i class=""ion ion-person-add""></i>
            </div>
            <a href=""#"" class=""small-box-footer"">More info <i class=""fas fa-arrow-circle-right""></i></a>
        </div>
    </div>
    <!-- ./col -->
    <div class=""col-lg-3 col-6"">
        <!-- small box -->
        <div class=""small-box bg-danger"">
            <div class=""inner"">
                <h3>");
#nullable restore
#line 56 "C:\Users\omerk\source\repos\EcommerceWebSite\EcommerceWebSite\Areas\AdminDash\Views\Dashboard\Dashboard.cshtml"
               Write(ViewBag.online);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>

                <p>Online Üyeler</p>
            </div>
            <div class=""icon"">
                <i class=""ion ion-pie-graph""></i>
            </div>
            <a href=""#"" class=""small-box-footer"">More info <i class=""fas fa-arrow-circle-right""></i></a>
        </div>
    </div>

    <!-- ./col -->
</div>

<!--Toplam Musteri Toplam ürün vs END-->




 <div class=""row"">
          <!-- Left col -->
          <section class=""col-lg-7 connectedSortable"">
            <!-- Custom tabs (Charts with tabs)-->
            <div class=""card"">
              <div class=""card-header"">
                <h3 class=""card-title"">
                  <i class=""fas fa-chart-pie mr-1""></i>
                  Satışlar
                </h3>
                <div class=""card-tools"">
                  <ul class=""nav nav-pills ml-auto"">
                    <li class=""nav-item"">
                      <a class=""nav-link active"" href=""#revenue-chart"" data-toggle=""tab"">Area</a>
                    <");
            WriteLiteral(@"/li>
                    <li class=""nav-item"">
                      <a class=""nav-link"" href=""#sales-chart"" data-toggle=""tab"">Donut</a>
                    </li>
                  </ul>
                </div>
              </div><!-- /.card-header -->
              <div class=""card-body"">
                <div class=""tab-content p-0"">
                  <!-- Morris chart - Sales -->
                  <div class=""chart tab-pane active"" id=""revenue-chart""
                       style=""position: relative; height: 300px;"">
                      <canvas id=""revenue-chart-canvas"" height=""300"" style=""height: 300px;""></canvas>
                   </div>
                  <div class=""chart tab-pane"" id=""sales-chart"" style=""position: relative; height: 300px;"">
                    <canvas id=""sales-chart-canvas"" height=""300"" style=""height: 300px;""></canvas>
                  </div>
                </div>
              </div><!-- /.card-body -->
            </div>
            <!-- /.card -->

        ");
            WriteLiteral(@"   
           

            <!-- TO DO List -->
            <div class=""card"">
              <div class=""card-header"">
                <h3 class=""card-title"">
                  <i class=""ion ion-clipboard mr-1""></i>
                  To Do List
                </h3>

                <div class=""card-tools"">
                  <ul class=""pagination pagination-sm"">
                    <li class=""page-item""><a href=""#"" class=""page-link"">&laquo;</a></li>
                    <li class=""page-item""><a href=""#"" class=""page-link"">1</a></li>
                    <li class=""page-item""><a href=""#"" class=""page-link"">2</a></li>
                    <li class=""page-item""><a href=""#"" class=""page-link"">3</a></li>
                    <li class=""page-item""><a href=""#"" class=""page-link"">&raquo;</a></li>
                  </ul>
                </div>
              </div>
              <!-- /.card-header -->
              <div class=""card-body"">
                <ul class=""todo-list"" data-widget=""todo-list"">
 ");
            WriteLiteral(@"                 <li>
                    <!-- drag handle -->
                    <span class=""handle"">
                      <i class=""fas fa-ellipsis-v""></i>
                      <i class=""fas fa-ellipsis-v""></i>
                    </span>
                    <!-- checkbox -->
                    <div  class=""icheck-primary d-inline ml-2"">
                      <input type=""checkbox""");
            BeginWriteAttribute("value", " value=\"", 5329, "\"", 5337, 0);
            EndWriteAttribute();
            WriteLiteral(@" name=""todo1"" id=""todoCheck1"">
                      <label for=""todoCheck1""></label>
                    </div>
                    <!-- todo text -->
                    <span class=""text"">Design a nice theme</span>
                    <!-- Emphasis label -->
                    <small class=""badge badge-danger""><i class=""far fa-clock""></i> 2 mins</small>
                    <!-- General tools such as edit or delete-->
                    <div class=""tools"">
                      <i class=""fas fa-edit""></i>
                      <i class=""fas fa-trash-o""></i>
                    </div>
                  </li>
                  <li>
                    <span class=""handle"">
                      <i class=""fas fa-ellipsis-v""></i>
                      <i class=""fas fa-ellipsis-v""></i>
                    </span>
                    <div  class=""icheck-primary d-inline ml-2"">
                      <input type=""checkbox""");
            BeginWriteAttribute("value", " value=\"", 6289, "\"", 6297, 0);
            EndWriteAttribute();
            WriteLiteral(@" name=""todo2"" id=""todoCheck2"" checked>
                      <label for=""todoCheck2""></label>
                    </div>
                    <span class=""text"">Make the theme responsive</span>
                    <small class=""badge badge-info""><i class=""far fa-clock""></i> 4 hours</small>
                    <div class=""tools"">
                      <i class=""fas fa-edit""></i>
                      <i class=""fas fa-trash-o""></i>
                    </div>
                  </li>
                  <li>
                    <span class=""handle"">
                      <i class=""fas fa-ellipsis-v""></i>
                      <i class=""fas fa-ellipsis-v""></i>
                    </span>
                    <div  class=""icheck-primary d-inline ml-2"">
                      <input type=""checkbox""");
            BeginWriteAttribute("value", " value=\"", 7111, "\"", 7119, 0);
            EndWriteAttribute();
            WriteLiteral(@" name=""todo3"" id=""todoCheck3"">
                      <label for=""todoCheck3""></label>
                    </div>
                    <span class=""text"">Let theme shine like a star</span>
                    <small class=""badge badge-warning""><i class=""far fa-clock""></i> 1 day</small>
                    <div class=""tools"">
                      <i class=""fas fa-edit""></i>
                      <i class=""fas fa-trash-o""></i>
                    </div>
                  </li>
                  <li>
                    <span class=""handle"">
                      <i class=""fas fa-ellipsis-v""></i>
                      <i class=""fas fa-ellipsis-v""></i>
                    </span>
                    <div  class=""icheck-primary d-inline ml-2"">
                      <input type=""checkbox""");
            BeginWriteAttribute("value", " value=\"", 7928, "\"", 7936, 0);
            EndWriteAttribute();
            WriteLiteral(@" name=""todo4"" id=""todoCheck4"">
                      <label for=""todoCheck4""></label>
                    </div>
                    <span class=""text"">Let theme shine like a star</span>
                    <small class=""badge badge-success""><i class=""far fa-clock""></i> 3 days</small>
                    <div class=""tools"">
                      <i class=""fas fa-edit""></i>
                      <i class=""fas fa-trash-o""></i>
                    </div>
                  </li>
                  <li>
                    <span class=""handle"">
                      <i class=""fas fa-ellipsis-v""></i>
                      <i class=""fas fa-ellipsis-v""></i>
                    </span>
                    <div  class=""icheck-primary d-inline ml-2"">
                      <input type=""checkbox""");
            BeginWriteAttribute("value", " value=\"", 8746, "\"", 8754, 0);
            EndWriteAttribute();
            WriteLiteral(@" name=""todo5"" id=""todoCheck5"">
                      <label for=""todoCheck5""></label>
                    </div>
                    <span class=""text"">Check your messages and notifications</span>
                    <small class=""badge badge-primary""><i class=""far fa-clock""></i> 1 week</small>
                    <div class=""tools"">
                      <i class=""fas fa-edit""></i>
                      <i class=""fas fa-trash-o""></i>
                    </div>
                  </li>
                  <li>
                    <span class=""handle"">
                      <i class=""fas fa-ellipsis-v""></i>
                      <i class=""fas fa-ellipsis-v""></i>
                    </span>
                    <div  class=""icheck-primary d-inline ml-2"">
                      <input type=""checkbox""");
            BeginWriteAttribute("value", " value=\"", 9574, "\"", 9582, 0);
            EndWriteAttribute();
            WriteLiteral(@" name=""todo6"" id=""todoCheck6"">
                      <label for=""todoCheck6""></label>
                    </div>
                    <span class=""text"">Let theme shine like a star</span>
                    <small class=""badge badge-secondary""><i class=""far fa-clock""></i> 1 month</small>
                    <div class=""tools"">
                      <i class=""fas fa-edit""></i>
                      <i class=""fas fa-trash-o""></i>
                    </div>
                  </li>
                </ul>
              </div>
              <!-- /.card-body -->
              <div class=""card-footer clearfix"">
                <button type=""button"" class=""btn btn-primary float-right""><i class=""fas fa-plus""></i> Add item</button>
              </div>
            </div>
            <!-- TO DO List end -->
          </section>
          <!-- /.Left col -->
          <!-- right col (We are only adding the ID to make the widgets sortable)-->
          <section class=""col-lg-5 connectedSortable"">

   ");
            WriteLiteral(@"         <!-- Map card -->
            <div class=""card bg-gradient-primary"">
              <div class=""card-header border-0"">
                <h3 class=""card-title"">
                  <i class=""fas fa-map-marker-alt mr-1""></i>
                  Visitors
                </h3>
                <!-- card tools -->
                 <div class=""card-tools"">
                  <button type=""button"" class=""btn btn-primary btn-sm daterange"" title=""Date range"">
                    <i class=""far fa-calendar-alt""></i>
                  </button>
                  <button type=""button"" class=""btn btn-primary btn-sm"" data-card-widget=""collapse"" title=""Collapse"">
                    <i class=""fas fa-minus""></i>
                  </button>
                </div>
                <!-- /.card-tools -->
              </div>
              <div class=""card-body"">
                <div id=""world-map"" style=""height: 250px; width: 100%;""></div>
              </div>
              <!-- /.card-body-->
              ");
            WriteLiteral(@"<div class=""card-footer bg-transparent"">
                <div class=""row"">
                  <div class=""col-4 text-center"">
                    <div id=""sparkline-1""></div>
                    <div class=""text-white"">Visitors</div>
                  </div>
                  <!-- ./col -->
                  <div class=""col-4 text-center"">
                    <div id=""sparkline-2""></div>
                    <div class=""text-white"">Online</div>
                  </div>
                  <!-- ./col -->
                  <div class=""col-4 text-center"">
                    <div id=""sparkline-3""></div>
                    <div class=""text-white"">Sales</div>
                  </div>
                  <!-- ./col -->
                </div>
                <!-- /.row -->
              </div>
            </div>
            <!-- /.card -->

          

            <!-- Calendar -->
            <div class=""card bg-gradient-success"">
              <div class=""card-header border-0"">

           ");
            WriteLiteral(@"     <h3 class=""card-title"">
                  <i class=""far fa-calendar-alt""></i>
                  Calendar
                </h3>
                <!-- tools card -->
                <div class=""card-tools"">
                  <!-- button with a dropdown -->
                  <div class=""btn-group"">
                    <button type=""button"" class=""btn btn-success btn-sm dropdown-toggle"" data-toggle=""dropdown"" data-offset=""-52"">
                      <i class=""fas fa-bars""></i>
                    </button>
                    <div class=""dropdown-menu"" role=""menu"">
                      <a href=""#"" class=""dropdown-item"">Add new event</a>
                      <a href=""#"" class=""dropdown-item"">Clear events</a>
                      <div class=""dropdown-divider""></div>
                      <a href=""#"" class=""dropdown-item"">View calendar</a>
                    </div>
                  </div>
                  <button type=""button"" class=""btn btn-success btn-sm"" data-card-widget=""collapse"">
 ");
            WriteLiteral(@"                   <i class=""fas fa-minus""></i>
                  </button>
                  <button type=""button"" class=""btn btn-success btn-sm"" data-card-widget=""remove"">
                    <i class=""fas fa-times""></i>
                  </button>
                </div>
                <!-- /. tools -->
              </div>
              <!-- /.card-header -->
              <div class=""card-body pt-0"">
                <!--The calendar -->
                <div id=""calendar"" style=""width: 100%""></div>
              </div>
              <!-- /.card-body -->
            </div>
            <!-- /Calendar end -->
          </section>
          <!-- right col -->
        </div>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591