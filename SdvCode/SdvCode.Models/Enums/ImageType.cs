﻿// <copyright file="ImageType.cs" company="SDV Code Data Models">
// Copyright (c) SDV Code Data Models. All rights reserved.
// </copyright>

namespace SdvCode.Models.Enums
{
    using System.ComponentModel.DataAnnotations;

    public enum ImageType
    {
        [Display(Name = "Post Cover Image")]
        PostCoverImage = 1,

        [Display(Name = "Post Image")]
        PostImage = 2,
    }
}