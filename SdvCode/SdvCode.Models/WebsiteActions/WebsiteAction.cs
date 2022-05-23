// <copyright file="WebsiteAction.cs" company="SDV Code Data Models">
// Copyright (c) SDV Code Data Models. All rights reserved.
// </copyright>

namespace SdvCode.Models.WebsiteActions
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    using SdvCode.Models.Enums;
    using SdvCode.Models.User;

    public abstract class WebsiteAction : BaseData
    {
        protected WebsiteAction()
        {
            this.ActionStatus = WebsiteActionStatus.Unread;
        }

        [Required]
        [EnumDataType(typeof(WebsiteActionType))]
        public WebsiteActionType ActionType { get; set; }

        [Required]
        [EnumDataType(typeof(WebsiteActionStatus))]
        public WebsiteActionStatus ActionStatus { get; set; }

        [Required]
        [ForeignKey(nameof(User))]
        public string OwnerId { get; set; }

        public User Owner { get; set; }

        [Required]
        [ForeignKey(nameof(User))]
        public string ReceiverId { get; set; }

        public User Receiver { get; set; }
    }
}