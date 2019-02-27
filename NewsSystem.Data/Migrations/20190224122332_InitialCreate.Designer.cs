﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NewsSystem.Data.DataContext;

namespace NewsSystem.Data.Migrations
{
    [DbContext(typeof(NewsContext))]
    [Migration("20190224122332_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("NewsSystem.Data.Models.Image", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ImageUrl");

                    b.Property<int?>("NewsID");

                    b.HasKey("ID");

                    b.HasIndex("NewsID");

                    b.ToTable("Image");
                });

            modelBuilder.Entity("NewsSystem.Data.Models.News", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("Image")
                        .HasMaxLength(255);

                    b.Property<int>("Reads");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<int?>("UserID");

                    b.Property<DateTime>("insertionDate");

                    b.Property<bool>("isActive");

                    b.Property<string>("shortDescription");

                    b.HasKey("ID");

                    b.HasIndex("UserID");

                    b.ToTable("News");
                });

            modelBuilder.Entity("NewsSystem.Data.Models.Role", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("RoleName")
                        .HasMaxLength(150);

                    b.HasKey("ID");

                    b.ToTable("Role");
                });

            modelBuilder.Entity("NewsSystem.Data.Models.User", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateOFRegistration");

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<bool>("IsActive");

                    b.Property<string>("NameSurname")
                        .HasMaxLength(150);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(16);

                    b.Property<int?>("RoleID");

                    b.HasKey("ID");

                    b.HasIndex("RoleID");

                    b.ToTable("User");
                });

            modelBuilder.Entity("NewsSystem.Data.Models.Image", b =>
                {
                    b.HasOne("NewsSystem.Data.Models.News", "News")
                        .WithMany("Images")
                        .HasForeignKey("NewsID");
                });

            modelBuilder.Entity("NewsSystem.Data.Models.News", b =>
                {
                    b.HasOne("NewsSystem.Data.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserID");
                });

            modelBuilder.Entity("NewsSystem.Data.Models.User", b =>
                {
                    b.HasOne("NewsSystem.Data.Models.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleID");
                });
#pragma warning restore 612, 618
        }
    }
}
