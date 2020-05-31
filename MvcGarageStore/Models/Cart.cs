using System.ComponentModel.DataAnnotations;

namespace MvcGarageStore.Models
{
    public class Cart
    {
        [Key]
        public int RecordId { get; set; }
        public string CartId { get; set; }
        public int VehicleId { get; set; }
        public int Count { get; set; }
        public System.DateTime DateCreated { get; set; }

        public virtual Vehicle Vehicle { get; set; }
    }
}