// <copyright file="LikedPostAction.cs" company="SDV Code Data Models">
// Copyright (c) SDV Code Data Models. All rights reserved.
// </copyright>

namespace SdvCode.Models.WebsiteActions.Post
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    using SdvCode.Models.Enums;
    using SdvCode.Models.User;

    public class LikedPostAction : BasePostAction
    {
        public LikedPostAction()
        {
            this.ActionType = WebsiteActionType.LikedPost;
        }

        [Required]
        [ForeignKey(nameof(Owner))]
        public string LikerId { get; set; }

        public User Liker { get; set; }
    }
}