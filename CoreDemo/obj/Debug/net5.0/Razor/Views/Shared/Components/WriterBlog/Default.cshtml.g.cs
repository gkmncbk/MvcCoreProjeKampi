#pragma checksum "C:\Users\GKMNCBK\source\repos\CoreDemo\CoreDemo\Views\Shared\Components\WriterBlog\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ad3c3092c63bbfe0b37f9479fd25bf92e638bf9a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_WriterBlog_Default), @"mvc.1.0.view", @"/Views/Shared/Components/WriterBlog/Default.cshtml")]
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
#line 1 "C:\Users\GKMNCBK\source\repos\CoreDemo\CoreDemo\Views\_ViewImports.cshtml"
using CoreDemo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\GKMNCBK\source\repos\CoreDemo\CoreDemo\Views\_ViewImports.cshtml"
using CoreDemo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ad3c3092c63bbfe0b37f9479fd25bf92e638bf9a", @"/Views/Shared/Components/WriterBlog/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac82c3bbfca83888214775683b20655a0c3863c3", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_WriterBlog_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EntityLayer.Concrete.Blog>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\GKMNCBK\source\repos\CoreDemo\CoreDemo\Views\Shared\Components\WriterBlog\Default.cshtml"
 if (Model.Count() > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"tech-btm\">\r\n        <h4>Yazarın Diğer Yazıları</h4>\r\n");
#nullable restore
#line 8 "C:\Users\GKMNCBK\source\repos\CoreDemo\CoreDemo\Views\Shared\Components\WriterBlog\Default.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"blog-grids row mb-3\">\r\n                <div class=\"col-md-5 blog-grid-left\">\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 321, "\"", 359, 3);
            WriteAttributeValue("", 328, "/Blog/BlogReadAll/", 328, 18, true);
#nullable restore
#line 12 "C:\Users\GKMNCBK\source\repos\CoreDemo\CoreDemo\Views\Shared\Components\WriterBlog\Default.cshtml"
WriteAttributeValue("", 346, item.BlogID, 346, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 358, "/", 358, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <img");
            BeginWriteAttribute("src", " src=\"", 391, "\"", 412, 1);
#nullable restore
#line 13 "C:\Users\GKMNCBK\source\repos\CoreDemo\CoreDemo\Views\Shared\Components\WriterBlog\Default.cshtml"
WriteAttributeValue("", 397, item.BlogImage, 397, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 431, "\"", 437, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    </a>\r\n                </div>\r\n                <div class=\"col-md-7 blog-grid-right\">\r\n\r\n                    <h5>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 601, "\"", 639, 3);
            WriteAttributeValue("", 608, "/Blog/BlogReadAll/", 608, 18, true);
#nullable restore
#line 19 "C:\Users\GKMNCBK\source\repos\CoreDemo\CoreDemo\Views\Shared\Components\WriterBlog\Default.cshtml"
WriteAttributeValue("", 626, item.BlogID, 626, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 638, "/", 638, 1, true);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 19 "C:\Users\GKMNCBK\source\repos\CoreDemo\CoreDemo\Views\Shared\Components\WriterBlog\Default.cshtml"
                                                             Write(item.BlogTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </a>\r\n                    </h5>\r\n                    <div class=\"sub-meta\">\r\n                        <span>\r\n                            <i class=\"far fa-clock\"></i> ");
#nullable restore
#line 23 "C:\Users\GKMNCBK\source\repos\CoreDemo\CoreDemo\Views\Shared\Components\WriterBlog\Default.cshtml"
                                                     Write(((DateTime)item.BlogCreateDate).ToString("dd-MMM-yyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </span>\r\n                    </div>\r\n                </div>\r\n\r\n            </div>\r\n");
#nullable restore
#line 29 "C:\Users\GKMNCBK\source\repos\CoreDemo\CoreDemo\Views\Shared\Components\WriterBlog\Default.cshtml"

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 33 "C:\Users\GKMNCBK\source\repos\CoreDemo\CoreDemo\Views\Shared\Components\WriterBlog\Default.cshtml"

}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EntityLayer.Concrete.Blog>> Html { get; private set; }
    }
}
#pragma warning restore 1591
