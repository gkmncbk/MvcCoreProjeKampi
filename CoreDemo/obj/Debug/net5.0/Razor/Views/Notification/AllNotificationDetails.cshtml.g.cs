#pragma checksum "C:\Users\GKMNCBK\source\repos\CoreDemo\CoreDemo\Views\Notification\AllNotificationDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5f392042c2cc501954326c9ef7b04a9d7792fe78"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Notification_AllNotificationDetails), @"mvc.1.0.view", @"/Views/Notification/AllNotificationDetails.cshtml")]
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
#nullable restore
#line 1 "C:\Users\GKMNCBK\source\repos\CoreDemo\CoreDemo\Views\Notification\AllNotificationDetails.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f392042c2cc501954326c9ef7b04a9d7792fe78", @"/Views/Notification/AllNotificationDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac82c3bbfca83888214775683b20655a0c3863c3", @"/Views/_ViewImports.cshtml")]
    public class Views_Notification_AllNotificationDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Notification>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\GKMNCBK\source\repos\CoreDemo\CoreDemo\Views\Notification\AllNotificationDetails.cshtml"
  
    ViewData["Title"] = "AllNotificationDetails";
    Layout = "~/Views/Shared/WriterLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1 class=\"col-12 grid-margin stretch-card\">TÜM BİLDİRİMLER</h1>\r\n\r\n");
#nullable restore
#line 10 "C:\Users\GKMNCBK\source\repos\CoreDemo\CoreDemo\Views\Notification\AllNotificationDetails.cshtml"
 foreach (var item in Model)
{
    if (item.NotificationStatus)
    {


#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col-12 grid-margin stretch-card\">\r\n            <div class=\"card\">\r\n                <div class=\"card-body\">\r\n                    <h4 class=\"card-title\">");
#nullable restore
#line 18 "C:\Users\GKMNCBK\source\repos\CoreDemo\CoreDemo\Views\Notification\AllNotificationDetails.cshtml"
                                      Write(item.NotificationType);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                    <hr />\r\n\r\n                    <div class=\"form-group\">\r\n                        <label>");
#nullable restore
#line 22 "C:\Users\GKMNCBK\source\repos\CoreDemo\CoreDemo\Views\Notification\AllNotificationDetails.cshtml"
                          Write(item.NotificationDetails);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                    </div>\r\n\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 28 "C:\Users\GKMNCBK\source\repos\CoreDemo\CoreDemo\Views\Notification\AllNotificationDetails.cshtml"

    }

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Notification>> Html { get; private set; }
    }
}
#pragma warning restore 1591
