using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using IP.Core.IPCommon;
using BKITrainingDS;
using BKITrainingDS.CDBNames;
using BKITrainingUS;
using System.Data;

namespace BKITrainingMain
{
	/// <summary>
	/// Summary description for f001_main_form.
	/// </summary>
	public class f001_main_form : System.Windows.Forms.Form
    {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public f001_main_form()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
            format_controls();
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhSáchNgườiSửDụngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhMụcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhSáchLớpIPCoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hiênThịThôngBáoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sinhViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lớpHọcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.m_tsm_mon_hoc = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.danhMụcToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(613, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.danhSáchNgườiSửDụngToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // danhSáchNgườiSửDụngToolStripMenuItem
            // 
            this.danhSáchNgườiSửDụngToolStripMenuItem.Name = "danhSáchNgườiSửDụngToolStripMenuItem";
            this.danhSáchNgườiSửDụngToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.danhSáchNgườiSửDụngToolStripMenuItem.Text = "Danh sách người sử dụng";
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // danhMụcToolStripMenuItem
            // 
            this.danhMụcToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.danhSáchLớpIPCoreToolStripMenuItem,
            this.hiênThịThôngBáoToolStripMenuItem,
            this.sinhViênToolStripMenuItem,
            this.lớpHọcToolStripMenuItem,
            this.m_tsm_mon_hoc});
            this.danhMụcToolStripMenuItem.Name = "danhMụcToolStripMenuItem";
            this.danhMụcToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.danhMụcToolStripMenuItem.Text = "Danh mục";
            this.danhMụcToolStripMenuItem.Click += new System.EventHandler(this.danhMụcToolStripMenuItem_Click);
            // 
            // danhSáchLớpIPCoreToolStripMenuItem
            // 
            this.danhSáchLớpIPCoreToolStripMenuItem.Name = "danhSáchLớpIPCoreToolStripMenuItem";
            this.danhSáchLớpIPCoreToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.danhSáchLớpIPCoreToolStripMenuItem.Text = "Danh sách lớp IPCore";
            this.danhSáchLớpIPCoreToolStripMenuItem.Click += new System.EventHandler(this.danhSáchLớpIPCoreToolStripMenuItem_Click);
            // 
            // hiênThịThôngBáoToolStripMenuItem
            // 
            this.hiênThịThôngBáoToolStripMenuItem.Name = "hiênThịThôngBáoToolStripMenuItem";
            this.hiênThịThôngBáoToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.hiênThịThôngBáoToolStripMenuItem.Text = "Hiên thị thông báo";
            this.hiênThịThôngBáoToolStripMenuItem.Click += new System.EventHandler(this.hiênThịThôngBáoToolStripMenuItem_Click);
            // 
            // sinhViênToolStripMenuItem
            // 
            this.sinhViênToolStripMenuItem.Name = "sinhViênToolStripMenuItem";
            this.sinhViênToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.sinhViênToolStripMenuItem.Text = "Sinh viên";
            this.sinhViênToolStripMenuItem.Click += new System.EventHandler(this.sinhViênToolStripMenuItem_Click);
            // 
            // lớpHọcToolStripMenuItem
            // 
            this.lớpHọcToolStripMenuItem.Name = "lớpHọcToolStripMenuItem";
            this.lớpHọcToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.lớpHọcToolStripMenuItem.Text = "Lớp học";
            this.lớpHọcToolStripMenuItem.Click += new System.EventHandler(this.lớpHọcToolStripMenuItem_Click_1);
            // 
            // m_tsm_mon_hoc
            // 
            this.m_tsm_mon_hoc.Name = "m_tsm_mon_hoc";
            this.m_tsm_mon_hoc.Size = new System.Drawing.Size(187, 22);
            this.m_tsm_mon_hoc.Text = "Môn Học";
            this.m_tsm_mon_hoc.Click += new System.EventHandler(this.testToolStripMenuItem_Click_1);
            // 
            // f001_main_form
            // 
            this.ClientSize = new System.Drawing.Size(613, 401);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "f001_main_form";
            this.Text = "F001 - Chuong trình dao tao IPCore BKIndex Group";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem hệThốngToolStripMenuItem;
        private ToolStripMenuItem danhSáchNgườiSửDụngToolStripMenuItem;
        private ToolStripMenuItem thoátToolStripMenuItem;
        private ToolStripMenuItem danhMụcToolStripMenuItem;
        private ToolStripMenuItem hiênThịThôngBáoToolStripMenuItem;
        private ToolStripMenuItem sinhViênToolStripMenuItem;
        private ToolStripMenuItem lớpHọcToolStripMenuItem;
        private ToolStripMenuItem m_tsm_mon_hoc;
        private ToolStripMenuItem danhSáchLớpIPCoreToolStripMenuItem;

        #region public Interface
		public void display(){
			this.ShowDialog();
		}
		
		#endregion

       
        #region Data Structures
        private enum eColNumber
        {
            Name =1
            , Age  = 2
            , BirthDay = 3
        }
        #endregion

        #region Members
        ITransferDataRow m_obj_trans;
        #endregion

       
        #region Private Methods
        private void format_controls()
        {
            CControlFormat.setFormStyle(this);
        }
        #endregion
        //
        //
        //   event handlers
        //
        //
        private void danhSáchLớpIPCoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                f200_danh_sach_lop_ipcore v_frm_main = new f200_danh_sach_lop_ipcore();
                v_frm_main.display();
                v_frm_main.Dispose();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                this.Close();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }

        }

        private void hiênThịThôngBáoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                

            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        private void show_dm_sinh_vien()
        {
            try
            {
                F001_DM_SINH_VIEN v_f001_dm_sinh_vien = new F001_DM_SINH_VIEN();
                v_f001_dm_sinh_vien.display();
                v_f001_dm_sinh_vien.Dispose();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        private void show_dm_lop_hoc()
        {
            try
            {
                F003_DM_LOP_HOC v_f003_dm_lop_hoc = new F003_DM_LOP_HOC();
                v_f003_dm_lop_hoc.display();
                v_f003_dm_lop_hoc.Dispose();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        private void show_dm_mon_hoc()
        {
            try
            {
                F004_DM_MON_HOC v_f004_dm_mon_hoc = new F004_DM_MON_HOC();
                v_f004_dm_mon_hoc.display();
                v_f004_dm_mon_hoc.Dispose();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
       
       /* private void show_test() 
        {
            try
            {
                frm400_ANHLT_TEST v_frm400_anhlt_test = new frm400_ANHLT_TEST();
                v_frm400_anhlt_test.display();
                v_frm400_anhlt_test.Dispose();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }    
        }*/

        private void sinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                show_dm_sinh_vien();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void testToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            try
            {
                show_dm_mon_hoc();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void danhMụcToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void lớpHọcToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            try
            {
                show_dm_lop_hoc();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
    }
}
