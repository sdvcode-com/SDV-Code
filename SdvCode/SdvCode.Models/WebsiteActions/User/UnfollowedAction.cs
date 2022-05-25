// <copyright file="UnfollowedAction.cs" company="SDV Code Data Models">
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

    public class UnfollowedAction : WebsiteAction
    {
        public UnfollowedAction()
        {
            this.ActionType = WebsiteActionType.Unfollowed;
        }
    }
}