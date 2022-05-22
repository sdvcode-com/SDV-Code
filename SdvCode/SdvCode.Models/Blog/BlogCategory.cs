// <copyright file="PostCategory.cs" company="SDV Code Data Models">
// Copyright (c) SDV Code Data Models. All rights reserved.
// </copyright>

namespace SdvCode.Models.Blog
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using SdvCode.Models.User;

    public class BlogCategory : BaseData
    {
        public BlogCategory()
        {
        }

        [ForeignKey(nameof(User))]
        public string? OwnerId { get; set; }

        public User Owner { get; set; }

        public virtual ICollection<BlogPost> BlogPosts { get; set; } = new HashSet<BlogPost>();
    }
}