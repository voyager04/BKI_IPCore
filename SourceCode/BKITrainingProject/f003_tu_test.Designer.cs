namespace BKITrainingForm
{
    partial class f003_tu_test
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f003_tu_test));
            this.m_fg = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.panel1 = new System.Windows.Forms.Panel();
            this.m_cmd_thoat = new SIS.Controls.Button.SiSButton();
            this.m_cmd_xoa = new SIS.Controls.Button.SiSButton();
            this.m_cmd_sua = new SIS.Controls.Button.SiSButton();
            this.m_cmd_them = new SIS.Controls.Button.SiSButton();
            ((System.ComponentModel.ISupportInitialize)(this.m_fg)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_fg
            // 
            this.m_fg.ColumnInfo = resources.GetString("m_fg.ColumnInfo");
            this.m_fg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_fg.Location = new System.Drawing.Point(0, 0);
            this.m_fg.Name = "m_fg";
            this.m_fg.Size = new System.Drawing.Size(583, 292);
            this.m_fg.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("m_fg.Styles"));
            this.m_fg.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.m_cmd_thoat);
            this.panel1.Controls.Add(this.m_cmd_xoa);
            this.panel1.Controls.Add(this.m_cmd_sua);
            this.panel1.Controls.Add(this.m_cmd_them);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 292);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(583, 40);
            this.panel1.TabIndex = 3;
            // 
            // m_cmd_thoat
            // 
            this.m_cmd_thoat.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_thoat.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_thoat.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_thoat.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_thoat.Location = new System.Drawing.Point(508, 0);
            this.m_cmd_thoat.Name = "m_cmd_thoat";
            this.m_cmd_thoat.Size = new System.Drawing.Size(75, 40);
            this.m_cmd_thoat.TabIndex = 3;
            this.m_cmd_thoat.Text = "Thoát";
            this.m_cmd_thoat.UseVisualStyleBackColor = true;
            // 
            // m_cmd_xoa
            // 
            this.m_cmd_xoa.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_xoa.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_xoa.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_xoa.Dock = System.Windows.Forms.DockStyle.Left;
            this.m_cmd_xoa.Location = new System.Drawing.Point(204, 0);
            this.m_cmd_xoa.Name = "m_cmd_xoa";
            this.m_cmd_xoa.Size = new System.Drawing.Size(102, 40);
            this.m_cmd_xoa.TabIndex = 2;
            this.m_cmd_xoa.Text = "Xóa";
            this.m_cmd_xoa.UseVisualStyleBackColor = true;
            // 
            // m_cmd_sua
            // 
            this.m_cmd_sua.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_sua.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_sua.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_sua.Dock = System.Windows.Forms.DockStyle.Left;
            this.m_cmd_sua.Location = new System.Drawing.Point(102, 0);
            this.m_cmd_sua.Name = "m_cmd_sua";
            this.m_cmd_sua.Size = new System.Drawing.Size(102, 40);
            this.m_cmd_sua.TabIndex = 1;
            this.m_cmd_sua.Text = "Sửa";
            this.m_cmd_sua.UseVisualStyleBackColor = true;
            // 
            // m_cmd_them
            // 
            this.m_cmd_them.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_them.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_them.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_them.Dock = System.Windows.Forms.DockStyle.Left;
            this.m_cmd_them.Location = new System.Drawing.Point(0, 0);
            this.m_cmd_them.Name = "m_cmd_them";
            this.m_cmd_them.Size = new System.Drawing.Size(102, 40);
            this.m_cmd_them.TabIndex = 0;
            this.m_cmd_them.Text = "Thêm";
            this.m_cmd_them.UseVisualStyleBackColor = true;
            // 
            // f003_tu_test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 332);
            this.Controls.Add(this.m_fg);
            this.Controls.Add(this.panel1);
            this.Name = "f003_tu_test";
            this.Text = "f003_tu_test";
            ((System.ComponentModel.ISupportInitialize)(this.m_fg)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.C1FlexGrid.C1FlexGrid m_fg;
        private System.Windows.Forms.Panel panel1;
        private SIS.Controls.Button.SiSButton m_cmd_thoat;
        private SIS.Controls.Button.SiSButton m_cmd_xoa;
        private SIS.Controls.Button.SiSButton m_cmd_sua;
        private SIS.Controls.Button.SiSButton m_cmd_them;
    }
}