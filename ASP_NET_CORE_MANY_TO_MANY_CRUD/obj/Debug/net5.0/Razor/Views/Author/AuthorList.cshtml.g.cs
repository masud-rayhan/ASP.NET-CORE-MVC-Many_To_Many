#pragma checksum "F:\ASP_NET_CORE_MANY_TO_MANY_CRUD\ASP_NET_CORE_MANY_TO_MANY_CRUD\Views\Author\AuthorList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "feadbebaf6a41b85cbd4a87713bbc139350003e3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Author_AuthorList), @"mvc.1.0.view", @"/Views/Author/AuthorList.cshtml")]
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
#line 1 "F:\ASP_NET_CORE_MANY_TO_MANY_CRUD\ASP_NET_CORE_MANY_TO_MANY_CRUD\Views\_ViewImports.cshtml"
using ASP_NET_CORE_MANY_TO_MANY_CRUD;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\ASP_NET_CORE_MANY_TO_MANY_CRUD\ASP_NET_CORE_MANY_TO_MANY_CRUD\Views\_ViewImports.cshtml"
using ASP_NET_CORE_MANY_TO_MANY_CRUD.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"feadbebaf6a41b85cbd4a87713bbc139350003e3", @"/Views/Author/AuthorList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d106eb88236b851b1b83c44dee971691ac8e1859", @"/Views/_ViewImports.cshtml")]
    public class Views_Author_AuthorList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ASP_NET_CORE_MANY_TO_MANY_CRUD.Models.Author>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success text-white float-right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "F:\ASP_NET_CORE_MANY_TO_MANY_CRUD\ASP_NET_CORE_MANY_TO_MANY_CRUD\Views\Author\AuthorList.cshtml"
  
    ViewData["Title"] = "AuthorList";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container\">\r\n    <div class=\"row\">\r\n        <div class=\"col-8\">\r\n            <h2>Author List</h2>\r\n        </div>\r\n        <div class=\"col-4\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "feadbebaf6a41b85cbd4a87713bbc139350003e34340", async() => {
                WriteLiteral("Create New Author");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"row\">\r\n        <div class=\"col\">\r\n            <table class=\"table table-striped border\">\r\n                <thead>\r\n                    <tr>\r\n                        <th>\r\n                            ");
#nullable restore
#line 23 "F:\ASP_NET_CORE_MANY_TO_MANY_CRUD\ASP_NET_CORE_MANY_TO_MANY_CRUD\Views\Author\AuthorList.cshtml"
                       Write(Html.DisplayNameFor(model=>model.AuthorName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
#nullable restore
#line 26 "F:\ASP_NET_CORE_MANY_TO_MANY_CRUD\ASP_NET_CORE_MANY_TO_MANY_CRUD\Views\Author\AuthorList.cshtml"
                       Write(Html.DisplayNameFor(model => model.Mail));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                    </tr>\r\n                </thead>\r\n\r\n                <tbody>\r\n");
#nullable restore
#line 32 "F:\ASP_NET_CORE_MANY_TO_MANY_CRUD\ASP_NET_CORE_MANY_TO_MANY_CRUD\Views\Author\AuthorList.cshtml"
                     foreach(var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>\r\n                                ");
#nullable restore
#line 36 "F:\ASP_NET_CORE_MANY_TO_MANY_CRUD\ASP_NET_CORE_MANY_TO_MANY_CRUD\Views\Author\AuthorList.cshtml"
                           Write(Html.DisplayFor(modelItem => item.AuthorName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 39 "F:\ASP_NET_CORE_MANY_TO_MANY_CRUD\ASP_NET_CORE_MANY_TO_MANY_CRUD\Views\Author\AuthorList.cshtml"
                           Write(Html.DisplayFor(modelItem=> item.Mail));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 42 "F:\ASP_NET_CORE_MANY_TO_MANY_CRUD\ASP_NET_CORE_MANY_TO_MANY_CRUD\Views\Author\AuthorList.cshtml"
                           Write(Html.ActionLink("Edit","Edit",new { id=item.AuthorId}, new { @class = "btn btn-info"}));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                                ");
#nullable restore
#line 43 "F:\ASP_NET_CORE_MANY_TO_MANY_CRUD\ASP_NET_CORE_MANY_TO_MANY_CRUD\Views\Author\AuthorList.cshtml"
                           Write(Html.ActionLink("Detele","Detele",new { id=item.AuthorId}, new { @class = "btn btn-danger", onclick = "return confirm(''Do you want to delete')" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 46 "F:\ASP_NET_CORE_MANY_TO_MANY_CRUD\ASP_NET_CORE_MANY_TO_MANY_CRUD\Views\Author\AuthorList.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ASP_NET_CORE_MANY_TO_MANY_CRUD.Models.Author>> Html { get; private set; }
    }
}
#pragma warning restore 1591
