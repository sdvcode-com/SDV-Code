// <copyright file="Follow.cs" company="SDV Code Data Models">
// Copyright (c) SDV Code Data Models. All rights reserved.
// </copyright>

namespace SdvCode.Models.User
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Follow
    {
        public Follow()
        {
            this.IsFollow = true;
        }

        [Required]
        [ForeignKey(nameof(User))]
        public string FollowerId { get; set; }

        public User Follower { get; set; }

        [Required]
        [ForeignKey(nameof(User))]
        public string FolloweeId { get; set; }

        public User Followee { get; set; }

        [Required]
        public bool IsFollow { get; set; }
    }
}