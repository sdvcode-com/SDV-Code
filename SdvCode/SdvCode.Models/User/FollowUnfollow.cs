// <copyright file="FollowUnfollow.cs" company="SDV Code Data Models">
// Copyright (c) SDV Code Data Models. All rights reserved.
// </copyright>

namespace SdvCode.Models.User
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class FollowUnfollow
    {
        [Required]
        [ForeignKey(nameof(User))]
        public string FollowerId { get; set; }

        public User Follower { get; set; }

        [Required]
        [ForeignKey(nameof(User))]
        public string FollowedId { get; set; }

        public User Followed { get; set; }
    }
}