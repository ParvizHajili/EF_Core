using System.ComponentModel.DataAnnotations;

namespace Ef_Core_Code_First
{
    public class Car
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int DoorCount { get; set; }
        public int CarCategoryId { get; set; }
        public virtual CarCategory CarCategory { get; set; }
    }
}
