// <auto-generated />
using System;
using MealDelivery.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MealDelivery.Persistence.Migrations
{
    [DbContext(typeof(DeliveryDBContext))]
    partial class DeliveryDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MealDelivery.Persistence.Models.DeliveryDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("OrderId")
                        .HasColumnType("int");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.ToTable("DeliveryDetails");
                });

            modelBuilder.Entity("MealDelivery.Persistence.Models.MealItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RestaurantId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("MealItems");
                });

            modelBuilder.Entity("MealDelivery.Persistence.Models.MealTags", b =>
                {
                    b.Property<int>("MealId")
                        .HasColumnType("int");

                    b.Property<int>("TagId")
                        .HasColumnType("int");

                    b.Property<int?>("MealItemId")
                        .HasColumnType("int");

                    b.HasKey("MealId", "TagId");

                    b.HasIndex("MealItemId");

                    b.HasIndex("TagId");

                    b.ToTable("MealTags");
                });

            modelBuilder.Entity("MealDelivery.Persistence.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("Id");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("MealDelivery.Persistence.Models.OrderItems", b =>
                {
                    b.Property<int>("MealItemId")
                        .HasColumnType("int");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.HasKey("MealItemId", "OrderId");

                    b.HasIndex("OrderId");

                    b.ToTable("OrderItems");
                });

            modelBuilder.Entity("MealDelivery.Persistence.Models.Restaurant", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Restaurants");
                });

            modelBuilder.Entity("MealDelivery.Persistence.Models.Tag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("MealDelivery.Persistence.Models.DeliveryDetail", b =>
                {
                    b.HasOne("MealDelivery.Persistence.Models.Order", null)
                        .WithMany("DeliveryDetails")
                        .HasForeignKey("OrderId");
                });

            modelBuilder.Entity("MealDelivery.Persistence.Models.MealTags", b =>
                {
                    b.HasOne("MealDelivery.Persistence.Models.MealItem", null)
                        .WithMany("MealTags")
                        .HasForeignKey("MealItemId");

                    b.HasOne("MealDelivery.Persistence.Models.Tag", null)
                        .WithMany("MealTags")
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MealDelivery.Persistence.Models.OrderItems", b =>
                {
                    b.HasOne("MealDelivery.Persistence.Models.MealItem", null)
                        .WithMany("OrderItems")
                        .HasForeignKey("MealItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MealDelivery.Persistence.Models.Order", null)
                        .WithMany("OrderItems")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MealDelivery.Persistence.Models.MealItem", b =>
                {
                    b.Navigation("MealTags");

                    b.Navigation("OrderItems");
                });

            modelBuilder.Entity("MealDelivery.Persistence.Models.Order", b =>
                {
                    b.Navigation("DeliveryDetails");

                    b.Navigation("OrderItems");
                });

            modelBuilder.Entity("MealDelivery.Persistence.Models.Tag", b =>
                {
                    b.Navigation("MealTags");
                });
#pragma warning restore 612, 618
        }
    }
}
