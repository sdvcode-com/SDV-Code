// <copyright file="FollowedAction.cs" company="SDV Code Data Models">
// Copyright (c) SDV Code Data Models. All rights reserved.
// </copyright>

namespace SdvCode.Models.WebsiteActions.User
{
    using SdvCode.Models.Enums;

    public class FollowedAction : WebsiteAction
    {
        public FollowedAction()
        {
            this.ActionType = WebsiteActionType.Followed;
        }
    }
}