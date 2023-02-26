using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Nevada.Data;
using Nevada.Models;
using Nevada.Models.ViewModel;

namespace Nevada.Pages.Admin.Shoes
{
    public class AddModel : PageModel
    {
        [BindProperty]
        public AddShoes AddShoesRequest { get; set; }

        private readonly ApplicationDbContext _context;
        public AddModel(ApplicationDbContext context)
        {
            this._context = context;
        }

        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            var shoe = new ShoesModel()
            {
                ShoeName = AddShoesRequest.ShoeName,
                Price = AddShoesRequest.Price,
                ImageTitle = AddShoesRequest.ImageTitle,
                ImageTitle1 = AddShoesRequest.ImageTitle1,
                ImageTitle2 = AddShoesRequest.ImageTitle2,
                ImageTitle3 = AddShoesRequest.ImageTitle3,
                OutOfStock = AddShoesRequest.OutOfStock,
                Property = AddShoesRequest.Property,
                Size = AddShoesRequest.Size
            };
            _context.Shoes.Add(shoe);
            _context.SaveChanges();

            return RedirectToPage("/Shoe");
        }

    }
}
