#pragma checksum "F:\ASP.NET CORE\ASP_NET_CORE_MANY_TO_MANY_CRUD\ASP_NET_CORE_MANY_TO_MANY_CRUD\Views\Book\BookList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "22522ce8dc3d3d7d3ab86589b95f3e0e129725a3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Book_BookList), @"mvc.1.0.view", @"/Views/Book/BookList.cshtml")]
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
#line 1 "F:\ASP.NET CORE\ASP_NET_CORE_MANY_TO_MANY_CRUD\ASP_NET_CORE_MANY_TO_MANY_CRUD\Views\_ViewImports.cshtml"
using ASP_NET_CORE_MANY_TO_MANY_CRUD;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\ASP.NET CORE\ASP_NET_CORE_MANY_TO_MANY_CRUD\ASP_NET_CORE_MANY_TO_MANY_CRUD\Views\_ViewImports.cshtml"
using ASP_NET_CORE_MANY_TO_MANY_CRUD.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22522ce8dc3d3d7d3ab86589b95f3e0e129725a3", @"/Views/Book/BookList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d106eb88236b851b1b83c44dee971691ac8e1859", @"/Views/_ViewImports.cshtml")]
    public class Views_Book_BookList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ASP_NET_CORE_MANY_TO_MANY_CRUD.Models.Book>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary text-white float-right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "F:\ASP.NET CORE\ASP_NET_CORE_MANY_TO_MANY_CRUD\ASP_NET_CORE_MANY_TO_MANY_CRUD\Views\Book\BookList.cshtml"
  
    ViewData["Title"] = "BookList";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container\">\r\n    <div class=\"row\">\r\n        <div class=\"col-8\">\r\n            <h2>Book List</h2>\r\n        </div>\r\n\r\n        <div class=\"col-4\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "22522ce8dc3d3d7d3ab86589b95f3e0e129725a34366", async() => {
                WriteLiteral("Create New Book");
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
#line 24 "F:\ASP.NET CORE\ASP_NET_CORE_MANY_TO_MANY_CRUD\ASP_NET_CORE_MANY_TO_MANY_CRUD\Views\Book\BookList.cshtml"
                       Write(Html.DisplayNameFor(model => model.BookName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
#nullable restore
#line 27 "F:\ASP.NET CORE\ASP_NET_CORE_MANY_TO_MANY_CRUD\ASP_NET_CORE_MANY_TO_MANY_CRUD\Views\Book\BookList.cshtml"
                       Write(Html.DisplayNameFor(model => model.BookType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                    </tr>\r\n                </thead>\r\n\r\n                <tbody>\r\n");
#nullable restore
#line 33 "F:\ASP.NET CORE\ASP_NET_CORE_MANY_TO_MANY_CRUD\ASP_NET_CORE_MANY_TO_MANY_CRUD\Views\Book\BookList.cshtml"
                     foreach(var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>\r\n                                ");
#nullable restore
#line 37 "F:\ASP.NET CORE\ASP_NET_CORE_MANY_TO_MANY_CRUD\ASP_NET_CORE_MANY_TO_MANY_CRUD\Views\Book\BookList.cshtml"
                           Write(Html.DisplayFor(modelItem => item.BookName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 40 "F:\ASP.NET CORE\ASP_NET_CORE_MANY_TO_MANY_CRUD\ASP_NET_CORE_MANY_TO_MANY_CRUD\Views\Book\BookList.cshtml"
                           Write(Html.DisplayFor(modelItem => item.BookType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 43 "F:\ASP.NET CORE\ASP_NET_CORE_MANY_TO_MANY_CRUD\ASP_NET_CORE_MANY_TO_MANY_CRUD\Views\Book\BookList.cshtml"
                           Write(Html.ActionLink("Edit","Edit",new {id=item.BookId }, new { @class = "btn btn-info"}));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                                ");
#nullable restore
#line 44 "F:\ASP.NET CORE\ASP_NET_CORE_MANY_TO_MANY_CRUD\ASP_NET_CORE_MANY_TO_MANY_CRUD\Views\Book\BookList.cshtml"
                           Write(Html.ActionLink("Detele", "Detele", new {id = item.BookId }, new { @class = "btn btn-danger", onclick = "return confirm(''Do you want to delete')" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
            WriteLiteral("\r\n                            </td>\r\n\r\n                        </tr>\r\n");
#nullable restore
#line 48 "F:\ASP.NET CORE\ASP_NET_CORE_MANY_TO_MANY_CRUD\ASP_NET_CORE_MANY_TO_MANY_CRUD\Views\Book\BookList.cshtml"

                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ASP_NET_CORE_MANY_TO_MANY_CRUD.Models.Book>> Html { get; private set; }
    }
}
#pragma warning restore 1591
