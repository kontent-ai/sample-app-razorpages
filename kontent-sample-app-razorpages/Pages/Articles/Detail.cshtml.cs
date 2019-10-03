using System.Threading.Tasks;
using Kentico.Kontent.Delivery;
using KenticoKontentModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace kontent_sample_app_razorpages.Pages.Articles
{
    public class DetailModel : PageModel
    {
        private IDeliveryClient _deliveryClient;

        public DetailModel(IDeliveryClient deliveryClient)
        {
            _deliveryClient = deliveryClient;
        }

       public Article Article { get; set; }

        public async Task<IActionResult> OnGetAsync(string UrlPattern)
        {
            string UrlPatternCodename = "elements." + Article.UrlPatternCodename;

            try
            {
                var response = await _deliveryClient.GetItemsAsync<Article>(
                new EqualsFilter(UrlPatternCodename, UrlPattern)
                );

                Article = response.Items[0];

                return Page();        
            }
            catch
            {
                return Redirect("/Error");
            }
                         
        }
    }
}