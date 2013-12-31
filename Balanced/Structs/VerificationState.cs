﻿using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Balanced.Structs
{
    [DataContract]
    public enum VerificationState
    {
        [JsonProperty("unknown")]
        Unknown = 0,

        [JsonProperty("pending")]
        Pending = 1,
        
        [JsonProperty("failed")]
        Failed = 2,
        
        [JsonProperty("verified")]
        Verified = 3,

        [JsonProperty("deposit_succeeded")]
        Deposit_Succeeded = 4
    }
}
