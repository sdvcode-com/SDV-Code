// <copyright file="CreatePostAction.cs" company="SDV Code Data Models">
// Copyright (c) SDV Code Data Models. All rights reserved.
// </copyright>

namespace SdvCode.Models.WebsiteActions.Blog
{
    using SdvCode.Models.Enums;

    public class CreatePostAction : BasePostAction
    {
        public CreatePostAction()
        {
            this.ActionType = WebsiteActionType.CreatePost;
        }
    }
}