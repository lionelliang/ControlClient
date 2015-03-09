using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaxapmControlClient
{
    public partial class Form1 : Form
    {
        public WindowsClient winclient;
        public WindowsServer winserver;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            winclient = new WindowsClient();
            winserver = new WindowsServer();
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            winclient.Show();
            gpbContainer.Controls.Clear();
            gpbContainer.Controls.Add(winclient);
        }

        private void btnServer_Click(object sender, EventArgs e)
        {
            winserver.Show();
            gpbContainer.Controls.Clear();
            gpbContainer.Controls.Add(winserver);
        }
    }
}
