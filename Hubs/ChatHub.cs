using System;
using Microsoft.AspNetCore.SignalR;

namespace Demo_Chat.Hubs
{
    public class ChatHub : Hub
    {
        public void Send(string name, string message)
        {
            Console.WriteLine("\nChat Hub Send !!!");
            Clients.All.SendAsync("broadcastMessage", name, message);
        }
    }
}
