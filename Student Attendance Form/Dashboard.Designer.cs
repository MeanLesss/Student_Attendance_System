
namespace Student_Attendance_Form
{
    partial class Dashboard
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_SideBig = new System.Windows.Forms.Panel();
            this.iconButton_ResetPassword = new FontAwesome.Sharp.IconButton();
            this.iconButton_SignOut = new FontAwesome.Sharp.IconButton();
            this.iconButton_Attendancee = new FontAwesome.Sharp.IconButton();
            this.panel_UserInfo = new System.Windows.Forms.Panel();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.label_UserName = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel_DataGrid = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_Session = new System.Windows.Forms.ComboBox();
            this.comboBox_Subject = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.noDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.avatarDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.remarkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel_SideBig.SuspendLayout();
            this.panel_UserInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.panel_DataGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(860, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel_SideBig
            // 
            this.panel_SideBig.BackColor = System.Drawing.Color.LightGray;
            this.panel_SideBig.Controls.Add(this.iconButton_ResetPassword);
            this.panel_SideBig.Controls.Add(this.iconButton_SignOut);
            this.panel_SideBig.Controls.Add(this.iconButton_Attendancee);
            this.panel_SideBig.Controls.Add(this.panel_UserInfo);
            this.panel_SideBig.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_SideBig.Location = new System.Drawing.Point(0, 0);
            this.panel_SideBig.Name = "panel_SideBig";
            this.panel_SideBig.Size = new System.Drawing.Size(228, 600);
            this.panel_SideBig.TabIndex = 1;
            // 
            // iconButton_ResetPassword
            // 
            this.iconButton_ResetPassword.BackColor = System.Drawing.Color.LightGray;
            this.iconButton_ResetPassword.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton_ResetPassword.FlatAppearance.BorderSize = 0;
            this.iconButton_ResetPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton_ResetPassword.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconButton_ResetPassword.IconChar = FontAwesome.Sharp.IconChar.Cogs;
            this.iconButton_ResetPassword.IconColor = System.Drawing.Color.DarkSlateGray;
            this.iconButton_ResetPassword.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton_ResetPassword.IconSize = 35;
            this.iconButton_ResetPassword.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton_ResetPassword.Location = new System.Drawing.Point(0, 208);
            this.iconButton_ResetPassword.Name = "iconButton_ResetPassword";
            this.iconButton_ResetPassword.Size = new System.Drawing.Size(228, 53);
            this.iconButton_ResetPassword.TabIndex = 3;
            this.iconButton_ResetPassword.Text = "Reset password";
            this.iconButton_ResetPassword.UseVisualStyleBackColor = false;
            // 
            // iconButton_SignOut
            // 
            this.iconButton_SignOut.BackColor = System.Drawing.SystemColors.GrayText;
            this.iconButton_SignOut.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.iconButton_SignOut.FlatAppearance.BorderSize = 0;
            this.iconButton_SignOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton_SignOut.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconButton_SignOut.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.iconButton_SignOut.IconColor = System.Drawing.Color.DarkSlateGray;
            this.iconButton_SignOut.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton_SignOut.IconSize = 35;
            this.iconButton_SignOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton_SignOut.Location = new System.Drawing.Point(0, 564);
            this.iconButton_SignOut.Name = "iconButton_SignOut";
            this.iconButton_SignOut.Size = new System.Drawing.Size(228, 36);
            this.iconButton_SignOut.TabIndex = 2;
            this.iconButton_SignOut.Text = "Sign out";
            this.iconButton_SignOut.UseVisualStyleBackColor = false;
            // 
            // iconButton_Attendancee
            // 
            this.iconButton_Attendancee.BackColor = System.Drawing.Color.LightGray;
            this.iconButton_Attendancee.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton_Attendancee.FlatAppearance.BorderSize = 0;
            this.iconButton_Attendancee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton_Attendancee.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconButton_Attendancee.IconChar = FontAwesome.Sharp.IconChar.Clipboard;
            this.iconButton_Attendancee.IconColor = System.Drawing.Color.DarkSlateGray;
            this.iconButton_Attendancee.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton_Attendancee.IconSize = 35;
            this.iconButton_Attendancee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton_Attendancee.Location = new System.Drawing.Point(0, 155);
            this.iconButton_Attendancee.Name = "iconButton_Attendancee";
            this.iconButton_Attendancee.Size = new System.Drawing.Size(228, 53);
            this.iconButton_Attendancee.TabIndex = 1;
            this.iconButton_Attendancee.Text = "Attendance";
            this.iconButton_Attendancee.UseVisualStyleBackColor = false;
            // 
            // panel_UserInfo
            // 
            this.panel_UserInfo.BackColor = System.Drawing.SystemColors.GrayText;
            this.panel_UserInfo.Controls.Add(this.iconPictureBox1);
            this.panel_UserInfo.Controls.Add(this.label_UserName);
            this.panel_UserInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_UserInfo.Location = new System.Drawing.Point(0, 0);
            this.panel_UserInfo.Name = "panel_UserInfo";
            this.panel_UserInfo.Size = new System.Drawing.Size(228, 155);
            this.panel_UserInfo.TabIndex = 0;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.iconPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.iconPictureBox1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.UserTie;
            this.iconPictureBox1.IconColor = System.Drawing.Color.DarkSlateGray;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 78;
            this.iconPictureBox1.Location = new System.Drawing.Point(78, 26);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(78, 78);
            this.iconPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconPictureBox1.TabIndex = 2;
            this.iconPictureBox1.TabStop = false;
            // 
            // label_UserName
            // 
            this.label_UserName.AutoSize = true;
            this.label_UserName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_UserName.Location = new System.Drawing.Point(75, 107);
            this.label_UserName.Name = "label_UserName";
            this.label_UserName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label_UserName.Size = new System.Drawing.Size(81, 21);
            this.label_UserName.TabIndex = 1;
            this.label_UserName.Text = "Username";
            this.label_UserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(Student_Attendance_Form.Attendance);
            // 
            // panel_DataGrid
            // 
            this.panel_DataGrid.Controls.Add(this.dataGridView1);
            this.panel_DataGrid.Controls.Add(this.panel1);
            this.panel_DataGrid.Location = new System.Drawing.Point(229, 44);
            this.panel_DataGrid.Name = "panel_DataGrid";
            this.panel_DataGrid.Size = new System.Drawing.Size(672, 555);
            this.panel_DataGrid.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.noDataGridViewTextBoxColumn,
            this.avatarDataGridViewImageColumn,
            this.nameDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.remarkDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bindingSource1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 111);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(672, 444);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.ataGridView1_CellValueChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GrayText;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.comboBox_Session);
            this.panel1.Controls.Add(this.comboBox_Subject);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(672, 111);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(427, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Session";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(182, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Subject";
            // 
            // comboBox_Session
            // 
            this.comboBox_Session.FormattingEnabled = true;
            this.comboBox_Session.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.comboBox_Session.Location = new System.Drawing.Point(427, 51);
            this.comboBox_Session.Name = "comboBox_Session";
            this.comboBox_Session.Size = new System.Drawing.Size(121, 23);
            this.comboBox_Session.TabIndex = 7;
            // 
            // comboBox_Subject
            // 
            this.comboBox_Subject.FormattingEnabled = true;
            this.comboBox_Subject.Items.AddRange(new object[] {
            "C#",
            "C++",
            "HTML",
            "CSS",
            "WPF",
            "WINFORM"});
            this.comboBox_Subject.Location = new System.Drawing.Point(32, 51);
            this.comboBox_Subject.Name = "comboBox_Subject";
            this.comboBox_Subject.Size = new System.Drawing.Size(121, 23);
            this.comboBox_Subject.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(570, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(182, 51);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(219, 23);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // noDataGridViewTextBoxColumn
            // 
            this.noDataGridViewTextBoxColumn.DataPropertyName = "No";
            this.noDataGridViewTextBoxColumn.Frozen = true;
            this.noDataGridViewTextBoxColumn.HeaderText = "No";
            this.noDataGridViewTextBoxColumn.Name = "noDataGridViewTextBoxColumn";
            this.noDataGridViewTextBoxColumn.Width = 50;
            // 
            // avatarDataGridViewImageColumn
            // 
            this.avatarDataGridViewImageColumn.DataPropertyName = "Avatar";
            this.avatarDataGridViewImageColumn.Frozen = true;
            this.avatarDataGridViewImageColumn.HeaderText = "Avatar";
            this.avatarDataGridViewImageColumn.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.avatarDataGridViewImageColumn.Name = "avatarDataGridViewImageColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.Frozen = true;
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 200;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.statusDataGridViewTextBoxColumn.DisplayStyleForCurrentCellOnly = true;
            this.statusDataGridViewTextBoxColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Items.AddRange(new object[] {
            "Present",
            "Late",
            "Absent"});
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // remarkDataGridViewTextBoxColumn
            // 
            this.remarkDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.remarkDataGridViewTextBoxColumn.DataPropertyName = "Remark";
            this.remarkDataGridViewTextBoxColumn.HeaderText = "Remark";
            this.remarkDataGridViewTextBoxColumn.Name = "remarkDataGridViewTextBoxColumn";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.panel_DataGrid);
            this.Controls.Add(this.panel_SideBig);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel_SideBig.ResumeLayout(false);
            this.panel_UserInfo.ResumeLayout(false);
            this.panel_UserInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.panel_DataGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_SideBig;
        private System.Windows.Forms.Panel panel_UserInfo;
        private System.Windows.Forms.Label label_UserName;
        private FontAwesome.Sharp.IconButton iconButton_Attendancee;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Panel panel_DataGrid;
        private FontAwesome.Sharp.IconButton iconButton_SignOut;
        private FontAwesome.Sharp.IconButton iconButton_ResetPassword;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox_Subject;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox_Session;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn noDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn avatarDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remarkDataGridViewTextBoxColumn;
    }
}