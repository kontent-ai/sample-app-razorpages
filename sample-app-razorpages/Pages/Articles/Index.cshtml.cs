using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using sample_app_razorpages.Models;
using Microsoft.AspNetCore.Mvc;
using Kontent.Ai.Delivery.Abstractions;
using Kontent.Ai.Urls.Delivery.QueryParameters;

namespace sample_app_razorpages.Pages.Articles
{
    public class IndexModel : PageModel
    {
        private readonly IDeliveryClient _deliveryClient;

        public IDeliveryItemListingResponse<Article> Articles { get; set; }

        public IndexModel(IDeliveryClient deliveryClient)
        {
            _deliveryClient = deliveryClient;
        }

        public async Task<IActionResult> OnGetAsync()
        {
            Articles = await _deliveryClient.GetItemsAsync<Article>(
                new DepthParameter(1),
                new OrderParameter("elements.post_date")
            );

            return Page();
        }
    }
}