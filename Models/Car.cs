using System.ComponentModel.DataAnnotations;

namespace VehicleManagementSystem.Models
{
    public class Car
    {
        [Key]
        [Required]
        public string Id { get; set; }
        public string VehicleType { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Engine { get; set; }
        public int Doors { get; set; }
        public int Wheels { get; set; }
        public string BodyType { get; set; }
    }
}
