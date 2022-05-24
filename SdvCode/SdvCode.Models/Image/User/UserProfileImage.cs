// <copyright file="UserProfileImage.cs" company="SDV Code Data Models">
// Copyright (c) SDV Code Data Models. All rights reserved.
// </copyright>

namespace SdvCode.Models.Image.User
{
    using SdvCode.Models.Enums;
    using SdvCode.Models.WebsiteActions.User;

    public class UserProfileImage : WebsiteImage
    {
        public UserProfileImage()
        {
            this.ImageType = WebsiteImageType.UserProfileImage;
            this.CloudinaryPath = $"/Users/{this.OwnerId}_{this.Owner.UserName}/ProfileImages/";
            this.SystemName = $"{this.Owner.UserName}_{this.Id}";
        }

        public virtual ICollection<ChangeProfileImageAction> Actions { get; set; } = new HashSet<ChangeProfileImageAction>();
    }
}