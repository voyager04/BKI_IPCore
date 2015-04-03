using System;
using System.Diagnostics;
using System.Windows.Forms;

using IP.Core.IPCommon;
using IP.Core.IPSystemAdmin;
using IP.Core.IPBusinessService;
using IP.Core.IPUserService;
using BKITrainingForm;



namespace BKITrainingMain
{
	#region Nhiệm vụ của Class
	//*********************************************************************************
	//*  Là khởi động và điều khiển dăng nhập mới vào  Hệ thống
	//*  - hiện thị form login
	//*  - nếu OK thì tạo context và hiện thị form main, User không muốn vào thì thoát ra
	//*  - nếu trở lại từ main theo kiểu login mới thì lại hiện thị form login
	//*  - nếu trở lại từ main theo kiểu "exit from system" thì thoát
	//*********************************************************************************
#endregion
	public class ApplicationControl
	{
        [STAThread]
		static void Main(){
			
			try {



                /*f005_bkindex_members v_frm_main = new f005_bkindex_members();
				v_frm_main.display();
				v_frm_main.Dispose();*/


               f001_main_form v_frm_main = new f001_main_form();
				v_frm_main.display();
				v_frm_main.Dispose();
                
				
			}		
			catch  (Exception v_e) {
				CSystemLog_301.ExceptionHandle(v_e);
			}	
		}		
	}
}
