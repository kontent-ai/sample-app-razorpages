using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using KenticoKontentModels;
using Kentico.Kontent.Delivery;
using Microsoft.AspNetCore.Mvc;

namespace kontent_sample_app_razorpages.Pages.Articles
{
    public class IndexModel : PageModel
    {

        private IDeliveryClient _deliveryClient;

        public IndexModel(IDeliveryClient deliveryClient)
        {
            _deliveryClient = deliveryClient;
        }

        public DeliveryItemListingResponse<Article> Articles { get; set; }

        public async Task<IActionResult> OnGetAsync()
        {
            Articles = await _deliveryClient.GetItemsAsync<Article>(
                new EqualsFilter("system.type", "article"),
                new DepthParameter(1),
                new OrderParameter("elements.post_date")
            );

            return Page();
        }
    }
}