#pragma checksum "D:\Hoseyn\Asp.NetCore5(atriya)\practices\10.LampShade_Project\Code\LampShade\ServiceHost\Pages\Shared\Components\ProductCategoryWithProduct\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f16726eca3005ec82ed3e0902f38a0d9f6c330ba"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ServiceHost.Pages.Shared.Components.ProductCategoryWithProduct.Pages_Shared_Components_ProductCategoryWithProduct_Default), @"mvc.1.0.view", @"/Pages/Shared/Components/ProductCategoryWithProduct/Default.cshtml")]
namespace ServiceHost.Pages.Shared.Components.ProductCategoryWithProduct
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
#line 1 "D:\Hoseyn\Asp.NetCore5(atriya)\practices\10.LampShade_Project\Code\LampShade\ServiceHost\Pages\_ViewImports.cshtml"
using ServiceHost;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f16726eca3005ec82ed3e0902f38a0d9f6c330ba", @"/Pages/Shared/Components/ProductCategoryWithProduct/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc56f396bbabde3e4f80a7f64d89484409a4286c", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Shared_Components_ProductCategoryWithProduct_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<_01_LampShadeQuery.Contracts.ProductCategory.ProductCategoryQueryModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/ProductCategory", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"

<div class=""single-row-slider-tab-area section-space"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-12"">
                <div class=""section-title-wrapper text-center section-space--half"">
                    <h2 class=""section-title"">Our Products</h2>
                    <p class=""section-subtitle"">
                        لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم از صنعت چاپ و با استفاده از طراحان گرافیک است چاپگرها و متون بلکه روزنامه و مجله در ستون و سطرآنچنان که لازم است
                    </p>
                </div>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-lg-12"">
                <div class=""tab-slider-wrapper"">
                    <div class=""tab-product-navigation"">
                        <div class=""nav nav-tabs justify-content-center"" id=""nav-tab2"" role=""tablist"">

");
#nullable restore
#line 22 "D:\Hoseyn\Asp.NetCore5(atriya)\practices\10.LampShade_Project\Code\LampShade\ServiceHost\Pages\Shared\Components\ProductCategoryWithProduct\Default.cshtml"
                             foreach (var category in Model)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <a");
            BeginWriteAttribute("class", " class=\"", 1114, "\"", 1184, 3);
            WriteAttributeValue("", 1122, "nav-item", 1122, 8, true);
            WriteAttributeValue(" ", 1130, "nav-link", 1131, 9, true);
#nullable restore
#line 24 "D:\Hoseyn\Asp.NetCore5(atriya)\practices\10.LampShade_Project\Code\LampShade\ServiceHost\Pages\Shared\Components\ProductCategoryWithProduct\Default.cshtml"
WriteAttributeValue(" ", 1139, Model.First() == category ? "active" : "", 1140, 44, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("id", "\r\n                                   id=\"", 1185, "\"", 1250, 2);
            WriteAttributeValue("", 1226, "product-tab-", 1226, 12, true);
#nullable restore
#line 25 "D:\Hoseyn\Asp.NetCore5(atriya)\practices\10.LampShade_Project\Code\LampShade\ServiceHost\Pages\Shared\Components\ProductCategoryWithProduct\Default.cshtml"
WriteAttributeValue("", 1238, category.Id, 1238, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("\r\n                                   data-toggle=\"tab\"");
            BeginWriteAttribute("href", "\r\n                                   href=\"", 1305, "\"", 1376, 2);
            WriteAttributeValue("", 1348, "#product-series-", 1348, 16, true);
#nullable restore
#line 27 "D:\Hoseyn\Asp.NetCore5(atriya)\practices\10.LampShade_Project\Code\LampShade\ServiceHost\Pages\Shared\Components\ProductCategoryWithProduct\Default.cshtml"
WriteAttributeValue("", 1364, category.Id, 1364, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("\r\n                                   role=\"tab\"");
            BeginWriteAttribute("aria-selected", "\r\n                                   aria-selected=\"", 1424, "\"", 1523, 1);
#nullable restore
#line 29 "D:\Hoseyn\Asp.NetCore5(atriya)\practices\10.LampShade_Project\Code\LampShade\ServiceHost\Pages\Shared\Components\ProductCategoryWithProduct\Default.cshtml"
WriteAttributeValue("", 1476, Model.First() == category ? "true" : "false", 1476, 47, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    ");
#nullable restore
#line 30 "D:\Hoseyn\Asp.NetCore5(atriya)\practices\10.LampShade_Project\Code\LampShade\ServiceHost\Pages\Shared\Components\ProductCategoryWithProduct\Default.cshtml"
                               Write(category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </a>\r\n");
#nullable restore
#line 32 "D:\Hoseyn\Asp.NetCore5(atriya)\practices\10.LampShade_Project\Code\LampShade\ServiceHost\Pages\Shared\Components\ProductCategoryWithProduct\Default.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"tab-content\">\r\n");
#nullable restore
#line 37 "D:\Hoseyn\Asp.NetCore5(atriya)\practices\10.LampShade_Project\Code\LampShade\ServiceHost\Pages\Shared\Components\ProductCategoryWithProduct\Default.cshtml"
                         foreach (var category in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div");
            BeginWriteAttribute("class", " class=\"", 1874, "\"", 1945, 4);
            WriteAttributeValue("", 1882, "tab-pane", 1882, 8, true);
            WriteAttributeValue(" ", 1890, "fade", 1891, 5, true);
            WriteAttributeValue(" ", 1895, "show", 1896, 5, true);
#nullable restore
#line 39 "D:\Hoseyn\Asp.NetCore5(atriya)\practices\10.LampShade_Project\Code\LampShade\ServiceHost\Pages\Shared\Components\ProductCategoryWithProduct\Default.cshtml"
WriteAttributeValue(" ", 1900, Model.First() == category ? "active" : "", 1901, 44, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("id", "\r\n                                 id=\"", 1946, "\"", 2012, 2);
            WriteAttributeValue("", 1985, "product-series-", 1985, 15, true);
#nullable restore
#line 40 "D:\Hoseyn\Asp.NetCore5(atriya)\practices\10.LampShade_Project\Code\LampShade\ServiceHost\Pages\Shared\Components\ProductCategoryWithProduct\Default.cshtml"
WriteAttributeValue("", 2000, category.Id, 2000, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" role=""tabpanel""
                                 aria-labelledby=""product-tab-1"">
                                <div class=""single-row-slider-wrapper"">
                                    <div class=""ht-slick-slider"" data-slick-setting='{
                                    ""slidesToShow"": 4,
                                    ""slidesToScroll"": 1,
                                    ""arrows"": true,
                                    ""autoplay"": false,
                                    ""autoplaySpeed"": 5000,
                                    ""speed"": 1000,
                                    ""infinite"": true,
                                    ""rtl"": true,
                                    ""prevArrow"": {""buttonClass"": ""slick-prev"", ""iconClass"": ""ion-chevron-left"" },
                                    ""nextArrow"": {""buttonClass"": ""slick-next"", ""iconClass"": ""ion-chevron-right"" }
                                }' data-slick-responsive='[
                                    {""breakpoin");
            WriteLiteral(@"t"":1501, ""settings"": {""slidesToShow"": 4} },
                                    {""breakpoint"":1199, ""settings"": {""slidesToShow"": 4, ""arrows"": false} },
                                    {""breakpoint"":991, ""settings"": {""slidesToShow"": 3, ""arrows"": false} },
                                    {""breakpoint"":767, ""settings"": {""slidesToShow"": 2, ""arrows"": false} },
                                    {""breakpoint"":575, ""settings"": {""slidesToShow"": 2, ""arrows"": false} },
                                    {""breakpoint"":479, ""settings"": {""slidesToShow"": 1, ""arrows"": false} }
                                ]'>

");
#nullable restore
#line 63 "D:\Hoseyn\Asp.NetCore5(atriya)\practices\10.LampShade_Project\Code\LampShade\ServiceHost\Pages\Shared\Components\ProductCategoryWithProduct\Default.cshtml"
                                         foreach (var product in category.Products)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <div class=\"col\">\r\n                                                <div class=\"single-grid-product\">\r\n                                                    <div class=\"single-grid-product__image\">\r\n");
#nullable restore
#line 68 "D:\Hoseyn\Asp.NetCore5(atriya)\practices\10.LampShade_Project\Code\LampShade\ServiceHost\Pages\Shared\Components\ProductCategoryWithProduct\Default.cshtml"
                                                         if (product.HasDiscount)
                                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                            <div class=\"single-grid-product__label\">\r\n                                                                <span class=\"sale\">-");
#nullable restore
#line 71 "D:\Hoseyn\Asp.NetCore5(atriya)\practices\10.LampShade_Project\Code\LampShade\ServiceHost\Pages\Shared\Components\ProductCategoryWithProduct\Default.cshtml"
                                                                               Write(product.DiscountRate);

#line default
#line hidden
#nullable disable
            WriteLiteral("%</span>\r\n                                                            </div>\r\n");
#nullable restore
#line 73 "D:\Hoseyn\Asp.NetCore5(atriya)\practices\10.LampShade_Project\Code\LampShade\ServiceHost\Pages\Shared\Components\ProductCategoryWithProduct\Default.cshtml"
                                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f16726eca3005ec82ed3e0902f38a0d9f6c330ba14351", async() => {
                WriteLiteral("\r\n                                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f16726eca3005ec82ed3e0902f38a0d9f6c330ba14667", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 4695, "~/UploadedFile/", 4695, 15, true);
#nullable restore
#line 75 "D:\Hoseyn\Asp.NetCore5(atriya)\practices\10.LampShade_Project\Code\LampShade\ServiceHost\Pages\Shared\Components\ProductCategoryWithProduct\Default.cshtml"
AddHtmlAttributeValue("", 4710, product.Picture, 4710, 16, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 76 "D:\Hoseyn\Asp.NetCore5(atriya)\practices\10.LampShade_Project\Code\LampShade\ServiceHost\Pages\Shared\Components\ProductCategoryWithProduct\Default.cshtml"
AddHtmlAttributeValue("", 4817, product.PictureAlt, 4817, 19, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "title", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 76 "D:\Hoseyn\Asp.NetCore5(atriya)\practices\10.LampShade_Project\Code\LampShade\ServiceHost\Pages\Shared\Components\ProductCategoryWithProduct\Default.cshtml"
AddHtmlAttributeValue("", 4845, product.PictureTitle, 4845, 21, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 74 "D:\Hoseyn\Asp.NetCore5(atriya)\practices\10.LampShade_Project\Code\LampShade\ServiceHost\Pages\Shared\Components\ProductCategoryWithProduct\Default.cshtml"
                                                                                 WriteLiteral(product.Slug);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

                                                        <div class=""hover-icons"">
                                                            <a href=""javascript:void(0)""><i class=""ion-bag""></i></a>
                                                            <a href=""javascript:void(0)""><i class=""ion-heart""></i></a>
                                                            <a href=""javascript:void(0)"">
                                                                <i class=""ion-android-options""></i>
                                                            </a>
                                                            <a href=""javascript:void(0)"" data-toggle=""modal""
                                                               data-target=""#quick-view-modal-container"">
                                                                <i class=""ion-android-open""></i>
                                                            </a>
                                                        </di");
            WriteLiteral(@"v>
                                                    </div>
                                                    <div class=""single-grid-product__content"">
                                                        <div class=""single-grid-product__category-rating"">
                                                            <span class=""category"">
                                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f16726eca3005ec82ed3e0902f38a0d9f6c330ba21054", async() => {
#nullable restore
#line 94 "D:\Hoseyn\Asp.NetCore5(atriya)\practices\10.LampShade_Project\Code\LampShade\ServiceHost\Pages\Shared\Components\ProductCategoryWithProduct\Default.cshtml"
                                                                                                                        Write(product.Category);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 94 "D:\Hoseyn\Asp.NetCore5(atriya)\practices\10.LampShade_Project\Code\LampShade\ServiceHost\Pages\Shared\Components\ProductCategoryWithProduct\Default.cshtml"
                                                                                                 WriteLiteral(category.Slug);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                                            </span>
                                                            <span class=""rating"">
                                                                <i class=""ion-android-star active""></i>
                                                                <i class=""ion-android-star active""></i>
                                                                <i class=""ion-android-star active""></i>
                                                                <i class=""ion-android-star active""></i>
                                                                <i class=""ion-android-star-outline""></i>
                                                            </span>
                                                        </div>

                                                        <h3 class=""single-grid-product__title"">
                                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f16726eca3005ec82ed3e0902f38a0d9f6c330ba24665", async() => {
                WriteLiteral("\r\n                                                                ");
#nullable restore
#line 107 "D:\Hoseyn\Asp.NetCore5(atriya)\practices\10.LampShade_Project\Code\LampShade\ServiceHost\Pages\Shared\Components\ProductCategoryWithProduct\Default.cshtml"
                                                           Write(product.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 106 "D:\Hoseyn\Asp.NetCore5(atriya)\practices\10.LampShade_Project\Code\LampShade\ServiceHost\Pages\Shared\Components\ProductCategoryWithProduct\Default.cshtml"
                                                                                     WriteLiteral(product.Slug);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                                        </h3>\r\n                                                        <p class=\"single-grid-product__price\">\r\n");
#nullable restore
#line 111 "D:\Hoseyn\Asp.NetCore5(atriya)\practices\10.LampShade_Project\Code\LampShade\ServiceHost\Pages\Shared\Components\ProductCategoryWithProduct\Default.cshtml"
                                                             if (product.HasDiscount)
                                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                                <span class=\"discounted-price\">");
#nullable restore
#line 113 "D:\Hoseyn\Asp.NetCore5(atriya)\practices\10.LampShade_Project\Code\LampShade\ServiceHost\Pages\Shared\Components\ProductCategoryWithProduct\Default.cshtml"
                                                                                          Write(product.PriceWithDiscount);

#line default
#line hidden
#nullable disable
            WriteLiteral(" تومان</span>\r\n                                                                <span class=\"main-price discounted\">");
#nullable restore
#line 114 "D:\Hoseyn\Asp.NetCore5(atriya)\practices\10.LampShade_Project\Code\LampShade\ServiceHost\Pages\Shared\Components\ProductCategoryWithProduct\Default.cshtml"
                                                                                               Write(product.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" تومان</span>\r\n");
#nullable restore
#line 115 "D:\Hoseyn\Asp.NetCore5(atriya)\practices\10.LampShade_Project\Code\LampShade\ServiceHost\Pages\Shared\Components\ProductCategoryWithProduct\Default.cshtml"
                                                            }
                                                            else
                                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                                <span class=\"main-price\">");
#nullable restore
#line 118 "D:\Hoseyn\Asp.NetCore5(atriya)\practices\10.LampShade_Project\Code\LampShade\ServiceHost\Pages\Shared\Components\ProductCategoryWithProduct\Default.cshtml"
                                                                                    Write(product.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" تومان</span>\r\n");
#nullable restore
#line 119 "D:\Hoseyn\Asp.NetCore5(atriya)\practices\10.LampShade_Project\Code\LampShade\ServiceHost\Pages\Shared\Components\ProductCategoryWithProduct\Default.cshtml"
                                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        </p>\r\n                                                    </div>\r\n                                                </div>\r\n                                            </div>\r\n");
#nullable restore
#line 124 "D:\Hoseyn\Asp.NetCore5(atriya)\practices\10.LampShade_Project\Code\LampShade\ServiceHost\Pages\Shared\Components\ProductCategoryWithProduct\Default.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </div>\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 128 "D:\Hoseyn\Asp.NetCore5(atriya)\practices\10.LampShade_Project\Code\LampShade\ServiceHost\Pages\Shared\Components\ProductCategoryWithProduct\Default.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<_01_LampShadeQuery.Contracts.ProductCategory.ProductCategoryQueryModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
