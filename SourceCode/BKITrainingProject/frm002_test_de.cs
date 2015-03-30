using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using IP.Core.IPCommon;
using BKITrainingDS;
using BKITrainingDS.CDBNames;
using BKITrainingUS;


namespace BKITrainingForm
{
    public partial class frm002_test_de : Form
    {
        public frm002_test_de()
        {
            InitializeComponent();
            format_controls();
        }



        #region Public Interface
        public void insert_data()
        {
            this.ShowDialog();
        }
        #endregion

        #region Data Structures
        #endregion

        #region Members
        US_TEST m_us_test = new US_TEST();
        #endregion

        #region Private Methods
        private void format_controls()
        {
            CControlFormat.setFormStyle(this);          
            set_define_events();
        }
        private void form_2_us_object()
        {
            m_us_test.strNAME = m_txt_name.Text;
            m_us_test.dcAGES = CIPConvert.ToDecimal(m_txt_age.Text);
            m_us_test.datBIRDDAY = m_dat_birthday.Value.Date;

        }
        private void save_data()
        {
            form_2_us_object();
            m_us_test.Insert();
            BaseMessages.MsgBox_Infor("Bạn đã lưu thành công");
            this.Close();
        }
        #endregion

        //
        //
        //
        // event handers
        //
        private void set_define_events()
        {
            this.Load += new EventHandler(frm002_test_de_Load);
            this.m_cmd_luu.Click += new EventHandler(m_cmd_luu_Click);
            this.m_cmd_thoat.Click += new EventHandler(m_cmd_thoat_Click);
        }

        void m_cmd_luu_Click(object sender, EventArgs e)
        {
            try
            {
                save_data();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_thoat_Click(object sender, EventArgs e)
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

        void frm002_test_de_Load(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
    }
}