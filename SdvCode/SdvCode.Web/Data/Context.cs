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
    using SdvCode.Models.User;
    using SdvCode.Models.UserInformation;
    using SdvCode.Models.WebsiteActions;
    using SdvCode.Models.WebsiteActions.Blog;
    using SdvCode.Models.WebsiteActions.Post;

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

        public DbSet<City> Cities { get; set; }

        public DbSet<Country> Countries { get; set; }

        public DbSet<CountryCode> CountryCodes { get; set; }

        public DbSet<ZipCode> ZipCodes { get; set; }

        public DbSet<State> States { get; set; }

        public DbSet<WebsiteAction> WebsiteActions { get; set; }

        public DbSet<LikePostAction> LikePostActions { get; set; }

        public DbSet<CreatePostAction> CreatePostActions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<WebsiteAction>().ToTable("WebsiteActions");

            builder.Entity<User>().ToTable("Users");
            builder.Entity<Role>().ToTable("Roles");
            builder.Entity<UserRole>().ToTable("UsersRoles");

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

            builder.Entity<LikePostAction>().ToTable("LikePostActions");
            builder.Entity<CreatePostAction>().ToTable("CreatePostActions");

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
        }
    }
}