using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Nevada.Models;

namespace Nevada.Pages.Forms
{
    public class ConfirmOrderModel : PageModel
    {
        [BindProperty]
        public UserModel User { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            return RedirectToPage("/Checkout/Thankyou", new { User.Name, User.Address, User.Phone });
        }
    }
}