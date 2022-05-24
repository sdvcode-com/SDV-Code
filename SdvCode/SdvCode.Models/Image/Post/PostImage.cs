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
            this.ImageType = WebsiteImageType.PostImage;
            this.CloudinaryPath = $"/Posts/{this.PostId}_{this.Owner.UserName}/Images/";
            this.SystemName = $"{this.Owner.UserName}_{this.Id}";
        }
    }
}