#pragma checksum "D:\PRN211\AssigmentPRN211\AssigmentPRN211\Views\Movie\EditMovie.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0458c01b80396c0861b415b2e6eec33dffc18065"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movie_EditMovie), @"mvc.1.0.view", @"/Views/Movie/EditMovie.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0458c01b80396c0861b415b2e6eec33dffc18065", @"/Views/Movie/EditMovie.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec77034fa5f9bc535a6ffd5376b8e1a9b35b9d93", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Movie_EditMovie : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AssigmentPRN211.Models.Movie>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("selected", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "2", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "3", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditMovie", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 4 "D:\PRN211\AssigmentPRN211\AssigmentPRN211\Views\Movie\EditMovie.cshtml"
  
    ViewData["Title"] = "EditMovie";
    Layout = "~/Views/Shared/_Layout_Admin.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""main-container"">
    <div class=""pd-ltr-20 xs-pd-20-10"">
        <div class=""min-height-200px"">
            <div class=""page-header"">
                <div class=""row"">
                    <div class=""col-md-6 col-sm-12"">
                        <div class=""title"">
                            <h4>Update Movie</h4>
                        </div>
                        <nav aria-label=""breadcrumb"" role=""navigation"">
                            <ol class=""breadcrumb"">
                                <li class=""breadcrumb-item""><a href=""/Admin/Index"">Home</a></li>
                                <li class=""breadcrumb-item active"" aria-current=""page"">Movie</li>
                            </ol>
                        </nav>
                    </div>
                    <div class=""col-md-6 col-sm-12 text-right"">
                        <div class=""dropdown"">
                            <a class=""btn btn-secondary dropdown-toggle"" href=""#"" role=""button"" data-toggle=""dropdown"">
   ");
            WriteLiteral(@"                             January 2018
                            </a>
                            <div class=""dropdown-menu dropdown-menu-right"">
                                <a class=""dropdown-item"" href=""#"">Export List</a>
                                <a class=""dropdown-item"" href=""#"">Policies</a>
                                <a class=""dropdown-item"" href=""#"">View Assets</a>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <!-- Default Basic Forms Start -->
            <div class=""pd-20 card-box mb-30"">
                
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0458c01b80396c0861b415b2e6eec33dffc180657024", async() => {
                WriteLiteral("\r\n                    <input");
                BeginWriteAttribute("value", " value=\"", 1890, "\"", 1920, 1);
#nullable restore
#line 43 "D:\PRN211\AssigmentPRN211\AssigmentPRN211\Views\Movie\EditMovie.cshtml"
WriteAttributeValue("", 1898, ViewBag.movie.MovieId, 1898, 22, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("  type=\"text\" hidden />\r\n                    <input");
                BeginWriteAttribute("value", " value=\"", 1972, "\"", 2002, 1);
#nullable restore
#line 44 "D:\PRN211\AssigmentPRN211\AssigmentPRN211\Views\Movie\EditMovie.cshtml"
WriteAttributeValue("", 1980, ViewBag.movie.GenreId, 1980, 22, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" type=""text"" />
                
                    <div class=""form-group row"">
                        <label class=""col-sm-12 col-md-2 col-form-label"">Title</label>
                        <div class=""col-sm-12 col-md-10"">
                            <input class=""form-control"" name=""newMovie.Title""");
                BeginWriteAttribute("value", " value=\"", 2312, "\"", 2340, 1);
#nullable restore
#line 49 "D:\PRN211\AssigmentPRN211\AssigmentPRN211\Views\Movie\EditMovie.cshtml"
WriteAttributeValue("", 2320, ViewBag.movie.Title, 2320, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" type=""text"" placeholder=""Johnny Brown"">
                        </div>
                    </div>
                    <div class=""form-group row"">
                        <label class=""col-sm-12 col-md-2 col-form-label"">Year</label>
                        <div class=""col-sm-12 col-md-10"">
                            <input class=""form-control"" name=""newMovie.Year""");
                BeginWriteAttribute("value", " value=\"", 2715, "\"", 2742, 1);
#nullable restore
#line 55 "D:\PRN211\AssigmentPRN211\AssigmentPRN211\Views\Movie\EditMovie.cshtml"
WriteAttributeValue("", 2723, ViewBag.movie.Year, 2723, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" placeholder=""Search Here"" type=""text"">
                        </div>
                    </div>
                    <div class=""form-group row"">
                        <label class=""col-sm-12 col-md-2 col-form-label"">Image</label>
                        <div class=""col-sm-12 col-md-10"">
                            <input class=""form-control"" name=""newMovie.Image""");
                BeginWriteAttribute("value", " value=\"", 3118, "\"", 3146, 1);
#nullable restore
#line 61 "D:\PRN211\AssigmentPRN211\AssigmentPRN211\Views\Movie\EditMovie.cshtml"
WriteAttributeValue("", 3126, ViewBag.movie.Image, 3126, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" type=""text"">
                        </div>
                    </div>
                  
                    <div class=""form-group row"">
                        <label class=""col-sm-12 col-md-2 col-form-label"">Description</label>
                        <div class=""col-sm-12 col-md-10"">
                            
                        <textarea name=""newMovie.Description"" cols=""58"" class=""form-control"" rows=""8"">");
#nullable restore
#line 69 "D:\PRN211\AssigmentPRN211\AssigmentPRN211\Views\Movie\EditMovie.cshtml"
                                                                                                 Write(ViewBag.movie.Description);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</textarea>
           
                            
                        </div>
                    </div>
                   
                    <div class=""form-group row"">
                        <label class=""col-sm-12 col-md-2 col-form-label"">Select</label>
                        <div class=""col-sm-12 col-md-10"">
                            <select class=""custom-select col-12"">
                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0458c01b80396c0861b415b2e6eec33dffc1806511556", async() => {
                    WriteLiteral("Choose...");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0458c01b80396c0861b415b2e6eec33dffc1806512693", async() => {
                    WriteLiteral("One");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0458c01b80396c0861b415b2e6eec33dffc1806513946", async() => {
                    WriteLiteral("Two");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0458c01b80396c0861b415b2e6eec33dffc1806515199", async() => {
                    WriteLiteral("Three");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                            </select>\r\n                        </div>\r\n                    </div>\r\n                    <button type=\"submit\">Update</button>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AssigmentPRN211.Models.Movie> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
