namespace SpaShop.Entity.Quanli.LichHen
{
    partial class ThoiGian
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ThoiGiandata = new System.Windows.Forms.DataGridView();
            this.Vitricho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Today = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayMai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngaymot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ThoiGiandata)).BeginInit();
            this.SuspendLayout();
            // 
            // ThoiGiandata
            // 
            this.ThoiGiandata.BackgroundColor = System.Drawing.Color.White;
            this.ThoiGiandata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ThoiGiandata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Vitricho,
            this.Today,
            this.NgayMai,
            this.Ngaymot});
            this.ThoiGiandata.Location = new System.Drawing.Point(3, 3);
            this.ThoiGiandata.Name = "ThoiGiandata";
            this.ThoiGiandata.Size = new System.Drawing.Size(728, 561);
            this.ThoiGiandata.TabIndex = 0;
            this.ThoiGiandata.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Vitricho
            // 
            this.Vitricho.FillWeight = 150F;
            this.Vitricho.HeaderText = "Vị trí chỗ";
            this.Vitricho.Name = "Vitricho";
            this.Vitricho.ReadOnly = true;
            this.Vitricho.Width = 150;
            // 
            // Today
            // 
            this.Today.HeaderText = "Column1";
            this.Today.Name = "Today";
            this.Today.Width = 150;
            // 
            // NgayMai
            // 
            this.NgayMai.HeaderText = "Column1";
            this.NgayMai.Name = "NgayMai";
            this.NgayMai.Width = 150;
            // 
            // Ngaymot
            // 
            this.Ngaymot.HeaderText = "Column1";
            this.Ngaymot.Name = "Ngaymot";
            this.Ngaymot.Width = 150;
            // 
            // ThoiGian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ThoiGiandata);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "ThoiGian";
            this.Size = new System.Drawing.Size(734, 567);
            ((System.ComponentModel.ISupportInitialize)(this.ThoiGiandata)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ThoiGiandata;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vitricho;
        private System.Windows.Forms.DataGridViewTextBoxColumn Today;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayMai;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngaymot;
    }
}
