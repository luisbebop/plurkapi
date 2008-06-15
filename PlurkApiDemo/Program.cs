using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PlurkApi;

namespace PlurkApiDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            PlurkApi.PlurkApi api = new PlurkApi.PlurkApi();
            Console.WriteLine("Plurk Api Sample in C# : luisbebop@gmail.com");
            Console.Write("Enter your username: ");
            string username = Console.ReadLine();
            Console.Write("Enter your password: ");
            string password = Console.ReadLine();
            Console.WriteLine("Sign in ...");
            if (api.Login(username, password))
            {
                Console.WriteLine("Logged ...");
                PlurkMessages msgsTimeline = api.getMessages(api.uid, "", "", false);
                PlurkMessages msgsUnread = api.getUnreadMessages(false);
                Console.WriteLine("My friends: " + api.myFriends.Count.ToString());
                Console.WriteLine("Unread Messages: " + msgsUnread.Count.ToString());
                Console.WriteLine("Last 25 messages on my timeline:");
                Console.WriteLine("-----------------------------------------");
                foreach (PlurkMessage msg in msgsTimeline) 
                {
                    Console.WriteLine(api.getMessagePermalink(msg.plurk_id));
                }
                Console.WriteLine("-----------------------------------------");
            }
            else 
            {
                Console.WriteLine("Logon fail ...");
            }
            Console.Read();
        }
    }
}
