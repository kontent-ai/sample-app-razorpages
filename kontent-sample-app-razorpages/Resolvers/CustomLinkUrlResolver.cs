using Kentico.Kontent.Delivery.Abstractions;

namespace kontent_sample_app_razorpages.Resolvers
{
    public class CustomContentLinkUrlResolver : IContentLinkUrlResolver
    {
        public string ResolveLinkUrl(ContentLink link)
        {
            // Resolves URLs to content items based on the 'accessory' content type
            return link.ContentTypeCodename switch
            {
                "article" => $"/Articles/Detail/{link.UrlSlug}",
                "coffee" => $"/Coffees/Detail/{link.UrlSlug}",
                _ => "/404",
            };
        }

        public string ResolveBrokenLinkUrl()
        {
            // Resolves URLs to unavailable content items
            return "/404";
        }
    }
}
