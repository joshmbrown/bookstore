#pragma checksum "/Users/joshbrown/Desktop/IS Core/IS 413/Bookstore/Bookstore/Views/Shared/BookSummary.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ee9ee9b65d6c666affac5d1ce9cce74d4d6e3a91"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_BookSummary), @"mvc.1.0.view", @"/Views/Shared/BookSummary.cshtml")]
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
#nullable restore
#line 6 "/Users/joshbrown/Desktop/IS Core/IS 413/Bookstore/Bookstore/Views/_ViewImports.cshtml"
using Bookstore.Infrastructure;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/joshbrown/Desktop/IS Core/IS 413/Bookstore/Bookstore/Views/_ViewImports.cshtml"
using System.Globalization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/joshbrown/Desktop/IS Core/IS 413/Bookstore/Bookstore/Views/_ViewImports.cshtml"
using System.Threading;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ee9ee9b65d6c666affac5d1ce9cce74d4d6e3a91", @"/Views/Shared/BookSummary.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ee7fb15eb58b56b538c121efd167f7d7ca689e7a", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_BookSummary : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Book>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/cart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
            WriteLiteral("\n");
            WriteLiteral("\n<div class=\"card my-2 p-2\">\n    <div class=\"row align-items-center\">\n        <div class=\"col-6 px-5\">\n            <h2 class=\"card-title\">");
#nullable restore
#line 10 "/Users/joshbrown/Desktop/IS Core/IS 413/Bookstore/Bookstore/Views/Shared/BookSummary.cshtml"
                              Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\n            <h5 class=\"card-subtitle text-muted\">");
#nullable restore
#line 11 "/Users/joshbrown/Desktop/IS Core/IS 413/Bookstore/Bookstore/Views/Shared/BookSummary.cshtml"
                                            Write(Model.Author);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n        </div>\n        <div class=\"col\">\n            <h6>Publisher: ");
#nullable restore
#line 14 "/Users/joshbrown/Desktop/IS Core/IS 413/Bookstore/Bookstore/Views/Shared/BookSummary.cshtml"
                      Write(Model.Publisher);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\n            <h6>ISBN: ");
#nullable restore
#line 15 "/Users/joshbrown/Desktop/IS Core/IS 413/Bookstore/Bookstore/Views/Shared/BookSummary.cshtml"
                 Write(Model.Isbn);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\n            <h6>Classification: ");
#nullable restore
#line 16 "/Users/joshbrown/Desktop/IS Core/IS 413/Bookstore/Bookstore/Views/Shared/BookSummary.cshtml"
                           Write(Model.Classification);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\n            <h6>Number of Pages: ");
#nullable restore
#line 17 "/Users/joshbrown/Desktop/IS Core/IS 413/Bookstore/Bookstore/Views/Shared/BookSummary.cshtml"
                            Write(Model.PageCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\n            <h6>Price: $");
#nullable restore
#line 18 "/Users/joshbrown/Desktop/IS Core/IS 413/Bookstore/Bookstore/Views/Shared/BookSummary.cshtml"
                   Write(Model.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\n        </div>\n        <div class=\"col-2\">\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ee9ee9b65d6c666affac5d1ce9cce74d4d6e3a917254", async() => {
                WriteLiteral("\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ee9ee9b65d6c666affac5d1ce9cce74d4d6e3a917524", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 22 "/Users/joshbrown/Desktop/IS Core/IS 413/Bookstore/Bookstore/Views/Shared/BookSummary.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.BookId);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                <input type=\"hidden\" name=\"returnURL\"");
                BeginWriteAttribute("value", " value=\"", 738, "\"", 793, 1);
#nullable restore
#line 23 "/Users/joshbrown/Desktop/IS Core/IS 413/Bookstore/Bookstore/Views/Shared/BookSummary.cshtml"
WriteAttributeValue("", 746, ViewContext.HttpContext.Request.PathAndQuery(), 746, 47, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\n\n\n                <button type=\"submit\" class=\"btn btn-primary\">Add to Cart</button>\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Page = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n        </div>\n    </div>\n</div>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Book> Html { get; private set; }
    }
}
#pragma warning restore 1591
