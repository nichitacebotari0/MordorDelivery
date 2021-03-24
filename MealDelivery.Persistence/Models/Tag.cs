using System.Collections.Generic;

namespace MealDelivery.Persistence.Models
{
    public class Tag
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<MealTags> MealTags { get; set; }
    }
}