namespace PBTL2
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvViewport = new System.Windows.Forms.DataGridView();
            this.clName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMaSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clGioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNgaysinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDiachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtHoten = new System.Windows.Forms.TextBox();
            this.cbGioitinh = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpNgaysinh = new System.Windows.Forms.DateTimePicker();
            this.ibtnXoa = new FontAwesome.Sharp.IconButton();
            this.tbtnThem = new FontAwesome.Sharp.IconButton();
            this.ibtnSua = new FontAwesome.Sharp.IconButton();
            this.ibtnTimKiem = new FontAwesome.Sharp.IconButton();
            this.txtDiachi = new System.Windows.Forms.TextBox();
            this.txtLop = new System.Windows.Forms.TextBox();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.iconButton5 = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewport)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 318);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 355);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã SV";
            // 
            // dgvViewport
            // 
            this.dgvViewport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvViewport.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvViewport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViewport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clName,
            this.clMaSV,
            this.clGioiTinh,
            this.clNgaysinh,
            this.clLop,
            this.clDiachi});
            this.dgvViewport.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvViewport.Location = new System.Drawing.Point(12, 65);
            this.dgvViewport.Name = "dgvViewport";
            this.dgvViewport.Size = new System.Drawing.Size(791, 209);
            this.dgvViewport.TabIndex = 1;
            this.dgvViewport.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvViewport_CellClick);
            // 
            // clName
            // 
            this.clName.DataPropertyName = "name";
            this.clName.HeaderText = "Họ tên";
            this.clName.Name = "clName";
            // 
            // clMaSV
            // 
            this.clMaSV.DataPropertyName = "masv";
            this.clMaSV.HeaderText = "Mã SV";
            this.clMaSV.Name = "clMaSV";
            // 
            // clGioiTinh
            // 
            this.clGioiTinh.DataPropertyName = "gioitinh";
            this.clGioiTinh.HeaderText = "Giới tính";
            this.clGioiTinh.Name = "clGioiTinh";
            // 
            // clNgaysinh
            // 
            this.clNgaysinh.DataPropertyName = "ngaysinh";
            this.clNgaysinh.HeaderText = "Ngày sinh";
            this.clNgaysinh.Name = "clNgaysinh";
            // 
            // clLop
            // 
            this.clLop.DataPropertyName = "lop";
            this.clLop.HeaderText = "Lớp";
            this.clLop.Name = "clLop";
            // 
            // clDiachi
            // 
            this.clDiachi.DataPropertyName = "diachi";
            this.clDiachi.HeaderText = "Địa chỉ";
            this.clDiachi.Name = "clDiachi";
            // 
            // txtHoten
            // 
            this.txtHoten.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoten.Location = new System.Drawing.Point(109, 308);
            this.txtHoten.Name = "txtHoten";
            this.txtHoten.Size = new System.Drawing.Size(172, 26);
            this.txtHoten.TabIndex = 2;
            this.txtHoten.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHoten_KeyPress);
            // 
            // cbGioitinh
            // 
            this.cbGioitinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGioitinh.FormattingEnabled = true;
            this.cbGioitinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbGioitinh.Location = new System.Drawing.Point(109, 388);
            this.cbGioitinh.Name = "cbGioitinh";
            this.cbGioitinh.Size = new System.Drawing.Size(73, 28);
            this.cbGioitinh.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(329, 394);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Địa chỉ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 397);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Giới tính";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(254, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(294, 31);
            this.label5.TabIndex = 5;
            this.label5.Text = "QUẢN LÝ SINH VIÊN";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.dtpNgaysinh);
            this.panel1.Controls.Add(this.cbGioitinh);
            this.panel1.Controls.Add(this.ibtnXoa);
            this.panel1.Controls.Add(this.tbtnThem);
            this.panel1.Controls.Add(this.ibtnSua);
            this.panel1.Controls.Add(this.ibtnTimKiem);
            this.panel1.Controls.Add(this.dgvViewport);
            this.panel1.Controls.Add(this.txtDiachi);
            this.panel1.Controls.Add(this.txtLop);
            this.panel1.Controls.Add(this.txtMaSV);
            this.panel1.Controls.Add(this.txtHoten);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtTimKiem);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(815, 454);
            this.panel1.TabIndex = 6;
            // 
            // dtpNgaysinh
            // 
            this.dtpNgaysinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaysinh.Location = new System.Drawing.Point(413, 305);
            this.dtpNgaysinh.Name = "dtpNgaysinh";
            this.dtpNgaysinh.Size = new System.Drawing.Size(172, 26);
            this.dtpNgaysinh.TabIndex = 5;
            // 
            // ibtnXoa
            // 
            this.ibtnXoa.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ibtnXoa.FlatAppearance.BorderSize = 0;
            this.ibtnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnXoa.ForeColor = System.Drawing.Color.White;
            this.ibtnXoa.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.ibtnXoa.IconColor = System.Drawing.Color.White;
            this.ibtnXoa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnXoa.IconSize = 30;
            this.ibtnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnXoa.Location = new System.Drawing.Point(647, 395);
            this.ibtnXoa.Name = "ibtnXoa";
            this.ibtnXoa.Size = new System.Drawing.Size(124, 40);
            this.ibtnXoa.TabIndex = 4;
            this.ibtnXoa.Text = "Xoá";
            this.ibtnXoa.UseVisualStyleBackColor = false;
            this.ibtnXoa.Click += new System.EventHandler(this.ibtnXoa_Click);
            // 
            // tbtnThem
            // 
            this.tbtnThem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbtnThem.FlatAppearance.BorderSize = 0;
            this.tbtnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tbtnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbtnThem.ForeColor = System.Drawing.Color.White;
            this.tbtnThem.IconChar = FontAwesome.Sharp.IconChar.Add;
            this.tbtnThem.IconColor = System.Drawing.Color.White;
            this.tbtnThem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.tbtnThem.IconSize = 30;
            this.tbtnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbtnThem.Location = new System.Drawing.Point(647, 289);
            this.tbtnThem.Name = "tbtnThem";
            this.tbtnThem.Size = new System.Drawing.Size(124, 40);
            this.tbtnThem.TabIndex = 4;
            this.tbtnThem.Text = "Thêm";
            this.tbtnThem.UseVisualStyleBackColor = false;
            this.tbtnThem.Click += new System.EventHandler(this.tbtnThem_Click);
            // 
            // ibtnSua
            // 
            this.ibtnSua.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ibtnSua.FlatAppearance.BorderSize = 0;
            this.ibtnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnSua.ForeColor = System.Drawing.Color.White;
            this.ibtnSua.IconChar = FontAwesome.Sharp.IconChar.Wrench;
            this.ibtnSua.IconColor = System.Drawing.Color.White;
            this.ibtnSua.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnSua.IconSize = 30;
            this.ibtnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnSua.Location = new System.Drawing.Point(647, 342);
            this.ibtnSua.Name = "ibtnSua";
            this.ibtnSua.Size = new System.Drawing.Size(124, 40);
            this.ibtnSua.TabIndex = 4;
            this.ibtnSua.Text = "Sửa";
            this.ibtnSua.UseVisualStyleBackColor = false;
            this.ibtnSua.Click += new System.EventHandler(this.ibtnSua_Click);
            // 
            // ibtnTimKiem
            // 
            this.ibtnTimKiem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ibtnTimKiem.FlatAppearance.BorderSize = 0;
            this.ibtnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnTimKiem.ForeColor = System.Drawing.Color.White;
            this.ibtnTimKiem.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.ibtnTimKiem.IconColor = System.Drawing.Color.White;
            this.ibtnTimKiem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnTimKiem.IconSize = 30;
            this.ibtnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnTimKiem.Location = new System.Drawing.Point(647, 14);
            this.ibtnTimKiem.Name = "ibtnTimKiem";
            this.ibtnTimKiem.Size = new System.Drawing.Size(124, 40);
            this.ibtnTimKiem.TabIndex = 4;
            this.ibtnTimKiem.Text = "Tìm Kiếm";
            this.ibtnTimKiem.UseVisualStyleBackColor = false;
            this.ibtnTimKiem.Click += new System.EventHandler(this.ibtnTimKiem_Click);
            // 
            // txtDiachi
            // 
            this.txtDiachi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiachi.Location = new System.Drawing.Point(413, 386);
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(172, 26);
            this.txtDiachi.TabIndex = 2;
            // 
            // txtLop
            // 
            this.txtLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLop.Location = new System.Drawing.Point(413, 344);
            this.txtLop.Name = "txtLop";
            this.txtLop.Size = new System.Drawing.Size(172, 26);
            this.txtLop.TabIndex = 2;
            // 
            // txtMaSV
            // 
            this.txtMaSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaSV.Location = new System.Drawing.Point(109, 349);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(172, 26);
            this.txtMaSV.TabIndex = 2;
            this.txtMaSV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaSV_KeyPress);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(199, 17);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(386, 29);
            this.txtTimKiem.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(329, 350);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Lớp";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(329, 313);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Ngày sinh";
            // 
            // iconButton5
            // 
            this.iconButton5.BackColor = System.Drawing.Color.Black;
            this.iconButton5.FlatAppearance.BorderSize = 0;
            this.iconButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton5.ForeColor = System.Drawing.Color.White;
            this.iconButton5.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton5.IconColor = System.Drawing.Color.White;
            this.iconButton5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton5.Location = new System.Drawing.Point(779, 2);
            this.iconButton5.Name = "iconButton5";
            this.iconButton5.Size = new System.Drawing.Size(36, 30);
            this.iconButton5.TabIndex = 4;
            this.iconButton5.Text = "X";
            this.iconButton5.UseVisualStyleBackColor = false;
            this.iconButton5.Click += new System.EventHandler(this.iconButton5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(815, 526);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.iconButton5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewport)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvViewport;
        private System.Windows.Forms.TextBox txtHoten;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbGioitinh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtTimKiem;
        private FontAwesome.Sharp.IconButton ibtnTimKiem;
        private FontAwesome.Sharp.IconButton ibtnXoa;
        private FontAwesome.Sharp.IconButton tbtnThem;
        private FontAwesome.Sharp.IconButton ibtnSua;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private FontAwesome.Sharp.IconButton iconButton5;
        private System.Windows.Forms.DateTimePicker dtpNgaysinh;
        private System.Windows.Forms.TextBox txtDiachi;
        private System.Windows.Forms.TextBox txtLop;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn clName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn clGioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNgaysinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn clLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDiachi;
    }
}

