#pragma checksum "E:\Web_Developer\Practice\BackEnd\dotnetcore\ShopApplication\ShopApplication\Views\Product\Search.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b266fd3cb5ecb8381df3dc0ba0c2a5f0fb1dd55e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Search), @"mvc.1.0.view", @"/Views/Product/Search.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Product/Search.cshtml", typeof(AspNetCore.Views_Product_Search))]
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
#line 1 "E:\Web_Developer\Practice\BackEnd\dotnetcore\ShopApplication\ShopApplication\Views\_ViewImports.cshtml"
using ShopApplication;

#line default
#line hidden
#line 2 "E:\Web_Developer\Practice\BackEnd\dotnetcore\ShopApplication\ShopApplication\Views\_ViewImports.cshtml"
using ShopApplication.Models;

#line default
#line hidden
#line 3 "E:\Web_Developer\Practice\BackEnd\dotnetcore\ShopApplication\ShopApplication\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 4 "E:\Web_Developer\Practice\BackEnd\dotnetcore\ShopApplication\ShopApplication\Views\_ViewImports.cshtml"
using ShopApplication.Data.Entities;

#line default
#line hidden
#line 5 "E:\Web_Developer\Practice\BackEnd\dotnetcore\ShopApplication\ShopApplication\Views\_ViewImports.cshtml"
using ShopApplication.Models.AccountViewModels;

#line default
#line hidden
#line 6 "E:\Web_Developer\Practice\BackEnd\dotnetcore\ShopApplication\ShopApplication\Views\_ViewImports.cshtml"
using ShopApplication.Models.ManageViewModels;

#line default
#line hidden
#line 7 "E:\Web_Developer\Practice\BackEnd\dotnetcore\ShopApplication\ShopApplication\Views\_ViewImports.cshtml"
using ShopApplication.Application.ViewModels.Product;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b266fd3cb5ecb8381df3dc0ba0c2a5f0fb1dd55e", @"/Views/Product/Search.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c6917980a95311f35f324cd854419d4a3c81b13d", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Search : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ShopApplication.Models.ProductViewModels.SearchResultViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "sortBy", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onchange", new global::Microsoft.AspNetCore.Html.HtmlString("this.form.submit()"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "pageSize", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/search.html"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "E:\Web_Developer\Practice\BackEnd\dotnetcore\ShopApplication\ShopApplication\Views\Product\Search.cshtml"
  
    ViewData["Title"] = "Search results of " + (Model.Data.CurrentPage == 1 ? Model.Keyword : Model.Keyword + " - Page " + Model.Data.CurrentPage);
    ViewData["MetaKeyword"] = "Search results of " + (Model.Data.CurrentPage == 1 ? Model.Keyword : Model.Keyword + " - Page " + Model.Data.CurrentPage);
    ViewData["MetaDescription"] = "Search results of " + (Model.Data.CurrentPage == 1 ? Model.Keyword : Model.Keyword + " - Page " + Model.Data.CurrentPage);

#line default
#line hidden
            BeginContext(541, 324, true);
            WriteLiteral(@"
<!-- Breadcrumbs -->

<div class=""breadcrumbs"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-xs-12"">
                <ul>
                    <li class=""home""> <a title=""Go to Home Page"" href=""/"">Home</a><span>&raquo;</span></li>
                    <li><strong>Search result: ");
            EndContext();
            BeginContext(866, 13, false);
#line 16 "E:\Web_Developer\Practice\BackEnd\dotnetcore\ShopApplication\ShopApplication\Views\Product\Search.cshtml"
                                          Write(Model.Keyword);

#line default
#line hidden
            EndContext();
            BeginContext(879, 431, true);
            WriteLiteral(@"</strong></li>
                </ul>
            </div>
        </div>
    </div>
</div>
<!-- Breadcrumbs End -->
<!-- Main Container -->
<div class=""main-container col1-layout"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-main col-sm-12 col-xs-12"">
                <div class=""shop-inner"">
                    <div class=""page-title"">
                        <h2>Search result: ");
            EndContext();
            BeginContext(1311, 13, false);
#line 30 "E:\Web_Developer\Practice\BackEnd\dotnetcore\ShopApplication\ShopApplication\Views\Product\Search.cshtml"
                                      Write(Model.Keyword);

#line default
#line hidden
            EndContext();
            BeginContext(1324, 109, true);
            WriteLiteral("</h2>\r\n                    </div>\r\n                    <div class=\"toolbar column\">\r\n                        ");
            EndContext();
            BeginContext(1433, 951, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cc6975e814bb4e98a3b1b2ad0261f75b", async() => {
                BeginContext(1474, 65, true);
                WriteLiteral("\r\n                            <input type=\"hidden\" name=\"keyword\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1539, "\"", 1561, 1);
#line 34 "E:\Web_Developer\Practice\BackEnd\dotnetcore\ShopApplication\ShopApplication\Views\Product\Search.cshtml"
WriteAttributeValue("", 1547, Model.Keyword, 1547, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1562, 208, true);
                WriteLiteral(" />\r\n                            <div class=\"sorter\">\r\n                                <div class=\"short-by\">\r\n                                    <label>Sort By:</label>\r\n                                    ");
                EndContext();
                BeginContext(1770, 153, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d98b36e19dca46bd84b7c2c53b207f1e", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Name = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 38 "E:\Web_Developer\Practice\BackEnd\dotnetcore\ShopApplication\ShopApplication\Views\Product\Search.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.SortType);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#line 39 "E:\Web_Developer\Practice\BackEnd\dotnetcore\ShopApplication\ShopApplication\Views\Product\Search.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = Model.SortTypes;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1923, 197, true);
                WriteLiteral("\r\n                                </div>\r\n                                <div class=\"short-by page\">\r\n                                    <label>Show:</label>\r\n                                    ");
                EndContext();
                BeginContext(2120, 155, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9417c8fcd08348afa123ea572913819b", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Name = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#line 43 "E:\Web_Developer\Practice\BackEnd\dotnetcore\ShopApplication\ShopApplication\Views\Product\Search.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.PageSize);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#line 44 "E:\Web_Developer\Practice\BackEnd\dotnetcore\ShopApplication\ShopApplication\Views\Product\Search.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = Model.PageSizes;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2275, 102, true);
                WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n                        ");
                EndContext();
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
            EndContext();
            BeginContext(2384, 135, true);
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"product-grid-area\">\r\n                        <ul class=\"products-grid\">\r\n");
            EndContext();
#line 51 "E:\Web_Developer\Practice\BackEnd\dotnetcore\ShopApplication\ShopApplication\Views\Product\Search.cshtml"
                             foreach (var item in Model.Data.Results)
                            {
                                var url = "/" + item.SeoAlias + "-p." + item.Id + ".html";

#line default
#line hidden
            BeginContext(2713, 648, true);
            WriteLiteral(@"                                <li class=""item col-lg-3 col-md-4 col-sm-6 col-xs-6 "">
                                    <div class=""product-item"">
                                        <div class=""item-inner"">
                                            <div class=""product-thumbnail"">
                                                <div class=""icon-sale-label sale-left"">Sale</div>
                                                <div class=""icon-new-label new-right"">New</div>
                                                <div class=""pr-img-area"">
                                                    <a title=""Ipsums Dolors Untra""");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3361, "\"", 3372, 1);
#line 61 "E:\Web_Developer\Practice\BackEnd\dotnetcore\ShopApplication\ShopApplication\Views\Product\Search.cshtml"
WriteAttributeValue("", 3368, url, 3368, 4, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3373, 90, true);
            WriteLiteral(">\r\n                                                        <figure> <img class=\"first-img\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 3463, "\"", 3480, 1);
#line 62 "E:\Web_Developer\Practice\BackEnd\dotnetcore\ShopApplication\ShopApplication\Views\Product\Search.cshtml"
WriteAttributeValue("", 3469, item.Image, 3469, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 3481, "\"", 3497, 1);
#line 62 "E:\Web_Developer\Practice\BackEnd\dotnetcore\ShopApplication\ShopApplication\Views\Product\Search.cshtml"
WriteAttributeValue("", 3487, item.Name, 3487, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3498, 24, true);
            WriteLiteral("> <img class=\"hover-img\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 3522, "\"", 3539, 1);
#line 62 "E:\Web_Developer\Practice\BackEnd\dotnetcore\ShopApplication\ShopApplication\Views\Product\Search.cshtml"
WriteAttributeValue("", 3528, item.Image, 3528, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 3540, "\"", 3556, 1);
#line 62 "E:\Web_Developer\Practice\BackEnd\dotnetcore\ShopApplication\ShopApplication\Views\Product\Search.cshtml"
WriteAttributeValue("", 3546, item.Name, 3546, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3557, 1152, true);
            WriteLiteral(@"></figure>
                                                    </a>
                                                </div>
                                                <div class=""pr-info-area"">
                                                    <div class=""pr-button"">
                                                        <div class=""mt-button add_to_wishlist""> <a href=""wishlist.html""> <i class=""fa fa-heart""></i> </a> </div>
                                                        <div class=""mt-button add_to_compare""> <a href=""compare.html""> <i class=""fa fa-signal""></i> </a> </div>
                                                        <div class=""mt-button quick-view""> <a href=""quick_view.html""> <i class=""fa fa-search""></i> </a> </div>
                                                    </div>
                                                </div>
                                            </div>
                                            <div class=""item-info"">
                         ");
            WriteLiteral("                       <div class=\"info-inner\">\r\n                                                    <div class=\"item-title\"> <a");
            EndContext();
            BeginWriteAttribute("title", " title=\"", 4709, "\"", 4727, 1);
#line 75 "E:\Web_Developer\Practice\BackEnd\dotnetcore\ShopApplication\ShopApplication\Views\Product\Search.cshtml"
WriteAttributeValue("", 4717, item.Name, 4717, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("href", " href=\"", 4728, "\"", 4739, 1);
#line 75 "E:\Web_Developer\Practice\BackEnd\dotnetcore\ShopApplication\ShopApplication\Views\Product\Search.cshtml"
WriteAttributeValue("", 4735, url, 4735, 4, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4740, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(4742, 9, false);
#line 75 "E:\Web_Developer\Practice\BackEnd\dotnetcore\ShopApplication\ShopApplication\Views\Product\Search.cshtml"
                                                                                                          Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(4751, 532, true);
            WriteLiteral(@"</a> </div>
                                                    <div class=""item-content"">
                                                        <div class=""rating""> <i class=""fa fa-star""></i> <i class=""fa fa-star""></i> <i class=""fa fa-star""></i> <i class=""fa fa-star-o""></i> <i class=""fa fa-star-o""></i> </div>
                                                        <div class=""item-price"">
                                                            <div class=""price-box""> <span class=""regular-price""> <span class=""price"">");
            EndContext();
            BeginContext(5284, 25, false);
#line 79 "E:\Web_Developer\Practice\BackEnd\dotnetcore\ShopApplication\ShopApplication\Views\Product\Search.cshtml"
                                                                                                                                Write(item.Price.ToString("N0"));

#line default
#line hidden
            EndContext();
            BeginContext(5309, 261, true);
            WriteLiteral(@"</span> </span> </div>
                                                        </div>
                                                        <div class=""pro-action"">
                                                            <button type=""button"" data-id=""");
            EndContext();
            BeginContext(5571, 7, false);
#line 82 "E:\Web_Developer\Practice\BackEnd\dotnetcore\ShopApplication\ShopApplication\Views\Product\Search.cshtml"
                                                                                      Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(5578, 422, true);
            WriteLiteral(@""" class=""add-to-cart""><span> Add to Cart</span> </button>
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </li>
");
            EndContext();
#line 90 "E:\Web_Developer\Practice\BackEnd\dotnetcore\ShopApplication\ShopApplication\Views\Product\Search.cshtml"

                            }

#line default
#line hidden
            BeginContext(6033, 81, true);
            WriteLiteral("\r\n                        </ul>\r\n                    </div>\r\n                    ");
            EndContext();
            BeginContext(6116, 48, false);
#line 95 "E:\Web_Developer\Practice\BackEnd\dotnetcore\ShopApplication\ShopApplication\Views\Product\Search.cshtml"
                Write(await Component.InvokeAsync("Pager", Model.Data));

#line default
#line hidden
            EndContext();
            BeginContext(6165, 111, true);
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n<!-- Main Container End -->\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ShopApplication.Models.ProductViewModels.SearchResultViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591