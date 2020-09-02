using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Microsoft.AspNetCore.SignalR.Client;

namespace SignalRClient
{
    public class MessageHubManager
    {
        private HubConnection hubConnection;
        private const string HUB_URL = "http://localhost:50722/MessageHub";
        public ListBox MessageList;
        string clientId;
        public MessageHubManager(ListBox list)
        {
            hubConnection = new HubConnectionBuilder().WithUrl(HUB_URL).Build();
            clientId = Guid.NewGuid().ToString();
            hubConnection.Closed += HubConnection_Closed;
            hubConnection.On<Message>("MessageReceived", (messageObj) =>
            {
                MessageList.Items.Add($"{messageObj.username}: {messageObj.message}");
            });
            MessageList = list;
        }

        public async Task StartMessageHub()
        {
           

            try
            {
                await hubConnection.StartAsync();
                MessageList.Items.Add("Connection started");
            } catch (Exception e)
            {
                MessageList.Items.Add(e.Message);
            }
        }

        public async Task SendMessage(string message, string userName)
        {
            try
            {
                var messageObj = new Message() { clientuniqueid = clientId, date = DateTime.Now, message = message, type = "sent", username = userName };
                await hubConnection.InvokeAsync("NewMessage", messageObj);
                
            }
            catch (Exception ex)
            {
                MessageList.Items.Add(ex.Message);
            }
        }

        private async Task HubConnection_Closed(Exception arg)
        {
            await Task.Delay(new Random().Next(0, 5) * 1000);
            await hubConnection.StartAsync();
        }
    }

    public class Message
    {
        public string clientuniqueid { get; set; }
        public string username { get; set; }
        public string type { get; set; }
        public string message { get; set; }
        public DateTime date { get; set; }
    }
}
