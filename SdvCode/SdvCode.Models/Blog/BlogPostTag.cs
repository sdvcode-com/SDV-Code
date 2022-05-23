// <copyright file="BlogPostTag.cs" company="SDV Code Data Models">
// Copyright (c) SDV Code Data Models. All rights reserved.
// </copyright>

namespace SdvCode.Models.Blog
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class BlogPostTag
    {
        public BlogPostTag()
        {
        }

        [Required]
        [ForeignKey(nameof(Tag))]
        public string TagId { get; set; }

        public BlogTag Tag { get; set; }

        [Required]
        [ForeignKey(nameof(BlogPost))]
        public string PostId { get; set; }

        public BlogPost Post { get; set; }
    }
}