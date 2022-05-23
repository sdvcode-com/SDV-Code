// <copyright file="CreatedPostAction.cs" company="SDV Code Data Models">
// Copyright (c) SDV Code Data Models. All rights reserved.
// </copyright>

namespace SdvCode.Models.WebsiteActions.Blog
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    using SdvCode.Models.Blog;
    using SdvCode.Models.Enums;

    public class CreatedPostAction : WebsiteAction
    {
        public CreatedPostAction()
        {
            this.ActionType = WebsiteActionType.CreatedPost;
        }

        [Required]
        [ForeignKey(nameof(BlogPost))]
        public string PostId { get; set; }

        public BlogPost Post { get; set; }
    }
}