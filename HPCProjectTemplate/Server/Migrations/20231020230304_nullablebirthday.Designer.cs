﻿// <auto-generated />
using System;
using HPCProjectTemplate.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HPCProjectTemplate.Server.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20231020230304_nullablebirthday")]
    partial class nullablebirthday
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.23")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Duende.IdentityServer.EntityFramework.Entities.DeviceFlowCodes", b =>
                {
                    b.Property<string>("UserCode")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("ClientId")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Data")
                        .IsRequired()
                        .HasMaxLength(50000)
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("DeviceCode")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime?>("Expiration")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<string>("SessionId")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("SubjectId")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("UserCode");

                    b.HasIndex("DeviceCode")
                        .IsUnique();

                    b.HasIndex("Expiration");

                    b.ToTable("DeviceCodes", (string)null);
                });

            modelBuilder.Entity("Duende.IdentityServer.EntityFramework.Entities.Key", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Algorithm")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("Data")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("DataProtected")
                        .HasColumnType("bit");

                    b.Property<bool>("IsX509Certificate")
                        .HasColumnType("bit");

                    b.Property<string>("Use")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Version")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Use");

                    b.ToTable("Keys");
                });

            modelBuilder.Entity("Duende.IdentityServer.EntityFramework.Entities.PersistedGrant", b =>
                {
                    b.Property<string>("Key")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("ClientId")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime?>("ConsumedTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Data")
                        .IsRequired()
                        .HasMaxLength(50000)
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime?>("Expiration")
                        .HasColumnType("datetime2");

                    b.Property<string>("SessionId")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("SubjectId")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Key");

                    b.HasIndex("ConsumedTime");

                    b.HasIndex("Expiration");

                    b.HasIndex("SubjectId", "ClientId", "Type");

                    b.HasIndex("SubjectId", "SessionId", "Type");

                    b.ToTable("PersistedGrants", (string)null);
                });

            modelBuilder.Entity("HPCProjectTemplate.Server.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("Birthday")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

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

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("HPCProjectTemplate.Shared.Plant", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ApplicationUserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("perenualId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationUserId");

                    b.HasIndex("perenualId", "ApplicationUserId")
                        .IsUnique();

                    b.ToTable("Plants");
                });

            modelBuilder.Entity("HPCProjectTemplate.Shared.PlantList", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<string>("common_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cycle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("image_id")
                        .HasColumnType("int");

                    b.Property<int>("license")
                        .HasColumnType("int");

                    b.Property<string>("license_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("license_url")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("medium_url")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("original_url")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("regular_url")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("small_url")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("thumbnail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("watering")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("PlantList");
                });

            modelBuilder.Entity("HPCProjectTemplate.Shared.Product", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<string>("brand")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("imageURL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("link")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("price")
                        .HasColumnType("float");

                    b.HasKey("id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            id = 1,
                            brand = "Schultz",
                            imageURL = "https://m.media-amazon.com/images/I/71klu8s1ByL._AC_SL1500_.jpg",
                            link = "https://www.amazon.com/Schultz-Purpose-Plant-10-15-10-1012/dp/B00BARNKVI",
                            name = "Plant Food",
                            price = 11.99
                        },
                        new
                        {
                            id = 2,
                            brand = "The Sill",
                            imageURL = "https://m.media-amazon.com/images/I/61pbHrnjtiL.__AC_SX300_SY300_QL70_FMwebp_.jpg",
                            link = "https://www.thesill.com/products/watering-can",
                            name = "Watering Can",
                            price = 15.0
                        },
                        new
                        {
                            id = 3,
                            brand = "RestMo",
                            imageURL = "https://m.media-amazon.com/images/I/6152WkWN1pL._AC_SL1500_.jpg",
                            link = "https://a.co/d/5wWRADc",
                            name = "Hose Nozzle",
                            price = 19.989999999999998
                        },
                        new
                        {
                            id = 4,
                            brand = "J&B",
                            imageURL = "https://m.media-amazon.com/images/I/51f02NCHHZL._AC_.jpg",
                            link = "https://a.co/d/7cKk3Ko",
                            name = "Hose",
                            price = 79.950000000000003
                        },
                        new
                        {
                            id = 5,
                            brand = "Cool Job",
                            imageURL = "https://m.media-amazon.com/images/I/81-H4AxC-HL._AC_SL1500_.jpg",
                            link = "https://a.co/d/8I984yK",
                            name = "Gardening Gloves",
                            price = 9.9900000000000002
                        },
                        new
                        {
                            id = 6,
                            brand = "Trendspot",
                            imageURL = "https://images.thdstatic.com/productImages/6f13eda0-b539-4f8e-af0b-efb8b7244c8b/svn/white-trendspot-plant-pots-cr01721s-06w-64_145.jpg",
                            link = "https://www.homedepot.com/p/Trendspot-6-in-White-Knack-Ceramic-Decorative-Planter-CR01721S-06W/314647810#overlay",
                            name = "Small Pot",
                            price = 15.0
                        },
                        new
                        {
                            id = 7,
                            brand = "Bloem Terra",
                            imageURL = "https://images.thdstatic.com/productImages/e96ac4ef-c26c-4650-9019-3d1620008850/svn/terra-cotta-bloem-plant-pots-50016c-64_145.jpg",
                            link = "https://www.homedepot.com/p/Bloem-Terra-16-in-Terra-Cotta-Plastic-Planter-50016C/301861355",
                            name = "Medium Pot",
                            price = 15.66
                        },
                        new
                        {
                            id = 8,
                            brand = "Style Selections",
                            imageURL = "https://mobileimages.lowes.com/productimages/2d392f1f-0a01-43da-becd-a6dd0265a3fc/03943290.jpg?size=mthb",
                            link = "https://www.lowes.com/pd/L-G-Solutions-19-3-in-W-x-12-1-in-H-Oak-Resin-Planter/50445052?cm_mmc=shp-_-c-_-prd-_-lwn-_-ggl-_-LIA_LWN_243_Planters-And-Outdoor-Decor-_-50445052-_-local-_-0-_-0&gclid=CjwKCAjwp8OpBhAFEiwAG7NaEm-5zdjPHY60pE4d1f2KqemFEiS5XFwjXcjXFBu_9pu2YFsbqq42XxoCkBsQAvD_BwE&gclsrc=aw.ds",
                            name = "Large Pot",
                            price = 16.98
                        },
                        new
                        {
                            id = 9,
                            brand = "Aplree",
                            imageURL = "https://m.media-amazon.com/images/I/41v5rWcdioL._SY450_.jpg",
                            link = "https://a.co/d/fWtmOMk",
                            name = "Spray Bottle",
                            price = 9.9900000000000002
                        },
                        new
                        {
                            id = 10,
                            brand = "Fox Farm",
                            imageURL = "https://m.media-amazon.com/images/I/617QtlPIYkL._AC_SL1008_.jpg",
                            link = "https://a.co/d/626DZLq",
                            name = "Potting Soil",
                            price = 23.989999999999998
                        },
                        new
                        {
                            id = 11,
                            brand = "Growneer",
                            imageURL = "https://m.media-amazon.com/images/I/61i6pPfDOXL._AC_SL1500_.jpg",
                            link = "https://a.co/d/1EtpyHh",
                            name = "Plant Saucer",
                            price = 14.99
                        },
                        new
                        {
                            id = 12,
                            brand = "Gouevn",
                            imageURL = "https://m.media-amazon.com/images/I/61sql7HKnrL._AC_SL1000_.jpg",
                            link = "https://a.co/d/gdYMp7P",
                            name = "Soil Moisture Meter",
                            price = 8.9700000000000006
                        },
                        new
                        {
                            id = 13,
                            brand = "Maxam",
                            imageURL = "https://m.media-amazon.com/images/I/81g9I5kaC4L._AC_SL1500_.jpg",
                            link = "https://a.co/d/2TyK4q0",
                            name = "Watering Globes",
                            price = 17.949999999999999
                        },
                        new
                        {
                            id = 14,
                            brand = "Flora Animalia",
                            imageURL = "https://media.self.com/photos/613a28d4761c8e04eaf65719/3:4/w_1280%2Cc_limit/untitled-1.png",
                            link = "https://cna.st/p/meh9fHuiYWLjmKvrfKeMpz4Kmp7XkzM8Z5wUSR8sWe9M8i3hFgPgGoRQonNHa9bHj1Xthh1KnADaRjTy7qPnSAnKAcWXCCcxoaSoEPHh1sHE7eGUthXFx3SvdAcBdee2QFYigTAJSignYsFnEd57TA6QtZh58sB7LPAe8oh4a?xid=fr1697744462979iih",
                            name = "Pruning Shears",
                            price = 24.0
                        },
                        new
                        {
                            id = 15,
                            brand = "Roadwater",
                            imageURL = "https://m.media-amazon.com/images/I/71lQbCwk-PL._AC_SL1500_.jpg",
                            link = "https://a.co/d/8gtjYit",
                            name = "Outdoor Plant Stand",
                            price = 32.990000000000002
                        },
                        new
                        {
                            id = 16,
                            brand = "PLantsHome",
                            imageURL = "https://m.media-amazon.com/images/I/61lUweEadvL._AC_SL1500_.jpg",
                            link = "https://a.co/d/i28n7fc",
                            name = "Indoor Plant Stand",
                            price = 20.989999999999998
                        },
                        new
                        {
                            id = 17,
                            brand = "Honeywell",
                            imageURL = "https://target.scene7.com/is/image/Target/GUEST_4b9d1941-405f-4c08-a881-0fd3c5c8f0bd?wid=800&hei=800&qlt=80&fmt=webp",
                            link = "https://www.target.com/p/honeywell-cool-mist-ultrasonic-humidifier/-/A-14568404?clkid=ba631689N5ca111ee8ddeddd158242021&cpng=PTID1&lnm=81938&afid=Self%20Commerce&ref=tgt_adv_xasd0002#lnk=sametab",
                            name = "Humidifier",
                            price = 41.990000000000002
                        },
                        new
                        {
                            id = 18,
                            brand = "Leonard",
                            imageURL = "https://www.amleo.com/media/catalog/product/cache/aa1841770a2aa8b05bb5b429e42f9ba2/a/t/ats1.jpg",
                            link = "https://www.amleo.com/leonard-complete-aluminum-gardening-tool-set/p/ATS1?utm_source=bing&utm_medium=cpc&utm_campaign=Bing%20Shopping%20%7C%20AM%20%7C%20Catch%20All&utm_term=&utm_content=301093518--1287528186799977--80470528555497&msclkid=d81a275df9081f3c4d65426c73b86712",
                            name = "Gardening Tool Set",
                            price = 54.689999999999998
                        },
                        new
                        {
                            id = 19,
                            brand = "Soltech Solutions",
                            imageURL = "https://m.media-amazon.com/images/I/61xA6AEkpKL._AC_SY679_.jpg",
                            link = "https://a.co/d/dVNNsly",
                            name = "LED Grow Light",
                            price = 149.99000000000001
                        },
                        new
                        {
                            id = 20,
                            brand = "Fiskars",
                            imageURL = "https://m.media-amazon.com/images/I/51C6b3bd4AL._AC_SL1280_.jpg",
                            link = "https://a.co/d/ceW5PG7",
                            name = "Hand Trowel",
                            price = 12.99
                        });
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

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
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

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
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

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("HPCProjectTemplate.Shared.Plant", b =>
                {
                    b.HasOne("HPCProjectTemplate.Server.Models.ApplicationUser", null)
                        .WithMany("FavoritePlants")
                        .HasForeignKey("ApplicationUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
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
                    b.HasOne("HPCProjectTemplate.Server.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("HPCProjectTemplate.Server.Models.ApplicationUser", null)
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

                    b.HasOne("HPCProjectTemplate.Server.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("HPCProjectTemplate.Server.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HPCProjectTemplate.Server.Models.ApplicationUser", b =>
                {
                    b.Navigation("FavoritePlants");
                });
#pragma warning restore 612, 618
        }
    }
}