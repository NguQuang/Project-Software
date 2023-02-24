using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Nevada.Data;
using Nevada.Models;
using System.Drawing;

namespace Nevada.Pages.Checkout
{
    [BindProperties(SupportsGet = true)]
    public class CheckoutModel : PageModel
    {
        public string ShoeName { get; set; }
        public float Price { get; set; }
        public string ImageTitle { get; set; }

        private readonly ApplicationDbContext _context;
        public CheckoutModel(ApplicationDbContext context)
        {
            _context = context;
        }
        public void OnGet()
        {
            ShoeOrder shoeOrder = new ShoeOrder();
            shoeOrder.ShoeName = ShoeName;
            shoeOrder.Price= Price;
            _context.ShoeOrders.Add(shoeOrder);
            _context.SaveChanges();
        }
    }
}
