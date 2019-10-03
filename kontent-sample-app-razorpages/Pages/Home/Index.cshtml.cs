using System.Threading.Tasks;
using Kentico.Kontent.Delivery;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace kontent_sample_app_razorpages.Pages
{
    public class IndexModel : PageModel
    {
        private IDeliveryClient _deliveryClient;

        public IndexModel(IDeliveryClient deliveryClient)
        {
            _deliveryClient = deliveryClient;
        }

        public DeliveryItemResponse<KenticoKontentModels.Home> Home { get; set; }        

        public async Task<IActionResult> OnGetAsync()
        {
            Home = await _deliveryClient.GetItemAsync<KenticoKontentModels.Home>(
                KenticoKontentModels.Home.Codename,
                new DepthParameter(3)
                );

            return Page();

        }
    }
}
