#pragma checksum "C:\Users\ankit_2\source\repos\PartTracking\PartTracking.Mvc\Views\Engineering\PartDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b51785e4a22b0635f589f74793b5dbbf4ac22f03"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Engineering_PartDetails), @"mvc.1.0.view", @"/Views/Engineering/PartDetails.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b51785e4a22b0635f589f74793b5dbbf4ac22f03", @"/Views/Engineering/PartDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5cc372da67165c24d690abe9b6dcf05489173a12", @"/Views/_ViewImports.cshtml")]
    public class Views_Engineering_PartDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PartTracking.Context.Models.DTO.PartMasterPartDetailsView>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\ankit_2\source\repos\PartTracking\PartTracking.Mvc\Views\Engineering\PartDetails.cshtml"
  
    ViewData["Title"] = "Engineering - View Part";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<style>
    .header {
        justify-content: center;
        align-items: center;
        border: 5px solid red;
        padding-top: 5px;
        padding-bottom: 5px;
        padding-left: 5px;
        font-size: x-large;
        text-align: center;
    }
    
    .tableData {
        font-size: x-large;
    }
</style>

<div class=""row"">
    <div class=""col-sm-3"">
    </div>
    <div class=""col-sm-6 header"">
        Engineering - View Part
    </div>
    <div class=""col-sm-3"">
    </div>
</div>

<div class=""tableData"">
    <dl class=""row"">
        <dt class=""col-sm-2"">
            Part Master #
        </dt>
        <dd class=""col-sm-10"">
            ");
#nullable restore
#line 41 "C:\Users\ankit_2\source\repos\PartTracking\PartTracking.Mvc\Views\Engineering\PartDetails.cshtml"
       Write(Html.DisplayFor(model => model.PartMasterId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 44 "C:\Users\ankit_2\source\repos\PartTracking\PartTracking.Mvc\Views\Engineering\PartDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.PartCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 47 "C:\Users\ankit_2\source\repos\PartTracking\PartTracking.Mvc\Views\Engineering\PartDetails.cshtml"
       Write(Html.DisplayFor(model => model.PartCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 50 "C:\Users\ankit_2\source\repos\PartTracking\PartTracking.Mvc\Views\Engineering\PartDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.PartName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 53 "C:\Users\ankit_2\source\repos\PartTracking\PartTracking.Mvc\Views\Engineering\PartDetails.cshtml"
       Write(Html.DisplayFor(model => model.PartName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 56 "C:\Users\ankit_2\source\repos\PartTracking\PartTracking.Mvc\Views\Engineering\PartDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.Quantity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n");
#nullable restore
#line 58 "C:\Users\ankit_2\source\repos\PartTracking\PartTracking.Mvc\Views\Engineering\PartDetails.cshtml"
          
            if (Model.Quantity == null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <dd class=\"col-sm-10\">\r\n                    0\r\n                </dd>\r\n");
#nullable restore
#line 64 "C:\Users\ankit_2\source\repos\PartTracking\PartTracking.Mvc\Views\Engineering\PartDetails.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <dd class=\"col-sm-10\">\r\n                    ");
#nullable restore
#line 68 "C:\Users\ankit_2\source\repos\PartTracking\PartTracking.Mvc\Views\Engineering\PartDetails.cshtml"
               Write(Html.DisplayFor(model => model.Quantity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n");
#nullable restore
#line 70 "C:\Users\ankit_2\source\repos\PartTracking\PartTracking.Mvc\Views\Engineering\PartDetails.cshtml"
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <dt class=\"col-sm-2\">\r\n            Part Detail ##\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 77 "C:\Users\ankit_2\source\repos\PartTracking\PartTracking.Mvc\Views\Engineering\PartDetails.cshtml"
       Write(Html.DisplayFor(model => model.PartDetailId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 80 "C:\Users\ankit_2\source\repos\PartTracking\PartTracking.Mvc\Views\Engineering\PartDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.PartDesc));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 83 "C:\Users\ankit_2\source\repos\PartTracking\PartTracking.Mvc\Views\Engineering\PartDetails.cshtml"
       Write(Html.DisplayFor(model => model.PartDesc));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 86 "C:\Users\ankit_2\source\repos\PartTracking\PartTracking.Mvc\Views\Engineering\PartDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.PartDrgFile));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 89 "C:\Users\ankit_2\source\repos\PartTracking\PartTracking.Mvc\Views\Engineering\PartDetails.cshtml"
       Write(Html.DisplayFor(model => model.PartDrgFile));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div class=\"tableData\">\r\n    ");
#nullable restore
#line 94 "C:\Users\ankit_2\source\repos\PartTracking\PartTracking.Mvc\Views\Engineering\PartDetails.cshtml"
Write(Html.ActionLink("Edit", "PartEdit", new { id = Model.PartMasterId }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b51785e4a22b0635f589f74793b5dbbf4ac22f0310029", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("  \r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PartTracking.Context.Models.DTO.PartMasterPartDetailsView> Html { get; private set; }
    }
}
#pragma warning restore 1591
