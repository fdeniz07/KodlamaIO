﻿// <auto-generated />
using System;
using Kodlama.io.Devs.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Kodlama.io.Devs.Persistence.Migrations
{
    [DbContext(typeof(BaseDbContext))]
    [Migration("20220906090818_mig-1")]
    partial class mig1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Kodlama.io.Devs.Api.Domain.Entities.ProgrammingLanguage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("Id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("CreatedByName")
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("ModifiedByName")
                        .HasColumnType("text");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("Name");

                    b.Property<string>("Note")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("ProgramminLanguage", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedByName = "Admin",
                            CreatedDate = new DateTime(2022, 9, 6, 9, 8, 18, 387, DateTimeKind.Utc).AddTicks(4529),
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedByName = "Admin",
                            ModifiedDate = new DateTime(2022, 9, 6, 9, 8, 18, 387, DateTimeKind.Utc).AddTicks(4529),
                            Name = "Java"
                        },
                        new
                        {
                            Id = 2,
                            CreatedByName = "Admin",
                            CreatedDate = new DateTime(2022, 9, 6, 9, 8, 18, 387, DateTimeKind.Utc).AddTicks(4531),
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedByName = "Admin",
                            ModifiedDate = new DateTime(2022, 9, 6, 9, 8, 18, 387, DateTimeKind.Utc).AddTicks(4531),
                            Name = "C#"
                        },
                        new
                        {
                            Id = 3,
                            CreatedByName = "Admin",
                            CreatedDate = new DateTime(2022, 9, 6, 9, 8, 18, 387, DateTimeKind.Utc).AddTicks(4532),
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedByName = "Admin",
                            ModifiedDate = new DateTime(2022, 9, 6, 9, 8, 18, 387, DateTimeKind.Utc).AddTicks(4532),
                            Name = "Python"
                        },
                        new
                        {
                            Id = 4,
                            CreatedByName = "Admin",
                            CreatedDate = new DateTime(2022, 9, 6, 9, 8, 18, 387, DateTimeKind.Utc).AddTicks(4532),
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedByName = "Admin",
                            ModifiedDate = new DateTime(2022, 9, 6, 9, 8, 18, 387, DateTimeKind.Utc).AddTicks(4533),
                            Name = "JavaScript"
                        },
                        new
                        {
                            Id = 5,
                            CreatedByName = "Admin",
                            CreatedDate = new DateTime(2022, 9, 6, 9, 8, 18, 387, DateTimeKind.Utc).AddTicks(4533),
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedByName = "Admin",
                            ModifiedDate = new DateTime(2022, 9, 6, 9, 8, 18, 387, DateTimeKind.Utc).AddTicks(4534),
                            Name = "Go"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
