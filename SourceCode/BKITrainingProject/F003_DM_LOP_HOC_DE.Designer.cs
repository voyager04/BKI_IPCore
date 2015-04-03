namespace BKITrainingMain
{
    partial class F003_DM_LOP_HOC_DE
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
            this.m_txt_ma_lop = new System.Windows.Forms.TextBox();
            this.m_lbl_ma_lop = new System.Windows.Forms.Label();
            this.m_lbl_ten_lop = new System.Windows.Forms.Label();
            this.m_txt_ten_lop = new System.Windows.Forms.TextBox();
            this.m_cmd_thoat = new System.Windows.Forms.Button();
            this.m_cmd_luu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // m_txt_ma_lop
            // 
            this.m_txt_ma_lop.Location = new System.Drawing.Point(97, 50);
            this.m_txt_ma_lop.Name = "m_txt_ma_lop";
            this.m_txt_ma_lop.Size = new System.Drawing.Size(167, 20);
            this.m_txt_ma_lop.TabIndex = 4;
            // 
            // m_lbl_ma_lop
            // 
            this.m_lbl_ma_lop.AutoSize = true;
            this.m_lbl_ma_lop.Location = new System.Drawing.Point(21, 53);
            this.m_lbl_ma_lop.Name = "m_lbl_ma_lop";
            this.m_lbl_ma_lop.Size = new System.Drawing.Size(43, 13);
            this.m_lbl_ma_lop.TabIndex = 3;
            this.m_lbl_ma_lop.Text = "Mã Lớp";
            // 
            // m_lbl_ten_lop
            // 
            this.m_lbl_ten_lop.AutoSize = true;
            this.m_lbl_ten_lop.Location = new System.Drawing.Point(21, 114);
            this.m_lbl_ten_lop.Name = "m_lbl_ten_lop";
            this.m_lbl_ten_lop.Size = new System.Drawing.Size(43, 13);
            this.m_lbl_ten_lop.TabIndex = 3;
            this.m_lbl_ten_lop.Text = "Tên lớp";
            // 
            // m_txt_ten_lop
            // 
            this.m_txt_ten_lop.Location = new System.Drawing.Point(97, 111);
            this.m_txt_ten_lop.Name = "m_txt_ten_lop";
            this.m_txt_ten_lop.Size = new System.Drawing.Size(167, 20);
            this.m_txt_ten_lop.TabIndex = 4;
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
            // F003_DM_LOP_HOC_DE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.m_cmd_thoat);
            this.Controls.Add(this.m_cmd_luu);
            this.Controls.Add(this.m_txt_ten_lop);
            this.Controls.Add(this.m_txt_ma_lop);
            this.Controls.Add(this.m_lbl_ten_lop);
            this.Controls.Add(this.m_lbl_ma_lop);
            this.Name = "F003_DM_LOP_HOC_DE";
            this.Text = "F003_DM_LOP_HOC_DE";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox m_txt_ma_lop;
        private System.Windows.Forms.Label m_lbl_ma_lop;
        private System.Windows.Forms.Label m_lbl_ten_lop;
        private System.Windows.Forms.TextBox m_txt_ten_lop;
        private System.Windows.Forms.Button m_cmd_thoat;
        private System.Windows.Forms.Button m_cmd_luu;
    }
}