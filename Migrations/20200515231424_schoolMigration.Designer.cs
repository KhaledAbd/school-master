﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using school.Models;

namespace school.Migrations
{
    [DbContext(typeof(SchoolContext))]
    [Migration("20200515231424_schoolMigration")]
    partial class schoolMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("school.Models.Absent", b =>
                {
                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.Property<bool?>("AbsentCheck")
                        .HasColumnType("bit");

                    b.Property<DateTime>("DateAbsent")
                        .HasColumnType("datetime2");

                    b.HasKey("StudentId");

                    b.ToTable("Absent");
                });

            modelBuilder.Entity("school.Models.Class", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Stage")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Stage");

                    b.ToTable("Class");
                });

            modelBuilder.Entity("school.Models.Stage", b =>
                {
                    b.Property<int>("StageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NameStage")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StageId");

                    b.ToTable("Stage");
                });

            modelBuilder.Entity("school.Models.Student", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ClassFk")
                        .HasColumnType("int");

                    b.Property<int?>("StageId")
                        .HasColumnType("int");

                    b.Property<string>("StudentName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TimeAbsent")
                        .HasColumnType("int");

                    b.HasKey("StudentId");

                    b.HasIndex("ClassFk");

                    b.HasIndex("StageId");

                    b.ToTable("Student");
                });

            modelBuilder.Entity("school.Models.StudentAbsent", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<bool>("Is_rejected")
                        .HasColumnType("bit");

                    b.Property<int>("Times")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("StudentAbsent");
                });

            modelBuilder.Entity("school.Models.User", b =>
                {
                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserName");

                    b.ToTable("User");
                });

            modelBuilder.Entity("school.Models.Absent", b =>
                {
                    b.HasOne("school.Models.Student", "StudentNavigation")
                        .WithMany("AbsentNavigation")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("school.Models.Class", b =>
                {
                    b.HasOne("school.Models.Stage", "StageNavigation")
                        .WithMany("ClassNavigation")
                        .HasForeignKey("Stage")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("school.Models.Student", b =>
                {
                    b.HasOne("school.Models.Class", "ClassNavigation")
                        .WithMany("Student")
                        .HasForeignKey("ClassFk");

                    b.HasOne("school.Models.Stage", null)
                        .WithMany("StudentNavigation")
                        .HasForeignKey("StageId");
                });

            modelBuilder.Entity("school.Models.StudentAbsent", b =>
                {
                    b.HasOne("school.Models.Student", "StudentNavigation")
                        .WithMany()
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
