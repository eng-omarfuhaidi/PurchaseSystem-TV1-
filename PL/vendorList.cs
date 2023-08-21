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
    public partial class vendorList : Form
    {
        public vendorList()
        {
            InitializeComponent();
        }
        BL.vednorClass vendor = new BL.vednorClass();
        private void vendorList_Load(object sender, EventArgs e)
        {
            this.dgvVendors.DataSource = vendor.GET_ALL_VENDORS();
            this.dgvVendors.Columns[0].Visible = false;
            this.dgvVendors.Columns[5].Visible = false;

        }

        private void dgvVendors_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
