// <copyright file="UnfollowAction.cs" company="SDV Code Data Models">
// Copyright (c) SDV Code Data Models. All rights reserved.
// </copyright>

namespace SdvCode.Models.WebsiteActions.User
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using SdvCode.Models.Enums;

    public class UnfollowAction : WebsiteAction
    {
        public UnfollowAction()
        {
            this.ActionType = WebsiteActionType.Unfollow;
        }
    }
}