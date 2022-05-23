// <copyright file="BlogComment.cs" company="SDV Code Data Models">
// Copyright (c) SDV Code Data Models. All rights reserved.
// </copyright>

namespace SdvCode.Models.Blog
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using SdvCode.Models.User;

    public class BlogComment : BaseData
    {
        public BlogComment()
        {
        }

        [ForeignKey(nameof(User))]
        public string? OwnerId { get; set; }

        public User Owner { get; set; }

        [Required]
        [ForeignKey(nameof(Blog.BlogPost))]
        public string PostId { get; set; }

        public BlogPost Post { get; set; }

        [ForeignKey(nameof(BlogComment))]
        public string? ParentCommentId { get; set; }

        public BlogComment ParentComment { get; set; }
    }
}