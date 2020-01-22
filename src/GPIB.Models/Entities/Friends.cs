using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GPIB.Models
{
    public class Friends : BaseUserEntity, IUserEntity
    {
        [Required]
        public String FriendsEmail { get; set; }

        [Required]
        public Int32 PromotionID { get; set; }
    }
}