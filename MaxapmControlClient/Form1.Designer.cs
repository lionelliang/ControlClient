namespace MaxapmControlClient
{
    partial class Form1
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.gpbContainer = new System.Windows.Forms.GroupBox();
            this.btnClient = new System.Windows.Forms.Button();
            this.btnServer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gpbContainer
            // 
            this.gpbContainer.Location = new System.Drawing.Point(12, 81);
            this.gpbContainer.Name = "gpbContainer";
            this.gpbContainer.Size = new System.Drawing.Size(488, 458);
            this.gpbContainer.TabIndex = 0;
            this.gpbContainer.TabStop = false;
            this.gpbContainer.Text = "groupBox1";
            // 
            // btnClient
            // 
            this.btnClient.Location = new System.Drawing.Point(12, 26);
            this.btnClient.Name = "btnClient";
            this.btnClient.Size = new System.Drawing.Size(75, 23);
            this.btnClient.TabIndex = 1;
            this.btnClient.Text = "Client";
            this.btnClient.UseVisualStyleBackColor = true;
            this.btnClient.Click += new System.EventHandler(this.btnClient_Click);
            // 
            // btnServer
            // 
            this.btnServer.Location = new System.Drawing.Point(108, 26);
            this.btnServer.Name = "btnServer";
            this.btnServer.Size = new System.Drawing.Size(75, 23);
            this.btnServer.TabIndex = 2;
            this.btnServer.Text = "Server";
            this.btnServer.UseVisualStyleBackColor = true;
            this.btnServer.Click += new System.EventHandler(this.btnServer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 578);
            this.Controls.Add(this.btnServer);
            this.Controls.Add(this.btnClient);
            this.Controls.Add(this.gpbContainer);
            this.Name = "Form1";
            this.Text = "MaxAPM Control Client";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbContainer;
        private System.Windows.Forms.Button btnClient;
        private System.Windows.Forms.Button btnServer;
    }
}

