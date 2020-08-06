using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartHomeServer.Hubs
{
    public class GarageHub : Hub
    {
        public async Task SendState(string state)
        {
            Console.WriteLine($"state changed to {state}");
            await Clients.All.SendAsync("ReceiveState", state);
        }

        public async Task RegisterClient()
        {
            Console.WriteLine(Context.ConnectionId);
        }

    }
}
