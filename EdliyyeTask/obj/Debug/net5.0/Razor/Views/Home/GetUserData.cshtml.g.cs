#pragma checksum "C:\Users\MSI-PC\source\repos\EdliyyeTask\EdliyyeTask\Views\Home\GetUserData.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e3f0c256e35ce31b981c9219e95a597d4309235b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_GetUserData), @"mvc.1.0.view", @"/Views/Home/GetUserData.cshtml")]
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
#line 1 "C:\Users\MSI-PC\source\repos\EdliyyeTask\EdliyyeTask\Views\_ViewImports.cshtml"
using EdliyyeTask;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\MSI-PC\source\repos\EdliyyeTask\EdliyyeTask\Views\_ViewImports.cshtml"
using EdliyyeTask.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\MSI-PC\source\repos\EdliyyeTask\EdliyyeTask\Views\Home\GetUserData.cshtml"
using Microsoft.CodeAnalysis.CSharp.Syntax;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e3f0c256e35ce31b981c9219e95a597d4309235b", @"/Views/Home/GetUserData.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e21c052d7fbe9d57d97225d59bf41e66f38da0b2", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_GetUserData : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<JsonObjectsViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-target", new global::Microsoft.AspNetCore.Html.HtmlString("#loginModal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-toggle", new global::Microsoft.AspNetCore.Html.HtmlString("modal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n\r\n");
#nullable restore
#line 6 "C:\Users\MSI-PC\source\repos\EdliyyeTask\EdliyyeTask\Views\Home\GetUserData.cshtml"
  
    ViewData["Title"] = "GetUserData";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Posts</h1>


<table class=""table"" id=""myTable"">
    <thead>
    <tr>
        <th scope=""col"">ID</th>
        <th scope=""col"">Title</th>
        <th scope=""col"">Content</th>
        <th scope=""col"">UserId</th>
        <th scope=""col"">Comments</th>
       
    </tr>
    </thead>
    
    <tbody>
 
");
#nullable restore
#line 27 "C:\Users\MSI-PC\source\repos\EdliyyeTask\EdliyyeTask\Views\Home\GetUserData.cshtml"
     foreach (var item in Model.userPosts)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 30 "C:\Users\MSI-PC\source\repos\EdliyyeTask\EdliyyeTask\Views\Home\GetUserData.cshtml"
           Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 31 "C:\Users\MSI-PC\source\repos\EdliyyeTask\EdliyyeTask\Views\Home\GetUserData.cshtml"
           Write(item.Body);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 32 "C:\Users\MSI-PC\source\repos\EdliyyeTask\EdliyyeTask\Views\Home\GetUserData.cshtml"
           Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 33 "C:\Users\MSI-PC\source\repos\EdliyyeTask\EdliyyeTask\Views\Home\GetUserData.cshtml"
           Write(item.UserId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n         \r\n            \r\n            <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e3f0c256e35ce31b981c9219e95a597d4309235b6211", async() => {
                WriteLiteral("Comments");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 36 "C:\Users\MSI-PC\source\repos\EdliyyeTask\EdliyyeTask\Views\Home\GetUserData.cshtml"
                                                                                      WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n            \r\n        </tr>\r\n");
#nullable restore
#line 39 "C:\Users\MSI-PC\source\repos\EdliyyeTask\EdliyyeTask\Views\Home\GetUserData.cshtml"
   
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("  \r\n  \r\n    </tbody>\r\n</table>\r\n\r\n\r\n");
            WriteLiteral(@"<div class=""modal fade"" tabindex=""-1"" id=""loginModal""
     data-keyboard=""false"" data-backdrop=""static"">
    <div class=""modal-dialog modal-lg"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h3>Modal</h3>
                <button type=""button"" class=""close"" data-dismiss=""modal"">
                    &times;
                </button>

            </div>
            <div class=""modal-body"">
                <table class=""table"" id=""myTable"">
                    <thead>
                    <tr>
                        <th scope=""col"">ID</th>
                        <th scope=""col"">PostId</th>
                        <th scope=""col"">Name</th>
                        <th scope=""col"">Email</th>
                        <th scope=""col"">Body</th>
                        
       
                    </tr>
                    </thead>
    
                    <tbody>
                   
");
#nullable restore
#line 75 "C:\Users\MSI-PC\source\repos\EdliyyeTask\EdliyyeTask\Views\Home\GetUserData.cshtml"
                         foreach (var item in Model.userComments.Where(x=>x.PostId==Model.userPosts[0].Id))
                        {


#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>");
#nullable restore
#line 79 "C:\Users\MSI-PC\source\repos\EdliyyeTask\EdliyyeTask\Views\Home\GetUserData.cshtml"
                               Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 80 "C:\Users\MSI-PC\source\repos\EdliyyeTask\EdliyyeTask\Views\Home\GetUserData.cshtml"
                               Write(item.PostId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 81 "C:\Users\MSI-PC\source\repos\EdliyyeTask\EdliyyeTask\Views\Home\GetUserData.cshtml"
                               Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 82 "C:\Users\MSI-PC\source\repos\EdliyyeTask\EdliyyeTask\Views\Home\GetUserData.cshtml"
                               Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 83 "C:\Users\MSI-PC\source\repos\EdliyyeTask\EdliyyeTask\Views\Home\GetUserData.cshtml"
                               Write(item.Body);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n\r\n                            </tr>\r\n");
#nullable restore
#line 87 "C:\Users\MSI-PC\source\repos\EdliyyeTask\EdliyyeTask\Views\Home\GetUserData.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    
                   

                    </tbody>
                </table>
            </div>
            <div class=""modal-footer"">
            
                <button type=""button"" class=""btn btn-primary""
                        data-dismiss=""modal"">
                    Close
                </button>
            </div>
        </div>
    </div>
</div>


");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<JsonObjectsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
