#pragma checksum "C:\Users\Alejandro\source\repos\AutoService\AutoService\Views\Users\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9b1336f6f569fe7b4153d714774fcec789f5ed98"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Users_Index), @"mvc.1.0.view", @"/Views/Users/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Users/Index.cshtml", typeof(AspNetCore.Views_Users_Index))]
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
#line 1 "C:\Users\Alejandro\source\repos\AutoService\AutoService\Views\_ViewImports.cshtml"
using AutoService;

#line default
#line hidden
#line 2 "C:\Users\Alejandro\source\repos\AutoService\AutoService\Views\_ViewImports.cshtml"
using AutoService.Models;

#line default
#line hidden
#line 2 "C:\Users\Alejandro\source\repos\AutoService\AutoService\Views\Users\Index.cshtml"
using AutoService.Areas.Identity.Pages.Account;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b1336f6f569fe7b4153d714774fcec789f5ed98", @"/Views/Users/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6204eefa95847e912f991f71e377938810ba79e9", @"/Views/_ViewImports.cshtml")]
    public class Views_Users_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AutoService.Data.Migrations.ApplicationUser>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Identity", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Account/Register", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 200px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "cars", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Users", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\Alejandro\source\repos\AutoService\AutoService\Views\Users\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(155, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(157, 2868, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "815ffe4b070b4ef590cf553715e7610e", async() => {
                BeginContext(218, 157, true);
                WriteLiteral("\r\n    <br/>\r\n    <h2>Customers</h2>\r\n    <hr/>\r\n    \r\n    <div style=\"height: 60px;\">\r\n        <div class=\"col-sm-3\" style=\"padding-top: 20px\">\r\n            ");
                EndContext();
                BeginContext(375, 319, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "79a67609ad74421ca87cc1d6dbc69f33", async() => {
                    BeginContext(472, 2, true);
                    WriteLiteral("\r\n");
                    EndContext();
                    BeginContext(587, 103, true);
                    WriteLiteral("                <span class=\"glyphicon glyphicon-plus\"></span> &nbsp; Create New Customer\r\n            ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(694, 218, true);
                WriteLiteral("\r\n        </div>\r\n        <div class=\"col-sm-9\">\r\n            <div class=\"row\">\r\n                <div class=\"col-sm-12 text-right\">\r\n                    <b>Search: </b>\r\n                    <label class=\"radio-inline\">");
                EndContext();
                BeginContext(913, 34, false);
#line 23 "C:\Users\Alejandro\source\repos\AutoService\AutoService\Views\Users\Index.cshtml"
                                           Write(Html.RadioButton("option", "name"));

#line default
#line hidden
                EndContext();
                BeginContext(947, 62, true);
                WriteLiteral("Name</label>\r\n                    <label class=\"radio-inline\">");
                EndContext();
                BeginContext(1010, 35, false);
#line 24 "C:\Users\Alejandro\source\repos\AutoService\AutoService\Views\Users\Index.cshtml"
                                           Write(Html.RadioButton("option", "email"));

#line default
#line hidden
                EndContext();
                BeginContext(1045, 63, true);
                WriteLiteral("Email</label>\r\n                    <label class=\"radio-inline\">");
                EndContext();
                BeginContext(1109, 35, false);
#line 25 "C:\Users\Alejandro\source\repos\AutoService\AutoService\Views\Users\Index.cshtml"
                                           Write(Html.RadioButton("option", "phone"));

#line default
#line hidden
                EndContext();
                BeginContext(1144, 413, true);
                WriteLiteral(@"Phone</label>
                </div>
            </div>
            <div class=""row"">
                <div class=""pull-right"">
                    <button type=""submit"" value=""Search"" class=""btn btn-primary"">
                        <span class=""glyphicon glyphicon-search""></span> Search
                    </button>
                </div>
                <div class=""pull-right"">
                    ");
                EndContext();
                BeginContext(1558, 77, false);
#line 35 "C:\Users\Alejandro\source\repos\AutoService\AutoService\Views\Users\Index.cshtml"
               Write(Html.Editor("search", new {htmlAttributes = new { @class = "form-control" }}));

#line default
#line hidden
                EndContext();
                BeginContext(1635, 224, true);
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n    \r\n    <hr/><br/>\r\n    <div class=\"form-border\">\r\n        <table class=\"table table-condensed table-hover\">\r\n            <tr>\r\n                <th>");
                EndContext();
                BeginContext(1860, 36, false);
#line 45 "C:\Users\Alejandro\source\repos\AutoService\AutoService\Views\Users\Index.cshtml"
               Write(Html.DisplayNameFor(m=> m.FirstName));

#line default
#line hidden
                EndContext();
                BeginContext(1896, 27, true);
                WriteLiteral("</th>\r\n                <th>");
                EndContext();
                BeginContext(1924, 35, false);
#line 46 "C:\Users\Alejandro\source\repos\AutoService\AutoService\Views\Users\Index.cshtml"
               Write(Html.DisplayNameFor(m=> m.LastName));

#line default
#line hidden
                EndContext();
                BeginContext(1959, 27, true);
                WriteLiteral("</th>\r\n                <th>");
                EndContext();
                BeginContext(1987, 38, false);
#line 47 "C:\Users\Alejandro\source\repos\AutoService\AutoService\Views\Users\Index.cshtml"
               Write(Html.DisplayNameFor(m=> m.PhoneNumber));

#line default
#line hidden
                EndContext();
                BeginContext(2025, 27, true);
                WriteLiteral("</th>\r\n                <th>");
                EndContext();
                BeginContext(2053, 32, false);
#line 48 "C:\Users\Alejandro\source\repos\AutoService\AutoService\Views\Users\Index.cshtml"
               Write(Html.DisplayNameFor(m=> m.Email));

#line default
#line hidden
                EndContext();
                BeginContext(2085, 76, true);
                WriteLiteral("</th>\r\n                <th></th><th></th>\r\n            </tr>\r\n            \r\n");
                EndContext();
#line 52 "C:\Users\Alejandro\source\repos\AutoService\AutoService\Views\Users\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
                BeginContext(2218, 46, true);
                WriteLiteral("                <tr>\r\n                    <td>");
                EndContext();
                BeginContext(2265, 34, false);
#line 55 "C:\Users\Alejandro\source\repos\AutoService\AutoService\Views\Users\Index.cshtml"
                   Write(Html.DisplayFor(f=>item.FirstName));

#line default
#line hidden
                EndContext();
                BeginContext(2299, 31, true);
                WriteLiteral("</td>\r\n                    <td>");
                EndContext();
                BeginContext(2331, 33, false);
#line 56 "C:\Users\Alejandro\source\repos\AutoService\AutoService\Views\Users\Index.cshtml"
                   Write(Html.DisplayFor(f=>item.LastName));

#line default
#line hidden
                EndContext();
                BeginContext(2364, 31, true);
                WriteLiteral("</td>\r\n                    <td>");
                EndContext();
                BeginContext(2396, 36, false);
#line 57 "C:\Users\Alejandro\source\repos\AutoService\AutoService\Views\Users\Index.cshtml"
                   Write(Html.DisplayFor(f=>item.PhoneNumber));

#line default
#line hidden
                EndContext();
                BeginContext(2432, 31, true);
                WriteLiteral("</td>\r\n                    <td>");
                EndContext();
                BeginContext(2464, 30, false);
#line 58 "C:\Users\Alejandro\source\repos\AutoService\AutoService\Views\Users\Index.cshtml"
                   Write(Html.DisplayFor(f=>item.Email));

#line default
#line hidden
                EndContext();
                BeginContext(2494, 57, true);
                WriteLiteral("</td>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(2551, 187, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a3139273ea304fcaa59e03fab9369940", async() => {
                    BeginContext(2623, 111, true);
                    WriteLiteral("\r\n                            <img src=\"images/car.png\" width=\"40\"/> &nbsp; View Cars\r\n                        ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-userId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 60 "C:\Users\Alejandro\source\repos\AutoService\AutoService\Views\Users\Index.cshtml"
                                                                          WriteLiteral(item.Id);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["userId"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-userId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["userId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2738, 79, true);
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(2818, 101, false);
#line 65 "C:\Users\Alejandro\source\repos\AutoService\AutoService\Views\Users\Index.cshtml"
                   Write(await Html.PartialAsync("_TableButtonPartial", new IndividualButtonPartial() { CustomerId = item.Id}));

#line default
#line hidden
                EndContext();
                BeginContext(2919, 52, true);
                WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
                EndContext();
#line 68 "C:\Users\Alejandro\source\repos\AutoService\AutoService\Views\Users\Index.cshtml"
            }

#line default
#line hidden
                BeginContext(2986, 32, true);
                WriteLiteral("\r\n        </table>\r\n    </div>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3025, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AutoService.Data.Migrations.ApplicationUser>> Html { get; private set; }
    }
}
#pragma warning restore 1591
