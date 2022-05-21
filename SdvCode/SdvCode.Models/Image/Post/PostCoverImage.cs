// <copyright file="PostCoverImage.cs" company="SDV Code Data Models">
// Copyright (c) SDV Code Data Models. All rights reserved.
// </copyright>

namespace SdvCode.Models.Image.Post
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

    public class PostCoverImage : BasePostImage
    {
        public PostCoverImage()
        {
            this.ImageType = ImageType.PostCoverImage;
            this.CloudinaryPath = $"/Blog/Posts/{this.PostId}/CoverImages/";
            this.SystemName = $"Post_Cover_Image_{this.Id}";
        }
    }
}