using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PurchaseSystem.PL
{
    public partial class Return : UserControl
    {
        BL.orderClass order = new BL.orderClass();
        public Return()
        {
            InitializeComponent();
            btnAdd.Image = PurchaseSystem.Properties.Resources.SaveBtn_32px;
            btnNew.Image = PurchaseSystem.Properties.Resources.AddBtn_32px;
            btnClose.Image = PurchaseSystem.Properties.Resources.CancelBtn_32px;
            //btnEdit.Image = PurchaseSystem.Properties.Resources.EditeBtn_32px;
            btnPrint.Image = PurchaseSystem.Properties.Resources.PrintBtn_32px;
            //btnDelete.Image = PurchaseSystem.Properties.Resources.DeleteBtn_32px;
            InvComboSearch.DisplayMember = "INVOICENUMBER";
            InvComboSearch.ValueMember = "INVOICEID";
            InvComboSearch.DataSource = order.Fill_InvoiceCombo();
            InvComboSearch.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            InvComboSearch.AutoCompleteSource = AutoCompleteSource.ListItems;
          //  btnPrint.Enabled = false;

        }

        void ClearData()
        {

            txtReurnNumber.Clear();
            txtReturnDesc.Clear();
            txtInvoiceId.Clear();
            InvComboSearch.ResetText();
            txtvendorInvoiceNumebr.Clear();
            txtVendName.Clear();
            txtOrderNum.Clear();
            dtInvoice.ResetText();
            txtInvoDesc.Clear();
            btnAdd.Enabled = false;
            btnNew.Enabled = true;
            btnPrint.Enabled = true;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            this.txtReurnNumber.Text = order.GET_LAST_RETURN_ID().Rows[0][0].ToString();
            btnNew.Enabled = false;
            btnAdd.Enabled = true;
       
        }

        private void InvComboSearch_SelectedValueChanged(object sender, EventArgs e)
        {
            int invoiceId = Convert.ToInt32(InvComboSearch.SelectedValue);
            DataTable dataTable = new DataTable();
            dataTable = order.GET_MAININVOICEDETAILS_BYID(invoiceId);

            if (dataTable.Rows.Count == 1)
            {
                DataRow row = dataTable.Rows[0];
                txtInvoiceId.Text = row["invoiceId"].ToString();
            
                txtInvoDesc.Text = row["invoDescription"].ToString();

                dtInvoice.Value = Convert.ToDateTime(row["invodate"]);

                ddlPyamentMethod.SelectedItem = row["payMethod"].ToString();
                ddlCurrency.SelectedItem = row["currency"].ToString();

                txtvendorInvoiceNumebr.Text = row["vinvoicenumber"].ToString();
                txtOrderNum.Text = row["ordernumber"].ToString();
                txtVendName.Text = row["vendorname"].ToString();
            
          
            }
            dgInvoice.DataSource = order.GetSecInviceDetailsBYID(invoiceId);
        }

        private void dgInvoice_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            // Check if the cell should be editable
            if (e.ColumnIndex == 0)
            {
                // Allow editing for specific columns (e.g., column index 0 and 2)
                e.Cancel = false;
            }
            else
            {
                // Cancel editing for other columns
                e.Cancel = true;
            }
        }

    

        private void button1_Click(object sender, EventArgs e)
        {
            int sum = 0;
                string message = string.Empty;
                foreach (DataGridViewRow row in dgInvoice.Rows)
                {
                    int isSelected = Convert.ToInt32(row.Cells["checkBox"].Value);
                    if (isSelected == 1)
                    {
                        sum+= Convert.ToInt32(row.Cells["المبلغ الإجمالي"].Value);
                    }
                }

               
            txtReturnTotal.Text = sum.ToString();
            }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtReurnNumber.Text == string.Empty || txtReturnTotal.Text == string.Empty || Convert.ToInt32(txtReturnTotal.Text) == 0  )
            {
                MessageBox.Show("ينبغي تسجيل المعلومات المهمة", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //إضافة معلومات الفاتورة
            order.ADD_RETURN(dtReturn.Value,txtReturnDesc.Text, Convert.ToInt32(txtInvoiceId.Text),Convert.ToDecimal( txtReturnTotal.Text),Convert.ToInt32(txtReurnNumber.Text));
      
            //إضافة المنتجات المدخلة
            for (int i = 0; i < dgInvoice.Rows.Count; i++)
            {
                if (Convert.ToInt32(dgInvoice.Rows[i].Cells[0].Value) == 1) 
                {

                    order.UPDATE_RETUREDINVOICEITEM(1, Convert.ToInt32(dgInvoice.Rows[i].Cells[1].Value));
                   MessageBox.Show("updated line withe numbers " + Convert.ToInt32(dgInvoice.Rows[i].Cells[1].Value));
                }
            }

            MessageBox.Show("تمت عملية الحفظ بنجاح", "عملية الحفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
           ClearData();
        }
    }
}
