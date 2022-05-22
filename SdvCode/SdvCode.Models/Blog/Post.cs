// <copyright file="Post.cs" company="SDV Code Data Models">
// Copyright (c) SDV Code Data Models. All rights reserved.
// </copyright>

namespace SdvCode.Models.Blog
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;

    using SdvCode.Models.Image.Post;
    using SdvCode.Models.User;
    using SdvCode.Models.WebsiteActions.Post;

    public class Post : BaseData
    {
        public Post()
        {
        }

        [ForeignKey(nameof(User))]
        public string? AuthorId { get; set; }

        public User Author { get; set; }

        public virtual ICollection<BasePostImage> PostImages { get; set; } = new HashSet<BasePostImage>();

        [NotMapped]
        public virtual ICollection<PostCoverImage> CoverImages { get; set; } = new HashSet<PostCoverImage>();

        [NotMapped]
        public virtual ICollection<PostImage> Images { get; set; } = new HashSet<PostImage>();

        public virtual ICollection<BasePostAction> PostActions { get; set; } = new HashSet<BasePostAction>();

        [NotMapped]
        public virtual ICollection<LikedPostAction> LikedPostActions { get; set; } = new HashSet<LikedPostAction>();

        [NotMapped]
        public virtual ICollection<LikeOwnPostAction> LikeOwnPostActions { get; set; } = new HashSet<LikeOwnPostAction>();

        [NotMapped]
        public virtual ICollection<LikePostAction> LikePostActions { get; set; } = new HashSet<LikePostAction>();

        [NotMapped]
        public virtual ICollection<UnlikedPostAction> UnlikedPostActions { get; set; } = new HashSet<UnlikedPostAction>();

        [NotMapped]
        public virtual ICollection<UnlikeOwnPostAction> UnlikeOwnPostActions { get; set; } = new HashSet<UnlikeOwnPostAction>();

        [NotMapped]
        public virtual ICollection<UnlikePostAction> UnlikePostActions { get; set; } = new HashSet<UnlikePostAction>();
    }
}