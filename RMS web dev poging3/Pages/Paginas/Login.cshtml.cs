using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RMS_web_dev_poging3.Pages.Models;
using RMS_web_dev_poging3.Pages.Repository;
using Ubiety.Dns.Core.Records.NotUsed;

namespace RMS_web_dev_poging3.Pages.Paginas
{
    public class Login : PageModel
    {
        [BindProperty]
        public user loginUser { get; set; }
        
        public IActionResult OnPostLogin()
        {
            string emailadres = loginUser.emailadres;
            string password = loginUser.password;
            
            if (emailadres == null || password == null)
            {
                return Page();
            }
            
            user user = UserRep.Login(emailadres, password);
            
            if (user == null)
            {
                return Page();
            }
            else
            {
                return RedirectToPage("/Paginas/MyCollection");
            }
            
        }
        
        public void OnGet()
        {
            
        }
    }
}