using System;

namespace MailAgent
{
    class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User();
            user1.Name = "Bob";
            user1.Agent = new TrueMailAgent();
            user1.Agent.OnSend += TrueMailAgent.MessageOnSand;
            user1.Agent.OnRecive += TrueMailAgent.MessageOnRecive;
            User user2 = new User();
            user2.Name = "Johny";
            user2.Agent = new TrueMailAgent();
            user2.Agent.OnSend += TrueMailAgent.MessageOnSand;
            user2.Agent.OnRecive += TrueMailAgent.MessageOnRecive;

            user1.Agent.SendMessage(user1, user2, "Это тестовое письмо");

            user2.Agent.SendMessage(user2, user1, "я его получил");

            Console.ReadKey();

         }
    }
}
