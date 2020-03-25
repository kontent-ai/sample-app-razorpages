using System.Threading.Tasks;
using Kentico.Kontent.Delivery;
using Kentico.Kontent.Delivery.Abstractions;
using kontent_sample_app_razorpages.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace kontent_sample_app_razorpages.Pages.Coffees
{
    public class IndexModel : PageModel
    {
        private readonly IDeliveryClient _deliveryClient;

        public DeliveryItemListingResponse<Coffee> Coffee { get; set; }

        public IndexModel(IDeliveryClient deliveryClient)
        {
            _deliveryClient = deliveryClient;
        }

        public async Task<IActionResult> OnGetAsync()
        {
            Coffee = await _deliveryClient.GetItemsAsync<Coffee>(new DepthParameter(1));

            return Page();
        }
    }
}