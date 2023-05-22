namespace BD_Lab_OLX.Models
{
    public class Orders
    {
        public int Id { get; set; } 
        public int PaymentId { get; set; }
        public Payment? Payment { get; set; }
        public int DeliveryId { get; set; } 
        public Delivery? Delivery { get; set; }
        public List<Product>? Product { get; set; } = new List<Product>();
        public int? UsersId { get; set; }
        public Users? Users { get; set; }
    }
}
