#pragma checksum "C:\Users\Amit-pc\Desktop\JayeshFol\CustOrder\CustOrderWebApp\Views\Owner\ViewAllOrders.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fa827dd2877eeaef12b0194a93246ae4dfb8d4d7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Owner_ViewAllOrders), @"mvc.1.0.view", @"/Views/Owner/ViewAllOrders.cshtml")]
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
#nullable restore
#line 1 "C:\Users\Amit-pc\Desktop\JayeshFol\CustOrder\CustOrderWebApp\Views\Owner\ViewAllOrders.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Amit-pc\Desktop\JayeshFol\CustOrder\CustOrderWebApp\Views\Owner\ViewAllOrders.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Amit-pc\Desktop\JayeshFol\CustOrder\CustOrderWebApp\Views\Owner\ViewAllOrders.cshtml"
using X.PagedList.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Amit-pc\Desktop\JayeshFol\CustOrder\CustOrderWebApp\Views\Owner\ViewAllOrders.cshtml"
using X.PagedList.Web.Common;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fa827dd2877eeaef12b0194a93246ae4dfb8d4d7", @"/Views/Owner/ViewAllOrders.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"50affc7c26f233b922ff8b995182b11407a19c68", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Owner_ViewAllOrders : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IPagedList<DataLayer.Order>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\Amit-pc\Desktop\JayeshFol\CustOrder\CustOrderWebApp\Views\Owner\ViewAllOrders.cshtml"
  
    ViewData["Title"] = "ViewAllOrders";
    Layout = "~/Views/Owner/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container\">\r\n\r\n    <p> <b> View All Orders </b>  </p>\r\n    <table class=\"table table-striped table-dark p-lg-5\">\r\n        <thead class=\"p-5\">\r\n\r\n\r\n            <tr>\r\n                <th> ");
#nullable restore
#line 20 "C:\Users\Amit-pc\Desktop\JayeshFol\CustOrder\CustOrderWebApp\Views\Owner\ViewAllOrders.cshtml"
                Write(Html.DisplayName("Customer ID"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th> ");
#nullable restore
#line 21 "C:\Users\Amit-pc\Desktop\JayeshFol\CustOrder\CustOrderWebApp\Views\Owner\ViewAllOrders.cshtml"
                Write(Html.DisplayName("Items"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th> ");
#nullable restore
#line 22 "C:\Users\Amit-pc\Desktop\JayeshFol\CustOrder\CustOrderWebApp\Views\Owner\ViewAllOrders.cshtml"
                Write(Html.DisplayName("Order Date"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th> ");
#nullable restore
#line 23 "C:\Users\Amit-pc\Desktop\JayeshFol\CustOrder\CustOrderWebApp\Views\Owner\ViewAllOrders.cshtml"
                Write(Html.DisplayName("Shipment Date"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th> ");
#nullable restore
#line 24 "C:\Users\Amit-pc\Desktop\JayeshFol\CustOrder\CustOrderWebApp\Views\Owner\ViewAllOrders.cshtml"
                Write(Html.DisplayName("Delete Order"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n\r\n            </tr>\r\n        </thead>\r\n\r\n\r\n");
#nullable restore
#line 30 "C:\Users\Amit-pc\Desktop\JayeshFol\CustOrder\CustOrderWebApp\Views\Owner\ViewAllOrders.cshtml"
         foreach (var order in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tbody>\r\n                <tr>\r\n\r\n");
            WriteLiteral("                    <td>");
#nullable restore
#line 36 "C:\Users\Amit-pc\Desktop\JayeshFol\CustOrder\CustOrderWebApp\Views\Owner\ViewAllOrders.cshtml"
                   Write(Html.DisplayFor(m => order.CustomerID));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 37 "C:\Users\Amit-pc\Desktop\JayeshFol\CustOrder\CustOrderWebApp\Views\Owner\ViewAllOrders.cshtml"
                   Write(Html.DisplayFor(m => order.Items));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td> ");
#nullable restore
#line 38 "C:\Users\Amit-pc\Desktop\JayeshFol\CustOrder\CustOrderWebApp\Views\Owner\ViewAllOrders.cshtml"
                    Write(Html.DisplayFor(m => order.OrderDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td> ");
#nullable restore
#line 39 "C:\Users\Amit-pc\Desktop\JayeshFol\CustOrder\CustOrderWebApp\Views\Owner\ViewAllOrders.cshtml"
                    Write(Html.DisplayFor(m => order.ShipmentDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>  ");
#nullable restore
#line 40 "C:\Users\Amit-pc\Desktop\JayeshFol\CustOrder\CustOrderWebApp\Views\Owner\ViewAllOrders.cshtml"
                     Write(Html.ActionLink("Delete", "DeleteOrder", "Owner", new { orderID = order.ID }, new { @class = "btn btn-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n\r\n                </tr>\r\n            </tbody>\r\n");
#nullable restore
#line 44 "C:\Users\Amit-pc\Desktop\JayeshFol\CustOrder\CustOrderWebApp\Views\Owner\ViewAllOrders.cshtml"

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n\r\n");
            WriteLiteral("\r\n\r\n    ");
#nullable restore
#line 51 "C:\Users\Amit-pc\Desktop\JayeshFol\CustOrder\CustOrderWebApp\Views\Owner\ViewAllOrders.cshtml"
Write(Html.PagedListPager((IPagedList)Model, page => Url.Action("ViewAllOrders", new { page }), new PagedListRenderOptions
        {
            LiElementClasses = new string[] { "page-item" },
            PageClasses = new string[] { "page-link" }
        }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n  \r\n\r\n\r\n\r\n\r\n");
#nullable restore
#line 62 "C:\Users\Amit-pc\Desktop\JayeshFol\CustOrder\CustOrderWebApp\Views\Owner\ViewAllOrders.cshtml"
     foreach (var order in Model)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 64 "C:\Users\Amit-pc\Desktop\JayeshFol\CustOrder\CustOrderWebApp\Views\Owner\ViewAllOrders.cshtml"
   Write(Html.ActionLink("Back", "OwnerloggedIn", "Owner", new { id = order.CustomerID }, new { @class = "btn btn-dark" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 64 "C:\Users\Amit-pc\Desktop\JayeshFol\CustOrder\CustOrderWebApp\Views\Owner\ViewAllOrders.cshtml"
                                                                                                                          
        break;
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IPagedList<DataLayer.Order>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
