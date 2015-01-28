namespace ControlClient
{
    partial class MaxAPMControlClient
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
            this.tbSQL = new System.Windows.Forms.TextBox();
            this.btnSQL = new System.Windows.Forms.Button();
            this.lblSQL = new System.Windows.Forms.Label();
            this.lblVar = new System.Windows.Forms.Label();
            this.lblLog4J = new System.Windows.Forms.Label();
            this.lblException = new System.Windows.Forms.Label();
            this.lblCss = new System.Windows.Forms.Label();
            this.tbMsg = new System.Windows.Forms.TextBox();
            this.ckbVar = new System.Windows.Forms.CheckBox();
            this.cbbLog4J = new System.Windows.Forms.ComboBox();
            this.tbException = new System.Windows.Forms.TextBox();
            this.btnException = new System.Windows.Forms.Button();
            this.ckbCss = new System.Windows.Forms.CheckBox();
            this.btnLog4J = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbSQL
            // 
            this.tbSQL.Location = new System.Drawing.Point(144, 52);
            this.tbSQL.Name = "tbSQL";
            this.tbSQL.Size = new System.Drawing.Size(100, 21);
            this.tbSQL.TabIndex = 0;
            this.tbSQL.Text = "50";
            // 
            // btnSQL
            // 
            this.btnSQL.Location = new System.Drawing.Point(271, 50);
            this.btnSQL.Name = "btnSQL";
            this.btnSQL.Size = new System.Drawing.Size(75, 23);
            this.btnSQL.TabIndex = 1;
            this.btnSQL.Text = "Cut";
            this.btnSQL.UseVisualStyleBackColor = true;
            this.btnSQL.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // lblSQL
            // 
            this.lblSQL.AutoSize = true;
            this.lblSQL.Location = new System.Drawing.Point(32, 61);
            this.lblSQL.Name = "lblSQL";
            this.lblSQL.Size = new System.Drawing.Size(77, 12);
            this.lblSQL.TabIndex = 2;
            this.lblSQL.Text = "SQL Lenghth:";
            // 
            // lblVar
            // 
            this.lblVar.AutoSize = true;
            this.lblVar.Location = new System.Drawing.Point(32, 99);
            this.lblVar.Name = "lblVar";
            this.lblVar.Size = new System.Drawing.Size(59, 12);
            this.lblVar.TabIndex = 3;
            this.lblVar.Text = "Variable:";
            // 
            // lblLog4J
            // 
            this.lblLog4J.AutoSize = true;
            this.lblLog4J.Location = new System.Drawing.Point(32, 131);
            this.lblLog4J.Name = "lblLog4J";
            this.lblLog4J.Size = new System.Drawing.Size(41, 12);
            this.lblLog4J.TabIndex = 4;
            this.lblLog4J.Text = "Log4J:";
            // 
            // lblException
            // 
            this.lblException.AutoSize = true;
            this.lblException.Location = new System.Drawing.Point(32, 164);
            this.lblException.Name = "lblException";
            this.lblException.Size = new System.Drawing.Size(65, 12);
            this.lblException.TabIndex = 5;
            this.lblException.Text = "Exception:";
            // 
            // lblCss
            // 
            this.lblCss.AutoSize = true;
            this.lblCss.Location = new System.Drawing.Point(32, 200);
            this.lblCss.Name = "lblCss";
            this.lblCss.Size = new System.Drawing.Size(53, 12);
            this.lblCss.TabIndex = 6;
            this.lblCss.Text = "Css Res:";
            // 
            // tbMsg
            // 
            this.tbMsg.Location = new System.Drawing.Point(34, 335);
            this.tbMsg.Name = "tbMsg";
            this.tbMsg.Size = new System.Drawing.Size(110, 21);
            this.tbMsg.TabIndex = 7;
            // 
            // ckbVar
            // 
            this.ckbVar.AutoSize = true;
            this.ckbVar.Location = new System.Drawing.Point(144, 98);
            this.ckbVar.Name = "ckbVar";
            this.ckbVar.Size = new System.Drawing.Size(48, 16);
            this.ckbVar.TabIndex = 8;
            this.ckbVar.Text = "Bind";
            this.ckbVar.UseVisualStyleBackColor = true;
            this.ckbVar.CheckedChanged += new System.EventHandler(this.ckbVar_CheckedChanged);
            // 
            // cbbLog4J
            // 
            this.cbbLog4J.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbLog4J.FormattingEnabled = true;
            this.cbbLog4J.Location = new System.Drawing.Point(144, 122);
            this.cbbLog4J.Name = "cbbLog4J";
            this.cbbLog4J.Size = new System.Drawing.Size(121, 20);
            this.cbbLog4J.TabIndex = 9;
            // 
            // tbException
            // 
            this.tbException.Location = new System.Drawing.Point(144, 164);
            this.tbException.Name = "tbException";
            this.tbException.Size = new System.Drawing.Size(100, 21);
            this.tbException.TabIndex = 10;
            this.tbException.Text = "50";
            // 
            // btnException
            // 
            this.btnException.Location = new System.Drawing.Point(271, 164);
            this.btnException.Name = "btnException";
            this.btnException.Size = new System.Drawing.Size(75, 23);
            this.btnException.TabIndex = 11;
            this.btnException.Text = "Cut";
            this.btnException.UseVisualStyleBackColor = true;
            this.btnException.Click += new System.EventHandler(this.btnException_Click);
            // 
            // ckbCss
            // 
            this.ckbCss.AutoSize = true;
            this.ckbCss.Location = new System.Drawing.Point(144, 196);
            this.ckbCss.Name = "ckbCss";
            this.ckbCss.Size = new System.Drawing.Size(54, 16);
            this.ckbCss.TabIndex = 12;
            this.ckbCss.Text = "Catch";
            this.ckbCss.UseVisualStyleBackColor = true;
            this.ckbCss.CheckedChanged += new System.EventHandler(this.ckbCss_CheckedChanged);
            // 
            // btnLog4J
            // 
            this.btnLog4J.Location = new System.Drawing.Point(271, 119);
            this.btnLog4J.Name = "btnLog4J";
            this.btnLog4J.Size = new System.Drawing.Size(75, 23);
            this.btnLog4J.TabIndex = 13;
            this.btnLog4J.Text = "Change";
            this.btnLog4J.UseVisualStyleBackColor = true;
            this.btnLog4J.Click += new System.EventHandler(this.btnVar_Click);
            // 
            // MaxAPMControlClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 368);
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
            this.Name = "MaxAPMControlClient";
            this.Text = "MaxAPM Control Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbSQL;
        private System.Windows.Forms.Button btnSQL;
        private System.Windows.Forms.Label lblSQL;
        private System.Windows.Forms.Label lblVar;
        private System.Windows.Forms.Label lblLog4J;
        private System.Windows.Forms.Label lblException;
        private System.Windows.Forms.Label lblCss;
        private System.Windows.Forms.TextBox tbMsg;
        private System.Windows.Forms.CheckBox ckbVar;
        private System.Windows.Forms.ComboBox cbbLog4J;
        private System.Windows.Forms.TextBox tbException;
        private System.Windows.Forms.Button btnException;
        private System.Windows.Forms.CheckBox ckbCss;
        private System.Windows.Forms.Button btnLog4J;
    }
}

