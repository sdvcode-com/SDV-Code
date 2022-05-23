// <copyright file="WebsiteImage.cs" company="SDV Code Data Models">
// Copyright (c) SDV Code Data Models. All rights reserved.
// </copyright>

namespace SdvCode.Models.Image
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    using SdvCode.Constraints;
    using SdvCode.Models.Enums;

    public abstract class WebsiteImage : BaseData
    {
        protected WebsiteImage()
        {
        }

        [Required]
        [MaxLength(DataModelConstants.ImageFrontNameMaxLength)]
        public string Name { get; set; }

        [Required]
        [MaxLength(DataModelConstants.ImageSystemNameMaxLength)]
        public string SystemName { get; set; }

        [Required]
        [MaxLength(DataModelConstants.ImageExtensionMaxLength)]
        public string Extension { get; set; }

        [Required]
        [MaxLength(DataModelConstants.ImageCloudinaryPathMaxLength)]
        public string CloudinaryPath { get; set; }

        [Required]
        [EnumDataType(typeof(WebsiteImageType))]
        public WebsiteImageType ImageType { get; set; }

        [Required]
        [ForeignKey(nameof(Models.User.User))]
        public string OwnerId { get; set; }

        public Models.User.User Owner { get; set; }
    }
}