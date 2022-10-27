using System.Threading.Tasks;
using Kontent.Ai.Delivery.Abstractions;

namespace sample_app_razorpages.Resolvers
{
    public class CustomContentLinkUrlResolver : IContentLinkUrlResolver
    {
        public async Task<string> ResolveLinkUrlAsync(IContentLink link)
        {
            // Resolves URLs to content items based on the 'accessory' content type
            return await Task.FromResult(link.ContentTypeCodename switch
            {
                "article" =>  $"/Articles/Detail/{link.UrlSlug}",
                "coffee" =>  $"/Coffees/Detail/{link.UrlSlug}",
                _ => "/404",
            });
        }

        public Task<string> ResolveBrokenLinkUrlAsync()
        {
            // Resolves URLs to unavailable content items
            return Task.FromResult("/404");
        }
    }
}
