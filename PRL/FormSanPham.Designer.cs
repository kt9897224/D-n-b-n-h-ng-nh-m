﻿namespace PRL
{
    partial class FormSanPham
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
            groupBox2 = new GroupBox();
            btn_thanhtoan = new Button();
            dataGridView2 = new DataGridView();
            groupBox1 = new GroupBox();
            button1 = new Button();
            btn_SuaHD = new Button();
            btn_themHD = new Button();
            dataGridView1 = new DataGridView();
            lb_next = new Label();
            lb_page = new Label();
            lb_back = new Label();
            tlp_SanPham = new TableLayoutPanel();
            btn_QLSP = new Button();
            btn_ShowSP = new Button();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btn_thanhtoan);
            groupBox2.Controls.Add(dataGridView2);
            groupBox2.Location = new Point(1339, 389);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(529, 345);
            groupBox2.TabIndex = 12;
            groupBox2.TabStop = false;
            groupBox2.Text = "Sản phẩm trong hóa đơn ";
            // 
            // btn_thanhtoan
            // 
            btn_thanhtoan.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_thanhtoan.Location = new Point(209, 301);
            btn_thanhtoan.Name = "btn_thanhtoan";
            btn_thanhtoan.Size = new Size(149, 29);
            btn_thanhtoan.TabIndex = 3;
            btn_thanhtoan.Text = "Thanh Toán ";
            btn_thanhtoan.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(16, 41);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(507, 244);
            dataGridView2.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(btn_SuaHD);
            groupBox1.Controls.Add(btn_themHD);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Location = new Point(1341, 15);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(527, 340);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Hóa đơn";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            button1.Location = new Point(77, 40);
            button1.Name = "button1";
            button1.Size = new Size(118, 29);
            button1.TabIndex = 3;
            button1.Text = "Tạo Hóa Đơn";
            button1.UseVisualStyleBackColor = true;
            // 
            // btn_SuaHD
            // 
            btn_SuaHD.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_SuaHD.Location = new Point(390, 35);
            btn_SuaHD.Name = "btn_SuaHD";
            btn_SuaHD.Size = new Size(94, 29);
            btn_SuaHD.TabIndex = 2;
            btn_SuaHD.Text = "Sửa HĐ";
            btn_SuaHD.UseVisualStyleBackColor = true;
            // 
            // btn_themHD
            // 
            btn_themHD.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_themHD.Location = new Point(253, 40);
            btn_themHD.Name = "btn_themHD";
            btn_themHD.Size = new Size(94, 29);
            btn_themHD.TabIndex = 1;
            btn_themHD.Text = "Thêm HĐ";
            btn_themHD.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(13, 75);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(508, 259);
            dataGridView1.TabIndex = 0;
            // 
            // lb_next
            // 
            lb_next.AutoSize = true;
            lb_next.Location = new Point(829, 748);
            lb_next.Name = "lb_next";
            lb_next.Size = new Size(39, 20);
            lb_next.TabIndex = 8;
            lb_next.Text = ">>>";
            // 
            // lb_page
            // 
            lb_page.AutoSize = true;
            lb_page.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            lb_page.Location = new Point(767, 742);
            lb_page.Name = "lb_page";
            lb_page.Size = new Size(27, 31);
            lb_page.TabIndex = 9;
            lb_page.Text = "1";
            // 
            // lb_back
            // 
            lb_back.AutoSize = true;
            lb_back.Location = new Point(687, 746);
            lb_back.Name = "lb_back";
            lb_back.Size = new Size(39, 20);
            lb_back.TabIndex = 10;
            lb_back.Text = "<<<";
            // 
            // tlp_SanPham
            // 
            tlp_SanPham.ColumnCount = 2;
            tlp_SanPham.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlp_SanPham.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlp_SanPham.Location = new Point(223, 14);
            tlp_SanPham.Name = "tlp_SanPham";
            tlp_SanPham.RowCount = 2;
            tlp_SanPham.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlp_SanPham.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlp_SanPham.Size = new Size(1110, 720);
            tlp_SanPham.TabIndex = 7;
            // 
            // btn_QLSP
            // 
            btn_QLSP.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_QLSP.Location = new Point(12, 97);
            btn_QLSP.Name = "btn_QLSP";
            btn_QLSP.Size = new Size(184, 66);
            btn_QLSP.TabIndex = 5;
            btn_QLSP.Text = "Quản lý SP";
            btn_QLSP.UseVisualStyleBackColor = true;
            // 
            // btn_ShowSP
            // 
            btn_ShowSP.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_ShowSP.Location = new Point(12, 14);
            btn_ShowSP.Name = "btn_ShowSP";
            btn_ShowSP.Size = new Size(184, 65);
            btn_ShowSP.TabIndex = 6;
            btn_ShowSP.Text = "Hiển thị SP";
            btn_ShowSP.UseVisualStyleBackColor = true;
            // 
            // FormSanPham
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1880, 786);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(lb_next);
            Controls.Add(lb_page);
            Controls.Add(lb_back);
            Controls.Add(tlp_SanPham);
            Controls.Add(btn_QLSP);
            Controls.Add(btn_ShowSP);
            Name = "FormSanPham";
            Text = "FormSanPham";
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox2;
        private Button btn_thanhtoan;
        private DataGridView dataGridView2;
        private GroupBox groupBox1;
        private Button button1;
        private Button btn_SuaHD;
        private Button btn_themHD;
        private DataGridView dataGridView1;
        private Label lb_next;
        private Label lb_page;
        private Label lb_back;
        private TableLayoutPanel tlp_SanPham;
        private Button btn_QLSP;
        private Button btn_ShowSP;
    }
}