// <copyright file="BlogTag.cs" company="SDV Code Data Models">
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

    public class BlogTag : BaseData
    {
        public BlogTag()
        {
        }

        [ForeignKey(nameof(User))]
        public string? OwnerId { get; set; }

        public User Owner { get; set; }

        public virtual ICollection<BlogPostTag> PostsTags { get; set; } = new HashSet<BlogPostTag>();
    }
}