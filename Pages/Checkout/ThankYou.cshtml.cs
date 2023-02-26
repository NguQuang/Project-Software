using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Nevada.Pages.Checkout
{
    [BindProperties(SupportsGet =true)]
    public class ThankYouModel : PageModel
    {
        public string ShoeName { get; set; }
        public float Price { get; set; }
        public string ImageTitle { get; set; }
        public void OnGet()
        {

        }
    }
}
