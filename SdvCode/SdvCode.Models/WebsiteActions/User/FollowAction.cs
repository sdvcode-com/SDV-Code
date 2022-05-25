// <copyright file="FollowAction.cs" company="SDV Code Data Models">
// Copyright (c) SDV Code Data Models. All rights reserved.
// </copyright>

namespace SdvCode.Models.WebsiteActions.User
{
    using SdvCode.Models.Enums;

    public class FollowAction : WebsiteAction
    {
        public FollowAction()
        {
            this.ActionType = WebsiteActionType.Follow;
        }
    }
}