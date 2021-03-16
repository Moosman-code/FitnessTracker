﻿// <auto-generated />
using System;
using FitnessTracker.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FitnessTracker.Migrations
{
    [DbContext(typeof(FitnessTrackerDBContext))]
    [Migration("20210315223122_WorkoutNamemigration")]
    partial class WorkoutNamemigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ExcerciseWorkout", b =>
                {
                    b.Property<int>("ExercisesId")
                        .HasColumnType("int");

                    b.Property<int>("WorkoutsId")
                        .HasColumnType("int");

                    b.HasKey("ExercisesId", "WorkoutsId");

                    b.HasIndex("WorkoutsId");

                    b.ToTable("ExcerciseWorkout");
                });

            modelBuilder.Entity("FitnessTracker.Models.BodyPart", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("BodyParts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Core"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Arms"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Back"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Chest"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Legs"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Shoulders"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Other"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Full Body"
                        });
                });

            modelBuilder.Entity("FitnessTracker.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Cardio"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Dumbbell"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Bodyweight"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Barbell"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Machine/Other"
                        });
                });

            modelBuilder.Entity("FitnessTracker.Models.Excercise", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BodypartId")
                        .HasColumnType("int");

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("BodypartId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("UserId");

                    b.ToTable("Exercises");
                });

            modelBuilder.Entity("FitnessTracker.Models.Food", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Calories")
                        .HasColumnType("int");

                    b.Property<int>("Carbohydrates")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateAdded")
                        .HasColumnType("datetime2");

                    b.Property<int>("Fat")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Protein")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Foods");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Calories = 119,
                            Carbohydrates = 0,
                            DateAdded = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fat = 3,
                            Name = "Boneless, Skinless Chicken Breast",
                            Protein = 23
                        },
                        new
                        {
                            Id = 2,
                            Calories = 81,
                            Carbohydrates = 0,
                            DateAdded = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fat = 1,
                            Name = "Tuna(water packed), can",
                            Protein = 18
                        },
                        new
                        {
                            Id = 3,
                            Calories = 78,
                            Carbohydrates = 0,
                            DateAdded = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fat = 2,
                            Name = "Salmon Filet",
                            Protein = 15
                        },
                        new
                        {
                            Id = 4,
                            Calories = 123,
                            Carbohydrates = 0,
                            DateAdded = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fat = 3,
                            Name = "Schrimp",
                            Protein = 24
                        },
                        new
                        {
                            Id = 5,
                            Calories = 121,
                            Carbohydrates = 0,
                            DateAdded = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fat = 4,
                            Name = "Extra Lean Ground Beef or Ground Round",
                            Protein = 24
                        },
                        new
                        {
                            Id = 6,
                            Calories = 69,
                            Carbohydrates = 0,
                            DateAdded = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fat = 5,
                            Name = "Egg",
                            Protein = 6
                        },
                        new
                        {
                            Id = 7,
                            Calories = 52,
                            Carbohydrates = 0,
                            DateAdded = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fat = 0,
                            Name = "Egg Whites",
                            Protein = 11
                        },
                        new
                        {
                            Id = 8,
                            Calories = 235,
                            Carbohydrates = 0,
                            DateAdded = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fat = 15,
                            Name = "Rib eye Steak",
                            Protein = 25
                        },
                        new
                        {
                            Id = 9,
                            Calories = 212,
                            Carbohydrates = 0,
                            DateAdded = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fat = 8,
                            Name = "Top round Steak",
                            Protein = 35
                        },
                        new
                        {
                            Id = 10,
                            Calories = 275,
                            Carbohydrates = 0,
                            DateAdded = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fat = 15,
                            Name = "Sirloin steak",
                            Protein = 35
                        },
                        new
                        {
                            Id = 11,
                            Calories = 200,
                            Carbohydrates = 0,
                            DateAdded = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fat = 8,
                            Name = "Filet Mignon",
                            Protein = 32
                        },
                        new
                        {
                            Id = 12,
                            Calories = 100,
                            Carbohydrates = 0,
                            DateAdded = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fat = 4,
                            Name = "NY Strip Steak",
                            Protein = 16
                        },
                        new
                        {
                            Id = 13,
                            Calories = 200,
                            Carbohydrates = 0,
                            DateAdded = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fat = 8,
                            Name = "Flank Steak(Stir Fry, Fajita)",
                            Protein = 32
                        },
                        new
                        {
                            Id = 14,
                            Calories = 146,
                            Carbohydrates = 0,
                            DateAdded = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fat = 6,
                            Name = "Pork Loin",
                            Protein = 23
                        },
                        new
                        {
                            Id = 15,
                            Calories = 122,
                            Carbohydrates = 0,
                            DateAdded = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fat = 2,
                            Name = "Ground turkey(Turkey Breast Slices or cutlets(fresh meat, not deli cuts)",
                            Protein = 26
                        },
                        new
                        {
                            Id = 16,
                            Calories = 100,
                            Carbohydrates = 23,
                            DateAdded = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fat = 0,
                            Name = "Sweet Potatoes, raw",
                            Protein = 2
                        },
                        new
                        {
                            Id = 17,
                            Calories = 272,
                            Carbohydrates = 62,
                            DateAdded = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fat = 0,
                            Name = "Quinoa",
                            Protein = 6
                        },
                        new
                        {
                            Id = 18,
                            Calories = 347,
                            Carbohydrates = 60,
                            DateAdded = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fat = 7,
                            Name = "Oats",
                            Protein = 11
                        },
                        new
                        {
                            Id = 19,
                            Calories = 459,
                            Carbohydrates = 96,
                            DateAdded = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fat = 3,
                            Name = "Old Fashioned Grifts",
                            Protein = 12
                        },
                        new
                        {
                            Id = 20,
                            Calories = 360,
                            Carbohydrates = 84,
                            DateAdded = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fat = 0,
                            Name = "White Rice",
                            Protein = 6
                        },
                        new
                        {
                            Id = 21,
                            Calories = 88,
                            Carbohydrates = 20,
                            DateAdded = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fat = 0,
                            Name = "White Potatoes, raw",
                            Protein = 2
                        },
                        new
                        {
                            Id = 22,
                            Calories = 12,
                            Carbohydrates = 2,
                            DateAdded = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fat = 0,
                            Name = "Lettuce",
                            Protein = 1
                        },
                        new
                        {
                            Id = 23,
                            Calories = 32,
                            Carbohydrates = 6,
                            DateAdded = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fat = 0,
                            Name = "Broccoli",
                            Protein = 2
                        },
                        new
                        {
                            Id = 24,
                            Calories = 24,
                            Carbohydrates = 4,
                            DateAdded = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fat = 0,
                            Name = "Asparagus",
                            Protein = 2
                        },
                        new
                        {
                            Id = 25,
                            Calories = 8,
                            Carbohydrates = 1,
                            DateAdded = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fat = 0,
                            Name = "Spinach",
                            Protein = 1
                        },
                        new
                        {
                            Id = 26,
                            Calories = 12,
                            Carbohydrates = 2,
                            DateAdded = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fat = 0,
                            Name = "Multi Colored Bell Peppers",
                            Protein = 1
                        },
                        new
                        {
                            Id = 27,
                            Calories = 20,
                            Carbohydrates = 4,
                            DateAdded = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fat = 0,
                            Name = "Brussels Sprouts",
                            Protein = 1
                        },
                        new
                        {
                            Id = 28,
                            Calories = 28,
                            Carbohydrates = 5,
                            DateAdded = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fat = 0,
                            Name = "Cauliflower",
                            Protein = 2
                        },
                        new
                        {
                            Id = 29,
                            Calories = 24,
                            Carbohydrates = 4,
                            DateAdded = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fat = 0,
                            Name = "Zucchini",
                            Protein = 2
                        },
                        new
                        {
                            Id = 30,
                            Calories = 20,
                            Carbohydrates = 4,
                            DateAdded = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fat = 0,
                            Name = "Cucumber",
                            Protein = 1
                        },
                        new
                        {
                            Id = 31,
                            Calories = 16,
                            Carbohydrates = 2,
                            DateAdded = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fat = 0,
                            Name = "Mushrooms",
                            Protein = 2
                        },
                        new
                        {
                            Id = 32,
                            Calories = 60,
                            Carbohydrates = 15,
                            DateAdded = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fat = 0,
                            Name = "Apple",
                            Protein = 0
                        },
                        new
                        {
                            Id = 33,
                            Calories = 112,
                            Carbohydrates = 27,
                            DateAdded = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fat = 0,
                            Name = "Banana",
                            Protein = 1
                        },
                        new
                        {
                            Id = 34,
                            Calories = 80,
                            Carbohydrates = 19,
                            DateAdded = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fat = 0,
                            Name = "Mango",
                            Protein = 1
                        },
                        new
                        {
                            Id = 35,
                            Calories = 72,
                            Carbohydrates = 16,
                            DateAdded = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fat = 0,
                            Name = "Navel orange",
                            Protein = 2
                        },
                        new
                        {
                            Id = 36,
                            Calories = 44,
                            Carbohydrates = 11,
                            DateAdded = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fat = 0,
                            Name = "Blueberries",
                            Protein = 0
                        },
                        new
                        {
                            Id = 37,
                            Calories = 40,
                            Carbohydrates = 9,
                            DateAdded = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fat = 0,
                            Name = "Strawberries",
                            Protein = 1
                        },
                        new
                        {
                            Id = 38,
                            Calories = 60,
                            Carbohydrates = 14,
                            DateAdded = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fat = 0,
                            Name = "Blackberries",
                            Protein = 1
                        },
                        new
                        {
                            Id = 39,
                            Calories = 704,
                            Carbohydrates = 28,
                            DateAdded = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fat = 56,
                            Name = "Almond Butter",
                            Protein = 22
                        },
                        new
                        {
                            Id = 40,
                            Calories = 1008,
                            Carbohydrates = 0,
                            DateAdded = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fat = 112,
                            Name = "Olive Oil",
                            Protein = 0
                        },
                        new
                        {
                            Id = 41,
                            Calories = 504,
                            Carbohydrates = 0,
                            DateAdded = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fat = 56,
                            Name = "Clarified or organic butter",
                            Protein = 0
                        },
                        new
                        {
                            Id = 42,
                            Calories = 1008,
                            Carbohydrates = 0,
                            DateAdded = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fat = 112,
                            Name = "Coconut oil",
                            Protein = 0
                        },
                        new
                        {
                            Id = 43,
                            Calories = 142,
                            Carbohydrates = 2,
                            DateAdded = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fat = 14,
                            Name = "Avocado",
                            Protein = 2
                        });
                });

            modelBuilder.Entity("FitnessTracker.Models.Workout", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Workouts");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityUser");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("FitnessTracker.Models.User", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Height")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Weight")
                        .HasColumnType("int");

                    b.HasDiscriminator().HasValue("User");
                });

            modelBuilder.Entity("ExcerciseWorkout", b =>
                {
                    b.HasOne("FitnessTracker.Models.Excercise", null)
                        .WithMany()
                        .HasForeignKey("ExercisesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FitnessTracker.Models.Workout", null)
                        .WithMany()
                        .HasForeignKey("WorkoutsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FitnessTracker.Models.Excercise", b =>
                {
                    b.HasOne("FitnessTracker.Models.BodyPart", "Bodypart")
                        .WithMany("Excercises")
                        .HasForeignKey("BodypartId");

                    b.HasOne("FitnessTracker.Models.Category", "Category")
                        .WithMany("Excercises")
                        .HasForeignKey("CategoryId");

                    b.HasOne("FitnessTracker.Models.User", "User")
                        .WithMany("Excercises")
                        .HasForeignKey("UserId");

                    b.Navigation("Bodypart");

                    b.Navigation("Category");

                    b.Navigation("User");
                });

            modelBuilder.Entity("FitnessTracker.Models.Food", b =>
                {
                    b.HasOne("FitnessTracker.Models.User", "User")
                        .WithMany("Foods")
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("FitnessTracker.Models.Workout", b =>
                {
                    b.HasOne("FitnessTracker.Models.User", "user")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("user");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FitnessTracker.Models.BodyPart", b =>
                {
                    b.Navigation("Excercises");
                });

            modelBuilder.Entity("FitnessTracker.Models.Category", b =>
                {
                    b.Navigation("Excercises");
                });

            modelBuilder.Entity("FitnessTracker.Models.User", b =>
                {
                    b.Navigation("Excercises");

                    b.Navigation("Foods");
                });
#pragma warning restore 612, 618
        }
    }
}
