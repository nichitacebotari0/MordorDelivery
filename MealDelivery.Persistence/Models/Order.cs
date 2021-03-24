using System.Collections.Generic;

namespace MealDelivery.Persistence.Models
{
    public class Order
    {
        public int Id { get; set; }
        public ICollection<DeliveryDetail> DeliveryDetails { get; set; }
        public ICollection<OrderItems> OrderItems { get; set; }
    }
}