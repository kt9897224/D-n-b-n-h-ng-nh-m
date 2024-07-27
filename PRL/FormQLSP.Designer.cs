namespace PRL
{
    partial class FormQLSP
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
            dtg_AllSP = new DataGridView();
            tbt_Timkiem = new TextBox();
            btn_AnSP = new Button();
            Btn_Sua = new Button();
            btn_Them = new Button();
            cbb_Trangthai = new ComboBox();
            tb_Gia = new TextBox();
            tb_Soluong = new TextBox();
            tb_Ten = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ptb_Mota = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dtg_AllSP).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptb_Mota).BeginInit();
            SuspendLayout();
            // 
            // dtg_AllSP
            // 
            dtg_AllSP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_AllSP.Location = new Point(12, 397);
            dtg_AllSP.Name = "dtg_AllSP";
            dtg_AllSP.RowHeadersWidth = 51;
            dtg_AllSP.Size = new Size(943, 288);
            dtg_AllSP.TabIndex = 23;
            // 
            // tbt_Timkiem
            // 
            tbt_Timkiem.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            tbt_Timkiem.Location = new Point(12, 344);
            tbt_Timkiem.Name = "tbt_Timkiem";
            tbt_Timkiem.PlaceholderText = "Nhập sản phẩm để tìm kiếm ";
            tbt_Timkiem.Size = new Size(943, 34);
            tbt_Timkiem.TabIndex = 22;
            // 
            // btn_AnSP
            // 
            btn_AnSP.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_AnSP.Location = new Point(753, 287);
            btn_AnSP.Name = "btn_AnSP";
            btn_AnSP.Size = new Size(202, 51);
            btn_AnSP.TabIndex = 19;
            btn_AnSP.Text = "Ẩn SP";
            btn_AnSP.UseVisualStyleBackColor = true;
            // 
            // Btn_Sua
            // 
            Btn_Sua.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            Btn_Sua.Location = new Point(532, 287);
            Btn_Sua.Name = "Btn_Sua";
            Btn_Sua.Size = new Size(202, 51);
            Btn_Sua.TabIndex = 20;
            Btn_Sua.Text = "Sửa";
            Btn_Sua.UseVisualStyleBackColor = true;
            // 
            // btn_Them
            // 
            btn_Them.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_Them.Location = new Point(303, 287);
            btn_Them.Name = "btn_Them";
            btn_Them.Size = new Size(202, 51);
            btn_Them.TabIndex = 21;
            btn_Them.Text = "Thêm mới";
            btn_Them.UseVisualStyleBackColor = true;
            // 
            // cbb_Trangthai
            // 
            cbb_Trangthai.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            cbb_Trangthai.FormattingEnabled = true;
            cbb_Trangthai.Location = new Point(447, 211);
            cbb_Trangthai.Name = "cbb_Trangthai";
            cbb_Trangthai.Size = new Size(508, 36);
            cbb_Trangthai.TabIndex = 18;
            cbb_Trangthai.Text = "Chọn trạng thái ";
            // 
            // tb_Gia
            // 
            tb_Gia.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            tb_Gia.Location = new Point(447, 144);
            tb_Gia.Name = "tb_Gia";
            tb_Gia.PlaceholderText = "Nhập giá";
            tb_Gia.Size = new Size(508, 34);
            tb_Gia.TabIndex = 15;
            // 
            // tb_Soluong
            // 
            tb_Soluong.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            tb_Soluong.Location = new Point(447, 80);
            tb_Soluong.Name = "tb_Soluong";
            tb_Soluong.PlaceholderText = "Nhập số lượng ";
            tb_Soluong.Size = new Size(508, 34);
            tb_Soluong.TabIndex = 16;
            // 
            // tb_Ten
            // 
            tb_Ten.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            tb_Ten.Location = new Point(447, 18);
            tb_Ten.Name = "tb_Ten";
            tb_Ten.PlaceholderText = "Nhập tên";
            tb_Ten.Size = new Size(508, 34);
            tb_Ten.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.Location = new Point(303, 219);
            label4.Name = "label4";
            label4.Size = new Size(114, 28);
            label4.TabIndex = 14;
            label4.Text = "Trạng thái ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(303, 150);
            label3.Name = "label3";
            label3.Size = new Size(43, 28);
            label3.TabIndex = 13;
            label3.Text = "Giá";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(303, 86);
            label2.Name = "label2";
            label2.Size = new Size(103, 28);
            label2.TabIndex = 12;
            label2.Text = "Số lượng ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(303, 18);
            label1.Name = "label1";
            label1.Size = new Size(45, 28);
            label1.TabIndex = 11;
            label1.Text = "Tên";
            // 
            // ptb_Mota
            // 
            ptb_Mota.BackColor = Color.FromArgb(255, 128, 0);
            ptb_Mota.Location = new Point(12, 18);
            ptb_Mota.Name = "ptb_Mota";
            ptb_Mota.Size = new Size(261, 269);
            ptb_Mota.TabIndex = 10;
            ptb_Mota.TabStop = false;
            // 
            // FormQLSP
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Coral;
            ClientSize = new Size(967, 703);
            Controls.Add(dtg_AllSP);
            Controls.Add(tbt_Timkiem);
            Controls.Add(btn_AnSP);
            Controls.Add(Btn_Sua);
            Controls.Add(btn_Them);
            Controls.Add(cbb_Trangthai);
            Controls.Add(tb_Gia);
            Controls.Add(tb_Soluong);
            Controls.Add(tb_Ten);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ptb_Mota);
            Name = "FormQLSP";
            Text = "FormQLSP";
            ((System.ComponentModel.ISupportInitialize)dtg_AllSP).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptb_Mota).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtg_AllSP;
        private TextBox tbt_Timkiem;
        private Button btn_AnSP;
        private Button Btn_Sua;
        private Button btn_Them;
        private ComboBox cbb_Trangthai;
        private TextBox tb_Gia;
        private TextBox tb_Soluong;
        private TextBox tb_Ten;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox ptb_Mota;
    }
}