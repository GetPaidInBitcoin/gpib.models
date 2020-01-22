using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GPIB.Models
{
    public interface IDeposit : IUserEntity
    {
        [DatabaseGenerated (DatabaseGeneratedOption.Identity)]
        DateTime Created { get; set; }

        decimal Amount { get; set; }

        string Reference { get; set; }

        Decimal? Fee { get; set; }
    }
}