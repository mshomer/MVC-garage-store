namespace MvcGarageStore.Models
{
    public class OrderDetail
    {
        public int OrderDetailId { get; set; }
        public int OrderId { get; set; }
        public int VehicleId { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }

        public virtual Vehicle Vehicle { get; set; }
        public virtual Order Order { get; set; }
    }
}
