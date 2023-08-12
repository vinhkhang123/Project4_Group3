namespace Project4_GR3
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
            this.name = new System.Windows.Forms.Label();
            this.dtngaynhap = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.maphieunhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaynhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_maphieu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_maphieunhap = new System.Windows.Forms.TextBox();
            this.txt_malinhkien = new System.Windows.Forms.TextBox();
            this.txt_tenlinhkien = new System.Windows.Forms.TextBox();
            this.txt_soluong = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.maphieunhaplk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.malinhkien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenlinhkien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_SuaLK = new System.Windows.Forms.Button();
            this.btn_XoaLK = new System.Windows.Forms.Button();
            this.btn_themLK = new System.Windows.Forms.Button();
            this.pb_pn = new System.Windows.Forms.Panel();
            this.btn_tim = new System.Windows.Forms.Button();
            this.pn_lk = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.pb_pn.SuspendLayout();
            this.pn_lk.SuspendLayout();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(49, 20);
            this.name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(99, 16);
            this.name.TabIndex = 0;
            this.name.Text = "Mã Phiếu Nhập";
            // 
            // dtngaynhap
            // 
            this.dtngaynhap.Location = new System.Drawing.Point(429, 15);
            this.dtngaynhap.Margin = new System.Windows.Forms.Padding(4);
            this.dtngaynhap.Name = "dtngaynhap";
            this.dtngaynhap.Size = new System.Drawing.Size(265, 22);
            this.dtngaynhap.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(238)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maphieunhap,
            this.ngaynhap});
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(238)))));
            this.dataGridView1.Location = new System.Drawing.Point(14, 130);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(680, 185);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // maphieunhap
            // 
            this.maphieunhap.DataPropertyName = "maphieunhap";
            this.maphieunhap.HeaderText = "maphieunhap";
            this.maphieunhap.MinimumWidth = 6;
            this.maphieunhap.Name = "maphieunhap";
            // 
            // ngaynhap
            // 
            this.ngaynhap.DataPropertyName = "ngaynhap";
            this.ngaynhap.HeaderText = "ngaynhap";
            this.ngaynhap.MinimumWidth = 6;
            this.ngaynhap.Name = "ngaynhap";
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(511, 358);
            this.btn_xoa.Margin = new System.Windows.Forms.Padding(4);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(108, 47);
            this.btn_xoa.TabIndex = 10;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(275, 358);
            this.btn_them.Margin = new System.Windows.Forms.Padding(4);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(109, 47);
            this.btn_them.TabIndex = 12;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(334, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ngày Nhập";
            // 
            // txt_maphieu
            // 
            this.txt_maphieu.Location = new System.Drawing.Point(184, 28);
            this.txt_maphieu.Margin = new System.Windows.Forms.Padding(4);
            this.txt_maphieu.Name = "txt_maphieu";
            this.txt_maphieu.Size = new System.Drawing.Size(127, 22);
            this.txt_maphieu.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Mã phiếu nhập";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(119, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Mã linh kiện";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(384, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Số lượng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(384, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "Tên linh kiện";
            // 
            // txt_maphieunhap
            // 
            this.txt_maphieunhap.Location = new System.Drawing.Point(972, 32);
            this.txt_maphieunhap.Name = "txt_maphieunhap";
            this.txt_maphieunhap.Size = new System.Drawing.Size(100, 22);
            this.txt_maphieunhap.TabIndex = 17;
            // 
            // txt_malinhkien
            // 
            this.txt_malinhkien.Location = new System.Drawing.Point(232, 90);
            this.txt_malinhkien.Name = "txt_malinhkien";
            this.txt_malinhkien.Size = new System.Drawing.Size(100, 22);
            this.txt_malinhkien.TabIndex = 18;
            // 
            // txt_tenlinhkien
            // 
            this.txt_tenlinhkien.Location = new System.Drawing.Point(493, 20);
            this.txt_tenlinhkien.Name = "txt_tenlinhkien";
            this.txt_tenlinhkien.Size = new System.Drawing.Size(100, 22);
            this.txt_tenlinhkien.TabIndex = 19;
            // 
            // txt_soluong
            // 
            this.txt_soluong.Location = new System.Drawing.Point(493, 90);
            this.txt_soluong.Name = "txt_soluong";
            this.txt_soluong.Size = new System.Drawing.Size(100, 22);
            this.txt_soluong.TabIndex = 20;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(238)))));
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maphieunhaplk,
            this.malinhkien,
            this.tenlinhkien,
            this.soluong});
            this.dataGridView2.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(238)))));
            this.dataGridView2.Location = new System.Drawing.Point(33, 130);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(659, 185);
            this.dataGridView2.TabIndex = 21;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // maphieunhaplk
            // 
            this.maphieunhaplk.DataPropertyName = "maphieunhap";
            this.maphieunhaplk.HeaderText = "maphieunhap";
            this.maphieunhaplk.MinimumWidth = 6;
            this.maphieunhaplk.Name = "maphieunhaplk";
            // 
            // malinhkien
            // 
            this.malinhkien.DataPropertyName = "malinhkien";
            this.malinhkien.HeaderText = "malinhkien";
            this.malinhkien.MinimumWidth = 6;
            this.malinhkien.Name = "malinhkien";
            // 
            // tenlinhkien
            // 
            this.tenlinhkien.DataPropertyName = "tenlinhkien";
            this.tenlinhkien.HeaderText = "tenlinhkien";
            this.tenlinhkien.MinimumWidth = 6;
            this.tenlinhkien.Name = "tenlinhkien";
            // 
            // soluong
            // 
            this.soluong.DataPropertyName = "soluong";
            this.soluong.HeaderText = "soluong";
            this.soluong.MinimumWidth = 6;
            this.soluong.Name = "soluong";
            // 
            // btn_SuaLK
            // 
            this.btn_SuaLK.Location = new System.Drawing.Point(320, 358);
            this.btn_SuaLK.Margin = new System.Windows.Forms.Padding(4);
            this.btn_SuaLK.Name = "btn_SuaLK";
            this.btn_SuaLK.Size = new System.Drawing.Size(109, 47);
            this.btn_SuaLK.TabIndex = 22;
            this.btn_SuaLK.Text = "Sửa";
            this.btn_SuaLK.UseVisualStyleBackColor = true;
            this.btn_SuaLK.Click += new System.EventHandler(this.btn_SuaLK_Click);
            // 
            // btn_XoaLK
            // 
            this.btn_XoaLK.Location = new System.Drawing.Point(522, 358);
            this.btn_XoaLK.Margin = new System.Windows.Forms.Padding(4);
            this.btn_XoaLK.Name = "btn_XoaLK";
            this.btn_XoaLK.Size = new System.Drawing.Size(108, 47);
            this.btn_XoaLK.TabIndex = 23;
            this.btn_XoaLK.Text = "Xóa";
            this.btn_XoaLK.UseVisualStyleBackColor = true;
            this.btn_XoaLK.Click += new System.EventHandler(this.btn_XoaLK_Click);
            // 
            // btn_themLK
            // 
            this.btn_themLK.Location = new System.Drawing.Point(105, 358);
            this.btn_themLK.Margin = new System.Windows.Forms.Padding(4);
            this.btn_themLK.Name = "btn_themLK";
            this.btn_themLK.Size = new System.Drawing.Size(109, 47);
            this.btn_themLK.TabIndex = 24;
            this.btn_themLK.Text = "Thêm";
            this.btn_themLK.UseVisualStyleBackColor = true;
            this.btn_themLK.Click += new System.EventHandler(this.btn_themLK_Click);
            // 
            // pb_pn
            // 
            this.pb_pn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(238)))));
            this.pb_pn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_pn.Controls.Add(this.btn_tim);
            this.pb_pn.Controls.Add(this.dataGridView1);
            this.pb_pn.Controls.Add(this.dtngaynhap);
            this.pb_pn.Controls.Add(this.btn_them);
            this.pb_pn.Controls.Add(this.label1);
            this.pb_pn.Controls.Add(this.btn_xoa);
            this.pb_pn.Controls.Add(this.name);
            this.pb_pn.Location = new System.Drawing.Point(12, 13);
            this.pb_pn.Name = "pb_pn";
            this.pb_pn.Size = new System.Drawing.Size(722, 569);
            this.pb_pn.TabIndex = 25;
            // 
            // btn_tim
            // 
            this.btn_tim.Location = new System.Drawing.Point(73, 358);
            this.btn_tim.Margin = new System.Windows.Forms.Padding(4);
            this.btn_tim.Name = "btn_tim";
            this.btn_tim.Size = new System.Drawing.Size(109, 47);
            this.btn_tim.TabIndex = 27;
            this.btn_tim.Text = "Tìm";
            this.btn_tim.UseVisualStyleBackColor = true;
            this.btn_tim.Click += new System.EventHandler(this.btn_tim_Click);
            // 
            // pn_lk
            // 
            this.pn_lk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(238)))));
            this.pn_lk.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_lk.Controls.Add(this.btn_XoaLK);
            this.pn_lk.Controls.Add(this.btn_themLK);
            this.pn_lk.Controls.Add(this.btn_SuaLK);
            this.pn_lk.Controls.Add(this.txt_tenlinhkien);
            this.pn_lk.Controls.Add(this.label5);
            this.pn_lk.Controls.Add(this.label2);
            this.pn_lk.Controls.Add(this.dataGridView2);
            this.pn_lk.Controls.Add(this.label3);
            this.pn_lk.Controls.Add(this.txt_soluong);
            this.pn_lk.Controls.Add(this.txt_malinhkien);
            this.pn_lk.Controls.Add(this.label4);
            this.pn_lk.Location = new System.Drawing.Point(750, 13);
            this.pn_lk.Name = "pn_lk";
            this.pn_lk.Size = new System.Drawing.Size(722, 569);
            this.pn_lk.TabIndex = 26;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(218)))), ((int)(((byte)(220)))));
            this.ClientSize = new System.Drawing.Size(1481, 655);
            this.Controls.Add(this.txt_maphieunhap);
            this.Controls.Add(this.txt_maphieu);
            this.Controls.Add(this.pb_pn);
            this.Controls.Add(this.pn_lk);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.pb_pn.ResumeLayout(false);
            this.pb_pn.PerformLayout();
            this.pn_lk.ResumeLayout(false);
            this.pn_lk.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label name;
        private System.Windows.Forms.DateTimePicker dtngaynhap;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_maphieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn maphieunhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaynhap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_maphieunhap;
        private System.Windows.Forms.TextBox txt_malinhkien;
        private System.Windows.Forms.TextBox txt_tenlinhkien;
        private System.Windows.Forms.TextBox txt_soluong;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btn_SuaLK;
        private System.Windows.Forms.Button btn_XoaLK;
        private System.Windows.Forms.Button btn_themLK;
        private System.Windows.Forms.DataGridViewTextBoxColumn maphieunhaplk;
        private System.Windows.Forms.DataGridViewTextBoxColumn malinhkien;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenlinhkien;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluong;
        private System.Windows.Forms.Panel pb_pn;
        private System.Windows.Forms.Panel pn_lk;
        private System.Windows.Forms.Button btn_tim;
    }
}

