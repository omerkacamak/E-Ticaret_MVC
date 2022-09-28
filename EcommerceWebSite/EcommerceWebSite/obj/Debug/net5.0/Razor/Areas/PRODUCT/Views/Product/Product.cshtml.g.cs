#pragma checksum "C:\Users\omerk\source\repos\EcommerceWebSite\EcommerceWebSite\Areas\PRODUCT\Views\Product\Product.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3230aec16130d3f9906f4de8ebd8d91b80476bc8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_PRODUCT_Views_Product_Product), @"mvc.1.0.view", @"/Areas/PRODUCT/Views/Product/Product.cshtml")]
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
#line 1 "C:\Users\omerk\source\repos\EcommerceWebSite\EcommerceWebSite\Areas\PRODUCT\Views\Product\Product.cshtml"
using Data.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3230aec16130d3f9906f4de8ebd8d91b80476bc8", @"/Areas/PRODUCT/Views/Product/Product.cshtml")]
    #nullable restore
    public class Areas_PRODUCT_Views_Product_Product : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Product>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\omerk\source\repos\EcommerceWebSite\EcommerceWebSite\Areas\PRODUCT\Views\Product\Product.cshtml"
  
    ViewData["Title"] = "Product";
    Layout = "~/Views/Shared/_AnaLayout.cshtml";
   

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- Shop Details Section Begin -->
<section class=""shop-details"">
    <div class=""product__details__pic"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-12"">
                    <div class=""product__details__breadcrumb"">
                        <a href=""./index.html"">Home</a>
                        <a href=""./shop.html"">Shop</a>
                        <span>Ürün Detayları</span>


                    </div>
                </div>
            </div>
            <div class=""row"">
                <div class=""col-lg-3 col-md-3"">
                    <ul class=""nav nav-tabs"" role=""tablist"">
                        <li class=""nav-item"">
                            <a class=""nav-link active"" data-toggle=""tab"" href=""#tabs-1"" role=""tab"">
                                <div class=""product__thumb__pic set-bg"" data-setbg=""/img/shop-details/thumb-1.png"">
                                </div>
                            </a>
                    ");
            WriteLiteral(@"    </li>
                        <li class=""nav-item"">
                            <a class=""nav-link"" data-toggle=""tab"" href=""#tabs-2"" role=""tab"">
                                <div class=""product__thumb__pic set-bg"" data-setbg=""/img/shop-details/thumb-2.png"">
                                </div>
                            </a>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link"" data-toggle=""tab"" href=""#tabs-3"" role=""tab"">
                                <div class=""product__thumb__pic set-bg"" data-setbg=""/img/shop-details/thumb-3.png"">
                                </div>
                            </a>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link"" data-toggle=""tab"" href=""#tabs-4"" role=""tab"">
                                <div class=""product__thumb__pic set-bg"" data-setbg=""/img/shop-details/thumb-4.png"">
                             ");
            WriteLiteral(@"       <i class=""fa fa-play""></i>
                                </div>
                            </a>
                        </li>
                    </ul>
                </div>
                <div class=""col-lg-6 col-md-9"">
                    <div class=""tab-content"">
                        <div class=""tab-pane active"" id=""tabs-1"" role=""tabpanel"">
                            <div class=""product__details__pic__item"">
                                <img src=""/img/shop-details/product-big-2.png""");
            BeginWriteAttribute("alt", " alt=\"", 2701, "\"", 2707, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            </div>
                        </div>
                        <div class=""tab-pane"" id=""tabs-2"" role=""tabpanel"">
                            <div class=""product__details__pic__item"">
                                <img src=""/img/shop-details/product-big-3.png""");
            BeginWriteAttribute("alt", " alt=\"", 3004, "\"", 3010, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            </div>
                        </div>
                        <div class=""tab-pane"" id=""tabs-3"" role=""tabpanel"">
                            <div class=""product__details__pic__item"">
                                <img src=""/img/shop-details/product-big.png""");
            BeginWriteAttribute("alt", " alt=\"", 3305, "\"", 3311, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            </div>
                        </div>
                        <div class=""tab-pane"" id=""tabs-4"" role=""tabpanel"">
                            <div class=""product__details__pic__item"">
                                <img src=""/img/shop-details/product-big-4.png""");
            BeginWriteAttribute("alt", " alt=\"", 3608, "\"", 3614, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                <a href=""https://www.youtube.com/watch?v=8PJ3_p7VqHw&list=RD8PJ3_p7VqHw&start_radio=1"" class=""video-popup""><i class=""fa fa-play""></i></a>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class=""product__details__content"">
        <div class=""container"">
            <div class=""row d-flex justify-content-center"">
                <div class=""col-lg-8"">
                    <div class=""product__details__text"">
                        <h4>");
#nullable restore
#line 87 "C:\Users\omerk\source\repos\EcommerceWebSite\EcommerceWebSite\Areas\PRODUCT\Views\Product\Product.cshtml"
                       Write(Model.ProductName.ToUpper());

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h4>
                        <div class=""rating"">
                            <i class=""fa fa-star""></i>
                            <i class=""fa fa-star""></i>
                            <i class=""fa fa-star""></i>
                            <i class=""fa fa-star""></i>
                            <i class=""fa fa-star-o""></i>
                            <span> - 5 Reviews</span>
                        </div>
                        <!--Bu view component sizea tıklayarak fiyatın güncellenmesini sağlar!!!!! -->
                        <span id=""pricespan"">");
#nullable restore
#line 97 "C:\Users\omerk\source\repos\EcommerceWebSite\EcommerceWebSite\Areas\PRODUCT\Views\Product\Product.cshtml"
                                        Write(await Component.InvokeAsync("sizeColorPrice",@Model.ProductItems[0].ProductItemID));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>

                        <div class=""product__details__cart__option"">
                            <div class=""quantity"">
                                <div class=""pro-qty"">
                                    <input id=""adet""  type=""text"" value=""1"">
                                </div>
                            </div>
                            <button onclick=""postEt()"" class=""primary-btn"">Sepete Ekle</button>
                        </div>


                        <p>
                            ");
#nullable restore
#line 110 "C:\Users\omerk\source\repos\EcommerceWebSite\EcommerceWebSite\Areas\PRODUCT\Views\Product\Product.cshtml"
                       Write(Model.subDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </p>\r\n                        <div class=\"product__details__option\">\r\n                            <div class=\"product__details__option__size\">\r\n                                <span>Size:</span>\r\n");
#nullable restore
#line 115 "C:\Users\omerk\source\repos\EcommerceWebSite\EcommerceWebSite\Areas\PRODUCT\Views\Product\Product.cshtml"
                                 foreach (var item in Model.ProductItems)
                                {


#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <label");
            BeginWriteAttribute("for", " for=\"", 5833, "\"", 5849, 1);
#nullable restore
#line 118 "C:\Users\omerk\source\repos\EcommerceWebSite\EcommerceWebSite\Areas\PRODUCT\Views\Product\Product.cshtml"
WriteAttributeValue("", 5839, item.Size, 5839, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                        ");
#nullable restore
#line 119 "C:\Users\omerk\source\repos\EcommerceWebSite\EcommerceWebSite\Areas\PRODUCT\Views\Product\Product.cshtml"
                                   Write(item.Size);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        <input");
            BeginWriteAttribute("onclick", " onclick=\"", 5951, "\"", 6024, 5);
            WriteAttributeValue("", 5961, "changePrice(", 5961, 12, true);
#nullable restore
#line 120 "C:\Users\omerk\source\repos\EcommerceWebSite\EcommerceWebSite\Areas\PRODUCT\Views\Product\Product.cshtml"
WriteAttributeValue("", 5973, item.ProductItemID, 5973, 19, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5992, "),itemDeger(", 5992, 12, true);
#nullable restore
#line 120 "C:\Users\omerk\source\repos\EcommerceWebSite\EcommerceWebSite\Areas\PRODUCT\Views\Product\Product.cshtml"
WriteAttributeValue("", 6004, item.ProductItemID, 6004, 19, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 6023, ")", 6023, 1, true);
            EndWriteAttribute();
            WriteLiteral(" type=\"radio\"");
            BeginWriteAttribute("id", " id=\"", 6038, "\"", 6053, 1);
#nullable restore
#line 120 "C:\Users\omerk\source\repos\EcommerceWebSite\EcommerceWebSite\Areas\PRODUCT\Views\Product\Product.cshtml"
WriteAttributeValue("", 6043, item.Size, 6043, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    </label>\r\n");
#nullable restore
#line 122 "C:\Users\omerk\source\repos\EcommerceWebSite\EcommerceWebSite\Areas\PRODUCT\Views\Product\Product.cshtml"

                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </div>
                            <div class=""product__details__option__color"">
                                <span>Color:</span>
                                <label class=""c-1"" for=""sp-1"">
                                    <input type=""radio"" id=""sp-1"">
                                </label>
                                <label class=""c-2"" for=""sp-2"">
                                    <input type=""radio"" id=""sp-2"">
                                </label>
                                <label class=""c-3"" for=""sp-3"">
                                    <input type=""radio"" id=""sp-3"">
                                </label>
                                <label class=""c-4"" for=""sp-4"">
                                    <input type=""radio"" id=""sp-4"">
                                </label>
                                <label class=""c-9"" for=""sp-9"">
                                    <input type=""radio"" id=""sp-9"">
                              ");
            WriteLiteral(@"  </label>
                            </div>
                        </div>



                        <div class=""product__details__btns__option"">
                            <a href=""#""><i class=""fa fa-heart""></i>Favorilere Ekle</a>
                            <a href=""#""><i class=""fa fa-exchange""></i> Karşılaştır</a>
                        </div>
                        <div class=""product__details__last__option"">
                            <h5><span>Güvenli Ödeme</span></h5>
                            <img src=""img/shop-details/details-payment.png""");
            BeginWriteAttribute("alt", " alt=\"", 7738, "\"", 7744, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <ul>\r\n                                <li><span>Stok Kodu:</span> ");
#nullable restore
#line 156 "C:\Users\omerk\source\repos\EcommerceWebSite\EcommerceWebSite\Areas\PRODUCT\Views\Product\Product.cshtml"
                                                       Write(Model.StokKodu);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                                <li><span>Kategori:</span> ");
#nullable restore
#line 157 "C:\Users\omerk\source\repos\EcommerceWebSite\EcommerceWebSite\Areas\PRODUCT\Views\Product\Product.cshtml"
                                                      Write(Model.Category.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</li>

                            </ul>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""row"">
                <div class=""col-lg-12"">
                    <div class=""product__details__tab"">
                        <ul class=""nav nav-tabs"" role=""tablist"">
                            <li class=""nav-item"">
                                <a class=""nav-link active"" data-toggle=""tab"" href=""#tabs-5""
                                   role=""tab"">Açıklama</a>
                            </li>
                            <li class=""nav-item"">
                                <a class=""nav-link"" data-toggle=""tab"" href=""#tabs-6"" role=""tab"">
                                    Yorumlar
                                </a>
                            </li>

                        </ul>
                        <div class=""tab-content"">
                            <div class=""tab-pane active"" id=""tabs-5"" role=""tabpanel"">
   ");
            WriteLiteral("                             <div class=\"product__details__tab__content\">\r\n                                    <p class=\"note\">\r\n                                        ");
#nullable restore
#line 183 "C:\Users\omerk\source\repos\EcommerceWebSite\EcommerceWebSite\Areas\PRODUCT\Views\Product\Product.cshtml"
                                   Write(Model.ProductDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                    </p>

                                </div>
                            </div>
                            <div class=""tab-pane"" id=""tabs-6"" role=""tabpanel"">
                                <div class=""product__details__tab__content"">
                                    <div class=""product__details__tab__content__item"">
                                        <h5>Products Infomation</h5>
                                        <p>
                                            A Pocket PC is a handheld computer, which features many of the same
                                            capabilities as a modern PC. These handy little devices allow
                                            individuals to retrieve and store e-mail messages, create a contact
                                            file, coordinate appointments, surf the internet, exchange text messages
                                            and more. Every product that is labeled as a P");
            WriteLiteral(@"ocket PC must be
                                            accompanied with specific software to operate the unit and must feature
                                            a touchscreen and touchpad.
                                        </p>
                                        <p>
                                            As is the case with any new technology product, the cost of a Pocket PC
                                            was substantial during it’s early release. For approximately $700.00,
                                            consumers could purchase one of top-of-the-line Pocket PCs in 2003.
                                            These days, customers are finding that prices have become much more
                                            reasonable now that the newness is wearing off. For approximately
                                            $350.00, a new Pocket PC can now be purchased.
                                        </p>
                  ");
            WriteLiteral(@"                  </div>
                                    <div class=""product__details__tab__content__item"">
                                        <h5>Material used</h5>
                                        <p>
                                            Polyester is deemed lower quality due to its none natural quality’s. Made
                                            from synthetic materials, not natural like wool. Polyester suits become
                                            creased easily and are known for not being breathable. Polyester suits
                                            tend to have a shine to them compared to wool and cotton suits, this can
                                            make the suit look cheap. The texture of velvet is luxurious and
                                            breathable. Velvet is a great choice for dinner party jacket and can be
                                            worn all year round.
                                      ");
            WriteLiteral(@"  </p>
                                    </div>
                                </div>
                            </div>
                            <div class=""tab-pane"" id=""tabs-7"" role=""tabpanel"">
                                <div class=""product__details__tab__content"">
                                    <p class=""note"">
                                        Nam tempus turpis at metus scelerisque placerat nulla deumantos
                                        solicitud felis. Pellentesque diam dolor, elementum etos lobortis des mollis
                                        ut risus. Sedcus faucibus an sullamcorper mattis drostique des commodo
                                        pharetras loremos.
                                    </p>
                                    <div class=""product__details__tab__content__item"">
                                        <h5>Products Infomation</h5>
                                        <p>
                                            ");
            WriteLiteral(@"A Pocket PC is a handheld computer, which features many of the same
                                            capabilities as a modern PC. These handy little devices allow
                                            individuals to retrieve and store e-mail messages, create a contact
                                            file, coordinate appointments, surf the internet, exchange text messages
                                            and more. Every product that is labeled as a Pocket PC must be
                                            accompanied with specific software to operate the unit and must feature
                                            a touchscreen and touchpad.
                                        </p>
                                        <p>
                                            As is the case with any new technology product, the cost of a Pocket PC
                                            was substantial during it’s early release. For approximately $700.0");
            WriteLiteral(@"0,
                                            consumers could purchase one of top-of-the-line Pocket PCs in 2003.
                                            These days, customers are finding that prices have become much more
                                            reasonable now that the newness is wearing off. For approximately
                                            $350.00, a new Pocket PC can now be purchased.
                                        </p>
                                    </div>
                                    <div class=""product__details__tab__content__item"">
                                        <h5>Material used</h5>
                                        <p>
                                            Polyester is deemed lower quality due to its none natural quality’s. Made
                                            from synthetic materials, not natural like wool. Polyester suits become
                                            creased easily and are k");
            WriteLiteral(@"nown for not being breathable. Polyester suits
                                            tend to have a shine to them compared to wool and cotton suits, this can
                                            make the suit look cheap. The texture of velvet is luxurious and
                                            breathable. Velvet is a great choice for dinner party jacket and can be
                                            worn all year round.
                                        </p>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    
</section>
<!-- Shop Details Section End -->
<!-- Related Section Begin -->
<section class=""related spad"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-12"">
                <h3 class=""related-title"">Related Product");
            WriteLiteral(@"</h3>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-lg-3 col-md-6 col-sm-6 col-sm-6"">
                <div class=""product__item"">
                    <div class=""product__item__pic set-bg"" data-setbg=""/img/product/product-1.jpg"">
                        <span class=""label"">New</span>
                        <ul class=""product__hover"">
                            <li><a href=""#""><img src=""/img/icon/heart.png""");
            BeginWriteAttribute("alt", " alt=\"", 16799, "\"", 16805, 0);
            EndWriteAttribute();
            WriteLiteral("></a></li>\r\n                            <li><a href=\"#\"><img src=\"/img/icon/compare.png\"");
            BeginWriteAttribute("alt", " alt=\"", 16894, "\"", 16900, 0);
            EndWriteAttribute();
            WriteLiteral("> <span>Compare</span></a></li>\r\n                            <li><a href=\"#\"><img src=\"/img/icon/search.png\"");
            BeginWriteAttribute("alt", " alt=\"", 17009, "\"", 17015, 0);
            EndWriteAttribute();
            WriteLiteral(@"></a></li>
                        </ul>
                    </div>
                    <div class=""product__item__text"">
                        <h6>Piqué Biker Jacket</h6>
                        <a href=""#"" class=""add-cart"">+ Add To Cart</a>
                        <div class=""rating"">
                            <i class=""fa fa-star-o""></i>
                            <i class=""fa fa-star-o""></i>
                            <i class=""fa fa-star-o""></i>
                            <i class=""fa fa-star-o""></i>
                            <i class=""fa fa-star-o""></i>
                        </div>
                        <h5>$67.24</h5>
                        <div class=""product__color__select"">
                            <label for=""pc-1"">
                                <input type=""radio"" id=""pc-1"">
                            </label>
                            <label class=""active black"" for=""pc-2"">
                                <input type=""radio"" id=""pc-2"">
                   ");
            WriteLiteral(@"         </label>
                            <label class=""grey"" for=""pc-3"">
                                <input type=""radio"" id=""pc-3"">
                            </label>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-lg-3 col-md-6 col-sm-6 col-sm-6"">
                <div class=""product__item"">
                    <div class=""product__item__pic set-bg"" data-setbg=""/img/product/product-2.jpg"">
                        <ul class=""product__hover"">
                            <li><a href=""#""><img src=""/img/icon/heart.png""");
            BeginWriteAttribute("alt", " alt=\"", 18662, "\"", 18668, 0);
            EndWriteAttribute();
            WriteLiteral("></a></li>\r\n                            <li><a href=\"#\"><img src=\"/img/icon/compare.png\"");
            BeginWriteAttribute("alt", " alt=\"", 18757, "\"", 18763, 0);
            EndWriteAttribute();
            WriteLiteral("> <span>Compare</span></a></li>\r\n                            <li><a href=\"#\"><img src=\"/img/icon/search.png\"");
            BeginWriteAttribute("alt", " alt=\"", 18872, "\"", 18878, 0);
            EndWriteAttribute();
            WriteLiteral(@"></a></li>
                        </ul>
                    </div>
                    <div class=""product__item__text"">
                        <h6>Piqué Biker Jacket</h6>
                        <a href=""#"" class=""add-cart"">+ Add To Cart</a>
                        <div class=""rating"">
                            <i class=""fa fa-star-o""></i>
                            <i class=""fa fa-star-o""></i>
                            <i class=""fa fa-star-o""></i>
                            <i class=""fa fa-star-o""></i>
                            <i class=""fa fa-star-o""></i>
                        </div>
                        <h5>$67.24</h5>
                        <div class=""product__color__select"">
                            <label for=""pc-4"">
                                <input type=""radio"" id=""pc-4"">
                            </label>
                            <label class=""active black"" for=""pc-5"">
                                <input type=""radio"" id=""pc-5"">
                   ");
            WriteLiteral(@"         </label>
                            <label class=""grey"" for=""pc-6"">
                                <input type=""radio"" id=""pc-6"">
                            </label>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-lg-3 col-md-6 col-sm-6 col-sm-6"">
                <div class=""product__item sale"">
                    <div class=""product__item__pic set-bg"" data-setbg=""img/product/product-3.jpg"">
                        <span class=""label"">Sale</span>
                        <ul class=""product__hover"">
                            <li><a href=""#""><img src=""/img/icon/heart.png""");
            BeginWriteAttribute("alt", " alt=\"", 20586, "\"", 20592, 0);
            EndWriteAttribute();
            WriteLiteral("></a></li>\r\n                            <li><a href=\"#\"><img src=\"/img/icon/compare.png\"");
            BeginWriteAttribute("alt", " alt=\"", 20681, "\"", 20687, 0);
            EndWriteAttribute();
            WriteLiteral("> <span>Compare</span></a></li>\r\n                            <li><a href=\"#\"><img src=\"/img/icon/search.png\"");
            BeginWriteAttribute("alt", " alt=\"", 20796, "\"", 20802, 0);
            EndWriteAttribute();
            WriteLiteral(@"></a></li>
                        </ul>
                    </div>
                    <div class=""product__item__text"">
                        <h6>Multi-pocket Chest Bag</h6>
                        <a href=""#"" class=""add-cart"">+ Add To Cart</a>
                        <div class=""rating"">
                            <i class=""fa fa-star""></i>
                            <i class=""fa fa-star""></i>
                            <i class=""fa fa-star""></i>
                            <i class=""fa fa-star""></i>
                            <i class=""fa fa-star-o""></i>
                        </div>
                        <h5>$43.48</h5>
                        <div class=""product__color__select"">
                            <label for=""pc-7"">
                                <input type=""radio"" id=""pc-7"">
                            </label>
                            <label class=""active black"" for=""pc-8"">
                                <input type=""radio"" id=""pc-8"">
                       ");
            WriteLiteral(@"     </label>
                            <label class=""grey"" for=""pc-9"">
                                <input type=""radio"" id=""pc-9"">
                            </label>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-lg-3 col-md-6 col-sm-6 col-sm-6"">
                <div class=""product__item"">
                    <div class=""product__item__pic set-bg"" data-setbg=""img/product/product-4.jpg"">
                        <ul class=""product__hover"">
                            <li><a href=""#""><img src=""/img/icon/heart.png""");
            BeginWriteAttribute("alt", " alt=\"", 22444, "\"", 22450, 0);
            EndWriteAttribute();
            WriteLiteral("></a></li>\r\n                            <li><a href=\"#\"><img src=\"/img/icon/compare.png\"");
            BeginWriteAttribute("alt", " alt=\"", 22539, "\"", 22545, 0);
            EndWriteAttribute();
            WriteLiteral("> <span>Compare</span></a></li>\r\n                            <li><a href=\"#\"><img src=\"/img/icon/search.png\"");
            BeginWriteAttribute("alt", " alt=\"", 22654, "\"", 22660, 0);
            EndWriteAttribute();
            WriteLiteral(@"></a></li>
                        </ul>
                    </div>
                    <div class=""product__item__text"">
                        <h6>Diagonal Textured Cap</h6>
                        <a href=""#"" class=""add-cart"">+ Add To Cart</a>
                        <div class=""rating"">
                            <i class=""fa fa-star-o""></i>
                            <i class=""fa fa-star-o""></i>
                            <i class=""fa fa-star-o""></i>
                            <i class=""fa fa-star-o""></i>
                            <i class=""fa fa-star-o""></i>
                        </div>
                        <h5>$60.9</h5>
                        <div class=""product__color__select"">
                            <label for=""pc-10"">
                                <input type=""radio"" id=""pc-10"">
                            </label>
                            <label class=""active black"" for=""pc-11"">
                                <input type=""radio"" id=""pc-11"">
             ");
            WriteLiteral(@"               </label>
                            <label class=""grey"" for=""pc-12"">
                                <input type=""radio"" id=""pc-12"">
                            </label>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>
<!-- Related Section End -->
");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <script>
        var abig; // sepete yollanan product item ID!
        var adet;  // sayfada adet seçilen yer ve bıurası sepete gider
       

        function changePrice(id) {
            $.ajax({ // ajax ile sayfadaki view component refresh olmadan yenilenir. size kısmı tıklandıkça fiyat değişir.
                type: ""GET"",
                url: ""/PRODUCT/Product/changePriceComp/"" + id,
                success: function(data) {
                    document.getElementById(""pricespan"").innerHTML = data;

                }
            });
        }

        function itemDeger(item2) {

            abig = item2;

        }
        function postEt() {  // sepete ekle denildiği anda SHOPPINGCART/home addcart methoduna gider ve sepete ekleme işi yapar!!!!ekleme SEPETE EKLE BUTON

            adet = $('#adet').val();
             var intAdet = parseInt(adet);
            if (abig == undefined) {
                alert(""Lütfen ürünün size'ını seçiniz!"")
            }
            els");
                WriteLiteral(@"e {
                $.ajax({
                    type: ""GET"",
                    url: ""/SHOPPINGCART/Home/AddCart?id="" + abig +""&adet=""+intAdet,
                    success: function(data) {
                        // sayfadaki sepet sayısı değişebilir
                        //document.getElementById(""pricespan"").innerHTML = data;
                        alert(data)
                    }
                });
               
            }
        }
    </script>
                                ");
            }
            );
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Product> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
