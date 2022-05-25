// <copyright file="DeletedPostAction.cs" company="SDV Code Data Models">
// Copyright (c) SDV Code Data Models. All rights reserved.
// </copyright>

namespace SdvCode.Models.WebsiteActions.Blog
{
    using System.ComponentModel.DataAnnotations;

    using SdvCode.Constraints;
    using SdvCode.Models.Enums;

    public class DeletedPostAction : BasePostAction
    {
        public DeletedPostAction()
        {
            this.ActionType = WebsiteActionType.DeletedPost;
        }

        [MaxLength(DataModelConstants.PostReasonToBeDeletedMaxLength)]
        public string? ReasonToBeDeleted { get; set; }
    }
}