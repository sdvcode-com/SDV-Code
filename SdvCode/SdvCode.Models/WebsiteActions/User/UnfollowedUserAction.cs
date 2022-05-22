// <copyright file="UnfollowedUserAction.cs" company="SDV Code Data Models">
// Copyright (c) SDV Code Data Models. All rights reserved.
// </copyright>

namespace SdvCode.Models.WebsiteActions.User
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using SdvCode.Models.Enums;
    using SdvCode.Models.User;

    public class UnfollowedUserAction : BaseUserAction
    {
        public UnfollowedUserAction()
        {
            this.ActionType = WebsiteActionType.Unfollowed;
        }

        [Required]
        [ForeignKey(nameof(User))]
        public string FollowerId { get; set; }

        public User Follower { get; set; }
    }
}