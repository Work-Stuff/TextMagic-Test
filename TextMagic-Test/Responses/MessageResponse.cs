using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextMagic_Test.Responses
{
    /// <summary>
    /// Response containing an outbound message sent by the current user
    /// </summary>
    public class MessageResponse : IResponse
    {
        /// <summary>
        /// The status of the response
        /// </summary>
        private ResponseStatus responseStatus;

        private readonly int id;
        private readonly string receiver;
        private readonly DateTime messageTime;
        private readonly int status;
        private readonly string text;
        private readonly string deleted;
        private readonly string charset;
        private readonly string firstName;
        private readonly string lastName;
        private readonly string country;
        private readonly string sender;
        private readonly double price;
        private readonly int partsCount;

        public MessageResponse(int id, string receiver, DateTime messageTime, int status, string text, string deleted, string charset, 
            string firstName, string lastName, string country, string sender, double price, int partsCount)
        {
            this.id = id;
            this.receiver = receiver;
            this.messageTime = messageTime;
            this.status = status;
            this.text = text;
            this.deleted = deleted;
            this.charset = charset;
            this.firstName = firstName;
            this.lastName = lastName;
            this.country = country;
            this.sender = sender;
            this.price = price;
            this.partsCount = partsCount;
        }

        public ResponseStatus ResponseStatus { get => responseStatus; set => responseStatus = value; }

        public int Id => id;

        public string Receiver => receiver;

        public DateTime MessageTime => messageTime;

        public int Status => status;

        public string Text => text;

        public string Deleted => deleted;

        public string Charset => charset;

        public string FirstName => firstName;

        public string LastName => lastName;

        public string Country => country;

        public string Sender => sender;

        public double Price => price;

        public int PartsCount => partsCount;
    }
}
