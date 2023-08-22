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
    public partial class PurchaseOrder : Form
    {
        int Position;
           BL.orderClass order = new BL.orderClass();
        DataTable Dt = new DataTable();
       // TextBox orderId = new TextBox();


        void ClearBoxes()
        {
            txtIDproduct.Clear();
            txtNameProduct.Clear();
            txtQty.Clear();
            btnBrowse.Focus();
        }

        void ClearData()
        {
            txtOderNumber.Clear();
            txtOrderDesc.Clear();
            dtOrder.ResetText();
            txtDeliveryAddress.Clear();
            txtSuppID.Clear();
            txtSuppName.Clear();
            txtSuppAddress.Clear();
            txtEmail.Clear();
            txtSuppPhone.Clear();
            txtAccountNumber.Clear();
            ClearBoxes();
            Dt.Clear();
            combSearch.ResetText();
            dgvProducts.DataSource = null;
            btnAdd.Enabled = false;
            btnNew.Enabled = true;
            btnPrint.Enabled = true;
            button1.Enabled = false;
        }



        void ClearDataWhenNewRecord()
        {
        
            txtOrderDesc.Clear();
            dtOrder.ResetText();
            txtDeliveryAddress.Clear();
            txtSuppID.Clear();
            txtSuppName.Clear();
            txtSuppAddress.Clear();
            txtEmail.Clear();
            txtSuppPhone.Clear();
            txtAccountNumber.Clear();
            ClearBoxes();
          
            combSearch.ResetText();
            dgvProducts.DataSource = null;
          
            btnNew.Enabled = true;
            btnPrint.Enabled = true;
         
        }

        void CreateDataTable()
        {
            Dt.Columns.Add("معرف المادة");
            Dt.Columns.Add("اسم المادة");
            Dt.Columns.Add("الكمية");

            dgvProducts.DataSource = Dt;
        }


        void ResizeDGV()
        {
            //  this.dgvProducts.ColumnCount = 4;
            // this.dgvProducts.RowHeadersWidth = 86;
            this.dgvProducts.Columns[0].Width = 40;
            this.dgvProducts.Columns[1].Width = 99;
            this.dgvProducts.Columns[2].Width = 199;
            this.dgvProducts.Columns[3].Width = 93;
         

        }


        public PurchaseOrder()
        {
            InitializeComponent();
            CreateDataTable();
           button1.Enabled = false;
            ResizeDGV();
            btnAdd.Image = PurchaseSystem.Properties.Resources.Save_32px;
            btnNew.Image= PurchaseSystem.Properties.Resources.Add_New_32px;
            btnNew.Image = PurchaseSystem.Properties.Resources.Add_New_32px;
            btnUpdate.Image = PurchaseSystem.Properties.Resources.Update_32px;
            btnPrint.Image= PurchaseSystem.Properties.Resources.Print_32px;
            btnClose.Image= PurchaseSystem.Properties.Resources.Cancel_32px;

        }

       

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if ( txtSuppID.Text == string.Empty || dgvProducts.Rows.Count < 1 || txtDeliveryAddress.Text == string.Empty)
            {
                MessageBox.Show("ينبغي تسجيل المعلومات المهمة", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //إضافة معلومات الطلب
            order.ADD_ORDER(Convert.ToInt32(txtSuppID.Text),Convert.ToInt32(txtOderNumber.Text) , dtOrder.Value,txtDeliveryAddress.Text,txtOrderDesc.Text);

            //إضافة المنتجات المدخلة
            for (int i = 0; i < dgvProducts.Rows.Count; i++)
            {
                order.ADD_ORDERITEM(Convert.ToInt32(orderId.Text), Convert.ToInt32(dgvProducts.Rows[i].Cells[1].Value),
                                    Convert.ToInt32(dgvProducts.Rows[i].Cells[3].Value));


            }

            MessageBox.Show("تمت عملية الحفظ بنجاح", "عملية الحفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearData();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            vendorList frm = new vendorList();
            frm.ShowDialog();
         
            this.txtSuppID.Text = frm.dgvVendors.CurrentRow.Cells[0].Value.ToString();
            this.txtSuppName.Text = frm.dgvVendors.CurrentRow.Cells[1].Value.ToString();
            this.txtSuppAddress.Text = frm.dgvVendors.CurrentRow.Cells[2].Value.ToString();
            this.txtSuppPhone.Text = frm.dgvVendors.CurrentRow.Cells[3].Value.ToString();
            this.txtEmail.Text = frm.dgvVendors.CurrentRow.Cells[4].Value.ToString();
            this.txtAccountNumber.Text = frm.dgvVendors.CurrentRow.Cells[5].Value.ToString();

        }

        private void btnNew_Click(object sender, EventArgs e)
        {

            this.txtOderNumber.Text = order.GET_LAST_ORDER_ID().Rows[0][0].ToString();
            this.orderId.Text = order.GET_RLAST_ORDER_ID().Rows[0][0].ToString();
            btnNew.Enabled = false;
            btnAdd.Enabled = true;
            button1.Enabled = true;
             ClearDataWhenNewRecord();
            
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            ClearBoxes();
            ProductsList frm = new ProductsList();
            frm.ShowDialog();
            txtIDproduct.Text = frm.dgvProducts.CurrentRow.Cells[0].Value.ToString();
            txtNameProduct.Text = frm.dgvProducts.CurrentRow.Cells[1].Value.ToString();
            btnBrowse.Focus();
        }

        private void txtQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void txtQty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                

                for (int i = 0; i < dgvProducts.Rows.Count ; i++)
                {
                    if (dgvProducts.Rows[i].Cells[1].Value.ToString() == txtIDproduct.Text)
                    {
                        MessageBox.Show("هذا المنتج تم إدخاله مسبقا", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }

                }

                DataRow r = Dt.NewRow();
                r[0] = txtIDproduct.Text;
                r[1] = txtNameProduct.Text;
                r[2] = txtQty.Text;

                Dt.Rows.Add(r);

                dgvProducts.DataSource = Dt;
                ResizeDGV();
                ClearBoxes();

            }
        }

        private void dgvProducts_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                txtIDproduct.Text = this.dgvProducts.CurrentRow.Cells[1].Value.ToString();
                txtNameProduct.Text = this.dgvProducts.CurrentRow.Cells[2].Value.ToString();
                txtQty.Text = this.dgvProducts.CurrentRow.Cells[3].Value.ToString();
                dgvProducts.Rows.RemoveAt(dgvProducts.CurrentRow.Index);
                txtQty.Focus();
            }
            catch
            {
                return;
            }
        }

        private void حذفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //dgvProducts_DoubleClick(sender, e);
           
        }

        private void تعديلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgvProducts.Rows.RemoveAt(dgvProducts.CurrentRow.Index);
        }

        private void حذفالكلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dt.Clear();
            dgvProducts.Refresh();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            dgvProducts.Rows.RemoveAt(dgvProducts.CurrentRow.Index);
        }

       

        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridView dataGridView = (DataGridView)sender;

                // Check if the clicked cell belongs to the Update button column
                if (dgvProducts.Columns[e.ColumnIndex].Name == "btnUpdate")
                {
                    int rowIndex = e.RowIndex;
                    dataGridView.Refresh();
                    // Handle the update button click
                    // Add code to perform the update operation based on the selected row
                }
                // Check if the clicked cell belongs to the Delete button column
                else if (dgvProducts.Columns[e.ColumnIndex].Name == "btnDel")
                {
                    // Get the row index of the clicked cell
                    int rowIndex = e.RowIndex;

                    // Check if the row index is valid
                    if (rowIndex >= 0 && rowIndex < dataGridView.Rows.Count)
                    {
                        // Delete the row from the DataGridView
                        dgvProducts.Rows.RemoveAt(rowIndex);
                    }
                }
            }
        }

        private void dgvProducts_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            // Check if the cell should be editable
            if (e.ColumnIndex == 3)
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

        private void PurchaseOrder_Load(object sender, EventArgs e)
        {
            combSearch.DisplayMember = "ORDERNUMBER";
            combSearch.ValueMember = "ORDERID";
            combSearch.DataSource = order.GET_ALL_ORDERS();
            combSearch.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            combSearch.AutoCompleteSource = AutoCompleteSource.ListItems;



        }

        private void combSearch_SelectedValueChanged(object sender, EventArgs e)
        {
            
            int oId = Convert.ToInt32(combSearch.SelectedValue);
            DataTable dataTable = new DataTable();
            dataTable = order.GET_MAINORDERDETAILS_BYID(oId);

            if (dataTable.Rows.Count == 1)
            {
                DataRow row = dataTable.Rows[0];

                orderId.Text = row["orderId"].ToString();

                txtOderNumber.Text = row["orderNumber"].ToString();

                txtOrderDesc.Text = row["orDescription"].ToString();

                txtDeliveryAddress.Text = row["orAddress"].ToString();
                txtSuppID.Text = row["vId"].ToString();
                txtSuppName.Text = row["vName"].ToString();

                txtSuppAddress.Text = row["vAddress"].ToString();
                dtOrder.Value = Convert.ToDateTime(row["orDate"]);
                txtSuppPhone.Text = row["vPhone"].ToString();
                txtEmail.Text = row["vEmail"].ToString();
                txtAccountNumber.Text = row["vAccNumber"].ToString(); 
            }

         dgvProducts.DataSource = order.GET_ORDERDETAILS_BYID(oId);

        }

        void Navigate(int Index)
        {
            try
            {
               
                DataRowCollection DRC= order.GET_ALL_Main_ORDERS_DETAILS().Rows;
                orderId.Text = DRC[Index][0].ToString();
                txtOderNumber.Text = DRC[Index][1].ToString();
                txtOrderDesc.Text = DRC[Index][2].ToString();
                dtOrder.Value = Convert.ToDateTime(DRC[Index][3]);
                txtDeliveryAddress.Text = DRC[Index][4].ToString();
                txtSuppID.Text = DRC[Index][5].ToString();
                txtSuppName.Text= DRC[Index][6].ToString();
                txtSuppAddress.Text = DRC[Index][7].ToString();
                txtSuppPhone.Text = DRC[Index][8].ToString();
                txtEmail.Text= DRC[Index][9].ToString();
                txtAccountNumber.Text= DRC[Index][10].ToString();
            }
            catch
            {
                return;
            }

        }

        private void pbEnd_Click(object sender, EventArgs e)
        {
            Navigate(0);
        }

        private void pbFirst_Click(object sender, EventArgs e)
        {
            Position = order.GET_ALL_Main_ORDERS_DETAILS().Rows.Count - 1;
            Navigate(Position);
        }

        private void pbForward_Click(object sender, EventArgs e)
        {
            if (Position == 0)
            {
                MessageBox.Show("هذا هو أول عنصر");
                return;
            }
            Position -= 1;
            Navigate(Position);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

            if (Position == order.GET_ALL_Main_ORDERS_DETAILS().Rows.Count - 1)
            {
                MessageBox.Show("هذا هو آخر عنصر");
                return;
            }
            Position += 1;
            Navigate(Position);
        }

        private void orderId_TextChanged(object sender, EventArgs e)
        {
            dgvProducts.DataSource = order.GET_ORDERDETAILS_BYID(Convert.ToInt32(orderId.Text));
        }
    }
}
