#pragma checksum "/Users/joshbrown/Desktop/IS Core/IS 413/Bookstore/Bookstore/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "de16f012b220844e77c119b165f5d87a71b6443b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 3 "/Users/joshbrown/Desktop/IS Core/IS 413/Bookstore/Bookstore/Views/_ViewImports.cshtml"
using Bookstore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/joshbrown/Desktop/IS Core/IS 413/Bookstore/Bookstore/Views/_ViewImports.cshtml"
using Bookstore.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/joshbrown/Desktop/IS Core/IS 413/Bookstore/Bookstore/Views/_ViewImports.cshtml"
using Bookstore.Models.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"de16f012b220844e77c119b165f5d87a71b6443b", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"841659c14ce4798898c7bf155f9f793c550faca1", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BooksViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("page-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Bookstore.Infrastructure.PaginationTagHelper __Bookstore_Infrastructure_PaginationTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/joshbrown/Desktop/IS Core/IS 413/Bookstore/Bookstore/Views/Home/Index.cshtml"
  
    ViewData["Title"] = "Catalog";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            WriteLiteral("\n<div class=\"container\">\n    <h1 class=\"text-center my-4\">Book Catalog</h1>\n\n");
#nullable restore
#line 10 "/Users/joshbrown/Desktop/IS Core/IS 413/Bookstore/Bookstore/Views/Home/Index.cshtml"
     foreach (Book book in Model.Books)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"card my-2 p-2\">\n            <div class=\"row align-items-center\">\n                <div class=\"col-6 px-5\">\n                    <h2 class=\"card-title\">");
#nullable restore
#line 15 "/Users/joshbrown/Desktop/IS Core/IS 413/Bookstore/Bookstore/Views/Home/Index.cshtml"
                                      Write(book.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\n                    <h5 class=\"card-subtitle text-muted\">");
#nullable restore
#line 16 "/Users/joshbrown/Desktop/IS Core/IS 413/Bookstore/Bookstore/Views/Home/Index.cshtml"
                                                    Write(book.Author);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n                </div>\n                <div class=\"col\">\n                    <h6>Publisher: ");
#nullable restore
#line 19 "/Users/joshbrown/Desktop/IS Core/IS 413/Bookstore/Bookstore/Views/Home/Index.cshtml"
                              Write(book.Publisher);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\n                    <h6>ISBN: ");
#nullable restore
#line 20 "/Users/joshbrown/Desktop/IS Core/IS 413/Bookstore/Bookstore/Views/Home/Index.cshtml"
                         Write(book.Isbn);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\n                    <h6>Classification: ");
#nullable restore
#line 21 "/Users/joshbrown/Desktop/IS Core/IS 413/Bookstore/Bookstore/Views/Home/Index.cshtml"
                                   Write(book.Classification);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\n                    <h6>Number of Pages: ");
#nullable restore
#line 22 "/Users/joshbrown/Desktop/IS Core/IS 413/Bookstore/Bookstore/Views/Home/Index.cshtml"
                                    Write(book.PageCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\n                    <h6>Price: $");
#nullable restore
#line 23 "/Users/joshbrown/Desktop/IS Core/IS 413/Bookstore/Bookstore/Views/Home/Index.cshtml"
                           Write(book.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\n                </div>\n            </div>\n        </div>\n");
#nullable restore
#line 27 "/Users/joshbrown/Desktop/IS Core/IS 413/Bookstore/Bookstore/Views/Home/Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n<div class=\"container\">\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "de16f012b220844e77c119b165f5d87a71b6443b6589", async() => {
            }
            );
            __Bookstore_Infrastructure_PaginationTagHelper = CreateTagHelper<global::Bookstore.Infrastructure.PaginationTagHelper>();
            __tagHelperExecutionContext.Add(__Bookstore_Infrastructure_PaginationTagHelper);
#nullable restore
#line 30 "/Users/joshbrown/Desktop/IS Core/IS 413/Bookstore/Bookstore/Views/Home/Index.cshtml"
__Bookstore_Infrastructure_PaginationTagHelper.PageNav = Model.PageInfo;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("page-nav", __Bookstore_Infrastructure_PaginationTagHelper.PageNav, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Bookstore_Infrastructure_PaginationTagHelper.PageAction = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BooksViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591