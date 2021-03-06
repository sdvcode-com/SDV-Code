// <copyright file="User.cs" company="SDV Code Data Models">
// Copyright (c) SDV Code Data Models. All rights reserved.
// </copyright>

namespace SdvCode.Models.User
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    using Microsoft.AspNetCore.Identity;

    using SdvCode.Constraints;
    using SdvCode.Models.Blog;
    using SdvCode.Models.Image;
    using SdvCode.Models.UserInformation;
    using SdvCode.Models.WebsiteActions;

    public class User : IdentityUser
    {
        public User()
        {
            this.IsBlocked = false;
            this.RegisteredOn = DateTime.UtcNow;
        }

        [Required]
        public DateTime RegisteredOn { get; set; }

        public DateTime? UpdatedOn { get; set; }

        [MaxLength(DataModelConstants.UserNamesMaxLength)]
        public string? FirstName { get; set; }

        [MaxLength(DataModelConstants.UserNamesMaxLength)]
        public string? MiddleName { get; set; }

        [MaxLength(DataModelConstants.UserNamesMaxLength)]
        public string? LastName { get; set; }

        public DateTime? BirthDate { get; set; }

        [MaxLength(DataModelConstants.UserAboutMeMaxLength)]
        public string? AboutMe { get; set; }

        public string? ImageUrl { get; set; }

        public string? CoverImageUrl { get; set; }

        [MaxLength(DataModelConstants.UserSocialMediaLinkMaxLength)]
        public string? GitHubUrl { get; set; }

        [MaxLength(DataModelConstants.UserSocialMediaLinkMaxLength)]
        public string? StackoverflowUrl { get; set; }

        [MaxLength(DataModelConstants.UserSocialMediaLinkMaxLength)]
        public string? FacebookUrl { get; set; }

        [MaxLength(DataModelConstants.UserSocialMediaLinkMaxLength)]
        public string? LinkedinUrl { get; set; }

        [MaxLength(DataModelConstants.UserSocialMediaLinkMaxLength)]
        public string? TwitterUrl { get; set; }

        [MaxLength(DataModelConstants.UserSocialMediaLinkMaxLength)]
        public string? InstagramUrl { get; set; }

        [Required]
        public bool IsBlocked { get; set; }

        [MaxLength(DataModelConstants.UserReasonToBeBlockedMaxLength)]
        public string? ReasonToBeBlocked { get; set; }

        [ForeignKey(nameof(ZipCode))]
        public string? ZipCodeId { get; set; }

        public virtual ZipCode ZipCode { get; set; }

        [ForeignKey(nameof(Country))]
        public string? CountryId { get; set; }

        public virtual Country Country { get; set; }

        [ForeignKey(nameof(State))]
        public string? StateId { get; set; }

        public virtual State State { get; set; }

        [ForeignKey(nameof(City))]
        public string? CityId { get; set; }

        public virtual City City { get; set; }

        [ForeignKey(nameof(CountryCode))]
        public string? CountryCodeId { get; set; }

        public virtual CountryCode CountryCode { get; set; }

        public virtual ICollection<UserRole> UserRoles { get; set; } = new HashSet<UserRole>();

        public virtual ICollection<BlogPost> Posts { get; set; } = new HashSet<BlogPost>();

        public virtual ICollection<BlogCategory> BlogCategories { get; set; } = new HashSet<BlogCategory>();

        public virtual ICollection<BlogTag> BlogTags { get; set; } = new HashSet<BlogTag>();

        public virtual ICollection<BlogComment> BlogComments { get; set; } = new HashSet<BlogComment>();

        public virtual ICollection<WebsiteAction> UserActions { get; set; } = new HashSet<WebsiteAction>();

        public virtual ICollection<WebsiteAction> ReceivedActions { get; set; } = new HashSet<WebsiteAction>();

        public virtual ICollection<WebsiteImage> WebsiteImages { get; set; } = new HashSet<WebsiteImage>();

        public virtual ICollection<Follow> Followers { get; set; } = new HashSet<Follow>();

        public virtual ICollection<Follow> Followees { get; set; } = new HashSet<Follow>();

        public virtual ICollection<BlockedPost> BlockedPosts { get; set; } = new HashSet<BlockedPost>();

        public virtual ICollection<PendingPost> PendingPosts { get; set; } = new HashSet<PendingPost>();

        public virtual ICollection<FavoritePost> FavoritePosts { get; set; } = new HashSet<FavoritePost>();
    }
}