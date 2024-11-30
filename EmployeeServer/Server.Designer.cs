namespace EmployeeServer
{
    partial class Server
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            ChatList = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label2 = new Label();
            label3 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("宋体", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(29, 46);
            label1.Name = "label1";
            label1.Size = new Size(96, 12);
            label1.TabIndex = 0;
            label1.Text = "在线用户数量：";
            // 
            // ChatList
            // 
            ChatList.Location = new Point(18, 84);
            ChatList.Multiline = true;
            ChatList.Name = "ChatList";
            ChatList.ScrollBars = ScrollBars.Both;
            ChatList.Size = new Size(266, 78);
            ChatList.TabIndex = 3;
            ChatList.TextChanged += textBox1_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(119, 16);
            label4.Name = "label4";
            label4.Size = new Size(0, 17);
            label4.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(119, 41);
            label5.Name = "label5";
            label5.Size = new Size(0, 17);
            label5.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("宋体", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(29, 21);
            label6.Name = "label6";
            label6.Size = new Size(70, 12);
            label6.TabIndex = 6;
            label6.Text = "启动时间：";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("宋体", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(29, 69);
            label2.Name = "label2";
            label2.Size = new Size(93, 12);
            label2.TabIndex = 7;
            label2.Text = "WinFrom端口：";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(119, 64);
            label3.Name = "label3";
            label3.Size = new Size(36, 17);
            label3.TabIndex = 8;
            label3.Text = "8094";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(131, 43);
            label7.Name = "label7";
            label7.Size = new Size(15, 17);
            label7.TabIndex = 9;
            label7.Text = "0";
            // 
            // Server
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(296, 169);
            Controls.Add(label7);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(ChatList);
            Controls.Add(label1);
            Name = "Server";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox ChatList;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label2;
        private Label label3;
        private Label label7;
    }
}
