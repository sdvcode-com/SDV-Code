// <copyright file="UnlikePostAction.cs" company="SDV Code Data Models">
// Copyright (c) SDV Code Data Models. All rights reserved.
// </copyright>

namespace SdvCode.Models.WebsiteActions.Post
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    using SdvCode.Models.Enums;
    using SdvCode.Models.User;

    public class UnlikePostAction : BasePostAction
    {
        public UnlikePostAction()
        {
            this.ActionType = WebsiteActionType.UnlikePost;
        }

        [Required]
        [ForeignKey(nameof(User))]
        public string UnlikeeId { get; set; }

        public User Unlikee { get; set; }
    }
}