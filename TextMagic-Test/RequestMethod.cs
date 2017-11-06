using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextMagic_Test
{
    /// <summary>
    /// Enum to enumerate all possible request methods
    /// </summary>
    [Flags]
    public enum RequestMethod
    {
        GET = 1 << 0,
        POST = 1 << 1,
        DELETE = 1 << 2,
    }
}
