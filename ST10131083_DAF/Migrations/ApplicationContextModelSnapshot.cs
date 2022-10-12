﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ST10131083_DAF.Data;

namespace ST10131083_DAF.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    partial class ApplicationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ST10131083_DAF.Models.Account.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("isActive")
                        .HasColumnType("bit");

                    b.HasKey("UserId");

                    b.ToTable("User");
                });

            modelBuilder.Entity("ST10131083_DAF.Models.Dashboard.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("ST10131083_DAF.Models.Dashboard.Disaster", b =>
                {
                    b.Property<int>("DisasterId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("AmountAllocation")
                        .HasColumnType("float");

                    b.Property<int>("Categoryid")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DisasterName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DisasterType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("DisasterId");

                    b.HasIndex("Categoryid");

                    b.ToTable("Disaster");
                });

            modelBuilder.Entity("ST10131083_DAF.Models.Dashboard.DisasterAllocation", b =>
                {
                    b.Property<int>("DisasterAllocationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AmountDonated")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AmountGoal")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("DisasterId")
                        .HasColumnType("int");

                    b.Property<string>("DisasterName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Donationid")
                        .HasColumnType("int");

                    b.Property<string>("GoodsDonated")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DisasterAllocationId");

                    b.HasIndex("DisasterId");

                    b.HasIndex("Donationid");

                    b.ToTable("DisasterAllocation");
                });

            modelBuilder.Entity("ST10131083_DAF.Models.Dashboard.Donation", b =>
                {
                    b.Property<int>("Donationid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Amount")
                        .HasColumnType("float");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("DisasterId")
                        .HasColumnType("int");

                    b.Property<string>("DisasterName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Fname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Lname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("Mobile")
                        .HasColumnType("bigint");

                    b.Property<int>("Userid")
                        .HasColumnType("int");

                    b.Property<bool>("isPrivate")
                        .HasColumnType("bit");

                    b.HasKey("Donationid");

                    b.HasIndex("DisasterId");

                    b.HasIndex("Userid");

                    b.ToTable("Donation");
                });

            modelBuilder.Entity("ST10131083_DAF.Models.Dashboard.Good", b =>
                {
                    b.Property<int>("Goodsid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("DisasterId")
                        .HasColumnType("int");

                    b.Property<string>("DisasterName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Fname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Lname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("Mobile")
                        .HasColumnType("bigint");

                    b.Property<int>("NumberofGoods")
                        .HasColumnType("int");

                    b.Property<int>("Userid")
                        .HasColumnType("int");

                    b.Property<bool>("isPrivate")
                        .HasColumnType("bit");

                    b.HasKey("Goodsid");

                    b.HasIndex("CategoryId");

                    b.HasIndex("DisasterId");

                    b.HasIndex("Userid");

                    b.ToTable("Good");
                });

            modelBuilder.Entity("ST10131083_DAF.Models.Dashboard.Disaster", b =>
                {
                    b.HasOne("ST10131083_DAF.Models.Dashboard.Category", "Category")
                        .WithMany("Disasters")
                        .HasForeignKey("Categoryid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("ST10131083_DAF.Models.Dashboard.DisasterAllocation", b =>
                {
                    b.HasOne("ST10131083_DAF.Models.Dashboard.Disaster", "Disaster")
                        .WithMany()
                        .HasForeignKey("DisasterId");

                    b.HasOne("ST10131083_DAF.Models.Dashboard.Donation", "Donation")
                        .WithMany()
                        .HasForeignKey("Donationid");

                    b.Navigation("Disaster");

                    b.Navigation("Donation");
                });

            modelBuilder.Entity("ST10131083_DAF.Models.Dashboard.Donation", b =>
                {
                    b.HasOne("ST10131083_DAF.Models.Dashboard.Disaster", "Disaster")
                        .WithMany()
                        .HasForeignKey("DisasterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ST10131083_DAF.Models.Account.User", "User")
                        .WithMany()
                        .HasForeignKey("Userid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Disaster");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ST10131083_DAF.Models.Dashboard.Good", b =>
                {
                    b.HasOne("ST10131083_DAF.Models.Dashboard.Category", null)
                        .WithMany("Goods")
                        .HasForeignKey("CategoryId");

                    b.HasOne("ST10131083_DAF.Models.Dashboard.Disaster", "Disaster")
                        .WithMany()
                        .HasForeignKey("DisasterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ST10131083_DAF.Models.Account.User", "User")
                        .WithMany()
                        .HasForeignKey("Userid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Disaster");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ST10131083_DAF.Models.Dashboard.Category", b =>
                {
                    b.Navigation("Disasters");

                    b.Navigation("Goods");
                });
#pragma warning restore 612, 618
        }
    }
}
