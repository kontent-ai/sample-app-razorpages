using System.Threading.Tasks;
using Kontent.Ai.Delivery.Abstractions;
using Kontent.Ai.Urls.Delivery.QueryParameters;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace sample_app_razorpages.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IDeliveryClient _deliveryClient;

        public IDeliveryItemResponse<Models.Home> Home { get; set; }

        public IndexModel(IDeliveryClient deliveryClient)
        {
            _deliveryClient = deliveryClient;
        }

        public async Task<IActionResult> OnGetAsync()
        {
            Home = await _deliveryClient.GetItemAsync<Models.Home>(
                Models.Home.Codename,
                new DepthParameter(3)
                );

            return Page();
        }
    }
}
