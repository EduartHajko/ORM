﻿// <auto-generated />
using System;
using ForingKey;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ForingKey.Migrations
{
    [DbContext(typeof(CustomerContext))]
    partial class CustomerContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ForingKey.Models.Costumer", b =>
                {
                    b.Property<int>("CostumerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CostumerID"));

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CostumerID");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("ForingKey.Models.Logs", b =>
                {
                    b.Property<int>("LogID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LogID"));

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<string>("ExceptionName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LogID");

                    b.ToTable("Logs");
                });

            modelBuilder.Entity("ForingKey.Models.OrderDetails", b =>
                {
                    b.Property<int>("DetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DetailId"));

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<string>("orderssOrderId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("DetailId");

                    b.HasIndex("orderssOrderId");

                    b.ToTable("OrdersDetails");
                });

            modelBuilder.Entity("ForingKey.Models.Orders", b =>
                {
                    b.Property<string>("OrderId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CostumerID")
                        .HasColumnType("int");

                    b.Property<string>("Destination")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OrderName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("OrderId");

                    b.HasIndex("CostumerID");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("ForingKey.Models.OrderDetails", b =>
                {
                    b.HasOne("ForingKey.Models.Orders", "orderss")
                        .WithMany("OrderDetails")
                        .HasForeignKey("orderssOrderId");

                    b.Navigation("orderss");
                });

            modelBuilder.Entity("ForingKey.Models.Orders", b =>
                {
                    b.HasOne("ForingKey.Models.Costumer", "costumer")
                        .WithMany("Orders")
                        .HasForeignKey("CostumerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("costumer");
                });

            modelBuilder.Entity("ForingKey.Models.Costumer", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("ForingKey.Models.Orders", b =>
                {
                    b.Navigation("OrderDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
