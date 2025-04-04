﻿// <auto-generated />
using System;
using COMP1640.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace COMP1640.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20250321031659_addmeetingrecrrd")]
    partial class addmeetingrecrrd
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("COMP1640.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("integer");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("boolean");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("MessageCount")
                        .HasColumnType("integer");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("text");

                    b.Property<string>("TutorId")
                        .HasColumnType("text");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("boolean");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.HasIndex("TutorId");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "1001",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "0acc19a9-dd56-47e4-844a-1acbf171294c",
                            Email = "teacher@gmail.com",
                            EmailConfirmed = true,
                            FullName = "Nhu Vinh",
                            LockoutEnabled = false,
                            MessageCount = 0,
                            NormalizedEmail = "TEACHER@GMAIL.COM",
                            NormalizedUserName = "TEACHER@GMAIL.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEEEOhX40y0gIgapG/9/mHOTSLkEjd4k+Ocj9afnGkF+0zR4LUVSGOCqVmcXf7wjTfw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "40ae2f26-eda5-4418-b344-a09f20b34d63",
                            TwoFactorEnabled = false,
                            UserName = "teacher@gmail.com"
                        },
                        new
                        {
                            Id = "1002",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "882c702e-29fb-4092-bfdc-6ce13dd1f434",
                            Email = "teacher2@gmail.com",
                            EmailConfirmed = true,
                            FullName = "Thanh Tra",
                            LockoutEnabled = false,
                            MessageCount = 0,
                            NormalizedEmail = "TEACHER2@GMAIL.COM",
                            NormalizedUserName = "TEACHER2@GMAIL.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAECd3ymHlSe9DkhePWCE4SbPY9IXlxCSQ3GXMCiRduPgpry0MYzW8A44E4D+3UuADcg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "8fa7faed-183d-4b13-a692-5e0967d07aa0",
                            TwoFactorEnabled = false,
                            UserName = "teacher2@gmail.com"
                        },
                        new
                        {
                            Id = "1003",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "a913f1a3-9908-44f9-9ef3-d66e62c042bb",
                            Email = "staff@gmail.com",
                            EmailConfirmed = true,
                            FullName = "Nathan Json",
                            LockoutEnabled = false,
                            MessageCount = 0,
                            NormalizedEmail = "STAFF@GMAIL.COM",
                            NormalizedUserName = "STAFF@GMAIL.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAELLlWjWZC/J8NprRj/QNO9QaTRWYIG2wVlXbWYhz6ocaxl9fE5Z/ODDTPmg8i7IGWg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "514c06c7-b88a-45cc-b92a-a888a171d02b",
                            TwoFactorEnabled = false,
                            UserName = "staff@gmail.com"
                        },
                        new
                        {
                            Id = "1004",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "22b9b64b-dc28-4bd2-b127-89da98d874a3",
                            Email = "staff2@gmail.com",
                            EmailConfirmed = true,
                            FullName = "Ly Tieu Long",
                            LockoutEnabled = false,
                            MessageCount = 0,
                            NormalizedEmail = "STAFF2@GMAIL.COM",
                            NormalizedUserName = "STAFF2@GMAIL.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEGw3AJeyNZAwTEc7DBCDQz12Wf5H/9AHY/j6h2r9E9wCWYUyBWqubufF13RgOea0hg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "d6d90a65-19ad-485b-b9a7-7f438c1bf25c",
                            TwoFactorEnabled = false,
                            UserName = "staff2@gmail.com"
                        },
                        new
                        {
                            Id = "2001",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "f14bce95-eb94-4bae-8c45-50cbebf31550",
                            Email = "student1@gmail.com",
                            EmailConfirmed = true,
                            FullName = "Bui Quang Minh",
                            LockoutEnabled = false,
                            MessageCount = 350,
                            NormalizedEmail = "STUDENT1@GMAIL.COM",
                            NormalizedUserName = "STUDENT1@GMAIL.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEO0Zvum2334bJTtlpIzkVpu6Luue+X1BhqMBBMAND2YH7M6bRk2UAweSd+zzgq8lcw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "0abf20b3-dc7d-4350-9454-acfe359e5dcc",
                            TutorId = "1001",
                            TwoFactorEnabled = false,
                            UserName = "student1@gmail.com"
                        },
                        new
                        {
                            Id = "2002",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "9ce2a0b0-c190-4db0-9f69-b817345c7d5c",
                            Email = "student2@gmail.com",
                            EmailConfirmed = true,
                            FullName = "Nguyen Hoang Anh",
                            LockoutEnabled = false,
                            MessageCount = 220,
                            NormalizedEmail = "STUDENT2@GMAIL.COM",
                            NormalizedUserName = "STUDENT2@GMAIL.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEIoxJr/9HP1P4PiCfF9alIKWkYMtFqdVjnGbYdk3hdGH9KH7Ir4pVZc/tnhbPiNfnA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "fcebfac4-f7b3-4210-81e9-4616c28064e4",
                            TutorId = "1002",
                            TwoFactorEnabled = false,
                            UserName = "student2@gmail.com"
                        },
                        new
                        {
                            Id = "2003",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "254e264c-dcc0-412a-9f42-d45223839378",
                            Email = "student3@gmail.com",
                            EmailConfirmed = true,
                            FullName = "Tran Bao Ngoc",
                            LockoutEnabled = false,
                            MessageCount = 100,
                            NormalizedEmail = "STUDENT3@GMAIL.COM",
                            NormalizedUserName = "STUDENT3@GMAIL.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEMEmDHAhgOUG/mj0j7760IHf/VZ3EwPIvHyVRBE8MeBwnE8IcKO+MzZ3/r01mLk7vA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "7d305058-fde5-429c-8721-d9f82de2d559",
                            TwoFactorEnabled = false,
                            UserName = "student3@gmail.com"
                        },
                        new
                        {
                            Id = "2004",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "d7563e02-71ed-4600-9712-914fa58cea3d",
                            Email = "student4@gmail.com",
                            EmailConfirmed = true,
                            FullName = "Pham Tuan Kiet",
                            LockoutEnabled = false,
                            MessageCount = 75,
                            NormalizedEmail = "STUDENT4@GMAIL.COM",
                            NormalizedUserName = "STUDENT4@GMAIL.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEEWXMZTKsPnOJReUEtbcGezkP7NncJuzxAyltnEl/L/62e2Gl2mudkSzcTIKy2FC5w==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "d59fc286-7618-4319-96bb-e22e16b2bb19",
                            TutorId = "1001",
                            TwoFactorEnabled = false,
                            UserName = "student4@gmail.com"
                        },
                        new
                        {
                            Id = "2005",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "130854c9-2e40-4a97-bca6-326715e91b34",
                            Email = "student5@gmail.com",
                            EmailConfirmed = true,
                            FullName = "Le Hong Phong",
                            LockoutEnabled = false,
                            MessageCount = 50,
                            NormalizedEmail = "STUDENT5@GMAIL.COM",
                            NormalizedUserName = "STUDENT5@GMAIL.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEBG+AugMHTmXMJ1UyLHZAfCDRZU2Jz+aDYGMkXylgU5cUlqWYPiN9c3ZUDshw+BQ8g==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "66e6cfd0-8a64-425e-b356-6f3da83726c8",
                            TwoFactorEnabled = false,
                            UserName = "student5@gmail.com"
                        });
                });

            modelBuilder.Entity("COMP1640.Models.Document", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("UploadedBy")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Documents");
                });

            modelBuilder.Entity("COMP1640.Models.Interaction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("StudentId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("Timestamp")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("TutorId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("StudentId");

                    b.HasIndex("TutorId");

                    b.ToTable("Interactions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            StudentId = "1e64a03d-37b5-4c8c-9985-64383c47a696",
                            Timestamp = new DateTime(2025, 3, 21, 3, 9, 58, 530, DateTimeKind.Utc).AddTicks(8073),
                            TutorId = "1002",
                            Type = "Uploaded a document"
                        },
                        new
                        {
                            Id = 2,
                            StudentId = "1e64a03d-37b5-4c8c-9985-64383c47a696",
                            Timestamp = new DateTime(2025, 3, 21, 3, 1, 58, 530, DateTimeKind.Utc).AddTicks(8082),
                            TutorId = "1002",
                            Type = "Sent you a message"
                        },
                        new
                        {
                            Id = 3,
                            StudentId = "1e64a03d-37b5-4c8c-9985-64383c47a696",
                            Timestamp = new DateTime(2025, 3, 21, 2, 46, 58, 530, DateTimeKind.Utc).AddTicks(8084),
                            TutorId = "1001",
                            Type = "Commented on your document"
                        });
                });

            modelBuilder.Entity("COMP1640.Models.Meeting", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Deadline")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("MeetingLink")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("RecordLink")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("StudentId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("TeacherId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("StudentId");

                    b.HasIndex("TeacherId");

                    b.ToTable("Meetings");
                });

            modelBuilder.Entity("COMP1640.Models.Message", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ReceiverId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("SenderId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("Timestamp")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("ReceiverId");

                    b.HasIndex("SenderId");

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("COMP1640.Models.Notification", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("IsRead")
                        .HasColumnType("boolean");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Notifications");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "1",
                            Name = "Student",
                            NormalizedName = "STUDENT"
                        },
                        new
                        {
                            Id = "2",
                            Name = "Teacher",
                            NormalizedName = "TEACHER"
                        },
                        new
                        {
                            Id = "3",
                            Name = "Staff",
                            NormalizedName = "STAFF"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("text");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .HasColumnType("text");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "1001",
                            RoleId = "2"
                        },
                        new
                        {
                            UserId = "1002",
                            RoleId = "2"
                        },
                        new
                        {
                            UserId = "1003",
                            RoleId = "3"
                        },
                        new
                        {
                            UserId = "1004",
                            RoleId = "3"
                        },
                        new
                        {
                            UserId = "2001",
                            RoleId = "1"
                        },
                        new
                        {
                            UserId = "2002",
                            RoleId = "1"
                        },
                        new
                        {
                            UserId = "2003",
                            RoleId = "1"
                        },
                        new
                        {
                            UserId = "2004",
                            RoleId = "1"
                        },
                        new
                        {
                            UserId = "2005",
                            RoleId = "1"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Value")
                        .HasColumnType("text");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("COMP1640.Models.ApplicationUser", b =>
                {
                    b.HasOne("COMP1640.Models.ApplicationUser", "Tutor")
                        .WithMany()
                        .HasForeignKey("TutorId");

                    b.Navigation("Tutor");
                });

            modelBuilder.Entity("COMP1640.Models.Interaction", b =>
                {
                    b.HasOne("COMP1640.Models.ApplicationUser", "Student")
                        .WithMany()
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("COMP1640.Models.ApplicationUser", "Tutor")
                        .WithMany()
                        .HasForeignKey("TutorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Student");

                    b.Navigation("Tutor");
                });

            modelBuilder.Entity("COMP1640.Models.Meeting", b =>
                {
                    b.HasOne("COMP1640.Models.ApplicationUser", "Student")
                        .WithMany()
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("COMP1640.Models.ApplicationUser", "Teacher")
                        .WithMany()
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Student");

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("COMP1640.Models.Message", b =>
                {
                    b.HasOne("COMP1640.Models.ApplicationUser", "Receiver")
                        .WithMany()
                        .HasForeignKey("ReceiverId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("COMP1640.Models.ApplicationUser", "Sender")
                        .WithMany()
                        .HasForeignKey("SenderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Receiver");

                    b.Navigation("Sender");
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
                    b.HasOne("COMP1640.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("COMP1640.Models.ApplicationUser", null)
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

                    b.HasOne("COMP1640.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("COMP1640.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
