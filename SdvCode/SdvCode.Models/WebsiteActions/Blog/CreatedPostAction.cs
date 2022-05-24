// <copyright file="CreatedPostAction.cs" company="SDV Code Data Models">
// Copyright (c) SDV Code Data Models. All rights reserved.
// </copyright>

namespace SdvCode.Models.WebsiteActions.Blog
{
    using SdvCode.Models.Enums;

    public class CreatedPostAction : BasePostAction
    {
        public CreatedPostAction()
        {
            this.ActionType = WebsiteActionType.CreatedPost;
        }
    }
}