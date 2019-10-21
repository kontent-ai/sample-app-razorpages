using System.Threading.Tasks;
using Kentico.Kontent.Delivery;
using KenticoKontentModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace kontent_sample_app_razorpages.Pages.Coffees
{
    public class IndexModel : PageModel
    {

        private IDeliveryClient _deliveryClient;

        public IndexModel(IDeliveryClient deliveryClient)
        {
            _deliveryClient = deliveryClient;
        }

        public DeliveryItemListingResponse<Coffee> Coffee { get; set; }

        public async Task<IActionResult> OnGetAsync()
        {
            Coffee = await _deliveryClient.GetItemsAsync<Coffee>(
                new EqualsFilter("system.type", "coffee"),
                new DepthParameter(1)
            );

            return Page();
        }
    }
}