using System;

namespace GPIB.Models
{
    public interface IDeposit
    {
        DateTime Created { get; set; }
        decimal Amount { get; set; }
        string Reference { get; set; }
        Decimal? Fee { get; set; }
    }
}