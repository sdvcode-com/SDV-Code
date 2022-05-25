﻿// <copyright file="AddedPostToFavoriteAction.cs" company="SDV Code Data Models">
// Copyright (c) SDV Code Data Models. All rights reserved.
// </copyright>

namespace SdvCode.Models.WebsiteActions.Post
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using SdvCode.Models.Enums;

    public class AddedPostToFavoriteAction : BasePostAction
    {
        public AddedPostToFavoriteAction()
        {
            this.ActionType = WebsiteActionType.AddedPostToFavorite;
        }
    }
}