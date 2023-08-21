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
    public partial class InvoiceDetails : Form
    {
        BL.orderClass order = new BL.orderClass();
        public InvoiceDetails()
        {
            InitializeComponent();
           
            comInvoice.DisplayMember = "INVOICENUMBER";
            comInvoice.ValueMember = "INVOICEID";
            comInvoice.DataSource = order.Fill_InvoiceCombo();
        }



        private void comInvoice_SelectedValueChanged(object sender, EventArgs e)
        {
           // int invoiceId = Convert.ToInt32(((DataRowView)comInvoice.SelectedValue)["INVOICEID"]);
            int invoiceId = Convert.ToInt32(comInvoice.SelectedValue);
            DataTable dataTable = new DataTable();
            dataTable = order.GET_MAININVOICEDETAILS_BYID(invoiceId);

            if (dataTable.Rows.Count == 1)
            {
                DataRow row = dataTable.Rows[0];
                string value = row["vendorname"].ToString();
                txtVendorName.Text = value;
                txtVInvoice.Text = row["vinvoicenumber"].ToString();

              txtOrderNumber.Text = row["ordernumber"].ToString(); 

                txtAmount.Text= row["amount"].ToString();

                txtboxCurrency.Text= row["currency"].ToString();
                dateInvoice.Value = Convert.ToDateTime(row["invodate"]);
               dueDate.Value=Convert.ToDateTime(row["dudate"]);
            }

            dataGridView1.DataSource = order.GetSecInviceDetailsBYID(invoiceId);
        }

        private void comInvoice_ValueMemberChanged(object sender, EventArgs e)
        {

        }
    }
}
