#pragma checksum "C:\Users\Alejandro\source\repos\AutoService\AutoService\Views\Shared\_TableButtonPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5d9049e31cd6641c00fcb8e929c1eb054811484b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__TableButtonPartial), @"mvc.1.0.view", @"/Views/Shared/_TableButtonPartial.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_TableButtonPartial.cshtml", typeof(AspNetCore.Views_Shared__TableButtonPartial))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d9049e31cd6641c00fcb8e929c1eb054811484b", @"/Views/Shared/_TableButtonPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6204eefa95847e912f991f71e377938810ba79e9", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__TableButtonPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IndividualButtonPartial>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(32, 79, true);
            WriteLiteral("\r\n<td style=\"width: 150px\">\r\n    <div class=\"btn-group\" role=\"group\">\r\n        ");
            EndContext();
            BeginContext(112, 278, false);
#line 5 "C:\Users\Alejandro\source\repos\AutoService\AutoService\Views\Shared\_TableButtonPartial.cshtml"
   Write(Html.Partial("_IndividualButtonPartial", model: new IndividualButtonPartial()
        {
            Action = "Edit", ButtonType = "btn-primary", Glyph = "pencil", Text = "Edit button", ServiceId = Model.ServiceId, CustomerId = Model.CustomerId, CarId = Model.CarId
        }));

#line default
#line hidden
            EndContext();
            BeginContext(390, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(401, 282, false);
#line 9 "C:\Users\Alejandro\source\repos\AutoService\AutoService\Views\Shared\_TableButtonPartial.cshtml"
   Write(Html.Partial("_IndividualButtonPartial", model: new IndividualButtonPartial()
        {
            Action = "Details", ButtonType = "btn-success", Glyph = "list", Text = "Details button", ServiceId = Model.ServiceId, CustomerId = Model.CustomerId, CarId = Model.CarId
        }));

#line default
#line hidden
            EndContext();
            BeginContext(683, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(694, 280, false);
#line 13 "C:\Users\Alejandro\source\repos\AutoService\AutoService\Views\Shared\_TableButtonPartial.cshtml"
   Write(Html.Partial("_IndividualButtonPartial", model: new IndividualButtonPartial()
        {
            Action = "Delete", ButtonType = "btn-danger", Glyph = "trash", Text = "Delete button", ServiceId = Model.ServiceId, CustomerId = Model.CustomerId, CarId = Model.CarId
        }));

#line default
#line hidden
            EndContext();
            BeginContext(974, 19, true);
            WriteLiteral("\r\n    </div>\r\n</td>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndividualButtonPartial> Html { get; private set; }
    }
}
#pragma warning restore 1591