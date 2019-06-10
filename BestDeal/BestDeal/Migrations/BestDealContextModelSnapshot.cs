﻿// <auto-generated />
using System;
using BestDeal.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BestDeal.Migrations
{
    [DbContext(typeof(BestDealContext))]
    partial class BestDealContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BestDeal.Models.Artikal", b =>
                {
                    b.Property<int>("IdArtikla");

                    b.Property<double>("CijenaArtikla");

                    b.Property<string>("DetaljniOpis");

                    b.Property<string>("KratkiOpis")
                        .IsRequired();

                    b.Property<string>("NazivArtikla")
                        .IsRequired();

                    b.Property<int>("TipArtiklaidTipa");

                    b.Property<string>("URLMaleSlike1");

                    b.Property<string>("URLSlike1");

                    b.HasKey("IdArtikla");

                    b.HasIndex("TipArtiklaidTipa");

                    b.ToTable("Artikal");
                });

            modelBuilder.Entity("BestDeal.Models.Korpa", b =>
                {
                    b.Property<string>("IdKorpe")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.HasKey("IdKorpe");

                    b.ToTable("Korpa");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Korpa");
                });

            modelBuilder.Entity("BestDeal.Models.Narudzba", b =>
                {
                    b.Property<int>("IdNarudzbe")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DatumVrijemeNarudzbe");

                    b.Property<string>("OdabraniArtikliIdKorpe");

                    b.HasKey("IdNarudzbe");

                    b.HasIndex("OdabraniArtikliIdKorpe");

                    b.ToTable("Narudzba");
                });

            modelBuilder.Entity("BestDeal.Models.Obavijest", b =>
                {
                    b.Property<int>("IdObavijesti")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<string>("TekstObavijesti")
                        .IsRequired();

                    b.HasKey("IdObavijesti");

                    b.ToTable("Obavijest");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Obavijest");
                });

            modelBuilder.Entity("BestDeal.Models.Recenzija", b =>
                {
                    b.Property<int>("IdRecenzije")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("BatteryLifeRating");

                    b.Property<double>("DesignRating");

                    b.Property<double>("OverallRating");

                    b.Property<double>("PerformanceRating");

                    b.HasKey("IdRecenzije");

                    b.ToTable("Recenzija");
                });

            modelBuilder.Entity("BestDeal.Models.Tip", b =>
                {
                    b.Property<int>("idTipa");

                    b.Property<string>("Ime");

                    b.HasKey("idTipa");

                    b.ToTable("Tip");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("BestDeal.Models.KorpaInfo", b =>
                {
                    b.HasBaseType("BestDeal.Models.Korpa");

                    b.Property<int?>("AIdArtikla");

                    b.Property<string>("IdKorpe1");

                    b.Property<int>("KolicinaArtikla");

                    b.Property<string>("KorpaIdKorpe");

                    b.HasIndex("AIdArtikla");

                    b.HasIndex("KorpaIdKorpe");

                    b.ToTable("KorpaInfo");

                    b.HasDiscriminator().HasValue("KorpaInfo");
                });

            modelBuilder.Entity("BestDeal.Models.ChatObavijest", b =>
                {
                    b.HasBaseType("BestDeal.Models.Obavijest");

                    b.ToTable("ChatObavijest");

                    b.HasDiscriminator().HasValue("ChatObavijest");
                });

            modelBuilder.Entity("BestDeal.Models.NarudzbeObavijest", b =>
                {
                    b.HasBaseType("BestDeal.Models.Obavijest");

                    b.ToTable("NarudzbeObavijest");

                    b.HasDiscriminator().HasValue("NarudzbeObavijest");
                });

            modelBuilder.Entity("BestDeal.Models.Artikal", b =>
                {
                    b.HasOne("BestDeal.Models.Tip", "TipArtikla")
                        .WithMany()
                        .HasForeignKey("TipArtiklaidTipa")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BestDeal.Models.Narudzba", b =>
                {
                    b.HasOne("BestDeal.Models.Korpa", "OdabraniArtikli")
                        .WithMany()
                        .HasForeignKey("OdabraniArtikliIdKorpe");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BestDeal.Models.KorpaInfo", b =>
                {
                    b.HasOne("BestDeal.Models.Artikal", "A")
                        .WithMany()
                        .HasForeignKey("AIdArtikla");

                    b.HasOne("BestDeal.Models.Korpa")
                        .WithMany("ArtikliKolicina")
                        .HasForeignKey("KorpaIdKorpe");
                });
#pragma warning restore 612, 618
        }
    }
}
