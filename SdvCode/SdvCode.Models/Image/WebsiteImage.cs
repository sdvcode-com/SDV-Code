// <copyright file="WebsiteImage.cs" company="SDV Code Data Models">
// Copyright (c) SDV Code Data Models. All rights reserved.
// </copyright>

namespace SdvCode.Models.Image
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using SdvCode.Models.Enums;
    using SdvCode.Models.User;

    public abstract class WebsiteImage : BaseData
    {
        protected WebsiteImage()
        {
        }

        [Required]
        [EnumDataType(typeof(WebsiteImageType))]
        public WebsiteImageType ImageType { get; set; }

        [Required]
        [ForeignKey(nameof(Models.User.User))]
        public string OwnerId { get; set; }

        public Models.User.User Owner { get; set; }
    }
}