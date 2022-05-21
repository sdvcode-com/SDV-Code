// <copyright file="BaseImage.cs" company="SDV Code Data Models">
// Copyright (c) SDV Code Data Models. All rights reserved.
// </copyright>

namespace SdvCode.Models.Image
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    using SdvCode.Constraints;
    using SdvCode.Models.Enums;
    using SdvCode.Models.User;

    public abstract class BaseWebsiteImage : BaseData
    {
        protected BaseWebsiteImage()
        {
        }

        [Required]
        [MaxLength(DataModelConstants.ImageCloudinaryPathMaxLength)]
        public string CloudinaryPath { get; set; }

        [Required]
        [EnumDataType(typeof(ImageType))]
        public ImageType ImageType { get; set; }

        [Required]
        [MaxLength(DataModelConstants.ImageFrontNameMaxLength)]
        public string FrontName { get; set; }

        [Required]
        [MaxLength(DataModelConstants.ImageSystemNameMaxLength)]
        public string SystemName { get; set; }

        [Required]
        public string Url { get; set; }

        [Required]
        [MaxLength(DataModelConstants.ImageExtensionMaxLength)]
        public string ImageExtension { get; set; }

        [Required]
        [ForeignKey(nameof(User))]
        public string OwnerId { get; set; }

        public User Owner { get; set; }
    }
}