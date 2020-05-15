using System;

namespace GPIB.Models
{
    public interface IThirdPartyEntity : IEntity
    {
        Guid thirdPartyID { get; set; }
    }
}