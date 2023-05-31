#pragma checksum "C:\after\GloboTicket.Client\Views\Order\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3d14adbb6b3bc7cb85a2815fde66332f14981046"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_Detail), @"mvc.1.0.view", @"/Views/Order/Detail.cshtml")]
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
#line 2 "C:\after\GloboTicket.Client\Views\_ViewImports.cshtml"
using GloboTicket.Web.Models.View;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3d14adbb6b3bc7cb85a2815fde66332f14981046", @"/Views/Order/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"03ed58786824169b4ed40dade632d67648d57ee4", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GloboTicket.Web.Models.Api.Order>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h2>Your Order</h2>\r\n\r\n");
#nullable restore
#line 5 "C:\after\GloboTicket.Client\Views\Order\Detail.cshtml"
 if (Model.Message != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h4 class=\"boldRed\">");
#nullable restore
#line 7 "C:\after\GloboTicket.Client\Views\Order\Detail.cshtml"
                   Write(Model.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>    \r\n");
#nullable restore
#line 8 "C:\after\GloboTicket.Client\Views\Order\Detail.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h4>Here are the events for your order.</h4>\r\n<br/>\r\n<div class=\"container\">\r\n    <div class=\"row\">\r\n        <div class=\"col-md\">\r\n            <h5>Order Date: <span class=\"bold\">");
#nullable restore
#line 15 "C:\after\GloboTicket.Client\Views\Order\Detail.cshtml"
                                          Write(Model.OrderPlaced.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("<span/></h5>\r\n        </div>\r\n        <div class=\"col-md\">\r\n            <h5>Order Total: <span class=\"bold\">$");
#nullable restore
#line 18 "C:\after\GloboTicket.Client\Views\Order\Detail.cshtml"
                                            Write(Model.OrderTotal);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></h5>\r\n        </div>\r\n        <div class=\"col-md\">\r\n            <h5>Order Paid: <span class=\"bold\">");
#nullable restore
#line 21 "C:\after\GloboTicket.Client\Views\Order\Detail.cshtml"
                                          Write(Model.OrderPaid);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></h5>\r\n        </div>\r\n    </div>\r\n</div>\r\n<br/>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr class=\"columnHeader text-center\">\r\n            <th>EVENT NAME</th>\r\n            <th>DATE</th>\r\n");
#nullable restore
#line 31 "C:\after\GloboTicket.Client\Views\Order\Detail.cshtml"
             if (Model.Message != null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <th>Message</th>\r\n");
#nullable restore
#line 34 "C:\after\GloboTicket.Client\Views\Order\Detail.cshtml"

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <th>QUANTITY</th>\r\n            <th>VENUE</th>\r\n            <th>CITY</th>\r\n            <th>COUNTRY</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 43 "C:\after\GloboTicket.Client\Views\Order\Detail.cshtml"
         foreach (var line in Model.OrderLines)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr class=\"text-center\">\r\n            <td>");
#nullable restore
#line 46 "C:\after\GloboTicket.Client\Views\Order\Detail.cshtml"
           Write(line.EventName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 47 "C:\after\GloboTicket.Client\Views\Order\Detail.cshtml"
           Write(line.EventDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 48 "C:\after\GloboTicket.Client\Views\Order\Detail.cshtml"
             if (Model.Message != null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td class=\"boldRed\">");
#nullable restore
#line 50 "C:\after\GloboTicket.Client\Views\Order\Detail.cshtml"
                               Write(line.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 51 "C:\after\GloboTicket.Client\Views\Order\Detail.cshtml"

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <td>");
#nullable restore
#line 53 "C:\after\GloboTicket.Client\Views\Order\Detail.cshtml"
           Write(line.TicketAmount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 54 "C:\after\GloboTicket.Client\Views\Order\Detail.cshtml"
           Write(line.VenueName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 55 "C:\after\GloboTicket.Client\Views\Order\Detail.cshtml"
           Write(line.VenueCity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 56 "C:\after\GloboTicket.Client\Views\Order\Detail.cshtml"
           Write(line.VenueCountry);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 58 "C:\after\GloboTicket.Client\Views\Order\Detail.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GloboTicket.Web.Models.Api.Order> Html { get; private set; }
    }
}
#pragma warning restore 1591