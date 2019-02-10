using System;

namespace GPIB.Models
{
    public abstract class BaseUserEntity
    {
        public int ID { get; set; }

        public Guid UserID { get; set; }
    }
}