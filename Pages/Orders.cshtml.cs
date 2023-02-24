using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Nevada.Data;
using Nevada.Models;

namespace Nevada.Pages
{
    public class OrdersModel : PageModel
    {
        public List<ShoeOrder> ShoeOrders = new List<ShoeOrder>();

        private readonly ApplicationDbContext _context;
        public OrdersModel(ApplicationDbContext context)
        {
            _context= context;
        }
        public void OnGet()
        {
            ShoeOrders = _context.ShoeOrders.ToList();  
        }
    }
}
