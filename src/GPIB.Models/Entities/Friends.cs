using System;

namespace GPIB.Repository
{
    public class Friends : BaseUserEntity
    {
        public String FriendsEmail { get; set; }

        public Int32 PromotionID { get; set; }
    }
}
