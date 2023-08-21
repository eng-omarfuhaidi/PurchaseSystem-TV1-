using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
namespace PurchaseSystem.PL
{
    public partial class AddProducts : Form
    {
        public string state = "add";
        BL.productClass prd = new BL.productClass();
        public AddProducts()
        {
            InitializeComponent();
            using (OracleConnection objConn = new OracleConnection(@" USER ID=PURCHASE;PASSWORD=PURCHASE;DATA SOURCE=localhost:1521/orcl"))
            {
                OracleCommand objCmd = new OracleCommand();
                objCmd.Connection = objConn;
                objCmd.CommandText = "PRODUCT_CATEGORY.GET_CATEGORY";
                objCmd.CommandType = CommandType.StoredProcedure;
                objCmd.Parameters.Add("CUR_CATEGORY", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                try
                {
                    objConn.Open();
                 //   OracleDataReader objReader = objCmd.ExecuteReader();
                    OracleDataAdapter da = new OracleDataAdapter(objCmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    cmbCategories.DataSource = dt;
                    cmbCategories.DisplayMember ="CAT_NAEM";
                    cmbCategories.ValueMember = "CAT_ID";
                }
                catch (Exception ex)
                {
                    System.Console.WriteLine("Exception: {0}", ex.ToString());
                }
                objConn.Close();
            }

            combo_unite.DataSource = prd.Fill_CateGoryCombo();
            combo_unite.DisplayMember = "CAT_NAEM";
            combo_unite.ValueMember = "CAT_ID";
        }



        private void btnOk_Click(object sender, EventArgs e)
        {
            if (state == "add")
            {
              

                prd.ADD_PRODUCT(Convert.ToInt32(cmbCategories.SelectedValue),   txtName.Text,txtDes.Text
                  , Convert.ToDecimal(txtPrice.Text), Convert.ToInt32(combo_unite.SelectedValue), Convert.ToDecimal(textBoxTax.Text));

                MessageBox.Show("تمت الإضافة بنجاح", "عملية الإضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
              
            }
            Products.getMainForm.dataGridView1.DataSource = prd.GET_ALL_PRODUCTS();
            //else
            //{


            //    prd.UPDATE_PRODUCT(Convert.ToInt32(cmbCategories.SelectedValue), txtDes.Text
            //        , txtName.Text, Convert.ToInt32(txtPrice.Text), txtPrice.Text, byteImage);

            //    MessageBox.Show("تم التعديل بنجاح", "عملية التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //Products.getMainForm.dataGridView1.DataSource = prd.GET_ALL_PRODUCTS();
        }
    }
}
