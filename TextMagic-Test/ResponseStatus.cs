using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextMagic_Test
{
    /// <summary>
    /// Enum to enumerate all possible api response statuses
    /// </summary>
    [Flags]
    public enum ResponseStatus
    {
        _200 = 1 << 0,
        _404 = 1 << 1,
        _500 = 1 << 2,
        _403 = 1 << 3,
        _400 = 1 << 4,
        _206 = 1 << 5,
    }
}
