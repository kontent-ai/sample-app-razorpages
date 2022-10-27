using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace sample_app_razorpages.Pages.Partnership
{
    public class IndexModel : PageModel
    {
        public void OnGetAsync()
        {
            ViewData["PartnershipRequested"] = TempData["formApplied"] ?? false;
        }

        /// <summary>
        /// Dummy action.
        /// </summary>        
        public IActionResult OnPost()
        {
            // If needed, put your code here to work with the uploaded data in MVC.
            TempData["formApplied"] = true;
            return Redirect("Partnership");
        }
    }
}