using System.Threading.Tasks;
using Kentico.Kontent.Delivery.Abstractions;
using Kentico.Kontent.Delivery.Urls.QueryParameters;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace kontent_sample_app_razorpages.Pages
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
