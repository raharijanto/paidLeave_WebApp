﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using paidLeave_WebApp.Context;

namespace paidLeave_WebApp.Migrations
{
    [DbContext(typeof(MyContext))]
    [Migration("20220929215706_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.29")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("paidLeave_WebApp.Models.Cuti", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("JumlahCuti")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Cuti");
                });

            modelBuilder.Entity("paidLeave_WebApp.Models.Gaji", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("GajiAwal")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Gaji");
                });

            modelBuilder.Entity("paidLeave_WebApp.Models.Jabatan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Posisi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SalaryId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SalaryId");

                    b.ToTable("Jabatan");
                });

            modelBuilder.Entity("paidLeave_WebApp.Models.Karyawan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AmbilCuti")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nama")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PosisiId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AmbilCuti");

                    b.HasIndex("PosisiId");

                    b.ToTable("Karyawan");
                });

            modelBuilder.Entity("paidLeave_WebApp.Models.Netto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CutiId")
                        .HasColumnType("int");

                    b.Property<int>("GajiBersih")
                        .HasColumnType("int");

                    b.Property<int>("GajiId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CutiId");

                    b.HasIndex("GajiId");

                    b.ToTable("Netto");
                });

            modelBuilder.Entity("paidLeave_WebApp.Models.Jabatan", b =>
                {
                    b.HasOne("paidLeave_WebApp.Models.Gaji", "Gaji")
                        .WithMany()
                        .HasForeignKey("SalaryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("paidLeave_WebApp.Models.Karyawan", b =>
                {
                    b.HasOne("paidLeave_WebApp.Models.Cuti", "Cuti")
                        .WithMany()
                        .HasForeignKey("AmbilCuti")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("paidLeave_WebApp.Models.Jabatan", "Jabatan")
                        .WithMany()
                        .HasForeignKey("PosisiId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("paidLeave_WebApp.Models.Netto", b =>
                {
                    b.HasOne("paidLeave_WebApp.Models.Cuti", "Cuti")
                        .WithMany()
                        .HasForeignKey("CutiId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("paidLeave_WebApp.Models.Gaji", "Gaji")
                        .WithMany()
                        .HasForeignKey("GajiId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
