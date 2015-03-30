using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


using IP.Core.IPCommon;
using BKITrainingDS.CDBNames;
using BKITrainingDS;
using BKITrainingUS;

namespace BKITrainingForm
{
    public partial class f003_tu_test : Form
    {
        public f003_tu_test()
        {
            InitializeComponent();
            format_controls();
        }




        #region Public Interface
        public void display()
        {
            this.ShowDialog();
        }
        #endregion 


        #region Data structures
        private enum eColNumber
        {
            name = 1
            , age = 2
            , birthday = 3
        }
        #endregion



        #region Members
        ITransferDataRow m_obj_trans;
        #endregion


        #region Private methods
        /// <summary>
        /// Phương thức dùng để định dạng control
        /// </summary>
        private void format_controls()
        {
            CControlFormat.setFormStyle(this);
            CControlFormat.setC1FlexFormat(m_fg);
            set_define_events();
        }
        /// <summary>
        /// Khi form bắt đầu load lên sẽ gọi phương thức này
        /// </summary>
        private void set_inital_form_load()
        {
            m_obj_trans = get_object_transfer_data();
            load_data_2_grid();
        }
        /// <summary>
        /// Đây là phương thức sử dụng để tạo ánh xạ giữa lưới và data set
        /// </summary>
        /// <returns></returns>
        private ITransferDataRow get_object_transfer_data()
        {
            Hashtable v_hst = new Hashtable();
            v_hst.Add(TU_TEST.FULL_NAME, eColNumber.name);
            v_hst.Add(TU_TEST.AGE, eColNumber.age);
            v_hst.Add(TU_TEST.BIRTHDAY, eColNumber.birthday);
            DS_TU_TEST v_ds_test = new DS_TU_TEST();
            ITransferDataRow v_obj_trans = new CC1TransferDataRow(m_fg, v_hst, v_ds_test.TU_TEST.NewTU_TESTRow());
            return v_obj_trans;
        }
        /// <summary>
        /// Đây là phương thức đưa dữ liệu lên lưới
        /// </summary>
        private void load_data_2_grid()
        {
            US_TU_TEST v_us_test = new US_TU_TEST();
            DS_TU_TEST v_ds_test = new DS_TU_TEST();
            v_us_test.FillDataset(v_ds_test);
            CGridUtils.Dataset2C1Grid(v_ds_test, m_fg, m_obj_trans);
        }
        /// <summary>
        /// Đây là phương thức đưa dữ liệu từ 1 dòng trên lưới vào US
        /// </summary>
        /// <param name="i_grid_row"> dòng tương ứng</param>
        /// <param name="?"></param>
        private void grid_2_us_object(int i_grid_row, US_TU_TEST op_us){
            DataRow v_dr = (DataRow)m_fg.Rows[i_grid_row].UserData;
            m_obj_trans.GridRow2DataRow(m_fg.Row, v_dr);
            op_us.DataRow2Me(v_dr);
        }
        private void xoa_du_lieu()
        {
            if (CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row) == false) return;
            if (CGridUtils.IsThere_Any_NonFixed_Row(m_fg) == false) return;
            if (BaseMessages.MsgBox_Warning(8) == true) return; // Bạn có thục sự muốn xóa không?
            US_TU_TEST v_us_tu_test = new US_TU_TEST();
            grid_2_us_object(m_fg.Row, v_us_tu_test);
            v_us_tu_test.Delete();
            BaseMessages.MsgBox_Infor("bạn đã xóa thành công!");
            load_data_2_grid();
        }

        private void sua_du_lieu()
        {
            if (CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row) == false) return;
            if (CGridUtils.IsThere_Any_NonFixed_Row(m_fg) == false) return;
            US_TU_TEST v_us_tu_test = new US_TU_TEST();
            grid_2_us_object(m_fg.Row, v_us_tu_test);
            f004_tu_test_de v_f004 = new f004_tu_test_de();
            v_f004.display_for_update(v_us_tu_test);
            load_data_2_grid();
        }

        private void them_du_lieu()
        {
            f004_tu_test_de v_f004 = new f004_tu_test_de();
            v_f004.display_for_insert();
            load_data_2_grid();
        }
        #endregion

    //
    //
    // event handlers
    //
        //
        private void set_define_events()
        {
            this.Load += new EventHandler(f003_tu_test_Load);
            this.m_cmd_thoat.Click += new EventHandler(m_cmd_thoat_Click);
            this.m_cmd_them.Click += new EventHandler(m_cmd_them_Click);
            this.m_cmd_sua.Click += new EventHandler(m_cmd_sua_Click);
            this.m_cmd_xoa.Click += new EventHandler(m_cmd_xoa_Click);
        }

        void m_cmd_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                xoa_du_lieu();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_sua_Click(object sender, EventArgs e)
        {
            try
            {
                sua_du_lieu();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_them_Click(object sender, EventArgs e)
        {
            try
            {
                them_du_lieu();
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

        void f003_tu_test_Load(object sender, EventArgs e)
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
    }
}