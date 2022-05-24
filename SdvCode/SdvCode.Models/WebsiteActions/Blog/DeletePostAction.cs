// <copyright file="DeletePostAction.cs" company="SDV Code Data Models">
// Copyright (c) SDV Code Data Models. All rights reserved.
// </copyright>

namespace SdvCode.Models.WebsiteActions.Blog
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using SdvCode.Constraints;
    using SdvCode.Models.Enums;

    public class DeletePostAction : BasePostAction
    {
        public DeletePostAction()
        {
            this.ActionType = WebsiteActionType.DeletePost;
        }

        [MaxLength(DataModelConstants.PostReasonToBeDeletedMaxLength)]
        public string? ReasonToBeDeleted { get; set; }
    }
}