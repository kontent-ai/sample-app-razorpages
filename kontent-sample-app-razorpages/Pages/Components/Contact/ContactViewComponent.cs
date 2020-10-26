using Kentico.Kontent.Delivery;
using Kentico.Kontent.Delivery.Abstractions;
using Kentico.Kontent.Delivery.Urls.QueryParameters;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace kontent_sample_app_razorpages.Pages.Components.ContactComponent
{
    public class ContactViewComponent : ViewComponent
    {
        private readonly IDeliveryClient _deliveryClient;

        public ContactViewComponent(IDeliveryClient deliveryClient)
        {
            _deliveryClient = deliveryClient;            
        }
        
        public IViewComponentResult Invoke()
        {
            IRichTextContent contactInfo = Task.Run(() => _deliveryClient.GetItemAsync<Models.Home>(Models.Home.Codename, new ElementsParameter("contact"))).Result.Item.Contact;
            return View("Contact", contactInfo);
        }
    }
}
