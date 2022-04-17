using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using News.Entities;
using System;

namespace News.Data
{
    public static class InsertData
    {
        public static void Seed(this ModelBuilder builder)
        {
            //Categories Data
            var categoryId1 = Guid.NewGuid().ToString();
            var categoryId2 = Guid.NewGuid().ToString();
            var categoryId3 = Guid.NewGuid().ToString();

            builder.Entity<Categories>().HasData(
                new Categories()
                {
                    category_Id = categoryId1,
                    category_Name = "Category1",
                    category_Description ="Des 1"
                },
                new Categories()
                {
                    category_Id = categoryId2,
                    category_Name = "Category2",
                    category_Description = "Des 2"
                },
                new Categories()
                {
                    category_Id = categoryId3,
                    category_Name = "Category3",
                    category_Description = "Des 3"
                }
                );




            //AppRole Data
            var IdRoleStaff = Guid.NewGuid().ToString();
            var IdRoleAdmin = Guid.NewGuid().ToString();

            builder.Entity<AppRole>().HasData(
                new AppRole()
                {
                    Id = IdRoleStaff,
                    Name = "staff",
                    Description = "Staff"
                },
                new AppRole()
                {
                    Id = IdRoleAdmin,
                    Name = "admin",
                    Description = "Admin"
                });

            //AppUser Data
            var userId1 = Guid.NewGuid().ToString();
            var userId2 = Guid.NewGuid().ToString();
            var userId3 = Guid.NewGuid().ToString();
            var userId4 = Guid.NewGuid().ToString();

            var hasher = new PasswordHasher<AppUser>();

            builder.Entity<AppUser>().HasData(
                new AppUser()
                {
                    Id = userId1,
                    UserName = "Admin",
                    LastName = "Admin",
                    NormalizedUserName = "ADMIN@GMAIL.COM",
                    NormalizedEmail = "ADMIN@GMAIL.COM",
                    Email = "admin@gmail.com",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "123456Aa@"),
                    SecurityStamp = Guid.NewGuid().ToString(),
                    DoB = new DateTime(2022, 02, 02)
                },
                new AppUser()
                {
                    Id = userId2,
                    UserName = "Staff",
                    LastName = "Staff",
                    NormalizedUserName = "STAFF@GMAIL.COM",
                    NormalizedEmail = "STAFF@GMAIL.COM",
                    Email = "staff@gmail.com",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "123456Aa@"),
                    SecurityStamp = Guid.NewGuid().ToString(),
                    DoB = new DateTime(2022, 02, 02)
                },
                new AppUser()
                {
                    Id = userId3,
                    UserName = "Staff2",
                    LastName = "Staff2",
                    NormalizedUserName = "STAFF2@GMAIL.COM",
                    NormalizedEmail = "STAFF2@GMAIL.COM",
                    Email = "staff2@gmail.com",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "123456Aa@"),
                    SecurityStamp = Guid.NewGuid().ToString(),
                    DoB = new DateTime(2022, 02, 02)
                },
                new AppUser()
                {
                    Id = userId4,
                    UserName = "Anonymous",
                    LastName = "Anonymous",
                    NormalizedUserName = "ANOYMOUS@GMAIL.COM",
                    NormalizedEmail = "ANOYMOUS@GMAIL.COM",
                    Email = "anonymous@gmail.com",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "123456Aa@"),
                    SecurityStamp = Guid.NewGuid().ToString(),
                    DoB = new DateTime(2022, 02, 03)
                }
                );

            //AppUser - role Data 
            builder.Entity<IdentityUserRole<string>>().HasData(
            new IdentityUserRole<string>
            {
                RoleId = IdRoleStaff,
                UserId = userId2
            },
            new IdentityUserRole<string>
            {
                RoleId = IdRoleAdmin,
                UserId = userId1
            });


            //Department Data
            var departmentId1 = Guid.NewGuid().ToString();
            var departmentId2 = Guid.NewGuid().ToString();
            var departmentId3 = Guid.NewGuid().ToString();

            builder.Entity<Department>().HasData(
                new Department()
                {
                    department_Id = departmentId1,
                    department_Name = "Department 1",
                    department_Description = "Department 1"
                },
                new Department()
                {
                    department_Id = departmentId2,
                    department_Name = "Department 2 ",
                    department_Description = "Department 2"
                },
                new Department()
                {
                    department_Id = departmentId3,
                    department_Name = "Department 3",
                    department_Description = "Department 3"
                }
                );

            //Academic Year Data 
            var SubmissionId1 = Guid.NewGuid().ToString();

            builder.Entity<Submission>().HasData(
                new Submission()
                {
                    submission_Id = SubmissionId1,
                    submission_Name = "Submission1",
                    submission_Description = "Submission1",
                    submission_StartTime = new DateTime(2021, 02, 02),
                    submission_DueTime = new DateTime(2023, 02, 02)
                }
                );

            //Idea Data
            var ideaId1 = Guid.NewGuid().ToString();
            var ideaId2 = Guid.NewGuid().ToString();
            var ideaId3 = Guid.NewGuid().ToString();

            builder.Entity<Idea>().HasData(
                new Idea()
                {
                    idea_Id = ideaId1,
                    idea_Title = "Title1",
                    idea_ImageName = "blog-1.png",
                    idea_Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Beatae ipsum non voluptatum eum repellendus quod aliquid. Vitae, dolorum voluptate quis repudiandae eos molestiae dolores enim. ",
                    idea_UpdateTime = new DateTime(2022, 02, 02),
                    idea_CategoryId = categoryId1,
                    idea_SubmissionId = SubmissionId1,
                    idea_UserId = userId2,
                    idea_View =0
                },
                new Idea()
                {
                    idea_Id = ideaId2,
                    idea_Title = "Title2",
                    idea_ImageName = "blog-2.png",
                    idea_Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Beatae ipsum non voluptatum eum repellendus quod aliquid. Vitae, dolorum voluptate quis repudiandae eos molestiae dolores enim. ",
                    idea_UpdateTime = new DateTime(2022, 02, 03),
                    idea_CategoryId = categoryId2,
                    idea_SubmissionId = SubmissionId1,
                    idea_UserId = userId2,
                    idea_View = 0
                },
                new Idea()
                {
                    idea_Id = ideaId3,
                    idea_Title = "Title3",
                    idea_ImageName = "blog-3.png",
                    idea_Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Beatae ipsum non voluptatum eum repellendus quod aliquid. Vitae, dolorum voluptate quis repudiandae eos molestiae dolores enim. ",
                    idea_UpdateTime = new DateTime(2022, 02, 04),
                    idea_CategoryId = categoryId2,
                    idea_SubmissionId = SubmissionId1,
                    idea_UserId = userId1,
                    idea_View = 0
                }
                );

            //UserInDepartment Data 
            var uidUserId1 = Guid.NewGuid().ToString();

            builder.Entity<UserInDepartment>().HasData(
                new UserInDepartment()
                {
                    uid_UserId = userId1,
                    uid_DepartmentId = departmentId1
                },
                new UserInDepartment()
                {
                    uid_UserId = userId2,
                    uid_DepartmentId = departmentId2
                }
                );

            //Comments

            var Cmt_Id1 = Guid.NewGuid().ToString();
            var Cmt_Id2 = Guid.NewGuid().ToString();
            var Cmt_Id3 = Guid.NewGuid().ToString();

            builder.Entity<Comments>().HasData(
                new Comments()
                {
                    cmt_Id = Cmt_Id1,
                    cmt_Content = "Comment1",
                    cmt_UserId = userId1,
                    cmt_UpdateDate = new DateTime(2022, 02, 04),
                    cmt_IdeaId = ideaId1,
                    IsDelete = false
                },
                new Comments()
                {
                    cmt_Id = Cmt_Id2,
                    cmt_Content = "Comment2",
                    cmt_UserId = userId2,
                    cmt_UpdateDate = new DateTime(2022, 02, 05),
                    cmt_IdeaId = ideaId1,
                    IsDelete = false
                },
                new Comments()
                {
                    cmt_Id = Cmt_Id3,
                    cmt_Content = "Comment3",
                    cmt_UserId = userId1,
                    cmt_UpdateDate = new DateTime(2022, 02, 06),
                    cmt_IdeaId = ideaId1,
                    IsDelete = false
                }
                );

            //ContactEmail Table
            var contactEmailId1 = Guid.NewGuid().ToString();

            builder.Entity<ContactEmail>().HasData(
                new ContactEmail()
                {
                    Id = contactEmailId1,
                    Name = "Name Test",
                    Subject = "Subject Test",
                    Email = "Email Test",
                    Message = "Message Test"
                }
                );

        }
    }
}
