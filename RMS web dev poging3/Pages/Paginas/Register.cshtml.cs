using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RMS_web_dev_poging3.Pages.Models;
using RMS_web_dev_poging3.Pages.Repository;

namespace RMS_web_dev_poging3.Pages.Paginas
{
    public class Register : PageModel
    {
        [BindProperty]
        public user newUser { get; set; }
        
        [BindProperty]
        public string passcheck { get; set; }

        public IActionResult OnPostRegister()
        {
            if (newUser.password == passcheck)
            {
                UserRep.Adduser(newUser);
                return RedirectToPage("/Paginas/Login");
            }
            else
            {
                return Page();
            }
        }
        
        public void OnGet()
        {
            
        }
    }
}