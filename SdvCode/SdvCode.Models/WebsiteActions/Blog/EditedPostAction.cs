// <copyright file="EditedPostAction.cs" company="SDV Code Data Models">
// Copyright (c) SDV Code Data Models. All rights reserved.
// </copyright>

namespace SdvCode.Models.WebsiteActions.Blog
{
    using SdvCode.Models.Enums;

    public class EditedPostAction : BasePostAction
    {
        public EditedPostAction()
        {
            this.ActionType = WebsiteActionType.EditedPost;
        }
    }
}