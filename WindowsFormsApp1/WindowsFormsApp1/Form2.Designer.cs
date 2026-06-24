namespace WindowsFormsApp1
{
    partial class Form2
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbMaHD = new System.Windows.Forms.Label();
            this.lbTenKH = new System.Windows.Forms.Label();
            this.lbNgayBan = new System.Windows.Forms.Label();
            this.lbMauSac = new System.Windows.Forms.Label();
            this.lbSoLuong = new System.Windows.Forms.Label();
            this.lbDonGia = new System.Windows.Forms.Label();
            this.lbTenDT = new System.Windows.Forms.Label();
            this.txtbMaHD = new System.Windows.Forms.TextBox();
            this.txtbTenKH = new System.Windows.Forms.TextBox();
            this.txtbTenDT = new System.Windows.Forms.TextBox();
            this.txtbDonGia = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.rdbDen = new System.Windows.Forms.RadioButton();
            this.rdbMauKhac = new System.Windows.Forms.RadioButton();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btThem = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btDong = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.Untitled;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 138);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApp1.Properties.Resources.Untitled1;
            this.pictureBox2.Location = new System.Drawing.Point(118, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 138);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // lbMaHD
            // 
            this.lbMaHD.AutoSize = true;
            this.lbMaHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaHD.Location = new System.Drawing.Point(543, 65);
            this.lbMaHD.Name = "lbMaHD";
            this.lbMaHD.Size = new System.Drawing.Size(63, 20);
            this.lbMaHD.TabIndex = 2;
            this.lbMaHD.Text = "Mã HD";
            // 
            // lbTenKH
            // 
            this.lbTenKH.AutoSize = true;
            this.lbTenKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenKH.Location = new System.Drawing.Point(543, 103);
            this.lbTenKH.Name = "lbTenKH";
            this.lbTenKH.Size = new System.Drawing.Size(66, 20);
            this.lbTenKH.TabIndex = 3;
            this.lbTenKH.Text = "Tên KH";
            // 
            // lbNgayBan
            // 
            this.lbNgayBan.AutoSize = true;
            this.lbNgayBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgayBan.Location = new System.Drawing.Point(543, 140);
            this.lbNgayBan.Name = "lbNgayBan";
            this.lbNgayBan.Size = new System.Drawing.Size(79, 20);
            this.lbNgayBan.TabIndex = 4;
            this.lbNgayBan.Text = "Ngày bán";
            // 
            // lbMauSac
            // 
            this.lbMauSac.AutoSize = true;
            this.lbMauSac.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMauSac.Location = new System.Drawing.Point(543, 184);
            this.lbMauSac.Name = "lbMauSac";
            this.lbMauSac.Size = new System.Drawing.Size(73, 20);
            this.lbMauSac.TabIndex = 5;
            this.lbMauSac.Text = "Màu sắc";
            // 
            // lbSoLuong
            // 
            this.lbSoLuong.AutoSize = true;
            this.lbSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoLuong.Location = new System.Drawing.Point(543, 222);
            this.lbSoLuong.Name = "lbSoLuong";
            this.lbSoLuong.Size = new System.Drawing.Size(74, 20);
            this.lbSoLuong.TabIndex = 6;
            this.lbSoLuong.Text = "Số lượng";
            // 
            // lbDonGia
            // 
            this.lbDonGia.AutoSize = true;
            this.lbDonGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDonGia.Location = new System.Drawing.Point(78, 222);
            this.lbDonGia.Name = "lbDonGia";
            this.lbDonGia.Size = new System.Drawing.Size(66, 20);
            this.lbDonGia.TabIndex = 7;
            this.lbDonGia.Text = "Đơn giá";
            // 
            // lbTenDT
            // 
            this.lbTenDT.AutoSize = true;
            this.lbTenDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenDT.Location = new System.Drawing.Point(78, 184);
            this.lbTenDT.Name = "lbTenDT";
            this.lbTenDT.Size = new System.Drawing.Size(64, 20);
            this.lbTenDT.TabIndex = 8;
            this.lbTenDT.Text = "Tên ĐT";
            // 
            // txtbMaHD
            // 
            this.txtbMaHD.Location = new System.Drawing.Point(642, 63);
            this.txtbMaHD.Name = "txtbMaHD";
            this.txtbMaHD.Size = new System.Drawing.Size(240, 22);
            this.txtbMaHD.TabIndex = 9;
            // 
            // txtbTenKH
            // 
            this.txtbTenKH.Location = new System.Drawing.Point(642, 103);
            this.txtbTenKH.Name = "txtbTenKH";
            this.txtbTenKH.Size = new System.Drawing.Size(240, 22);
            this.txtbTenKH.TabIndex = 10;
            // 
            // txtbTenDT
            // 
            this.txtbTenDT.Location = new System.Drawing.Point(159, 184);
            this.txtbTenDT.Name = "txtbTenDT";
            this.txtbTenDT.Size = new System.Drawing.Size(240, 22);
            this.txtbTenDT.TabIndex = 11;
            // 
            // txtbDonGia
            // 
            this.txtbDonGia.Location = new System.Drawing.Point(159, 222);
            this.txtbDonGia.Name = "txtbDonGia";
            this.txtbDonGia.Size = new System.Drawing.Size(240, 22);
            this.txtbDonGia.TabIndex = 12;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(642, 137);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(240, 22);
            this.dateTimePicker1.TabIndex = 13;
            // 
            // rdbDen
            // 
            this.rdbDen.AutoSize = true;
            this.rdbDen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbDen.Location = new System.Drawing.Point(642, 184);
            this.rdbDen.Name = "rdbDen";
            this.rdbDen.Size = new System.Drawing.Size(60, 24);
            this.rdbDen.TabIndex = 14;
            this.rdbDen.TabStop = true;
            this.rdbDen.Text = "Đen";
            this.rdbDen.UseVisualStyleBackColor = true;
            // 
            // rdbMauKhac
            // 
            this.rdbMauKhac.AutoSize = true;
            this.rdbMauKhac.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbMauKhac.Location = new System.Drawing.Point(719, 184);
            this.rdbMauKhac.Name = "rdbMauKhac";
            this.rdbMauKhac.Size = new System.Drawing.Size(102, 24);
            this.rdbMauKhac.TabIndex = 15;
            this.rdbMauKhac.TabStop = true;
            this.rdbMauKhac.Text = "Màu khác";
            this.rdbMauKhac.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(642, 221);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown1.TabIndex = 16;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 306);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(932, 165);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btThem
            // 
            this.btThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThem.Location = new System.Drawing.Point(188, 486);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(83, 32);
            this.btThem.TabIndex = 18;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // btSua
            // 
            this.btSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSua.Location = new System.Drawing.Point(354, 486);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(83, 32);
            this.btSua.TabIndex = 19;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btXoa
            // 
            this.btXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoa.Location = new System.Drawing.Point(523, 486);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(83, 32);
            this.btXoa.TabIndex = 20;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btDong
            // 
            this.btDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDong.Location = new System.Drawing.Point(690, 486);
            this.btDong.Name = "btDong";
            this.btDong.Size = new System.Drawing.Size(83, 32);
            this.btDong.TabIndex = 21;
            this.btDong.Text = "Đóng";
            this.btDong.UseVisualStyleBackColor = true;
            this.btDong.Click += new System.EventHandler(this.btDong_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 530);
            this.Controls.Add(this.btDong);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.rdbMauKhac);
            this.Controls.Add(this.rdbDen);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtbDonGia);
            this.Controls.Add(this.txtbTenDT);
            this.Controls.Add(this.txtbTenKH);
            this.Controls.Add(this.txtbMaHD);
            this.Controls.Add(this.lbTenDT);
            this.Controls.Add(this.lbDonGia);
            this.Controls.Add(this.lbSoLuong);
            this.Controls.Add(this.lbMauSac);
            this.Controls.Add(this.lbNgayBan);
            this.Controls.Add(this.lbTenKH);
            this.Controls.Add(this.lbMaHD);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbMaHD;
        private System.Windows.Forms.Label lbTenKH;
        private System.Windows.Forms.Label lbNgayBan;
        private System.Windows.Forms.Label lbMauSac;
        private System.Windows.Forms.Label lbSoLuong;
        private System.Windows.Forms.Label lbDonGia;
        private System.Windows.Forms.Label lbTenDT;
        private System.Windows.Forms.TextBox txtbMaHD;
        private System.Windows.Forms.TextBox txtbTenKH;
        private System.Windows.Forms.TextBox txtbTenDT;
        private System.Windows.Forms.TextBox txtbDonGia;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.RadioButton rdbDen;
        private System.Windows.Forms.RadioButton rdbMauKhac;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btDong;
    }
}