using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RMS_web_dev_poging3.Pages.Models;
using RMS_web_dev_poging3.Pages.Repository;

namespace RMS_web_dev_poging3.Pages.Paginas
{
    public class MyCollection : PageModel
    {
        public List<record> records
        {
            get
            {
                return new RecordRep().Get();
            }
        }
        



        
        public void OnGet()
        {
            
        }
        
    }
    
}