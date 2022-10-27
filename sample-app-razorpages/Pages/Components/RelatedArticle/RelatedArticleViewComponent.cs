using Microsoft.AspNetCore.Mvc;
using sample_app_razorpages.Models;

namespace sample_app_razorpages.Pages.Components.RelatedArticle
{
    public class RelatedArticleViewComponent: ViewComponent
    {
        public IViewComponentResult Invoke(Article article)
        {                        
            return View("RelatedArticle", article);
        }
    }
}
