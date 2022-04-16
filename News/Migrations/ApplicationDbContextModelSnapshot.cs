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
                            UserId = "b69d3bf8-b9a6-4abd-9daf-d0b48bcb4739",
                            RoleId = "cfceb4fc-7fb5-4c66-9749-0321e1a29e6d"
                        },
                        new
                        {
                            UserId = "1c7498e1-6050-4215-ab66-13620bd236ae",
                            RoleId = "611a9796-2d7c-4f3e-b6a4-a6fbebc6ae53"
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
                            category_Id = "e773555c-d3d5-4750-91d3-ebcc7709ab83",
                            category_Description = "Des 1",
                            category_Name = "Category1"
                        },
                        new
                        {
                            category_Id = "ba7c0b81-5834-40cc-8408-58663f41f840",
                            category_Description = "Des 2",
                            category_Name = "Category2"
                        },
                        new
                        {
                            category_Id = "7b065a3c-9187-4a3a-97c9-a8d384c7e928",
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
                            cmt_Id = "a7fdbc95-8979-43a0-bc47-1fd52dfefb92",
                            cmt_Content = "Comment1",
                            cmt_IdeaId = "b725ecae-7bf5-4c97-a1b0-1b87b1c828ee",
                            cmt_IsDelete = false,
                            cmt_UpdateDate = new DateTime(2022, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            cmt_UserId = "1c7498e1-6050-4215-ab66-13620bd236ae"
                        },
                        new
                        {
                            cmt_Id = "714539c7-cf39-4a40-95c7-f2e00dbcf185",
                            cmt_Content = "Comment2",
                            cmt_IdeaId = "b725ecae-7bf5-4c97-a1b0-1b87b1c828ee",
                            cmt_IsDelete = false,
                            cmt_UpdateDate = new DateTime(2022, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            cmt_UserId = "b69d3bf8-b9a6-4abd-9daf-d0b48bcb4739"
                        },
                        new
                        {
                            cmt_Id = "e1a4d0bf-f3f0-479e-afad-343e5bec5cd2",
                            cmt_Content = "Comment3",
                            cmt_IdeaId = "b725ecae-7bf5-4c97-a1b0-1b87b1c828ee",
                            cmt_IsDelete = false,
                            cmt_UpdateDate = new DateTime(2022, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            cmt_UserId = "1c7498e1-6050-4215-ab66-13620bd236ae"
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
                            department_Id = "72adae0f-47d9-412f-a066-f59e0c095af0",
                            department_Description = "Department 1",
                            department_Name = "Department 1"
                        },
                        new
                        {
                            department_Id = "384a4394-7a97-4af9-aa88-7dba64c8fb1c",
                            department_Description = "Department 2",
                            department_Name = "Department 2 "
                        },
                        new
                        {
                            department_Id = "e9990391-bfcd-4574-9037-558fc4b3448d",
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
                            idea_Id = "b725ecae-7bf5-4c97-a1b0-1b87b1c828ee",
                            idea_Agree = false,
                            idea_CategoryId = "e773555c-d3d5-4750-91d3-ebcc7709ab83",
                            idea_Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Beatae ipsum non voluptatum eum repellendus quod aliquid. Vitae, dolorum voluptate quis repudiandae eos molestiae dolores enim. ",
                            idea_ImageName = "blog-1.png",
                            idea_SubmissionId = "2cf7b477-865b-411c-b4b5-84eacb60c1bd",
                            idea_Title = "Title1",
                            idea_UpdateTime = new DateTime(2022, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            idea_UserId = "b69d3bf8-b9a6-4abd-9daf-d0b48bcb4739",
                            idea_View = 0
                        },
                        new
                        {
                            idea_Id = "81c633c0-e249-4c34-bf0e-97ad41356c15",
                            idea_Agree = false,
                            idea_CategoryId = "ba7c0b81-5834-40cc-8408-58663f41f840",
                            idea_Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Beatae ipsum non voluptatum eum repellendus quod aliquid. Vitae, dolorum voluptate quis repudiandae eos molestiae dolores enim. ",
                            idea_ImageName = "blog-2.png",
                            idea_SubmissionId = "2cf7b477-865b-411c-b4b5-84eacb60c1bd",
                            idea_Title = "Title2",
                            idea_UpdateTime = new DateTime(2022, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            idea_UserId = "b69d3bf8-b9a6-4abd-9daf-d0b48bcb4739",
                            idea_View = 0
                        },
                        new
                        {
                            idea_Id = "6e058615-b432-4774-9a53-e881816175ea",
                            idea_Agree = false,
                            idea_CategoryId = "ba7c0b81-5834-40cc-8408-58663f41f840",
                            idea_Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Beatae ipsum non voluptatum eum repellendus quod aliquid. Vitae, dolorum voluptate quis repudiandae eos molestiae dolores enim. ",
                            idea_ImageName = "blog-3.png",
                            idea_SubmissionId = "2cf7b477-865b-411c-b4b5-84eacb60c1bd",
                            idea_Title = "Title3",
                            idea_UpdateTime = new DateTime(2022, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            idea_UserId = "1c7498e1-6050-4215-ab66-13620bd236ae",
                            idea_View = 0
                        });
                });

            modelBuilder.Entity("News.Entities.LikeInIdea", b =>
                {
                    b.Property<string>("likeInIdea_Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("likeInIdea_CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("likeInIdea_DisLike")
                        .HasColumnType("bit");

                    b.Property<string>("likeInIdea_IdeaId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("likeInIdea_Like")
                        .HasColumnType("bit");

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
                            submission_Id = "2cf7b477-865b-411c-b4b5-84eacb60c1bd",
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
                            uid_UserId = "1c7498e1-6050-4215-ab66-13620bd236ae",
                            uid_DepartmentId = "72adae0f-47d9-412f-a066-f59e0c095af0"
                        },
                        new
                        {
                            uid_UserId = "b69d3bf8-b9a6-4abd-9daf-d0b48bcb4739",
                            uid_DepartmentId = "384a4394-7a97-4af9-aa88-7dba64c8fb1c"
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
                            Id = "cfceb4fc-7fb5-4c66-9749-0321e1a29e6d",
                            ConcurrencyStamp = "ed5c24f5-33b1-4244-861a-d89017612602",
                            Name = "staff",
                            Description = "Staff"
                        },
                        new
                        {
                            Id = "611a9796-2d7c-4f3e-b6a4-a6fbebc6ae53",
                            ConcurrencyStamp = "0a6007dc-d4d3-4ca4-a588-b2280ae00225",
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
                            Id = "1c7498e1-6050-4215-ab66-13620bd236ae",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "b0857ff4-f33c-451e-8e4b-fe4b9f31dd40",
                            Email = "admin@gmail.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@GMAIL.COM",
                            NormalizedUserName = "ADMIN@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEFFqEY7SpMwEg5Ast76nreMWGYyye6Hom2ZAVyTfBJnqJPZZC+FSRN6c8Cjiycdf5A==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "77d0367f-25a3-4b93-baef-d9a436eb95f9",
                            TwoFactorEnabled = false,
                            UserName = "Admin",
                            DoB = new DateTime(2022, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastName = "Admin"
                        },
                        new
                        {
                            Id = "b69d3bf8-b9a6-4abd-9daf-d0b48bcb4739",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "f9d783b9-0e91-4af5-b087-ae1ef3327ec7",
                            Email = "staff@gmail.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "STAFF@GMAIL.COM",
                            NormalizedUserName = "STAFF@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEOCJu5V/LAo/V70JzIJmtGYAJ5Ra6imGFnPwhvNL0qTY6gW59x9MqwgJuM7MJ+W4mw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "1ab1e34a-3368-49d0-a410-041c6d9a0320",
                            TwoFactorEnabled = false,
                            UserName = "Staff",
                            DoB = new DateTime(2022, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastName = "Staff"
                        },
                        new
                        {
                            Id = "58bb2241-dbeb-43f9-9ee0-548d12b7a5b9",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "4414f72d-8de5-45a0-b228-b6538a9299dd",
                            Email = "staff2@gmail.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "STAFF2@GMAIL.COM",
                            NormalizedUserName = "STAFF2@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEMs/Talb5HzQRiJzuGqc48rnSJ9uUZqfU4Ii+KP+Yc18CZnBov1X3grXOtvPjhKM+A==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "f193ccb7-a853-4def-9a67-31c7edccc2e0",
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
