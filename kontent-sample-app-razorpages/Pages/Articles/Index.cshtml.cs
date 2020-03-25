using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using kontent_sample_app_razorpages.Models;
using Kentico.Kontent.Delivery;
using Microsoft.AspNetCore.Mvc;
using Kentico.Kontent.Delivery.Abstractions;

namespace kontent_sample_app_razorpages.Pages.Articles
{
    public class IndexModel : PageModel
    {
        private readonly IDeliveryClient _deliveryClient;

        public DeliveryItemListingResponse<Article> Articles { get; set; }

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