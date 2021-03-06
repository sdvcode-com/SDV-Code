// <copyright file="UnlikedPostAction.cs" company="SDV Code Data Models">
// Copyright (c) SDV Code Data Models. All rights reserved.
// </copyright>

namespace SdvCode.Models.WebsiteActions.Post
{
    using SdvCode.Models.Enums;

    public class UnlikedPostAction : BasePostAction
    {
        public UnlikedPostAction()
        {
            this.ActionType = WebsiteActionType.UnlikedPost;
        }
    }
}