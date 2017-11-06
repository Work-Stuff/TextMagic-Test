using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextMagic_Test.Responses
{
    /// <summary>
    /// Response containing all outbound messages sent by the current user
    /// </summary
    public class GetAllMessagesResponse : IResponse
    {
        /// <summary>
        /// The status of the response
        /// </summary>
        private ResponseStatus responseStatus;

        private int limit;
        private List<MessageResponse> messages;
        private int page;
        private int pageCount;
        private bool success;


        /// <summary>
        /// The status of the response
        /// </summary>
        public ResponseStatus ResponseStatus { get => responseStatus; set => responseStatus = value; }
        public int Limit { get => limit; }
        public List<MessageResponse> Messages { get => messages; }
        public int Page { get => page; }
        public int PageCount { get => pageCount; }
        public bool Success { get => success; }

        public GetAllMessagesResponse(int limit, List<MessageResponse> messages, int page, int pageCount, bool success)
        {
            this.limit = limit;
            this.messages = messages;
            this.page = page;
            this.pageCount = pageCount;
            this.success = success;
        }

    }
}
