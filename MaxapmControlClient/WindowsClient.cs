using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaxapmControlClient
{
    public partial class WindowsClient : UserControl
    {
        public Socket s = null;
        Thread threadClient = null;

        public WindowsClient()
        {
            InitializeComponent();
            this.DoBindDataSource();
            System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;
           /*
            this.s = SocketsConnection.ConnectServer("127.0.0.1", 12004);
            if (this.s == null)
            {
                tbMsg.Text = "Connection failed";
            }
            else
            {
                tbMsg.Text = "Server connected";
            }
           */
        }


        private void btnConnect_Click(object sender, EventArgs e)
        {
            tbMsg.Text = "";
            string strIp = tbIp.Text.Trim();
            int iPort = int.Parse(tbPort.Text.Trim());

            this.s = SocketsConnection.ConnectServer(strIp, iPort);
            //this.s = SocketsConnection.ConnectServer("127.0.0.1", 12004);
            if (this.s == null || this.s.Connected == false)
            {
                tbMsg.Text = "Connection failed";
            }
            else
            {
                tbMsg.Text += "Connected to " + strIp + " " + iPort + "\r\n";
                threadClient = new Thread(ReciveMsg);
                threadClient.Start();
            }
        }
        #region functions
        private void btnSQL_Click(object sender, EventArgs e)
        {
            String str = "1#";
                str += tbSQL.Text;
            if (String.IsNullOrEmpty(tbSQL.Text.Trim()))
            {
                return;
            }
            byte[] buffer = System.Text.Encoding.Default.GetBytes(str);
            if (this.s == null || this.s.Connected == false)
            {
                tbMsg.Text = "Connection lost";
                return;
            }
            SocketsConnection.SendData(this.s, buffer, -1);
            tbMsg.AppendText(str);
        }

        private void ckbVar_CheckedChanged(object sender, EventArgs e)
        {
            String str = "2#";

            if(ckbVar.CheckState == CheckState.Checked)
            {
                str += "1";
            }
            else
            {
                str += "0";
            }

            byte[] buffer = System.Text.Encoding.Default.GetBytes(str);
            if (this.s == null || this.s.Connected == false)
            {
                tbMsg.Text = "Connection lost";
                return;
            }
            SocketsConnection.SendData(this.s, buffer, -1);
            tbMsg.AppendText(str);
        }

        private void DoBindDataSource()
        {
            //构造数据源（或从数据库中查询）  
            DataTable Dt = new DataTable();
            DataColumn DC1 = new DataColumn("id", typeof(int));
            DataColumn DC2 = new DataColumn("name", typeof(string));
            Dt.Columns.Add(DC1);
            Dt.Columns.Add(DC2);

            DataRow dr1 = Dt.NewRow();
            dr1[0] = "0";
            dr1[1] = "ERROR";
            Dt.Rows.Add(dr1);

            DataRow dr2 = Dt.NewRow();
            dr2[0] = "1";
            dr2[1] = "WARN";
            Dt.Rows.Add(dr2);

            DataRow dr3 = Dt.NewRow();
            dr3[0] = "3";
            dr3[1] = "INFO";
            Dt.Rows.Add(dr3);

            DataRow dr4 = Dt.NewRow();
            dr4[0] = "4";
            dr4[1] = "DEBUG";
            Dt.Rows.Add(dr4); 

            //进行绑定  
            cbbLog4J.DisplayMember = "name";//控件显示的列名  
            cbbLog4J.ValueMember = "id";//控件值的列名  
            cbbLog4J.DataSource = Dt;
        }

        private void btnVar_Click(object sender, EventArgs e)
        {
            String str = "3#";
            str += cbbLog4J.SelectedValue;

            byte[] buffer = System.Text.Encoding.Default.GetBytes(str);
            if (this.s == null || this.s.Connected == false)
            {
                tbMsg.Text = "Connection lost";
                return;
            }
            SocketsConnection.SendData(this.s, buffer, -1);
            tbMsg.AppendText(str);
        }

        private void btnException_Click(object sender, EventArgs e)
        {
            String str = "4#";
            str += tbException.Text;
            if (String.IsNullOrEmpty( tbException.Text.Trim()))
            {
                return;
            }
            byte[] buffer = System.Text.Encoding.Default.GetBytes(str);
            if (this.s == null || this.s.Connected == false)
            {
                tbMsg.Text = "Connection lost";
                return;
            }
            SocketsConnection.SendData(this.s, buffer, -1);
            tbMsg.AppendText(str);
        }

        private void ckbCss_CheckedChanged(object sender, EventArgs e)
        {
            String str = "5#";

            if (ckbCss.CheckState == CheckState.Checked)
            {
                str += "1";
            }
            else
            {
                str += "0";
            }

            byte[] buffer = System.Text.Encoding.Default.GetBytes(str);
            if (this.s == null || this.s.Connected == false)
            {
                tbMsg.Text += "\r\nConnection lost";
                return;
            }
            SocketsConnection.SendData(this.s, buffer, -1);
            tbMsg.AppendText(str);
        }
        #endregion

        private void ReciveMsg()
        {
            //byte[] buffer = new byte[1024 * 1024 * 4];
            byte[] data = new byte[1024];
            /*
            while (true)
            {
                if (this.s == null || this.s.Connected == false)
                {
                    tbMsg.Text += "\r\nConnection lost";
                    break;
                }
             * */
               /*
                    byte[] byteMsg = new byte[1024 * 1024 * 4];
                    int length = this.s.Receive(byteMsg);
                    string strMsg = Encoding.UTF8.GetString(byteMsg, 0, length);
                    tbMsg.Text += strMsg;
                */
                /*
                int flag = SocketsConnection.RecvData(this.s, buffer, 10);
                if (flag == 0)
                {
                    string strMsg = Encoding.UTF8.GetString(buffer, 0, buffer.Length);
                    tbMsg.Text += strMsg;
                }
                else
                {
                    continue;
                }*/
                new Thread(() =>
                {
                    while (true)
                    {
                        
                        try
                        {
                            int length = this.s.Receive(data);
                        }
                        catch (Exception ex)
                        {
                            tbMsg.AppendText(string.Format("Exception：{0}", ex.Message));
                            break;
                        }
                        tbMsg.AppendText(Encoding.UTF8.GetString(data));
                        //string sendMsg = "get the message";
                        //this.s.Send(Encoding.UTF8.GetBytes(sendMsg));
                    }
                }).Start();
           // }
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            //this.s.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbMsg.Text = "";
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            String str = tbMsgSend.Text.Trim();

            byte[] buffer = System.Text.Encoding.Default.GetBytes(str);
            if (this.s == null || this.s.Connected == false)
            {
                tbMsg.Text = "Connection lost";
                return;
            }
            SocketsConnection.SendData(this.s, buffer, -1);
            tbMsg.AppendText(str);
        }
    }
}
