#pragma checksum "/Users/joshbrown/Desktop/IS Core/IS 413/Bookstore/Bookstore/Views/Shared/Components/CartSummary/Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f584c9696101d350c273ffa55f0f327f81caff9f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_CartSummary_Default), @"mvc.1.0.view", @"/Views/Shared/Components/CartSummary/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f584c9696101d350c273ffa55f0f327f81caff9f", @"/Views/Shared/Components/CartSummary/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ee7fb15eb58b56b538c121efd167f7d7ca689e7a", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_CartSummary_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Cart>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("ml-0 pl-0 btn btn-sm navbar-btn d-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/cart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 1 "/Users/joshbrown/Desktop/IS Core/IS 413/Bookstore/Bookstore/Views/Shared/Components/CartSummary/Default.cshtml"
  
    Thread.CurrentThread.CurrentCulture = new CultureInfo("es-US");

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            WriteLiteral("\n<div class=\"d-flex align-items-center\">\n");
#nullable restore
#line 8 "/Users/joshbrown/Desktop/IS Core/IS 413/Bookstore/Bookstore/Views/Shared/Components/CartSummary/Default.cshtml"
     if (Model.Items.Count() > 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <small class=\"navbar-text mx-0 px-0\">\n            <b>Your Cart:</b>\n            ");
#nullable restore
#line 12 "/Users/joshbrown/Desktop/IS Core/IS 413/Bookstore/Bookstore/Views/Shared/Components/CartSummary/Default.cshtml"
       Write(Model.Items.Sum(x => x.Quantity));

#line default
#line hidden
#nullable disable
            WriteLiteral(" Item(s)\n            ");
#nullable restore
#line 13 "/Users/joshbrown/Desktop/IS Core/IS 413/Bookstore/Bookstore/Views/Shared/Components/CartSummary/Default.cshtml"
       Write(Model.CalculateTotalPrice().ToString("C"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </small>\n");
#nullable restore
#line 15 "/Users/joshbrown/Desktop/IS Core/IS 413/Bookstore/Bookstore/Views/Shared/Components/CartSummary/Default.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f584c9696101d350c273ffa55f0f327f81caff9f6068", async() => {
                WriteLiteral("\n        <i>\n            <img src=\"/img/shopping_cart.svg\" style=\"filter: invert(1);\" />\n        </i>\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-returnurl", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 16 "/Users/joshbrown/Desktop/IS Core/IS 413/Bookstore/Bookstore/Views/Shared/Components/CartSummary/Default.cshtml"
                                                                                  WriteLiteral(ViewContext.HttpContext.Request.PathAndQuery());

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["returnurl"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-returnurl", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["returnurl"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n    <div class=\"d-inline text-light mx-2\">|</div>\n    <a class=\"btn btn-sm navbar-btn d-inline text-white\" href=\"/admin\">Admin</a>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Cart> Html { get; private set; }
    }
}
#pragma warning restore 1591
