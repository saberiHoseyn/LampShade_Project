#pragma checksum "D:\Hoseyn\Asp.NetCore5(atriya)\practices\10.LampShade_Project\Code\LampShade\ServiceHost\Pages\Shared\Components\Slide\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e79182dcf2ce3029c0548c10358d0d5ad76adfd8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ServiceHost.Pages.Shared.Components.Slide.Pages_Shared_Components_Slide_Default), @"mvc.1.0.view", @"/Pages/Shared/Components/Slide/Default.cshtml")]
namespace ServiceHost.Pages.Shared.Components.Slide
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e79182dcf2ce3029c0548c10358d0d5ad76adfd8", @"/Pages/Shared/Components/Slide/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d027006424b9e12b1709732f146fce9f1d78e6a1", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Shared_Components_Slide_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<_01_LampShadeQuery.Contracts.Slide.SlideQueryModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""hero-slider-area section-space"">
    <div class=""container wide"">
        <div class=""row"">
            <div class=""col-lg-12"">
                <div class=""hero-slider-wrapper"">
                    <div class=""ht-slick-slider"" data-slick-setting='{
                        ""slidesToShow"": 1,
                        ""slidesToScroll"": 1,
                        ""arrows"": true,
                        ""dots"": true,
                        ""autoplay"": true,
                        ""autoplaySpeed"": 5000,
                        ""speed"": 1000,
                        ""fade"": true,
                        ""infinite"": true,
                        ""prevArrow"": {""buttonClass"": ""slick-prev"", ""iconClass"": ""ion-chevron-left"" },
                        ""nextArrow"": {""buttonClass"": ""slick-next"", ""iconClass"": ""ion-chevron-right"" }
                    }' data-slick-responsive='[
                        {""breakpoint"":1501, ""settings"": {""slidesToShow"": 1} },
                        {""breakpoint""");
            WriteLiteral(@":1199, ""settings"": {""slidesToShow"": 1, ""arrows"": false} },
                        {""breakpoint"":991, ""settings"": {""slidesToShow"": 1, ""arrows"": false} },
                        {""breakpoint"":767, ""settings"": {""slidesToShow"": 1, ""arrows"": false} },
                        {""breakpoint"":575, ""settings"": {""slidesToShow"": 1, ""arrows"": false} },
                        {""breakpoint"":479, ""settings"": {""slidesToShow"": 1, ""arrows"": false} }
                    ]'>

");
#nullable restore
#line 29 "D:\Hoseyn\Asp.NetCore5(atriya)\practices\10.LampShade_Project\Code\LampShade\ServiceHost\Pages\Shared\Components\Slide\Default.cshtml"
                         foreach (var slide in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"single-slider-item\">\r\n                                <div class=\"hero-slider-item-wrapper\">\r\n                                    <div class=\"container\">\r\n                                        <img");
            BeginWriteAttribute("src", " src=\"", 1880, "\"", 1900, 1);
#nullable restore
#line 34 "D:\Hoseyn\Asp.NetCore5(atriya)\practices\10.LampShade_Project\Code\LampShade\ServiceHost\Pages\Shared\Components\Slide\Default.cshtml"
WriteAttributeValue("", 1886, slide.Picture, 1886, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1901, "\"", 1924, 1);
#nullable restore
#line 34 "D:\Hoseyn\Asp.NetCore5(atriya)\practices\10.LampShade_Project\Code\LampShade\ServiceHost\Pages\Shared\Components\Slide\Default.cshtml"
WriteAttributeValue("", 1907, slide.PictureAlt, 1907, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 1925, "\"", 1952, 1);
#nullable restore
#line 34 "D:\Hoseyn\Asp.NetCore5(atriya)\practices\10.LampShade_Project\Code\LampShade\ServiceHost\Pages\Shared\Components\Slide\Default.cshtml"
WriteAttributeValue("", 1933, slide.PictureTitle, 1933, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"/>
                                        <div class=""row"">
                                            <div class=""col-lg-12"">
                                                <div class=""hero-slider-content hero-slider-content--left-space"">
                                                    <p class=""slider-title slider-title--big-light"">");
#nullable restore
#line 38 "D:\Hoseyn\Asp.NetCore5(atriya)\practices\10.LampShade_Project\Code\LampShade\ServiceHost\Pages\Shared\Components\Slide\Default.cshtml"
                                                                                               Write(slide.Heding);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                                    <p class=\"slider-title slider-title--big-bold\">");
#nullable restore
#line 39 "D:\Hoseyn\Asp.NetCore5(atriya)\practices\10.LampShade_Project\Code\LampShade\ServiceHost\Pages\Shared\Components\Slide\Default.cshtml"
                                                                                              Write(slide.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                                    <p class=\"slider-title slider-title--small\">\r\n                                                       ");
#nullable restore
#line 41 "D:\Hoseyn\Asp.NetCore5(atriya)\practices\10.LampShade_Project\Code\LampShade\ServiceHost\Pages\Shared\Components\Slide\Default.cshtml"
                                                  Write(slide.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                    </p>\r\n                                                    <a class=\"hero-slider-button\" href=\"shop-left-sidebar.html\">\r\n                                                        ");
#nullable restore
#line 44 "D:\Hoseyn\Asp.NetCore5(atriya)\practices\10.LampShade_Project\Code\LampShade\ServiceHost\Pages\Shared\Components\Slide\Default.cshtml"
                                                   Write(slide.BtnText);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" <i class=""ion-ios-plus-empty""></i>
                                                    </a>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
");
#nullable restore
#line 52 "D:\Hoseyn\Asp.NetCore5(atriya)\practices\10.LampShade_Project\Code\LampShade\ServiceHost\Pages\Shared\Components\Slide\Default.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n\r\n                <!--=======  End of hero slider wrapper  =======-->\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<_01_LampShadeQuery.Contracts.Slide.SlideQueryModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
