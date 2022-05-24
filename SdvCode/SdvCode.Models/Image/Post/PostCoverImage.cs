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
            this.ImageType = WebsiteImageType.PostCoverImage;
            this.CloudinaryPath = $"/Posts/{this.PostId}_{this.Owner.UserName}/CoverImages/";
            this.SystemName = $"{this.Owner.UserName}_{this.Id}";
        }
    }
}