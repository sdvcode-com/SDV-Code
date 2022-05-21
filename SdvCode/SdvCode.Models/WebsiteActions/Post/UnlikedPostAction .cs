// <copyright file="UnlikedPostAction .cs" company="SDV Code Data Models">
// Copyright (c) SDV Code Data Models. All rights reserved.
// </copyright>

namespace SdvCode.Models.WebsiteActions.Post
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    using SdvCode.Models.Enums;
    using SdvCode.Models.User;

    public class UnlikedPostAction : BasePostAction
    {
        public UnlikedPostAction()
        {
            this.ActionType = WebsiteActionType.UnlikedPost;
        }

        [Required]
        [ForeignKey(nameof(User))]
        public string UnlikerId { get; set; }

        public User Unliker { get; set; }
    }
}