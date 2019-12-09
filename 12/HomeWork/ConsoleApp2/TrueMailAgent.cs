using System;
using System.Collections.Generic;
using System.Text;

namespace MailAgent
{
    class TrueMailAgent
    {
        public EventHandler<MailArgs> OnRecive;
        public EventHandler<MailArgs> OnSend;

        public void SendMessage(User sender, User recipient, string message)
        {
            if (message.Length > 0)
            {
                MailArgs args = new MailArgs() { sender = sender, recipient = recipient, message = message, sendTime = DateTime.Now };
                recipient.Agent.OnRecive?.Invoke(recipient.Agent, args);
                sender.Agent.OnSend?.Invoke(sender.Agent, args);
            }
        }
        public static void MessageOnRecive(object mailAgent, MailArgs m)
        {
            Console.WriteLine($"{m.recipient.Name} : I have message from {m.sender.Name}. Message is \"{m.message}\"");
        }

        public static void MessageOnSand(object mailAgent, MailArgs m)
        {
            Console.WriteLine($"{m.sender.Name} : I sent message on {String.Format("{0:dd-MM-yyyy hh:mm:ss}", m.sendTime)}");
        }

        public class MailArgs : EventArgs
        {
            public User sender;
            public User recipient;
            public string message;
            public DateTime sendTime;

        }
    }
}
