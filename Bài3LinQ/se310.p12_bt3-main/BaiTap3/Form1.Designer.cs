namespace BaiTap3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            delBtn = new Button();
            addBtn = new Button();
            ngayhethan = new DateTimePicker();
            tbxuatxu = new TextBox();
            tbdongia = new TextBox();
            tbsoluong = new TextBox();
            tbtensp = new TextBox();
            tbmasp = new TextBox();
            label2 = new Label();
            xuatxu = new Label();
            dongia = new Label();
            soluong = new Label();
            tensp = new Label();
            masp = new Label();
            label1 = new Label();
            panel2 = new Panel();
            dgv2 = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            tbB = new TextBox();
            tbA = new TextBox();
            sanPhamTrongPhamViBtn = new Button();
            sanPhamQuaHanBtn = new Button();
            sanPhamTuNhatBanBtn = new Button();
            sanPhamCoDGCaoNhatBtn = new Button();
            label3 = new Label();
            label4 = new Label();
            dgv = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            label5 = new Label();
            panel3 = new Panel();
            delSanPhamQuaHanBtn = new Button();
            delAllBtn = new Button();
            btnSanPhamHopLe = new Button();
            delXuatXu = new TextBox();
            delXuatXuBtn = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(delBtn);
            panel1.Controls.Add(addBtn);
            panel1.Controls.Add(ngayhethan);
            panel1.Controls.Add(tbxuatxu);
            panel1.Controls.Add(tbdongia);
            panel1.Controls.Add(tbsoluong);
            panel1.Controls.Add(tbtensp);
            panel1.Controls.Add(tbmasp);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(xuatxu);
            panel1.Controls.Add(dongia);
            panel1.Controls.Add(soluong);
            panel1.Controls.Add(tensp);
            panel1.Controls.Add(masp);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(309, 304);
            panel1.TabIndex = 0;
            // 
            // delBtn
            // 
            delBtn.Location = new Point(167, 248);
            delBtn.Name = "delBtn";
            delBtn.Size = new Size(124, 34);
            delBtn.TabIndex = 17;
            delBtn.Text = "Xóa sản phẩm";
            delBtn.UseVisualStyleBackColor = true;
            delBtn.Click += delBtn_Click;
            // 
            // addBtn
            // 
            addBtn.Location = new Point(3, 250);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(140, 32);
            addBtn.TabIndex = 16;
            addBtn.Text = "Lưu sản phẩm";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // ngayhethan
            // 
            ngayhethan.Location = new Point(118, 203);
            ngayhethan.Name = "ngayhethan";
            ngayhethan.Size = new Size(173, 27);
            ngayhethan.TabIndex = 12;
            // 
            // tbxuatxu
            // 
            tbxuatxu.Location = new Point(118, 168);
            tbxuatxu.Name = "tbxuatxu";
            tbxuatxu.Size = new Size(173, 27);
            tbxuatxu.TabIndex = 11;
            // 
            // tbdongia
            // 
            tbdongia.Location = new Point(118, 135);
            tbdongia.Name = "tbdongia";
            tbdongia.Size = new Size(173, 27);
            tbdongia.TabIndex = 10;
            // 
            // tbsoluong
            // 
            tbsoluong.Location = new Point(118, 102);
            tbsoluong.Name = "tbsoluong";
            tbsoluong.Size = new Size(173, 27);
            tbsoluong.TabIndex = 9;
            // 
            // tbtensp
            // 
            tbtensp.Location = new Point(118, 67);
            tbtensp.Name = "tbtensp";
            tbtensp.Size = new Size(173, 27);
            tbtensp.TabIndex = 8;
            // 
            // tbmasp
            // 
            tbmasp.Location = new Point(118, 31);
            tbmasp.Name = "tbmasp";
            tbmasp.Size = new Size(173, 27);
            tbmasp.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 193);
            label2.Name = "label2";
            label2.Size = new Size(97, 20);
            label2.TabIndex = 6;
            label2.Text = "Ngày hết hạn";
            // 
            // xuatxu
            // 
            xuatxu.AutoSize = true;
            xuatxu.Location = new Point(3, 164);
            xuatxu.Name = "xuatxu";
            xuatxu.Size = new Size(62, 20);
            xuatxu.TabIndex = 5;
            xuatxu.Text = "Xuất xứ:";
            // 
            // dongia
            // 
            dongia.AutoSize = true;
            dongia.Location = new Point(3, 135);
            dongia.Name = "dongia";
            dongia.Size = new Size(65, 20);
            dongia.TabIndex = 4;
            dongia.Text = "Đơn giá:";
            // 
            // soluong
            // 
            soluong.AutoSize = true;
            soluong.Location = new Point(3, 102);
            soluong.Name = "soluong";
            soluong.Size = new Size(72, 20);
            soluong.TabIndex = 3;
            soluong.Text = "Số lượng:";
            // 
            // tensp
            // 
            tensp.AutoSize = true;
            tensp.Location = new Point(3, 67);
            tensp.Name = "tensp";
            tensp.Size = new Size(103, 20);
            tensp.TabIndex = 2;
            tensp.Text = "Tên sản phẩm:";
            // 
            // masp
            // 
            masp.AutoSize = true;
            masp.Location = new Point(3, 31);
            masp.Name = "masp";
            masp.Size = new Size(101, 20);
            masp.TabIndex = 1;
            masp.Text = "Mã sản phẩm:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(66, 0);
            label1.Name = "label1";
            label1.Size = new Size(177, 20);
            label1.TabIndex = 0;
            label1.Text = "Nhập thông tin sản phẩm";
            // 
            // panel2
            // 
            panel2.Controls.Add(dgv2);
            panel2.Controls.Add(tbB);
            panel2.Controls.Add(tbA);
            panel2.Controls.Add(sanPhamTrongPhamViBtn);
            panel2.Controls.Add(sanPhamQuaHanBtn);
            panel2.Controls.Add(sanPhamTuNhatBanBtn);
            panel2.Controls.Add(sanPhamCoDGCaoNhatBtn);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(341, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(792, 304);
            panel2.TabIndex = 1;
            // 
            // dgv2
            // 
            dgv2.AllowUserToAddRows = false;
            dgv2.AllowUserToDeleteRows = false;
            dgv2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv2.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6 });
            dgv2.Location = new Point(3, 83);
            dgv2.Name = "dgv2";
            dgv2.ReadOnly = true;
            dgv2.RowHeadersVisible = false;
            dgv2.RowHeadersWidth = 51;
            dgv2.RowTemplate.Height = 29;
            dgv2.Size = new Size(779, 202);
            dgv2.TabIndex = 22;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Mã SP";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Width = 80;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Tên SP";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Số lượng";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Đơn giá";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.HeaderText = "Xuất xứ";
            dataGridViewTextBoxColumn5.MinimumWidth = 6;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.HeaderText = "Ngày hết hạn";
            dataGridViewTextBoxColumn6.MinimumWidth = 6;
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.ReadOnly = true;
            dataGridViewTextBoxColumn6.Width = 200;
            // 
            // tbB
            // 
            tbB.Location = new Point(683, 35);
            tbB.Name = "tbB";
            tbB.Size = new Size(48, 27);
            tbB.TabIndex = 20;
            // 
            // tbA
            // 
            tbA.Location = new Point(629, 35);
            tbA.Name = "tbA";
            tbA.Size = new Size(48, 27);
            tbA.TabIndex = 19;
            // 
            // sanPhamTrongPhamViBtn
            // 
            sanPhamTrongPhamViBtn.Location = new Point(523, 19);
            sanPhamTrongPhamViBtn.Name = "sanPhamTrongPhamViBtn";
            sanPhamTrongPhamViBtn.Size = new Size(103, 58);
            sanPhamTrongPhamViBtn.TabIndex = 18;
            sanPhamTrongPhamViBtn.Text = "Xuất các SP có ĐG [a,b]";
            sanPhamTrongPhamViBtn.UseVisualStyleBackColor = true;
            sanPhamTrongPhamViBtn.Click += sanPhamTrongPhamViBtn_Click;
            // 
            // sanPhamQuaHanBtn
            // 
            sanPhamQuaHanBtn.Location = new Point(390, 19);
            sanPhamQuaHanBtn.Name = "sanPhamQuaHanBtn";
            sanPhamQuaHanBtn.Size = new Size(103, 58);
            sanPhamQuaHanBtn.TabIndex = 17;
            sanPhamQuaHanBtn.Text = "Xuất toàn bộ SP quá hạn";
            sanPhamQuaHanBtn.UseVisualStyleBackColor = true;
            sanPhamQuaHanBtn.Click += sanPhamQuaHanBtn_Click;
            // 
            // sanPhamTuNhatBanBtn
            // 
            sanPhamTuNhatBanBtn.Location = new Point(281, 19);
            sanPhamTuNhatBanBtn.Name = "sanPhamTuNhatBanBtn";
            sanPhamTuNhatBanBtn.Size = new Size(103, 58);
            sanPhamTuNhatBanBtn.TabIndex = 16;
            sanPhamTuNhatBanBtn.Text = "1 SP từ Nhật Bản";
            sanPhamTuNhatBanBtn.UseVisualStyleBackColor = true;
            sanPhamTuNhatBanBtn.Click += sanPhamTuNhatBanBtn_Click;
            // 
            // sanPhamCoDGCaoNhatBtn
            // 
            sanPhamCoDGCaoNhatBtn.Location = new Point(172, 19);
            sanPhamCoDGCaoNhatBtn.Name = "sanPhamCoDGCaoNhatBtn";
            sanPhamCoDGCaoNhatBtn.Size = new Size(103, 58);
            sanPhamCoDGCaoNhatBtn.TabIndex = 15;
            sanPhamCoDGCaoNhatBtn.Text = "1 SP có ĐG cao nhất";
            sanPhamCoDGCaoNhatBtn.UseVisualStyleBackColor = true;
            sanPhamCoDGCaoNhatBtn.Click += sanPhamCoDGCaoNhatBtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(313, 0);
            label3.Name = "label3";
            label3.Size = new Size(177, 20);
            label3.TabIndex = 13;
            label3.Text = "Chọn chức năng tìm kiếm";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 330);
            label4.Name = "label4";
            label4.Size = new Size(231, 20);
            label4.TabIndex = 13;
            label4.Text = "Danh sách sản phẩm sau khi nhập";
            // 
            // dgv
            // 
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            dgv.Location = new Point(15, 353);
            dgv.Name = "dgv";
            dgv.ReadOnly = true;
            dgv.RowHeadersVisible = false;
            dgv.RowHeadersWidth = 51;
            dgv.RowTemplate.Height = 29;
            dgv.Size = new Size(710, 202);
            dgv.TabIndex = 21;
            // 
            // Column1
            // 
            Column1.HeaderText = "Mã SP";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 80;
            // 
            // Column2
            // 
            Column2.HeaderText = "Tên SP";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "Số lượng";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "Đơn giá";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 125;
            // 
            // Column5
            // 
            Column5.HeaderText = "Xuất xứ";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Width = 125;
            // 
            // Column6
            // 
            Column6.HeaderText = "Ngày hết hạn";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            Column6.Width = 125;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(881, 330);
            label5.Name = "label5";
            label5.Size = new Size(101, 20);
            label5.TabIndex = 22;
            label5.Text = "Chọn thao tác";
            // 
            // panel3
            // 
            panel3.Controls.Add(delSanPhamQuaHanBtn);
            panel3.Controls.Add(delAllBtn);
            panel3.Controls.Add(btnSanPhamHopLe);
            panel3.Controls.Add(delXuatXu);
            panel3.Controls.Add(delXuatXuBtn);
            panel3.Location = new Point(780, 353);
            panel3.Name = "panel3";
            panel3.Size = new Size(307, 202);
            panel3.TabIndex = 23;
            // 
            // delSanPhamQuaHanBtn
            // 
            delSanPhamQuaHanBtn.Location = new Point(154, 131);
            delSanPhamQuaHanBtn.Name = "delSanPhamQuaHanBtn";
            delSanPhamQuaHanBtn.Size = new Size(135, 58);
            delSanPhamQuaHanBtn.TabIndex = 24;
            delSanPhamQuaHanBtn.Text = "Xóa toàn bộ SP quá hạn";
            delSanPhamQuaHanBtn.UseVisualStyleBackColor = true;
            delSanPhamQuaHanBtn.Click += delSanPhamQuaHanBtn_Click;
            // 
            // delAllBtn
            // 
            delAllBtn.Location = new Point(15, 131);
            delAllBtn.Name = "delAllBtn";
            delAllBtn.Size = new Size(133, 58);
            delAllBtn.TabIndex = 23;
            delAllBtn.Text = "Xóa toàn bộ SP trong kho";
            delAllBtn.UseVisualStyleBackColor = true;
            delAllBtn.Click += delAllBtn_Click;
            // 
            // btnSanPhamHopLe
            // 
            btnSanPhamHopLe.Location = new Point(13, 67);
            btnSanPhamHopLe.Name = "btnSanPhamHopLe";
            btnSanPhamHopLe.Size = new Size(276, 58);
            btnSanPhamHopLe.TabIndex = 22;
            btnSanPhamHopLe.Text = "Kiểm tra SP có quá hạn hay không?";
            btnSanPhamHopLe.UseVisualStyleBackColor = true;
            btnSanPhamHopLe.Click += btnSanPhamHopLe_Click;
            // 
            // delXuatXu
            // 
            delXuatXu.Location = new Point(168, 19);
            delXuatXu.Name = "delXuatXu";
            delXuatXu.Size = new Size(121, 27);
            delXuatXu.TabIndex = 21;
            // 
            // delXuatXuBtn
            // 
            delXuatXuBtn.Location = new Point(13, 3);
            delXuatXuBtn.Name = "delXuatXuBtn";
            delXuatXuBtn.Size = new Size(119, 58);
            delXuatXuBtn.TabIndex = 21;
            delXuatXuBtn.Text = "Xóa SP theo xuất xứ bất kỳ";
            delXuatXuBtn.UseVisualStyleBackColor = true;
            delXuatXuBtn.Click += delXuatXuBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1135, 606);
            Controls.Add(panel3);
            Controls.Add(label5);
            Controls.Add(dgv);
            Controls.Add(label4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label xuatxu;
        private Label dongia;
        private Label soluong;
        private Label tensp;
        private Label masp;
        private Label label1;
        private Panel panel2;
        private DateTimePicker ngayhethan;
        private TextBox tbxuatxu;
        private TextBox tbdongia;
        private TextBox tbsoluong;
        private TextBox tbtensp;
        private TextBox tbmasp;
        private TextBox tbB;
        private TextBox tbA;
        private Button sanPhamTrongPhamViBtn;
        private Button sanPhamQuaHanBtn;
        private Button sanPhamTuNhatBanBtn;
        private Button sanPhamCoDGCaoNhatBtn;
        private Label label3;
        private Label label4;
        private DataGridView dgv;
        private Label label5;
        private Panel panel3;
        private Button delSanPhamQuaHanBtn;
        private Button delAllBtn;
        private Button btnSanPhamHopLe;
        private TextBox delXuatXu;
        private Button delXuatXuBtn;
        private Button delBtn;
        private Button addBtn;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridView dgv2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}