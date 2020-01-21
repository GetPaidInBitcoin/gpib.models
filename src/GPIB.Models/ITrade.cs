using System;

namespace GPIB.Models {
    public interface ITrade {
        int ID { get; set; }
        String Exchange { get; set; }
        String ThirdPartyID { get; set; }
        string Type { get; set; }
        String Crypto { get; set; }
        String Fiat { get; set; }
        decimal CryptoAmount { get; set; }
        decimal Fee { get; set; }
        decimal GST { get; set; }
        decimal Rate { get; set; }
        DateTime Created { get; set; }
    }
}