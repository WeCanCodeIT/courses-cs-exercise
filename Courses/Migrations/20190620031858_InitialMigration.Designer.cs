﻿// <auto-generated />
using Courses;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Courses.Migrations
{
    [DbContext(typeof(UniversityContext))]
    [Migration("20190620031858_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Courses.Models.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Courses");

                    b.HasData(
                        new { Id = 1, Description = "Machine learning for humans", Name = "Machine Learning" },
                        new { Id = 2, Description = "It's all you need to learn it all", Name = "C# for Smarties" },
                        new { Id = 3, Description = "OMG, the front end will become your BFF", Name = "HTML, CSS, JS, oh my!" }
                    );
                });
#pragma warning restore 612, 618
        }
    }
}