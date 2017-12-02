using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Cars.Models
{
    public class Manufacturer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Model> Models { get; set; }

        public Manufacturer()
        {
            Models = new Collection<Model>();
        }
    }
}