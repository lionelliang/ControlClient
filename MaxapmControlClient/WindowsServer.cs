using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.Threading;

namespace MaxapmControlClient
{
    public partial class WindowsServer : UserControl
    {
        //负责监听端口
        Socket sokWelcome = null;
        //负责和客户端Socket通信
        Socket sokConnection = null;
        Thread threadWatchPort = null;

        public WindowsServer()
        {
            InitializeComponent();
        }

        private void btnListen_Click(object sender, EventArgs e)
        {
            beginStartService();
        }

        private void beginStartService()
        {
            try
            {
                //创建IP地址
                IPAddress address = IPAddress.Parse(tbIp.Text.Trim());
                //创建IP节点(包含IP和端口)
                IPEndPoint endpoint = new IPEndPoint(address, int.Parse(tbPort.Text.Trim()));
                //创建监听套接字(寻址协议，流方式，TCP协议)
                sokWelcome = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                sokWelcome.Bind(endpoint);
                sokWelcome.Listen(100);//参数：指能同时处理的连接数
                threadWatchPort = new Thread(WatchPort);
                threadWatchPort.Start();
                tbMsg.Text += "\nstart listening on " + tbIp.Text.Trim() + " " + tbPort.Text.Trim();
            }
            catch (Exception e)
            {
                tbMsg.Text += e.Message;
            }
        }

        public void WatchPort()
        {
            

            byte[] buffer = new byte[1024];
            while (true)
            {
                if (sokWelcome == null)
                {
                    tbMsg.Text = "Connection losed";
                    break;
                }
                try
                {
                    sokConnection = sokWelcome.Accept();
                    tbMsg.Text += "\r\nclient connected " + sokConnection.RemoteEndPoint + "\r\n";
                    /*
                    sokConnection.Receive(buffer);
                    string str = System.Text.Encoding.Default.GetString(buffer, 0, buffer.Length);
                    tbMsg.AppendText(sokConnection.RemoteEndPoint + "：" + str + "\r\n");
                     * */
                    new Thread(() =>
                    {
                        while (true)
                        {
                            byte[] data = new byte[1024];
                            try
                            {
                                int length = sokConnection.Receive(data);
                            }
                            catch (Exception ex)
                            {
                                tbMsg.AppendText(string.Format("Exception：{0}", ex.Message));
                                break;
                            }
                            tbMsg.AppendText(string.Format("Message：{0}", Encoding.UTF8.GetString(data)));
                            string sendMsg = "get the message";
                            sokConnection.Send(Encoding.UTF8.GetBytes(sendMsg));
                        }
                    }).Start();
                }
                catch (Exception e)
                {
                    //tbMsg.Text += e.Message;
                }
                break;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbMsg.Text = "";
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
        //    String str = tbMsgSend.Text.Trim();

        //    byte[] buffer = System.Text.Encoding.Default.GetBytes(str);
        //    if (this.s == null || this.s.Connected == false)
        //    {
        //        tbMsg.Text = "Connection losed";
        //        return;
        //    }
        //    SocketsConnection.SendData(this.s, buffer, -1);
        } 
    }
}
