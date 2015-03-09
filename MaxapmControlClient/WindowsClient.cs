using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaxapmControlClient
{
    public partial class WindowsClient : UserControl
    {
        private Socket s;

        public WindowsClient()
        {
            InitializeComponent();
            this.DoBindDataSource();
            this.s = SocketsConnection.ConnectServer("127.0.0.1", 12004);
            if (this.s == null)
            {
                tbMsg.Text = "Connection failed";
            }
            else
            {
                tbMsg.Text = "Server connected";
            }
        }
               private void btnSend_Click(object sender, EventArgs e)
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
                tbMsg.Text = "Connection losed";
                return;
            }
            SocketsConnection.SendData(this.s, buffer, -1);
            tbMsg.Text = "success";
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
                tbMsg.Text = "Connection losed";
                return;
            }
            SocketsConnection.SendData(this.s, buffer, -1);
            tbMsg.Text = "success";
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
                tbMsg.Text = "Connection losed";
                return;
            }
            SocketsConnection.SendData(this.s, buffer, -1);
            tbMsg.Text = "success";
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
                tbMsg.Text = "Connection losed";
                return;
            }
            SocketsConnection.SendData(this.s, buffer, -1);
            tbMsg.Text = "success";
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
                tbMsg.Text = "Connection losed";
                return;
            }
            SocketsConnection.SendData(this.s, buffer, -1);
            tbMsg.Text = "success";
        }  
    }
}
