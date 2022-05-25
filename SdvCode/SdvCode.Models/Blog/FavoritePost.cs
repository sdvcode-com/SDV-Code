// <copyright file="FavoritePost.cs" company="SDV Code Data Models">
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
    using SdvCode.Models.WebsiteActions.Post;

    public class FavoritePost
    {
        public FavoritePost()
        {
            this.IsFavorite = true;
        }

        [Required]
        [ForeignKey(nameof(BlogPost))]
        public string PostId { get; set; }

        public BlogPost Post { get; set; }

        [Required]
        [ForeignKey(nameof(Models.User.User))]
        public string UserId { get; set; }

        public User User { get; set; }

        [Required]
        public bool IsFavorite { get; set; }
    }
}