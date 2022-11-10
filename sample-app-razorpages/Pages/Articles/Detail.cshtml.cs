using System.Threading.Tasks;
using Kontent.Ai.Delivery.Abstractions;
using Kontent.Ai.Urls.Delivery.QueryParameters.Filters;
using sample_app_razorpages.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace sample_app_razorpages.Pages.Articles
{
    public class DetailModel : PageModel
    {
        private readonly IDeliveryClient _deliveryClient;

        public Article Article { get; set; }

        public DetailModel(IDeliveryClient deliveryClient)
        {
            _deliveryClient = deliveryClient;
        }

        public async Task<IActionResult> OnGetAsync(string UrlPattern)
        {
            string UrlPatternCodename = "elements." + Article.UrlPatternCodename;

            try
            {
                var response = await _deliveryClient.GetItemsAsync<Article>(new EqualsFilter(UrlPatternCodename, UrlPattern));

                Article = response.Items[0];

                return Page();
            }
            catch
            {
                return Redirect("/Error");
            }
        }
    }
}