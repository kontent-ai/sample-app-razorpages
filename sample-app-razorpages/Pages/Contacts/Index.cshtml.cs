using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kontent.Ai.Delivery.Abstractions;
using Kontent.Ai.Urls.Delivery.QueryParameters.Filters;
using sample_app_razorpages.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace sample_app_razorpages.Pages.Contacts
{
    public class IndexModel : PageModel
    {
        private readonly IDeliveryClient _deliveryClient;

        public Cafe Roastery { get; set; }

        public IList<Cafe> Cafes { get; set; }

        public IndexModel(IDeliveryClient deliveryClient)
        {
            _deliveryClient = deliveryClient;
        }

        public async Task<IActionResult> OnGetAsync()
        {
            var response = await _deliveryClient.GetItemsAsync<Cafe>(new EqualsFilter("elements.country", "USA"));
            var cafes = response.Items;

            Roastery = cafes.FirstOrDefault();
            Cafes = cafes;

            return Page();
        }
    }
}