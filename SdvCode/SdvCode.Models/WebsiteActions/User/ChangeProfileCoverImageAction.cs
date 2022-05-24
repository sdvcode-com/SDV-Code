// <copyright file="ChangeProfileCoverImageAction.cs" company="SDV Code Data Models">
// Copyright (c) SDV Code Data Models. All rights reserved.
// </copyright>

namespace SdvCode.Models.WebsiteActions.User
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    using SdvCode.Models.Enums;
    using SdvCode.Models.Image.User;

    public class ChangeProfileCoverImageAction : WebsiteAction
    {
        public ChangeProfileCoverImageAction()
        {
            this.ActionType = WebsiteActionType.ChangeProfileCoverImage;
        }

        [Required]
        [ForeignKey(nameof(UserCoverImage))]
        public string UserCoverImageId { get; set; }

        public UserCoverImage Image { get; set; }
    }
}