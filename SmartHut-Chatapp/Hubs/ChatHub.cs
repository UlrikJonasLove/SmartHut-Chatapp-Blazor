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
            await Clients.All.SendAsync("Message", username, message);
        }
    }
}