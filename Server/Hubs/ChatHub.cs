using Microsoft.AspNetCore.SignalR;
using Serilog;

namespace Server.Hubs;

public class ChatHub : Hub
{
    public async Task SendMessage(string user, string message)
    {
        Log.Information("{0} : {1}", user, message);
        await Clients.All.SendAsync("ReceiveMessage", user, message);
    }
}
