using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextmagicRest;

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

    }
}
