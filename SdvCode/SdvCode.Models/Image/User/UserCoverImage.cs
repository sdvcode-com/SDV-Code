// <copyright file="UserCoverImage.cs" company="SDV Code Data Models">
// Copyright (c) SDV Code Data Models. All rights reserved.
// </copyright>

namespace SdvCode.Models.Image.User
{
    using SdvCode.Models.Enums;
    using SdvCode.Models.WebsiteActions.User;

    public class UserCoverImage : WebsiteImage
    {
        public UserCoverImage()
        {
            this.ImageType = WebsiteImageType.UserCoverImage;
            this.CloudinaryPath = $"/Users/{this.OwnerId}_{this.Owner.UserName}/CoverImages/";
            this.SystemName = $"{this.Owner.UserName}_{this.Id}";
        }

        public virtual ICollection<ChangeProfileCoverImageAction> Actions { get; set; } = new HashSet<ChangeProfileCoverImageAction>();
    }
}