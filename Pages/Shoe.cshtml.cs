using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Nevada.Data;
using Nevada.Models;

namespace Nevada.Pages
{
    public class ShoeModel : PageModel
    {
        private readonly ApplicationDbContext context;

        public List<ShoesModel> Shoes { get; set; }

        public ShoeModel(ApplicationDbContext context)
        {
            this.context = context;
        }
        public void OnGet()
        {
            Shoes = context.Shoes.ToList();
        }
    }
}
