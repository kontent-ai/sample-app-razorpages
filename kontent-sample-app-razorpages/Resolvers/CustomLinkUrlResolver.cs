using Kentico.Kontent.Delivery;

namespace kontent_sample_app_razorpages.Resolvers
{
    public class CustomContentLinkUrlResolver : IContentLinkUrlResolver
    {
        public string ResolveLinkUrl(ContentLink link)
        {
            // Resolves URLs to content items based on the 'accessory' content type
            switch (link.ContentTypeCodename)
            {
                case "article":
                    return $"/Articles/Detail/{link.UrlSlug}";
                case "coffee":
                    return $"/Coffees/Detail/{link.UrlSlug}";
                default:
                    return "/404";

            }            
        }

        public string ResolveBrokenLinkUrl()
        {
            // Resolves URLs to unavailable content items
            return "/404";
        }
    }
}
