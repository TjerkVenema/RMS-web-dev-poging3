using System.ComponentModel.DataAnnotations;

namespace RMS_web_dev_poging3.Pages.Models
{
    public class user
    {
        public int user_id { get; set; }
        [MinLength(2, ErrorMessage = "Minimaal 2 karakters")]
        [MaxLength(30)]
        public string firstname { get; set; }
        [MinLength(3, ErrorMessage = "Minimaal 3 karakters")]
        [MaxLength(30)]
        public string lastname { get; set; }
        [MinLength(6, ErrorMessage = "Minimaal 6 karakters")]
        [MaxLength(30)]
        public string emailadres { get; set; }
        
        [MinLength(6, ErrorMessage = "Minimaal 6 karakters")]
        [MaxLength(30)]
        public string password { get; set; }
        public string adres { get; set; }
        public string city { get; set; }
        public string zipcode { get; set; }
        public string country { get; set; }
    }
}