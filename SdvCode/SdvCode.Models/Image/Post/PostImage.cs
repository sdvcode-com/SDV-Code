// <copyright file="PostImage.cs" company="SDV Code Data Models">
// Copyright (c) SDV Code Data Models. All rights reserved.
// </copyright>

namespace SdvCode.Models.Image.Post
{
    using SdvCode.Models.Enums;

    public class PostImage : BasePostImage
    {
        public PostImage()
        {
            this.ImageType = ImageType.PostImage;
            this.CloudinaryPath = $"/Blog/Posts/{this.PostId}/PostImages/";
            this.SystemName = $"Post_Image_{this.Id}";
        }
    }
}