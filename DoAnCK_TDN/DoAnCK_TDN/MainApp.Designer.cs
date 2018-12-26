namespace DoAnCK_TDN
{
    partial class MainApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainApp));
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Loading = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.radian1 = new DoAnCK_TDN.Radian();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MusicButton = new DoAnCK_TDN.CircleButton();
            this.VideoButton = new DoAnCK_TDN.CircleButton();
            this.AdminButton = new DoAnCK_TDN.CircleButton();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.circleButton1 = new DoAnCK_TDN.CircleButton();
            this.TraiNghiaLabel = new System.Windows.Forms.Label();
            this.NghiaLabel = new System.Windows.Forms.Label();
            this.DongNghiaLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBox = new System.Windows.Forms.ListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.radian1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(599, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Dịch Nghĩa Chi Tiết:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(164, 284);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 23);
            this.label5.TabIndex = 7;
            this.label5.Text = "Từ Trái Nghĩa:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(164, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Từ Đồng Nghĩa:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(220, 56);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(374, 359);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 33;
            this.pictureBox2.TabStop = false;
            // 
            // Loading
            // 
            this.Loading.Font = new System.Drawing.Font("Candara", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Loading.ForeColor = System.Drawing.Color.Green;
            this.Loading.Location = new System.Drawing.Point(326, 9);
            this.Loading.Name = "Loading";
            this.Loading.Size = new System.Drawing.Size(177, 56);
            this.Loading.TabIndex = 34;
            this.Loading.Text = "Loading...";
            this.Loading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.AutoEllipsis = true;
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Font = new System.Drawing.Font("Candara", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(168, 130);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 41);
            this.button1.TabIndex = 16;
            this.button1.Text = "Tìm Kiếm";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // radian1
            // 
            this.radian1.ColorButton = System.Drawing.Color.White;
            this.radian1.ColorTop = System.Drawing.Color.CornflowerBlue;
            this.radian1.Controls.Add(this.textBox1);
            this.radian1.Controls.Add(this.panel1);
            this.radian1.Controls.Add(this.circleButton1);
            this.radian1.Controls.Add(this.TraiNghiaLabel);
            this.radian1.Controls.Add(this.NghiaLabel);
            this.radian1.Controls.Add(this.DongNghiaLabel);
            this.radian1.Controls.Add(this.button1);
            this.radian1.Controls.Add(this.label9);
            this.radian1.Controls.Add(this.label8);
            this.radian1.Controls.Add(this.label10);
            this.radian1.Controls.Add(this.label11);
            this.radian1.Controls.Add(this.groupBox1);
            this.radian1.Location = new System.Drawing.Point(0, 0);
            this.radian1.Name = "radian1";
            this.radian1.Size = new System.Drawing.Size(816, 474);
            this.radian1.TabIndex = 32;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(169, 86);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox1.Size = new System.Drawing.Size(219, 38);
            this.textBox1.TabIndex = 33;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.MusicButton);
            this.panel1.Controls.Add(this.VideoButton);
            this.panel1.Controls.Add(this.AdminButton);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(816, 42);
            this.panel1.TabIndex = 32;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(53, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 23);
            this.label1.TabIndex = 33;
            this.label1.Text = "Long Ruồi Dictionary";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MusicButton
            // 
            this.MusicButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.MusicButton.FlatAppearance.BorderSize = 0;
            this.MusicButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MusicButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MusicButton.ForeColor = System.Drawing.Color.White;
            this.MusicButton.Location = new System.Drawing.Point(413, 3);
            this.MusicButton.Name = "MusicButton";
            this.MusicButton.Size = new System.Drawing.Size(109, 36);
            this.MusicButton.TabIndex = 23;
            this.MusicButton.Text = "&Nhạc";
            this.MusicButton.UseVisualStyleBackColor = false;
            this.MusicButton.Click += new System.EventHandler(this.MusicButton_Click);
            // 
            // VideoButton
            // 
            this.VideoButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.VideoButton.FlatAppearance.BorderSize = 0;
            this.VideoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VideoButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VideoButton.ForeColor = System.Drawing.Color.White;
            this.VideoButton.Location = new System.Drawing.Point(555, 3);
            this.VideoButton.Name = "VideoButton";
            this.VideoButton.Size = new System.Drawing.Size(109, 36);
            this.VideoButton.TabIndex = 23;
            this.VideoButton.Text = "&Videos";
            this.VideoButton.UseVisualStyleBackColor = false;
            this.VideoButton.Click += new System.EventHandler(this.VideoButton_Click);
            // 
            // AdminButton
            // 
            this.AdminButton.BackColor = System.Drawing.Color.Red;
            this.AdminButton.FlatAppearance.BorderSize = 0;
            this.AdminButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AdminButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminButton.ForeColor = System.Drawing.Color.White;
            this.AdminButton.Location = new System.Drawing.Point(269, 3);
            this.AdminButton.Name = "AdminButton";
            this.AdminButton.Size = new System.Drawing.Size(109, 36);
            this.AdminButton.TabIndex = 23;
            this.AdminButton.Text = "&Quản Lý";
            this.AdminButton.UseVisualStyleBackColor = false;
            this.AdminButton.Click += new System.EventHandler(this.AdminButton_Click);
            // 
            // button3
            // 
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(777, 9);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(27, 24);
            this.button3.TabIndex = 22;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.button2.Location = new System.Drawing.Point(745, 10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(26, 23);
            this.button2.TabIndex = 21;
            this.button2.Text = "_";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // circleButton1
            // 
            this.circleButton1.BackColor = System.Drawing.Color.White;
            this.circleButton1.FlatAppearance.BorderSize = 0;
            this.circleButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.circleButton1.Image = ((System.Drawing.Image)(resources.GetObject("circleButton1.Image")));
            this.circleButton1.Location = new System.Drawing.Point(396, 84);
            this.circleButton1.Name = "circleButton1";
            this.circleButton1.Size = new System.Drawing.Size(43, 40);
            this.circleButton1.TabIndex = 31;
            this.circleButton1.UseVisualStyleBackColor = false;
            this.circleButton1.Click += new System.EventHandler(this.circleButton1_Click);
            // 
            // TraiNghiaLabel
            // 
            this.TraiNghiaLabel.BackColor = System.Drawing.SystemColors.Window;
            this.TraiNghiaLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TraiNghiaLabel.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TraiNghiaLabel.Location = new System.Drawing.Point(168, 364);
            this.TraiNghiaLabel.Name = "TraiNghiaLabel";
            this.TraiNghiaLabel.Size = new System.Drawing.Size(278, 107);
            this.TraiNghiaLabel.TabIndex = 29;
            // 
            // NghiaLabel
            // 
            this.NghiaLabel.BackColor = System.Drawing.SystemColors.Window;
            this.NghiaLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NghiaLabel.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NghiaLabel.Location = new System.Drawing.Point(463, 84);
            this.NghiaLabel.Name = "NghiaLabel";
            this.NghiaLabel.Size = new System.Drawing.Size(341, 387);
            this.NghiaLabel.TabIndex = 30;
            // 
            // DongNghiaLabel
            // 
            this.DongNghiaLabel.BackColor = System.Drawing.SystemColors.Window;
            this.DongNghiaLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DongNghiaLabel.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DongNghiaLabel.Location = new System.Drawing.Point(169, 210);
            this.DongNghiaLabel.Name = "DongNghiaLabel";
            this.DongNghiaLabel.Size = new System.Drawing.Size(276, 107);
            this.DongNghiaLabel.TabIndex = 30;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Consolas", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label9.Location = new System.Drawing.Point(228, 337);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(159, 27);
            this.label9.TabIndex = 22;
            this.label9.Text = "TỪ TRÁI NGHĨA";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Candara", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label8.Location = new System.Drawing.Point(458, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(206, 24);
            this.label8.TabIndex = 21;
            this.label8.Text = "Dịch  Nghĩa  Chi  Tiết";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Consolas", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label10.Location = new System.Drawing.Point(229, 183);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(157, 27);
            this.label10.TabIndex = 23;
            this.label10.Text = "TỪ ĐỒNG NGHĨA";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Candara", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label11.Location = new System.Drawing.Point(164, 53);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(123, 30);
            this.label11.TabIndex = 24;
            this.label11.Text = "Từ  Cần  Tra:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.listBox);
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.groupBox1.Location = new System.Drawing.Point(12, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(141, 423);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Từ Đã Tra";
            // 
            // listBox
            // 
            this.listBox.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 19;
            this.listBox.Location = new System.Drawing.Point(3, 37);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(136, 384);
            this.listBox.TabIndex = 1;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 18;
            this.listBox1.Location = new System.Drawing.Point(3, 59);
            this.listBox1.Name = "listBox1";
            this.listBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listBox1.ScrollAlwaysVisible = true;
            this.listBox1.Size = new System.Drawing.Size(136, 256);
            this.listBox1.TabIndex = 0;
            // 
            // MainApp
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(816, 491);
            this.Controls.Add(this.radian1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Loading);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainApp";
            this.Load += new System.EventHandler(this.MainApp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.radian1.ResumeLayout(false);
            this.radian1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
       
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;        
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label DongNghiaLabel;
        private System.Windows.Forms.Label TraiNghiaLabel;
        private CircleButton circleButton1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private Radian radian1;
        private CircleButton MusicButton;
        private CircleButton VideoButton;
        private CircleButton AdminButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label NghiaLabel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label Loading;
    }
}