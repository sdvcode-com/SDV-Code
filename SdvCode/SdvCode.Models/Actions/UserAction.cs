// <copyright file="UserAction.cs" company="SDV Code Data Models">
// Copyright (c) SDV Code Data Models. All rights reserved.
// </copyright>

namespace SdvCode.Models.Actions
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    using SdvCode.Models.User;

    public class UserAction
    {
        [Required]
        [ForeignKey(nameof(User))]
        public string OwnerId { get; set; }

        public User Owner { get; set; }

        [Required]
        [ForeignKey(nameof(User))]
        public string ReceiverId { get; set; }

        public User Receiver { get; set; }

        [Required]
        [ForeignKey(nameof(Actions.Action))]
        public string ActionId { get; set; }

        public Action Action { get; set; }
    }
}