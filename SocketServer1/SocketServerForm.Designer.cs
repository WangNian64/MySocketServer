namespace SocketServer1
{
    partial class SocketServerForm
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label_IP = new System.Windows.Forms.Label();
            this.label_port = new System.Windows.Forms.Label();
            this.textBox_IP = new System.Windows.Forms.TextBox();
            this.textBox_port = new System.Windows.Forms.TextBox();
            this.listenClient_btn = new System.Windows.Forms.Button();
            this.listBox_receiveMsg = new System.Windows.Forms.ListBox();
            this.sendMsg_btn = new System.Windows.Forms.Button();
            this.textBox_sendMsg = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label_IP
            // 
            this.label_IP.AutoSize = true;
            this.label_IP.Location = new System.Drawing.Point(12, 25);
            this.label_IP.Name = "label_IP";
            this.label_IP.Size = new System.Drawing.Size(23, 12);
            this.label_IP.TabIndex = 0;
            this.label_IP.Text = "IP:";
            this.label_IP.Click += new System.EventHandler(this.label_IP_Click);
            // 
            // label_port
            // 
            this.label_port.AutoSize = true;
            this.label_port.Location = new System.Drawing.Point(333, 28);
            this.label_port.Name = "label_port";
            this.label_port.Size = new System.Drawing.Size(35, 12);
            this.label_port.TabIndex = 1;
            this.label_port.Text = "Port:";
            // 
            // textBox_IP
            // 
            this.textBox_IP.Location = new System.Drawing.Point(54, 25);
            this.textBox_IP.Name = "textBox_IP";
            this.textBox_IP.Text = "127.0.0.1";
            this.textBox_IP.Size = new System.Drawing.Size(200, 21);
            this.textBox_IP.TabIndex = 2;
            this.textBox_IP.TextChanged += new System.EventHandler(this.textBox_IP_TextChanged);
            // 
            // textBox_port
            // 
            this.textBox_port.Location = new System.Drawing.Point(390, 25);
            this.textBox_port.Name = "textBox_port";
            this.textBox_port.Text = "50001";
            this.textBox_port.Size = new System.Drawing.Size(232, 21);
            this.textBox_port.TabIndex = 3;
            this.textBox_port.TextChanged += new System.EventHandler(this.textBox_port_TextChanged);
            // 
            // listenClient_btn
            // 
            this.listenClient_btn.Location = new System.Drawing.Point(728, 6);
            this.listenClient_btn.Name = "listenClient_btn";
            this.listenClient_btn.Size = new System.Drawing.Size(148, 57);
            this.listenClient_btn.TabIndex = 4;
            this.listenClient_btn.Text = "开始监听";
            this.listenClient_btn.UseVisualStyleBackColor = true;
            this.listenClient_btn.Click += new System.EventHandler(this.listenClient_btn_Click);
            // 
            // listBox_receiveMsg
            // 
            this.listBox_receiveMsg.FormattingEnabled = true;
            this.listBox_receiveMsg.ItemHeight = 12;
            this.listBox_receiveMsg.Location = new System.Drawing.Point(29, 83);
            this.listBox_receiveMsg.Name = "listBox_receiveMsg";
            this.listBox_receiveMsg.Size = new System.Drawing.Size(847, 244);
            this.listBox_receiveMsg.TabIndex = 5;
            // 
            // sendMsg_btn
            // 
            this.sendMsg_btn.Location = new System.Drawing.Point(728, 476);
            this.sendMsg_btn.Name = "sendMsg_btn";
            this.sendMsg_btn.Size = new System.Drawing.Size(148, 57);
            this.sendMsg_btn.TabIndex = 6;
            this.sendMsg_btn.Text = "发送";
            this.sendMsg_btn.UseVisualStyleBackColor = true;
            this.sendMsg_btn.Click += new System.EventHandler(this.sendMsg_btn_Click);
            // 
            // textBox_sendMsg
            // 
            this.textBox_sendMsg.Location = new System.Drawing.Point(29, 358);
            this.textBox_sendMsg.Multiline = true;
            this.textBox_sendMsg.Name = "textBox_sendMsg";
            this.textBox_sendMsg.Size = new System.Drawing.Size(637, 175);
            this.textBox_sendMsg.TabIndex = 7;
            this.textBox_sendMsg.TextChanged += new System.EventHandler(this.textBox_sendMsg_TextChanged);
            // 
            // SocketServerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 569);
            this.Controls.Add(this.textBox_sendMsg);
            this.Controls.Add(this.sendMsg_btn);
            this.Controls.Add(this.listBox_receiveMsg);
            this.Controls.Add(this.listenClient_btn);
            this.Controls.Add(this.textBox_port);
            this.Controls.Add(this.textBox_IP);
            this.Controls.Add(this.label_port);
            this.Controls.Add(this.label_IP);
            this.Name = "SocketServerForm";
            this.Text = "SocketServerForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_IP;
        private System.Windows.Forms.Label label_port;
        private System.Windows.Forms.TextBox textBox_IP;
        private System.Windows.Forms.TextBox textBox_port;
        private System.Windows.Forms.Button listenClient_btn;
        private System.Windows.Forms.ListBox listBox_receiveMsg;
        private System.Windows.Forms.Button sendMsg_btn;
        private System.Windows.Forms.TextBox textBox_sendMsg;
    }
}

