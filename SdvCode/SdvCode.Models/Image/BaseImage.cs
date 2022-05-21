// <copyright file="BaseImage.cs" company="SDV Code Data Models">
// Copyright (c) SDV Code Data Models. All rights reserved.
// </copyright>

namespace SdvCode.Models.Image
{
    using System.ComponentModel.DataAnnotations;

    using SdvCode.Constraints;

    public abstract class BaseImage : BaseData
    {
        protected BaseImage()
        {
        }

        [Required]
        [MaxLength(DataModelConstants.ImageFrontNameMaxLength)]
        public string FrontName { get; set; }

        [Required]
        [MaxLength(DataModelConstants.ImageSystemNameMaxLength)]
        public string SystemName { get; set; }

        [Required]
        public string Url { get; set; }

        [Required]
        [MaxLength(DataModelConstants.ImageTypeMaxLength)]
        public string ImageType { get; set; }
    }
}