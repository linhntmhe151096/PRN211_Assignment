#pragma checksum "D:\PRN211\AssigmentPRN211\AssigmentPRN211\Views\Home\Filter.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "14f26a39ba3d7fdc1fbfe20f72ce8c43dd52bdf0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Filter), @"mvc.1.0.view", @"/Views/Home/Filter.cshtml")]
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
#line 1 "D:\PRN211\AssigmentPRN211\AssigmentPRN211\Views\_ViewImports.cshtml"
using AssigmentPRN211;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\PRN211\AssigmentPRN211\AssigmentPRN211\Views\_ViewImports.cshtml"
using AssigmentPRN211.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"14f26a39ba3d7fdc1fbfe20f72ce8c43dd52bdf0", @"/Views/Home/Filter.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec77034fa5f9bc535a6ffd5376b8e1a9b35b9d93", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Filter : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Movie>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\PRN211\AssigmentPRN211\AssigmentPRN211\Views\Home\Filter.cshtml"
  
    ViewData["Title"] = "Filter";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<style>\r\n    a{\r\n        text-decoration:none;\r\n    }\r\n</style>\r\n\r\n <br>\r\n\r\n\r\n    <!-- Page content-->\r\n    <div class=\"container-fluid row\">\r\n        <div class=\"col-md-3\">\r\n            <h1>Thể Loại</h1>\r\n           \r\n            <ul class=\"text\">\r\n");
#nullable restore
#line 22 "D:\PRN211\AssigmentPRN211\AssigmentPRN211\Views\Home\Filter.cshtml"
            foreach (Genre listgen in ViewBag.Genre)
           {

#line default
#line hidden
#nullable disable
            WriteLiteral("               <li><a");
            BeginWriteAttribute("href", " href=\"", 450, "\"", 495, 2);
            WriteAttributeValue("", 457, "/Home/Filter?genre_id=", 457, 22, true);
#nullable restore
#line 24 "D:\PRN211\AssigmentPRN211\AssigmentPRN211\Views\Home\Filter.cshtml"
WriteAttributeValue("", 479, listgen.GenreId, 479, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 24 "D:\PRN211\AssigmentPRN211\AssigmentPRN211\Views\Home\Filter.cshtml"
                                                               Write(listgen.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 25 "D:\PRN211\AssigmentPRN211\AssigmentPRN211\Views\Home\Filter.cshtml"
           }     

#line default
#line hidden
#nullable disable
            WriteLiteral("            </ul>\r\n        </div>\r\n        <div class=\"col-md-9\">\r\n            <div class=\"row\">\r\n");
#nullable restore
#line 30 "D:\PRN211\AssigmentPRN211\AssigmentPRN211\Views\Home\Filter.cshtml"
                 foreach (Movie movie in ViewBag.listmovie)
               {

#line default
#line hidden
#nullable disable
            WriteLiteral("                   <div class=\"col-md-3 my-3 \" style=\"text-align: center;\">\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 823, "\"", 861, 2);
            WriteAttributeValue("", 830, "/Movie/Detail?id=", 830, 17, true);
#nullable restore
#line 33 "D:\PRN211\AssigmentPRN211\AssigmentPRN211\Views\Home\Filter.cshtml"
WriteAttributeValue("", 847, movie.MovieId, 847, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><img class=\"imgg\"");
            BeginWriteAttribute("src", " src=\"", 880, "\"", 898, 1);
#nullable restore
#line 33 "D:\PRN211\AssigmentPRN211\AssigmentPRN211\Views\Home\Filter.cshtml"
WriteAttributeValue("", 886, movie.Image, 886, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></a>\r\n                    <div class=\"cont\">\r\n                        <div class=\"contentt\">\r\n                            <h3><a");
            BeginWriteAttribute("href", " href=\"", 1028, "\"", 1066, 2);
            WriteAttributeValue("", 1035, "/Movie/Detail?id=", 1035, 17, true);
#nullable restore
#line 36 "D:\PRN211\AssigmentPRN211\AssigmentPRN211\Views\Home\Filter.cshtml"
WriteAttributeValue("", 1052, movie.MovieId, 1052, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 36 "D:\PRN211\AssigmentPRN211\AssigmentPRN211\Views\Home\Filter.cshtml"
                                                                     Write(movie.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h3>\r\n                            Năm: ");
#nullable restore
#line 37 "D:\PRN211\AssigmentPRN211\AssigmentPRN211\Views\Home\Filter.cshtml"
                            Write(movie.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br>\r\n                            Loại: ");
#nullable restore
#line 38 "D:\PRN211\AssigmentPRN211\AssigmentPRN211\Views\Home\Filter.cshtml"
                             Write(movie.Genre.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<br>
                            Điểm: 7.03<br>
                        </div>
                        <button type=""button"" class=""btn btn-primary"" style=""margin-top: 10px;"">Đánh giá</button><br><br>
                    </div>
                </div>
");
#nullable restore
#line 44 "D:\PRN211\AssigmentPRN211\AssigmentPRN211\Views\Home\Filter.cshtml"
               }

#line default
#line hidden
#nullable disable
            WriteLiteral("                \r\n             \r\n          \r\n               \r\n           \r\n\r\n                <!-- them cac bo phim vao day -->\r\n                \r\n            </div>\r\n        </div>\r\n     </div>\r\n    <br><br><br />\r\n\r\n    <br /><br /><br />");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Movie>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591