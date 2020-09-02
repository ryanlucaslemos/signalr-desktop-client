using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SignalRClient
{
    public partial class Form1 : Form
    {
        public MessageHubManager HubManager;
        public Form1()
        {
            InitializeComponent();
            HubManager = new MessageHubManager(messageListBox);
            HubManager.StartMessageHub();
        }

        private async void sendMessageButton_Click(object sender, EventArgs e)
        {
            await HubManager.SendMessage(messageTextbox.Text, nameTextBox.Text);
        }
    }
}
