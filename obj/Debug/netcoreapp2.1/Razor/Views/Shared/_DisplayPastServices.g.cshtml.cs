#pragma checksum "C:\Users\Alejandro\source\repos\AutoService\AutoService\Views\Shared\_DisplayPastServices.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7b5a35609f16b70f2d70357d860adc6db7d7b12d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__DisplayPastServices), @"mvc.1.0.view", @"/Views/Shared/_DisplayPastServices.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_DisplayPastServices.cshtml", typeof(AspNetCore.Views_Shared__DisplayPastServices))]
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
#line 1 "C:\Users\Alejandro\source\repos\AutoService\AutoService\Views\Shared\_DisplayPastServices.cshtml"
using AutoService.Utility;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7b5a35609f16b70f2d70357d860adc6db7d7b12d", @"/Views/Shared/_DisplayPastServices.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6204eefa95847e912f991f71e377938810ba79e9", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__DisplayPastServices : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AutoService.ViewModel.CarAndServicesViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(82, 110, true);
            WriteLiteral("<div>\r\n    <table class=\"table table-hover table-condensed\">\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(193, 65, false);
#line 7 "C:\Users\Alejandro\source\repos\AutoService\AutoService\Views\Shared\_DisplayPastServices.cshtml"
           Write(Html.DisplayNameFor(m=>Model.PastServices.FirstOrDefault().Miles));

#line default
#line hidden
            EndContext();
            BeginContext(258, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(314, 65, false);
#line 10 "C:\Users\Alejandro\source\repos\AutoService\AutoService\Views\Shared\_DisplayPastServices.cshtml"
           Write(Html.DisplayNameFor(m=>Model.PastServices.FirstOrDefault().Price));

#line default
#line hidden
            EndContext();
            BeginContext(379, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(435, 67, false);
#line 13 "C:\Users\Alejandro\source\repos\AutoService\AutoService\Views\Shared\_DisplayPastServices.cshtml"
           Write(Html.DisplayNameFor(m=>Model.PastServices.FirstOrDefault().Details));

#line default
#line hidden
            EndContext();
            BeginContext(502, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(558, 69, false);
#line 16 "C:\Users\Alejandro\source\repos\AutoService\AutoService\Views\Shared\_DisplayPastServices.cshtml"
           Write(Html.DisplayNameFor(m=>Model.PastServices.FirstOrDefault().DateAdded));

#line default
#line hidden
            EndContext();
            BeginContext(627, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(683, 76, false);
#line 19 "C:\Users\Alejandro\source\repos\AutoService\AutoService\Views\Shared\_DisplayPastServices.cshtml"
           Write(Html.DisplayNameFor(m=>Model.PastServices.FirstOrDefault().ServiceType.Name));

#line default
#line hidden
            EndContext();
            BeginContext(759, 108, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th><!--For the delete button if present-->\r\n        </tr>\r\n        \r\n");
            EndContext();
#line 24 "C:\Users\Alejandro\source\repos\AutoService\AutoService\Views\Shared\_DisplayPastServices.cshtml"
         foreach (var item in Model.PastServices)
        {

#line default
#line hidden
            BeginContext(929, 30, true);
            WriteLiteral("        <tr>\r\n            <td>");
            EndContext();
            BeginContext(960, 32, false);
#line 27 "C:\Users\Alejandro\source\repos\AutoService\AutoService\Views\Shared\_DisplayPastServices.cshtml"
           Write(Html.DisplayFor(f => item.Miles));

#line default
#line hidden
            EndContext();
            BeginContext(992, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1016, 32, false);
#line 28 "C:\Users\Alejandro\source\repos\AutoService\AutoService\Views\Shared\_DisplayPastServices.cshtml"
           Write(Html.DisplayFor(f => item.Price));

#line default
#line hidden
            EndContext();
            BeginContext(1048, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1072, 34, false);
#line 29 "C:\Users\Alejandro\source\repos\AutoService\AutoService\Views\Shared\_DisplayPastServices.cshtml"
           Write(Html.DisplayFor(f => item.Details));

#line default
#line hidden
            EndContext();
            BeginContext(1106, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1130, 36, false);
#line 30 "C:\Users\Alejandro\source\repos\AutoService\AutoService\Views\Shared\_DisplayPastServices.cshtml"
           Write(Html.DisplayFor(f => item.DateAdded));

#line default
#line hidden
            EndContext();
            BeginContext(1166, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1190, 43, false);
#line 31 "C:\Users\Alejandro\source\repos\AutoService\AutoService\Views\Shared\_DisplayPastServices.cshtml"
           Write(Html.DisplayFor(f => item.ServiceType.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1233, 25, true);
            WriteLiteral("</td>\r\n            <td>\r\n");
            EndContext();
#line 33 "C:\Users\Alejandro\source\repos\AutoService\AutoService\Views\Shared\_DisplayPastServices.cshtml"
                 if (item.DateAdded.Date == DateTime.Now.Date && User.IsInRole(StaticDetails.AdminEndUser))
                 {
                     

#line default
#line hidden
            BeginContext(1409, 421, false);
#line 35 "C:\Users\Alejandro\source\repos\AutoService\AutoService\Views\Shared\_DisplayPastServices.cshtml"
                Write(await Html.PartialAsync("_IndividualButtonPartial",
                         model: new IndividualButtonPartial()
                         {
                             Action = "Delete",
                             ButtonType = "btn-danger",
                             Glyph = "trash",
                             Text = "Delete",
                             ServiceId = item.Id
                         }));

#line default
#line hidden
            EndContext();
#line 43 "C:\Users\Alejandro\source\repos\AutoService\AutoService\Views\Shared\_DisplayPastServices.cshtml"
                           
                 }

#line default
#line hidden
            BeginContext(1852, 34, true);
            WriteLiteral("            </td>\r\n        </tr>\r\n");
            EndContext();
#line 47 "C:\Users\Alejandro\source\repos\AutoService\AutoService\Views\Shared\_DisplayPastServices.cshtml"
        }

#line default
#line hidden
            BeginContext(1897, 20, true);
            WriteLiteral("    </table>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AutoService.ViewModel.CarAndServicesViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
