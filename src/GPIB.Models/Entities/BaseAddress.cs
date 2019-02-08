using System;
using System.Collections.Generic;

namespace GPIB.Repository
{
    public abstract class BaseAddress : BaseUserEntity
    {
        public short Percent { get; set; }

        public String Label { get; set; }

        public Boolean Deleted { get; set; }

        public ICollection<Transfer> Transfers { get; set; }
    }
}