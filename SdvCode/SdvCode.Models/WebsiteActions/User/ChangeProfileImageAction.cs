// <copyright file="ChangeProfileImageAction.cs" company="SDV Code Data Models">
// Copyright (c) SDV Code Data Models. All rights reserved.
// </copyright>

namespace SdvCode.Models.WebsiteActions.User
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    using SdvCode.Models.Enums;
    using SdvCode.Models.Image.User;

    public class ChangeProfileImageAction : WebsiteAction
    {
        public ChangeProfileImageAction()
        {
            this.ActionType = WebsiteActionType.ChangeProfileImage;
        }

        [Required]
        [ForeignKey(nameof(UserProfileImage))]
        public string UserProfileImageId { get; set; }

        public UserProfileImage Image { get; set; }
    }
}