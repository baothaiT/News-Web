using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace News.Migrations
{
    public partial class @int : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AssignToRoleModels",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssignToRoleModels", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    category_Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    category_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    category_Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.category_Id);
                });

            migrationBuilder.CreateTable(
                name: "ContactEmail",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Subject = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactEmail", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Department",
                columns: table => new
                {
                    department_Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    department_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    department_Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Department", x => x.department_Id);
                });

            migrationBuilder.CreateTable(
                name: "DetailIdeaModels",
                columns: table => new
                {
                    idea_Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    idea_Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    idea_Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    idea_UpdateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    idea_ImageName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    idea_CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    idea_SubmissionName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    idea_UserName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetailIdeaModels", x => x.idea_Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DoB = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RoleClaims_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Submission",
                columns: table => new
                {
                    submission_Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    submission_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    submission_Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    submission_StartTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    submission_DueTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    submission_UserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Submission", x => x.submission_Id);
                    table.ForeignKey(
                        name: "FK_Submission_Users_submission_UserId",
                        column: x => x.submission_UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserClaims_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserInDepartment",
                columns: table => new
                {
                    uid_UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    uid_DepartmentId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserInDepartment", x => new { x.uid_UserId, x.uid_DepartmentId });
                    table.ForeignKey(
                        name: "FK_UserInDepartment_Department_uid_DepartmentId",
                        column: x => x.uid_DepartmentId,
                        principalTable: "Department",
                        principalColumn: "department_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserInDepartment_Users_uid_UserId",
                        column: x => x.uid_UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_UserLogins_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_UserRoles_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRoles_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_UserTokens_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Idea",
                columns: table => new
                {
                    idea_Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    idea_Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    idea_Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    idea_View = table.Column<int>(type: "int", nullable: false),
                    idea_UpdateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    idea_Agree = table.Column<bool>(type: "bit", nullable: false),
                    idea_ImageName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    idea_ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    idea_CategoryId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    idea_SubmissionId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    idea_UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Idea", x => x.idea_Id);
                    table.ForeignKey(
                        name: "FK_Idea_Categories_idea_CategoryId",
                        column: x => x.idea_CategoryId,
                        principalTable: "Categories",
                        principalColumn: "category_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Idea_Submission_idea_SubmissionId",
                        column: x => x.idea_SubmissionId,
                        principalTable: "Submission",
                        principalColumn: "submission_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Idea_Users_idea_UserId",
                        column: x => x.idea_UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    cmt_Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    cmt_Content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cmt_UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    cmt_UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    cmt_IdeaId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.cmt_Id);
                    table.ForeignKey(
                        name: "FK_Comments_Idea_cmt_IdeaId",
                        column: x => x.cmt_IdeaId,
                        principalTable: "Idea",
                        principalColumn: "idea_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Comments_Users_cmt_UserId",
                        column: x => x.cmt_UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LikeInIdea",
                columns: table => new
                {
                    likeInIdea_Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    likeInIdea_Like = table.Column<bool>(type: "bit", nullable: false),
                    likeInIdea_DisLike = table.Column<bool>(type: "bit", nullable: false),
                    likeInIdea_CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    likeInIdea_UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    likeInIdea_IdeaId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LikeInIdea", x => x.likeInIdea_Id);
                    table.ForeignKey(
                        name: "FK_LikeInIdea_Idea_likeInIdea_IdeaId",
                        column: x => x.likeInIdea_IdeaId,
                        principalTable: "Idea",
                        principalColumn: "idea_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LikeInIdea_Users_likeInIdea_UserId",
                        column: x => x.likeInIdea_UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "category_Id", "IsDelete", "category_Description", "category_Name" },
                values: new object[,]
                {
                    { "2afb786f-9424-4c26-8098-081a3e3913e4", false, "Des 1", "Category1" },
                    { "11a3f89a-6396-43b6-a64d-311251544356", false, "Des 2", "Category2" },
                    { "7a451a04-24c0-4d20-b0be-0e0e2988c88a", false, "Des 3", "Category3" }
                });

            migrationBuilder.InsertData(
                table: "ContactEmail",
                columns: new[] { "Id", "Email", "Message", "Name", "Subject" },
                values: new object[] { "2f0b8f3d-87ba-442f-ad17-e43203e916ae", "Email Test", "Message Test", "Name Test", "Subject Test" });

            migrationBuilder.InsertData(
                table: "Department",
                columns: new[] { "department_Id", "IsDelete", "department_Description", "department_Name" },
                values: new object[,]
                {
                    { "777127d0-3f73-4274-827e-a28690b445cf", false, "Department 1", "Department 1" },
                    { "d44af338-7cc0-4e80-a482-7a0dca509d5f", false, "Department 2", "Department 2 " },
                    { "fc76596b-c522-4592-ae54-0d4b4b24723d", false, "Department 3", "Department 3" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Discriminator", "IsDelete", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "fc89639a-b5f8-4c60-8c8e-a4d0caa6d0e9", "f6c077e4-deb7-4b75-bbe6-dea028d9482c", "Staff", "AppRole", false, "Staff", "staff" },
                    { "cd41a493-c1d7-4e8a-851d-c4a543fc8903", "aa51b7db-76f6-424b-8723-5685714ab4ba", "Admin", "AppRole", false, "Admin", "admin" }
                });

            migrationBuilder.InsertData(
                table: "Submission",
                columns: new[] { "submission_Id", "IsDelete", "submission_Description", "submission_DueTime", "submission_Name", "submission_StartTime", "submission_UserId" },
                values: new object[] { "9c0ec5b3-0116-41e8-9fc0-4aa926c4a0bb", false, "Submission1", new DateTime(2023, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Submission1", new DateTime(2021, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "DoB", "Email", "EmailConfirmed", "FirstName", "IsDelete", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "edd08de3-5bb3-49f9-9bde-2c982f0d50ba", 0, "ab8292da-7724-4979-95b8-719307b1a7cc", "AppUser", new DateTime(2022, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@gmail.com", true, null, false, "Admin", false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEGbagH21EKYIsRgo1C3jCUZ7cVHviH43bPYKSGLPB8zFO5i1vO1BRTDxDVVymLyzcQ==", null, false, "c040a170-c00d-4fcc-9bf4-d0a44a095674", false, "Admin" },
                    { "61bdc17c-bc12-4304-b17a-660c18e76af4", 0, "87fb822b-ad7d-4608-93b5-dd6f63aa8829", "AppUser", new DateTime(2022, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "staff@gmail.com", true, null, false, "Staff", false, null, "STAFF@GMAIL.COM", "STAFF@GMAIL.COM", "AQAAAAEAACcQAAAAEP52hEEo+WfEd0syph1CbhuJlOMp7V35ycGgDSC1fqFFAUa+/Lwfn3yvfP3iSNfmNA==", null, false, "ddcd0133-36e9-475f-91ab-3b78a50f333e", false, "Staff" },
                    { "2f9df61d-5cf3-44a2-a7b0-c3d8ec8d2c20", 0, "9f0245cb-6a3a-4822-afc1-68c93fee807b", "AppUser", new DateTime(2022, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "staff2@gmail.com", true, null, false, "Staff2", false, null, "STAFF2@GMAIL.COM", "STAFF2@GMAIL.COM", "AQAAAAEAACcQAAAAECMdljR2HphEPDivrBklsRthhGwSo3Sx1zemudEjPw+VcE8b+ULmeIlCB1gA4aVPig==", null, false, "fd64d8ca-1e00-4d56-87c1-b8df68cbe005", false, "Staff2" },
                    { "381bc30c-550d-45d9-a78e-84b794782ce4", 0, "422d3fa6-4a68-45d8-824d-874680d8b9f0", "AppUser", new DateTime(2022, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "anonymous@gmail.com", true, null, false, "Anonymous", false, null, "ANOYMOUS@GMAIL.COM", "ANOYMOUS@GMAIL.COM", "AQAAAAEAACcQAAAAEEPtjpCbW+2iNxqZpLX0+v7GVd8o5RLk4lKoEBw/HlQ3iunYauvdupVizEI3SQ7bCQ==", null, false, "fca1e68e-9ef7-4ccd-808a-978086bbda7d", false, "Anonymous" }
                });

            migrationBuilder.InsertData(
                table: "Idea",
                columns: new[] { "idea_Id", "IsDelete", "idea_Agree", "idea_CategoryId", "idea_Description", "idea_ImageName", "idea_ImagePath", "idea_SubmissionId", "idea_Title", "idea_UpdateTime", "idea_UserId", "idea_View" },
                values: new object[,]
                {
                    { "fd27dfc2-3234-4eb1-93a9-3d70867189e8", false, false, "2afb786f-9424-4c26-8098-081a3e3913e4", "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Beatae ipsum non voluptatum eum repellendus quod aliquid. Vitae, dolorum voluptate quis repudiandae eos molestiae dolores enim. ", "blog-1.png", null, "9c0ec5b3-0116-41e8-9fc0-4aa926c4a0bb", "Title1", new DateTime(2022, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "61bdc17c-bc12-4304-b17a-660c18e76af4", 0 },
                    { "2932cc11-ca5a-4009-96cc-00c937bbdc99", false, false, "11a3f89a-6396-43b6-a64d-311251544356", "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Beatae ipsum non voluptatum eum repellendus quod aliquid. Vitae, dolorum voluptate quis repudiandae eos molestiae dolores enim. ", "blog-2.png", null, "9c0ec5b3-0116-41e8-9fc0-4aa926c4a0bb", "Title2", new DateTime(2022, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "61bdc17c-bc12-4304-b17a-660c18e76af4", 0 },
                    { "b2f72874-584c-4e83-971b-fef4c0b2587d", false, false, "11a3f89a-6396-43b6-a64d-311251544356", "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Beatae ipsum non voluptatum eum repellendus quod aliquid. Vitae, dolorum voluptate quis repudiandae eos molestiae dolores enim. ", "blog-3.png", null, "9c0ec5b3-0116-41e8-9fc0-4aa926c4a0bb", "Title3", new DateTime(2022, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "edd08de3-5bb3-49f9-9bde-2c982f0d50ba", 0 }
                });

            migrationBuilder.InsertData(
                table: "UserInDepartment",
                columns: new[] { "uid_DepartmentId", "uid_UserId" },
                values: new object[,]
                {
                    { "777127d0-3f73-4274-827e-a28690b445cf", "edd08de3-5bb3-49f9-9bde-2c982f0d50ba" },
                    { "d44af338-7cc0-4e80-a482-7a0dca509d5f", "61bdc17c-bc12-4304-b17a-660c18e76af4" }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "cd41a493-c1d7-4e8a-851d-c4a543fc8903", "edd08de3-5bb3-49f9-9bde-2c982f0d50ba" },
                    { "fc89639a-b5f8-4c60-8c8e-a4d0caa6d0e9", "61bdc17c-bc12-4304-b17a-660c18e76af4" }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "cmt_Id", "IsDelete", "cmt_Content", "cmt_IdeaId", "cmt_UpdateDate", "cmt_UserId" },
                values: new object[] { "edbde984-c101-4614-893b-a51f68367e22", false, "Comment1", "fd27dfc2-3234-4eb1-93a9-3d70867189e8", new DateTime(2022, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "edd08de3-5bb3-49f9-9bde-2c982f0d50ba" });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "cmt_Id", "IsDelete", "cmt_Content", "cmt_IdeaId", "cmt_UpdateDate", "cmt_UserId" },
                values: new object[] { "fba7c5c4-4245-4ba2-addd-9e87f3665989", false, "Comment2", "fd27dfc2-3234-4eb1-93a9-3d70867189e8", new DateTime(2022, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "61bdc17c-bc12-4304-b17a-660c18e76af4" });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "cmt_Id", "IsDelete", "cmt_Content", "cmt_IdeaId", "cmt_UpdateDate", "cmt_UserId" },
                values: new object[] { "37338b5d-f8b1-4656-814c-31ce5e7676e3", false, "Comment3", "fd27dfc2-3234-4eb1-93a9-3d70867189e8", new DateTime(2022, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "edd08de3-5bb3-49f9-9bde-2c982f0d50ba" });

            migrationBuilder.CreateIndex(
                name: "IX_Comments_cmt_IdeaId",
                table: "Comments",
                column: "cmt_IdeaId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_cmt_UserId",
                table: "Comments",
                column: "cmt_UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Idea_idea_CategoryId",
                table: "Idea",
                column: "idea_CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Idea_idea_SubmissionId",
                table: "Idea",
                column: "idea_SubmissionId");

            migrationBuilder.CreateIndex(
                name: "IX_Idea_idea_UserId",
                table: "Idea",
                column: "idea_UserId");

            migrationBuilder.CreateIndex(
                name: "IX_LikeInIdea_likeInIdea_IdeaId",
                table: "LikeInIdea",
                column: "likeInIdea_IdeaId");

            migrationBuilder.CreateIndex(
                name: "IX_LikeInIdea_likeInIdea_UserId",
                table: "LikeInIdea",
                column: "likeInIdea_UserId");

            migrationBuilder.CreateIndex(
                name: "IX_RoleClaims_RoleId",
                table: "RoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "Roles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Submission_submission_UserId",
                table: "Submission",
                column: "submission_UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserClaims_UserId",
                table: "UserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserInDepartment_uid_DepartmentId",
                table: "UserInDepartment",
                column: "uid_DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_UserLogins_UserId",
                table: "UserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_RoleId",
                table: "UserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "Users",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "Users",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AssignToRoleModels");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "ContactEmail");

            migrationBuilder.DropTable(
                name: "DetailIdeaModels");

            migrationBuilder.DropTable(
                name: "LikeInIdea");

            migrationBuilder.DropTable(
                name: "RoleClaims");

            migrationBuilder.DropTable(
                name: "UserClaims");

            migrationBuilder.DropTable(
                name: "UserInDepartment");

            migrationBuilder.DropTable(
                name: "UserLogins");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "UserTokens");

            migrationBuilder.DropTable(
                name: "Idea");

            migrationBuilder.DropTable(
                name: "Department");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Submission");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
