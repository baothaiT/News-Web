﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using News.Data;

namespace News.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
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

                    b.ToTable("Roles");

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityRole");
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

                    b.ToTable("RoleClaims");
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

                    b.ToTable("Users");

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

                    b.ToTable("UserClaims");
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

                    b.ToTable("UserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("UserRoles");

                    b.HasData(
                        new
                        {
                            UserId = "9b5160cd-3f91-436e-b21f-1fd102eaa84c",
                            RoleId = "4fd340e2-7fed-435b-b5dd-7d12e2d1c1b2"
                        },
                        new
                        {
                            UserId = "64546a2c-75d4-47d3-82b3-adcd5a87915a",
                            RoleId = "03cca429-b877-4735-9b6b-dc689c042553"
                        });
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

                    b.ToTable("UserTokens");
                });

            modelBuilder.Entity("News.Entities.Categories", b =>
                {
                    b.Property<string>("category_Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("category_Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("category_Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("category_Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            category_Id = "1ddfe87e-d074-4365-83fc-498b603e9e9e",
                            category_Description = "Des 1",
                            category_Name = "Category1"
                        },
                        new
                        {
                            category_Id = "d69587a5-0e58-4e51-8e91-ba3d5b90bdf4",
                            category_Description = "Des 2",
                            category_Name = "Category2"
                        },
                        new
                        {
                            category_Id = "2446c36b-26cf-4544-82a6-9280a06bd704",
                            category_Description = "Des 3",
                            category_Name = "Category3"
                        });
                });

            modelBuilder.Entity("News.Entities.Comments", b =>
                {
                    b.Property<string>("cmt_Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("cmt_Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cmt_IdeaId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("cmt_IsDelete")
                        .HasColumnType("bit");

                    b.Property<DateTime>("cmt_UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("cmt_UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("cmt_Id");

                    b.HasIndex("cmt_IdeaId");

                    b.HasIndex("cmt_UserId");

                    b.ToTable("Comments");

                    b.HasData(
                        new
                        {
                            cmt_Id = "ff90f68d-7486-47a1-885b-6dd994b229cd",
                            cmt_Content = "Comment1",
                            cmt_IdeaId = "5a76199f-171b-4e94-9328-7b7186a449f2",
                            cmt_IsDelete = false,
                            cmt_UpdateDate = new DateTime(2022, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            cmt_UserId = "64546a2c-75d4-47d3-82b3-adcd5a87915a"
                        },
                        new
                        {
                            cmt_Id = "4753a838-4212-459e-82a7-cfeaad7714a0",
                            cmt_Content = "Comment2",
                            cmt_IdeaId = "5a76199f-171b-4e94-9328-7b7186a449f2",
                            cmt_IsDelete = false,
                            cmt_UpdateDate = new DateTime(2022, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            cmt_UserId = "9b5160cd-3f91-436e-b21f-1fd102eaa84c"
                        },
                        new
                        {
                            cmt_Id = "456d0a12-51df-41fd-89fa-704f2311301e",
                            cmt_Content = "Comment3",
                            cmt_IdeaId = "5a76199f-171b-4e94-9328-7b7186a449f2",
                            cmt_IsDelete = false,
                            cmt_UpdateDate = new DateTime(2022, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            cmt_UserId = "64546a2c-75d4-47d3-82b3-adcd5a87915a"
                        });
                });

            modelBuilder.Entity("News.Entities.Department", b =>
                {
                    b.Property<string>("department_Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("department_Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("department_Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("department_Id");

                    b.ToTable("Department");

                    b.HasData(
                        new
                        {
                            department_Id = "ca63d27f-7176-4c16-8ca2-1fd0f10ba5ae",
                            department_Description = "Department 1",
                            department_Name = "Department 1"
                        },
                        new
                        {
                            department_Id = "01ba1636-2ab5-4a0b-9d8f-1c8e2bbaffb2",
                            department_Description = "Department 2",
                            department_Name = "Department 2 "
                        },
                        new
                        {
                            department_Id = "dd176980-f93e-456a-8fed-43182383d6da",
                            department_Description = "Department 3",
                            department_Name = "Department 3"
                        });
                });

            modelBuilder.Entity("News.Entities.Idea", b =>
                {
                    b.Property<string>("idea_Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("idea_Agree")
                        .HasColumnType("bit");

                    b.Property<string>("idea_CategoryId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("idea_Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("idea_ImageName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("idea_ImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("idea_SubmissionId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("idea_Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("idea_UpdateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("idea_UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("idea_View")
                        .HasColumnType("int");

                    b.HasKey("idea_Id");

                    b.HasIndex("idea_CategoryId");

                    b.HasIndex("idea_SubmissionId");

                    b.HasIndex("idea_UserId");

                    b.ToTable("Idea");

                    b.HasData(
                        new
                        {
                            idea_Id = "5a76199f-171b-4e94-9328-7b7186a449f2",
                            idea_Agree = false,
                            idea_CategoryId = "1ddfe87e-d074-4365-83fc-498b603e9e9e",
                            idea_Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Beatae ipsum non voluptatum eum repellendus quod aliquid. Vitae, dolorum voluptate quis repudiandae eos molestiae dolores enim. ",
                            idea_ImageName = "blog-1.png",
                            idea_SubmissionId = "57f70f6d-c11e-45c5-962d-6e2c44e03c6b",
                            idea_Title = "Title1",
                            idea_UpdateTime = new DateTime(2022, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            idea_UserId = "9b5160cd-3f91-436e-b21f-1fd102eaa84c",
                            idea_View = 0
                        },
                        new
                        {
                            idea_Id = "e59bc9dd-9c1e-42e8-8e11-494daed0d377",
                            idea_Agree = false,
                            idea_CategoryId = "d69587a5-0e58-4e51-8e91-ba3d5b90bdf4",
                            idea_Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Beatae ipsum non voluptatum eum repellendus quod aliquid. Vitae, dolorum voluptate quis repudiandae eos molestiae dolores enim. ",
                            idea_ImageName = "blog-2.png",
                            idea_SubmissionId = "57f70f6d-c11e-45c5-962d-6e2c44e03c6b",
                            idea_Title = "Title2",
                            idea_UpdateTime = new DateTime(2022, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            idea_UserId = "9b5160cd-3f91-436e-b21f-1fd102eaa84c",
                            idea_View = 0
                        },
                        new
                        {
                            idea_Id = "313b0056-8e14-4e94-8b5d-dfb2965fb8eb",
                            idea_Agree = false,
                            idea_CategoryId = "d69587a5-0e58-4e51-8e91-ba3d5b90bdf4",
                            idea_Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Beatae ipsum non voluptatum eum repellendus quod aliquid. Vitae, dolorum voluptate quis repudiandae eos molestiae dolores enim. ",
                            idea_ImageName = "blog-3.png",
                            idea_SubmissionId = "57f70f6d-c11e-45c5-962d-6e2c44e03c6b",
                            idea_Title = "Title3",
                            idea_UpdateTime = new DateTime(2022, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            idea_UserId = "64546a2c-75d4-47d3-82b3-adcd5a87915a",
                            idea_View = 0
                        });
                });

            modelBuilder.Entity("News.Entities.LikeInIdea", b =>
                {
                    b.Property<string>("likeInIdea_Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("likeInIdea_CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("likeInIdea_DisLike")
                        .HasColumnType("int");

                    b.Property<string>("likeInIdea_IdeaId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("likeInIdea_Like")
                        .HasColumnType("int");

                    b.Property<string>("likeInIdea_UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("likeInIdea_Id");

                    b.HasIndex("likeInIdea_IdeaId");

                    b.HasIndex("likeInIdea_UserId");

                    b.ToTable("LikeInIdea");
                });

            modelBuilder.Entity("News.Entities.Submission", b =>
                {
                    b.Property<string>("submission_Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("submission_Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("submission_DueTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("submission_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("submission_StartTime")
                        .HasColumnType("datetime2");

                    b.HasKey("submission_Id");

                    b.ToTable("Submission");

                    b.HasData(
                        new
                        {
                            submission_Id = "57f70f6d-c11e-45c5-962d-6e2c44e03c6b",
                            submission_Description = "AcademicYear1",
                            submission_DueTime = new DateTime(2023, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            submission_Name = "AcademicYear1",
                            submission_StartTime = new DateTime(2021, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("News.Entities.UserInDepartment", b =>
                {
                    b.Property<string>("uid_UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("uid_DepartmentId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("uid_UserId", "uid_DepartmentId");

                    b.HasIndex("uid_DepartmentId");

                    b.ToTable("UserInDepartment");

                    b.HasData(
                        new
                        {
                            uid_UserId = "64546a2c-75d4-47d3-82b3-adcd5a87915a",
                            uid_DepartmentId = "ca63d27f-7176-4c16-8ca2-1fd0f10ba5ae"
                        },
                        new
                        {
                            uid_UserId = "9b5160cd-3f91-436e-b21f-1fd102eaa84c",
                            uid_DepartmentId = "01ba1636-2ab5-4a0b-9d8f-1c8e2bbaffb2"
                        });
                });

            modelBuilder.Entity("News.Entities.AppRole", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityRole");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("AppRole");

                    b.HasData(
                        new
                        {
                            Id = "4fd340e2-7fed-435b-b5dd-7d12e2d1c1b2",
                            ConcurrencyStamp = "bcb8ebb4-283d-4563-ab55-ae2bbe7e3f63",
                            Name = "staff",
                            Description = "Staff"
                        },
                        new
                        {
                            Id = "03cca429-b877-4735-9b6b-dc689c042553",
                            ConcurrencyStamp = "5f6aff12-8931-4deb-b999-270ec6a0e9a4",
                            Name = "admin",
                            Description = "Admin"
                        });
                });

            modelBuilder.Entity("News.Entities.AppUser", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.Property<DateTime>("DoB")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("AppUser");

                    b.HasData(
                        new
                        {
                            Id = "64546a2c-75d4-47d3-82b3-adcd5a87915a",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "2a157fb5-d76f-4220-8730-321046dc638c",
                            Email = "admin@gmail.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@GMAIL.COM",
                            NormalizedUserName = "ADMIN@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEF60/tWZeb83Z0GhqDQKLkZwK5pRW69VfTWIi0aIDfE18bjSX6fCkvs2bfTTmR3g7g==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "d35f1a98-1e4d-4e07-a22a-962c0fb3c2f9",
                            TwoFactorEnabled = false,
                            UserName = "Admin",
                            DoB = new DateTime(2022, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastName = "Admin"
                        },
                        new
                        {
                            Id = "9b5160cd-3f91-436e-b21f-1fd102eaa84c",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "8d0f0f0d-c7f7-48eb-83ac-b78e195f04a5",
                            Email = "staff@gmail.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "STAFF@GMAIL.COM",
                            NormalizedUserName = "STAFF@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEBrMEWOl8bnezyYzH+c4Iob+EeBMLPhlecxwTFpPzpHC2GxKVGP6cQrf1BmxWStMcA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "c50aa838-d37b-4ff1-9284-e5f303102210",
                            TwoFactorEnabled = false,
                            UserName = "Staff",
                            DoB = new DateTime(2022, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastName = "Staff"
                        },
                        new
                        {
                            Id = "dafa23d2-5ac0-453e-be5c-a3e93fa70b7c",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "8167614c-e2e2-4ee9-b132-7d9330ab721c",
                            Email = "staff2@gmail.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "STAFF2@GMAIL.COM",
                            NormalizedUserName = "STAFF2@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEKOii7TQ+eWn9D1PylQ/IUU/ClCXQXuxp85PPRfT0xzdaJQX6cOIjje58PP1tx3D+A==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "f319540b-6801-4c00-a22f-65a5b8d1cea4",
                            TwoFactorEnabled = false,
                            UserName = "Staff2",
                            DoB = new DateTime(2022, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastName = "Staff2"
                        });
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

            modelBuilder.Entity("News.Entities.Comments", b =>
                {
                    b.HasOne("News.Entities.Idea", "IdeaFk")
                        .WithMany("Comments")
                        .HasForeignKey("cmt_IdeaId");

                    b.HasOne("News.Entities.AppUser", "AppUserFk")
                        .WithMany("Comments")
                        .HasForeignKey("cmt_UserId");

                    b.Navigation("AppUserFk");

                    b.Navigation("IdeaFk");
                });

            modelBuilder.Entity("News.Entities.Idea", b =>
                {
                    b.HasOne("News.Entities.Categories", "categoriesFK")
                        .WithMany("IdeaList")
                        .HasForeignKey("idea_CategoryId");

                    b.HasOne("News.Entities.Submission", "submissionFK")
                        .WithMany("IdeaList")
                        .HasForeignKey("idea_SubmissionId");

                    b.HasOne("News.Entities.AppUser", "appUserFK")
                        .WithMany("ideasList")
                        .HasForeignKey("idea_UserId");

                    b.Navigation("appUserFK");

                    b.Navigation("categoriesFK");

                    b.Navigation("submissionFK");
                });

            modelBuilder.Entity("News.Entities.LikeInIdea", b =>
                {
                    b.HasOne("News.Entities.Idea", "Idea")
                        .WithMany("likeInIdea")
                        .HasForeignKey("likeInIdea_IdeaId");

                    b.HasOne("News.Entities.AppUser", "AppUser")
                        .WithMany("likeInIdea")
                        .HasForeignKey("likeInIdea_UserId");

                    b.Navigation("AppUser");

                    b.Navigation("Idea");
                });

            modelBuilder.Entity("News.Entities.UserInDepartment", b =>
                {
                    b.HasOne("News.Entities.Department", "DepartmentFK")
                        .WithMany("userInDepartmentsList")
                        .HasForeignKey("uid_DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("News.Entities.AppUser", "AppUserFK")
                        .WithMany("userInDepartmentsList")
                        .HasForeignKey("uid_UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AppUserFK");

                    b.Navigation("DepartmentFK");
                });

            modelBuilder.Entity("News.Entities.Categories", b =>
                {
                    b.Navigation("IdeaList");
                });

            modelBuilder.Entity("News.Entities.Department", b =>
                {
                    b.Navigation("userInDepartmentsList");
                });

            modelBuilder.Entity("News.Entities.Idea", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("likeInIdea");
                });

            modelBuilder.Entity("News.Entities.Submission", b =>
                {
                    b.Navigation("IdeaList");
                });

            modelBuilder.Entity("News.Entities.AppUser", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("ideasList");

                    b.Navigation("likeInIdea");

                    b.Navigation("userInDepartmentsList");
                });
#pragma warning restore 612, 618
        }
    }
}
