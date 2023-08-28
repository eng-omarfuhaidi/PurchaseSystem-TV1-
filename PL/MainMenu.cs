using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace PurchaseSystem.PL
{ 
    public partial class MainMenu : Form
    {



        bool slidbarExpand;
        bool initialCollaps;
        bool operationsCollaps;
        bool reportCollaps;
        public MainMenu()
        {
            InitializeComponent();

        

        }

        private void AddCloseButton(TabPage tabPage)
        {
            // Set the DrawMode property of the TabControl to OwnerDrawFixed.
            this.tabControl1.DrawMode = (TabDrawMode)DrawMode.OwnerDrawFixed;

            // Create a Button control and set its Image property to the close button image.
            Button closeButton = new Button();
            closeButton.Image = Image.FromFile(@"C:\Users\omar_\source\repos\PurchaseSystem\Resources\Delete_50px.png");

            // Add the Button control to the tab page's Controls collection.
            tabPage.Controls.Add(closeButton);

        }


        private void slidbarTimer_Tick(object sender, EventArgs e)
        {
            if (slidbarExpand) 
            {
                slidbar.Width -= 10;
                if (slidbar.Width == slidbar.MinimumSize.Width) 
                {

                    slidbarExpand = false;
                    slidbarTimer.Stop();
               }
            }
            else 
            {
                slidbar.Width += 10;
                if (slidbar.Width == slidbar.MaximumSize.Width) 
                {
                    slidbarExpand = true;
                    slidbarTimer.Stop();


                }
            }
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            slidbarTimer.Start();
        }

        private void InitialTimer_Tick(object sender, EventArgs e)
        {
            if (initialCollaps)
            {
                initialContainer.Height += 10;
                if (initialContainer.Height == initialContainer.MaximumSize.Height)
                {
                    initialCollaps = false;
                    initialTimer.Stop();
                }
            }
            else 
            {
                initialContainer.Height -= 10;
                if (initialContainer.Height == initialContainer.MinimumSize.Height) 
                {
                    initialCollaps = true;
                    initialTimer.Stop();
                
                }
            }
        }

        private void btnInitial_Click(object sender, EventArgs e)
        {
            initialTimer.Start();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            operationsTimer.Start();
        }
   

        private void operationsTimer_Tick(object sender, EventArgs e)
        {
            if (operationsCollaps)
            {
                operationsContainer.Height += 10;
                if (operationsContainer.Height == operationsContainer.MaximumSize.Height)
                {
                    operationsCollaps = false;
                    operationsTimer.Stop();
                }
            }
            else
            {
                operationsContainer.Height -= 10;
                if (operationsContainer.Height == operationsContainer.MinimumSize.Height)
                {
                    operationsCollaps = true;
                    operationsTimer.Stop();

                }
            }
        }

        private void reportTinmer_Tick(object sender, EventArgs e)
        {
            if (reportCollaps)
            {
                reportContainer.Height += 10;
                if (reportContainer.Height == reportContainer.MaximumSize.Height)
                {
                    reportCollaps = false;
                    reportTinmer.Stop();
                }
            }
            else
            {
                reportContainer.Height -= 10;
                if (reportContainer.Height == reportContainer.MinimumSize.Height)
                {
                    reportCollaps = true;
                    reportTinmer.Stop();

                }
            }
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            reportTinmer.Start();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
           
        }

        private void btnManageVendors_Click(object sender, EventArgs e)
        {

            Vendors frm = new Vendors();
            TabPage tpage = new TabPage();
   
            tpage.Size = frm.Size;
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            tpage.Controls.Add(frm);
            frm.Show();
            tpage.Text = frm.Text;
            OpenTabPage(tpage);
 
        }

        private void OpenTabPage(TabPage tabPage)
        {
            if (!IsTabPageOpened(tabPage))
            {
               
                tabControl1.TabPages.Add(tabPage);
                tabControl1.SelectedTab = tabPage;
            }

           
        }

        private bool IsTabPageOpened(TabPage tabPage)
        {
            foreach (TabPage existingTabPage in tabControl1.TabPages)
            {
                if (HasSameContent(existingTabPage, tabPage))
                {
                    return true;

                }
            }

            return false;
        }

        private bool HasSameContent(TabPage tabPage1, TabPage tabPage2)
        {
            return tabPage1.Text == tabPage2.Text;
        }

        private void btnPurchasePrder_Click(object sender, EventArgs e)
        {
            PurchaseOrder frm = new PurchaseOrder();
            TabPage tpage = new TabPage();

            tpage.Size = frm.Size;
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            tpage.Controls.Add(frm);
            frm.Show();
            tpage.Text = frm.Text;
            OpenTabPage(tpage);
        }

        private void btnInvoice_Click(object sender, EventArgs e)
        {
            Invoice frm = new Invoice();
            TabPage tpage = new TabPage();

            tpage.Size = frm.Size;
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            tpage.Controls.Add(frm);
            frm.Show();
            tpage.Text = frm.Text;

     
            OpenTabPage(tpage);
        }

        private void btnReport1_Click(object sender, EventArgs e)
        {
            InvoiceDetails frm = new InvoiceDetails();
            TabPage tpage = new TabPage();

            tpage.Size = frm.Size;
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            tpage.Controls.Add(frm);
            frm.Show();
            tpage.Text = frm.Text;
         
            OpenTabPage(tpage);

    
        }

        private void btnRturnInvoice_Click(object sender, EventArgs e)
        {
            Return frm = new Return();
            TabPage tpage = new TabPage();

            tpage.Size = frm.Size;
            //frm.TopLevel = false;
            //frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            tpage.Controls.Add(frm);
            frm.Show();
            tpage.Text = "مردودات المشتريات";

            OpenTabPage(tpage);
        }
    }
}
