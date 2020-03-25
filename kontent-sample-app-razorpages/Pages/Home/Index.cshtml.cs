using System.Threading.Tasks;
using Kentico.Kontent.Delivery;
using Kentico.Kontent.Delivery.Abstractions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace kontent_sample_app_razorpages.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IDeliveryClient _deliveryClient;

        public DeliveryItemResponse<kontent_sample_app_razorpages.Models.Home> Home { get; set; }

        public IndexModel(IDeliveryClient deliveryClient)
        {
            _deliveryClient = deliveryClient;
        }

        public async Task<IActionResult> OnGetAsync()
        {
            Home = await _deliveryClient.GetItemAsync<kontent_sample_app_razorpages.Models.Home>(
                kontent_sample_app_razorpages.Models.Home.Codename,
                new DepthParameter(3)
                );

            return Page();
        }
    }
}
