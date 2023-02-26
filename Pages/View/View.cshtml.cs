using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Nevada.Data;
using Nevada.Models;
using Nevada.Models.ViewModel;

namespace Nevada.Pages
{
    public class ViewModel : PageModel
    {
        private readonly ApplicationDbContext context;

        [BindProperty(SupportsGet = true)]
        public ViewShoes ViewShoes { get; set; }

        public IActionResult OnPost()
        {
            // Redirect to Checkout page with shoe data in query parameters
            return RedirectToPage("/Checkout/Checkout",
                new
                {
                    Id = ViewShoes.Id,
                    CustomerName =ViewShoes.CustomerName,
                    CustomerAddress= ViewShoes.CustomerAddress,
                    CustomerPhone= ViewShoes.CustomerPhone,
                    ShoeName = ViewShoes.ShoeName,
                    Price = ViewShoes.Price,
                    ImageTitle = ViewShoes.ImageTitle,
                    Property = ViewShoes.Property,
                    Size = ViewShoes.Size,
                    OutOfStock = ViewShoes.OutOfStock
                });
        }
    }
}