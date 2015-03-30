namespace BKITrainingForm
{
    partial class frm002_test_de
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
            this.m_txt_name = new System.Windows.Forms.TextBox();
            this.m_dat_birthday = new System.Windows.Forms.DateTimePicker();
            this.m_txt_age = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.m_cmd_thoat = new SIS.Controls.Button.SiSButton();
            this.m_cmd_luu = new SIS.Controls.Button.SiSButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // m_txt_name
            // 
            this.m_txt_name.Location = new System.Drawing.Point(55, 14);
            this.m_txt_name.Name = "m_txt_name";
            this.m_txt_name.Size = new System.Drawing.Size(185, 20);
            this.m_txt_name.TabIndex = 1;
            // 
            // m_dat_birthday
            // 
            this.m_dat_birthday.CustomFormat = "dd/mm/yyyy";
            this.m_dat_birthday.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.m_dat_birthday.Location = new System.Drawing.Point(56, 88);
            this.m_dat_birthday.Name = "m_dat_birthday";
            this.m_dat_birthday.Size = new System.Drawing.Size(184, 20);
            this.m_dat_birthday.TabIndex = 2;
            // 
            // m_txt_age
            // 
            this.m_txt_age.Location = new System.Drawing.Point(55, 51);
            this.m_txt_age.Name = "m_txt_age";
            this.m_txt_age.Size = new System.Drawing.Size(185, 20);
            this.m_txt_age.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Age";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Birthday";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.m_cmd_thoat);
            this.panel1.Controls.Add(this.m_cmd_luu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 125);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(297, 40);
            this.panel1.TabIndex = 6;
            // 
            // m_cmd_thoat
            // 
            this.m_cmd_thoat.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_thoat.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_thoat.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_thoat.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_thoat.Location = new System.Drawing.Point(222, 0);
            this.m_cmd_thoat.Name = "m_cmd_thoat";
            this.m_cmd_thoat.Size = new System.Drawing.Size(75, 40);
            this.m_cmd_thoat.TabIndex = 3;
            this.m_cmd_thoat.Text = "Thoát";
            this.m_cmd_thoat.UseVisualStyleBackColor = true;
            // 
            // m_cmd_luu
            // 
            this.m_cmd_luu.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_luu.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_luu.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_luu.Dock = System.Windows.Forms.DockStyle.Left;
            this.m_cmd_luu.Location = new System.Drawing.Point(0, 0);
            this.m_cmd_luu.Name = "m_cmd_luu";
            this.m_cmd_luu.Size = new System.Drawing.Size(102, 40);
            this.m_cmd_luu.TabIndex = 1;
            this.m_cmd_luu.Text = "Lưu";
            this.m_cmd_luu.UseVisualStyleBackColor = true;
            // 
            // frm002_test_de
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 165);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.m_txt_age);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.m_dat_birthday);
            this.Controls.Add(this.m_txt_name);
            this.Controls.Add(this.label1);
            this.Name = "frm002_test_de";
            this.Text = "F002 - cap nhat test";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox m_txt_name;
        private System.Windows.Forms.DateTimePicker m_dat_birthday;
        private System.Windows.Forms.TextBox m_txt_age;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private SIS.Controls.Button.SiSButton m_cmd_thoat;
        private SIS.Controls.Button.SiSButton m_cmd_luu;
    }
}