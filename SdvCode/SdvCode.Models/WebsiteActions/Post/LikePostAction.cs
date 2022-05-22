// <copyright file="LikePostAction.cs" company="SDV Code Data Models">
// Copyright (c) SDV Code Data Models. All rights reserved.
// </copyright>

namespace SdvCode.Models.WebsiteActions.Post
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    using SdvCode.Models.Enums;
    using SdvCode.Models.User;

    public class LikePostAction : BasePostAction
    {
        public LikePostAction()
        {
            this.ActionType = WebsiteActionType.LikePost;
        }

        [Required]
        [ForeignKey(nameof(User))]
        public string LikeeId { get; set; }

        public User Likee { get; set; }
    }
}