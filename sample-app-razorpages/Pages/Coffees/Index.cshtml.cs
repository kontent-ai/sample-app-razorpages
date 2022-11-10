using System.Threading.Tasks;
using Kontent.Ai.Delivery.Abstractions;
using Kontent.Ai.Urls.Delivery.QueryParameters;
using sample_app_razorpages.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace sample_app_razorpages.Pages.Coffees
{
    public class IndexModel : PageModel
    {
        private readonly IDeliveryClient _deliveryClient;

        public IDeliveryItemListingResponse<Coffee> Coffee { get; set; }

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