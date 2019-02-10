using System;

namespace GPIB.Models
{
    public class Friends : BaseUserEntity
    {
        public String FriendsEmail { get; set; }

        public Int32 PromotionID { get; set; }
    }
}
