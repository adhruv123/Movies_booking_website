#pragma checksum "E:\visual studio\AspNetCoreProject\WDDN_DotNetCore_Project_CE076_CE073_CE048\MovieTicketBooking\MovieTicketBooking\Views\Movie\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "15d09a1197d757403f0fef52d2591d8a211a6e97"
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
#line 1 "E:\visual studio\AspNetCoreProject\WDDN_DotNetCore_Project_CE076_CE073_CE048\MovieTicketBooking\MovieTicketBooking\Views\_ViewImports.cshtml"
using MovieTicketBooking.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\visual studio\AspNetCoreProject\WDDN_DotNetCore_Project_CE076_CE073_CE048\MovieTicketBooking\MovieTicketBooking\Views\_ViewImports.cshtml"
using MovieTicketBooking.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\visual studio\AspNetCoreProject\WDDN_DotNetCore_Project_CE076_CE073_CE048\MovieTicketBooking\MovieTicketBooking\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"15d09a1197d757403f0fef52d2591d8a211a6e97", @"/Views/Movie/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74d0764ec683f957555843768c7ee9df69f87af1", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Movie_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Movie>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Booking", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-dark text-decoration-none mx-2 my-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("rounded-3 w-100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height: 25rem; width: 17rem"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card rounded-3 text-decoration-none"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\visual studio\AspNetCoreProject\WDDN_DotNetCore_Project_CE076_CE073_CE048\MovieTicketBooking\MovieTicketBooking\Views\Movie\Details.cshtml"
  
    string posterPath = "~/images/" + (Model.PosterPath ?? "default-poster.jpg");

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container d-flex justify-content-between align-items-center my-1\">\r\n    <button onclick=\"history.back()\" class=\"btn btn-dark text-decoration-none my-2\">Back</button>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "15d09a1197d757403f0fef52d2591d8a211a6e976993", async() => {
                WriteLiteral("Book Now");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 9 "E:\visual studio\AspNetCoreProject\WDDN_DotNetCore_Project_CE076_CE073_CE048\MovieTicketBooking\MovieTicketBooking\Views\Movie\Details.cshtml"
                                                     WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n\r\n<div class=\"container-fluid bg-dark\">\r\n    <div class=\"container p-3\">\r\n        <div class=\"row\">\r\n            <div class=\"col-4\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "15d09a1197d757403f0fef52d2591d8a211a6e979687", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 16 "E:\visual studio\AspNetCoreProject\WDDN_DotNetCore_Project_CE076_CE073_CE048\MovieTicketBooking\MovieTicketBooking\Views\Movie\Details.cshtml"
              WriteLiteral(posterPath);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("src", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
#nullable restore
#line 16 "E:\visual studio\AspNetCoreProject\WDDN_DotNetCore_Project_CE076_CE073_CE048\MovieTicketBooking\MovieTicketBooking\Views\Movie\Details.cshtml"
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
#line 21 "E:\visual studio\AspNetCoreProject\WDDN_DotNetCore_Project_CE076_CE073_CE048\MovieTicketBooking\MovieTicketBooking\Views\Movie\Details.cshtml"
                   Write(ViewBag.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <span class=\"text-muted\">(");
#nullable restore
#line 22 "E:\visual studio\AspNetCoreProject\WDDN_DotNetCore_Project_CE076_CE073_CE048\MovieTicketBooking\MovieTicketBooking\Views\Movie\Details.cshtml"
                                             Write(ViewBag.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral(")</span>\r\n                    </h1>\r\n                    <h6 class=\"my-3\">\r\n                        <span class=\"text-light\">");
#nullable restore
#line 25 "E:\visual studio\AspNetCoreProject\WDDN_DotNetCore_Project_CE076_CE073_CE048\MovieTicketBooking\MovieTicketBooking\Views\Movie\Details.cshtml"
                                            Write(ViewBag.Runtime);

#line default
#line hidden
#nullable disable
            WriteLiteral(" • </span>\r\n                        <span class=\"text-light\">");
#nullable restore
#line 26 "E:\visual studio\AspNetCoreProject\WDDN_DotNetCore_Project_CE076_CE073_CE048\MovieTicketBooking\MovieTicketBooking\Views\Movie\Details.cshtml"
                                            Write(ViewBag.Genre);

#line default
#line hidden
#nullable disable
            WriteLiteral(" •</span>\r\n                        <span class=\"text-light\">");
#nullable restore
#line 27 "E:\visual studio\AspNetCoreProject\WDDN_DotNetCore_Project_CE076_CE073_CE048\MovieTicketBooking\MovieTicketBooking\Views\Movie\Details.cshtml"
                                            Write(ViewBag.Released);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    </h6>\r\n                    <h5>\r\n");
#nullable restore
#line 30 "E:\visual studio\AspNetCoreProject\WDDN_DotNetCore_Project_CE076_CE073_CE048\MovieTicketBooking\MovieTicketBooking\Views\Movie\Details.cshtml"
                         foreach (var language in ViewBag.Languages)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <span class=\"badge bg-light text-dark my-3 me-2\">");
#nullable restore
#line 32 "E:\visual studio\AspNetCoreProject\WDDN_DotNetCore_Project_CE076_CE073_CE048\MovieTicketBooking\MovieTicketBooking\Views\Movie\Details.cshtml"
                                                                        Write(language);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 33 "E:\visual studio\AspNetCoreProject\WDDN_DotNetCore_Project_CE076_CE073_CE048\MovieTicketBooking\MovieTicketBooking\Views\Movie\Details.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </h5>\r\n                    <h4 class=\"text-primary\">Ratings</h4>\r\n                    <div class=\"row my-3 text-light\">\r\n");
#nullable restore
#line 37 "E:\visual studio\AspNetCoreProject\WDDN_DotNetCore_Project_CE076_CE073_CE048\MovieTicketBooking\MovieTicketBooking\Views\Movie\Details.cshtml"
                         foreach (var rating in ViewBag.Ratings)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"col-4 d-flex flex-column\">\r\n                                <h5>");
#nullable restore
#line 40 "E:\visual studio\AspNetCoreProject\WDDN_DotNetCore_Project_CE076_CE073_CE048\MovieTicketBooking\MovieTicketBooking\Views\Movie\Details.cshtml"
                               Write(rating.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                <p class=\"text-muted\">");
#nullable restore
#line 41 "E:\visual studio\AspNetCoreProject\WDDN_DotNetCore_Project_CE076_CE073_CE048\MovieTicketBooking\MovieTicketBooking\Views\Movie\Details.cshtml"
                                                 Write(rating.Key);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            </div>\r\n");
#nullable restore
#line 43 "E:\visual studio\AspNetCoreProject\WDDN_DotNetCore_Project_CE076_CE073_CE048\MovieTicketBooking\MovieTicketBooking\Views\Movie\Details.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                    <h4 class=\"text-primary\">Cast & Crew</h4>\r\n                    <div class=\"row text-light my-3\">\r\n");
#nullable restore
#line 47 "E:\visual studio\AspNetCoreProject\WDDN_DotNetCore_Project_CE076_CE073_CE048\MovieTicketBooking\MovieTicketBooking\Views\Movie\Details.cshtml"
                         foreach (var actor in ViewBag.Actors)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"col-4 d-flex flex-column\">\r\n                                <h5>");
#nullable restore
#line 50 "E:\visual studio\AspNetCoreProject\WDDN_DotNetCore_Project_CE076_CE073_CE048\MovieTicketBooking\MovieTicketBooking\Views\Movie\Details.cshtml"
                               Write(actor);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                <p class=\"text-muted\">Actor</p>\r\n                            </div>\r\n");
#nullable restore
#line 53 "E:\visual studio\AspNetCoreProject\WDDN_DotNetCore_Project_CE076_CE073_CE048\MovieTicketBooking\MovieTicketBooking\Views\Movie\Details.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"col-4 d-flex flex-column\">\r\n                            <h5>");
#nullable restore
#line 55 "E:\visual studio\AspNetCoreProject\WDDN_DotNetCore_Project_CE076_CE073_CE048\MovieTicketBooking\MovieTicketBooking\Views\Movie\Details.cshtml"
                           Write(ViewBag.Director);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                            <p class=\"text-muted\">Director</p>\r\n                        </div>\r\n");
#nullable restore
#line 58 "E:\visual studio\AspNetCoreProject\WDDN_DotNetCore_Project_CE076_CE073_CE048\MovieTicketBooking\MovieTicketBooking\Views\Movie\Details.cshtml"
                         foreach (var writer in ViewBag.Writers)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"col-4 d-flex flex-column\">\r\n                                <h5>");
#nullable restore
#line 61 "E:\visual studio\AspNetCoreProject\WDDN_DotNetCore_Project_CE076_CE073_CE048\MovieTicketBooking\MovieTicketBooking\Views\Movie\Details.cshtml"
                               Write(writer);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                <p class=\"text-muted\">Writer</p>\r\n                            </div>\r\n");
#nullable restore
#line 64 "E:\visual studio\AspNetCoreProject\WDDN_DotNetCore_Project_CE076_CE073_CE048\MovieTicketBooking\MovieTicketBooking\Views\Movie\Details.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n<div class=\"container my-3\">\r\n    <h4><span class=\"badge bg-dark text-white\">About the Movie</span></h4>\r\n    <p id=\"desc\">");
#nullable restore
#line 74 "E:\visual studio\AspNetCoreProject\WDDN_DotNetCore_Project_CE076_CE073_CE048\MovieTicketBooking\MovieTicketBooking\Views\Movie\Details.cshtml"
            Write(ViewBag.Plot);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n</div>\r\n\r\n");
#nullable restore
#line 77 "E:\visual studio\AspNetCoreProject\WDDN_DotNetCore_Project_CE076_CE073_CE048\MovieTicketBooking\MovieTicketBooking\Views\Movie\Details.cshtml"
 if (ViewBag.SimilarMovies.Count != 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"container my-3\">\r\n        <h4><span class=\"badge bg-dark text-white\">You might also like</span></h4>\r\n        <div class=\"d-flex\" style=\"overflow-x:auto;flex-wrap:nowrap\">\r\n");
#nullable restore
#line 82 "E:\visual studio\AspNetCoreProject\WDDN_DotNetCore_Project_CE076_CE073_CE048\MovieTicketBooking\MovieTicketBooking\Views\Movie\Details.cshtml"
             foreach (var movie in ViewBag.SimilarMovies)
            {
                string poster = "~/images/" + (movie.PosterPath ?? "default-poster.jpg");

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"my-2 me-2\" style=\"flex:0 0 auto\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "15d09a1197d757403f0fef52d2591d8a211a6e9721333", async() => {
                WriteLiteral("\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "15d09a1197d757403f0fef52d2591d8a211a6e9721613", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 87 "E:\visual studio\AspNetCoreProject\WDDN_DotNetCore_Project_CE076_CE073_CE048\MovieTicketBooking\MovieTicketBooking\Views\Movie\Details.cshtml"
                      WriteLiteral(poster);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("src", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
#nullable restore
#line 87 "E:\visual studio\AspNetCoreProject\WDDN_DotNetCore_Project_CE076_CE073_CE048\MovieTicketBooking\MovieTicketBooking\Views\Movie\Details.cshtml"
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
                WriteLiteral("\r\n                        <div class=\"text-dark text-center my-2\">\r\n                            ");
#nullable restore
#line 89 "E:\visual studio\AspNetCoreProject\WDDN_DotNetCore_Project_CE076_CE073_CE048\MovieTicketBooking\MovieTicketBooking\Views\Movie\Details.cshtml"
                       Write(movie.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </div>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 86 "E:\visual studio\AspNetCoreProject\WDDN_DotNetCore_Project_CE076_CE073_CE048\MovieTicketBooking\MovieTicketBooking\Views\Movie\Details.cshtml"
                                              WriteLiteral(movie.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n");
#nullable restore
#line 93 "E:\visual studio\AspNetCoreProject\WDDN_DotNetCore_Project_CE076_CE073_CE048\MovieTicketBooking\MovieTicketBooking\Views\Movie\Details.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n");
#nullable restore
#line 96 "E:\visual studio\AspNetCoreProject\WDDN_DotNetCore_Project_CE076_CE073_CE048\MovieTicketBooking\MovieTicketBooking\Views\Movie\Details.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Movie> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591