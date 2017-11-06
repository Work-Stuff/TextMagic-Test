using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextMagic_Test.Requests;
using TextMagic_Test.Responses;
using TextmagicRest;
using TextmagicRest.Model;

namespace TextMagic_Test
{
    public class TextMagicClient
    {
        private Client client;
        private readonly string API_KEY;
        private readonly string USER_NAME;

        public TextMagicClient(string API_KEY, string USER_NAME, string phoneNumber = "")
        {
            this.API_KEY = API_KEY;
            this.USER_NAME = USER_NAME;
            PhoneNumber = phoneNumber;
            client = new Client(USER_NAME, API_KEY);
        }

        public string PhoneNumber { get; }
        
        public void SendMessage(string text)
        {
            var link = client.SendMessage(text, PhoneNumber);

            if (link.Success)
            {
                Console.WriteLine("Message session {0} successfully sent", link.Id);
            }
            else
            {
                Console.WriteLine("Message was not sent due to following exception: " + link.ClientException.Message);
            }
        }

        public GetAllMessagesResponse GetAllOutboundMessages(GetAllMessagesRequest request)
        {
            MessagesResult res = client.GetMessages(int.Parse(request.Page), int.Parse(request.Limit));
            List<MessageResponse> messages = new List<MessageResponse>(res.Messages.Count);
            foreach (Message msg in res.Messages)
                messages.Add(new MessageResponse(msg.Id, msg.Receiver, msg.MessageTime, (int) msg.Status, msg.Text, null, msg.Charset, 
                    msg.FirstName, msg.LastName, msg.CountryId, msg.Sender, msg.Price, msg.PartsCount));
            GetAllMessagesResponse response = new GetAllMessagesResponse(res.Limit, messages, res.Page, res.PageCount, res.Success);
            response.ResponseStatus = res.Success ? ResponseStatus._200 : ResponseStatus._500;
            return response;
        }

    }
}
