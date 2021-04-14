using System.ComponentModel.DataAnnotations;

namespace RMS_web_dev_poging3.Pages.Models
{
    public class record_for_sale
    {
        public int recordForSaleId { get; set; }
        public int user_id { get; set; }
        public int record_id { get; set; }
        [Range(1, 99999, ErrorMessage = "Voer een prijs in tussen €1,- en €99999,-")]
        public float priceSold { get; set; }
    }
}