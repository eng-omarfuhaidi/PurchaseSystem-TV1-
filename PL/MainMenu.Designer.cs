
namespace PurchaseSystem.PL
{
    partial class MainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.slidbar = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.menuButton = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.initialContainer = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnManageVendors = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnInitial = new System.Windows.Forms.Button();
            this.operationsContainer = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnRturnInvoice = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btnInvoice = new System.Windows.Forms.Button();
            this.panel11 = new System.Windows.Forms.Panel();
            this.btnPurchasePrder = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.reportContainer = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnReport = new System.Windows.Forms.Button();
            this.panel12 = new System.Windows.Forms.Panel();
            this.button9 = new System.Windows.Forms.Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.panel13 = new System.Windows.Forms.Panel();
            this.btnReport1 = new System.Windows.Forms.Button();
            this.slidbarTimer = new System.Windows.Forms.Timer(this.components);
            this.initialTimer = new System.Windows.Forms.Timer(this.components);
            this.operationsTimer = new System.Windows.Forms.Timer(this.components);
            this.reportTinmer = new System.Windows.Forms.Timer(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.slidbar.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).BeginInit();
            this.panel3.SuspendLayout();
            this.initialContainer.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.operationsContainer.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel5.SuspendLayout();
            this.reportContainer.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel13.SuspendLayout();
            this.SuspendLayout();
            // 
            // slidbar
            // 
            this.slidbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.slidbar.Controls.Add(this.panel1);
            this.slidbar.Controls.Add(this.panel3);
            this.slidbar.Controls.Add(this.initialContainer);
            this.slidbar.Controls.Add(this.operationsContainer);
            this.slidbar.Controls.Add(this.reportContainer);
            this.slidbar.Dock = System.Windows.Forms.DockStyle.Left;
            this.slidbar.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.slidbar.Location = new System.Drawing.Point(0, 0);
            this.slidbar.MaximumSize = new System.Drawing.Size(155, 700);
            this.slidbar.MinimumSize = new System.Drawing.Size(62, 450);
            this.slidbar.Name = "slidbar";
            this.slidbar.Size = new System.Drawing.Size(155, 700);
            this.slidbar.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.menuButton);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(217, 100);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(80, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "القائمة";
            // 
            // menuButton
            // 
            this.menuButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuButton.Image = global::PurchaseSystem.Properties.Resources.Menu_32px;
            this.menuButton.Location = new System.Drawing.Point(3, 28);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(50, 32);
            this.menuButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.menuButton.TabIndex = 0;
            this.menuButton.TabStop = false;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button2);
            this.panel3.Location = new System.Drawing.Point(3, 109);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(152, 35);
            this.panel3.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = global::PurchaseSystem.Properties.Resources.Home_32px;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.Location = new System.Drawing.Point(-3, -5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(234, 47);
            this.button2.TabIndex = 2;
            this.button2.Text = "الرئيسية";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // initialContainer
            // 
            this.initialContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.initialContainer.Controls.Add(this.panel6);
            this.initialContainer.Controls.Add(this.panel4);
            this.initialContainer.Location = new System.Drawing.Point(3, 150);
            this.initialContainer.MaximumSize = new System.Drawing.Size(155, 84);
            this.initialContainer.MinimumSize = new System.Drawing.Size(155, 39);
            this.initialContainer.Name = "initialContainer";
            this.initialContainer.Size = new System.Drawing.Size(155, 39);
            this.initialContainer.TabIndex = 4;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnManageVendors);
            this.panel6.Location = new System.Drawing.Point(0, 41);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(155, 35);
            this.panel6.TabIndex = 4;
            // 
            // btnManageVendors
            // 
            this.btnManageVendors.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManageVendors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageVendors.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageVendors.ForeColor = System.Drawing.SystemColors.Window;
            this.btnManageVendors.Image = global::PurchaseSystem.Properties.Resources.Business_Building_32px;
            this.btnManageVendors.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnManageVendors.Location = new System.Drawing.Point(-3, -5);
            this.btnManageVendors.Name = "btnManageVendors";
            this.btnManageVendors.Size = new System.Drawing.Size(194, 47);
            this.btnManageVendors.TabIndex = 2;
            this.btnManageVendors.Text = "إدارة الموردين";
            this.btnManageVendors.UseVisualStyleBackColor = true;
            this.btnManageVendors.Click += new System.EventHandler(this.btnManageVendors_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnInitial);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(155, 35);
            this.panel4.TabIndex = 3;
            // 
            // btnInitial
            // 
            this.btnInitial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btnInitial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInitial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInitial.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInitial.ForeColor = System.Drawing.SystemColors.Window;
            this.btnInitial.Image = global::PurchaseSystem.Properties.Resources.Settings_32px;
            this.btnInitial.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInitial.Location = new System.Drawing.Point(-3, -5);
            this.btnInitial.Name = "btnInitial";
            this.btnInitial.Size = new System.Drawing.Size(234, 47);
            this.btnInitial.TabIndex = 2;
            this.btnInitial.Text = "تهيئة النظام";
            this.btnInitial.UseVisualStyleBackColor = false;
            this.btnInitial.Click += new System.EventHandler(this.btnInitial_Click);
            // 
            // operationsContainer
            // 
            this.operationsContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.operationsContainer.Controls.Add(this.panel8);
            this.operationsContainer.Controls.Add(this.panel9);
            this.operationsContainer.Controls.Add(this.panel11);
            this.operationsContainer.Controls.Add(this.panel5);
            this.operationsContainer.Location = new System.Drawing.Point(3, 195);
            this.operationsContainer.MaximumSize = new System.Drawing.Size(155, 161);
            this.operationsContainer.MinimumSize = new System.Drawing.Size(155, 47);
            this.operationsContainer.Name = "operationsContainer";
            this.operationsContainer.Size = new System.Drawing.Size(155, 47);
            this.operationsContainer.TabIndex = 4;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.btnRturnInvoice);
            this.panel8.Location = new System.Drawing.Point(3, 126);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(152, 35);
            this.panel8.TabIndex = 5;
            // 
            // btnRturnInvoice
            // 
            this.btnRturnInvoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.btnRturnInvoice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRturnInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRturnInvoice.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRturnInvoice.ForeColor = System.Drawing.Color.White;
            this.btnRturnInvoice.Image = global::PurchaseSystem.Properties.Resources.Return_Purchase_32px;
            this.btnRturnInvoice.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRturnInvoice.Location = new System.Drawing.Point(-3, -5);
            this.btnRturnInvoice.Name = "btnRturnInvoice";
            this.btnRturnInvoice.Size = new System.Drawing.Size(181, 47);
            this.btnRturnInvoice.TabIndex = 2;
            this.btnRturnInvoice.Text = "مردودات الشراء";
            this.btnRturnInvoice.UseVisualStyleBackColor = false;
            this.btnRturnInvoice.Click += new System.EventHandler(this.btnRturnInvoice_Click);
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.btnInvoice);
            this.panel9.Location = new System.Drawing.Point(3, 85);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(152, 35);
            this.panel9.TabIndex = 6;
            // 
            // btnInvoice
            // 
            this.btnInvoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.btnInvoice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInvoice.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInvoice.ForeColor = System.Drawing.Color.White;
            this.btnInvoice.Image = global::PurchaseSystem.Properties.Resources.Invoice_32px;
            this.btnInvoice.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInvoice.Location = new System.Drawing.Point(-3, -5);
            this.btnInvoice.Name = "btnInvoice";
            this.btnInvoice.Size = new System.Drawing.Size(190, 47);
            this.btnInvoice.TabIndex = 2;
            this.btnInvoice.Text = "فواتير الشراء";
            this.btnInvoice.UseVisualStyleBackColor = false;
            this.btnInvoice.Click += new System.EventHandler(this.btnInvoice_Click);
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.btnPurchasePrder);
            this.panel11.Location = new System.Drawing.Point(0, 44);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(152, 35);
            this.panel11.TabIndex = 6;
            // 
            // btnPurchasePrder
            // 
            this.btnPurchasePrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.btnPurchasePrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPurchasePrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPurchasePrder.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPurchasePrder.ForeColor = System.Drawing.Color.White;
            this.btnPurchasePrder.Image = global::PurchaseSystem.Properties.Resources.Purchase_Order_32px;
            this.btnPurchasePrder.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPurchasePrder.Location = new System.Drawing.Point(-3, -5);
            this.btnPurchasePrder.Name = "btnPurchasePrder";
            this.btnPurchasePrder.Size = new System.Drawing.Size(193, 47);
            this.btnPurchasePrder.TabIndex = 2;
            this.btnPurchasePrder.Text = "طلبات الشراء";
            this.btnPurchasePrder.UseVisualStyleBackColor = false;
            this.btnPurchasePrder.Click += new System.EventHandler(this.btnPurchasePrder_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.panel5.Controls.Add(this.button4);
            this.panel5.Location = new System.Drawing.Point(0, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(152, 35);
            this.panel5.TabIndex = 3;
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Image = global::PurchaseSystem.Properties.Resources.Buy_32px;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.Location = new System.Drawing.Point(-3, -5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(234, 47);
            this.button4.TabIndex = 2;
            this.button4.Text = "العمليات";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // reportContainer
            // 
            this.reportContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.reportContainer.Controls.Add(this.panel2);
            this.reportContainer.Controls.Add(this.panel12);
            this.reportContainer.Controls.Add(this.panel10);
            this.reportContainer.Controls.Add(this.panel13);
            this.reportContainer.Location = new System.Drawing.Point(3, 248);
            this.reportContainer.MaximumSize = new System.Drawing.Size(155, 165);
            this.reportContainer.MinimumSize = new System.Drawing.Size(149, 47);
            this.reportContainer.Name = "reportContainer";
            this.reportContainer.Size = new System.Drawing.Size(149, 49);
            this.reportContainer.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.panel2.Controls.Add(this.btnReport);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(152, 46);
            this.panel2.TabIndex = 1;
            // 
            // btnReport
            // 
            this.btnReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.ForeColor = System.Drawing.Color.White;
            this.btnReport.Image = global::PurchaseSystem.Properties.Resources.Combo_Chart_32px;
            this.btnReport.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReport.Location = new System.Drawing.Point(-3, -5);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(234, 54);
            this.btnReport.TabIndex = 2;
            this.btnReport.Text = "التقارير";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.panel12.Controls.Add(this.button9);
            this.panel12.Location = new System.Drawing.Point(0, 123);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(152, 35);
            this.panel12.TabIndex = 4;
            // 
            // button9
            // 
            this.button9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.White;
            this.button9.Image = global::PurchaseSystem.Properties.Resources.Report_Card_32px;
            this.button9.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button9.Location = new System.Drawing.Point(-3, -5);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(188, 47);
            this.button9.TabIndex = 2;
            this.button9.Text = "صافي المشتريات";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.panel10.Controls.Add(this.button7);
            this.panel10.Location = new System.Drawing.Point(3, 82);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(152, 35);
            this.panel10.TabIndex = 3;
            // 
            // button7
            // 
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Image = global::PurchaseSystem.Properties.Resources.Return_32px;
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button7.Location = new System.Drawing.Point(-3, -5);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(188, 47);
            this.button7.TabIndex = 2;
            this.button7.Text = "مردود المشتريات";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.panel13.Controls.Add(this.btnReport1);
            this.panel13.Location = new System.Drawing.Point(3, 41);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(152, 35);
            this.panel13.TabIndex = 5;
            // 
            // btnReport1
            // 
            this.btnReport1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReport1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport1.ForeColor = System.Drawing.Color.White;
            this.btnReport1.Image = global::PurchaseSystem.Properties.Resources.Brief_32px;
            this.btnReport1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReport1.Location = new System.Drawing.Point(-3, -5);
            this.btnReport1.Name = "btnReport1";
            this.btnReport1.Size = new System.Drawing.Size(188, 47);
            this.btnReport1.TabIndex = 2;
            this.btnReport1.Text = "خلاصة المشتريات";
            this.btnReport1.UseVisualStyleBackColor = true;
            this.btnReport1.Click += new System.EventHandler(this.btnReport1_Click);
            // 
            // slidbarTimer
            // 
            this.slidbarTimer.Interval = 10;
            this.slidbarTimer.Tick += new System.EventHandler(this.slidbarTimer_Tick);
            // 
            // initialTimer
            // 
            this.initialTimer.Interval = 10;
            this.initialTimer.Tick += new System.EventHandler(this.InitialTimer_Tick);
            // 
            // operationsTimer
            // 
            this.operationsTimer.Interval = 10;
            this.operationsTimer.Tick += new System.EventHandler(this.operationsTimer_Tick);
            // 
            // reportTinmer
            // 
            this.reportTinmer.Interval = 10;
            this.reportTinmer.Tick += new System.EventHandler(this.reportTinmer_Tick);
            // 
            // tabControl1
            // 
            this.tabControl1.Location = new System.Drawing.Point(161, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeftLayout = true;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.ShowToolTips = true;
            this.tabControl1.Size = new System.Drawing.Size(1211, 743);
            this.tabControl1.TabIndex = 1;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.slidbar);
            this.Name = "MainMenu";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "نظام المشتريات";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.slidbar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).EndInit();
            this.panel3.ResumeLayout(false);
            this.initialContainer.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.operationsContainer.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.reportContainer.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel slidbar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnInitial;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox menuButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer slidbarTimer;
        private System.Windows.Forms.Panel initialContainer;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnManageVendors;
        public System.Windows.Forms.Timer initialTimer;
        private System.Windows.Forms.Panel operationsContainer;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btnRturnInvoice;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button btnInvoice;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Button btnPurchasePrder;
        private System.Windows.Forms.Timer operationsTimer;
        private System.Windows.Forms.Panel reportContainer;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Button btnReport1;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Timer reportTinmer;
        private System.Windows.Forms.TabControl tabControl1;
    }
}