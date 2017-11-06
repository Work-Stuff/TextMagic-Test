using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextMagic_Test.Requests
{
    /// <summary>
    /// Request to get all outbound messages sent by the current user
    /// </summary>
    public class GetAllMessagesRequest : IRequest
    {
        /// <summary>
        /// The URL of the API call
        /// </summary>
        private readonly string url = @"/api/v2/messages";

        /// <summary>
        /// The Status of the API call
        /// </summary>
        private RequestStatus status = RequestStatus.Processing;

        /// <summary>
        /// The HTTP method used by this API call
        /// </summary>
        private readonly RequestMethod method = RequestMethod.GET;

        /// <summary>
        /// The page of results to send back i.e each page contains 50 results default is 1
        /// </summary>
        private readonly string page;

        /// <summary>
        /// The number of results to send back default is 10
        /// </summary>
        private readonly string limit;

        /// <summary>
        /// The ID of the last message to send back default is 0
        /// </summary>
        private readonly string lastId;
        /// <summary>
        /// Constructs a GetAllMessagesRequest
        /// </summary>
        /// <param name="page">The page of results to send back i.e each page contains 50 results default is 1</param>
        /// <param name="limit">The number of results to send back default is 10</param>
        /// <param name="lastId">The ID of the last message to send back default is 0</param>
        public GetAllMessagesRequest(string page = "1", string limit = "10", string lastId = "0")
        {
            int temp;
            if (!int.TryParse(page, out temp) || temp < 1)
                throw new InvalidOperationException("Page must be a positive integer");
            this.page = page;
            if (!int.TryParse(limit, out temp) || temp < 1)
                throw new InvalidOperationException("Limit must be a positive integer");
            this.limit = limit;
            if (!int.TryParse(lastId, out temp) || temp < 0)
                throw new InvalidOperationException("LastID must be a positive integer or zero");
            this.lastId = lastId;
        }

        /// <summary>
        /// The URL of the API call
        /// </summary>
        public string URL => url;

        /// <summary>
        /// The Status of the API call
        /// </summary>
        public RequestStatus Status { get => status; set => status = value; }

        /// <summary>
        /// The HTTP method used by this API call
        /// </summary>
        public RequestMethod Method => method;

        /// <summary>
        /// The page of results to send back i.e each page contains 50 results default is 1
        /// </summary>
        public string Page => page;

        /// <summary>
        /// The number of results to send back default is 10
        /// </summary>
        public string Limit => limit;

        /// <summary>
        /// The ID of the last message to send back default is 0
        /// </summary>
        public string LastID => lastId;
    }
}
