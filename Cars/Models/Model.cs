namespace Cars.Models
{
    public class Model
    {
        public int Id {get; set;}
        public string Name {get; set;}
        public Manufacturer Manufacturer { get; set; }
        public int ManufacturerId { get; set; }
    }
}