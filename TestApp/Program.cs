using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextMagic_Test;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            TextMagicClient textMagicClient = new TextMagicClient(Environment.GetEnvironmentVariable("TM_API_KEY"),
                Environment.GetEnvironmentVariable("TM_USER_NAME"));
            textMagicClient.SendMessage("Hello World");
            Console.ReadKey();
        }
    }
}
