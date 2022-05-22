// <copyright file="BaseData.cs" company="SDV Code Data Models">
// Copyright (c) SDV Code Data Models. All rights reserved.
// </copyright>

namespace SdvCode.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    using SdvCode.Constraints;
    using SdvCode.ExtensionMethods;

    public abstract class BaseData
    {
        protected BaseData()
        {
            this.Id = Guid.NewGuid().ToString();
            this.CreatedOn = DateTime.UtcNow;
            this.SystemMessage = $"This record of type \"{this.GetType().Name.SplitCamelCase()}\" was created on {this.CreatedOn.ToLocalTime():dd-MMMM-yyyy HH:mm:ss}";
            this.IsDeleted = false;
        }

        [Key]
        [Required]
        public string Id { get; set; }

        [Required]
        public DateTime CreatedOn { get; set; }

        [Required]
        [MaxLength(DataModelConstants.SystemMessageMaxLength)]
        public string SystemMessage { get; set; }

        public DateTime? UpdatedOn { get; set; }

        public DateTime? DeletedOn { get; set; }

        public bool IsDeleted { get; set; }
    }
}