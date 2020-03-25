using System.Threading.Tasks;
using Kentico.Kontent.Delivery.Abstractions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace kontent_sample_app_razorpages
{
    public class AboutModel : PageModel
    {
        private readonly IDeliveryClient _deliveryClient;

        public DeliveryItemResponse<kontent_sample_app_razorpages.Models.AboutUs> AboutUs { get; set; }

        public AboutModel(IDeliveryClient deliveryClient)
        {
            _deliveryClient = deliveryClient;
        }

        public async Task<IActionResult> OnGetAsync()
        {
            AboutUs = await _deliveryClient.GetItemAsync<kontent_sample_app_razorpages.Models.AboutUs>("about_us");

            return Page();
        }
    }
}