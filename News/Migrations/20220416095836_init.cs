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
                    { "2aa49c16-3651-43d1-ac91-b50b228afb85", "Des 1", "Category1" },
                    { "7239cbe9-0e60-4bf7-a60c-6f2031f7f9f9", "Des 2", "Category2" },
                    { "ae728b3d-1f3f-45d9-a2a1-bef488b6bd5d", "Des 3", "Category3" }
                });

            migrationBuilder.InsertData(
                table: "Department",
                columns: new[] { "department_Id", "department_Description", "department_Name" },
                values: new object[,]
                {
                    { "ae9b337f-f557-4419-86f6-870990d85ed3", "Department 1", "Department 1" },
                    { "97bf4447-9ee6-465f-b8b1-5c074d99cc32", "Department 2", "Department 2 " },
                    { "820d8279-f944-4c7c-9f66-c3eb1b1330d0", "Department 3", "Department 3" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Discriminator", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "aa3f7a29-b90a-4ea3-b78a-4fd4519548bb", "3928a2f5-216a-449a-9af5-47a3aea1ad5c", "Staff", "AppRole", "staff", null },
                    { "32cd6af2-db67-4efb-9a77-0958d4f3af82", "924be001-91cb-4c2a-8e0b-84a298bc0e97", "Admin", "AppRole", "admin", null }
                });

            migrationBuilder.InsertData(
                table: "Submission",
                columns: new[] { "submission_Id", "submission_Description", "submission_DueTime", "submission_Name", "submission_StartTime" },
                values: new object[] { "d3191f41-d75e-4282-918a-26d5d57c8e72", "AcademicYear1", new DateTime(2023, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "AcademicYear1", new DateTime(2021, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "DoB", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "b28e2c03-5ce5-4651-b1e2-9eb0322d0d5c", 0, "ece7cd25-be79-4b14-a09e-f5bfd3e3e91a", "AppUser", new DateTime(2022, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@gmail.com", true, null, "Admin", false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEBHUQDCF9U5xs+AgE7Z9XKmaLA1xn+ACsTAe+C2HXNayXVmbbEuapGx1/0h2/5qhdw==", null, false, "25a34628-d25c-4e91-b2d5-8f32c6127d13", false, "Admin" },
                    { "2a5d968d-8d5f-4133-9707-16dfb669dc23", 0, "0a3f7754-2692-4b23-b1c1-6fc932df610f", "AppUser", new DateTime(2022, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "staff@gmail.com", true, null, "Staff", false, null, "STAFF@GMAIL.COM", "STAFF@GMAIL.COM", "AQAAAAEAACcQAAAAEP+eAU7wGslMKsPuoeOKcdx+w2nVvdiLPIa+W/wkxPHLFUlWGHGM3QY2lzR9rWXl6w==", null, false, "741dfacd-ec69-4611-a1de-c266e341e358", false, "Staff" },
                    { "58bb86c1-59e7-43df-abc1-802ea05752c5", 0, "c2b683fd-ec89-43c2-9fe0-a36250b49b73", "AppUser", new DateTime(2022, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "staff2@gmail.com", true, null, "Staff2", false, null, "STAFF2@GMAIL.COM", "STAFF2@GMAIL.COM", "AQAAAAEAACcQAAAAEO3IUFclDD2bTjmb7kNZIcRHaaz7Yzw8V+ylZ2lQdGz3IpOE2lXLFjF4vcvkPUMKSw==", null, false, "fdf941fa-923e-44ac-bb70-b8148a970810", false, "Staff2" }
                });

            migrationBuilder.InsertData(
                table: "Idea",
                columns: new[] { "idea_Id", "idea_Agree", "idea_CategoryId", "idea_Description", "idea_ImageName", "idea_ImagePath", "idea_SubmissionId", "idea_Title", "idea_UpdateTime", "idea_UserId", "idea_View" },
                values: new object[,]
                {
                    { "322e678d-0edd-400b-b28c-31d926d79313", false, "2aa49c16-3651-43d1-ac91-b50b228afb85", "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Beatae ipsum non voluptatum eum repellendus quod aliquid. Vitae, dolorum voluptate quis repudiandae eos molestiae dolores enim.", "blog-1.jpg", null, "d3191f41-d75e-4282-918a-26d5d57c8e72", "Title1", new DateTime(2022, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "2a5d968d-8d5f-4133-9707-16dfb669dc23", 0 },
                    { "12234206-5ed9-49dd-8ba1-55d8c19b2fec", false, "7239cbe9-0e60-4bf7-a60c-6f2031f7f9f9", "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Beatae ipsum non voluptatum eum repellendus quod aliquid. Vitae, dolorum voluptate quis repudiandae eos molestiae dolores enim.", "blog-2.jpg", null, "d3191f41-d75e-4282-918a-26d5d57c8e72", "Title2", new DateTime(2022, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "2a5d968d-8d5f-4133-9707-16dfb669dc23", 0 },
                    { "cb2bd8b2-25e7-416d-a036-6dd350fb1dce", false, "7239cbe9-0e60-4bf7-a60c-6f2031f7f9f9", "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Beatae ipsum non voluptatum eum repellendus quod aliquid. Vitae, dolorum voluptate quis repudiandae eos molestiae dolores enim.", "blog-3.jpg", null, "d3191f41-d75e-4282-918a-26d5d57c8e72", "Title3", new DateTime(2022, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "b28e2c03-5ce5-4651-b1e2-9eb0322d0d5c", 0 }
                });

            migrationBuilder.InsertData(
                table: "UserInDepartment",
                columns: new[] { "uid_DepartmentId", "uid_UserId" },
                values: new object[,]
                {
                    { "ae9b337f-f557-4419-86f6-870990d85ed3", "b28e2c03-5ce5-4651-b1e2-9eb0322d0d5c" },
                    { "97bf4447-9ee6-465f-b8b1-5c074d99cc32", "2a5d968d-8d5f-4133-9707-16dfb669dc23" }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "32cd6af2-db67-4efb-9a77-0958d4f3af82", "b28e2c03-5ce5-4651-b1e2-9eb0322d0d5c" },
                    { "aa3f7a29-b90a-4ea3-b78a-4fd4519548bb", "2a5d968d-8d5f-4133-9707-16dfb669dc23" }
                });

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
