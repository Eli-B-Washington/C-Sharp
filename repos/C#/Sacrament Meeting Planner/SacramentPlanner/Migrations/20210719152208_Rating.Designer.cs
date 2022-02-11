﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SacramentPlanner.Models;

namespace SacramentPlanner.Migrations
{
    [DbContext(typeof(SacramentPlannerContext))]
    [Migration("20210719152208_Rating")]
    partial class Rating
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SacramentPlanner.Models.Speaker", b =>
                {
                    b.Property<int>("SpeakerID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("Subject")
                        .IsRequired();

                    b.Property<int>("SundayID");

                    b.HasKey("SpeakerID");

                    b.HasIndex("SundayID");

                    b.ToTable("Speaker");
                });

            modelBuilder.Entity("SacramentPlanner.Models.Sunday", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClosingHymn");

                    b.Property<string>("ClosingPrayer")
                        .IsRequired();

                    b.Property<string>("Conductor")
                        .IsRequired();

                    b.Property<DateTime>("Date");

                    b.Property<string>("IntermediateSong");

                    b.Property<int>("OpeningHymn");

                    b.Property<string>("OpeningPrayer")
                        .IsRequired();

                    b.Property<int>("SacramentHymn");

                    b.Property<string>("Theme");

                    b.HasKey("Id");

                    b.ToTable("Sunday");
                });

            modelBuilder.Entity("SacramentPlanner.Models.Speaker", b =>
                {
                    b.HasOne("SacramentPlanner.Models.Sunday", "Sunday")
                        .WithMany("Speakers")
                        .HasForeignKey("SundayID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
