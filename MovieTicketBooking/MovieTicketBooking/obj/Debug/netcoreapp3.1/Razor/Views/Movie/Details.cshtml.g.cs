#pragma checksum "D:\Projects\.NetCore\MovieTicketBooking\MovieTicketBooking\Views\Movie\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8553a9b458a7119815a59e750bf3e6ea7135afd4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movie_Details), @"mvc.1.0.view", @"/Views/Movie/Details.cshtml")]
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
#line 1 "D:\Projects\.NetCore\MovieTicketBooking\MovieTicketBooking\Views\_ViewImports.cshtml"
using MovieTicketBooking.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projects\.NetCore\MovieTicketBooking\MovieTicketBooking\Views\_ViewImports.cshtml"
using MovieTicketBooking.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Projects\.NetCore\MovieTicketBooking\MovieTicketBooking\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8553a9b458a7119815a59e750bf3e6ea7135afd4", @"/Views/Movie/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74d0764ec683f957555843768c7ee9df69f87af1", @"/Views/_ViewImports.cshtml")]
    public class Views_Movie_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Movie>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("rounded-3 w-100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Projects\.NetCore\MovieTicketBooking\MovieTicketBooking\Views\Movie\Details.cshtml"
  
    string posterPath = "~/images/" + (Model.PosterPath ?? "default-poster.jpg");

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<input id=\"title\" type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 139, "\"", 159, 1);
#nullable restore
#line 7 "D:\Projects\.NetCore\MovieTicketBooking\MovieTicketBooking\Views\Movie\Details.cshtml"
WriteAttributeValue("", 147, Model.Title, 147, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n\r\n<div class=\"d-flex justify-content-center align-items-center\" style=\"height:50px\">\r\n    <div class=\"mx-3\">\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 285, "\"", 292, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"text-decoration-none\">Details</a>\r\n    </div>\r\n    <div class=\"mx-3\">\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 382, "\"", 389, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"text-decoration-none\">Reviews</a>\r\n    </div>\r\n</div>\r\n\r\n<div class=\"container-fluid bg-dark\">\r\n    <div class=\"container p-3\">\r\n        <div class=\"row\">\r\n            <div class=\"col-4\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8553a9b458a7119815a59e750bf3e6ea7135afd45114", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 22 "D:\Projects\.NetCore\MovieTicketBooking\MovieTicketBooking\Views\Movie\Details.cshtml"
              WriteLiteral(posterPath);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("src", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
#nullable restore
#line 22 "D:\Projects\.NetCore\MovieTicketBooking\MovieTicketBooking\Views\Movie\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n            <div class=\"col-8 d-flex align-items-center\">\r\n                <div id=\"details\">\r\n                    <h1 class=\"text-light mb-3\">\r\n                        ");
#nullable restore
#line 27 "D:\Projects\.NetCore\MovieTicketBooking\MovieTicketBooking\Views\Movie\Details.cshtml"
                   Write(ViewBag.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <span class=\"text-muted\">(");
#nullable restore
#line 28 "D:\Projects\.NetCore\MovieTicketBooking\MovieTicketBooking\Views\Movie\Details.cshtml"
                                             Write(ViewBag.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral(")</span>\r\n                    </h1>\r\n                    <h6 class=\"my-3\">\r\n                        <span class=\"text-light\">");
#nullable restore
#line 31 "D:\Projects\.NetCore\MovieTicketBooking\MovieTicketBooking\Views\Movie\Details.cshtml"
                                            Write(ViewBag.Runtime);

#line default
#line hidden
#nullable disable
            WriteLiteral(" • </span>\r\n                        <span class=\"text-light\">");
#nullable restore
#line 32 "D:\Projects\.NetCore\MovieTicketBooking\MovieTicketBooking\Views\Movie\Details.cshtml"
                                            Write(ViewBag.Genre);

#line default
#line hidden
#nullable disable
            WriteLiteral(" •</span>\r\n                        <span class=\"text-light\">");
#nullable restore
#line 33 "D:\Projects\.NetCore\MovieTicketBooking\MovieTicketBooking\Views\Movie\Details.cshtml"
                                            Write(ViewBag.Released);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    </h6>\r\n                    <h5>\r\n");
#nullable restore
#line 36 "D:\Projects\.NetCore\MovieTicketBooking\MovieTicketBooking\Views\Movie\Details.cshtml"
                         foreach (var language in ViewBag.Languages)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <span class=\"badge bg-light text-dark my-3 me-2\">");
#nullable restore
#line 38 "D:\Projects\.NetCore\MovieTicketBooking\MovieTicketBooking\Views\Movie\Details.cshtml"
                                                                        Write(language);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 39 "D:\Projects\.NetCore\MovieTicketBooking\MovieTicketBooking\Views\Movie\Details.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </h5>\r\n                    <h4 class=\"text-primary\">Ratings</h4>\r\n                    <div class=\"row my-3 text-light\">\r\n");
#nullable restore
#line 43 "D:\Projects\.NetCore\MovieTicketBooking\MovieTicketBooking\Views\Movie\Details.cshtml"
                         foreach (var rating in ViewBag.Ratings)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"col-4 d-flex flex-column\">\r\n                                <h5>");
#nullable restore
#line 46 "D:\Projects\.NetCore\MovieTicketBooking\MovieTicketBooking\Views\Movie\Details.cshtml"
                               Write(rating.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                <p class=\"text-muted\">");
#nullable restore
#line 47 "D:\Projects\.NetCore\MovieTicketBooking\MovieTicketBooking\Views\Movie\Details.cshtml"
                                                 Write(rating.Key);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            </div>\r\n");
#nullable restore
#line 49 "D:\Projects\.NetCore\MovieTicketBooking\MovieTicketBooking\Views\Movie\Details.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                    <h4 class=\"text-primary\">Cast & Crew</h4>\r\n                    <div class=\"row text-light my-3\">\r\n");
#nullable restore
#line 53 "D:\Projects\.NetCore\MovieTicketBooking\MovieTicketBooking\Views\Movie\Details.cshtml"
                         foreach (var actor in ViewBag.Actors)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"col-4 d-flex flex-column\">\r\n                                <h5>");
#nullable restore
#line 56 "D:\Projects\.NetCore\MovieTicketBooking\MovieTicketBooking\Views\Movie\Details.cshtml"
                               Write(actor);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                <p class=\"text-muted\">Actor</p>\r\n                            </div>\r\n");
#nullable restore
#line 59 "D:\Projects\.NetCore\MovieTicketBooking\MovieTicketBooking\Views\Movie\Details.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"col-4 d-flex flex-column\">\r\n                            <h5>");
#nullable restore
#line 61 "D:\Projects\.NetCore\MovieTicketBooking\MovieTicketBooking\Views\Movie\Details.cshtml"
                           Write(ViewBag.Director);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                            <p class=\"text-muted\">Director</p>\r\n                        </div>\r\n");
#nullable restore
#line 64 "D:\Projects\.NetCore\MovieTicketBooking\MovieTicketBooking\Views\Movie\Details.cshtml"
                         foreach (var writer in ViewBag.Writers)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"col-4 d-flex flex-column\">\r\n                                <h5>");
#nullable restore
#line 67 "D:\Projects\.NetCore\MovieTicketBooking\MovieTicketBooking\Views\Movie\Details.cshtml"
                               Write(writer);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                <p class=\"text-muted\">Writer</p>\r\n                            </div>\r\n");
#nullable restore
#line 70 "D:\Projects\.NetCore\MovieTicketBooking\MovieTicketBooking\Views\Movie\Details.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n<div class=\"container my-3\">\r\n    <h3><span class=\"badge bg-dark text-white\">About the Movie</span></h3>\r\n    <p id=\"desc\">");
#nullable restore
#line 80 "D:\Projects\.NetCore\MovieTicketBooking\MovieTicketBooking\Views\Movie\Details.cshtml"
            Write(ViewBag.Plot);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Movie> Html { get; private set; }
    }
}
#pragma warning restore 1591