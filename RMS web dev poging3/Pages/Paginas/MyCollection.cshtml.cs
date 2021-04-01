using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RMS_web_dev_poging3.Pages.Models;
using RMS_web_dev_poging3.Pages.Repository;

namespace RMS_web_dev_poging3.Pages.Paginas
{
    public class MyCollection : PageModel
    {
        [BindProperty]
        public record newrecord { get; set; }
        [BindProperty]
        public List<record> records { get; set; }
        


        public void OnPostAddRecord()
        {
            newrecord.owner = Convert.ToInt32(Request.Cookies["user_id"]);
            RecordRep.AddRecord(newrecord);
            records = RecordRep.GetRecordsByOwner(newrecord.owner);
        }
        
        public void OnGet()
        {
            int Id = Convert.ToInt32(Request.Cookies["user_id"]);
            records = RecordRep.GetRecordsByOwner(Id);
        }
        
    }
    
}