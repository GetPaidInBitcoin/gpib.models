using System;

namespace GPIB.Models
{
    public interface ISms : IUserEntity
    {
        DateTime Expires { get; set; }

        string Message { get; set; }

        DateTime Sent { get; set; }
    }
}