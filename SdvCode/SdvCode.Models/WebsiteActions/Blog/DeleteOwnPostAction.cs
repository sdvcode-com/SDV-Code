// <copyright file="DeleteOwnPostAction.cs" company="SDV Code Data Models">
// Copyright (c) SDV Code Data Models. All rights reserved.
// </copyright>

namespace SdvCode.Models.WebsiteActions.Blog
{
    using System.ComponentModel.DataAnnotations;

    using SdvCode.Constraints;
    using SdvCode.Models.Enums;

    public class DeleteOwnPostAction : BasePostAction
    {
        public DeleteOwnPostAction()
        {
            this.ActionType = WebsiteActionType.DeleteOwnPost;
        }

        [MaxLength(DataModelConstants.PostReasonToBeDeletedMaxLength)]
        public string? ReasonToBeDeleted { get; set; }
    }
}