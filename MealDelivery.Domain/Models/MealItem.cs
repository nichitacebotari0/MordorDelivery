namespace MealDelivery.Domain.Models
{
    public class MealItem
    {
        public int Id { get; set; }
        public int RestaurantId { get; set; }
        public string Name { get; set; }
    }
}