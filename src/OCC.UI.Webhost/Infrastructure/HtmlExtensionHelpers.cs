using System.Web.Mvc;
using OCC.UI.Webhost.Models;

namespace OCC.UI.Webhost.Infrastructure
{
    public static class HtmlExtensionHelpers
    {
        public static MvcHtmlString ImageTag(this HtmlHelper html, string src, string alt, int? height = null, int? width = null,
                                             string title = null, string cssClass = null)
        {
            var url = new UrlHelper(html.ViewContext.RequestContext);

            var imageTagBuilder = new TagBuilder("img");
            imageTagBuilder.MergeAttribute("src", url.Content(src));
            imageTagBuilder.MergeAttribute("alt", alt);
            if (height != null)
                imageTagBuilder.MergeAttribute("height", height.ToString());
            if (width != null)
                imageTagBuilder.MergeAttribute("width", width.ToString());
            if (!string.IsNullOrEmpty(title))
                imageTagBuilder.MergeAttribute("title", title);
            if (!string.IsNullOrEmpty(cssClass)) imageTagBuilder.MergeAttribute("class", cssClass);
            string imgHtml = imageTagBuilder.ToString(TagRenderMode.SelfClosing);

            return MvcHtmlString.Create(imgHtml);
        }

        public  static MvcHtmlString ImageTag(this HtmlHelper html, MetroTileIcon icon, string cssClass = null)
        {
            return ImageTag(html, icon.PathUri, icon.AltText, icon.Height, icon.Width, icon.Title, cssClass);
        }
    }
}