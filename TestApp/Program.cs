using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextMagic_Test;
using TextMagic_Test.Requests;
using TextMagic_Test.Responses;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            TextMagicClient textMagicClient = new TextMagicClient(Environment.GetEnvironmentVariable("TM_API_KEY"),
                Environment.GetEnvironmentVariable("TM_USER_NAME"));
            // textMagicClient.SendMessage("Hello World");
            GetAllMessagesResponse response = textMagicClient.GetAllOutboundMessages(new GetAllMessagesRequest("1", "10"));
            for(int i = 0; i < response.Messages.Count - 1; i++)
            {
                Console.WriteLine("Message {0} Status is: {1}", i + 1, GetMessageStatus(response.Messages[i]));
            }
            Console.ReadKey();
        }

        private static string GetMessageStatus(MessageResponse message)
        {
            List<string> friendlyStrings = new List<string>()
            {
                "Acknowledged",
                "Delivered",
                "Failed",
                "Rejected",
                "Queued",
                "Enrouted",
                "Scheduled",
                "Unknown"
            };
            switch (message.Status)
            {
                case 97:
                    return friendlyStrings[0];
                case 100:
                    return friendlyStrings[1];
                case 102:
                    return friendlyStrings[2];
                case 106:
                    return friendlyStrings[3];
                case 113:
                    return friendlyStrings[4];
                case 114:
                    return friendlyStrings[5];
                case 115:
                    return friendlyStrings[6];
                case 117:
                    return friendlyStrings[0];
                default:
                    return "Unknown Message Status Returned";
            }
        }
    }
}
