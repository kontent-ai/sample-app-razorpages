using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kentico.Kontent.Delivery;
using KenticoKontentModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace kontent_sample_app_razorpages.Pages.Cafes
{
    public class IndexModel : PageModel
    {
        private IDeliveryClient _deliveryClient;

        public List<Cafe> CompanyCafes { get; set; }

        public List<Cafe> PartnerCafes { get; set; }

        public IndexModel(IDeliveryClient deliveryClient)
        {
            _deliveryClient = deliveryClient;
        }

        public DeliveryItemResponse<KenticoKontentModels.Home> Home { get; set; }

        public async Task<IActionResult> OnGetAsync()
        {
            var response = await _deliveryClient.GetItemsAsync<Cafe>(
                new EqualsFilter("system.type", "cafe"),
                new OrderParameter("system.name")
            );
            var cafes = response.Items;

            CompanyCafes = cafes.Where(c => c.Country == "USA").ToList();
            PartnerCafes = cafes.Where(c => c.Country != "USA").ToList();

            return Page();
        }
    }
}