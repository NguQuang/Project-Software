using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Nevada.Data;
using Nevada.Models;


namespace Nevada.Pages.Admin.Shoes
{
    public class EditModel : PageModel
    {
        private readonly ApplicationDbContext context;

        [BindProperty]
        public ShoesModel Shoe { get; set; }

        public EditModel(ApplicationDbContext context)
        {
            this.context = context;
        }
        public void OnGet(Guid id)
        {
            Shoe = context.Shoes.Find(id);
        }
        public IActionResult OnPostEdit()
        {
            var existingShoe = context.Shoes.Find(Shoe.Id);
            if (existingShoe != null)
            {
                existingShoe.Property = Shoe.Property;
                existingShoe.Price = Shoe.Price;
                existingShoe.OutOfStock = Shoe.OutOfStock;
                existingShoe.Size = Shoe.Size;
                existingShoe.ShoeName = Shoe.ShoeName;
                existingShoe.ImageTitle = Shoe.ImageTitle;
                existingShoe.ImageTitle1 = Shoe.ImageTitle1;
                existingShoe.ImageTitle2 = Shoe.ImageTitle2;
                existingShoe.ImageTitle3 = Shoe.ImageTitle3;
            }
            context.SaveChanges();
            return RedirectToPage("/Admin/Shoes/List");
        }
        public IActionResult OnPostDelete(int id)
        {
            var existingShoe = context.Shoes.Find(Shoe.Id);
            if (existingShoe != null)
            {
                context.Shoes.Remove(existingShoe);
            }
            context.SaveChanges();
            return RedirectToPage("/Admin/Shoes/List");
        }

    }
}
