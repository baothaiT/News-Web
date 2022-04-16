using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace News.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    category_Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    category_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    category_Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.category_Id);
                });

            migrationBuilder.CreateTable(
                name: "Department",
                columns: table => new
                {
                    department_Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    department_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    department_Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Department", x => x.department_Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Submission",
                columns: table => new
                {
                    submission_Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    submission_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    submission_Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    submission_StartTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    submission_DueTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Submission", x => x.submission_Id);
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
                    idea_UserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
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
                name: "Comments",
                columns: table => new
                {
                    cmt_Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    cmt_Content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cmt_UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    cmt_UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    cmt_IdeaId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    cmt_IsDelete = table.Column<bool>(type: "bit", nullable: false)
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
                    likeInIdea_Like = table.Column<int>(type: "int", nullable: false),
                    likeInIdea_DisLike = table.Column<int>(type: "int", nullable: false),
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
                columns: new[] { "category_Id", "category_Description", "category_Name" },
                values: new object[,]
                {
                    { "1ddfe87e-d074-4365-83fc-498b603e9e9e", "Des 1", "Category1" },
                    { "d69587a5-0e58-4e51-8e91-ba3d5b90bdf4", "Des 2", "Category2" },
                    { "2446c36b-26cf-4544-82a6-9280a06bd704", "Des 3", "Category3" }
                });

            migrationBuilder.InsertData(
                table: "Department",
                columns: new[] { "department_Id", "department_Description", "department_Name" },
                values: new object[,]
                {
                    { "ca63d27f-7176-4c16-8ca2-1fd0f10ba5ae", "Department 1", "Department 1" },
                    { "01ba1636-2ab5-4a0b-9d8f-1c8e2bbaffb2", "Department 2", "Department 2 " },
                    { "dd176980-f93e-456a-8fed-43182383d6da", "Department 3", "Department 3" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Discriminator", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4fd340e2-7fed-435b-b5dd-7d12e2d1c1b2", "bcb8ebb4-283d-4563-ab55-ae2bbe7e3f63", "Staff", "AppRole", "staff", null },
                    { "03cca429-b877-4735-9b6b-dc689c042553", "5f6aff12-8931-4deb-b999-270ec6a0e9a4", "Admin", "AppRole", "admin", null }
                });

            migrationBuilder.InsertData(
                table: "Submission",
                columns: new[] { "submission_Id", "submission_Description", "submission_DueTime", "submission_Name", "submission_StartTime" },
                values: new object[] { "57f70f6d-c11e-45c5-962d-6e2c44e03c6b", "AcademicYear1", new DateTime(2023, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "AcademicYear1", new DateTime(2021, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "DoB", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "64546a2c-75d4-47d3-82b3-adcd5a87915a", 0, "2a157fb5-d76f-4220-8730-321046dc638c", "AppUser", new DateTime(2022, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@gmail.com", true, null, "Admin", false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEF60/tWZeb83Z0GhqDQKLkZwK5pRW69VfTWIi0aIDfE18bjSX6fCkvs2bfTTmR3g7g==", null, false, "d35f1a98-1e4d-4e07-a22a-962c0fb3c2f9", false, "Admin" },
                    { "9b5160cd-3f91-436e-b21f-1fd102eaa84c", 0, "8d0f0f0d-c7f7-48eb-83ac-b78e195f04a5", "AppUser", new DateTime(2022, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "staff@gmail.com", true, null, "Staff", false, null, "STAFF@GMAIL.COM", "STAFF@GMAIL.COM", "AQAAAAEAACcQAAAAEBrMEWOl8bnezyYzH+c4Iob+EeBMLPhlecxwTFpPzpHC2GxKVGP6cQrf1BmxWStMcA==", null, false, "c50aa838-d37b-4ff1-9284-e5f303102210", false, "Staff" },
                    { "dafa23d2-5ac0-453e-be5c-a3e93fa70b7c", 0, "8167614c-e2e2-4ee9-b132-7d9330ab721c", "AppUser", new DateTime(2022, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "staff2@gmail.com", true, null, "Staff2", false, null, "STAFF2@GMAIL.COM", "STAFF2@GMAIL.COM", "AQAAAAEAACcQAAAAEKOii7TQ+eWn9D1PylQ/IUU/ClCXQXuxp85PPRfT0xzdaJQX6cOIjje58PP1tx3D+A==", null, false, "f319540b-6801-4c00-a22f-65a5b8d1cea4", false, "Staff2" }
                });

            migrationBuilder.InsertData(
                table: "Idea",
                columns: new[] { "idea_Id", "idea_Agree", "idea_CategoryId", "idea_Description", "idea_ImageName", "idea_ImagePath", "idea_SubmissionId", "idea_Title", "idea_UpdateTime", "idea_UserId", "idea_View" },
                values: new object[,]
                {
                    { "5a76199f-171b-4e94-9328-7b7186a449f2", false, "1ddfe87e-d074-4365-83fc-498b603e9e9e", "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Beatae ipsum non voluptatum eum repellendus quod aliquid. Vitae, dolorum voluptate quis repudiandae eos molestiae dolores enim. ", "blog-1.png", null, "57f70f6d-c11e-45c5-962d-6e2c44e03c6b", "Title1", new DateTime(2022, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "9b5160cd-3f91-436e-b21f-1fd102eaa84c", 0 },
                    { "e59bc9dd-9c1e-42e8-8e11-494daed0d377", false, "d69587a5-0e58-4e51-8e91-ba3d5b90bdf4", "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Beatae ipsum non voluptatum eum repellendus quod aliquid. Vitae, dolorum voluptate quis repudiandae eos molestiae dolores enim. ", "blog-2.png", null, "57f70f6d-c11e-45c5-962d-6e2c44e03c6b", "Title2", new DateTime(2022, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "9b5160cd-3f91-436e-b21f-1fd102eaa84c", 0 },
                    { "313b0056-8e14-4e94-8b5d-dfb2965fb8eb", false, "d69587a5-0e58-4e51-8e91-ba3d5b90bdf4", "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Beatae ipsum non voluptatum eum repellendus quod aliquid. Vitae, dolorum voluptate quis repudiandae eos molestiae dolores enim. ", "blog-3.png", null, "57f70f6d-c11e-45c5-962d-6e2c44e03c6b", "Title3", new DateTime(2022, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "64546a2c-75d4-47d3-82b3-adcd5a87915a", 0 }
                });

            migrationBuilder.InsertData(
                table: "UserInDepartment",
                columns: new[] { "uid_DepartmentId", "uid_UserId" },
                values: new object[,]
                {
                    { "ca63d27f-7176-4c16-8ca2-1fd0f10ba5ae", "64546a2c-75d4-47d3-82b3-adcd5a87915a" },
                    { "01ba1636-2ab5-4a0b-9d8f-1c8e2bbaffb2", "9b5160cd-3f91-436e-b21f-1fd102eaa84c" }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "03cca429-b877-4735-9b6b-dc689c042553", "64546a2c-75d4-47d3-82b3-adcd5a87915a" },
                    { "4fd340e2-7fed-435b-b5dd-7d12e2d1c1b2", "9b5160cd-3f91-436e-b21f-1fd102eaa84c" }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "cmt_Id", "cmt_Content", "cmt_IdeaId", "cmt_IsDelete", "cmt_UpdateDate", "cmt_UserId" },
                values: new object[] { "ff90f68d-7486-47a1-885b-6dd994b229cd", "Comment1", "5a76199f-171b-4e94-9328-7b7186a449f2", false, new DateTime(2022, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "64546a2c-75d4-47d3-82b3-adcd5a87915a" });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "cmt_Id", "cmt_Content", "cmt_IdeaId", "cmt_IsDelete", "cmt_UpdateDate", "cmt_UserId" },
                values: new object[] { "4753a838-4212-459e-82a7-cfeaad7714a0", "Comment2", "5a76199f-171b-4e94-9328-7b7186a449f2", false, new DateTime(2022, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "9b5160cd-3f91-436e-b21f-1fd102eaa84c" });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "cmt_Id", "cmt_Content", "cmt_IdeaId", "cmt_IsDelete", "cmt_UpdateDate", "cmt_UserId" },
                values: new object[] { "456d0a12-51df-41fd-89fa-704f2311301e", "Comment3", "5a76199f-171b-4e94-9328-7b7186a449f2", false, new DateTime(2022, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "64546a2c-75d4-47d3-82b3-adcd5a87915a" });

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
                name: "Comments");

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
