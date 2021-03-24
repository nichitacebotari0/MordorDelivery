using System.Collections.Generic;

namespace MealDelivery.Persistence.Models
{
    public class MealItem
    {
        public int Id { get; set; }
        public int RestaurantId { get; set; }
        public string Name { get; set; }
        public ICollection<MealTags> MealTags { get; set; }
        public ICollection<OrderItems> OrderItems { get; set; }
    }
}