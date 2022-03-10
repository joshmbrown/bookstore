using System;
using Bookstore.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Bookstore.Infrastructure
{
    [HtmlTargetElement("div", Attributes = "page-nav")]
    public class PaginationTagHelper : TagHelper
    {
        private IUrlHelperFactory _uhf;
        public PaginationTagHelper (IUrlHelperFactory uhf)
        {
            _uhf = uhf;
        }

        [ViewContext]
        [HtmlAttributeNotBound]
        public ViewContext vc { get; set; }
        public PageInfo PageNav { get; set; }
        public string PageAction { get; set; }

        public override void Process (TagHelperContext thc, TagHelperOutput tho)
        {
            IUrlHelper uh = _uhf.GetUrlHelper(vc);

            TagBuilder final = new TagBuilder("div");

            final.InnerHtml.Append(" | ");
            for (int i = 1; i <= PageNav.TotalPages; i++)
            {
                TagBuilder tb = new TagBuilder("a");

                tb.Attributes["href"] = uh.Action(PageAction, new { pageNum = i });
                tb.InnerHtml.Append("Page ");
                tb.InnerHtml.Append(i.ToString());
                tb.AddCssClass("btn");

                final.InnerHtml.AppendHtml(tb);
                final.InnerHtml.Append(" | ");
            }

            tho.Content.AppendHtml(final.InnerHtml);
        }
    }
}
