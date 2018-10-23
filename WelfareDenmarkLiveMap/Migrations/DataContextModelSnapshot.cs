﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WelfareDenmarkLiveMap.Models;

namespace WelfareDenmarkLiveMap.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WelfareDenmarkLiveMap.Models.County", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("ID");

                    b.ToTable("County");
                });

            modelBuilder.Entity("WelfareDenmarkLiveMap.Models.Exercise", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CompletionRate");

                    b.Property<int?>("ExerciseTypeID");

                    b.Property<int?>("SessionID");

                    b.HasKey("ID");

                    b.HasIndex("ExerciseTypeID");

                    b.HasIndex("SessionID");

                    b.ToTable("Exercise");
                });

            modelBuilder.Entity("WelfareDenmarkLiveMap.Models.ExerciseType", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("ID");

                    b.ToTable("ExerciseType");
                });

            modelBuilder.Entity("WelfareDenmarkLiveMap.Models.Patient", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CountyID");

                    b.Property<string>("Name");

                    b.HasKey("ID");

                    b.HasIndex("CountyID");

                    b.ToTable("Patients");
                });

            modelBuilder.Entity("WelfareDenmarkLiveMap.Models.Session", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CompletionRate");

                    b.Property<int?>("PatientID");

                    b.Property<DateTime>("Time");

                    b.HasKey("ID");

                    b.HasIndex("PatientID");

                    b.ToTable("Session");
                });

            modelBuilder.Entity("WelfareDenmarkLiveMap.Models.Exercise", b =>
                {
                    b.HasOne("WelfareDenmarkLiveMap.Models.ExerciseType", "ExerciseType")
                        .WithMany()
                        .HasForeignKey("ExerciseTypeID");

                    b.HasOne("WelfareDenmarkLiveMap.Models.Session", "Session")
                        .WithMany("Exercises")
                        .HasForeignKey("SessionID");
                });

            modelBuilder.Entity("WelfareDenmarkLiveMap.Models.Patient", b =>
                {
                    b.HasOne("WelfareDenmarkLiveMap.Models.County", "County")
                        .WithMany("Patients")
                        .HasForeignKey("CountyID");
                });

            modelBuilder.Entity("WelfareDenmarkLiveMap.Models.Session", b =>
                {
                    b.HasOne("WelfareDenmarkLiveMap.Models.Patient", "Patient")
                        .WithMany("Sessions")
                        .HasForeignKey("PatientID");
                });
#pragma warning restore 612, 618
        }
    }
}