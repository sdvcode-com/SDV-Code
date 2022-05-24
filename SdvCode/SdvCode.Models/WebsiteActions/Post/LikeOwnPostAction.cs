﻿// <copyright file="LikeOwnPostAction.cs" company="SDV Code Data Models">
// Copyright (c) SDV Code Data Models. All rights reserved.
// </copyright>

namespace SdvCode.Models.WebsiteActions.Post
{
    using SdvCode.Models.Enums;

    public class LikeOwnPostAction : BasePostAction
    {
        public LikeOwnPostAction()
        {
            this.ActionType = WebsiteActionType.LikeOwnPost;
        }
    }
}