using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GPIB.Models
{
    public abstract class BaseAddress : BaseUserEntity
    {
        [Required]
        public short Percent { get; set; }

        public String Label { get; set; }

        [Required]
        public Boolean Deleted { get; set; }

        public ICollection<Transfer> Transfers { get; set; }
    }
}