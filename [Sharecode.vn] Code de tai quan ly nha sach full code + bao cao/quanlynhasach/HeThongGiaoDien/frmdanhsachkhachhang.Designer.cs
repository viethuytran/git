namespace quanlynhasach.HeThongGiaoDien
{
    partial class frmdanhsachkhachhang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmdanhsachkhachhang));
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.rademail = new System.Windows.Forms.RadioButton();
            this.raddienthoai = new System.Windows.Forms.RadioButton();
            this.raddiachi = new System.Windows.Forms.RadioButton();
            this.radtatca = new System.Windows.Forms.RadioButton();
            this.radtenkh = new System.Windows.Forms.RadioButton();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnchon = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dskhachhang = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.pictureBox15 = new System.Windows.Forms.PictureBox();
            this.pictureBox16 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.colmakh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colhoten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coldienthoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coldiachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colemail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coltienno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dskhachhang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txttimkiem);
            this.groupBox4.Controls.Add(this.rademail);
            this.groupBox4.Controls.Add(this.raddienthoai);
            this.groupBox4.Controls.Add(this.raddiachi);
            this.groupBox4.Controls.Add(this.radtatca);
            this.groupBox4.Controls.Add(this.radtenkh);
            this.groupBox4.Location = new System.Drawing.Point(21, 64);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(576, 56);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tìm kiếm";
            // 
            // txttimkiem
            // 
            this.txttimkiem.Location = new System.Drawing.Point(6, 19);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(189, 20);
            this.txttimkiem.TabIndex = 0;
            this.txttimkiem.TextChanged += new System.EventHandler(this.txttimkiem_TextChanged);
            // 
            // rademail
            // 
            this.rademail.AutoSize = true;
            this.rademail.Location = new System.Drawing.Point(520, 22);
            this.rademail.Name = "rademail";
            this.rademail.Size = new System.Drawing.Size(50, 17);
            this.rademail.TabIndex = 3;
            this.rademail.TabStop = true;
            this.rademail.Text = "Email";
            this.rademail.UseVisualStyleBackColor = true;
            this.rademail.CheckedChanged += new System.EventHandler(this.rademail_CheckedChanged);
            // 
            // raddienthoai
            // 
            this.raddienthoai.AutoSize = true;
            this.raddienthoai.Location = new System.Drawing.Point(441, 22);
            this.raddienthoai.Name = "raddienthoai";
            this.raddienthoai.Size = new System.Drawing.Size(73, 17);
            this.raddienthoai.TabIndex = 3;
            this.raddienthoai.TabStop = true;
            this.raddienthoai.Text = "Điện thoại";
            this.raddienthoai.UseVisualStyleBackColor = true;
            this.raddienthoai.CheckedChanged += new System.EventHandler(this.raddienthoai_CheckedChanged);
            // 
            // raddiachi
            // 
            this.raddiachi.AutoSize = true;
            this.raddiachi.Location = new System.Drawing.Point(377, 20);
            this.raddiachi.Name = "raddiachi";
            this.raddiachi.Size = new System.Drawing.Size(58, 17);
            this.raddiachi.TabIndex = 2;
            this.raddiachi.TabStop = true;
            this.raddiachi.Text = "Địa chỉ";
            this.raddiachi.UseVisualStyleBackColor = true;
            this.raddiachi.CheckedChanged += new System.EventHandler(this.raddiachi_CheckedChanged);
            // 
            // radtatca
            // 
            this.radtatca.AutoSize = true;
            this.radtatca.Location = new System.Drawing.Point(201, 19);
            this.radtatca.Name = "radtatca";
            this.radtatca.Size = new System.Drawing.Size(56, 17);
            this.radtatca.TabIndex = 1;
            this.radtatca.TabStop = true;
            this.radtatca.Text = "Tất cả";
            this.radtatca.UseVisualStyleBackColor = true;
            this.radtatca.CheckedChanged += new System.EventHandler(this.radtatca_CheckedChanged);
            // 
            // radtenkh
            // 
            this.radtenkh.AutoSize = true;
            this.radtenkh.Location = new System.Drawing.Point(267, 20);
            this.radtenkh.Name = "radtenkh";
            this.radtenkh.Size = new System.Drawing.Size(104, 17);
            this.radtenkh.TabIndex = 1;
            this.radtenkh.TabStop = true;
            this.radtenkh.Text = "Tên khách hàng";
            this.radtenkh.UseVisualStyleBackColor = true;
            this.radtenkh.CheckedChanged += new System.EventHandler(this.radtenkh_CheckedChanged);
            // 
            // btnexit
            // 
            this.btnexit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnexit.BackgroundImage")));
            this.btnexit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.ForeColor = System.Drawing.Color.White;
            this.btnexit.Location = new System.Drawing.Point(523, 314);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(75, 23);
            this.btnexit.TabIndex = 5;
            this.btnexit.Text = "Thoát";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btnchon
            // 
            this.btnchon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnchon.BackgroundImage")));
            this.btnchon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnchon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnchon.ForeColor = System.Drawing.Color.White;
            this.btnchon.Location = new System.Drawing.Point(442, 314);
            this.btnchon.Name = "btnchon";
            this.btnchon.Size = new System.Drawing.Size(75, 23);
            this.btnchon.TabIndex = 4;
            this.btnchon.Text = "Chọn";
            this.btnchon.UseVisualStyleBackColor = true;
            this.btnchon.Click += new System.EventHandler(this.btnchon_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dskhachhang);
            this.groupBox2.Location = new System.Drawing.Point(21, 139);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(576, 173);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dach sách khách hàng";
            // 
            // dskhachhang
            // 
            this.dskhachhang.AllowUserToAddRows = false;
            this.dskhachhang.AllowUserToDeleteRows = false;
            this.dskhachhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dskhachhang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colmakh,
            this.colhoten,
            this.coldienthoai,
            this.coldiachi,
            this.colemail,
            this.coltienno});
            this.dskhachhang.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dskhachhang.Location = new System.Drawing.Point(9, 18);
            this.dskhachhang.MultiSelect = false;
            this.dskhachhang.Name = "dskhachhang";
            this.dskhachhang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dskhachhang.Size = new System.Drawing.Size(558, 143);
            this.dskhachhang.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::quanlynhasach.Properties.Resources.nen23psd_20;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(-2, -4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(18, 365);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackgroundImage = global::quanlynhasach.Properties.Resources.nen23psd_01;
            this.pictureBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox8.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(98, 18);
            this.pictureBox8.TabIndex = 25;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackgroundImage = global::quanlynhasach.Properties.Resources.nen23psd_06;
            this.pictureBox10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox10.Location = new System.Drawing.Point(626, -2);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(19, 51);
            this.pictureBox10.TabIndex = 26;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox11
            // 
            this.pictureBox11.BackgroundImage = global::quanlynhasach.Properties.Resources.nen23psd_03;
            this.pictureBox11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox11.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(646, 18);
            this.pictureBox11.TabIndex = 24;
            this.pictureBox11.TabStop = false;
            // 
            // pictureBox14
            // 
            this.pictureBox14.BackgroundImage = global::quanlynhasach.Properties.Resources.nen23psd_12;
            this.pictureBox14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox14.Location = new System.Drawing.Point(626, 12);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.Size = new System.Drawing.Size(19, 349);
            this.pictureBox14.TabIndex = 27;
            this.pictureBox14.TabStop = false;
            // 
            // pictureBox15
            // 
            this.pictureBox15.BackgroundImage = global::quanlynhasach.Properties.Resources.nen23psd_21;
            this.pictureBox15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox15.Location = new System.Drawing.Point(626, 302);
            this.pictureBox15.Name = "pictureBox15";
            this.pictureBox15.Size = new System.Drawing.Size(19, 56);
            this.pictureBox15.TabIndex = 29;
            this.pictureBox15.TabStop = false;
            // 
            // pictureBox16
            // 
            this.pictureBox16.BackgroundImage = global::quanlynhasach.Properties.Resources.nen23psd_22;
            this.pictureBox16.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox16.Location = new System.Drawing.Point(-1, 314);
            this.pictureBox16.Name = "pictureBox16";
            this.pictureBox16.Size = new System.Drawing.Size(16, 45);
            this.pictureBox16.TabIndex = 30;
            this.pictureBox16.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::quanlynhasach.Properties.Resources.nen23psd_26;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(4, 340);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(641, 19);
            this.pictureBox3.TabIndex = 28;
            this.pictureBox3.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label6.Location = new System.Drawing.Point(179, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(304, 31);
            this.label6.TabIndex = 31;
            this.label6.Text = "Danh Sách Khách Hàng";
            // 
            // colmakh
            // 
            this.colmakh.DataPropertyName = "MaKhachHang";
            this.colmakh.HeaderText = "Mã khách hàng";
            this.colmakh.Name = "colmakh";
            // 
            // colhoten
            // 
            this.colhoten.DataPropertyName = "HoTenKhachHang";
            this.colhoten.HeaderText = "Họ tên khách hàng";
            this.colhoten.Name = "colhoten";
            // 
            // coldienthoai
            // 
            this.coldienthoai.DataPropertyName = "DienThoai";
            this.coldienthoai.HeaderText = "Điện thoại";
            this.coldienthoai.Name = "coldienthoai";
            // 
            // coldiachi
            // 
            this.coldiachi.DataPropertyName = "DiaChi";
            this.coldiachi.HeaderText = "Địa chỉ";
            this.coldiachi.Name = "coldiachi";
            // 
            // colemail
            // 
            this.colemail.DataPropertyName = "Email";
            this.colemail.HeaderText = "Email";
            this.colemail.Name = "colemail";
            // 
            // coltienno
            // 
            this.coltienno.DataPropertyName = "TienNo";
            this.coltienno.HeaderText = "Tiền nợ";
            this.coltienno.Name = "coltienno";
            // 
            // frmdanhsachkhachhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(642, 358);
            this.Controls.Add(this.btnchon);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox15);
            this.Controls.Add(this.pictureBox16);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox14);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnexit);
            this.Name = "frmdanhsachkhachhang";
            this.Text = "Danh sách khách hàng";
            this.Load += new System.EventHandler(this.frmdanhsachkhachhang_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dskhachhang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txttimkiem;
        private System.Windows.Forms.RadioButton rademail;
        private System.Windows.Forms.RadioButton raddienthoai;
        private System.Windows.Forms.RadioButton raddiachi;
        private System.Windows.Forms.RadioButton radtenkh;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnchon;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dskhachhang;
        private System.Windows.Forms.RadioButton radtatca;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pictureBox14;
        private System.Windows.Forms.PictureBox pictureBox15;
        private System.Windows.Forms.PictureBox pictureBox16;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn colmakh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colhoten;
        private System.Windows.Forms.DataGridViewTextBoxColumn coldienthoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn coldiachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colemail;
        private System.Windows.Forms.DataGridViewTextBoxColumn coltienno;
    }
}