using Kontent.Ai.Delivery.Abstractions;
using sample_app_razorpages.Models;
using System.Linq;

namespace sample_app_razorpages.Resolvers
{
    public class HostedVideoResolver : IInlineContentItemsResolver<HostedVideo>
    {
        public string Resolve(HostedVideo data)
        {
            var host = data.VideoHost.FirstOrDefault()?.Codename;
            if (host == "youtube")
            {
                return $"<iframe class='hosted-video__wrapper' width='560' height='315' src='https://www.youtube.com/embed/{data.VideoId}' frameborder='0' allowfullscreen> </iframe>";

            }
            else if (host == "vimeo")
            {
                return $"<iframe class='hosted-video__wrapper' src='https://player.vimeo.com/video/{data.VideoId}?title=0&byline=0&portrait=0' width='640' height='360' frameborder='0' webkitallowfullscreen mozallowfullscreen allowfullscreen></iframe>";
            }
            else
            {
                return "<p>Video host unknown.  Please contact your website administrator.</p>";
            }
        }
    }
}
