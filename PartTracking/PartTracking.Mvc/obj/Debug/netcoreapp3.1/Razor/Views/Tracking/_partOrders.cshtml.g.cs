#pragma checksum "C:\Users\ankit_2\source\repos\PartTracking\PartTracking.Mvc\Views\Tracking\_partOrders.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dd4cd778b7b0411f3b50cdde295911b850056355"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tracking__partOrders), @"mvc.1.0.view", @"/Views/Tracking/_partOrders.cshtml")]
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
#line 1 "C:\Users\ankit_2\source\repos\PartTracking\PartTracking.Mvc\Views\_ViewImports.cshtml"
using PartTracking.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ankit_2\source\repos\PartTracking\PartTracking.Mvc\Views\_ViewImports.cshtml"
using PartTracking.Mvc.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ankit_2\source\repos\PartTracking\PartTracking.Mvc\Views\_ViewImports.cshtml"
using PartTracking.Context.Models.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ankit_2\source\repos\PartTracking\PartTracking.Mvc\Views\Tracking\_partOrders.cshtml"
using PartTracking.Context.Models.DTO;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd4cd778b7b0411f3b50cdde295911b850056355", @"/Views/Tracking/_partOrders.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5cc372da67165c24d690abe9b6dcf05489173a12", @"/Views/_ViewImports.cshtml")]
    public class Views_Tracking__partOrders : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PartTracking.Context.Models.DTO.PartTrackingData>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<style>\r\n    .data {\r\n        color: red;\r\n        font-size: xx-large;\r\n    }\r\n\r\n    .label {\r\n        font-size: xx-large;\r\n    }\r\n</style>\r\n\r\n<p></p>\r\n");
#nullable restore
#line 16 "C:\Users\ankit_2\source\repos\PartTracking\PartTracking.Mvc\Views\Tracking\_partOrders.cshtml"
 if (TempData["Exception"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"container response\">\r\n        <h3>Error : ");
#nullable restore
#line 19 "C:\Users\ankit_2\source\repos\PartTracking\PartTracking.Mvc\Views\Tracking\_partOrders.cshtml"
               Write(TempData["Exception"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n    </div>\r\n");
#nullable restore
#line 21 "C:\Users\ankit_2\source\repos\PartTracking\PartTracking.Mvc\Views\Tracking\_partOrders.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<p></p>\r\n\r\n<div>\r\n    <h4>Part - Data</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 29 "C:\Users\ankit_2\source\repos\PartTracking\PartTracking.Mvc\Views\Tracking\_partOrders.cshtml"
       Write(Html.DisplayNameFor(model => model.PartMasterId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 32 "C:\Users\ankit_2\source\repos\PartTracking\PartTracking.Mvc\Views\Tracking\_partOrders.cshtml"
       Write(Html.DisplayFor(model => model.PartMasterId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2 label\">\r\n            ");
#nullable restore
#line 35 "C:\Users\ankit_2\source\repos\PartTracking\PartTracking.Mvc\Views\Tracking\_partOrders.cshtml"
       Write(Html.DisplayNameFor(model => model.Part));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10 data\">\r\n            ");
#nullable restore
#line 38 "C:\Users\ankit_2\source\repos\PartTracking\PartTracking.Mvc\Views\Tracking\_partOrders.cshtml"
       Write(Html.DisplayFor(model => model.Part));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2 label\">\r\n            QTY\r\n        </dt>\r\n        <dd class=\"col-sm-10 data\">\r\n            ");
#nullable restore
#line 44 "C:\Users\ankit_2\source\repos\PartTracking\PartTracking.Mvc\Views\Tracking\_partOrders.cshtml"
       Write(Html.DisplayFor(model => model.Quantity));

#line default
#line hidden
#nullable disable
            WriteLiteral("  ");
            WriteLiteral("@WareHouse\r\n        </dd>\r\n    </dl>\r\n</div>\r\n\r\n<!-- part - orders data -->\r\n<div>\r\n    <h4>Part Orders - Data</h4>\r\n    <hr />\r\n\r\n");
#nullable restore
#line 54 "C:\Users\ankit_2\source\repos\PartTracking\PartTracking.Mvc\Views\Tracking\_partOrders.cshtml"
     if (Model.Orders.Count() > 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <table class=""table"">
            <thead>
                <tr>
                    <th>
                        Order #
                    </th>
                    <th>
                        Order QTY
                    </th>
                    <th>
                        Order Date
                    </th>
                    <th>
                        Status
                    </th>
                    <th>
                        #REF#
                    </th>
                    <th></th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 78 "C:\Users\ankit_2\source\repos\PartTracking\PartTracking.Mvc\Views\Tracking\_partOrders.cshtml"
                 foreach (var item in Model.Orders)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
#nullable restore
#line 82 "C:\Users\ankit_2\source\repos\PartTracking\PartTracking.Mvc\Views\Tracking\_partOrders.cshtml"
                       Write(item.OrderMasterId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 85 "C:\Users\ankit_2\source\repos\PartTracking\PartTracking.Mvc\Views\Tracking\_partOrders.cshtml"
                       Write(item.OrderQuantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 88 "C:\Users\ankit_2\source\repos\PartTracking\PartTracking.Mvc\Views\Tracking\_partOrders.cshtml"
                       Write(item.OrderDate.ToString("dd MMM yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n");
#nullable restore
#line 90 "C:\Users\ankit_2\source\repos\PartTracking\PartTracking.Mvc\Views\Tracking\_partOrders.cshtml"
                          
                            string orderStatus = "";
                            int value = (int)item.OrderStatus;
                            if (Enum.IsDefined(typeof(OrderStatusType), value))
                                orderStatus = ((OrderStatusType)value).ToString();
                            else
                                orderStatus = "N/A";

                            if (value == 0)
                            {
                                // Confirmed

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <td style=\"color:green;font-size:large;\">\r\n                                    ");
#nullable restore
#line 102 "C:\Users\ankit_2\source\repos\PartTracking\PartTracking.Mvc\Views\Tracking\_partOrders.cshtml"
                               Write(orderStatus);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n");
#nullable restore
#line 104 "C:\Users\ankit_2\source\repos\PartTracking\PartTracking.Mvc\Views\Tracking\_partOrders.cshtml"
                            }
                            else if (value == 1)
                            {
                                // Received

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <td style=\"color:red; font-size:large;\">\r\n                                    ");
#nullable restore
#line 109 "C:\Users\ankit_2\source\repos\PartTracking\PartTracking.Mvc\Views\Tracking\_partOrders.cshtml"
                               Write(orderStatus);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n");
#nullable restore
#line 111 "C:\Users\ankit_2\source\repos\PartTracking\PartTracking.Mvc\Views\Tracking\_partOrders.cshtml"
                            }
                            else
                            {
                                // Half_Received

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <td style=\"color:blue; font-size:large;\">\r\n                                    ");
#nullable restore
#line 116 "C:\Users\ankit_2\source\repos\PartTracking\PartTracking.Mvc\Views\Tracking\_partOrders.cshtml"
                               Write(orderStatus);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n");
#nullable restore
#line 118 "C:\Users\ankit_2\source\repos\PartTracking\PartTracking.Mvc\Views\Tracking\_partOrders.cshtml"
                            }
                        

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td>\r\n                            ");
#nullable restore
#line 121 "C:\Users\ankit_2\source\repos\PartTracking\PartTracking.Mvc\Views\Tracking\_partOrders.cshtml"
                       Write(item.RefCode);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            <a class=\"btn btn-primary receivingDetails\"\r\n                               data-id=\"");
#nullable restore
#line 125 "C:\Users\ankit_2\source\repos\PartTracking\PartTracking.Mvc\Views\Tracking\_partOrders.cshtml"
                                   Write(item.OrderMasterId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"\r\n                               href=\"javascript:void(0)\">Track Receiving!</a>\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 129 "C:\Users\ankit_2\source\repos\PartTracking\PartTracking.Mvc\Views\Tracking\_partOrders.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n");
#nullable restore
#line 132 "C:\Users\ankit_2\source\repos\PartTracking\PartTracking.Mvc\Views\Tracking\_partOrders.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p></p>\r\n        <div class=\"container\" style=\"color:red; font-size:xx-large;\">\r\n            Orders NOT Found!\r\n        </div>\r\n        <p></p>\r\n");
#nullable restore
#line 140 "C:\Users\ankit_2\source\repos\PartTracking\PartTracking.Mvc\Views\Tracking\_partOrders.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>

<!-- part-orders partial view -->
<div id=""partReceiving"">
</div>


<script type=""text/javascript"">

    $("".receivingDetails"").click(function () {

        var obj = {};
        obj.Id = $(this).attr('data-id');

        $.ajax({
            type: ""Get"", //Method type
            url: ""/Tracking/GetReceivingDetailsByOrder?Id="" + obj.Id, //url to load partial view
            data: JSON.stringify(obj.Id),
            contentType: ""application/json; charset=utf-8"",
            dataType: ""html"",
            success: function (response) {
                console.log(response);
                $('#partReceiving').html(response);
            },
            failure: function (response) {

            },
            error: function (response) {

            }
        });
    });

</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PartTracking.Context.Models.DTO.PartTrackingData> Html { get; private set; }
    }
}
#pragma warning restore 1591
