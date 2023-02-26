using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Nevada.Data;
using Nevada.Models;

namespace Nevada.Pages.Admin.Shoes
{
    public class EditOrdersModel : PageModel
    {
        [BindProperty]
        public ShoeOrder Order { get; set; }
        private readonly ApplicationDbContext context;

        public EditOrdersModel(ApplicationDbContext context)
        {
            this.context = context;
        }

        public void OnGet(Guid id)
        {
            Order = context.ShoeOrders.Find(id);
        }
        public IActionResult OnPostEdit()
        {
            var existingOrder = context.ShoeOrders.Find(Order.Id);
            if (existingOrder != null)
            {
                existingOrder.ShoesModelId = Order.ShoesModelId;
                existingOrder.CustomerAddress = Order.CustomerAddress;
                existingOrder.Price = Order.Price;
                existingOrder.CustomerPhone = Order.CustomerPhone;
                existingOrder.CustomerName = Order.CustomerName;
                existingOrder.ShoeName = Order.ShoeName;
                existingOrder.Delivered = Order.Delivered;
            }
            context.SaveChanges();
            return RedirectToPage("/Admin/Shoes/Orders");
        }
        public IActionResult OnPostDelete(int id)
        {
            var existingOrder = context.ShoeOrders.Find(Order.Id);
            if (existingOrder != null)
            {
                context.ShoeOrders.Remove(existingOrder);
            }
            context.SaveChanges();
            return RedirectToPage("/Admin/Shoes/Orders");
        }
    }
}
