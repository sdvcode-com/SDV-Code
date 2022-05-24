// <copyright file="EditPersonalDataAction.cs" company="SDV Code Data Models">
// Copyright (c) SDV Code Data Models. All rights reserved.
// </copyright>

namespace SdvCode.Models.WebsiteActions.User
{
    using System.ComponentModel.DataAnnotations;

    using SdvCode.Constraints;
    using SdvCode.Models.Enums;

    public class EditPersonalDataAction : WebsiteAction
    {
        public EditPersonalDataAction()
        {
            this.ActionType = WebsiteActionType.EditPersonalData;
        }

        [Required]
        [MaxLength(DataModelConstants.EditPersonalDataMessageMaxLength)]
        public string Message { get; set; }
    }
}