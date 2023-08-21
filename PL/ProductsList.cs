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

    public partial class ProductsList : Form
    {
        BL.productClass prd = new BL.productClass();
        public ProductsList()
        {
            InitializeComponent();

            this.dgvProducts.DataSource = prd.GET_ALL_PRODUCTS();
        }

        private void dgvProducts_DoubleClick(object sender, EventArgs e)
        {
            Close();
        }
    }
}
