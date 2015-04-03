namespace BKITrainingMain
{
    partial class F004_DM_MON_HOC_DE
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
            this.m_txt_ma_mon = new System.Windows.Forms.TextBox();
            this.m_lbl_ma_mon = new System.Windows.Forms.Label();
            this.m_lbl_ten_mon = new System.Windows.Forms.Label();
            this.m_txt_ten_mon = new System.Windows.Forms.TextBox();
            this.m_cmd_thoat = new System.Windows.Forms.Button();
            this.m_cmd_luu = new System.Windows.Forms.Button();
            this.m_lbl_so_chi = new System.Windows.Forms.Label();
            this.m_txt_so_chi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // m_txt_ma_mon
            // 
            this.m_txt_ma_mon.Location = new System.Drawing.Point(96, 30);
            this.m_txt_ma_mon.Name = "m_txt_ma_mon";
            this.m_txt_ma_mon.Size = new System.Drawing.Size(167, 20);
            this.m_txt_ma_mon.TabIndex = 4;
            // 
            // m_lbl_ma_mon
            // 
            this.m_lbl_ma_mon.AutoSize = true;
            this.m_lbl_ma_mon.Location = new System.Drawing.Point(20, 33);
            this.m_lbl_ma_mon.Name = "m_lbl_ma_mon";
            this.m_lbl_ma_mon.Size = new System.Drawing.Size(46, 13);
            this.m_lbl_ma_mon.TabIndex = 3;
            this.m_lbl_ma_mon.Text = "Mã Môn";
            // 
            // m_lbl_ten_mon
            // 
            this.m_lbl_ten_mon.AutoSize = true;
            this.m_lbl_ten_mon.Location = new System.Drawing.Point(20, 91);
            this.m_lbl_ten_mon.Name = "m_lbl_ten_mon";
            this.m_lbl_ten_mon.Size = new System.Drawing.Size(50, 13);
            this.m_lbl_ten_mon.TabIndex = 3;
            this.m_lbl_ten_mon.Text = "Tên Môn";
            // 
            // m_txt_ten_mon
            // 
            this.m_txt_ten_mon.Location = new System.Drawing.Point(96, 91);
            this.m_txt_ten_mon.Name = "m_txt_ten_mon";
            this.m_txt_ten_mon.Size = new System.Drawing.Size(167, 20);
            this.m_txt_ten_mon.TabIndex = 4;
            // 
            // m_cmd_thoat
            // 
            this.m_cmd_thoat.Location = new System.Drawing.Point(202, 220);
            this.m_cmd_thoat.Name = "m_cmd_thoat";
            this.m_cmd_thoat.Size = new System.Drawing.Size(85, 41);
            this.m_cmd_thoat.TabIndex = 6;
            this.m_cmd_thoat.Text = "Thoát";
            this.m_cmd_thoat.UseVisualStyleBackColor = true;
            // 
            // m_cmd_luu
            // 
            this.m_cmd_luu.Location = new System.Drawing.Point(-3, 220);
            this.m_cmd_luu.Name = "m_cmd_luu";
            this.m_cmd_luu.Size = new System.Drawing.Size(99, 41);
            this.m_cmd_luu.TabIndex = 7;
            this.m_cmd_luu.Text = "Lưu";
            this.m_cmd_luu.UseVisualStyleBackColor = true;
            // 
            // m_lbl_so_chi
            // 
            this.m_lbl_so_chi.AutoSize = true;
            this.m_lbl_so_chi.Location = new System.Drawing.Point(20, 147);
            this.m_lbl_so_chi.Name = "m_lbl_so_chi";
            this.m_lbl_so_chi.Size = new System.Drawing.Size(58, 13);
            this.m_lbl_so_chi.TabIndex = 3;
            this.m_lbl_so_chi.Text = "Số Tín Chỉ";
            // 
            // m_txt_so_chi
            // 
            this.m_txt_so_chi.Location = new System.Drawing.Point(96, 144);
            this.m_txt_so_chi.Name = "m_txt_so_chi";
            this.m_txt_so_chi.Size = new System.Drawing.Size(167, 20);
            this.m_txt_so_chi.TabIndex = 4;
            // 
            // F004_DM_MON_HOC_DE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.m_cmd_thoat);
            this.Controls.Add(this.m_cmd_luu);
            this.Controls.Add(this.m_txt_so_chi);
            this.Controls.Add(this.m_txt_ten_mon);
            this.Controls.Add(this.m_lbl_so_chi);
            this.Controls.Add(this.m_txt_ma_mon);
            this.Controls.Add(this.m_lbl_ten_mon);
            this.Controls.Add(this.m_lbl_ma_mon);
            this.Name = "F004_DM_MON_HOC_DE";
            this.Text = "F003_DM_MON_HOC_DE";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox m_txt_ma_mon;
        private System.Windows.Forms.Label m_lbl_ma_mon;
        private System.Windows.Forms.Label m_lbl_ten_mon;
        private System.Windows.Forms.TextBox m_txt_ten_mon;
        private System.Windows.Forms.Button m_cmd_thoat;
        private System.Windows.Forms.Button m_cmd_luu;
        private System.Windows.Forms.Label m_lbl_so_chi;
        private System.Windows.Forms.TextBox m_txt_so_chi;
    }
}