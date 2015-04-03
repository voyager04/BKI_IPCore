using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using IP.Core.IPCommon;
using BKITrainingUS;
using BKITrainingDS;
using BKITrainingDS.CDBNames;
namespace BKITrainingMain
{
    public partial class F004_DM_MON_HOC_DE : Form
    {
        public F004_DM_MON_HOC_DE()
        {
            InitializeComponent();
            format_controls();
        }

        #region Public interface
        public void display(US_DM_MON_HOC ip_us_mon_hoc)
        {
            m_us_dm_mon_hoc = ip_us_mon_hoc;
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
        /// <param name="ip_us_dm_lop_hoc"></param>
        public void display_for_update(US_DM_MON_HOC ip_us_mon_hoc)
        {
            m_us_dm_mon_hoc = ip_us_mon_hoc;
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
        US_DM_MON_HOC m_us_dm_mon_hoc=new US_DM_MON_HOC();
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
            m_txt_ma_mon.Text = m_us_dm_mon_hoc.strMA_MON;
            m_txt_ten_mon.Text = m_us_dm_mon_hoc.strTEN_MON;
            m_txt_so_chi.Text = m_us_dm_mon_hoc.strSO_TIN_CHI;

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

            if (!CValidateTextBox.IsValid(m_txt_ma_mon, DataType.StringType, allowNull.NO, true))
            {
                return false;
            }
            if (!check_validate_unique_ma_mon_hoc(m_us_dm_mon_hoc, m_txt_ma_mon))
            {
                return false;
            }

            if (!CValidateTextBox.IsValid(m_txt_ten_mon, DataType.StringType, allowNull.YES, true))
            {
                return false;

            }
            if (!CValidateTextBox.IsValid(m_txt_so_chi, DataType.StringType, allowNull.YES, true))
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
            m_us_dm_mon_hoc.strMA_MON = m_txt_ma_mon.Text.Trim();
            m_us_dm_mon_hoc.strTEN_MON = m_txt_ten_mon.Text.Trim();
            m_us_dm_mon_hoc.strSO_TIN_CHI = m_txt_so_chi.Text.Trim();
        }
        private void form_2_us_object_ma_mon()
        {
            m_us_dm_mon_hoc.strMA_MON = m_txt_ma_mon.Text.Trim();
        }
        /// <summary>
        /// Đây là phương thức dùng để save dữ liệu
        /// </summary>
        private void save_data()
        {
            form_2_us_object_ma_mon();
            if (check_data_is_ok() == false) return;
            form_2_us_object();
            switch (m_e_form_mode)
            {
                case DataEntryFormMode.InsertDataState:
                    m_us_dm_mon_hoc.Insert();
                    break;
                case DataEntryFormMode.UpdateDataState:
                    m_us_dm_mon_hoc.Update();
                    break;
            }
            BaseMessages.MsgBox_Infor("Dữ liệu đã được cập nhât!");
            this.Close();
        }
        private bool check_validate_unique_ma_mon_hoc(US_DM_MON_HOC ip_us_dm_mon_hoc, TextBox ip_txt_validate)
        {
            DS_DM_MON_HOC v_ds = new DS_DM_MON_HOC();                                       //khởi tạo dataset
            new US_DM_MON_HOC().FillDatasetSearchByMaMon(v_ds, ip_us_dm_mon_hoc.strMA_MON);
            if (m_e_form_mode == DataEntryFormMode.InsertDataState)
            {
                if (v_ds.DM_MON_HOC.Count > 0)
                {
                    BaseMessages.MsgBox_Infor("Không nhập mã môn đã trùng!");
                    ip_txt_validate.Focus();
                    return false;
                }
            }
            else if (m_e_form_mode == DataEntryFormMode.UpdateDataState)
            {
                
                if (v_ds.DM_MON_HOC.Count > 0)
                {
                    if (v_ds.Tables[0].Rows[0][DM_MON_HOC.MA_MON].ToString() == ip_us_dm_mon_hoc.strMA_MON)
                    {
                        return true;
                    }
                    else
                    {
                        BaseMessages.MsgBox_Infor("Không nhập mã môn đã trùng!");
                        ip_txt_validate.Focus();
                        return false;
                    }

                }
            }

            return true;
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
            this.Load += new EventHandler(F003_DM_LOP_HOC_DE_Load);
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

        void F003_DM_LOP_HOC_DE_Load(object sender, EventArgs e)
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

        public US_DM_MON_HOC ip_us_mon_hoc { get; set; }
    }
}
