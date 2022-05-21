// <copyright file="Post.cs" company="SDV Code Data Models">
// Copyright (c) SDV Code Data Models. All rights reserved.
// </copyright>

namespace SdvCode.Models.Blog
{
    using System.Collections.Generic;

    using SdvCode.Models.Image.Post;
    using SdvCode.Models.WebsiteActions.Post;

    public class Post : BaseData
    {
        public Post()
        {
        }

        public virtual ICollection<PostCoverImage> CoverImages { get; set; } = new HashSet<PostCoverImage>();

        public virtual ICollection<PostImage> PostImages { get; set; } = new HashSet<PostImage>();

        public virtual ICollection<LikedPostAction> LikedPostActions { get; set; } = new HashSet<LikedPostAction>();

        public virtual ICollection<LikeOwnPostAction> LikeOwnPostAction { get; set; } = new HashSet<LikeOwnPostAction>();

        public virtual ICollection<LikePostAction> LikePostAction { get; set; } = new HashSet<LikePostAction>();

        public virtual ICollection<UnlikedPostAction> UnlikedPostActions { get; set; } = new HashSet<UnlikedPostAction>();

        public virtual ICollection<UnlikeOwnPostAction> UnlikeOwnPostActions { get; set; } = new HashSet<UnlikeOwnPostAction>();

        public virtual ICollection<UnlikePostAction> UnlikePostActions { get; set; } = new HashSet<UnlikePostAction>();
    }
}