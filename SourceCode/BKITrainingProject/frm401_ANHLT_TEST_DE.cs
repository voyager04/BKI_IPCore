using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using IP.Core.IPCommon;
using BKITrainingUS;

namespace BKITrainingMain
{
    public partial class frm401_ANHLT_TEST_DE : Form
    {
        public frm401_ANHLT_TEST_DE()
        {
            InitializeComponent();
            format_controls();
        }

        #region Public interface
        public void display(US_ANHLT_TEST ip_us_test)
        {
            m_us_anhlt_test = ip_us_test;
            m_e_form_mode = DataEntryFormMode.ViewDataState;
            this.ShowDialog();
        }
        public void display_for_insert()
        {
            m_e_form_mode = DataEntryFormMode.InsertDataState;
            this.ShowDialog();

        }
        /// <summary>
        /// hiển thị form dùng để cập nhật dữ liệu
        /// </summary>
        /// <param name="ip_us_test"></param>
        public void display_for_update(US_ANHLT_TEST ip_us_test)
        {
            m_us_anhlt_test = ip_us_test;
            m_e_form_mode = DataEntryFormMode.UpdateDataState;
            this.ShowDialog();
        }
        #endregion

        #region Data Structures
        #endregion

        #region Members
        /// <summary>
        /// biến dùng để xác định trang thái của form
        /// </summary>
        DataEntryFormMode m_e_form_mode;
        US_ANHLT_TEST m_us_anhlt_test = new US_ANHLT_TEST();
        #endregion

        #region Private Methods
        private void format_controls()
        {
            CControlFormat.setFormStyle(this);
            set_define_events();
        }
        /// <summary>
        /// Đầy là phương thức đưa dữ liệu từ US lên trên form
        /// </summary>
        private void us_object_2_form()
        {
            m_txt_name.Text = m_us_anhlt_test.strFULL_NAME;
            m_txt_address.Text = m_us_anhlt_test.strADDRESS;
            m_dat_birthday.Value = m_us_anhlt_test.datBIRTHDAY;
        }
        private void set_inital_form_load()
        {
            switch (m_e_form_mode)
            {
                case DataEntryFormMode.InsertDataState:
                    break;
                case DataEntryFormMode.UpdateDataState:
                    us_object_2_form();
                    break;
            }
        }
        /// <summary>
        /// kiểm tra dữ liệu ở trên form điền có đúng không?
        /// </summary>
        /// <returns></returns>


        private bool check_data_is_ok()
        {
            if (!CValidateTextBox.IsValid(m_txt_name, DataType.StringType, allowNull.NO, true))
            {
                return false;
            }
            if (!CValidateTextBox.IsValid(m_txt_address, DataType.StringType, allowNull.YES, true))
            {
                return false;

            }
            return true;
        }
        /// <summary>
        /// Đây là phương thức đưa dữ liệu từ form vào us
        /// </summary>
        private void form_2_us_object()
        {
            m_us_anhlt_test.strFULL_NAME = m_txt_name.Text;
            if (m_txt_address.Text == "")
            {
                m_us_anhlt_test.SetADDRESSNull();
            }
            else
            {
                m_us_anhlt_test.strADDRESS = m_txt_address.Text;
            }
            // birthday khong luu gio nen ta phai .Date
            m_us_anhlt_test.datBIRTHDAY = m_dat_birthday.Value.Date;
        }
        /// <summary>
        /// Đây là phương thức dùng để save dữ liệu
        /// </summary>
        private void save_data()
        {
            if (check_data_is_ok() == false) return;
            form_2_us_object();
            switch (m_e_form_mode)
            {
                case DataEntryFormMode.InsertDataState:
                    m_us_anhlt_test.Insert();
                    break;
                case DataEntryFormMode.UpdateDataState:
                    m_us_anhlt_test.Update();
                    break;
            }
            BaseMessages.MsgBox_Infor("Dữ liệu đã được cập nhât!");
            this.Close();
        }
        #endregion

        //
        //
        // event handlers
        //
        //
        private void set_define_events()
        {
            this.m_cmd_thoat.Click += new EventHandler(m_cmd_thoat_Click);
            this.Load += new EventHandler(frm401_ANHLT_TEST_DE_Load);
            this.m_cmd_luu.Click += new EventHandler(m_cmd_luu_Click);
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

        void frm401_ANHLT_TEST_DE_Load(object sender, EventArgs e)
        {
            try
            {
                set_inital_form_load();
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


    }
}
