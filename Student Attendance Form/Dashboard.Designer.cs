
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.label1 = new System.Windows.Forms.Label();
            this.panel_SideBig = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.panel_UserInfo = new System.Windows.Forms.Panel();
            this.label_UserName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_SideBig.SuspendLayout();
            this.panel_UserInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.panel_SideBig.BackColor = System.Drawing.Color.Gray;
            this.panel_SideBig.Controls.Add(this.iconButton1);
            this.panel_SideBig.Controls.Add(this.panel_UserInfo);
            this.panel_SideBig.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_SideBig.Location = new System.Drawing.Point(0, 0);
            this.panel_SideBig.Name = "panel_SideBig";
            this.panel_SideBig.Size = new System.Drawing.Size(228, 600);
            this.panel_SideBig.TabIndex = 1;
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.SystemColors.GrayText;
            this.iconButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(0, 155);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(228, 53);
            this.iconButton1.TabIndex = 1;
            this.iconButton1.Text = "iconButton1";
            this.iconButton1.UseVisualStyleBackColor = false;
            // 
            // panel_UserInfo
            // 
            this.panel_UserInfo.Controls.Add(this.label_UserName);
            this.panel_UserInfo.Controls.Add(this.pictureBox1);
            this.panel_UserInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_UserInfo.Location = new System.Drawing.Point(0, 0);
            this.panel_UserInfo.Name = "panel_UserInfo";
            this.panel_UserInfo.Size = new System.Drawing.Size(228, 155);
            this.panel_UserInfo.TabIndex = 0;
            // 
            // label_UserName
            // 
            this.label_UserName.AutoSize = true;
            this.label_UserName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_UserName.Location = new System.Drawing.Point(75, 107);
            this.label_UserName.Name = "label_UserName";
            this.label_UserName.Size = new System.Drawing.Size(81, 21);
            this.label_UserName.TabIndex = 1;
            this.label_UserName.Text = "Username";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(71, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 600);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_SideBig;
        private System.Windows.Forms.Panel panel_UserInfo;
        private System.Windows.Forms.Label label_UserName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}