#pragma checksum "C:\Users\GKMNCBK\source\repos\CoreDemo\CoreDemo\Views\Blog\BlogListByWriter.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "796e5f77aba9cc8fa1f66ce79bd4567fdcf3c7c1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_BlogListByWriter), @"mvc.1.0.view", @"/Views/Blog/BlogListByWriter.cshtml")]
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
#line 1 "C:\Users\GKMNCBK\source\repos\CoreDemo\CoreDemo\Views\Blog\BlogListByWriter.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"796e5f77aba9cc8fa1f66ce79bd4567fdcf3c7c1", @"/Views/Blog/BlogListByWriter.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac82c3bbfca83888214775683b20655a0c3863c3", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_BlogListByWriter : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Blog>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\GKMNCBK\source\repos\CoreDemo\CoreDemo\Views\Blog\BlogListByWriter.cshtml"
  
    ViewData["Title"] = "BloglistByWriter";
    Layout = "~/Views/Shared/WriterLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<script type=""text/javascript"" src=""https://ajax.googleapis.com/ajax/libs/jquery/1.8.3/jquery.min.js""></script>
<script type=""text/javascript"" src=""https://cdnjs.cloudflare.com/ajax/libs/jquery-ajax-unobtrusive/3.2.6/jquery.unobtrusive-ajax.js""></script>

<script src=""https://cdn.jsdelivr.net/npm/sweetalert2@11""></script>



<h1>Yazarın Blogları</h1>

<table class=""table table-bordered"">
    <tr>
        <th>#</th>
        <th>Blog Başlığı</th>
        <th>Oluşturma Tarihi</th>
        <th>Kategori</th>
        <th>Durum</th>
        <th>Sil</th>
        <th>Düzenle</th>
    </tr>
");
#nullable restore
#line 26 "C:\Users\GKMNCBK\source\repos\CoreDemo\CoreDemo\Views\Blog\BlogListByWriter.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <th>");
#nullable restore
#line 29 "C:\Users\GKMNCBK\source\repos\CoreDemo\CoreDemo\Views\Blog\BlogListByWriter.cshtml"
           Write(item.BlogID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <td>");
#nullable restore
#line 30 "C:\Users\GKMNCBK\source\repos\CoreDemo\CoreDemo\Views\Blog\BlogListByWriter.cshtml"
           Write(item.BlogTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 31 "C:\Users\GKMNCBK\source\repos\CoreDemo\CoreDemo\Views\Blog\BlogListByWriter.cshtml"
            Write(((DateTime)item.BlogCreateDate).ToString("dd-MMM-yyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 32 "C:\Users\GKMNCBK\source\repos\CoreDemo\CoreDemo\Views\Blog\BlogListByWriter.cshtml"
           Write(item.Category.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 33 "C:\Users\GKMNCBK\source\repos\CoreDemo\CoreDemo\Views\Blog\BlogListByWriter.cshtml"
             if (@item.BlogStatus)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td>Aktif</td>\r\n");
#nullable restore
#line 36 "C:\Users\GKMNCBK\source\repos\CoreDemo\CoreDemo\Views\Blog\BlogListByWriter.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td>Pasif</td>\r\n");
#nullable restore
#line 40 "C:\Users\GKMNCBK\source\repos\CoreDemo\CoreDemo\Views\Blog\BlogListByWriter.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <td><a data-id=\"");
#nullable restore
#line 43 "C:\Users\GKMNCBK\source\repos\CoreDemo\CoreDemo\Views\Blog\BlogListByWriter.cshtml"
                       Write(item.BlogID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"btn btn-danger blogsil\">Sil</a> </td>\r\n\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 1450, "\"", 1484, 2);
            WriteAttributeValue("", 1457, "/Blog/EditBlog/", 1457, 15, true);
#nullable restore
#line 45 "C:\Users\GKMNCBK\source\repos\CoreDemo\CoreDemo\Views\Blog\BlogListByWriter.cshtml"
WriteAttributeValue("", 1472, item.BlogID, 1472, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-warning\">Düzenle</a> </td>\r\n        </tr>\r\n");
#nullable restore
#line 47 "C:\Users\GKMNCBK\source\repos\CoreDemo\CoreDemo\Views\Blog\BlogListByWriter.cshtml"


    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

</table>

<a href=""/Blog/BlogAdd/"" class=""btn btn-primary"">Yeni Blog Oluştur</a>
<script>
         $(document).on('click' ,'.blogsil', function(){
         var id = $(this).data(""id"");
            Swal.fire({
                    title: 'Blog silinecek!',
                    text: ""Silmek istediğinize emin misiniz?"",
                    //type: 'warning',
                    showCancelButton: true,
                    confirmButtonColor: '#3085d6',
                    cancelButtonColor: '#d33',
                    confirmButtonText: 'Evet, sil!',
                    cancelButtonText: 'İptal!',
                    //closeOnConfirm: false
                    }).then(function(isConfirm) { if (isConfirm) {
                        $.ajax({
                            type: 'post',
                            url: '/Blog/DeleteBlog2/'+ id,
                            success: function (data) {
                                if (data) {
                                  Swal.fire(
        ");
            WriteLiteral(@"                            'Tebrikler!',
                                    'Blog başarıyla silindi.',
                                    'success',
                                     )
                                     window.setTimeout(function () {window.location.href = """);
#nullable restore
#line 79 "C:\Users\GKMNCBK\source\repos\CoreDemo\CoreDemo\Views\Blog\BlogListByWriter.cshtml"
                                                                                       Write(Url.Action("BloglistByWriter", "Blog"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"""}, 1000);

                                   }
                                    else {
                                            Swal.fire(
                                                'Deleted2!',
                                                'Your file has been deleted.',
                                                'success'
                                              )
                                    return false;
                            }
                        }
                    });

                }
                });
            });
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Blog>> Html { get; private set; }
    }
}
#pragma warning restore 1591
