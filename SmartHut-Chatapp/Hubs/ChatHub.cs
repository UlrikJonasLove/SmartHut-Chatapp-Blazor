using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace SmartHut_Chatapp 
{
    public class ChatHub : Hub 
    {
        public const string HubUrl = "/chat";

        public async Task Message(string username, string message) 
        {
            await Clients.All.SendAsync("SendMessage", username, message);
        }

        public override Task OnConnectedAsync()
        {
            Console.WriteLine($"{Context.ConnectionId} connected");
            return base.OnConnectedAsync();
        }

        public override async Task OnDisconnectedAsync(Exception err) 
        {
            Console.WriteLine($"Disconnected {err?.Message} {Context.ConnectionId}");
            await base.OnDisconnectedAsync(err);
        }
    }
}