using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Nevada.Data;
using Nevada.Models;

namespace Nevada.Pages.Admin.Shoes
{
    public class ListModel : PageModel
    {
        private readonly ApplicationDbContext context;

        public List<ShoesModel> Shoes { get; set; }

        public ListModel(ApplicationDbContext context)
        {
            this.context = context;
        }
        public void OnGet()
        {
            Shoes = context.Shoes.ToList();
        }
    }
}
