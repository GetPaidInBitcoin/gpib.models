﻿using System;
using System.ComponentModel.DataAnnotations;

namespace GPIB.Models
{
    [Obsolete]
    public class Friends : BaseUserEntity, IUserEntity
    {
        [Required]
        public String FriendsEmail { get; set; }

        [Required]
        public Int32 PromotionID { get; set; }
    }
}