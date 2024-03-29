﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Plant_A_Plant.Data;

namespace PlantAPlant.Data.Migrations
{
    [DbContext(typeof(PaPDbContext))]
    partial class PaPDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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

            modelBuilder.Entity("Plant_A_Plant.Data.Models.Event", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedOn");

                    b.Property<DateTime?>("DeletedOn");

                    b.Property<Guid>("FieldId");

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTime?>("ModifiedOn");

                    b.Property<string>("PaPUserId");

                    b.HasKey("Id");

                    b.HasIndex("PaPUserId");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("Plant_A_Plant.Data.Models.Family", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedOn");

                    b.Property<DateTime?>("DeletedOn");

                    b.Property<string>("Description");

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTime?>("ModifiedOn");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Families");
                });

            modelBuilder.Entity("Plant_A_Plant.Data.Models.FeedbackInfo", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("FullName");

                    b.Property<string>("Message");

                    b.Property<DateTime>("SendOn");

                    b.Property<string>("SenderEmail");

                    b.Property<string>("SenderPhoneNumber");

                    b.HasKey("Id");

                    b.ToTable("Feedback");
                });

            modelBuilder.Entity("Plant_A_Plant.Data.Models.Field", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedOn");

                    b.Property<DateTime?>("DeletedOn");

                    b.Property<Guid>("EventId");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("Location");

                    b.Property<DateTime?>("ModifiedOn");

                    b.Property<int>("Soil");

                    b.HasKey("Id");

                    b.HasIndex("EventId")
                        .IsUnique();

                    b.ToTable("Fields");
                });

            modelBuilder.Entity("Plant_A_Plant.Data.Models.PaPUser", b =>
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

            modelBuilder.Entity("Plant_A_Plant.Data.Models.Pest", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedOn");

                    b.Property<DateTime?>("DeletedOn");

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTime?>("ModifiedOn");

                    b.Property<string>("Name");

                    b.Property<string>("PestImgUrl");

                    b.Property<string>("ShortDescription");

                    b.Property<string>("SuperFamily");

                    b.Property<int>("Type");

                    b.HasKey("Id");

                    b.ToTable("Pests");
                });

            modelBuilder.Entity("Plant_A_Plant.Data.Models.PestsPlants", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("PestId");

                    b.Property<Guid>("PlantId");

                    b.HasKey("Id");

                    b.HasIndex("PestId");

                    b.HasIndex("PlantId");

                    b.ToTable("PestsPlants");
                });

            modelBuilder.Entity("Plant_A_Plant.Data.Models.Plant", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedOn");

                    b.Property<DateTime?>("DeletedOn");

                    b.Property<TimeSpan>("EstimatedTimeForGrowing");

                    b.Property<Guid?>("EventId");

                    b.Property<Guid>("FamilyId");

                    b.Property<Guid?>("FieldId");

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTime?>("ModifiedOn");

                    b.Property<string>("Name");

                    b.Property<string>("ShortDescription");

                    b.HasKey("Id");

                    b.HasIndex("EventId");

                    b.HasIndex("FamilyId");

                    b.HasIndex("FieldId");

                    b.ToTable("Plants");
                });

            modelBuilder.Entity("Plant_A_Plant.Data.Models.RegisterActivity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedOn");

                    b.Property<DateTime?>("DeletedOn");

                    b.Property<string>("Description");

                    b.Property<Guid>("FieldId");

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTime?>("ModifiedOn");

                    b.Property<string>("PaPUserId");

                    b.Property<DateTime>("RegisteredOn");

                    b.HasKey("Id");

                    b.HasIndex("FieldId");

                    b.HasIndex("PaPUserId");

                    b.ToTable("RegisterActivities");
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
                    b.HasOne("Plant_A_Plant.Data.Models.PaPUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Plant_A_Plant.Data.Models.PaPUser")
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

                    b.HasOne("Plant_A_Plant.Data.Models.PaPUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Plant_A_Plant.Data.Models.PaPUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Plant_A_Plant.Data.Models.Event", b =>
                {
                    b.HasOne("Plant_A_Plant.Data.Models.PaPUser")
                        .WithMany("Events")
                        .HasForeignKey("PaPUserId");
                });

            modelBuilder.Entity("Plant_A_Plant.Data.Models.Field", b =>
                {
                    b.HasOne("Plant_A_Plant.Data.Models.Event", "Event")
                        .WithOne("Field")
                        .HasForeignKey("Plant_A_Plant.Data.Models.Field", "EventId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Plant_A_Plant.Data.Models.PestsPlants", b =>
                {
                    b.HasOne("Plant_A_Plant.Data.Models.Pest", "Pest")
                        .WithMany("PestsPlants")
                        .HasForeignKey("PestId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Plant_A_Plant.Data.Models.Plant", "Plant")
                        .WithMany("PlantsPests")
                        .HasForeignKey("PlantId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Plant_A_Plant.Data.Models.Plant", b =>
                {
                    b.HasOne("Plant_A_Plant.Data.Models.Event")
                        .WithMany("Plants")
                        .HasForeignKey("EventId");

                    b.HasOne("Plant_A_Plant.Data.Models.Family", "Family")
                        .WithMany("Plants")
                        .HasForeignKey("FamilyId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Plant_A_Plant.Data.Models.Field")
                        .WithMany("Plants")
                        .HasForeignKey("FieldId");
                });

            modelBuilder.Entity("Plant_A_Plant.Data.Models.RegisterActivity", b =>
                {
                    b.HasOne("Plant_A_Plant.Data.Models.Field", "Field")
                        .WithMany("Activities")
                        .HasForeignKey("FieldId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Plant_A_Plant.Data.Models.PaPUser")
                        .WithMany("TotalActivities")
                        .HasForeignKey("PaPUserId");
                });
#pragma warning restore 612, 618
        }
    }
}
