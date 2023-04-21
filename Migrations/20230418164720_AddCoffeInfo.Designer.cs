﻿// <auto-generated />
using CoffeeShop.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CoffeeShop.Migrations
{
    [DbContext(typeof(CoffeeContext))]
    [Migration("20230418164720_AddCoffeInfo")]
    partial class AddCoffeInfo
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.13");

            modelBuilder.Entity("CoffeeShop.Models.Coffee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("id");

                    b.Property<int>("Count")
                        .HasColumnType("INTEGER")
                        .HasColumnName("count");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT")
                        .HasColumnName("descr");

                    b.Property<string>("Img")
                        .HasColumnType("TEXT")
                        .HasColumnName("img");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT")
                        .HasColumnName("name");

                    b.Property<float>("Price")
                        .HasColumnType("REAL")
                        .HasColumnName("price");

                    b.HasKey("Id");

                    b.ToTable("Coffees");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Count = 100,
                            Description = "готовится как двойная порция эспрессо, две закладки кофе и два объема воды.",
                            Img = "1.jpg",
                            Name = "Доппио",
                            Price = 130f
                        },
                        new
                        {
                            Id = 2,
                            Count = 100,
                            Description = "эспрессо обычный или двойной, в который после приготовления добавили (30–470 мл) горячей воды.",
                            Img = "2.jpg",
                            Name = "Американо",
                            Price = 80f
                        },
                        new
                        {
                            Id = 3,
                            Count = 100,
                            Description = "спрессо заваренный из того же количества кофе и за то же время экстракции, но с использованием вдвое меньшего количества воды.",
                            Img = "3.jpg",
                            Name = "Ристретто",
                            Price = 180f
                        },
                        new
                        {
                            Id = 4,
                            Count = 100,
                            Description = "похож на Американо по пропорции воды к кофе. Однако, этот объем воды используется при заваривании (пропускается через кофе), в противоположность Американо, где вода заливается в готовый эспрессо.",
                            Img = "4.jpg",
                            Name = "Лунго",
                            Price = 160f
                        },
                        new
                        {
                            Id = 5,
                            Count = 100,
                            Description = " еще более длинный Лунго. До 50-х годов caffe crema называли эспрессо.",
                            Img = "5.jpg",
                            Name = "Кафе крема",
                            Price = 200f
                        },
                        new
                        {
                            Id = 6,
                            Count = 100,
                            Description = "напиток приготовленный с помощью рожковой эспрессо-машины. Принципиальные различия во вкусе достигаются благодаря более длительному времени экстракции",
                            Img = "6.jpg",
                            Name = "Эспресс",
                            Price = 150f
                        });
                });

            modelBuilder.Entity("CoffeeShop.Models.Coin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("id");

                    b.Property<bool>("Active")
                        .HasColumnType("INTEGER")
                        .HasColumnName("active");

                    b.Property<int>("Count")
                        .HasColumnType("INTEGER")
                        .HasColumnName("count");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT")
                        .HasColumnName("name");

                    b.Property<float>("Value")
                        .HasColumnType("REAL")
                        .HasColumnName("value");

                    b.HasKey("Id");

                    b.ToTable("Coins");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Active = true,
                            Count = 10000,
                            Name = "1 Рубль",
                            Value = 1f
                        },
                        new
                        {
                            Id = 2,
                            Active = false,
                            Count = 10000,
                            Name = "2 Рубля",
                            Value = 2f
                        },
                        new
                        {
                            Id = 3,
                            Active = true,
                            Count = 10000,
                            Name = "5 Рублей",
                            Value = 5f
                        },
                        new
                        {
                            Id = 4,
                            Active = true,
                            Count = 10000,
                            Name = "10 Рублей",
                            Value = 10f
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
