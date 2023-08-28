

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PurchaseSystem.PL
{
    public partial class Invoice : Form
    {
        int Position;
        BL.orderClass order = new BL.orderClass();
        DataTable Dt = new DataTable();

        void CalculateAmount()
        {
            if (txtPrice.Text != string.Empty && txtQty.Text != string.Empty)

                txtTotalAmount.Text = (Convert.ToDouble(txtPrice.Text) * Convert.ToInt32(txtQty.Text)).ToString();
        }




        void ClearBoxes()
        {
            txtlinId.Clear();
            txtIDproduct.Clear();
            txtNameProduct.Clear();
            txtPrice.Clear();
            txtQty.Clear();
            txtTotalAmount.Clear();
        }

        void ClearData()
        {
          
            txtordernumber.Clear();
            textorderDesc.Clear();
            txtOrderId.Clear();
            dateOrder.ResetText();
            txtAddress.Clear();
            txtInvoiceNumber.Clear();
            txtInvoiceDesc.Clear();
            dtInvoice.ResetText();
        
            dueDate.ResetText();
            ClearBoxes();
            Dt.Clear();
            dgvInvoice.DataSource = Dt;
            txtSumTotals.Clear();
            btnAdd.Enabled = false;
            btnNew.Enabled = true;
            btnPrint.Enabled = true;
        }


        void ClearDataWhenNew()
        {
       
            txtordernumber.Clear();
            textorderDesc.Clear();
            txtOrderId.Clear();
            dateOrder.ResetText();
            txtAddress.Clear();
            combSearch.ResetText();
            txtInvoiceDesc.Clear();
            dtInvoice.ResetText();
            txtvendorInvoiceNumebr.Clear();
           
            dueDate.ResetText();
            ClearBoxes();
            Dt.Clear();
            dgvInvoice.DataSource = Dt;
            txtSumTotals.Clear();
            btnAdd.Enabled = true;
            btnNew.Enabled = true;
            btnPrint.Enabled = true;
        }

        void CreateDataTable()
        {

            Dt.Columns.Add("معرف البند");
            Dt.Columns.Add("معرف المادة");
            Dt.Columns.Add("اسم المادة");
            Dt.Columns.Add("سعر الوحدة");
            Dt.Columns.Add("الكمية");
            Dt.Columns.Add("المبلغ الإجمالي");

            dgvInvoice.DataSource = Dt;

            //Add ButtonColumn To DataGridView
            /*  DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
              btn.HeaderText = "اختيار مادة";
              btn.Text = "البحث";
              btn.UseColumnTextForButtonValue = true;
              dgvProducts.Columns.Insert(0,btn); */
        }

        void ResizeDGV()
        {
            // this.dgvInvoice.RowHeadersWidth = 86;
            this.dgvInvoice.Columns[0].Width = 42;
            this.dgvInvoice.Columns[1].Width = 99;
            this.dgvInvoice.Columns[2].Width = 99;
            this.dgvInvoice.Columns[3].Width = 199;
            this.dgvInvoice.Columns[4].Width = 85;
            this.dgvInvoice.Columns[5].Width = 93;
            this.dgvInvoice.Columns[6].Width = 121;

        }
        public Invoice()
        {
            InitializeComponent();
            CreateDataTable();
            ResizeDGV();
            btnAdd.Image = PurchaseSystem.Properties.Resources.SaveBtn_32px;
            btnNew.Image = PurchaseSystem.Properties.Resources.AddBtn_32px;
            btnClose.Image = PurchaseSystem.Properties.Resources.CancelBtn_32px;
            btnUpdate.Image = PurchaseSystem.Properties.Resources.EditeBtn_32px;
            btnPrint.Image = PurchaseSystem.Properties.Resources.PrintBtn_32px;
            buttonDelete.Image = PurchaseSystem.Properties.Resources.DeleteBtn_32px;

            //  btnSelectOrder.Enabled = false;
            combSearch.DisplayMember = "INVOICENUMBER";
            combSearch.ValueMember = "INVOICEID";
            combSearch.DataSource = order.Fill_InvoiceCombo();
            combSearch.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            combSearch.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void btnSelectOrder_Click(object sender, EventArgs e)
        {
            PurchaseOrderList frm = new PurchaseOrderList();
            frm.ShowDialog();

            this.txtOrderId.Text = frm.dgvOrders.CurrentRow.Cells[0].Value.ToString();
            this.txtordernumber.Text = frm.dgvOrders.CurrentRow.Cells[2].Value.ToString();
            this.textorderDesc.Text = frm.dgvOrders.CurrentRow.Cells[6].Value.ToString();
            this.dateOrder.Text = frm.dgvOrders.CurrentRow.Cells[3].Value.ToString();
            this.txtAddress.Text = frm.dgvOrders.CurrentRow.Cells[5].Value.ToString();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            this.txtInvoiceNumber.Text = order.GET_LAST_INVOICE_ID().Rows[0][0].ToString();
            btnNew.Enabled = false;
            btnSelectOrder.Enabled = true;
            btnAdd.Enabled = true;
            ClearDataWhenNew();
        }

        private void txtOrderId_TextChanged(object sender, EventArgs e)
        {
            string inputValue = txtOrderId.Text.Trim();

            if (!string.IsNullOrEmpty(inputValue))
            {
                int orderId;
                if (int.TryParse(inputValue, out orderId))
                {
                    dataGridView1.DataSource = order.GET_ORDERDETAILS_BYID(orderId);
                }
                else
                {
                    // Handle invalid input
                }
            }
            else
            {
                // Clear the DataGridView when the TextBox is empty
                dataGridView1.DataSource = null;
            }
        }

        private void txtQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            char DecimalSeparator = Convert.ToChar(CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != DecimalSeparator)
            {
                e.Handled = true;
            }
        }

        private void txtPrice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtPrice.Text != string.Empty)
            {
                txtQty.Focus();
            }
        }

        private void txtPrice_KeyUp(object sender, KeyEventArgs e)
        {
            CalculateAmount();

        }

        private void txtQty_KeyUp(object sender, KeyEventArgs e)
        {
            CalculateAmount();

        }

        private void txtQty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                for (int i = 0; i < dgvInvoice.Rows.Count; i++)
                {
                    if (dgvInvoice.Rows[i].Cells[1].Value.ToString() == txtlinId.Text)
                    {
                        MessageBox.Show("هذه المادة تم إدخالها مسبقا", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }

                }


                DataRow r = Dt.NewRow();
                r[0] = txtlinId.Text;
                r[1] = txtIDproduct.Text;
                r[2] = txtNameProduct.Text;
                r[3] = txtPrice.Text;
                r[4] = txtQty.Text;
                r[5] = txtTotalAmount.Text;
                Dt.Rows.Add(r);

                dgvInvoice.DataSource = Dt;
                ClearBoxes();
                txtOrderId.Focus();
                txtSumTotals.Text =
                    (from DataGridViewRow row in dgvInvoice.Rows
                     where row.Cells[6].FormattedValue.ToString() != string.Empty
                     select Convert.ToDouble(row.Cells[6].FormattedValue)).Sum().ToString();
            }
        }

        private void dgvInvoice_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                txtlinId.Text = this.dgvInvoice.CurrentRow.Cells[1].Value.ToString();
                txtIDproduct.Text = this.dgvInvoice.CurrentRow.Cells[2].Value.ToString();
                txtNameProduct.Text = this.dgvInvoice.CurrentRow.Cells[3].Value.ToString();
                txtPrice.Text = this.dgvInvoice.CurrentRow.Cells[4].Value.ToString();
                txtQty.Text = this.dgvInvoice.CurrentRow.Cells[5].Value.ToString();
                txtTotalAmount.Text = this.dgvInvoice.CurrentRow.Cells[6].Value.ToString();
                dgvInvoice.Rows.RemoveAt(dgvInvoice.CurrentRow.Index);
                txtPrice.Focus();
            }
            catch
            {
                return;
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                txtlinId.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txtIDproduct.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txtNameProduct.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txtQty.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
                txtTotalAmount.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
                txtPrice.Focus();
            }
            catch
            {
                return;
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Check Values

            if (txtInvoiceNumber.Text == string.Empty || txtOrderId.Text == string.Empty || dgvInvoice.Rows.Count < 1 || txtInvoiceDesc.Text == string.Empty)
            {
                MessageBox.Show("ينبغي تسجيل المعلومات المهمة", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //إضافة معلومات الفاتورة
            order.ADD_INVOICE(Convert.ToInt32(txtOrderId.Text), Convert.ToInt32(txtInvoiceNumber.Text), dtInvoice.Value, Convert.ToDecimal(txtSumTotals.Text), dueDate.Value, txtInvoiceDesc.Text, ddlPyamentMethod.SelectedItem.ToString(), ddlCurrency.SelectedItem.ToString(), Convert.ToInt32(txtvendorInvoiceNumebr.Text));
            order.UPDATE_PURCHASEORDER(1, Convert.ToInt32(txtOrderId.Text));
            //إضافة المنتجات المدخلة
            for (int i = 0; i < dgvInvoice.Rows.Count; i++)
            {
                order.UPDATE_PURCHASEORDERLIINE(Convert.ToInt32(dgvInvoice.Rows[i].Cells[5].Value),

                                        Convert.ToDecimal(dgvInvoice.Rows[i].Cells[4].Value),
                                       Convert.ToDecimal(dgvInvoice.Rows[i].Cells[6].Value),

                                       Convert.ToInt32(dgvInvoice.Rows[i].Cells[1].Value));


            }

            MessageBox.Show("تمت عملية الحفظ بنجاح", "عملية الحفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearData();
        }

        private void dgvInvoice_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridView dataGridView = (DataGridView)sender;

                // Check if the clicked cell belongs to the Update button column
                if (dgvInvoice.Columns[e.ColumnIndex].Name == "btnUpdate")
                {
                    int rowIndex = e.RowIndex;
                    dataGridView.Refresh();
                    // Handle the update button click
                    // Add code to perform the update operation based on the selected row
                }
                // Check if the clicked cell belongs to the Delete button column
                else if (dgvInvoice.Columns[e.ColumnIndex].Name == "btnDelete")
                {
                    // Get the row index of the clicked cell
                    int rowIndex = e.RowIndex;

                    // Check if the row index is valid
                    if (rowIndex >= 0 && rowIndex < dataGridView.Rows.Count)
                    {
                        // Delete the row from the DataGridView
                        dgvInvoice.Rows.RemoveAt(rowIndex);
                        dgvInvoice.Refresh();
                        //update the totalSum
                        txtSumTotals.Text = (from DataGridViewRow row1 in dgvInvoice.Rows
                         where row1.Cells[6].FormattedValue.ToString() != string.Empty
                         select Convert.ToDouble(row1.Cells[6].FormattedValue)).Sum().ToString();
                    }
                }
            }
        }

        private void dgvInvoice_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {

            // Check if the cell should be editable
            if (e.ColumnIndex == 4 )
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

        private void dgvInvoice_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 4 )
            {
                DataGridViewRow row = dgvInvoice.Rows[e.RowIndex];

                if (row.Cells[4].Value != null )
                {
                    int value1, value2;
                    if (int.TryParse(row.Cells[4].Value.ToString(), out value1) &&
                        int.TryParse(row.Cells[5].Value.ToString(), out value2))
                    {
                        int newValue = CalculateNewValue(value1, value2);
                        row.Cells[6].Value = newValue;
                        //update the totalSum
                        txtSumTotals.Text =
                       (from DataGridViewRow row1 in dgvInvoice.Rows
                        where row1.Cells[6].FormattedValue.ToString() != string.Empty
                        select Convert.ToDouble(row1.Cells[6].FormattedValue)).Sum().ToString();
                    }
                }
            }

        }


        private int CalculateNewValue(int value1, int value2)
        {
            return value1 * value2;
        }

        private void combSearch_SelectedValueChanged(object sender, EventArgs e)
        {
            int invoiceId = Convert.ToInt32(combSearch.SelectedValue);
            DataTable dataTable = new DataTable();
            dataTable = order.GET_MAININVOICEDETAILS_BYID(invoiceId);

            if (dataTable.Rows.Count == 1)
            {
                DataRow row = dataTable.Rows[0];
                txtInvoiceId.Text= row["invoiceId"].ToString();
                txtInvoiceNumber.Text = row["invoNumber"].ToString();

                txtInvoiceDesc.Text = row["invoDescription"].ToString();

                dtInvoice.Value = Convert.ToDateTime(row["invodate"]);

                ddlPyamentMethod.SelectedItem = row["payMethod"].ToString();
                dueDate.Value = Convert.ToDateTime(row["dudate"]);
                ddlCurrency.SelectedItem = row["currency"].ToString();

                txtvendorInvoiceNumebr.Text = row["vinvoicenumber"].ToString();
                txtOrderId.Text = row["orderId"].ToString();
                txtordernumber.Text = row["ordernumber"].ToString();
                textorderDesc.Text = row["description"].ToString();
                dateOrder.Value = Convert.ToDateTime(row["orderDate"]);
                txtSumTotals.Text= row["amount"].ToString(); 
            }
            dgvInvoice.DataSource = order.GetSecInviceDetailsBYID(invoiceId);
            
        }

        void Navigate(int Index)
        {
            try
            {

                DataRowCollection DRC = order.GET_ALL_Main_INVOICES_DETAILS().Rows;
                txtInvoiceId.Text= DRC[Index][0].ToString();
                txtInvoiceNumber.Text = DRC[Index][1].ToString();
                txtInvoiceDesc.Text = DRC[Index][2].ToString();
                dtInvoice.Value = Convert.ToDateTime(DRC[Index][3]);
                ddlPyamentMethod.Text = DRC[Index][4].ToString();
                dueDate.Value = Convert.ToDateTime(DRC[Index][5]);
                ddlCurrency.Text= DRC[Index][6].ToString();
                txtvendorInvoiceNumebr.Text = DRC[Index][7].ToString();
                txtOrderId.Text = DRC[Index][8].ToString();
                txtordernumber.Text = DRC[Index][9].ToString();
                textorderDesc.Text = DRC[Index][10].ToString();
                dateOrder.Value= Convert.ToDateTime(DRC[Index][11]);
                txtAddress.Text= DRC[Index][12].ToString();
                txtSumTotals.Text= DRC[Index][13].ToString();
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
            Position = order.GET_ALL_Main_INVOICES_DETAILS().Rows.Count - 1;
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

        private void pbBackward_Click(object sender, EventArgs e)
        {
            if (Position == order.GET_ALL_Main_INVOICES_DETAILS().Rows.Count - 1)
            {
                MessageBox.Show("هذا هو آخر عنصر");
                return;
            }
            Position += 1;
            Navigate(Position);
        }

        private void txtInvoiceId_TextChanged(object sender, EventArgs e)
        {
            dgvInvoice.DataSource = order.GetSecInviceDetailsBYID(Convert.ToInt32(txtInvoiceId.Text));
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            if (txtInvoiceNumber.Text == string.Empty || txtOrderId.Text == string.Empty || dgvInvoice.Rows.Count < 1 || txtInvoiceDesc.Text == string.Empty)
            {
                MessageBox.Show("ينبغي تسجيل المعلومات المهمة", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
       
            //تعديل معلومات الفاتورة
            order.UPDATE_INVOICE_UPDATEBTN(Convert.ToInt32(txtOrderId.Text), Convert.ToInt32(txtInvoiceNumber.Text), dtInvoice.Value, Convert.ToDecimal(txtSumTotals.Text), dueDate.Value, txtInvoiceDesc.Text, ddlPyamentMethod.SelectedItem.ToString(), ddlCurrency.SelectedItem.ToString(), Convert.ToInt32(txtvendorInvoiceNumebr.Text), Convert.ToInt32(txtInvoiceId.Text));
            order.UPDATE_PURCHASEORDER(1, Convert.ToInt32(txtOrderId.Text));
            //تعديل بنود الفاتورة
            for (int i = 0; i < dgvInvoice.Rows.Count; i++)
            {
                order.UPDATE_PURCHASEORDERLIINE(Convert.ToInt32(dgvInvoice.Rows[i].Cells[5].Value),

                                        Convert.ToDecimal(dgvInvoice.Rows[i].Cells[4].Value),
                                       Convert.ToDecimal(dgvInvoice.Rows[i].Cells[6].Value),

                                       Convert.ToInt32(dgvInvoice.Rows[i].Cells[1].Value));


            }

            MessageBox.Show("تمت عملية التعديل بنجاح", "عملية التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    ClearData();
            
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
        
            this.Cursor = Cursors.WaitCursor;
            int invoiceId = Convert.ToInt32(txtInvoiceId.Text);
            RPT.invoiceReport report = new RPT.invoiceReport();
            RPT.ordersReport frm = new RPT.ordersReport();
            report.SetDataSource(order.GETINVOICEDETAILSFORPRINT(invoiceId));
            frm.crystalReportViewer1.ReportSource = report;
            frm.ShowDialog();
            this.Cursor = Cursors.Default;
        }
    }
}
