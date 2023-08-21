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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void اضافةموردينToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vendors frm = new Vendors();
            frm.ShowDialog();
        }

        private void طلبشراءToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PurchaseOrder frm = new PurchaseOrder();
            frm.ShowDialog();
        }

        private void فاتورةشراءToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Invoice frm = new Invoice();
            frm.ShowDialog();
        }

        private void فاتورةمردودمشترياتToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void خلاصةالمشترياتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InvoiceDetails frm = new InvoiceDetails();
            frm.ShowDialog();
        }
    }
}
