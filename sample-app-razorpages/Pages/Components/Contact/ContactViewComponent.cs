
using Kontent.Ai.Delivery.Abstractions;
using Kontent.Ai.Urls.Delivery.QueryParameters;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace sample_app_razorpages.Pages.Components.ContactComponent
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
