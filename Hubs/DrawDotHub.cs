using Microsoft.AspNetCore.SignalR;

namespace SignalRStuff.Hubs
{
    public class DrawDotHub : Hub
    {
        public async Task UpdateCanvas(int x, int y)
        {
            await Clients.All.SendAsync("updateDot", x, y);
        }
        public async Task ClearCanvas()
        {
            await Clients.All.SendAsync("clearCanvas");
        }
    }
}
