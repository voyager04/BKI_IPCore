///************************************************
/// Generated by: TUAN_BH
/// Date: 29/03/2015 07:00:54
/// Goal: Create User Service Class for DM_SINH_VIEN
///************************************************
/// <summary>
/// Create User Service Class for DM_SINH_VIEN
/// </summary>

namespace BKITrainingUS
{
using BKITrainingDS;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using System.Data.SqlClient;
using System.Data;
using System;


public class US_DM_SINH_VIEN : US_Object
{
	private const string c_TableName = "DM_SINH_VIEN";
#region "Public Properties"
	public decimal dcID 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "ID", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["ID"] = value;
		}
	}

	public bool IsIDNull()	{
		return pm_objDR.IsNull("ID");
	}

	public void SetIDNull() {
		pm_objDR["ID"] = System.Convert.DBNull;
	}

	public string strMA_SV 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "MA_SV", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["MA_SV"] = value;
		}
	}

	public bool IsMA_SVNull() 
	{
		return pm_objDR.IsNull("MA_SV");
	}

	public void SetMA_SVNull() {
		pm_objDR["MA_SV"] = System.Convert.DBNull;
	}

	public string strHO_TEN 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "HO_TEN", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["HO_TEN"] = value;
		}
	}

	public bool IsHO_TENNull() 
	{
		return pm_objDR.IsNull("HO_TEN");
	}

	public void SetHO_TENNull() {
		pm_objDR["HO_TEN"] = System.Convert.DBNull;
	}

	public DateTime datNGAY_SINH
	{
		get   
		{
			return CNull.RowNVLDate(pm_objDR, "NGAY_SINH", IPConstants.c_DefaultDate);
		}
		set   
		{
			pm_objDR["NGAY_SINH"] = value;
		}
	}

	public bool IsNGAY_SINHNull()
	{
		return pm_objDR.IsNull("NGAY_SINH");
	}

	public void SetNGAY_SINHNull()
	{
		pm_objDR["NGAY_SINH"] = System.Convert.DBNull;
	}

	public string strGIOI_TINH 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "GIOI_TINH", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["GIOI_TINH"] = value;
		}
	}

	public bool IsGIOI_TINHNull() 
	{
		return pm_objDR.IsNull("GIOI_TINH");
	}

	public void SetGIOI_TINHNull() {
		pm_objDR["GIOI_TINH"] = System.Convert.DBNull;
	}

#endregion
#region "Init Functions"
	public US_DM_SINH_VIEN() 
	{
		pm_objDS = new DS_DM_SINH_VIEN();
		pm_strTableName = c_TableName;
		pm_objDR = pm_objDS.Tables[pm_strTableName].NewRow();
	}

	public US_DM_SINH_VIEN(DataRow i_objDR): this()
	{
		this.DataRow2Me(i_objDR);
	}

	public US_DM_SINH_VIEN(decimal i_dbID) 
	{
		pm_objDS = new DS_DM_SINH_VIEN();
		pm_strTableName = c_TableName;
		IMakeSelectCmd v_objMkCmd = new CMakeAndSelectCmd(pm_objDS, c_TableName);
		v_objMkCmd.AddCondition("ID", i_dbID, eKieuDuLieu.KieuNumber, eKieuSoSanh.Bang);
		SqlCommand v_cmdSQL;
		v_cmdSQL = v_objMkCmd.getSelectCmd();
		this.FillDatasetByCommand(pm_objDS, v_cmdSQL);
		pm_objDR = getRowClone(pm_objDS.Tables[pm_strTableName].Rows[0]);
	}
    /* public void FillDatasetSearch(DS_DM_SINH_VIEN sv_ds, string i_str_search)
    {
        CStoredProc v_sp = new CStoredProc("pr_DM_SINH_VIEN_Check");
        v_sp.addNVarcharInputParam("@m_ma_sv", i_str_search);
        v_sp.fillDataSetByCommand(this, sv_ds);
    }*/
#endregion

    public void FillDatasetSearchByMSSV(DS_DM_SINH_VIEN op_ds, string ip_str_mssv)
    {
        CStoredProc v_sp = new CStoredProc("pr_DM_SINH_VIEN_Check");
        v_sp.addNVarcharInputParam("@ip_str_mssv", ip_str_mssv);
        v_sp.fillDataSetByCommand(this, op_ds);
    }
}
}
