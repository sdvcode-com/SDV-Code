// <copyright file="BlogPostTag.cs" company="SDV Code Data Models">
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

    public class BlogPostTag
    {
        public BlogPostTag()
        {
        }

        [Required]
        [ForeignKey(nameof(BlogTag))]
        public string BlogTagId { get; set; }

        public BlogTag BlogTag { get; set; }

        [Required]
        [ForeignKey(nameof(Blog.BlogPost))]
        public string BlogPostId { get; set; }

        public BlogPost BlogPost { get; set; }
    }
}