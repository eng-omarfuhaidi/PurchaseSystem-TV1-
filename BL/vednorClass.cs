using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PurchaseSystem.BL
{
    class vednorClass
    {
        public DataTable GET_ALL_VENDORS()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();

            using (OracleDataAdapter reader = DAL.SelectData("VENDORS.GET_VENDORS", "CUR_VENDOR"))
            {
                reader.Fill(dt);
            }

            return dt;
        }
        public void ADD_VENDOR(string vendorAName, string vendorEName, int  vPhone,
                           string vEmail, string  vAddress, int  vAccountNumebr)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            OracleParameter[] param = new OracleParameter[6];

            param[0] = new OracleParameter("v_aName", OracleDbType.Varchar2, 255);
            param[0].Value = vendorAName;

            param[1] = new OracleParameter("v_eName", OracleDbType.Varchar2, 255);
            param[1].Value = vendorEName;

            param[2] = new OracleParameter("v_phone", OracleDbType.Int32);
            param[2].Value = vPhone;

            param[3] = new OracleParameter("v_email", OracleDbType.Varchar2,255);
            param[3].Value = vEmail;

            param[4] = new OracleParameter("v_address", OracleDbType.Varchar2,255);
            param[4].Value = vAddress;

            param[5] = new OracleParameter("v_accountNumber", OracleDbType.Int32);
            param[5].Value = vAccountNumebr;


            DAL.ExecuteCommand("INSERT_VENDOR", param);
            DAL.Close();

        }


        public void UPDATE_VENDOR(string vendorAName, string vendorEName, int vPhone,
                          string vEmail, string vAddress, int vAccountNumebr, int Id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            OracleParameter[] param = new OracleParameter[7];

            param[0] = new OracleParameter("v_aName", OracleDbType.Varchar2, 255);
            param[0].Value = vendorAName;

            param[1] = new OracleParameter("v_eName", OracleDbType.Varchar2, 255);
            param[1].Value = vendorEName;

            param[2] = new OracleParameter("v_phone", OracleDbType.Int32);
            param[2].Value = vPhone;

            param[3] = new OracleParameter("v_email", OracleDbType.Varchar2, 255);
            param[3].Value = vEmail;

            param[4] = new OracleParameter("v_address", OracleDbType.Varchar2, 255);
            param[4].Value = vAddress;

            param[5] = new OracleParameter("v_accountNumber", OracleDbType.Int32);
            param[5].Value = vAccountNumebr;


            param[6] = new OracleParameter("v_id", OracleDbType.Int32);
            param[6].Value = Id;

            DAL.ExecuteCommand("EDITE_VENDOR", param);
            DAL.Close();

        }


        public void DELETE_VENDOR(int Id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            OracleParameter[] param = new OracleParameter[1];

            param[0] = new OracleParameter("v_id", OracleDbType.Int32);
            param[0].Value = Id;

            DAL.ExecuteCommand("DELETE_VENDOR", param);
            DAL.Close();

        }





    }
}
