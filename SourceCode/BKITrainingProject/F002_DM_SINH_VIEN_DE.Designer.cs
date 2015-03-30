namespace BKITrainingMain
{
    partial class F002_DM_SINH_VIEN_DE
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.m_txt_ma_sv = new System.Windows.Forms.TextBox();
            this.m_txt_ho_ten = new System.Windows.Forms.TextBox();
            this.m_dat_ngay_sinh = new System.Windows.Forms.DateTimePicker();
            this.m_cmd_luu = new System.Windows.Forms.Button();
            this.m_cmd_thoat = new System.Windows.Forms.Button();
            this.m_cbx_gioitinh = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Sinh Viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ Tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ngày Sinh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Giới Tính";
            // 
            // m_txt_ma_sv
            // 
            this.m_txt_ma_sv.Location = new System.Drawing.Point(91, 27);
            this.m_txt_ma_sv.Name = "m_txt_ma_sv";
            this.m_txt_ma_sv.Size = new System.Drawing.Size(167, 20);
            this.m_txt_ma_sv.TabIndex = 2;
            // 
            // m_txt_ho_ten
            // 
            this.m_txt_ho_ten.Location = new System.Drawing.Point(91, 71);
            this.m_txt_ho_ten.Name = "m_txt_ho_ten";
            this.m_txt_ho_ten.Size = new System.Drawing.Size(167, 20);
            this.m_txt_ho_ten.TabIndex = 2;
            // 
            // m_dat_ngay_sinh
            // 
            this.m_dat_ngay_sinh.CustomFormat = "dd/MM/yyyy";
            this.m_dat_ngay_sinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.m_dat_ngay_sinh.Location = new System.Drawing.Point(91, 116);
            this.m_dat_ngay_sinh.Name = "m_dat_ngay_sinh";
            this.m_dat_ngay_sinh.Size = new System.Drawing.Size(167, 20);
            this.m_dat_ngay_sinh.TabIndex = 4;
            // 
            // m_cmd_luu
            // 
            this.m_cmd_luu.Location = new System.Drawing.Point(0, 220);
            this.m_cmd_luu.Name = "m_cmd_luu";
            this.m_cmd_luu.Size = new System.Drawing.Size(99, 41);
            this.m_cmd_luu.TabIndex = 5;
            this.m_cmd_luu.Text = "Lưu";
            this.m_cmd_luu.UseVisualStyleBackColor = true;
            // 
            // m_cmd_thoat
            // 
            this.m_cmd_thoat.Location = new System.Drawing.Point(202, 220);
            this.m_cmd_thoat.Name = "m_cmd_thoat";
            this.m_cmd_thoat.Size = new System.Drawing.Size(85, 41);
            this.m_cmd_thoat.TabIndex = 5;
            this.m_cmd_thoat.Text = "Thoát";
            this.m_cmd_thoat.UseVisualStyleBackColor = true;
            // 
            // m_cbx_gioitinh
            // 
            this.m_cbx_gioitinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m_cbx_gioitinh.FormattingEnabled = true;
            this.m_cbx_gioitinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.m_cbx_gioitinh.Location = new System.Drawing.Point(91, 155);
            this.m_cbx_gioitinh.Name = "m_cbx_gioitinh";
            this.m_cbx_gioitinh.Size = new System.Drawing.Size(167, 21);
            this.m_cbx_gioitinh.TabIndex = 6;
            // 
            // F002_DM_SINH_VIEN_DE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.m_cbx_gioitinh);
            this.Controls.Add(this.m_cmd_thoat);
            this.Controls.Add(this.m_cmd_luu);
            this.Controls.Add(this.m_dat_ngay_sinh);
            this.Controls.Add(this.m_txt_ho_ten);
            this.Controls.Add(this.m_txt_ma_sv);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "F002_DM_SINH_VIEN_DE";
            this.Text = "F002_DM_SINH_VIEN_DE";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox m_txt_ma_sv;
        private System.Windows.Forms.TextBox m_txt_ho_ten;
        private System.Windows.Forms.DateTimePicker m_dat_ngay_sinh;
        private System.Windows.Forms.Button m_cmd_luu;
        private System.Windows.Forms.Button m_cmd_thoat;
        private System.Windows.Forms.ComboBox m_cbx_gioitinh;
    }
}