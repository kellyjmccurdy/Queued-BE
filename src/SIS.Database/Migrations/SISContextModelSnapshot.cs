﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RedStarter.Database.Contexts;

namespace RedStarter.Database.Migrations
{
    [DbContext(typeof(SISContext))]
    partial class SISContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<int>("RoleId");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<int>("UserId");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.Property<int>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("RedStarter.Database.Entities.Application.ApplicationEntity", b =>
                {
                    b.Property<Guid>("ApplicationEntityId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTimeOffset>("DateCreated");

                    b.Property<DateTimeOffset?>("DateModified");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<int>("OwnerId");

                    b.HasKey("ApplicationEntityId");

                    b.ToTable("ApplicationTableAccess");
                });

            modelBuilder.Entity("RedStarter.Database.Entities.Application.ContactEntity", b =>
                {
                    b.Property<Guid>("ApplicationEntityId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("City");

                    b.Property<string>("Email");

                    b.Property<string>("Phone");

                    b.Property<string>("State");

                    b.Property<string>("StreetAddress");

                    b.Property<string>("Zip");

                    b.HasKey("ApplicationEntityId");

                    b.ToTable("ContactTableAccess");
                });

            modelBuilder.Entity("RedStarter.Database.Entities.Application.DemographicEntity", b =>
                {
                    b.Property<Guid>("ApplicationEntityId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Ethnicity");

                    b.Property<string>("Gender");

                    b.Property<bool>("Married");

                    b.HasKey("ApplicationEntityId");

                    b.ToTable("DemographicTableAccess");
                });

            modelBuilder.Entity("RedStarter.Database.Entities.Application.EducationEntity", b =>
                {
                    b.Property<Guid>("ApplicationEntityId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CollegeGraduationInfo");

                    b.Property<bool>("CurrentlyEnrolled");

                    b.Property<string>("FieldOfStudy");

                    b.Property<string>("HighSchoolGraduationInfo");

                    b.HasKey("ApplicationEntityId");

                    b.ToTable("EducationTableAccess");
                });

            modelBuilder.Entity("RedStarter.Database.Entities.Application.ExperienceEntity", b =>
                {
                    b.Property<Guid>("ApplicationEntityId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("EmploymentStatus");

                    b.Property<string>("IncomeLevel");

                    b.HasKey("ApplicationEntityId");

                    b.ToTable("ExperienceTableAccess");
                });

            modelBuilder.Entity("RedStarter.Database.Entities.Event.EventEntity", b =>
                {
                    b.Property<int>("EventEntityId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTimeOffset>("DateCreated");

                    b.Property<string>("EventTitle")
                        .IsRequired();

                    b.Property<string>("Information");

                    b.Property<bool>("IsAssigned");

                    b.Property<bool>("IsCompleted");

                    b.Property<bool>("IsExpired");

                    b.Property<bool>("IsPaid");

                    b.Property<int?>("JumperPersonEntityId");

                    b.Property<string>("Location")
                        .IsRequired();

                    b.Property<int>("OwnerID");

                    b.Property<int?>("PersonEntityId");

                    b.Property<decimal>("Price");

                    b.Property<string>("StartTime")
                        .IsRequired();

                    b.Property<int>("TypeOfEvent");

                    b.HasKey("EventEntityId");

                    b.HasIndex("JumperPersonEntityId");

                    b.HasIndex("PersonEntityId");

                    b.ToTable("EventTableAccess");
                });

            modelBuilder.Entity("RedStarter.Database.Entities.People.UserEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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

            modelBuilder.Entity("RedStarter.Database.Entities.Person.PersonEntity", b =>
                {
                    b.Property<int>("PersonEntityId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTimeOffset>("DateCreated");

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.Property<string>("Phone");

                    b.HasKey("PersonEntityId");

                    b.ToTable("PersonTableAccess");
                });

            modelBuilder.Entity("RedStarter.Database.Entities.Roles.RoleEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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

            modelBuilder.Entity("RedStarter.Database.Entities.Roles.UserRoleEntity", b =>
                {
                    b.Property<int>("UserId");

                    b.Property<int>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.HasOne("RedStarter.Database.Entities.Roles.RoleEntity")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.HasOne("RedStarter.Database.Entities.People.UserEntity")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.HasOne("RedStarter.Database.Entities.People.UserEntity")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.HasOne("RedStarter.Database.Entities.People.UserEntity")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("RedStarter.Database.Entities.Event.EventEntity", b =>
                {
                    b.HasOne("RedStarter.Database.Entities.Person.PersonEntity", "Jumper")
                        .WithMany()
                        .HasForeignKey("JumperPersonEntityId");

                    b.HasOne("RedStarter.Database.Entities.Person.PersonEntity", "Placer")
                        .WithMany()
                        .HasForeignKey("PersonEntityId");
                });

            modelBuilder.Entity("RedStarter.Database.Entities.Roles.UserRoleEntity", b =>
                {
                    b.HasOne("RedStarter.Database.Entities.Roles.RoleEntity", "Role")
                        .WithMany("UserRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("RedStarter.Database.Entities.People.UserEntity", "User")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
