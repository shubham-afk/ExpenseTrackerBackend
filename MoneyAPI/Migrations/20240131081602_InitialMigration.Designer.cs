﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace MoneyAPI.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240131081602_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("ExpenseApi.ExpenseData", b =>
                {
                    b.Property<string>("MonthName")
                        .HasColumnType("text");

                    b.Property<DateTime>("FirstExpenseDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("Food")
                        .HasColumnType("integer");

                    b.Property<int>("Investment")
                        .HasColumnType("integer");

                    b.Property<DateTime>("LatestExpenseDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("Luxury")
                        .HasColumnType("integer");

                    b.Property<int>("Miscellaneous")
                        .HasColumnType("integer");

                    b.Property<int>("NumberOfExpenses")
                        .HasColumnType("integer");

                    b.Property<int>("Personal")
                        .HasColumnType("integer");

                    b.Property<int>("TotalAmount")
                        .HasColumnType("integer");

                    b.HasKey("MonthName");

                    b.ToTable("ExpenseDatas");
                });
#pragma warning restore 612, 618
        }
    }
}
