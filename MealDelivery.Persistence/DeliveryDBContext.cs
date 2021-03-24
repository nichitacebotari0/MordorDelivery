using System.Diagnostics.CodeAnalysis;
using MealDelivery.Persistence.Models;
using Microsoft.EntityFrameworkCore;

namespace MealDelivery.Persistence
{
    public class DeliveryDBContext : DbContext
    {
        public DeliveryDBContext([NotNullAttribute] DbContextOptions options)
            : base(options)
        { }

        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItems> OrderItems { get; set; }
        public DbSet<MealItem> MealItems { get; set; }
        public DbSet<MealTags> MealTags { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<DeliveryDetail> DeliveryDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<MealTags>().HasKey(i => new { i.MealId, i.TagId });
            modelBuilder.Entity<OrderItems>().HasKey(i => new { i.MealItemId, i.OrderId });
        }
    }
}