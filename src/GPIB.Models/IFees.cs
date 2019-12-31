using System;

namespace GPIB.Models
{
    public interface IFees : IEntity
    {
        decimal Amount { get; set; }

        string Tx { get; set; }

        string Address { get; set; }

        string Coin { get; set; }

        DateTime Created { get; set; }
    }
}