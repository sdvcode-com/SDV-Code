// <copyright file="UnlikeOwnPostAction.cs" company="SDV Code Data Models">
// Copyright (c) SDV Code Data Models. All rights reserved.
// </copyright>

namespace SdvCode.Models.WebsiteActions.Post
{
    using SdvCode.Models.Enums;

    public class UnlikeOwnPostAction : BasePostAction
    {
        public UnlikeOwnPostAction()
        {
            this.ActionType = WebsiteActionType.UnlikeOwnPost;
        }
    }
}