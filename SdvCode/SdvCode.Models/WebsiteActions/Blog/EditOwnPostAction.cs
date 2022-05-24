﻿// <copyright file="EditOwnPostAction.cs" company="SDV Code Data Models">
// Copyright (c) SDV Code Data Models. All rights reserved.
// </copyright>

namespace SdvCode.Models.WebsiteActions.Blog
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using SdvCode.Models.Enums;

    public class EditOwnPostAction : BasePostAction
    {
        public EditOwnPostAction()
        {
            this.ActionType = WebsiteActionType.EditOwnPost;
        }
    }
}