using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Nevada.Data;
using Nevada.Models;
using Nevada.Models.ViewModel;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;

namespace Nevada.Pages.Checkout
{
    public class CheckoutModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public CheckoutModel(ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty(SupportsGet = true)]
        public ViewShoes ViewShoes { get; set; }

        public void OnGet()
        {
            // Create a new ShoeOrder object with  all the necessary information
            var shoeOrder = new ShoeOrder()
            {
                Delivered= ViewShoes.Delivered,
                CustomerName = ViewShoes.CustomerName,
                CustomerAddress = ViewShoes.CustomerAddress,
                CustomerPhone = ViewShoes.CustomerPhone,
                ShoeName = ViewShoes.ShoeName,
                Price = ViewShoes.Price,
                ShoesModelId = ViewShoes.Id,
            };

            // Add the new ShoeOrder object to the database
            _context.ShoeOrders.Add(shoeOrder);
            _context.SaveChanges();
        }
    }
}
