namespace EmployeeManagementSystem
{
    partial class GeneratePayRoll
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GeneratePayRoll));
            sideBarPanel = new System.Windows.Forms.Panel();
            btnNameDsc = new System.Windows.Forms.Button();
            btnNameAsc = new System.Windows.Forms.Button();
            panel3 = new System.Windows.Forms.Panel();
            lblMainMenu = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            sortByTotalWageDsc = new System.Windows.Forms.Button();
            sortByTotalWageAsc = new System.Windows.Forms.Button();
            logoPanel = new System.Windows.Forms.Panel();
            picBoxLogo = new System.Windows.Forms.PictureBox();
            lblLogo = new System.Windows.Forms.Label();
            headerPanel = new System.Windows.Forms.Panel();
            header = new System.Windows.Forms.Label();
            lblMinimize = new System.Windows.Forms.Label();
            lblClose = new System.Windows.Forms.Label();
            panel1 = new System.Windows.Forms.Panel();
            btnClose = new System.Windows.Forms.Button();
            panel2 = new System.Windows.Forms.Panel();
            payrollDataGridView = new System.Windows.Forms.DataGridView();
            FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            WageRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            workedHour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            TotalWage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            sideBarPanel.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            logoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBoxLogo).BeginInit();
            headerPanel.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)payrollDataGridView).BeginInit();
            SuspendLayout();
            // 
            // sideBarPanel
            // 
            sideBarPanel.BackColor = System.Drawing.Color.FromArgb(41, 53, 65);
            sideBarPanel.Controls.Add(btnNameDsc);
            sideBarPanel.Controls.Add(btnNameAsc);
            sideBarPanel.Controls.Add(panel3);
            sideBarPanel.Controls.Add(sortByTotalWageDsc);
            sideBarPanel.Controls.Add(sortByTotalWageAsc);
            sideBarPanel.Controls.Add(logoPanel);
            sideBarPanel.Dock = System.Windows.Forms.DockStyle.Left;
            sideBarPanel.Location = new System.Drawing.Point(0, 0);
            sideBarPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            sideBarPanel.Name = "sideBarPanel";
            sideBarPanel.Size = new System.Drawing.Size(205, 726);
            sideBarPanel.TabIndex = 1;
            sideBarPanel.MouseDown += OnMouseDown;
            sideBarPanel.MouseMove += OnMouseMove;
            sideBarPanel.MouseUp += OnMouseUp;
            // 
            // btnNameDsc
            // 
            btnNameDsc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            btnNameDsc.Cursor = System.Windows.Forms.Cursors.Hand;
            btnNameDsc.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(31, 43, 55);
            btnNameDsc.FlatAppearance.BorderSize = 0;
            btnNameDsc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnNameDsc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnNameDsc.ForeColor = System.Drawing.Color.White;
            btnNameDsc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnNameDsc.Location = new System.Drawing.Point(2, 318);
            btnNameDsc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            btnNameDsc.Name = "btnNameDsc";
            btnNameDsc.Size = new System.Drawing.Size(202, 52);
            btnNameDsc.TabIndex = 6;
            btnNameDsc.Text = "名字降序";
            btnNameDsc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnNameDsc.UseVisualStyleBackColor = true;
            btnNameDsc.Click += BtnNameDsc_Click;
            // 
            // btnNameAsc
            // 
            btnNameAsc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            btnNameAsc.Cursor = System.Windows.Forms.Cursors.Hand;
            btnNameAsc.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(31, 43, 55);
            btnNameAsc.FlatAppearance.BorderSize = 0;
            btnNameAsc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnNameAsc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnNameAsc.ForeColor = System.Drawing.Color.White;
            btnNameAsc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnNameAsc.Location = new System.Drawing.Point(2, 258);
            btnNameAsc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            btnNameAsc.Name = "btnNameAsc";
            btnNameAsc.Size = new System.Drawing.Size(202, 52);
            btnNameAsc.TabIndex = 5;
            btnNameAsc.Text = "名称升序";
            btnNameAsc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnNameAsc.UseVisualStyleBackColor = true;
            btnNameAsc.Click += BtnNameAsc_Click;
            // 
            // panel3
            // 
            panel3.BackColor = System.Drawing.Color.FromArgb(104, 104, 104);
            panel3.Controls.Add(lblMainMenu);
            panel3.Controls.Add(pictureBox1);
            panel3.Dock = System.Windows.Forms.DockStyle.Top;
            panel3.Location = new System.Drawing.Point(0, 69);
            panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(205, 60);
            panel3.TabIndex = 4;
            // 
            // lblMainMenu
            // 
            lblMainMenu.AutoSize = true;
            lblMainMenu.BackColor = System.Drawing.Color.FromArgb(104, 104, 104);
            lblMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblMainMenu.ForeColor = System.Drawing.Color.White;
            lblMainMenu.Location = new System.Drawing.Point(56, 9);
            lblMainMenu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblMainMenu.Name = "lblMainMenu";
            lblMainMenu.Size = new System.Drawing.Size(122, 31);
            lblMainMenu.TabIndex = 4;
            lblMainMenu.Text = "排序方式";
            lblMainMenu.MouseDown += OnMouseDown;
            lblMainMenu.MouseMove += OnMouseMove;
            lblMainMenu.MouseUp += OnMouseUp;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(4, 5);
            pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(50, 51);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.MouseDown += OnMouseDown;
            pictureBox1.MouseMove += OnMouseMove;
            pictureBox1.MouseUp += OnMouseUp;
            // 
            // sortByTotalWageDsc
            // 
            sortByTotalWageDsc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            sortByTotalWageDsc.Cursor = System.Windows.Forms.Cursors.Hand;
            sortByTotalWageDsc.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(31, 43, 55);
            sortByTotalWageDsc.FlatAppearance.BorderSize = 0;
            sortByTotalWageDsc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            sortByTotalWageDsc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            sortByTotalWageDsc.ForeColor = System.Drawing.Color.White;
            sortByTotalWageDsc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            sortByTotalWageDsc.Location = new System.Drawing.Point(2, 197);
            sortByTotalWageDsc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            sortByTotalWageDsc.Name = "sortByTotalWageDsc";
            sortByTotalWageDsc.Size = new System.Drawing.Size(202, 52);
            sortByTotalWageDsc.TabIndex = 2;
            sortByTotalWageDsc.Text = "总工资差值";
            sortByTotalWageDsc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            sortByTotalWageDsc.UseVisualStyleBackColor = true;
            sortByTotalWageDsc.Click += SortByTotalWageDsc_Click;
            sortByTotalWageDsc.MouseDown += OnMouseDown;
            sortByTotalWageDsc.MouseMove += OnMouseMove;
            sortByTotalWageDsc.MouseUp += OnMouseUp;
            // 
            // sortByTotalWageAsc
            // 
            sortByTotalWageAsc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            sortByTotalWageAsc.Cursor = System.Windows.Forms.Cursors.Hand;
            sortByTotalWageAsc.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(31, 43, 55);
            sortByTotalWageAsc.FlatAppearance.BorderSize = 0;
            sortByTotalWageAsc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            sortByTotalWageAsc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            sortByTotalWageAsc.ForeColor = System.Drawing.Color.White;
            sortByTotalWageAsc.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            sortByTotalWageAsc.Location = new System.Drawing.Point(2, 137);
            sortByTotalWageAsc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            sortByTotalWageAsc.Name = "sortByTotalWageAsc";
            sortByTotalWageAsc.Size = new System.Drawing.Size(202, 52);
            sortByTotalWageAsc.TabIndex = 1;
            sortByTotalWageAsc.Text = "工资总额";
            sortByTotalWageAsc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            sortByTotalWageAsc.UseVisualStyleBackColor = true;
            sortByTotalWageAsc.Click += SortByTotalWageAsc_Click;
            sortByTotalWageAsc.MouseDown += OnMouseDown;
            sortByTotalWageAsc.MouseMove += OnMouseMove;
            sortByTotalWageAsc.MouseUp += OnMouseUp;
            // 
            // logoPanel
            // 
            logoPanel.BackColor = System.Drawing.Color.FromArgb(222, 120, 53);
            logoPanel.Controls.Add(picBoxLogo);
            logoPanel.Controls.Add(lblLogo);
            logoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            logoPanel.Location = new System.Drawing.Point(0, 0);
            logoPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            logoPanel.Name = "logoPanel";
            logoPanel.Size = new System.Drawing.Size(205, 69);
            logoPanel.TabIndex = 0;
            logoPanel.MouseDown += OnMouseDown;
            logoPanel.MouseMove += OnMouseMove;
            logoPanel.MouseUp += OnMouseUp;
            // 
            // picBoxLogo
            // 
            picBoxLogo.Image = (System.Drawing.Image)resources.GetObject("picBoxLogo.Image");
            picBoxLogo.Location = new System.Drawing.Point(4, 1);
            picBoxLogo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            picBoxLogo.Name = "picBoxLogo";
            picBoxLogo.Size = new System.Drawing.Size(70, 65);
            picBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            picBoxLogo.TabIndex = 1;
            picBoxLogo.TabStop = false;
            picBoxLogo.MouseDown += OnMouseDown;
            picBoxLogo.MouseMove += OnMouseMove;
            picBoxLogo.MouseUp += OnMouseUp;
            // 
            // lblLogo
            // 
            lblLogo.AutoSize = true;
            lblLogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblLogo.ForeColor = System.Drawing.Color.White;
            lblLogo.Location = new System.Drawing.Point(78, 10);
            lblLogo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new System.Drawing.Size(80, 33);
            lblLogo.TabIndex = 0;
            lblLogo.Text = "EMS";
            lblLogo.MouseDown += OnMouseDown;
            lblLogo.MouseMove += OnMouseMove;
            lblLogo.MouseUp += OnMouseUp;
            // 
            // headerPanel
            // 
            headerPanel.BackColor = System.Drawing.Color.White;
            headerPanel.Controls.Add(header);
            headerPanel.Controls.Add(lblMinimize);
            headerPanel.Controls.Add(lblClose);
            headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            headerPanel.Location = new System.Drawing.Point(205, 0);
            headerPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            headerPanel.Name = "headerPanel";
            headerPanel.Size = new System.Drawing.Size(1221, 69);
            headerPanel.TabIndex = 2;
            headerPanel.MouseDown += OnMouseDown;
            headerPanel.MouseMove += OnMouseMove;
            headerPanel.MouseUp += OnMouseUp;
            // 
            // header
            // 
            header.AutoSize = true;
            header.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            header.ForeColor = System.Drawing.Color.FromArgb(31, 43, 55);
            header.Location = new System.Drawing.Point(267, 10);
            header.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            header.Name = "header";
            header.Size = new System.Drawing.Size(641, 33);
            header.TabIndex = 2;
            header.Text = "Employee Management System (Payroll Report)";
            header.MouseDown += OnMouseDown;
            header.MouseMove += OnMouseMove;
            header.MouseUp += OnMouseUp;
            // 
            // lblMinimize
            // 
            lblMinimize.AutoSize = true;
            lblMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            lblMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblMinimize.Location = new System.Drawing.Point(1161, 4);
            lblMinimize.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblMinimize.Name = "lblMinimize";
            lblMinimize.Size = new System.Drawing.Size(19, 25);
            lblMinimize.TabIndex = 1;
            lblMinimize.Text = "-";
            lblMinimize.Click += LblMinimize_Click;
            lblMinimize.MouseDown += OnMouseDown;
            lblMinimize.MouseMove += OnMouseMove;
            lblMinimize.MouseUp += OnMouseUp;
            // 
            // lblClose
            // 
            lblClose.AutoSize = true;
            lblClose.Cursor = System.Windows.Forms.Cursors.Hand;
            lblClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblClose.Location = new System.Drawing.Point(1188, 4);
            lblClose.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblClose.Name = "lblClose";
            lblClose.Size = new System.Drawing.Size(23, 25);
            lblClose.TabIndex = 0;
            lblClose.Text = "x";
            lblClose.Click += LblClose_Click;
            lblClose.MouseDown += OnMouseDown;
            lblClose.MouseMove += OnMouseMove;
            lblClose.MouseUp += OnMouseUp;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnClose);
            panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel1.Location = new System.Drawing.Point(205, 595);
            panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1221, 131);
            panel1.TabIndex = 3;
            panel1.MouseDown += OnMouseDown;
            panel1.MouseMove += OnMouseMove;
            panel1.MouseUp += OnMouseUp;
            // 
            // btnClose
            // 
            btnClose.BackColor = System.Drawing.Color.FromArgb(201, 48, 44);
            btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(31, 43, 55);
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnClose.ForeColor = System.Drawing.Color.White;
            btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnClose.Location = new System.Drawing.Point(1065, 48);
            btnClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            btnClose.Name = "btnClose";
            btnClose.Size = new System.Drawing.Size(140, 52);
            btnClose.TabIndex = 6;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += BtnClose_Click;
            btnClose.MouseDown += OnMouseDown;
            btnClose.MouseMove += OnMouseMove;
            btnClose.MouseUp += OnMouseUp;
            // 
            // panel2
            // 
            panel2.Controls.Add(payrollDataGridView);
            panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            panel2.Location = new System.Drawing.Point(205, 69);
            panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(1221, 526);
            panel2.TabIndex = 4;
            // 
            // payrollDataGridView
            // 
            payrollDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            payrollDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            payrollDataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            payrollDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            payrollDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            payrollDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { FullName, Department, WageRate, workedHour, TotalWage });
            payrollDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            payrollDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            payrollDataGridView.ImeMode = System.Windows.Forms.ImeMode.Off;
            payrollDataGridView.Location = new System.Drawing.Point(0, 0);
            payrollDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            payrollDataGridView.Name = "payrollDataGridView";
            payrollDataGridView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            payrollDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            payrollDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            payrollDataGridView.Size = new System.Drawing.Size(1221, 526);
            payrollDataGridView.TabIndex = 5;
            payrollDataGridView.MouseDown += OnMouseDown;
            payrollDataGridView.MouseMove += OnMouseMove;
            payrollDataGridView.MouseUp += OnMouseUp;
            // 
            // FullName
            // 
            FullName.FillWeight = 83.94669F;
            FullName.HeaderText = "姓名";
            FullName.Name = "FullName";
            // 
            // Department
            // 
            Department.FillWeight = 83.94669F;
            Department.HeaderText = "部门";
            Department.Name = "Department";
            // 
            // WageRate
            // 
            WageRate.FillWeight = 83.94669F;
            WageRate.HeaderText = "工资率";
            WageRate.Name = "WageRate";
            // 
            // workedHour
            // 
            workedHour.HeaderText = "工龄";
            workedHour.Name = "workedHour";
            // 
            // TotalWage
            // 
            TotalWage.HeaderText = "总工资";
            TotalWage.Name = "TotalWage";
            // 
            // GeneratePayRoll
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1426, 726);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(headerPanel);
            Controls.Add(sideBarPanel);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            Name = "GeneratePayRoll";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "GeneratePayRoll";
            sideBarPanel.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            logoPanel.ResumeLayout(false);
            logoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picBoxLogo).EndInit();
            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)payrollDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel sideBarPanel;
        private System.Windows.Forms.Button sortByTotalWageDsc;
        private System.Windows.Forms.Button sortByTotalWageAsc;
        private System.Windows.Forms.Panel logoPanel;
        private System.Windows.Forms.PictureBox picBoxLogo;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label header;
        private System.Windows.Forms.Label lblMinimize;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView payrollDataGridView;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblMainMenu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnNameAsc;
        private System.Windows.Forms.Button btnNameDsc;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Department;
        private System.Windows.Forms.DataGridViewTextBoxColumn WageRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn workedHour;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalWage;
    }
}