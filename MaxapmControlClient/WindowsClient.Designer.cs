namespace MaxapmControlClient
{
    partial class WindowsClient
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lblconnect = new System.Windows.Forms.Label();
            this.tbIp = new System.Windows.Forms.TextBox();
            this.btnLog4J = new System.Windows.Forms.Button();
            this.ckbCss = new System.Windows.Forms.CheckBox();
            this.btnException = new System.Windows.Forms.Button();
            this.tbException = new System.Windows.Forms.TextBox();
            this.cbbLog4J = new System.Windows.Forms.ComboBox();
            this.ckbVar = new System.Windows.Forms.CheckBox();
            this.tbMsg = new System.Windows.Forms.TextBox();
            this.lblCss = new System.Windows.Forms.Label();
            this.lblException = new System.Windows.Forms.Label();
            this.lblLog4J = new System.Windows.Forms.Label();
            this.lblVar = new System.Windows.Forms.Label();
            this.lblSQL = new System.Windows.Forms.Label();
            this.btnSQL = new System.Windows.Forms.Button();
            this.tbSQL = new System.Windows.Forms.TextBox();
            this.tbPort = new System.Windows.Forms.TextBox();
            this.lblIp = new System.Windows.Forms.Label();
            this.lblPort = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.tbMsgSend = new System.Windows.Forms.TextBox();
            this.lblSend = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblconnect
            // 
            this.lblconnect.AutoSize = true;
            this.lblconnect.Location = new System.Drawing.Point(45, 26);
            this.lblconnect.Name = "lblconnect";
            this.lblconnect.Size = new System.Drawing.Size(65, 12);
            this.lblconnect.TabIndex = 0;
            this.lblconnect.Text = "Connect to";
            // 
            // tbIp
            // 
            this.tbIp.Location = new System.Drawing.Point(157, 44);
            this.tbIp.Name = "tbIp";
            this.tbIp.Size = new System.Drawing.Size(100, 21);
            this.tbIp.TabIndex = 29;
            this.tbIp.Text = "127.0.0.1";
            // 
            // btnLog4J
            // 
            this.btnLog4J.Location = new System.Drawing.Point(284, 169);
            this.btnLog4J.Name = "btnLog4J";
            this.btnLog4J.Size = new System.Drawing.Size(75, 23);
            this.btnLog4J.TabIndex = 28;
            this.btnLog4J.Text = "Change";
            this.btnLog4J.UseVisualStyleBackColor = true;
            this.btnLog4J.Click += new System.EventHandler(this.btnVar_Click);
            // 
            // ckbCss
            // 
            this.ckbCss.AutoSize = true;
            this.ckbCss.Location = new System.Drawing.Point(157, 246);
            this.ckbCss.Name = "ckbCss";
            this.ckbCss.Size = new System.Drawing.Size(54, 16);
            this.ckbCss.TabIndex = 27;
            this.ckbCss.Text = "Catch";
            this.ckbCss.UseVisualStyleBackColor = true;
            this.ckbCss.CheckedChanged += new System.EventHandler(this.ckbCss_CheckedChanged);
            // 
            // btnException
            // 
            this.btnException.Location = new System.Drawing.Point(284, 214);
            this.btnException.Name = "btnException";
            this.btnException.Size = new System.Drawing.Size(75, 23);
            this.btnException.TabIndex = 26;
            this.btnException.Text = "Cut";
            this.btnException.UseVisualStyleBackColor = true;
            this.btnException.Click += new System.EventHandler(this.btnException_Click);
            // 
            // tbException
            // 
            this.tbException.Location = new System.Drawing.Point(157, 214);
            this.tbException.Name = "tbException";
            this.tbException.Size = new System.Drawing.Size(100, 21);
            this.tbException.TabIndex = 25;
            this.tbException.Text = "50";
            // 
            // cbbLog4J
            // 
            this.cbbLog4J.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbLog4J.FormattingEnabled = true;
            this.cbbLog4J.Location = new System.Drawing.Point(157, 172);
            this.cbbLog4J.Name = "cbbLog4J";
            this.cbbLog4J.Size = new System.Drawing.Size(121, 20);
            this.cbbLog4J.TabIndex = 24;
            // 
            // ckbVar
            // 
            this.ckbVar.AutoSize = true;
            this.ckbVar.Location = new System.Drawing.Point(157, 148);
            this.ckbVar.Name = "ckbVar";
            this.ckbVar.Size = new System.Drawing.Size(48, 16);
            this.ckbVar.TabIndex = 23;
            this.ckbVar.Text = "Bind";
            this.ckbVar.UseVisualStyleBackColor = true;
            this.ckbVar.CheckedChanged += new System.EventHandler(this.ckbVar_CheckedChanged);
            // 
            // tbMsg
            // 
            this.tbMsg.Location = new System.Drawing.Point(47, 282);
            this.tbMsg.Multiline = true;
            this.tbMsg.Name = "tbMsg";
            this.tbMsg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbMsg.Size = new System.Drawing.Size(312, 120);
            this.tbMsg.TabIndex = 22;
            // 
            // lblCss
            // 
            this.lblCss.AutoSize = true;
            this.lblCss.Location = new System.Drawing.Point(45, 250);
            this.lblCss.Name = "lblCss";
            this.lblCss.Size = new System.Drawing.Size(53, 12);
            this.lblCss.TabIndex = 21;
            this.lblCss.Text = "Css Res:";
            // 
            // lblException
            // 
            this.lblException.AutoSize = true;
            this.lblException.Location = new System.Drawing.Point(45, 214);
            this.lblException.Name = "lblException";
            this.lblException.Size = new System.Drawing.Size(65, 12);
            this.lblException.TabIndex = 20;
            this.lblException.Text = "Exception:";
            // 
            // lblLog4J
            // 
            this.lblLog4J.AutoSize = true;
            this.lblLog4J.Location = new System.Drawing.Point(45, 181);
            this.lblLog4J.Name = "lblLog4J";
            this.lblLog4J.Size = new System.Drawing.Size(41, 12);
            this.lblLog4J.TabIndex = 19;
            this.lblLog4J.Text = "Log4J:";
            // 
            // lblVar
            // 
            this.lblVar.AutoSize = true;
            this.lblVar.Location = new System.Drawing.Point(45, 149);
            this.lblVar.Name = "lblVar";
            this.lblVar.Size = new System.Drawing.Size(59, 12);
            this.lblVar.TabIndex = 18;
            this.lblVar.Text = "Variable:";
            // 
            // lblSQL
            // 
            this.lblSQL.AutoSize = true;
            this.lblSQL.Location = new System.Drawing.Point(45, 111);
            this.lblSQL.Name = "lblSQL";
            this.lblSQL.Size = new System.Drawing.Size(77, 12);
            this.lblSQL.TabIndex = 17;
            this.lblSQL.Text = "SQL Lenghth:";
            // 
            // btnSQL
            // 
            this.btnSQL.Location = new System.Drawing.Point(284, 100);
            this.btnSQL.Name = "btnSQL";
            this.btnSQL.Size = new System.Drawing.Size(75, 23);
            this.btnSQL.TabIndex = 16;
            this.btnSQL.Text = "Cut";
            this.btnSQL.UseVisualStyleBackColor = true;
            this.btnSQL.Click += new System.EventHandler(this.btnSQL_Click);
            // 
            // tbSQL
            // 
            this.tbSQL.Location = new System.Drawing.Point(157, 102);
            this.tbSQL.Name = "tbSQL";
            this.tbSQL.Size = new System.Drawing.Size(100, 21);
            this.tbSQL.TabIndex = 15;
            this.tbSQL.Text = "50";
            // 
            // tbPort
            // 
            this.tbPort.Location = new System.Drawing.Point(157, 72);
            this.tbPort.Name = "tbPort";
            this.tbPort.Size = new System.Drawing.Size(100, 21);
            this.tbPort.TabIndex = 30;
            this.tbPort.Text = "12004";
            // 
            // lblIp
            // 
            this.lblIp.AutoSize = true;
            this.lblIp.Location = new System.Drawing.Point(75, 47);
            this.lblIp.Name = "lblIp";
            this.lblIp.Size = new System.Drawing.Size(23, 12);
            this.lblIp.TabIndex = 31;
            this.lblIp.Text = "IP:";
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(75, 75);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(35, 12);
            this.lblPort.TabIndex = 32;
            this.lblPort.Text = "Port:";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(284, 72);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 33;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(284, 44);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(75, 23);
            this.btnDisconnect.TabIndex = 34;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(392, 379);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 35;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(392, 428);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 47;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // tbMsgSend
            // 
            this.tbMsgSend.Location = new System.Drawing.Point(104, 428);
            this.tbMsgSend.Name = "tbMsgSend";
            this.tbMsgSend.Size = new System.Drawing.Size(255, 21);
            this.tbMsgSend.TabIndex = 46;
            // 
            // lblSend
            // 
            this.lblSend.AutoSize = true;
            this.lblSend.Location = new System.Drawing.Point(21, 428);
            this.lblSend.Name = "lblSend";
            this.lblSend.Size = new System.Drawing.Size(77, 12);
            this.lblSend.TabIndex = 45;
            this.lblSend.Text = "Send Message";
            // 
            // WindowsClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.tbMsgSend);
            this.Controls.Add(this.lblSend);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.lblPort);
            this.Controls.Add(this.lblIp);
            this.Controls.Add(this.tbPort);
            this.Controls.Add(this.tbIp);
            this.Controls.Add(this.btnLog4J);
            this.Controls.Add(this.ckbCss);
            this.Controls.Add(this.btnException);
            this.Controls.Add(this.tbException);
            this.Controls.Add(this.cbbLog4J);
            this.Controls.Add(this.ckbVar);
            this.Controls.Add(this.tbMsg);
            this.Controls.Add(this.lblCss);
            this.Controls.Add(this.lblException);
            this.Controls.Add(this.lblLog4J);
            this.Controls.Add(this.lblVar);
            this.Controls.Add(this.lblSQL);
            this.Controls.Add(this.btnSQL);
            this.Controls.Add(this.tbSQL);
            this.Controls.Add(this.lblconnect);
            this.Name = "WindowsClient";
            this.Size = new System.Drawing.Size(488, 458);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblconnect;
        private System.Windows.Forms.TextBox tbIp;
        private System.Windows.Forms.Button btnLog4J;
        private System.Windows.Forms.CheckBox ckbCss;
        private System.Windows.Forms.Button btnException;
        private System.Windows.Forms.TextBox tbException;
        private System.Windows.Forms.ComboBox cbbLog4J;
        private System.Windows.Forms.CheckBox ckbVar;
        private System.Windows.Forms.TextBox tbMsg;
        private System.Windows.Forms.Label lblCss;
        private System.Windows.Forms.Label lblException;
        private System.Windows.Forms.Label lblLog4J;
        private System.Windows.Forms.Label lblVar;
        private System.Windows.Forms.Label lblSQL;
        private System.Windows.Forms.Button btnSQL;
        private System.Windows.Forms.TextBox tbSQL;
        private System.Windows.Forms.TextBox tbPort;
        private System.Windows.Forms.Label lblIp;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox tbMsgSend;
        private System.Windows.Forms.Label lblSend;
    }
}
