// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Project_Cms_v6.Context;

#nullable disable

namespace Project_Cms_v6.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230206034516_Relationship7")]
    partial class Relationship7
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Project_Cms_v6.Models.AccountRoles", b =>
                {
                    b.Property<string>("AccountNIK")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasIndex("AccountNIK");

                    b.HasIndex("RoleId");

                    b.ToTable("AccountRoles");
                });

            modelBuilder.Entity("Project_Cms_v6.Models.Accounts", b =>
                {
                    b.Property<string>("NIK")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("NIK");

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("Project_Cms_v6.Models.Departments", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Manager_Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Manager_Id")
                        .IsUnique()
                        .HasFilter("[Manager_Id] IS NOT NULL");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("Project_Cms_v6.Models.Employees", b =>
                {
                    b.Property<string>("NIK")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Departments_Id")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Manager_Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Salary")
                        .HasColumnType("int");

                    b.HasKey("NIK");

                    b.HasIndex("Departments_Id");

                    b.HasIndex("Manager_Id");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("Project_Cms_v6.Models.Roles", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("Project_Cms_v6.Models.AccountRoles", b =>
                {
                    b.HasOne("Project_Cms_v6.Models.Accounts", "Accounts")
                        .WithMany()
                        .HasForeignKey("AccountNIK");

                    b.HasOne("Project_Cms_v6.Models.Roles", "Roles")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Accounts");

                    b.Navigation("Roles");
                });

            modelBuilder.Entity("Project_Cms_v6.Models.Accounts", b =>
                {
                    b.HasOne("Project_Cms_v6.Models.Employees", "Employees")
                        .WithOne("Accounts")
                        .HasForeignKey("Project_Cms_v6.Models.Accounts", "NIK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employees");
                });

            modelBuilder.Entity("Project_Cms_v6.Models.Departments", b =>
                {
                    b.HasOne("Project_Cms_v6.Models.Employees", "Manager")
                        .WithOne("Manager_Department")
                        .HasForeignKey("Project_Cms_v6.Models.Departments", "Manager_Id");

                    b.Navigation("Manager");
                });

            modelBuilder.Entity("Project_Cms_v6.Models.Employees", b =>
                {
                    b.HasOne("Project_Cms_v6.Models.Departments", "Departments")
                        .WithMany("Employees")
                        .HasForeignKey("Departments_Id");

                    b.HasOne("Project_Cms_v6.Models.Employees", "Manager")
                        .WithMany("EmployeesManager")
                        .HasForeignKey("Manager_Id");

                    b.Navigation("Departments");

                    b.Navigation("Manager");
                });

            modelBuilder.Entity("Project_Cms_v6.Models.Departments", b =>
                {
                    b.Navigation("Employees");
                });

            modelBuilder.Entity("Project_Cms_v6.Models.Employees", b =>
                {
                    b.Navigation("Accounts");

                    b.Navigation("EmployeesManager");

                    b.Navigation("Manager_Department");
                });
#pragma warning restore 612, 618
        }
    }
}
