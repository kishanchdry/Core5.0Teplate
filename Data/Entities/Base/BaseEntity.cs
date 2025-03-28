﻿using Shared.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities.Base
{
    public abstract class BaseEntity
    {
        public BaseEntity()
        {
            CreatedDate = CreatedDate;
            ModifiedDate = ModifiedDate;
            IsActive = IsActive;
            IsDeleted = IsDeleted;
        }
        [Key]
        public long Id { get; set; }

        private DateTime? createDate;
        public DateTime CreatedDate
        {
            get
            {
                if (createDate == null || createDate == DateTime.MinValue)
                {
                    createDate = DateTime.UtcNow.GetLocal();
                }
                return createDate.Value;
            }
            set { createDate = value; }
        }
        private DateTime? modificationDate;
        public DateTime ModifiedDate
        {
            get
            {
                if (modificationDate == null || modificationDate == DateTime.MinValue)
                {
                    modificationDate = DateTime.UtcNow.GetLocal();
                }
                return modificationDate.Value;
            }
            set { modificationDate = value; }
        }

        private bool? isActive;
        public bool IsActive
        {
            get
            {
                if (isActive == null)
                {
                    isActive = true;
                }
                return isActive.Value;
            }
            set
            {
                isActive = value;
            }
        }

        private bool? isDeleted;
        public bool IsDeleted
        {
            get
            {
                if (isDeleted == null)
                {
                    isDeleted = false;
                }
                return isDeleted.Value;
            }
            set
            {
                isDeleted = value;
            }
        }

        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }

    }
}
