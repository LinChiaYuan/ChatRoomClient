namespace ChatRoomClient
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.ListBChat = new System.Windows.Forms.ListBox();
            this.TxtSend = new System.Windows.Forms.TextBox();
            this.BtnConnect = new System.Windows.Forms.Button();
            this.BtnSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("標楷體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(33, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "聊天室內容";
            // 
            // ListBChat
            // 
            this.ListBChat.Font = new System.Drawing.Font("標楷體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ListBChat.FormattingEnabled = true;
            this.ListBChat.ItemHeight = 23;
            this.ListBChat.Location = new System.Drawing.Point(38, 71);
            this.ListBChat.Name = "ListBChat";
            this.ListBChat.Size = new System.Drawing.Size(402, 211);
            this.ListBChat.TabIndex = 1;
            // 
            // TxtSend
            // 
            this.TxtSend.Font = new System.Drawing.Font("標楷體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TxtSend.Location = new System.Drawing.Point(38, 302);
            this.TxtSend.Multiline = true;
            this.TxtSend.Name = "TxtSend";
            this.TxtSend.Size = new System.Drawing.Size(303, 105);
            this.TxtSend.TabIndex = 2;
            // 
            // BtnConnect
            // 
            this.BtnConnect.Font = new System.Drawing.Font("標楷體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BtnConnect.Location = new System.Drawing.Point(347, 302);
            this.BtnConnect.Name = "BtnConnect";
            this.BtnConnect.Size = new System.Drawing.Size(93, 44);
            this.BtnConnect.TabIndex = 3;
            this.BtnConnect.Text = "連線";
            this.BtnConnect.UseVisualStyleBackColor = true;
            this.BtnConnect.Click += new System.EventHandler(this.BtnConnect_Click);
            // 
            // BtnSend
            // 
            this.BtnSend.Font = new System.Drawing.Font("標楷體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BtnSend.Location = new System.Drawing.Point(347, 357);
            this.BtnSend.Name = "BtnSend";
            this.BtnSend.Size = new System.Drawing.Size(93, 50);
            this.BtnSend.TabIndex = 4;
            this.BtnSend.Text = "送出";
            this.BtnSend.UseVisualStyleBackColor = true;
            this.BtnSend.Click += new System.EventHandler(this.BtnSend_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 436);
            this.Controls.Add(this.BtnSend);
            this.Controls.Add(this.BtnConnect);
            this.Controls.Add(this.TxtSend);
            this.Controls.Add(this.ListBChat);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox ListBChat;
        private System.Windows.Forms.TextBox TxtSend;
        private System.Windows.Forms.Button BtnConnect;
        private System.Windows.Forms.Button BtnSend;
    }
}

