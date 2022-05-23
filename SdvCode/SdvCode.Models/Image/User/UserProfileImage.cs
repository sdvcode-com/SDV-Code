// <copyright file="UserProfileImage.cs" company="SDV Code Data Models">
// Copyright (c) SDV Code Data Models. All rights reserved.
// </copyright>

namespace SdvCode.Models.Image.User
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using SdvCode.Models.Enums;

    public class UserProfileImage : WebsiteImage
    {
        public UserProfileImage()
        {
            this.ImageType = WebsiteImageType.UserProfileImage;
        }
    }
}