using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Sapo.Models.ViewModels;

namespace Sapo.Infrastructure
{
    [HtmlTargetElement("div", Attributes = "page-number")]
    public class PaginationTagHelper : TagHelper
    {
        //Create the page links

        private IUrlHelperFactory uhf;

        public PaginationTagHelper(IUrlHelperFactory temp)
        {
            uhf = temp;
        }

        [ViewContext]
        [HtmlAttributeNotBound]
        public ViewContext vc { get; set; }

        public PageInfo PageNumber { get; set; }
        public string PageAction { get; set; }
        public string PageClass { get; set; }
        public bool PageClassEnabled { get; set; }
        public string PageClassNormal { get; set; }
        public string PageClassSelected { get; set; }


        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            IUrlHelper uh = uhf.GetUrlHelper(vc);

            TagBuilder final = new TagBuilder("div");

            for (int i = 1; i <= PageNumber.TotalPages; i++)
            {
                TagBuilder tb = new TagBuilder("a");
                tb.Attributes["href"] = uh.Action(PageAction, new { PageNum = i });

                if (PageClassEnabled)
                {
                    tb.AddCssClass(PageClass);
                    tb.AddCssClass(i == PageNumber.CurrentPage ? PageClassSelected : PageClassNormal);
                }
                tb.AddCssClass(PageClass);
                tb.InnerHtml.Append(i.ToString());

                final.InnerHtml.AppendHtml(tb);

            }

            output.Content.AppendHtml(final.InnerHtml);



        }
    }
}
