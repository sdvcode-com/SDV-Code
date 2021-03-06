using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SdvCode.Web.Migrations
{
    public partial class M1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BaseData",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SystemMessage = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BaseData", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleLevel = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CountryCodes",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CountryCodes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CountryCodes_BaseData_Id",
                        column: x => x.Id,
                        principalTable: "BaseData",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
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
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    CountryCodeId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Countries_BaseData_Id",
                        column: x => x.Id,
                        principalTable: "BaseData",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Countries_CountryCodes_CountryCodeId",
                        column: x => x.CountryCodeId,
                        principalTable: "CountryCodes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "States",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    CountryId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_States", x => x.Id);
                    table.ForeignKey(
                        name: "FK_States_BaseData_Id",
                        column: x => x.Id,
                        principalTable: "BaseData",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_States_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    StateId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CountryId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cities_BaseData_Id",
                        column: x => x.Id,
                        principalTable: "BaseData",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Cities_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Cities_States_StateId",
                        column: x => x.StateId,
                        principalTable: "States",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ZipCodes",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    CityId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ZipCodes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ZipCodes_BaseData_Id",
                        column: x => x.Id,
                        principalTable: "BaseData",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ZipCodes_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RegisteredOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    MiddleName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AboutMe = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CoverImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GitHubUrl = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    StackoverflowUrl = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    FacebookUrl = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    LinkedinUrl = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    TwitterUrl = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    InstagramUrl = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    IsBlocked = table.Column<bool>(type: "bit", nullable: false),
                    ReasonToBeBlocked = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    ZipCodeId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CountryId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    StateId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CityId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CountryCodeId = table.Column<string>(type: "nvarchar(450)", nullable: true),
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
                    table.ForeignKey(
                        name: "FK_Users_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Users_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Users_CountryCodes_CountryCodeId",
                        column: x => x.CountryCodeId,
                        principalTable: "CountryCodes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Users_States_StateId",
                        column: x => x.StateId,
                        principalTable: "States",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Users_ZipCodes_ZipCodeId",
                        column: x => x.ZipCodeId,
                        principalTable: "ZipCodes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
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
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BlogCategories",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    OwnerId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogCategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BlogCategories_BaseData_Id",
                        column: x => x.Id,
                        principalTable: "BaseData",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BlogCategories_Users_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BlogTags",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    OwnerId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogTags", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BlogTags_BaseData_Id",
                        column: x => x.Id,
                        principalTable: "BaseData",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BlogTags_Users_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Follows",
                columns: table => new
                {
                    FollowerId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FolloweeId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IsFollow = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Follows", x => new { x.FollowerId, x.FolloweeId });
                    table.ForeignKey(
                        name: "FK_Follows_Users_FolloweeId",
                        column: x => x.FolloweeId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Follows_Users_FollowerId",
                        column: x => x.FollowerId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UsersRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsersRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_UsersRoles_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UsersRoles_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WebsiteActions",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ActionType = table.Column<int>(type: "int", nullable: false),
                    ActionStatus = table.Column<int>(type: "int", nullable: false),
                    OwnerId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ReceiverId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WebsiteActions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WebsiteActions_BaseData_Id",
                        column: x => x.Id,
                        principalTable: "BaseData",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_WebsiteActions_Users_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WebsiteActions_Users_ReceiverId",
                        column: x => x.ReceiverId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "WebsiteImages",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    SystemName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    Extension = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    CloudinaryPath = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    ImageType = table.Column<int>(type: "int", nullable: false),
                    OwnerId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WebsiteImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WebsiteImages_BaseData_Id",
                        column: x => x.Id,
                        principalTable: "BaseData",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_WebsiteImages_Users_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BlogPosts",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    AuthorId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CategoryId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogPosts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BlogPosts_BaseData_Id",
                        column: x => x.Id,
                        principalTable: "BaseData",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BlogPosts_BlogCategories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "BlogCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BlogPosts_Users_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "EditPersonalDataActions",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Message = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EditPersonalDataActions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EditPersonalDataActions_WebsiteActions_Id",
                        column: x => x.Id,
                        principalTable: "WebsiteActions",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "UserCoverImages",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserCoverImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserCoverImages_WebsiteImages_Id",
                        column: x => x.Id,
                        principalTable: "WebsiteImages",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "UserProfileImages",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserProfileImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserProfileImages_WebsiteImages_Id",
                        column: x => x.Id,
                        principalTable: "WebsiteImages",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "BasePostActions",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PostId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BasePostActions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BasePostActions_BlogPosts_PostId",
                        column: x => x.PostId,
                        principalTable: "BlogPosts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BasePostActions_WebsiteActions_Id",
                        column: x => x.Id,
                        principalTable: "WebsiteActions",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "BasePostImages",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PostId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BasePostImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BasePostImages_BlogPosts_PostId",
                        column: x => x.PostId,
                        principalTable: "BlogPosts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BasePostImages_WebsiteImages_Id",
                        column: x => x.Id,
                        principalTable: "WebsiteImages",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "BlockedPosts",
                columns: table => new
                {
                    PostId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IsBlocked = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlockedPosts", x => new { x.UserId, x.PostId });
                    table.ForeignKey(
                        name: "FK_BlockedPosts_BlogPosts_PostId",
                        column: x => x.PostId,
                        principalTable: "BlogPosts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BlockedPosts_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BlogComments",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    OwnerId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    PostId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ParentCommentId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogComments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BlogComments_BaseData_Id",
                        column: x => x.Id,
                        principalTable: "BaseData",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BlogComments_BlogComments_ParentCommentId",
                        column: x => x.ParentCommentId,
                        principalTable: "BlogComments",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BlogComments_BlogPosts_PostId",
                        column: x => x.PostId,
                        principalTable: "BlogPosts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BlogComments_Users_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BlogPostLikes",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PostId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IsLiked = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogPostLikes", x => new { x.UserId, x.PostId });
                    table.ForeignKey(
                        name: "FK_BlogPostLikes_BlogPosts_PostId",
                        column: x => x.PostId,
                        principalTable: "BlogPosts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BlogPostLikes_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BlogPostsTags",
                columns: table => new
                {
                    TagId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PostId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogPostsTags", x => new { x.PostId, x.TagId });
                    table.ForeignKey(
                        name: "FK_BlogPostsTags_BlogPosts_PostId",
                        column: x => x.PostId,
                        principalTable: "BlogPosts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BlogPostsTags_BlogTags_TagId",
                        column: x => x.TagId,
                        principalTable: "BlogTags",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FavoritePosts",
                columns: table => new
                {
                    PostId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IsFavorite = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FavoritePosts", x => new { x.UserId, x.PostId });
                    table.ForeignKey(
                        name: "FK_FavoritePosts_BlogPosts_PostId",
                        column: x => x.PostId,
                        principalTable: "BlogPosts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FavoritePosts_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PendingPosts",
                columns: table => new
                {
                    PostId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IsPending = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PendingPosts", x => new { x.UserId, x.PostId });
                    table.ForeignKey(
                        name: "FK_PendingPosts_BlogPosts_PostId",
                        column: x => x.PostId,
                        principalTable: "BlogPosts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PendingPosts_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ChangeProfileCoverImageActions",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserCoverImageId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChangeProfileCoverImageActions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ChangeProfileCoverImageActions_UserCoverImages_UserCoverImageId",
                        column: x => x.UserCoverImageId,
                        principalTable: "UserCoverImages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChangeProfileCoverImageActions_WebsiteActions_Id",
                        column: x => x.Id,
                        principalTable: "WebsiteActions",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ChangeProfileImageActions",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserProfileImageId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChangeProfileImageActions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ChangeProfileImageActions_UserProfileImages_UserProfileImageId",
                        column: x => x.UserProfileImageId,
                        principalTable: "UserProfileImages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChangeProfileImageActions_WebsiteActions_Id",
                        column: x => x.Id,
                        principalTable: "WebsiteActions",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CreatedPostActions",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CreatedPostActions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CreatedPostActions_BasePostActions_Id",
                        column: x => x.Id,
                        principalTable: "BasePostActions",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CreatePostActions",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CreatePostActions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CreatePostActions_BasePostActions_Id",
                        column: x => x.Id,
                        principalTable: "BasePostActions",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "DeletedPostActions",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ReasonToBeDeleted = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeletedPostActions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DeletedPostActions_BasePostActions_Id",
                        column: x => x.Id,
                        principalTable: "BasePostActions",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "DeleteOwnPostActions",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ReasonToBeDeleted = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeleteOwnPostActions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DeleteOwnPostActions_BasePostActions_Id",
                        column: x => x.Id,
                        principalTable: "BasePostActions",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "DeletePostActions",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ReasonToBeDeleted = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeletePostActions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DeletePostActions_BasePostActions_Id",
                        column: x => x.Id,
                        principalTable: "BasePostActions",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "EditedPostActions",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EditedPostActions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EditedPostActions_BasePostActions_Id",
                        column: x => x.Id,
                        principalTable: "BasePostActions",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "EditOwnPostActions",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EditOwnPostActions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EditOwnPostActions_BasePostActions_Id",
                        column: x => x.Id,
                        principalTable: "BasePostActions",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "EditPostActions",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EditPostActions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EditPostActions_BasePostActions_Id",
                        column: x => x.Id,
                        principalTable: "BasePostActions",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "LikedPostActions",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LikedPostActions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LikedPostActions_BasePostActions_Id",
                        column: x => x.Id,
                        principalTable: "BasePostActions",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "LikeOwnPostActions",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LikeOwnPostActions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LikeOwnPostActions_BasePostActions_Id",
                        column: x => x.Id,
                        principalTable: "BasePostActions",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "LikePostActions",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LikePostActions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LikePostActions_BasePostActions_Id",
                        column: x => x.Id,
                        principalTable: "BasePostActions",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "UnlikedPostActions",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnlikedPostActions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UnlikedPostActions_BasePostActions_Id",
                        column: x => x.Id,
                        principalTable: "BasePostActions",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "UnlikeOwnPostActions",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnlikeOwnPostActions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UnlikeOwnPostActions_BasePostActions_Id",
                        column: x => x.Id,
                        principalTable: "BasePostActions",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "UnlikePostActions",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnlikePostActions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UnlikePostActions_BasePostActions_Id",
                        column: x => x.Id,
                        principalTable: "BasePostActions",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PostCoverImages",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostCoverImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PostCoverImages_BasePostImages_Id",
                        column: x => x.Id,
                        principalTable: "BasePostImages",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PostImages",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PostImages_BasePostImages_Id",
                        column: x => x.Id,
                        principalTable: "BasePostImages",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_BasePostActions_PostId",
                table: "BasePostActions",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_BasePostImages_PostId",
                table: "BasePostImages",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_BlockedPosts_PostId",
                table: "BlockedPosts",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_BlogCategories_OwnerId",
                table: "BlogCategories",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_BlogComments_OwnerId",
                table: "BlogComments",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_BlogComments_ParentCommentId",
                table: "BlogComments",
                column: "ParentCommentId");

            migrationBuilder.CreateIndex(
                name: "IX_BlogComments_PostId",
                table: "BlogComments",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_BlogPostLikes_PostId",
                table: "BlogPostLikes",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_BlogPosts_AuthorId",
                table: "BlogPosts",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_BlogPosts_CategoryId",
                table: "BlogPosts",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_BlogPostsTags_TagId",
                table: "BlogPostsTags",
                column: "TagId");

            migrationBuilder.CreateIndex(
                name: "IX_BlogTags_OwnerId",
                table: "BlogTags",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_ChangeProfileCoverImageActions_UserCoverImageId",
                table: "ChangeProfileCoverImageActions",
                column: "UserCoverImageId");

            migrationBuilder.CreateIndex(
                name: "IX_ChangeProfileImageActions_UserProfileImageId",
                table: "ChangeProfileImageActions",
                column: "UserProfileImageId");

            migrationBuilder.CreateIndex(
                name: "IX_Cities_CountryId",
                table: "Cities",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Cities_StateId",
                table: "Cities",
                column: "StateId");

            migrationBuilder.CreateIndex(
                name: "IX_Countries_CountryCodeId",
                table: "Countries",
                column: "CountryCodeId");

            migrationBuilder.CreateIndex(
                name: "IX_FavoritePosts_PostId",
                table: "FavoritePosts",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_Follows_FolloweeId",
                table: "Follows",
                column: "FolloweeId");

            migrationBuilder.CreateIndex(
                name: "IX_PendingPosts_PostId",
                table: "PendingPosts",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "Roles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_States_CountryId",
                table: "States",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "Users",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "IX_Users_CityId",
                table: "Users",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_CountryCodeId",
                table: "Users",
                column: "CountryCodeId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_CountryId",
                table: "Users",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_StateId",
                table: "Users",
                column: "StateId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_ZipCodeId",
                table: "Users",
                column: "ZipCodeId");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "Users",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_UsersRoles_RoleId",
                table: "UsersRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_WebsiteActions_OwnerId",
                table: "WebsiteActions",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_WebsiteActions_ReceiverId",
                table: "WebsiteActions",
                column: "ReceiverId");

            migrationBuilder.CreateIndex(
                name: "IX_WebsiteImages_OwnerId",
                table: "WebsiteImages",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_ZipCodes_CityId",
                table: "ZipCodes",
                column: "CityId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "BlockedPosts");

            migrationBuilder.DropTable(
                name: "BlogComments");

            migrationBuilder.DropTable(
                name: "BlogPostLikes");

            migrationBuilder.DropTable(
                name: "BlogPostsTags");

            migrationBuilder.DropTable(
                name: "ChangeProfileCoverImageActions");

            migrationBuilder.DropTable(
                name: "ChangeProfileImageActions");

            migrationBuilder.DropTable(
                name: "CreatedPostActions");

            migrationBuilder.DropTable(
                name: "CreatePostActions");

            migrationBuilder.DropTable(
                name: "DeletedPostActions");

            migrationBuilder.DropTable(
                name: "DeleteOwnPostActions");

            migrationBuilder.DropTable(
                name: "DeletePostActions");

            migrationBuilder.DropTable(
                name: "EditedPostActions");

            migrationBuilder.DropTable(
                name: "EditOwnPostActions");

            migrationBuilder.DropTable(
                name: "EditPersonalDataActions");

            migrationBuilder.DropTable(
                name: "EditPostActions");

            migrationBuilder.DropTable(
                name: "FavoritePosts");

            migrationBuilder.DropTable(
                name: "Follows");

            migrationBuilder.DropTable(
                name: "LikedPostActions");

            migrationBuilder.DropTable(
                name: "LikeOwnPostActions");

            migrationBuilder.DropTable(
                name: "LikePostActions");

            migrationBuilder.DropTable(
                name: "PendingPosts");

            migrationBuilder.DropTable(
                name: "PostCoverImages");

            migrationBuilder.DropTable(
                name: "PostImages");

            migrationBuilder.DropTable(
                name: "UnlikedPostActions");

            migrationBuilder.DropTable(
                name: "UnlikeOwnPostActions");

            migrationBuilder.DropTable(
                name: "UnlikePostActions");

            migrationBuilder.DropTable(
                name: "UsersRoles");

            migrationBuilder.DropTable(
                name: "BlogTags");

            migrationBuilder.DropTable(
                name: "UserCoverImages");

            migrationBuilder.DropTable(
                name: "UserProfileImages");

            migrationBuilder.DropTable(
                name: "BasePostImages");

            migrationBuilder.DropTable(
                name: "BasePostActions");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "WebsiteImages");

            migrationBuilder.DropTable(
                name: "BlogPosts");

            migrationBuilder.DropTable(
                name: "WebsiteActions");

            migrationBuilder.DropTable(
                name: "BlogCategories");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "ZipCodes");

            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "States");

            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropTable(
                name: "CountryCodes");

            migrationBuilder.DropTable(
                name: "BaseData");
        }
    }
}