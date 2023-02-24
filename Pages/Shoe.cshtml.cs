using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Nevada.Models;

namespace Nevada.Pages
{
    public class ShoeModel : PageModel
    {
        public List<ShoesModel> ShoeDB = new List<ShoesModel>()
        {
            new ShoesModel(){ImageTitle="AirJordan1MidSe",ShoeName="AirJordan1MidSe", Price=50},
            new ShoesModel(){ImageTitle="NikeAirForce1High",ShoeName="NikeAirForce1High", Price=50},
            new ShoesModel(){ImageTitle="NikeAirMax90E",ShoeName="NikeAirMax90E", Price=50 , },
            new ShoesModel(){ImageTitle="NikeMetcon8",ShoeName="NikeMetcon8", Price=50 , },
            new ShoesModel(){ImageTitle="NikePegasus39Premium",ShoeName="NikePegasus39Premium", Price=50}
        };
        public void OnGet()
        {
        }
    }
}
