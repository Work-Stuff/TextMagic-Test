using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextMagic_Test.Responses
{
    /// <summary>
    /// Common fields of all TextMagic API responses
    /// </summary>
    interface IResponse
    {
        /// <summary>
        /// The status of the response
        /// </summary>
        ResponseStatus ResponseStatus { get; set; }
    }
}
