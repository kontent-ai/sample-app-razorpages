using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kentico.Kontent.Delivery;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace kontent_sample_app_razorpages
{
    public class AboutModel : PageModel
    {
        private IDeliveryClient _deliveryClient;

        public AboutModel(IDeliveryClient deliveryClient)
        {
            _deliveryClient = deliveryClient;
        }

        public DeliveryItemResponse<KenticoKontentModels.AboutUs> AboutUs { get; set; }

        public async Task<IActionResult> OnGetAsync()
        {
            AboutUs = await _deliveryClient.GetItemAsync<KenticoKontentModels.AboutUs>("about_us");

            return Page();
        }
    }
}