﻿// <copyright file="Post.cs" company="SDV Code Data Models">
// Copyright (c) SDV Code Data Models. All rights reserved.
// </copyright>

namespace SdvCode.Models.Blog
{
    using System.Collections.Generic;

    using SdvCode.Models.WebsiteActions.Post;

    public class Post : BaseData
    {
        public Post()
        {
        }

        public virtual ICollection<BasePostAction> PostActions { get; set; } = new HashSet<BasePostAction>();
    }
}