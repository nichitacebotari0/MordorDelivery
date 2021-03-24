using System.ComponentModel.DataAnnotations;

namespace MealDelivery.Persistence.Models
{
    public class OrderItems
    {
        public int OrderId { get; set; }
        public int MealItemId { get; set; }
    }
}