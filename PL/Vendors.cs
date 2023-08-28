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
    public partial class Vendors : Form
    {
        BL.vednorClass vendor = new BL.vednorClass();
        int ID, Position;
        public Vendors()
        {
            InitializeComponent();
            this.dgList.DataSource = vendor.GET_ALL_VENDORS();
           dgList.Columns[0].Visible =true;

            btnAdd.Image = PurchaseSystem.Properties.Resources.SaveBtn_32px;
            btnNew.Image = PurchaseSystem.Properties.Resources.AddBtn_32px;
            btnClose.Image = PurchaseSystem.Properties.Resources.CancelBtn_32px;
            btnEdit.Image = PurchaseSystem.Properties.Resources.EditeBtn_32px;
            btnPrint.Image = PurchaseSystem.Properties.Resources.PrintBtn_32px;
            btnDelete.Image = PurchaseSystem.Properties.Resources.DeleteBtn_32px;

        
        }

        private void Reset() 
        {
            txtAName.Clear();
            txtEName.Clear();
            txtPhone.Clear();
            txtAddress.Clear();
            textEmail.Clear();
            textAccount.Clear();

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Reset();
            txtAName.Focus();
            btnAdd.Enabled = true;
            btnNew.Enabled = false;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {

                vendor.ADD_VENDOR(txtAName.Text, txtEName.Text, Convert.ToInt32(txtPhone.Text), textEmail.Text, txtAddress.Text, Convert.ToInt32(textAccount.Text));
                MessageBox.Show("تمت الإضافة بنجاح", "الإضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.dgList.DataSource = vendor.GET_ALL_VENDORS();

            }
            catch
            {
                return;
            }
            finally
            {
                btnAdd.Enabled = false;
                btnNew.Enabled = true;
            }

        }

        private void txtAName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtEName.Focus();
            }
        }

        private void txtEName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtAddress.Focus();
            }
        }

        private void txtAddress_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPhone.Focus();
            }
        }

        private void txtPhone_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textEmail.Focus();
            }
        }

        private void textEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textAccount.Focus();
            }
        }

        private void dgList_DoubleClick(object sender, EventArgs e)
        {
            try
            {
    
                ID = Convert.ToInt32(dgList.CurrentRow.Cells[0].Value);
                this.txtAName.Text = dgList.CurrentRow.Cells[1].Value.ToString();
                this.txtPhone.Text = dgList.CurrentRow.Cells[2].Value.ToString();
                this.textEmail.Text = dgList.CurrentRow.Cells[3].Value.ToString();
                this.txtAddress.Text = dgList.CurrentRow.Cells[4].Value.ToString();
                this.textAccount.Text = dgList.CurrentRow.Cells[5].Value.ToString();
                this.txtEName.Text = dgList.CurrentRow.Cells[6].Value.ToString();
            }
            catch
            {
                return;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (ID == 0)
                {
                    MessageBox.Show("المورد المراد تعديله غير موجود");
                    return;
                }
                    
                    vendor.UPDATE_VENDOR(txtAName.Text, txtEName.Text,Convert.ToInt32(txtPhone.Text), textEmail.Text, txtAddress.Text ,Convert.ToInt32(textAccount.Text),ID);
                    MessageBox.Show("تم التعديل بنجاح", "التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.dgList.DataSource = vendor.GET_ALL_VENDORS();

            }
            catch
            {
                return;
            }

            Reset();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (ID == 0)
            {
                MessageBox.Show("المورد المراد حذفه غير موجود");
                return;
            }
            if (MessageBox.Show("هل تريد فعلا حذف هذا المورد؟", "الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
               vendor.DELETE_VENDOR(ID);
                MessageBox.Show("تم الحذف بنجاح", "الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.dgList.DataSource =vendor.GET_ALL_VENDORS();

            }
            Reset();
        }

        private void textAccount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAdd.Focus();
            }
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            Navigate(0);
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            Position = vendor.GET_ALL_VENDORS().Rows.Count - 1;
            Navigate(Position);
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (Position == 0)
            {
                MessageBox.Show("هذا هو أول عنصر");
                return;
            }
            Position -= 1;
            Navigate(Position);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (Position == vendor.GET_ALL_VENDORS().Rows.Count - 1)
            {
                MessageBox.Show("هذا هو آخر عنصر");
                return;
            }
            Position += 1;
            Navigate(Position);
        }

        void Navigate(int Index)
        {
            try
            {
             
                DataRowCollection DRC = vendor.GET_ALL_VENDORS().Rows;
                ID = Convert.ToInt32(DRC[Index][0]);
                txtAName.Text = DRC[Index][1].ToString();
                txtPhone.Text = DRC[Index][2].ToString();
                textEmail.Text = DRC[Index][3].ToString();
                txtAddress.Text = DRC[Index][4].ToString();
                textAccount.Text = DRC[Index][5].ToString();
                txtEName.Text = DRC[Index][6].ToString();


            }
            catch
            {
                return;
            }

        }


    }
}
