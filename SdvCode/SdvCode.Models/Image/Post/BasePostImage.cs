// <copyright file="BasePostImage.cs" company="SDV Code Data Models">
// Copyright (c) SDV Code Data Models. All rights reserved.
// </copyright>

namespace SdvCode.Models.Image.Post
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using SdvCode.Models.Blog;

    public abstract class BasePostImage : BaseWebsiteImage
    {
        protected BasePostImage()
        {
        }

        [Required]
        [ForeignKey(nameof(Post))]
        public string PostId { get; set; }

        public Post Post { get; set; }
    }
}