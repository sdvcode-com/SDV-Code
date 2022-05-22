// <copyright file="PostCoverImage.cs" company="SDV Code Data Models">
// Copyright (c) SDV Code Data Models. All rights reserved.
// </copyright>

namespace SdvCode.Models.Image.Post
{
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