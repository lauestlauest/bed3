using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SW4BED_3.Pages
{
    [Authorize("CanEnterRestaurantPage")]
    [BindProperties]
    public class RestaurantModel : PageModel
    {

        public int RoomNumber { get; set; }
        public int NrAdults { get; set; }
        public int NrChildren { get; set; }
        public void OnGet()
        {
        }

        public void OnPost()
        {

        }
    }
}
