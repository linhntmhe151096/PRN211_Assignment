#pragma checksum "D:\PRN211\AssigmentPRN211\AssigmentPRN211\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9437e3479034e0ebf6bda36ace89fe5965853804"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#nullable restore
#line 2 "D:\PRN211\AssigmentPRN211\AssigmentPRN211\Views\Home\Index.cshtml"
using AssigmentPRN211.Logic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\PRN211\AssigmentPRN211\AssigmentPRN211\Views\Home\Index.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\PRN211\AssigmentPRN211\AssigmentPRN211\Views\Home\Index.cshtml"
using System.Text.Json;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9437e3479034e0ebf6bda36ace89fe5965853804", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec77034fa5f9bc535a6ffd5376b8e1a9b35b9d93", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Movie>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 6 "D:\PRN211\AssigmentPRN211\AssigmentPRN211\Views\Home\Index.cshtml"
  
    Person p = Context.Session.GetString("User") != null ?
           JsonSerializer.Deserialize<Person>(Context.Session.GetString("User")) : null;
    int idPerson = p == null ? -1 : p.PersonId;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<style>\r\n    a {\r\n        text-decoration: none;\r\n    }\r\n</style>\r\n\r\n\r\n\r\n<br>\r\n\r\n\r\n<!-- Page content-->\r\n<div class=\"container-fluid row\">\r\n    <div class=\"col-md-3\">\r\n        <h1>Th??? Lo???i</h1>\r\n\r\n        <ul class=\"text\">\r\n");
#nullable restore
#line 29 "D:\PRN211\AssigmentPRN211\AssigmentPRN211\Views\Home\Index.cshtml"
             foreach (Genre item in ViewBag.Genres)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li><a");
            BeginWriteAttribute("href", " href=\"", 659, "\"", 701, 2);
            WriteAttributeValue("", 666, "/Home/Filter?genre_id=", 666, 22, true);
#nullable restore
#line 31 "D:\PRN211\AssigmentPRN211\AssigmentPRN211\Views\Home\Index.cshtml"
WriteAttributeValue("", 688, item.GenreId, 688, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 31 "D:\PRN211\AssigmentPRN211\AssigmentPRN211\Views\Home\Index.cshtml"
                                                             Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 32 "D:\PRN211\AssigmentPRN211\AssigmentPRN211\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </ul>\r\n    </div>\r\n    <div class=\"col-md-9\">\r\n        <div class=\"row\">\r\n");
#nullable restore
#line 37 "D:\PRN211\AssigmentPRN211\AssigmentPRN211\Views\Home\Index.cshtml"
             foreach (var movie in ViewBag.listmovie)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-md-3 my-3 \" style=\"text-align: center;\">\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 994, "\"", 1032, 2);
            WriteAttributeValue("", 1001, "/Movie/Detail?id=", 1001, 17, true);
#nullable restore
#line 40 "D:\PRN211\AssigmentPRN211\AssigmentPRN211\Views\Home\Index.cshtml"
WriteAttributeValue("", 1018, movie.MovieId, 1018, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><img class=\"imgg\"");
            BeginWriteAttribute("src", " src=\"", 1051, "\"", 1069, 1);
#nullable restore
#line 40 "D:\PRN211\AssigmentPRN211\AssigmentPRN211\Views\Home\Index.cshtml"
WriteAttributeValue("", 1057, movie.Image, 1057, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></a>\r\n                    <div class=\"cont\">\r\n                        <div class=\"contentt\">\r\n                            <h3><a");
            BeginWriteAttribute("href", " href=\"", 1199, "\"", 1237, 2);
            WriteAttributeValue("", 1206, "/Movie/Detail?id=", 1206, 17, true);
#nullable restore
#line 43 "D:\PRN211\AssigmentPRN211\AssigmentPRN211\Views\Home\Index.cshtml"
WriteAttributeValue("", 1223, movie.MovieId, 1223, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 43 "D:\PRN211\AssigmentPRN211\AssigmentPRN211\Views\Home\Index.cshtml"
                                                                     Write(movie.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h3>\r\n                            N??m: ");
#nullable restore
#line 44 "D:\PRN211\AssigmentPRN211\AssigmentPRN211\Views\Home\Index.cshtml"
                            Write(movie.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br>\r\n                            Lo???i: ");
#nullable restore
#line 45 "D:\PRN211\AssigmentPRN211\AssigmentPRN211\Views\Home\Index.cshtml"
                             Write(movie.Genre.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br>\r\n                             ??i???m:\r\n");
#nullable restore
#line 47 "D:\PRN211\AssigmentPRN211\AssigmentPRN211\Views\Home\Index.cshtml"
                             if(@ViewBag.rate is not null)
                            {
                                 

#line default
#line hidden
#nullable disable
#nullable restore
#line 49 "D:\PRN211\AssigmentPRN211\AssigmentPRN211\Views\Home\Index.cshtml"
                            Write(Rates.Ratee(@movie.MovieId));

#line default
#line hidden
#nullable disable
#nullable restore
#line 49 "D:\PRN211\AssigmentPRN211\AssigmentPRN211\Views\Home\Index.cshtml"
                                                             

                            }else{

#line default
#line hidden
#nullable disable
            WriteLiteral("                               <span>aaaaa</span>\r\n");
#nullable restore
#line 53 "D:\PRN211\AssigmentPRN211\AssigmentPRN211\Views\Home\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                           \r\n\r\n                           \r\n\r\n\r\n\r\n\r\n\r\n                        </div>\r\n");
#nullable restore
#line 63 "D:\PRN211\AssigmentPRN211\AssigmentPRN211\Views\Home\Index.cshtml"
                         if (p == null)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <a href=\"/Login/Login\" type=\"button\" class=\"btn btn-primary\" style=\"margin-top: 10px;\">????nh gi??</a><br><br>\r\n");
#nullable restore
#line 66 "D:\PRN211\AssigmentPRN211\AssigmentPRN211\Views\Home\Index.cshtml"
                        }
                        else{

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <a");
            BeginWriteAttribute("href", " href=\"", 2081, "\"", 2119, 2);
            WriteAttributeValue("", 2088, "/Movie/Detail?id=", 2088, 17, true);
#nullable restore
#line 68 "D:\PRN211\AssigmentPRN211\AssigmentPRN211\Views\Home\Index.cshtml"
WriteAttributeValue("", 2105, movie.MovieId, 2105, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" type=\"button\" class=\"btn btn-primary\" style=\"margin-top: 10px;\">????nh gi??</a><br><br>\r\n");
#nullable restore
#line 69 "D:\PRN211\AssigmentPRN211\AssigmentPRN211\Views\Home\Index.cshtml"
                            
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            \r\n\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 75 "D:\PRN211\AssigmentPRN211\AssigmentPRN211\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n\r\n            <!-- them cac bo phim vao day -->\r\n\r\n        </div>\r\n    </div>\r\n</div>\r\n<br>\r\n<br>\r\n");
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
