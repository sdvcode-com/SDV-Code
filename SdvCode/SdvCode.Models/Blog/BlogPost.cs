// <copyright file="Post.cs" company="SDV Code Data Models">
// Copyright (c) SDV Code Data Models. All rights reserved.
// </copyright>

namespace SdvCode.Models.Blog
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;

    using SdvCode.Models.User;

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
    }
}