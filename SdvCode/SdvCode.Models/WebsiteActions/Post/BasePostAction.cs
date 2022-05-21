﻿// <copyright file="BasePostAction.cs" company="SDV Code Data Models">
// Copyright (c) SDV Code Data Models. All rights reserved.
// </copyright>

namespace SdvCode.Models.WebsiteActions.Post
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    using SdvCode.Models.Blog;

    public abstract class BasePostAction : BaseWebsiteAction
    {
        protected BasePostAction()
        {
        }

        [Required]
        [ForeignKey(nameof(Post))]
        public string PostId { get; set; }

        public Post Post { get; set; }
    }
}