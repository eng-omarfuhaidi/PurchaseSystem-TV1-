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
    public partial class PurchaseOrderList : Form
    {
        BL.orderClass order = new BL.orderClass();
       
       
        public PurchaseOrderList()
        {
            InitializeComponent();
            this.dgvOrders.DataSource = order.GET_ALL_ORDERS();
        }

        private void dgvOrders_DoubleClick(object sender, EventArgs e)
        {
            
           
            Close();
        }
    }
}
