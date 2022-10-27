using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kontent.Ai.Delivery.Abstractions;
using Kontent.Ai.Urls.Delivery.QueryParameters;
using sample_app_razorpages.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace sample_app_razorpages.Pages.Cafes
{
    public class IndexModel : PageModel
    {
        private readonly IDeliveryClient _deliveryClient;

        public IDeliveryItemResponse<Models.Home> Home { get; set; }

        public List<Cafe> CompanyCafes { get; set; }

        public List<Cafe> PartnerCafes { get; set; }

        public IndexModel(IDeliveryClient deliveryClient)
        {
            _deliveryClient = deliveryClient;
        }

        public async Task<IActionResult> OnGetAsync()
        {
            var response = await _deliveryClient.GetItemsAsync<Cafe>(new OrderParameter("system.name"));
            var cafes = response.Items;

            CompanyCafes = cafes.Where(c => c.Country == "USA").ToList();
            PartnerCafes = cafes.Where(c => c.Country != "USA").ToList();

            return Page();
        }
    }
}