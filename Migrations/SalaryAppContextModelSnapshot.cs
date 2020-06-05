﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SalaryApp.Data;

namespace SalaryApp.Migrations
{
    [DbContext(typeof(SalaryAppContext))]
    partial class SalaryAppContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SalaryApp.Models.Allowance", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("OvertimeId")
                        .HasColumnType("int");

                    b.Property<int>("bonusKPI")
                        .HasColumnType("int");

                    b.Property<int>("lunchCharge")
                        .HasColumnType("int");

                    b.Property<int>("phoneCharge")
                        .HasColumnType("int");

                    b.Property<int>("uniformsCharge")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OvertimeId")
                        .IsUnique();

                    b.ToTable("Allowance");
                });

            modelBuilder.Entity("SalaryApp.Models.Overtime", b =>
                {
                    b.Property<int>("OverTimeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("SalaryId")
                        .HasColumnType("int");

                    b.Property<int>("dayOff")
                        .HasColumnType("int");

                    b.Property<int>("overtimeHours")
                        .HasColumnType("int");

                    b.Property<int>("overtimeSalary")
                        .HasColumnType("int");

                    b.HasKey("OverTimeId");

                    b.HasIndex("SalaryId");

                    b.ToTable("Overtime");
                });

            modelBuilder.Entity("SalaryApp.Models.Salary", b =>
                {
                    b.Property<int>("SalaryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("StaffId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("basicSalary")
                        .HasColumnType("int");

                    b.Property<int>("chargeInsurrance")
                        .HasColumnType("int");

                    b.Property<int>("chargeTax")
                        .HasColumnType("int");

                    b.Property<DateTime>("dayTakeId")
                        .HasColumnType("datetime2");

                    b.Property<int>("keepSalary")
                        .HasColumnType("int");

                    b.Property<int>("supportCash")
                        .HasColumnType("int");

                    b.Property<int>("totalSalary")
                        .HasColumnType("int");

                    b.HasKey("SalaryId");

                    b.HasIndex("StaffId");

                    b.ToTable("Salary");
                });

            modelBuilder.Entity("SalaryApp.Models.Staff", b =>
                {
                    b.Property<string>("StaffId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Regency")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("dayIn")
                        .HasColumnType("datetime2");

                    b.HasKey("StaffId");

                    b.ToTable("Staff");
                });

            modelBuilder.Entity("SalaryApp.Models.Allowance", b =>
                {
                    b.HasOne("SalaryApp.Models.Overtime", "Overtime")
                        .WithOne("Allowance")
                        .HasForeignKey("SalaryApp.Models.Allowance", "OvertimeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SalaryApp.Models.Overtime", b =>
                {
                    b.HasOne("SalaryApp.Models.Salary", "Salary")
                        .WithMany("Overtimes")
                        .HasForeignKey("SalaryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SalaryApp.Models.Salary", b =>
                {
                    b.HasOne("SalaryApp.Models.Staff", "Staff")
                        .WithMany("Salaries")
                        .HasForeignKey("StaffId");
                });
#pragma warning restore 612, 618
        }
    }
}
