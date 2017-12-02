using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace CarsApp.ResourceModels
{
    public class ManufacturerResource
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public ICollection<ModelResource> Models { get; set; }

        public ManufacturerResource()
        {
            Models = new Collection<ModelResource>();
        }
    }
}