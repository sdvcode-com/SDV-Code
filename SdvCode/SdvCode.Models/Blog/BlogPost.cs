// <copyright file="BlogPost.cs" company="SDV Code Data Models">
// Copyright (c) SDV Code Data Models. All rights reserved.
// </copyright>

namespace SdvCode.Models.Blog
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;

    using SdvCode.Models.User;
    using SdvCode.Models.WebsiteActions.Blog;
    using SdvCode.Models.WebsiteActions.Post;

    public class BlogPost : BaseData
    {
        public BlogPost()
        {
        }

        [ForeignKey(nameof(User))]
        public string? AuthorId { get; set; }

        public User Author { get; set; }

        [ForeignKey(nameof(BlogCategory))]
        public string? CategoryId { get; set; }

        public BlogCategory Category { get; set; }

        public virtual ICollection<BlogPostTag> PostsTags { get; set; } = new HashSet<BlogPostTag>();

        public virtual ICollection<BlogComment> Comments { get; set; } = new HashSet<BlogComment>();

        public virtual ICollection<LikePostAction> LikePostActions { get; set; } = new HashSet<LikePostAction>();

        public virtual ICollection<UnlikePostAction> UnlikePostActions { get; set; } = new HashSet<UnlikePostAction>();

        public virtual ICollection<LikeOwnPostAction> LikeOwnPostActions { get; set; } = new HashSet<LikeOwnPostAction>();

        public virtual ICollection<UnlikeOwnPostAction> UnlikeOwnPostActions { get; set; } = new HashSet<UnlikeOwnPostAction>();

        public virtual ICollection<LikedPostAction> LikedPostActions { get; set; } = new HashSet<LikedPostAction>();

        public virtual ICollection<UnlikedPostAction> UnlikedPostActions { get; set; } = new HashSet<UnlikedPostAction>();

        public virtual ICollection<CreatePostAction> CreatePostActions { get; set; } = new HashSet<CreatePostAction>();

        public virtual ICollection<CreatedPostAction> CreatedPostActions { get; set; } = new HashSet<CreatedPostAction>();
    }
}