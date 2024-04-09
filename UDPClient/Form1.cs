using System.Net;
using System.Net.Sockets;
using System.Text;

namespace udpClient
{
    public partial class Form1 : Form
    {
        private static IPEndPoint ep = new IPEndPoint(IPAddress.Parse("192.168.220.223"), 35486);
        private static UdpClient udpClient = new UdpClient(34285);
        private static string ipFrom;
        public Form1()
        {
            String strHostName = string.Empty;
            strHostName = Dns.GetHostName();
            IPHostEntry ipEntry = Dns.GetHostEntry(strHostName);
            IPAddress[] addr = ipEntry.AddressList;
            ipFrom = addr[1].ToString();
           
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            


            Message message = new Message(Command.Text, Text.Text, IpTo.Text, ipFrom);
            string messageJson = message.ToJSON();
            byte[] messageData = Encoding.UTF8.GetBytes(messageJson);
            udpClient.Send(messageData, ep);
            
        }
    }
}
