using System;

namespace Events
{
    class Program
    {
        
        static void Main(string[] args)
        {
            User user1 = new User();
            user1.Name = "Bob";
            User user = new User();
            user.Name = "Johny";
            user.OnRecive += ReciveMessage;
            user1.SendMessage(user, "Hello");

            


            #region OldProgram
            //user._myEvent += DoSomething;
            //user.WriteToConsoleRed("Hello Boris");
            //user.doSomething();
            //user.doSomething -= DoSomething;
            //user.doSomething = (x) =>
            //{
            //    Console.WriteLine(x);
            //};
            //user.doSomething = (x) =>
            //{
            //    Console.WriteLine(x+"123");
            //};
            //user.doSomething = (x) =>
            //{
            //    Console.WriteLine(x+"Vasya");
            //};
            #endregion
            Console.ReadLine();

        }

        private static void ReciveMessage(object sender, UserArgs u)
        {
            Console.WriteLine($"I have message from {u.Name}. Message is \"{u.Message}\"");
        }



        //static void DoSomething(object sender, string message)
        //{
        //    var user = (User)sender;
        //    Console.WriteLine($"User with id {user.id} send message: {message}");
        //}



        public class User{
            public string Name="Nobody";
            public int id;
            public EventHandler<UserArgs> OnRecive;

            public void SendMessage(User reciver, string message)
            {
                Console.WriteLine($"{this.Name} send message to {reciver.Name}");
                if(message.Length>0)
                    reciver.OnRecive?.Invoke(this, new UserArgs() { id=this.id, Name=this.Name, Message=message});
            }


            
            #region OldCode
            //public delegate void myDelegate(string message="123");
            //public event myDelegate _myEvent;
            //public myDelegate _myDelegate;
            //public User()
            //{
            //    _myDelegate = Do;
            //    _myDelegate("privet");
            //}
            //public void Do(string a="12")
            //{
            //    Console.WriteLine(a);
            //}
            //
            //
            //
            ////public Action action { get; set; }
            ////public myDelegate doSomething;
            //public void WriteToConsoleRed(string message)
            //{
            //    _myEvent?.Invoke(this, message);
            //}
            #endregion

        }
        public class UserArgs : EventArgs
        {
            public int id;
            public string Name;
            public string Message;
        }
    }
}
