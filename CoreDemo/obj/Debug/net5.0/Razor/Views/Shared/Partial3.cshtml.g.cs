#pragma checksum "C:\Users\GKMNCBK\source\repos\CoreDemo\CoreDemo\Views\Shared\Partial3.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "154dc91547f5000b72365e1940a20b5d9e6e4ce1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Partial3), @"mvc.1.0.view", @"/Views/Shared/Partial3.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"154dc91547f5000b72365e1940a20b5d9e6e4ce1", @"/Views/Shared/Partial3.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac82c3bbfca83888214775683b20655a0c3863c3", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Partial3 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<footer>
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-4 footer-grid-agileits-w3ls text-left"">
                <h3>Hakkımızda</h3>
                <p>
                    Blog, genellikle güncelden eskiye doğru sıralanmış yazı ve yorumların yayınlandığı, web tabanlı bir yayını belirtir. 
                    Çoğunlukla her gönderinin sonunda yazarın adı ve gönderi zamanı belirtilir. Yayıncının seçimine göre okuyucular yazılara
                    yorum yapılabilir. Yorumlar, blog kültürünün çok önemli bir dinamiğidir; bu sayede yazar ve okuyucular ...
                </p>
                <div class=""read"">
                    <a href=""/About/Index/"" class=""btn btn-primary read-m"">Devamını Oku</a>
                </div>
            </div>

            ");
#nullable restore
#line 16 "C:\Users\GKMNCBK\source\repos\CoreDemo\CoreDemo\Views\Shared\Partial3.cshtml"
       Write(await Component.InvokeAsync("LastThreeBlog"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <!-- subscribe -->\r\n            <div class=\"col-lg-4 subscribe-main footer-grid-agileits-w3ls text-left\">\r\n                <div class=\"tech-btm\">\r\n                    <h2>Mail bültenine abone olun</h2>\r\n                    ");
#nullable restore
#line 21 "C:\Users\GKMNCBK\source\repos\CoreDemo\CoreDemo\Views\Shared\Partial3.cshtml"
               Write(await Html.PartialAsync("~/Views/NewsLetter/SubscribeMail.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n");
            WriteLiteral(@"
                </div>
                <!-- //subscribe -->
            </div>
        </div>
        <!-- footer -->
        <div class=""footer-cpy text-center"">
            <div class=""footer-social"">
                <div class=""copyrighttop"">
                    <ul>
                        <li class=""mx-3"">
                            <a class=""facebook"" href=""#"">
                                <i class=""fab fa-facebook-f""></i>
                                <span>Facebook</span>
                            </a>
                        </li>
                        <li>
                            <a class=""facebook"" href=""#"">
                                <i class=""fab fa-twitter""></i>
                                <span>Twitter</span>
                            </a>
                        </li>
                        <li class=""mx-3"">
                            <a class=""facebook"" href=""#"">
                                <i class=""fab fa-google-plus-g""></i>
         ");
            WriteLiteral(@"                       <span>Google+</span>
                            </a>
                        </li>
                        <li>
                            <a class=""facebook"" href=""#"">
                                <i class=""fab fa-pinterest-p""></i>
                                <span>Pinterest</span>
                            </a>
                        </li>
                    </ul>

                </div>
            </div>
            <div class=""w3layouts-agile-copyrightbottom"">
                <p>
                    © ");
#nullable restore
#line 72 "C:\Users\GKMNCBK\source\repos\CoreDemo\CoreDemo\Views\Shared\Partial3.cshtml"
                 Write(DateTime.Now.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Asp.Net Core 5.0 Proje Kampı . Tüm hakları saklıdır.| Design by\r\n                    <a href=\"http://w3layouts.com/\">W3layouts</a>\r\n                </p>\r\n\r\n            </div>\r\n        </div>\r\n\r\n        <!-- //footer -->\r\n\r\n\r\n    </div>\r\n</footer>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
