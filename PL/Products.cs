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
    public partial class Products : Form
    {
        private static Products frm;
        static void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }

        public static Products getMainForm
        {
            get
            {
                if (frm == null)
                {
                    frm = new Products();
                    frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
                }
                return frm;
            }
        }
        BL.productClass prd = new BL.productClass();
        public Products()
        {
            InitializeComponent();
            if (frm == null)
                frm = this;
            this.dataGridView1.DataSource = prd.GET_ALL_PRODUCTS();
        }

      
    }
}
