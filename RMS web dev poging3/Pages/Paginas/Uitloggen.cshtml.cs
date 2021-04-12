using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RMS_web_dev_poging3.Pages.Paginas
{
    public class Uitloggen : PageModel
    {
        public RedirectToPageResult OnGet()
        {
            Response.Cookies.Delete("user_id");
            return RedirectToPage("/Index");
        }
    }
}