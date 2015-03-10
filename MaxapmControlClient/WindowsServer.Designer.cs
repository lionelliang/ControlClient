namespace MaxapmControlClient
{
    partial class WindowsServer
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
            this.btnListen = new System.Windows.Forms.Button();
            this.lblPort = new System.Windows.Forms.Label();
            this.lblIp = new System.Windows.Forms.Label();
            this.tbPort = new System.Windows.Forms.TextBox();
            this.tbIp = new System.Windows.Forms.TextBox();
            this.lblListen = new System.Windows.Forms.Label();
            this.lblMsg = new System.Windows.Forms.Label();
            this.tbMsg = new System.Windows.Forms.TextBox();
            this.lblSend = new System.Windows.Forms.Label();
            this.tbMsgSend = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnListen
            // 
            this.btnListen.Location = new System.Drawing.Point(262, 80);
            this.btnListen.Name = "btnListen";
            this.btnListen.Size = new System.Drawing.Size(111, 23);
            this.btnListen.TabIndex = 39;
            this.btnListen.Text = "Start Listening";
            this.btnListen.UseVisualStyleBackColor = true;
            this.btnListen.Click += new System.EventHandler(this.btnListen_Click);
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(53, 83);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(35, 12);
            this.lblPort.TabIndex = 38;
            this.lblPort.Text = "Port:";
            // 
            // lblIp
            // 
            this.lblIp.AutoSize = true;
            this.lblIp.Location = new System.Drawing.Point(53, 55);
            this.lblIp.Name = "lblIp";
            this.lblIp.Size = new System.Drawing.Size(23, 12);
            this.lblIp.TabIndex = 37;
            this.lblIp.Text = "IP:";
            // 
            // tbPort
            // 
            this.tbPort.Location = new System.Drawing.Point(135, 80);
            this.tbPort.Name = "tbPort";
            this.tbPort.Size = new System.Drawing.Size(100, 21);
            this.tbPort.TabIndex = 36;
            this.tbPort.Text = "12004";
            // 
            // tbIp
            // 
            this.tbIp.Location = new System.Drawing.Point(135, 52);
            this.tbIp.Name = "tbIp";
            this.tbIp.Size = new System.Drawing.Size(100, 21);
            this.tbIp.TabIndex = 35;
            this.tbIp.Text = "127.0.0.1";
            // 
            // lblListen
            // 
            this.lblListen.AutoSize = true;
            this.lblListen.Location = new System.Drawing.Point(23, 34);
            this.lblListen.Name = "lblListen";
            this.lblListen.Size = new System.Drawing.Size(59, 12);
            this.lblListen.TabIndex = 34;
            this.lblListen.Text = "Listen on";
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Location = new System.Drawing.Point(25, 136);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(137, 12);
            this.lblMsg.TabIndex = 40;
            this.lblMsg.Text = "Conversation Messages:";
            // 
            // tbMsg
            // 
            this.tbMsg.Location = new System.Drawing.Point(25, 172);
            this.tbMsg.Multiline = true;
            this.tbMsg.Name = "tbMsg";
            this.tbMsg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbMsg.Size = new System.Drawing.Size(401, 219);
            this.tbMsg.TabIndex = 41;
            // 
            // lblSend
            // 
            this.lblSend.AutoSize = true;
            this.lblSend.Location = new System.Drawing.Point(27, 423);
            this.lblSend.Name = "lblSend";
            this.lblSend.Size = new System.Drawing.Size(77, 12);
            this.lblSend.TabIndex = 42;
            this.lblSend.Text = "Send Message";
            // 
            // tbMsgSend
            // 
            this.tbMsgSend.Location = new System.Drawing.Point(135, 423);
            this.tbMsgSend.Name = "tbMsgSend";
            this.tbMsgSend.Size = new System.Drawing.Size(100, 21);
            this.tbMsgSend.TabIndex = 43;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(298, 423);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 44;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(390, 421);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 45;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // WindowsServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.tbMsgSend);
            this.Controls.Add(this.lblSend);
            this.Controls.Add(this.tbMsg);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.btnListen);
            this.Controls.Add(this.lblPort);
            this.Controls.Add(this.lblIp);
            this.Controls.Add(this.tbPort);
            this.Controls.Add(this.tbIp);
            this.Controls.Add(this.lblListen);
            this.Name = "WindowsServer";
            this.Size = new System.Drawing.Size(488, 458);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnListen;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.Label lblIp;
        private System.Windows.Forms.TextBox tbPort;
        private System.Windows.Forms.TextBox tbIp;
        private System.Windows.Forms.Label lblListen;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.TextBox tbMsg;
        private System.Windows.Forms.Label lblSend;
        private System.Windows.Forms.TextBox tbMsgSend;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnClear;

    }
}
