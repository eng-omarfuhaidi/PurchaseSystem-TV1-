
namespace PurchaseSystem.PL
{
    partial class InvoiceDetails
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.comInvoice = new System.Windows.Forms.ComboBox();
            this.txtVendorName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtVInvoice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOrderNumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dateInvoice = new System.Windows.Forms.DateTimePicker();
            this.dueDate = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.txtboxCurrency = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 175);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(808, 226);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "بنود الفاتورة";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(796, 312);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(333, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "اختر فاتورة:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button7);
            this.groupBox2.Controls.Add(this.button8);
            this.groupBox2.Location = new System.Drawing.Point(12, 407);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(808, 94);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "العمليات المتاحة";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(279, 34);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(122, 23);
            this.button7.TabIndex = 7;
            this.button7.Text = "الخروج";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(407, 34);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(155, 23);
            this.button8.TabIndex = 6;
            this.button8.Text = "طباعة الفاتورة";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // comInvoice
            // 
            this.comInvoice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comInvoice.FormattingEnabled = true;
            this.comInvoice.Location = new System.Drawing.Point(406, 23);
            this.comInvoice.Name = "comInvoice";
            this.comInvoice.Size = new System.Drawing.Size(121, 21);
            this.comInvoice.TabIndex = 8;
            this.comInvoice.ValueMemberChanged += new System.EventHandler(this.comInvoice_ValueMemberChanged);
            this.comInvoice.SelectedValueChanged += new System.EventHandler(this.comInvoice_SelectedValueChanged);
            // 
            // txtVendorName
            // 
            this.txtVendorName.Location = new System.Drawing.Point(97, 77);
            this.txtVendorName.Name = "txtVendorName";
            this.txtVendorName.ReadOnly = true;
            this.txtVendorName.Size = new System.Drawing.Size(118, 20);
            this.txtVendorName.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "اسم المورد:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(227, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "رقم فاتورة المورد:";
            // 
            // txtVInvoice
            // 
            this.txtVInvoice.Location = new System.Drawing.Point(315, 80);
            this.txtVInvoice.Name = "txtVInvoice";
            this.txtVInvoice.ReadOnly = true;
            this.txtVInvoice.Size = new System.Drawing.Size(118, 20);
            this.txtVInvoice.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(444, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "رقم الطلب:";
            // 
            // txtOrderNumber
            // 
            this.txtOrderNumber.Location = new System.Drawing.Point(509, 83);
            this.txtOrderNumber.Name = "txtOrderNumber";
            this.txtOrderNumber.ReadOnly = true;
            this.txtOrderNumber.Size = new System.Drawing.Size(118, 20);
            this.txtOrderNumber.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(638, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "اجمالي الفاتورة:";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(720, 86);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.ReadOnly = true;
            this.txtAmount.Size = new System.Drawing.Size(118, 20);
            this.txtAmount.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(254, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "تاريخ الفاتورة:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(544, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "تاريخ الاستحقاق:";
            // 
            // dateInvoice
            // 
            this.dateInvoice.Location = new System.Drawing.Point(327, 137);
            this.dateInvoice.Name = "dateInvoice";
            this.dateInvoice.Size = new System.Drawing.Size(200, 20);
            this.dateInvoice.TabIndex = 21;
            // 
            // dueDate
            // 
            this.dueDate.Location = new System.Drawing.Point(636, 140);
            this.dueDate.Name = "dueDate";
            this.dueDate.Size = new System.Drawing.Size(200, 20);
            this.dueDate.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "عملة الفاتورة:";
            // 
            // txtboxCurrency
            // 
            this.txtboxCurrency.Location = new System.Drawing.Point(97, 137);
            this.txtboxCurrency.Name = "txtboxCurrency";
            this.txtboxCurrency.ReadOnly = true;
            this.txtboxCurrency.Size = new System.Drawing.Size(118, 20);
            this.txtboxCurrency.TabIndex = 23;
            // 
            // InvoiceDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 504);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtboxCurrency);
            this.Controls.Add(this.dueDate);
            this.Controls.Add(this.dateInvoice);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtOrderNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtVInvoice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtVendorName);
            this.Controls.Add(this.comInvoice);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Name = "InvoiceDetails";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "InvoiceDetails";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.ComboBox comInvoice;
        private System.Windows.Forms.TextBox txtVendorName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtVInvoice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtOrderNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateInvoice;
        private System.Windows.Forms.DateTimePicker dueDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtboxCurrency;
    }
}