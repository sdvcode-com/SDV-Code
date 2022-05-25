// <copyright file="AddPostToFavoriteAction.cs" company="SDV Code Data Models">
// Copyright (c) SDV Code Data Models. All rights reserved.
// </copyright>

namespace SdvCode.Models.WebsiteActions.Post
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using SdvCode.Models.Blog;
    using SdvCode.Models.Enums;

    public class AddPostToFavoriteAction : BasePostAction
    {
        public AddPostToFavoriteAction()
        {
            this.ActionType = WebsiteActionType.AddPostToFavorite;
        }
    }
}