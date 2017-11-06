using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextMagic_Test.Requests
{
    /// <summary>
    /// Common fields of all TextMagic API requests
    /// </summary>
    interface IRequest
    {
        /// <summary>
        /// The URL of the API call
        /// </summary>
        string URL { get; }

        /// <summary>
        /// The Status of the API call
        /// </summary>
        RequestStatus Status { get; set; }

        /// <summary>
        /// The HTTP method used by this API call
        /// </summary>
        RequestMethod Method { get; }
    }
}
