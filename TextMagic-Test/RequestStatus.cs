using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextMagic_Test
{
    /// <summary>
    /// Enum to enumerate all possible API request statuses
    /// </summary>
    [Flags]
    public enum RequestStatus
    {
        Sucessful = 1 << 0,
        Failed = 1 << 1,
        Forbidden = 1 << 2,
        Processing = 1 << 3
    }
}
