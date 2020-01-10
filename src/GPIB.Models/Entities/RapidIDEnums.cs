using System;

namespace GPIB.Models
{
    public enum RapidIDPEPStatus
    {
        PEP_NOTSTARTED = 0,
        PEP_POSITIVE = 1,
        PEP_POTENTIAL_MATCH = 2,
        PEP_NOMATCH = 3,
        PEP_UNKNOWN = 4,
        PEP_ERROR = 5,
        PEP_SUCCESS = 6
    }

    public enum RapidIDSMSStatus
    {
        SMS_NOTSTARTED = 0,
        SMS_SENT = 1,
        SMS_OPENED = 2,
        SMS_REVIEW = 3,
        SMS_PASSED = 4,
        SMS_FAILED = 5,
        SMS_ERROR = 6,
        SMS_SUCCESS = 7
    }

    public enum RapidIDVerificationStatus
    {
        NotStarted = 1,
        Started = 2,
        Completed = 3
    }

    public enum RapidIDRequestType
    {
        PEP = 1,
        SendSMS = 2,
        SMSStatus = 3
    }
}
