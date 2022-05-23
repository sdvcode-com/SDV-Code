// <copyright file="Action.cs" company="SDV Code Data Models">
// Copyright (c) SDV Code Data Models. All rights reserved.
// </copyright>

namespace SdvCode.Models.Actions
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Mvc;

    using SdvCode.Models.Enums;

    public abstract class Action : BaseData
    {
        protected Action()
        {
            this.ActionStatus = WebsiteActionStatus.Unread;
        }

        [Required]
        [EnumDataType(typeof(WebsiteActionType))]
        public WebsiteActionType ActionType { get; set; }

        [Required]
        [EnumDataType(typeof(WebsiteActionStatus))]
        public WebsiteActionStatus ActionStatus { get; set; }

        public virtual ICollection<UserAction> UsersActions { get; set; } = new HashSet<UserAction>();
    }
}