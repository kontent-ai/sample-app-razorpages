using Kentico.Kontent.Delivery;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kontent_sample_app_razorpages.Pages.Components.ContactComponent
{
    public class ContactViewComponent : ViewComponent
    {
        private IDeliveryClient _deliveryClient;

        public ContactViewComponent(IDeliveryClient deliveryClient)
        {
            _deliveryClient = deliveryClient;            
        }
        

        public IViewComponentResult Invoke()
        {
            IRichTextContent contactInfo = Task.Run(() => _deliveryClient.GetItemAsync<KenticoKontentModels.Home>(KenticoKontentModels.Home.Codename, new ElementsParameter("contact"))).Result.Item.Contact;
            return View("Contact", contactInfo);
        }
    }
}
