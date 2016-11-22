using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chat;

namespace ChatClientConsole
{
    class MyChatClient
    {
        private ChatClient client;

        public MyChatClient()
        {
            client = new ChatClient();
        }
        
        public bool Login(string username, string password)
        {
            try
            {
                client.Register(username, password);
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool SendAMessage(string username, string text)
        {
            try
            {
                client.SendMessage(username, text);
            }
            catch
            {
                return false;
            }
            return true;
        }

        public string[] Messages()
        {
            string[] names = client.GetAllMessages().Select(m => m.From).ToArray();
            return names;
        }

        public string[] UserMessages(string username)
        {
            string[] messages; 
            messages = client.GetAllMessages().Where(a => a.From == username).Select(t => t.Text).ToArray();
            return messages;
        }
    }
}
