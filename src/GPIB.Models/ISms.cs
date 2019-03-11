using System;

namespace GPIB.Models
{
    public interface ISms
    {
        int ID { get; set; }

        Guid UserID { get; set; }

        DateTime Expires { get; set; }

        string Message { get; set; }

        DateTime Sent { get; set; }
    }
}