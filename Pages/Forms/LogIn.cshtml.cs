using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Nevada.Models;

namespace Nevada.Pages.Forms
{
    public class LogInModel : PageModel
    {
        public UsersModel User { get; set; }
        public void OnGet()
        {
        }
    }
}
