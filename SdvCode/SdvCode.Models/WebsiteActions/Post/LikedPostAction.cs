﻿// <copyright file="LikedPostAction.cs" company="SDV Code Data Models">
// Copyright (c) SDV Code Data Models. All rights reserved.
// </copyright>

namespace SdvCode.Models.WebsiteActions.Post
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    using SdvCode.Models.Blog;
    using SdvCode.Models.Enums;

    public class LikedPostAction : BasePostAction
    {
        public LikedPostAction()
        {
            this.ActionType = WebsiteActionType.LikedPost;
        }
    }
}