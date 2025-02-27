namespace SpaShop
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.TenDangNhapTb = new System.Windows.Forms.TextBox();
            this.TenDangNhaplb = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.MatKhaulb = new System.Windows.Forms.Label();
            this.MatKhauTb = new System.Windows.Forms.TextBox();
            this.DangNhapBT = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ThoatBT = new System.Windows.Forms.Button();
            this.NhoKhonglb = new System.Windows.Forms.Label();
            this.TimMKLb = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.TenDangNhaplb);
            this.panel1.Controls.Add(this.TenDangNhapTb);
            this.panel1.Location = new System.Drawing.Point(149, 111);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(467, 102);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // TenDangNhapTb
            // 
            this.TenDangNhapTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TenDangNhapTb.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenDangNhapTb.Location = new System.Drawing.Point(19, 50);
            this.TenDangNhapTb.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.TenDangNhapTb.Name = "TenDangNhapTb";
            this.TenDangNhapTb.Size = new System.Drawing.Size(437, 29);
            this.TenDangNhapTb.TabIndex = 0;
            this.TenDangNhapTb.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TenDangNhaplb
            // 
            this.TenDangNhaplb.AutoSize = true;
            this.TenDangNhaplb.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenDangNhaplb.ForeColor = System.Drawing.Color.Black;
            this.TenDangNhaplb.Location = new System.Drawing.Point(15, 15);
            this.TenDangNhaplb.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.TenDangNhaplb.Name = "TenDangNhaplb";
            this.TenDangNhaplb.Size = new System.Drawing.Size(121, 21);
            this.TenDangNhaplb.TabIndex = 1;
            this.TenDangNhaplb.Text = "Tên đăng nhập";
            this.TenDangNhaplb.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.MatKhaulb);
            this.panel2.Controls.Add(this.MatKhauTb);
            this.panel2.Location = new System.Drawing.Point(149, 223);
            this.panel2.Margin = new System.Windows.Forms.Padding(5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(467, 102);
            this.panel2.TabIndex = 2;
            // 
            // MatKhaulb
            // 
            this.MatKhaulb.AutoSize = true;
            this.MatKhaulb.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MatKhaulb.Location = new System.Drawing.Point(16, 15);
            this.MatKhaulb.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.MatKhaulb.Name = "MatKhaulb";
            this.MatKhaulb.Size = new System.Drawing.Size(83, 21);
            this.MatKhaulb.TabIndex = 1;
            this.MatKhaulb.Text = "Mật Khẩu";
            // 
            // MatKhauTb
            // 
            this.MatKhauTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MatKhauTb.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MatKhauTb.Location = new System.Drawing.Point(20, 50);
            this.MatKhauTb.Margin = new System.Windows.Forms.Padding(5);
            this.MatKhauTb.Name = "MatKhauTb";
            this.MatKhauTb.PasswordChar = '*';
            this.MatKhauTb.Size = new System.Drawing.Size(437, 29);
            this.MatKhauTb.TabIndex = 0;
            // 
            // DangNhapBT
            // 
            this.DangNhapBT.Location = new System.Drawing.Point(75, 3);
            this.DangNhapBT.Name = "DangNhapBT";
            this.DangNhapBT.Size = new System.Drawing.Size(122, 47);
            this.DangNhapBT.TabIndex = 3;
            this.DangNhapBT.Text = "Đăng nhập";
            this.DangNhapBT.UseVisualStyleBackColor = true;
            this.DangNhapBT.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.TimMKLb);
            this.panel3.Controls.Add(this.NhoKhonglb);
            this.panel3.Controls.Add(this.ThoatBT);
            this.panel3.Controls.Add(this.DangNhapBT);
            this.panel3.Location = new System.Drawing.Point(149, 335);
            this.panel3.Margin = new System.Windows.Forms.Padding(5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(467, 102);
            this.panel3.TabIndex = 4;
            // 
            // ThoatBT
            // 
            this.ThoatBT.Location = new System.Drawing.Point(281, 3);
            this.ThoatBT.Name = "ThoatBT";
            this.ThoatBT.Size = new System.Drawing.Size(122, 47);
            this.ThoatBT.TabIndex = 5;
            this.ThoatBT.Text = "Thoát";
            this.ThoatBT.UseVisualStyleBackColor = true;
            this.ThoatBT.Click += new System.EventHandler(this.ThoatBT_Click);
            // 
            // NhoKhonglb
            // 
            this.NhoKhonglb.AutoSize = true;
            this.NhoKhonglb.Location = new System.Drawing.Point(34, 67);
            this.NhoKhonglb.Name = "NhoKhonglb";
            this.NhoKhonglb.Size = new System.Drawing.Size(237, 21);
            this.NhoKhonglb.TabIndex = 6;
            this.NhoKhonglb.Text = "Nếu bạn không nhớ mật khẩu :";
            // 
            // TimMKLb
            // 
            this.TimMKLb.AutoSize = true;
            this.TimMKLb.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimMKLb.Location = new System.Drawing.Point(277, 67);
            this.TimMKLb.Name = "TimMKLb";
            this.TimMKLb.Size = new System.Drawing.Size(114, 21);
            this.TimMKLb.TabIndex = 8;
            this.TimMKLb.Text = "Tìm mật khẩu";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(783, 523);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Nhập";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TenDangNhapTb;
        private System.Windows.Forms.Label TenDangNhaplb;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label MatKhaulb;
        private System.Windows.Forms.TextBox MatKhauTb;
        private System.Windows.Forms.Button DangNhapBT;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button ThoatBT;
        private System.Windows.Forms.Label NhoKhonglb;
        private System.Windows.Forms.Label TimMKLb;
    }
}

