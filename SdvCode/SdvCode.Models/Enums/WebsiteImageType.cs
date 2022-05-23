// <copyright file="WebsiteImageType.cs" company="SDV Code Data Models">
// Copyright (c) SDV Code Data Models. All rights reserved.
// </copyright>

namespace SdvCode.Models.Enums
{
    using System.ComponentModel.DataAnnotations;

    public enum WebsiteImageType
    {
        [Display(Name = "Post Cover Image")]
        PostCoverImage = 1,

        [Display(Name = "Post Image")]
        PostImage = 2,

        [Display(Name = "User Profile Image")]
        UserProfileImage = 3,

        [Display(Name = "User Cover Image")]
        UserCoverImage = 4,
    }
}