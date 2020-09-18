using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace GPIB.Models
{
    public class RapidID
    {
        [DatabaseGenerated (DatabaseGeneratedOption.Identity)]
        public Int32 ID { get; set; }

        public RapidIDRequestType RequestType { get; set; }

        public String RapidIDRequest { get; set; }

        public String RapidIDResponse { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime ModifiedOn { get; set; }

        public Int32 Attempt { get; set; }

        public Int32 RapidIDClientInfoId { get; set; }

        public RapidIDClientInfo RapidIDClientInfo { get; set; }
    }
}