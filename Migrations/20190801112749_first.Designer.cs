﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ScreenProject;

namespace ScreenProject.Migrations
{
    [DbContext(typeof(MyAppContext))]
    [Migration("20190801112749_first")]
    partial class first
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.1-servicing-10028")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ScreenProject.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DOB");

                    b.Property<string>("Email");

                    b.Property<string>("FName");

                    b.Property<string>("JobTitle");

                    b.Property<string>("LName");

                    b.Property<DateTime>("StartDate");

                    b.Property<string>("Status");

                    b.HasKey("Id");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("ScreenProject.Models.Event", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("EndDate");

                    b.Property<int>("Priority");

                    b.Property<string>("Repeat");

                    b.Property<DateTime>("StartDate");

                    b.Property<int>("TemplateId");

                    b.HasKey("Id");

                    b.HasIndex("TemplateId");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("ScreenProject.Models.EventField", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("EventId");

                    b.Property<int>("TemplateFieldId");

                    b.Property<string>("Value");

                    b.HasKey("Id");

                    b.HasIndex("EventId");

                    b.HasIndex("TemplateFieldId");

                    b.ToTable("EventFields");
                });

            modelBuilder.Entity("ScreenProject.Models.Template", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BackGroundImg");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Templates");
                });

            modelBuilder.Entity("ScreenProject.Models.TemplateField", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FontColor");

                    b.Property<string>("FontFamily");

                    b.Property<int>("FontSize");

                    b.Property<string>("LeftPosition");

                    b.Property<string>("Name");

                    b.Property<int?>("TemplateId");

                    b.Property<string>("TopPosition");

                    b.HasKey("Id");

                    b.HasIndex("TemplateId");

                    b.ToTable("TemplateFields");
                });

            modelBuilder.Entity("ScreenProject.Models.Event", b =>
                {
                    b.HasOne("ScreenProject.Models.Template", "MyTemplate")
                        .WithMany("Events")
                        .HasForeignKey("TemplateId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ScreenProject.Models.EventField", b =>
                {
                    b.HasOne("ScreenProject.Models.Event", "MyEvent")
                        .WithMany("EventFields")
                        .HasForeignKey("EventId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("ScreenProject.Models.TemplateField", "MyTemplateField")
                        .WithMany("EventFields")
                        .HasForeignKey("TemplateFieldId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ScreenProject.Models.TemplateField", b =>
                {
                    b.HasOne("ScreenProject.Models.Template", "MyTemplate")
                        .WithMany("TemplateFields")
                        .HasForeignKey("TemplateId")
                        .OnDelete(DeleteBehavior.SetNull);
                });
#pragma warning restore 612, 618
        }
    }
}
