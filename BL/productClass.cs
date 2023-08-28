using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PurchaseSystem.BL
{
    class productClass
    {
        public DataTable GET_ALL_CATEGORIES()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();

            using (OracleDataReader reader = DAL.ExecuteDataReader("GET_ALL_CATEGORIES"))
            {
                dt.Load(reader);
            }

            return dt;
        }

        public DataTable Fill_CateGoryCombo()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();

            using (OracleDataAdapter reader = DAL.PopoulateCombo("PRODUCT_CATEGORY.GET_CATEGORY", "CUR_CATEGORY"))
            {
                reader.Fill(dt);
            }

            return dt;
        }



        public void ADD_PRODUCT(int ID_cat, string productName, string productDesc,
                            Decimal Price, int unit, Decimal tax)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            OracleParameter[] param = new OracleParameter[6];

            param[0] = new OracleParameter("NAME", OracleDbType.Varchar2, 30);
            param[0].Value = productName;

            param[1] = new OracleParameter("DESCRIPTION", OracleDbType.Varchar2, 30);
            param[1].Value = productDesc;

            param[2] = new OracleParameter("PRICE", OracleDbType.Decimal);
            param[2].Value = Price;

            param[3] = new OracleParameter("UNIT", OracleDbType.Int32);
            param[3].Value = unit;

            param[4] = new OracleParameter("CATEGORY", OracleDbType.Int32);
            param[4].Value = ID_cat;

            param[5] = new OracleParameter("TAX", OracleDbType.Decimal);
            param[5].Value = tax;

            DAL.ExecuteCommand("INSERT_PRODUCT_ITEM", param);
            DAL.Close();

        }



        //public void UPDATE_PRODUCT(int ID_cat, string productName, string productDesc,
        //                    Decimal Price, int unit, Decimal tax)
        //{
        //    DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
        //    DAL.Open();
        //    OracleParameter[] param = new OracleParameter[6];
        //    param[0] = new OracleParameter("@ID_CAT", SqlDbType.Int);
        //    param[0].Value = ID_cat;

        //    param[1] = new OracleParameter("@ID_PRODUCT", SqlDbType.VarChar, 30);
        //    param[1].Value = ID_product;

        //    param[2] = new OracleParameter("@Label", SqlDbType.VarChar, 30);
        //    param[2].Value = Label_product;

        //    param[3] = new OracleParameter("@Qte", SqlDbType.Int);
        //    param[3].Value = Qte;

        //    param[4] = new OracleParameter("@PRICE", SqlDbType.VarChar, 50);
        //    param[4].Value = Price;

        //    param[5] = new OracleParameter("@Img", SqlDbType.Image);
        //    param[5].Value = img;

        //    DAL.ExecuteCommand("UPDATE_PRODUCT", param);
        //    DAL.Close();

        //}

        //public DataTable VerifyProductID(string ID)
        //{
        //    DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
        //    DataTable Dt = new DataTable();
        //    OracleParameter[] param = new OracleParameter[1];
        //    param[0] = new OracleParameter("@ID", SqlDbType.VarChar, 50);
        //    param[0].Value = ID;
        //    Dt = DAL.SelectData("VerifyProductID", param);
        //    DAL.Close();
        //    return Dt;
        //}


        public DataTable GET_ALL_PRODUCTS()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();

            using (OracleDataAdapter reader = DAL.SelectData("PRODUCTS.GET_PRDUCT", "CUR_PRODUCT"))
            {
                reader.Fill(dt);
            }

            return dt;
        }


            //public DataTable SearchProduct(string ID)
            //{
            //    DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            //    DataTable Dt = new DataTable();
            //    OracleParameter[] param = new OracleParameter[1];
            //    param[0] = new OracleParameter("@ID", SqlDbType.VarChar, 50);
            //    param[0].Value = ID;
            //    Dt = DAL.SelectData("SearchProduct", param);
            //    DAL.Close();
            //    return Dt;
            //}



            //public void DeleteProduct(string ID)
            //{
            //    DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            //    DAL.Open();
            //    OracleParameter[] param = new OracleParameter[1];
            //    param[0] = new OracleParameter("@ID", SqlDbType.VarChar, 50);
            //    param[0].Value = ID;
            //    DAL.ExecuteCommand("DeleteProduct", param);
            //    DAL.Close();

            //}
        
    }
}