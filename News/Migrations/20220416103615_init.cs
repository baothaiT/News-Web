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
                    { "0dddad2f-c7a3-4849-b2f4-d6abd616ebfc", "Des 1", "Category1" },
                    { "ce24a0a7-fa28-458c-a687-3b311c683b32", "Des 2", "Category2" },
                    { "93078d09-1b0e-4d95-bf51-34537ef33fc2", "Des 3", "Category3" }
                });

            migrationBuilder.InsertData(
                table: "Department",
                columns: new[] { "department_Id", "department_Description", "department_Name" },
                values: new object[,]
                {
                    { "3d9d3ce8-bc08-4929-bb6b-185be26aafa3", "Department 1", "Department 1" },
                    { "e655b83b-a3ca-45b7-bbed-132956b18785", "Department 2", "Department 2 " },
                    { "97705cd0-1e15-4ac9-b02a-5187519fde20", "Department 3", "Department 3" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Discriminator", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "eda7d1f0-41e9-412b-a5a4-b9567850031c", "bc0f0fa4-7841-4bcf-9d99-bc9c0c239534", "Staff", "AppRole", "staff", null },
                    { "5d3f53b4-8fce-4d54-89c8-8a107aa51a19", "294f5f70-8ea8-4199-b2cf-e159d74686e5", "Admin", "AppRole", "admin", null }
                });

            migrationBuilder.InsertData(
                table: "Submission",
                columns: new[] { "submission_Id", "submission_Description", "submission_DueTime", "submission_Name", "submission_StartTime" },
                values: new object[] { "139a43ab-4233-4e32-b4fb-061398db7bbe", "AcademicYear1", new DateTime(2023, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "AcademicYear1", new DateTime(2021, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "DoB", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "63de45a0-62c3-4341-81e8-94143483c884", 0, "96ecbd66-6645-4925-8f9e-b9c5c874ade7", "AppUser", new DateTime(2022, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@gmail.com", true, null, "Admin", false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEDFQ5fPROakJNnTqav57LLZZANaZeHO5bVCddBTEn69gOU2j7i8k8XM8CfXVmIc0zA==", null, false, "1fd27514-67bc-4c3f-be6e-4faca223ec9c", false, "Admin" },
                    { "da124a04-44cb-477f-ae16-af064d5d44d8", 0, "5b7622b6-40d1-4749-bc6a-1b9849e2189d", "AppUser", new DateTime(2022, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "staff@gmail.com", true, null, "Staff", false, null, "STAFF@GMAIL.COM", "STAFF@GMAIL.COM", "AQAAAAEAACcQAAAAEJRN3GzYyyvCbt+Vj7nIbmLFaJIbNtAXadgOGgOpTJ4SgBltNNIoVivc9a8MXbB/sg==", null, false, "526995a4-9a2e-4002-ae15-8aac12c79f06", false, "Staff" },
                    { "c5351d33-2d6c-4d69-b180-8b2549725ee6", 0, "3ec3c06c-8388-44c5-8b91-ef56345a2736", "AppUser", new DateTime(2022, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "staff2@gmail.com", true, null, "Staff2", false, null, "STAFF2@GMAIL.COM", "STAFF2@GMAIL.COM", "AQAAAAEAACcQAAAAED+gqXVn/HIdv+gEf3Sdmkekwn1scNTAc5iyLpFs8zYfqrhJ/vAUPThdHqf50sLIsQ==", null, false, "fc08519e-630a-4621-8df5-17f8f69b64a9", false, "Staff2" }
                });

            migrationBuilder.InsertData(
                table: "Idea",
                columns: new[] { "idea_Id", "idea_Agree", "idea_CategoryId", "idea_Description", "idea_ImageName", "idea_ImagePath", "idea_SubmissionId", "idea_Title", "idea_UpdateTime", "idea_UserId", "idea_View" },
                values: new object[,]
                {
                    { "97c9adee-d410-4cd7-867e-883bd66ec28a", false, "0dddad2f-c7a3-4849-b2f4-d6abd616ebfc", "<p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Beatae ipsum non voluptatum eum repellendus quod aliquid. Vitae, dolorum voluptate quis repudiandae eos molestiae dolores enim. </p>", "blog-1.png", null, "139a43ab-4233-4e32-b4fb-061398db7bbe", "Title1", new DateTime(2022, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "da124a04-44cb-477f-ae16-af064d5d44d8", 0 },
                    { "c46da456-7fec-4719-8a23-e5c97c553a7f", false, "ce24a0a7-fa28-458c-a687-3b311c683b32", "<p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Beatae ipsum non voluptatum eum repellendus quod aliquid. Vitae, dolorum voluptate quis repudiandae eos molestiae dolores enim. </p>", "blog-2.png", null, "139a43ab-4233-4e32-b4fb-061398db7bbe", "Title2", new DateTime(2022, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "da124a04-44cb-477f-ae16-af064d5d44d8", 0 },
                    { "fd2daa68-bf5a-417a-963c-dedade9988c6", false, "ce24a0a7-fa28-458c-a687-3b311c683b32", "<p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Beatae ipsum non voluptatum eum repellendus quod aliquid. Vitae, dolorum voluptate quis repudiandae eos molestiae dolores enim. </p>", "blog-3.png", null, "139a43ab-4233-4e32-b4fb-061398db7bbe", "Title3", new DateTime(2022, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "63de45a0-62c3-4341-81e8-94143483c884", 0 }
                });

            migrationBuilder.InsertData(
                table: "UserInDepartment",
                columns: new[] { "uid_DepartmentId", "uid_UserId" },
                values: new object[,]
                {
                    { "3d9d3ce8-bc08-4929-bb6b-185be26aafa3", "63de45a0-62c3-4341-81e8-94143483c884" },
                    { "e655b83b-a3ca-45b7-bbed-132956b18785", "da124a04-44cb-477f-ae16-af064d5d44d8" }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "5d3f53b4-8fce-4d54-89c8-8a107aa51a19", "63de45a0-62c3-4341-81e8-94143483c884" },
                    { "eda7d1f0-41e9-412b-a5a4-b9567850031c", "da124a04-44cb-477f-ae16-af064d5d44d8" }
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
