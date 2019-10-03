using Kentico.Kontent.Delivery;
using Microsoft.AspNetCore.Mvc;
using KenticoKontentModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kontent_sample_app_razorpages.Pages.Components.RelatedArticle
{
    public class RelatedArticleViewComponent: ViewComponent
    {
        public IViewComponentResult Invoke(Article article)
        {                        
            return View("RelatedArticle", article);
        }
    }
}
