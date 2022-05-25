// <copyright file="BlogPostLike.cs" company="SDV Code Data Models">
// Copyright (c) SDV Code Data Models. All rights reserved.
// </copyright>

namespace SdvCode.Models.Blog
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    using SdvCode.Models.User;

    public class BlogPostLike
    {
        public BlogPostLike()
        {
            this.IsLiked = true;
        }

        [Required]
        [ForeignKey(nameof(Models.User.User))]
        public string UserId { get; set; }

        public User User { get; set; }

        [Required]
        [ForeignKey(nameof(BlogPost))]
        public string PostId { get; set; }

        public BlogPost Post { get; set; }

        [Required]
        public bool IsLiked { get; set; }
    }
}