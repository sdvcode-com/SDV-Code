﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SdvCode.Data;

#nullable disable

namespace SdvCode.Web.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20220523132900_M9")]
    partial class M9
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("SdvCode.Models.BaseData", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("SystemMessage")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<DateTime?>("UpdatedOn")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("BaseData");
                });

            modelBuilder.Entity("SdvCode.Models.Blog.BlogPostTag", b =>
                {
                    b.Property<string>("PostId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("TagId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("PostId", "TagId");

                    b.HasIndex("TagId");

                    b.ToTable("BlogPostsTags", (string)null);
                });

            modelBuilder.Entity("SdvCode.Models.User.Role", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(350)
                        .HasColumnType("nvarchar(350)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<int>("RoleLevel")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("Roles", (string)null);
                });

            modelBuilder.Entity("SdvCode.Models.User.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("AboutMe")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<DateTime?>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CityId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CountryCodeId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CountryId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CoverImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FacebookUrl")
                        .HasMaxLength(120)
                        .HasColumnType("nvarchar(120)");

                    b.Property<string>("FirstName")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("GitHubUrl")
                        .HasMaxLength(120)
                        .HasColumnType("nvarchar(120)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InstagramUrl")
                        .HasMaxLength(120)
                        .HasColumnType("nvarchar(120)");

                    b.Property<bool>("IsBlocked")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("LinkedinUrl")
                        .HasMaxLength(120)
                        .HasColumnType("nvarchar(120)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("MiddleName")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

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

                    b.Property<string>("ReasonToBeBlocked")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StackoverflowUrl")
                        .HasMaxLength(120)
                        .HasColumnType("nvarchar(120)");

                    b.Property<string>("StateId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("TwitterUrl")
                        .HasMaxLength(120)
                        .HasColumnType("nvarchar(120)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("ZipCodeId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.HasIndex("CountryCodeId");

                    b.HasIndex("CountryId");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.HasIndex("StateId");

                    b.HasIndex("ZipCodeId");

                    b.ToTable("Users", (string)null);
                });

            modelBuilder.Entity("SdvCode.Models.User.UserRole", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("UsersRoles", (string)null);
                });

            modelBuilder.Entity("SdvCode.Models.Blog.BlogCategory", b =>
                {
                    b.HasBaseType("SdvCode.Models.BaseData");

                    b.Property<string>("OwnerId")
                        .HasColumnType("nvarchar(450)");

                    b.HasIndex("OwnerId");

                    b.ToTable("BlogCategories", (string)null);
                });

            modelBuilder.Entity("SdvCode.Models.Blog.BlogComment", b =>
                {
                    b.HasBaseType("SdvCode.Models.BaseData");

                    b.Property<string>("OwnerId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ParentCommentId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("PostId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasIndex("OwnerId");

                    b.HasIndex("ParentCommentId");

                    b.HasIndex("PostId");

                    b.ToTable("BlogComments", (string)null);
                });

            modelBuilder.Entity("SdvCode.Models.Blog.BlogPost", b =>
                {
                    b.HasBaseType("SdvCode.Models.BaseData");

                    b.Property<string>("AuthorId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CategoryId")
                        .HasColumnType("nvarchar(450)");

                    b.HasIndex("AuthorId");

                    b.HasIndex("CategoryId");

                    b.ToTable("BlogPosts", (string)null);
                });

            modelBuilder.Entity("SdvCode.Models.Blog.BlogTag", b =>
                {
                    b.HasBaseType("SdvCode.Models.BaseData");

                    b.Property<string>("OwnerId")
                        .HasColumnType("nvarchar(450)");

                    b.HasIndex("OwnerId");

                    b.ToTable("BlogTags", (string)null);
                });

            modelBuilder.Entity("SdvCode.Models.UserInformation.City", b =>
                {
                    b.HasBaseType("SdvCode.Models.BaseData");

                    b.Property<string>("CountryId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("StateId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasIndex("CountryId");

                    b.HasIndex("StateId");

                    b.ToTable("Cities", (string)null);
                });

            modelBuilder.Entity("SdvCode.Models.UserInformation.Country", b =>
                {
                    b.HasBaseType("SdvCode.Models.BaseData");

                    b.Property<string>("CountryCodeId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasIndex("CountryCodeId");

                    b.ToTable("Countries", (string)null);
                });

            modelBuilder.Entity("SdvCode.Models.UserInformation.CountryCode", b =>
                {
                    b.HasBaseType("SdvCode.Models.BaseData");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(6)
                        .HasColumnType("nvarchar(6)");

                    b.ToTable("CountryCodes", (string)null);
                });

            modelBuilder.Entity("SdvCode.Models.UserInformation.State", b =>
                {
                    b.HasBaseType("SdvCode.Models.BaseData");

                    b.Property<string>("CountryId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasIndex("CountryId");

                    b.ToTable("States", (string)null);
                });

            modelBuilder.Entity("SdvCode.Models.UserInformation.ZipCode", b =>
                {
                    b.HasBaseType("SdvCode.Models.BaseData");

                    b.Property<string>("CityId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasIndex("CityId");

                    b.ToTable("ZipCodes", (string)null);
                });

            modelBuilder.Entity("SdvCode.Models.WebsiteActions.WebsiteAction", b =>
                {
                    b.HasBaseType("SdvCode.Models.BaseData");

                    b.Property<int>("ActionStatus")
                        .HasColumnType("int");

                    b.Property<int>("ActionType")
                        .HasColumnType("int");

                    b.Property<string>("OwnerId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ReceiverId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasIndex("OwnerId");

                    b.HasIndex("ReceiverId");

                    b.ToTable("WebsiteActions", (string)null);
                });

            modelBuilder.Entity("SdvCode.Models.WebsiteActions.Blog.CreatePostAction", b =>
                {
                    b.HasBaseType("SdvCode.Models.WebsiteActions.WebsiteAction");

                    b.Property<string>("PostId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasIndex("PostId");

                    b.ToTable("CreatePostActions", (string)null);
                });

            modelBuilder.Entity("SdvCode.Models.WebsiteActions.Post.LikedPostAction", b =>
                {
                    b.HasBaseType("SdvCode.Models.WebsiteActions.WebsiteAction");

                    b.Property<string>("PostId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasIndex("PostId");

                    b.ToTable("LikedPostActions", (string)null);
                });

            modelBuilder.Entity("SdvCode.Models.WebsiteActions.Post.LikeOwnPostAction", b =>
                {
                    b.HasBaseType("SdvCode.Models.WebsiteActions.WebsiteAction");

                    b.Property<string>("PostId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasIndex("PostId");

                    b.ToTable("LikeOwnPostActions", (string)null);
                });

            modelBuilder.Entity("SdvCode.Models.WebsiteActions.Post.LikePostAction", b =>
                {
                    b.HasBaseType("SdvCode.Models.WebsiteActions.WebsiteAction");

                    b.Property<string>("PostId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasIndex("PostId");

                    b.ToTable("LikePostActions", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("SdvCode.Models.User.Role", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("SdvCode.Models.User.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("SdvCode.Models.User.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("SdvCode.Models.User.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SdvCode.Models.Blog.BlogPostTag", b =>
                {
                    b.HasOne("SdvCode.Models.Blog.BlogPost", "Post")
                        .WithMany("PostsTags")
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("SdvCode.Models.Blog.BlogTag", "Tag")
                        .WithMany("PostsTags")
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Post");

                    b.Navigation("Tag");
                });

            modelBuilder.Entity("SdvCode.Models.User.User", b =>
                {
                    b.HasOne("SdvCode.Models.UserInformation.City", "City")
                        .WithMany("ApplicationUsers")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("SdvCode.Models.UserInformation.CountryCode", "CountryCode")
                        .WithMany("ApplicationUsers")
                        .HasForeignKey("CountryCodeId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("SdvCode.Models.UserInformation.Country", "Country")
                        .WithMany("ApplicationUsers")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("SdvCode.Models.UserInformation.State", "State")
                        .WithMany("ApplicationUsers")
                        .HasForeignKey("StateId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("SdvCode.Models.UserInformation.ZipCode", "ZipCode")
                        .WithMany("ApplicationUsers")
                        .HasForeignKey("ZipCodeId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("City");

                    b.Navigation("Country");

                    b.Navigation("CountryCode");

                    b.Navigation("State");

                    b.Navigation("ZipCode");
                });

            modelBuilder.Entity("SdvCode.Models.User.UserRole", b =>
                {
                    b.HasOne("SdvCode.Models.User.Role", "Role")
                        .WithMany("UsersRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SdvCode.Models.User.User", "User")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");

                    b.Navigation("User");
                });

            modelBuilder.Entity("SdvCode.Models.Blog.BlogCategory", b =>
                {
                    b.HasOne("SdvCode.Models.BaseData", null)
                        .WithOne()
                        .HasForeignKey("SdvCode.Models.Blog.BlogCategory", "Id")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();

                    b.HasOne("SdvCode.Models.User.User", "Owner")
                        .WithMany("BlogCategories")
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("Owner");
                });

            modelBuilder.Entity("SdvCode.Models.Blog.BlogComment", b =>
                {
                    b.HasOne("SdvCode.Models.BaseData", null)
                        .WithOne()
                        .HasForeignKey("SdvCode.Models.Blog.BlogComment", "Id")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();

                    b.HasOne("SdvCode.Models.User.User", "Owner")
                        .WithMany("BlogComments")
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("SdvCode.Models.Blog.BlogComment", "ParentComment")
                        .WithMany()
                        .HasForeignKey("ParentCommentId");

                    b.HasOne("SdvCode.Models.Blog.BlogPost", "Post")
                        .WithMany("Comments")
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Owner");

                    b.Navigation("ParentComment");

                    b.Navigation("Post");
                });

            modelBuilder.Entity("SdvCode.Models.Blog.BlogPost", b =>
                {
                    b.HasOne("SdvCode.Models.User.User", "Author")
                        .WithMany("Posts")
                        .HasForeignKey("AuthorId");

                    b.HasOne("SdvCode.Models.Blog.BlogCategory", "Category")
                        .WithMany("Posts")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("SdvCode.Models.BaseData", null)
                        .WithOne()
                        .HasForeignKey("SdvCode.Models.Blog.BlogPost", "Id")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();

                    b.Navigation("Author");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("SdvCode.Models.Blog.BlogTag", b =>
                {
                    b.HasOne("SdvCode.Models.BaseData", null)
                        .WithOne()
                        .HasForeignKey("SdvCode.Models.Blog.BlogTag", "Id")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();

                    b.HasOne("SdvCode.Models.User.User", "Owner")
                        .WithMany("BlogTags")
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("Owner");
                });

            modelBuilder.Entity("SdvCode.Models.UserInformation.City", b =>
                {
                    b.HasOne("SdvCode.Models.UserInformation.Country", "Country")
                        .WithMany("Cities")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("SdvCode.Models.BaseData", null)
                        .WithOne()
                        .HasForeignKey("SdvCode.Models.UserInformation.City", "Id")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();

                    b.HasOne("SdvCode.Models.UserInformation.State", "State")
                        .WithMany("Cities")
                        .HasForeignKey("StateId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Country");

                    b.Navigation("State");
                });

            modelBuilder.Entity("SdvCode.Models.UserInformation.Country", b =>
                {
                    b.HasOne("SdvCode.Models.UserInformation.CountryCode", "CountryCode")
                        .WithMany("Coutries")
                        .HasForeignKey("CountryCodeId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("SdvCode.Models.BaseData", null)
                        .WithOne()
                        .HasForeignKey("SdvCode.Models.UserInformation.Country", "Id")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();

                    b.Navigation("CountryCode");
                });

            modelBuilder.Entity("SdvCode.Models.UserInformation.CountryCode", b =>
                {
                    b.HasOne("SdvCode.Models.BaseData", null)
                        .WithOne()
                        .HasForeignKey("SdvCode.Models.UserInformation.CountryCode", "Id")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SdvCode.Models.UserInformation.State", b =>
                {
                    b.HasOne("SdvCode.Models.UserInformation.Country", "Country")
                        .WithMany("States")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SdvCode.Models.BaseData", null)
                        .WithOne()
                        .HasForeignKey("SdvCode.Models.UserInformation.State", "Id")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("SdvCode.Models.UserInformation.ZipCode", b =>
                {
                    b.HasOne("SdvCode.Models.UserInformation.City", "City")
                        .WithMany("ZipCodes")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("SdvCode.Models.BaseData", null)
                        .WithOne()
                        .HasForeignKey("SdvCode.Models.UserInformation.ZipCode", "Id")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();

                    b.Navigation("City");
                });

            modelBuilder.Entity("SdvCode.Models.WebsiteActions.WebsiteAction", b =>
                {
                    b.HasOne("SdvCode.Models.BaseData", null)
                        .WithOne()
                        .HasForeignKey("SdvCode.Models.WebsiteActions.WebsiteAction", "Id")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();

                    b.HasOne("SdvCode.Models.User.User", "Owner")
                        .WithMany("UserActions")
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("SdvCode.Models.User.User", "Receiver")
                        .WithMany("ReceivedActions")
                        .HasForeignKey("ReceiverId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Owner");

                    b.Navigation("Receiver");
                });

            modelBuilder.Entity("SdvCode.Models.WebsiteActions.Blog.CreatePostAction", b =>
                {
                    b.HasOne("SdvCode.Models.WebsiteActions.WebsiteAction", null)
                        .WithOne()
                        .HasForeignKey("SdvCode.Models.WebsiteActions.Blog.CreatePostAction", "Id")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();

                    b.HasOne("SdvCode.Models.Blog.BlogPost", "Post")
                        .WithMany("CreatePostActions")
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Post");
                });

            modelBuilder.Entity("SdvCode.Models.WebsiteActions.Post.LikedPostAction", b =>
                {
                    b.HasOne("SdvCode.Models.WebsiteActions.WebsiteAction", null)
                        .WithOne()
                        .HasForeignKey("SdvCode.Models.WebsiteActions.Post.LikedPostAction", "Id")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();

                    b.HasOne("SdvCode.Models.Blog.BlogPost", "Post")
                        .WithMany()
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Post");
                });

            modelBuilder.Entity("SdvCode.Models.WebsiteActions.Post.LikeOwnPostAction", b =>
                {
                    b.HasOne("SdvCode.Models.WebsiteActions.WebsiteAction", null)
                        .WithOne()
                        .HasForeignKey("SdvCode.Models.WebsiteActions.Post.LikeOwnPostAction", "Id")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();

                    b.HasOne("SdvCode.Models.Blog.BlogPost", "Post")
                        .WithMany()
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Post");
                });

            modelBuilder.Entity("SdvCode.Models.WebsiteActions.Post.LikePostAction", b =>
                {
                    b.HasOne("SdvCode.Models.WebsiteActions.WebsiteAction", null)
                        .WithOne()
                        .HasForeignKey("SdvCode.Models.WebsiteActions.Post.LikePostAction", "Id")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();

                    b.HasOne("SdvCode.Models.Blog.BlogPost", "Post")
                        .WithMany("LikePostActions")
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Post");
                });

            modelBuilder.Entity("SdvCode.Models.User.Role", b =>
                {
                    b.Navigation("UsersRoles");
                });

            modelBuilder.Entity("SdvCode.Models.User.User", b =>
                {
                    b.Navigation("BlogCategories");

                    b.Navigation("BlogComments");

                    b.Navigation("BlogTags");

                    b.Navigation("Posts");

                    b.Navigation("ReceivedActions");

                    b.Navigation("UserActions");

                    b.Navigation("UserRoles");
                });

            modelBuilder.Entity("SdvCode.Models.Blog.BlogCategory", b =>
                {
                    b.Navigation("Posts");
                });

            modelBuilder.Entity("SdvCode.Models.Blog.BlogPost", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("CreatePostActions");

                    b.Navigation("LikePostActions");

                    b.Navigation("PostsTags");
                });

            modelBuilder.Entity("SdvCode.Models.Blog.BlogTag", b =>
                {
                    b.Navigation("PostsTags");
                });

            modelBuilder.Entity("SdvCode.Models.UserInformation.City", b =>
                {
                    b.Navigation("ApplicationUsers");

                    b.Navigation("ZipCodes");
                });

            modelBuilder.Entity("SdvCode.Models.UserInformation.Country", b =>
                {
                    b.Navigation("ApplicationUsers");

                    b.Navigation("Cities");

                    b.Navigation("States");
                });

            modelBuilder.Entity("SdvCode.Models.UserInformation.CountryCode", b =>
                {
                    b.Navigation("ApplicationUsers");

                    b.Navigation("Coutries");
                });

            modelBuilder.Entity("SdvCode.Models.UserInformation.State", b =>
                {
                    b.Navigation("ApplicationUsers");

                    b.Navigation("Cities");
                });

            modelBuilder.Entity("SdvCode.Models.UserInformation.ZipCode", b =>
                {
                    b.Navigation("ApplicationUsers");
                });
#pragma warning restore 612, 618
        }
    }
}
