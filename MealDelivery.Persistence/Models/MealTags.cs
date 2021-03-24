using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MealDelivery.Persistence.Models
{
    public class MealTags
    {
        public int MealId { get; set; }
        public int TagId { get; set; }
    }
}