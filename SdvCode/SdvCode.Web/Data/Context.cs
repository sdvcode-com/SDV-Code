// <copyright file="Context.cs" company="SDV Code">
// Copyright (c) SDV Code. All rights reserved.
// </copyright>

namespace SdvCode.Data
{
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;

    using SdvCode.Models;
    using SdvCode.Models.Blog;
    using SdvCode.Models.Image;
    using SdvCode.Models.Image.Post;
    using SdvCode.Models.Image.User;
    using SdvCode.Models.User;
    using SdvCode.Models.UserInformation;
    using SdvCode.Models.WebsiteActions;
    using SdvCode.Models.WebsiteActions.Blog;
    using SdvCode.Models.WebsiteActions.Post;
    using SdvCode.Models.WebsiteActions.User;

    public class Context : IdentityDbContext<User, Role, string,
        IdentityUserClaim<string>, UserRole, IdentityUserLogin<string>,
        IdentityRoleClaim<string>, IdentityUserToken<string>>
    {
        public Context(DbContextOptions<Context> options)
            : base(options)
        {
        }

        public DbSet<BaseData> BaseData { get; set; }

        public DbSet<BlogPost> BlogPosts { get; set; }

        public DbSet<BlogCategory> BlogCategories { get; set; }

        public DbSet<BlogTag> BlogTags { get; set; }

        public DbSet<BlogPostTag> BlogPostsTags { get; set; }

        public DbSet<BlogComment> BlogComments { get; set; }

        public DbSet<BlogPostLike> BlogPostLikes { get; set; }

        public DbSet<City> Cities { get; set; }

        public DbSet<Country> Countries { get; set; }

        public DbSet<CountryCode> CountryCodes { get; set; }

        public DbSet<ZipCode> ZipCodes { get; set; }

        public DbSet<State> States { get; set; }

        public DbSet<WebsiteAction> WebsiteActions { get; set; }

        public DbSet<LikePostAction> LikePostActions { get; set; }

        public DbSet<UnlikePostAction> UnlikePostActions { get; set; }

        public DbSet<LikeOwnPostAction> LikeOwnPostActions { get; set; }

        public DbSet<UnlikeOwnPostAction> UnlikeOwnPostActions { get; set; }

        public DbSet<LikedPostAction> LikedPostActions { get; set; }

        public DbSet<UnlikedPostAction> UnlikedPostActions { get; set; }

        public DbSet<AddPostToFavoriteAction> AddPostToFavoriteActions { get; set; }

        public DbSet<AddedPostToFavoriteAction> AddedPostToFavoriteActions { get; set; }

        public DbSet<CreatePostAction> CreatePostActions { get; set; }

        public DbSet<CreatedPostAction> CreatedPostActions { get; set; }

        public DbSet<EditPostAction> EditPostAction { get; set; }

        public DbSet<EditedPostAction> EditedPostActions { get; set; }

        public DbSet<EditOwnPostAction> EditOwnPostAction { get; set; }

        public DbSet<DeletePostAction> DeletePostActions { get; set; }

        public DbSet<DeletedPostAction> DeletedPostActions { get; set; }

        public DbSet<DeleteOwnPostAction> DeleteOwnPostActions { get; set; }

        public DbSet<UserProfileImage> UserProfileImages { get; set; }

        public DbSet<UserCoverImage> UserCoverImages { get; set; }

        public DbSet<PostImage> PostImages { get; set; }

        public DbSet<PostCoverImage> PostCoverImages { get; set; }

        public DbSet<EditPersonalDataAction> EditPersonalDataActions { get; set; }

        public DbSet<ChangeProfileCoverImageAction> ChangeProfileCoverImageActions { get; set; }

        public DbSet<ChangeProfileImageAction> ChangeProfileImageActions { get; set; }

        public DbSet<PendingPost> PendingPosts { get; set; }

        public DbSet<BlockedPost> BlockedPosts { get; set; }

        public DbSet<FavoritePost> FavoritePosts { get; set; }

        public DbSet<Follow> Follows { get; set; }

        public DbSet<UnfollowedAction> UnfollowedActions { get; set; }

        public DbSet<UnfollowAction> UnfollowActions { get; set; }

        public DbSet<FollowedAction> FollowedActions { get; set; }

        public DbSet<FollowAction> FollowActions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<WebsiteAction>().ToTable("WebsiteActions");
            builder.Entity<WebsiteImage>().ToTable("WebsiteImages");
            builder.Entity<BasePostImage>().ToTable("BasePostImages");
            builder.Entity<BasePostAction>().ToTable("BasePostActions");

            builder.Entity<User>().ToTable("Users");
            builder.Entity<Role>().ToTable("Roles");
            builder.Entity<UserRole>().ToTable("UsersRoles");
            builder.Entity<Follow>().ToTable("Follows");

            builder.Entity<City>().ToTable("Cities");
            builder.Entity<Country>().ToTable("Countries");
            builder.Entity<CountryCode>().ToTable("CountryCodes");
            builder.Entity<ZipCode>().ToTable("ZipCodes");
            builder.Entity<State>().ToTable("States");

            builder.Entity<BlogPost>().ToTable("BlogPosts");
            builder.Entity<BlogCategory>().ToTable("BlogCategories");
            builder.Entity<BlogTag>().ToTable("BlogTags");
            builder.Entity<BlogPostTag>().ToTable("BlogPostsTags");
            builder.Entity<BlogComment>().ToTable("BlogComments");
            builder.Entity<BlogPostLike>().ToTable("BlogPostLikes");

            builder.Entity<LikePostAction>().ToTable("LikePostActions");
            builder.Entity<UnlikePostAction>().ToTable("UnlikePostActions");
            builder.Entity<LikeOwnPostAction>().ToTable("LikeOwnPostActions");
            builder.Entity<UnlikeOwnPostAction>().ToTable("UnlikeOwnPostActions");
            builder.Entity<LikedPostAction>().ToTable("LikedPostActions");
            builder.Entity<UnlikedPostAction>().ToTable("UnlikedPostActions");

            builder.Entity<CreatePostAction>().ToTable("CreatePostActions");
            builder.Entity<CreatedPostAction>().ToTable("CreatedPostActions");
            builder.Entity<EditPostAction>().ToTable("EditPostActions");
            builder.Entity<EditedPostAction>().ToTable("EditedPostActions");
            builder.Entity<EditOwnPostAction>().ToTable("EditOwnPostActions");
            builder.Entity<DeletePostAction>().ToTable("DeletePostActions");
            builder.Entity<DeletedPostAction>().ToTable("DeletedPostActions");
            builder.Entity<DeleteOwnPostAction>().ToTable("DeleteOwnPostActions");
            builder.Entity<AddedPostToFavoriteAction>().ToTable("AddedPostToFavoriteActions");
            builder.Entity<AddPostToFavoriteAction>().ToTable("AddPostToFavoriteActions");

            builder.Entity<UserProfileImage>().ToTable("UserProfileImages");
            builder.Entity<UserCoverImage>().ToTable("UserCoverImages");

            builder.Entity<PostImage>().ToTable("PostImages");
            builder.Entity<PostCoverImage>().ToTable("PostCoverImages");

            builder.Entity<EditPersonalDataAction>().ToTable("EditPersonalDataActions");
            builder.Entity<ChangeProfileCoverImageAction>().ToTable("ChangeProfileCoverImageActions");
            builder.Entity<ChangeProfileImageAction>().ToTable("ChangeProfileImageActions");

            builder.Entity<FavoritePost>().ToTable("FavoritePosts");
            builder.Entity<PendingPost>().ToTable("PendingPosts");
            builder.Entity<BlockedPost>().ToTable("BlockedPosts");

            builder.Entity<FollowAction>().ToTable("FollowActions");
            builder.Entity<FollowedAction>().ToTable("FollowedActions");
            builder.Entity<UnfollowAction>().ToTable("UnfollowActions");
            builder.Entity<UnfollowedAction>().ToTable("UnfollowedAction");

            builder.Entity<City>(entity =>
            {
                entity.HasOne(e => e.State)
                    .WithMany(e => e.Cities)
                    .HasForeignKey(e => e.StateId)
                    .OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(e => e.Country)
                    .WithMany(e => e.Cities)
                    .HasForeignKey(e => e.CountryId)
                    .OnDelete(DeleteBehavior.Restrict);

                entity.HasMany(e => e.ZipCodes)
                    .WithOne(e => e.City)
                    .HasForeignKey(e => e.CityId)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            builder.Entity<Country>(entity =>
            {
                entity.HasOne(e => e.CountryCode)
                    .WithMany(e => e.Coutries)
                    .HasForeignKey(e => e.CountryCodeId)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            builder.Entity<User>(entity =>
            {
                entity.HasOne(e => e.ZipCode)
                    .WithMany(e => e.ApplicationUsers)
                    .HasForeignKey(e => e.ZipCodeId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .IsRequired(false);

                entity.HasOne(e => e.CountryCode)
                    .WithMany(e => e.ApplicationUsers)
                    .HasForeignKey(e => e.CountryCodeId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .IsRequired(false);

                entity.HasMany(e => e.UserRoles)
                    .WithOne(e => e.User)
                    .HasForeignKey(ur => ur.UserId)
                    .IsRequired();

                entity.HasOne(x => x.State)
                    .WithMany(x => x.ApplicationUsers)
                    .HasForeignKey(x => x.StateId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .IsRequired(false);

                entity.HasOne(x => x.City)
                    .WithMany(x => x.ApplicationUsers)
                    .HasForeignKey(x => x.CityId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .IsRequired(false);

                entity.HasOne(x => x.Country)
                    .WithMany(x => x.ApplicationUsers)
                    .HasForeignKey(x => x.CountryId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .IsRequired(false);

                entity.HasMany(x => x.BlogCategories)
                    .WithOne(x => x.Owner)
                    .HasForeignKey(x => x.OwnerId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .IsRequired(false);

                entity.HasMany(x => x.BlogTags)
                    .WithOne(x => x.Owner)
                    .HasForeignKey(x => x.OwnerId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .IsRequired(false);

                entity.HasMany(x => x.BlogComments)
                    .WithOne(x => x.Owner)
                    .HasForeignKey(x => x.OwnerId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .IsRequired(false);
            });

            builder.Entity<Role>(entity =>
            {
                entity.HasMany(e => e.UsersRoles)
                    .WithOne(e => e.Role)
                    .HasForeignKey(ur => ur.RoleId)
                    .IsRequired();
            });

            builder.Entity<BlogPost>(entity =>
            {
                entity.HasOne(x => x.Category)
                    .WithMany(x => x.Posts)
                    .HasForeignKey(x => x.CategoryId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .IsRequired(false);

                entity.HasMany(x => x.PostsTags)
                    .WithOne(x => x.Post)
                    .HasForeignKey(x => x.PostId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .IsRequired(true);

                entity.HasMany(e => e.Comments)
                    .WithOne(e => e.Post)
                    .HasForeignKey(e => e.PostId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .IsRequired(true);
            });

            builder.Entity<BlogTag>(entity =>
            {
                entity.HasMany(x => x.PostsTags)
                    .WithOne(x => x.Tag)
                    .HasForeignKey(x => x.TagId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .IsRequired(true);
            });

            builder.Entity<BlogPostTag>(entity =>
            {
                entity.HasKey(x => new { x.PostId, x.TagId });
            });

            builder.Entity<WebsiteAction>(entity =>
            {
                entity.HasOne(x => x.Owner)
                    .WithMany(x => x.UserActions)
                    .HasForeignKey(x => x.OwnerId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .IsRequired(true);

                entity.HasOne(x => x.Receiver)
                    .WithMany(x => x.ReceivedActions)
                    .HasForeignKey(x => x.ReceiverId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .IsRequired(true);
            });

            builder.Entity<Follow>(entity =>
            {
                entity.HasKey(k => new { k.FollowerId, k.FolloweeId });

                entity.HasOne(u => u.Followee)
                    .WithMany(u => u.Followers)
                    .HasForeignKey(u => u.FollowerId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .IsRequired(true);

                entity.HasOne(u => u.Follower)
                    .WithMany(u => u.Followees)
                    .HasForeignKey(u => u.FolloweeId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .IsRequired(true);
            });

            builder.Entity<BlockedPost>(entity =>
            {
                entity.HasKey(x => new { x.UserId, x.PostId });
            });

            builder.Entity<PendingPost>(entity =>
            {
                entity.HasKey(x => new { x.UserId, x.PostId });
            });

            builder.Entity<FavoritePost>(entity =>
            {
                entity.HasKey(x => new { x.UserId, x.PostId });
            });

            builder.Entity<BlogPostLike>(entity =>
            {
                entity.HasKey(x => new { x.UserId, x.PostId });
            });
        }
    }
}