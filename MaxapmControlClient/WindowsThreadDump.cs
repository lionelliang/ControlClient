using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaxapmControlClient
{
    public partial class WindowsThreadDump : UserControl
    {
        WindowsClient winclient;

        public WindowsThreadDump()
        {
            InitializeComponent();
        }
        public WindowsThreadDump(WindowsClient winclient)
        {
            InitializeComponent();
            this.winclient = winclient;
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            if (this.winclient.s == null || this.winclient.s.Connected == false)
            {  
                MessageBox.Show("Connection lost");
                return;
            }
            byte[] data = new byte[1024];
            //send a command
            //SocketsConnection.SendData(this.winclient.s, System.Text.Encoding.Default.GetBytes(""), -1);
            //SocketsConnection.RecvData(this.winclient.s, data,3);
            //Encoding.UTF8.GetString(data)
            string str = @"GC DaemonId=14 TIMED_WAITING on sun.misc.GC$LatencyLock@6e978bae
	at java.lang.Object.wait(Native Method)
	-  waiting on sun.misc.GC$LatencyLock@6e978bae
	at sun.misc.GC$Daemon.run(GC.java:117)";
            string[] arrstr = str.Split('\n');
            LogThreadDumpBlue(arrstr[0]);
            for (int i = 1; i < arrstr.Length; i++)
            {
                LogThreadDumpRed(arrstr[i]);
            }
        }

        public delegate void LogAppendDelegate(Color color, string text);

        public void LogAppend(Color color, string text)
        {
            rtbMsg.AppendText("\n");
            rtbMsg.SelectionColor = color;
            rtbMsg.AppendText(text);
        }

        public void LogThreadDumpBlue(string text)
        {
            LogAppendDelegate la = new LogAppendDelegate(LogAppend);
            rtbMsg.Invoke(la, Color.Blue, text);

        } 
        public void LogThreadDumpRed(string text)
        {
            LogAppendDelegate la = new LogAppendDelegate(LogAppend);
            rtbMsg.Invoke(la, Color.Red, "\t" + text);
        } 
    }
}
