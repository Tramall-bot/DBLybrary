﻿// <auto-generated />
using DBLybrary.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DBLybrary.Migrations
{
    [DbContext(typeof(lybraryContext))]
    [Migration("20201009121155_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DBLybrary.Models.Book", b =>
                {
                    b.Property<int>("BkId")
                        .HasColumnName("Bk_ID")
                        .HasColumnType("INT");

                    b.Property<string>("BkAuthor")
                        .IsRequired()
                        .HasColumnName("Bk_Author")
                        .HasColumnType("VARCHAR(16)");

                    b.Property<string>("BkName")
                        .IsRequired()
                        .HasColumnName("Bk_Name")
                        .HasColumnType("VARCHAR(16)");

                    b.Property<string>("BkRealiseDate")
                        .IsRequired()
                        .HasColumnName("Bk_Realise_Date")
                        .HasColumnType("VARCHAR(16)");

                    b.Property<int>("GenId")
                        .HasColumnName("Gen_ID")
                        .HasColumnType("INT");

                    b.Property<int>("PubId")
                        .HasColumnName("Pub_ID")
                        .HasColumnType("INT");

                    b.HasKey("BkId");

                    b.HasIndex("GenId");

                    b.HasIndex("PubId");

                    b.ToTable("Book");
                });

            modelBuilder.Entity("DBLybrary.Models.Employee", b =>
                {
                    b.Property<int>("EmpId")
                        .HasColumnName("Emp_ID")
                        .HasColumnType("INT");

                    b.Property<string>("EmpAddress")
                        .IsRequired()
                        .HasColumnName("Emp_Address")
                        .HasColumnType("VARCHAR(16)");

                    b.Property<int>("EmpAge")
                        .HasColumnName("Emp_Age")
                        .HasColumnType("INT");

                    b.Property<string>("EmpFullName")
                        .IsRequired()
                        .HasColumnName("Emp_Full_Name")
                        .HasColumnType("VARCHAR(16)");

                    b.Property<string>("EmpPassportData")
                        .IsRequired()
                        .HasColumnName("Emp_Passport_Data")
                        .HasColumnType("VARCHAR(16)");

                    b.Property<string>("EmpPhoneNumber")
                        .IsRequired()
                        .HasColumnName("Emp_Phone_Number")
                        .HasColumnType("VARCHAR(16)");

                    b.Property<string>("EmpSex")
                        .IsRequired()
                        .HasColumnName("Emp_Sex")
                        .HasColumnType("CHAR(16)");

                    b.Property<int>("PosId")
                        .HasColumnName("Pos_ID")
                        .HasColumnType("INT");

                    b.HasKey("EmpId");

                    b.HasIndex("PosId");

                    b.ToTable("Employee");
                });

            modelBuilder.Entity("DBLybrary.Models.Genre", b =>
                {
                    b.Property<int>("GenId")
                        .HasColumnName("Gen_ID")
                        .HasColumnType("INT");

                    b.Property<string>("GenDescription")
                        .IsRequired()
                        .HasColumnName("Gen_Description")
                        .HasColumnType("VARCHAR(16)");

                    b.Property<string>("GenName")
                        .IsRequired()
                        .HasColumnName("Gen_Name")
                        .HasColumnType("VARCHAR(16)");

                    b.HasKey("GenId");

                    b.ToTable("Genre");
                });

            modelBuilder.Entity("DBLybrary.Models.Position", b =>
                {
                    b.Property<int>("PosId")
                        .HasColumnName("Pos_ID")
                        .HasColumnType("INT");

                    b.Property<string>("PosDuties")
                        .IsRequired()
                        .HasColumnName("Pos_Duties")
                        .HasColumnType("VARCHAR(16)");

                    b.Property<string>("PosName")
                        .IsRequired()
                        .HasColumnName("Pos_Name")
                        .HasColumnType("VARCHAR(16)");

                    b.Property<string>("PosRequirements")
                        .IsRequired()
                        .HasColumnName("Pos_Requirements")
                        .HasColumnType("VARCHAR(16)");

                    b.Property<int>("PosSalary")
                        .HasColumnName("Pos_Salary")
                        .HasColumnType("INT");

                    b.HasKey("PosId");

                    b.ToTable("Position");
                });

            modelBuilder.Entity("DBLybrary.Models.Publisher", b =>
                {
                    b.Property<int>("PubId")
                        .HasColumnName("Pub_ID")
                        .HasColumnType("INT");

                    b.Property<string>("PubAddress")
                        .IsRequired()
                        .HasColumnName("Pub_Address")
                        .HasColumnType("VARCHAR(16)");

                    b.Property<string>("PubCity")
                        .IsRequired()
                        .HasColumnName("Pub_City")
                        .HasColumnType("VARCHAR(16)");

                    b.Property<string>("PubName")
                        .IsRequired()
                        .HasColumnName("Pub_Name")
                        .HasColumnType("VARCHAR(16)");

                    b.HasKey("PubId");

                    b.ToTable("Publisher");
                });

            modelBuilder.Entity("DBLybrary.Models.Reader", b =>
                {
                    b.Property<int>("RdId")
                        .HasColumnName("Rd_ID")
                        .HasColumnType("INT");

                    b.Property<string>("RdAddress")
                        .IsRequired()
                        .HasColumnName("Rd_Address")
                        .HasColumnType("VARCHAR(16)");

                    b.Property<string>("RdBdDate")
                        .IsRequired()
                        .HasColumnName("Rd_BD_Date")
                        .HasColumnType("VARCHAR(16)");

                    b.Property<string>("RdFullName")
                        .IsRequired()
                        .HasColumnName("Rd_Full_Name")
                        .HasColumnType("VARCHAR(16)");

                    b.Property<string>("RdPassportData")
                        .IsRequired()
                        .HasColumnName("Rd_Passport_Data")
                        .HasColumnType("VARCHAR(16)");

                    b.Property<string>("RdPhoneNumber")
                        .IsRequired()
                        .HasColumnName("Rd_Phone_Number")
                        .HasColumnType("VARCHAR(16)");

                    b.Property<string>("RdSex")
                        .IsRequired()
                        .HasColumnName("Rd_Sex")
                        .HasColumnType("CHAR(16)");

                    b.HasKey("RdId");

                    b.ToTable("Reader");
                });

            modelBuilder.Entity("DBLybrary.Models.ReturnedBooks", b =>
                {
                    b.Property<int>("BkId")
                        .HasColumnName("Bk_ID")
                        .HasColumnType("INT");

                    b.Property<int>("EmpId")
                        .HasColumnName("Emp_ID")
                        .HasColumnType("INT");

                    b.Property<string>("RbGiveOutDate")
                        .IsRequired()
                        .HasColumnName("Rb_GiveOut_Date")
                        .HasColumnType("VARCHAR(16)");

                    b.Property<string>("RbReturnDate")
                        .IsRequired()
                        .HasColumnName("Rb_Return_Date")
                        .HasColumnType("VARCHAR(16)");

                    b.Property<int>("RbReturnFlag")
                        .HasColumnName("Rb_Return_Flag")
                        .HasColumnType("INT");

                    b.Property<int>("RdId")
                        .HasColumnName("Rd_ID")
                        .HasColumnType("INT");

                    b.HasIndex("BkId");

                    b.HasIndex("EmpId");

                    b.HasIndex("RdId");

                    b.ToTable("Returned_Books");
                });

            modelBuilder.Entity("DBLybrary.Models.Book", b =>
                {
                    b.HasOne("DBLybrary.Models.Genre", "Gen")
                        .WithMany("Book")
                        .HasForeignKey("GenId")
                        .IsRequired();

                    b.HasOne("DBLybrary.Models.Publisher", "Pub")
                        .WithMany("Book")
                        .HasForeignKey("PubId")
                        .IsRequired();
                });

            modelBuilder.Entity("DBLybrary.Models.Employee", b =>
                {
                    b.HasOne("DBLybrary.Models.Position", "Pos")
                        .WithMany("Employee")
                        .HasForeignKey("PosId")
                        .IsRequired();
                });

            modelBuilder.Entity("DBLybrary.Models.ReturnedBooks", b =>
                {
                    b.HasOne("DBLybrary.Models.Book", "Bk")
                        .WithMany()
                        .HasForeignKey("BkId")
                        .IsRequired();

                    b.HasOne("DBLybrary.Models.Employee", "Emp")
                        .WithMany()
                        .HasForeignKey("EmpId")
                        .IsRequired();

                    b.HasOne("DBLybrary.Models.Reader", "Rd")
                        .WithMany()
                        .HasForeignKey("RdId")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
