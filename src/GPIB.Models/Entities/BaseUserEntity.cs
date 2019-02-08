using System;

namespace GPIB.Repository
{
    public abstract class BaseUserEntity
    {
        public int ID { get; set; }

        public Guid UserID { get; set; }
    }
}