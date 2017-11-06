using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextMagic_Test
{
    /// <summary>
    /// Enum to enumerate all possible message delivery statuses
    /// </summary>
    public enum MessageDeliveryStatus
    {
        Acked = 97,
        Delivered = 100,
        Failed = 102,
        Rejected = 106,
        Queued = 113,
        Enrouted = 114,
        Scheduled = 115,
        Unknown = 117
    }
}
