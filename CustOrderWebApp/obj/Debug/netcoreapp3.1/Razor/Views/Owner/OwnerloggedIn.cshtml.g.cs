#pragma checksum "C:\Users\Amit-pc\Desktop\JayeshFol\CustOrder\CustOrderWebApp\Views\Owner\OwnerloggedIn.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8593b06e8715442cd59dd157fca1e9daf2a2b722"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Owner_OwnerloggedIn), @"mvc.1.0.view", @"/Views/Owner/OwnerloggedIn.cshtml")]
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
#line 1 "C:\Users\Amit-pc\Desktop\JayeshFol\CustOrder\CustOrderWebApp\Views\_ViewImports.cshtml"
using CustOrderWebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Amit-pc\Desktop\JayeshFol\CustOrder\CustOrderWebApp\Views\_ViewImports.cshtml"
using CustOrderWebApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8593b06e8715442cd59dd157fca1e9daf2a2b722", @"/Views/Owner/OwnerloggedIn.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"50affc7c26f233b922ff8b995182b11407a19c68", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Owner_OwnerloggedIn : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DataLayer.Owner>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Amit-pc\Desktop\JayeshFol\CustOrder\CustOrderWebApp\Views\Owner\OwnerloggedIn.cshtml"
  
    ViewData["Title"] = "OwnerloggedIn";
    Layout = "~/Views/Owner/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n    <h2>\r\n        Welcome ");
#nullable restore
#line 11 "C:\Users\Amit-pc\Desktop\JayeshFol\CustOrder\CustOrderWebApp\Views\Owner\OwnerloggedIn.cshtml"
           Write(Model.EmailID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </h2>\r\n\r\n    <div class=\"container\">\r\n      \r\n        <div class=\"row\">\r\n            <div class=\"col-sm-9\">\r\n                ");
#nullable restore
#line 18 "C:\Users\Amit-pc\Desktop\JayeshFol\CustOrder\CustOrderWebApp\Views\Owner\OwnerloggedIn.cshtml"
           Write(Html.ActionLink("View All Orders", "ViewAllOrders", "Owner", null, new { @class = "btn btn-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n           \r\n        </div>\r\n    </div>\r\n\r\n\r\n\r\n\r\n");
            WriteLiteral("\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DataLayer.Owner> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591