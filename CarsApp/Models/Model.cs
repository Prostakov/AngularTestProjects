using System.ComponentModel.DataAnnotations;

namespace CarsApp.Models
{
    public class Model
    {
        public int Id {get; set;}
        
        [Required]
        [StringLength(255)]
        public string Name {get; set;}
        public Manufacturer Manufacturer { get; set; }
        public int ManufacturerId { get; set; }
    }
}