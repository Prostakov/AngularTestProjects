using System.ComponentModel.DataAnnotations;

namespace CarsApp.ResourceModels
{
    public class ModelResource
    {
        public int Id {get; set;}
        
        [Required]
        [StringLength(255)]
        public string Name {get; set;}
        public ManufacturerResource Manufacturer { get; set; }
        public int ManufacturerId { get; set; }
    }
}