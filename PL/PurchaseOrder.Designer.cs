namespace PurchaseSystem.PL
{
    partial class PurchaseOrder
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.btnDel = new System.Windows.Forms.DataGridViewButtonColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.حذفToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.تعديلToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.حذفالكلToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSystemUser = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDeliveryAddress = new System.Windows.Forms.TextBox();
            this.orderId = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.dtOrder = new System.Windows.Forms.DateTimePicker();
            this.txtOderNumber = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtOrderDesc = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtAccountNumber = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtSuppID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSuppPhone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSuppAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSuppName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.combSearch = new System.Windows.Forms.ComboBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbFirst = new System.Windows.Forms.PictureBox();
            this.pbBackward = new System.Windows.Forms.PictureBox();
            this.pbForward = new System.Windows.Forms.PictureBox();
            this.pbEnd = new System.Windows.Forms.PictureBox();
            this.pbSearch = new System.Windows.Forms.PictureBox();
            this.label24 = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFirst)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackward)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbForward)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(128)))), ((int)(((byte)(182)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.ImageKey = "cross.png";
            this.btnClose.Location = new System.Drawing.Point(745, 612);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(118, 48);
            this.btnClose.TabIndex = 24;
            this.btnClose.Text = "خروج";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvProducts);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(29, 347);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(922, 238);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "بنود الطلب";
            // 
            // dgvProducts
            // 
            this.dgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProducts.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.dgvProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnDel});
            this.dgvProducts.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvProducts.Location = new System.Drawing.Point(89, 19);
            this.dgvProducts.MultiSelect = false;
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.RowHeadersWidth = 86;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvProducts.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducts.Size = new System.Drawing.Size(771, 213);
            this.dgvProducts.TabIndex = 2;
            this.dgvProducts.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvProducts_CellBeginEdit);
            this.dgvProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducts_CellClick);
            this.dgvProducts.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvProducts_EditingControlShowing);
            // 
            // btnDel
            // 
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDel.HeaderText = "عمليات";
            this.btnDel.Name = "btnDel";
            this.btnDel.Text = "حذف";
            this.btnDel.UseColumnTextForButtonValue = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.حذفToolStripMenuItem,
            this.تعديلToolStripMenuItem,
            this.حذفالكلToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(169, 70);
            // 
            // حذفToolStripMenuItem
            // 
            this.حذفToolStripMenuItem.Name = "حذفToolStripMenuItem";
            this.حذفToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.حذفToolStripMenuItem.Text = "تعديل";
            this.حذفToolStripMenuItem.Click += new System.EventHandler(this.حذفToolStripMenuItem_Click);
            // 
            // تعديلToolStripMenuItem
            // 
            this.تعديلToolStripMenuItem.Name = "تعديلToolStripMenuItem";
            this.تعديلToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.تعديلToolStripMenuItem.Text = "حذف السطر الحالي";
            this.تعديلToolStripMenuItem.Click += new System.EventHandler(this.تعديلToolStripMenuItem_Click);
            // 
            // حذفالكلToolStripMenuItem
            // 
            this.حذفالكلToolStripMenuItem.Name = "حذفالكلToolStripMenuItem";
            this.حذفالكلToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.حذفالكلToolStripMenuItem.Text = "حذف الكل";
            this.حذفالكلToolStripMenuItem.Click += new System.EventHandler(this.حذفالكلToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSystemUser);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtDeliveryAddress);
            this.groupBox1.Controls.Add(this.orderId);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.dtOrder);
            this.groupBox1.Controls.Add(this.txtOderNumber);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtOrderDesc);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(29, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(427, 243);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "بيانات الطلب";
            // 
            // txtSystemUser
            // 
            this.txtSystemUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSystemUser.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSystemUser.Location = new System.Drawing.Point(122, 188);
            this.txtSystemUser.Name = "txtSystemUser";
            this.txtSystemUser.ReadOnly = true;
            this.txtSystemUser.Size = new System.Drawing.Size(172, 24);
            this.txtSystemUser.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(314, 191);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 19);
            this.label8.TabIndex = 13;
            this.label8.Text = "مستخدم النظام:";
            // 
            // txtDeliveryAddress
            // 
            this.txtDeliveryAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDeliveryAddress.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeliveryAddress.Location = new System.Drawing.Point(122, 153);
            this.txtDeliveryAddress.Name = "txtDeliveryAddress";
            this.txtDeliveryAddress.Size = new System.Drawing.Size(172, 24);
            this.txtDeliveryAddress.TabIndex = 12;
            // 
            // orderId
            // 
            this.orderId.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderId.Location = new System.Drawing.Point(32, 23);
            this.orderId.Name = "orderId";
            this.orderId.ReadOnly = true;
            this.orderId.Size = new System.Drawing.Size(100, 24);
            this.orderId.TabIndex = 33;
            this.orderId.Visible = false;
            this.orderId.TextChanged += new System.EventHandler(this.orderId_TextChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(314, 156);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(79, 19);
            this.label19.TabIndex = 11;
            this.label19.Text = "عنوان التوصيل:";
            // 
            // dtOrder
            // 
            this.dtOrder.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtOrder.Location = new System.Drawing.Point(32, 118);
            this.dtOrder.Name = "dtOrder";
            this.dtOrder.Size = new System.Drawing.Size(262, 24);
            this.dtOrder.TabIndex = 2;
            // 
            // txtOderNumber
            // 
            this.txtOderNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOderNumber.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOderNumber.Location = new System.Drawing.Point(176, 32);
            this.txtOderNumber.Name = "txtOderNumber";
            this.txtOderNumber.ReadOnly = true;
            this.txtOderNumber.Size = new System.Drawing.Size(118, 24);
            this.txtOderNumber.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(311, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 19);
            this.label6.TabIndex = 9;
            this.label6.Text = "رقم الطب:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(314, 124);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 19);
            this.label9.TabIndex = 2;
            this.label9.Text = "تاريخ الطلب:";
            // 
            // txtOrderDesc
            // 
            this.txtOrderDesc.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrderDesc.Location = new System.Drawing.Point(32, 64);
            this.txtOrderDesc.Multiline = true;
            this.txtOrderDesc.Name = "txtOrderDesc";
            this.txtOrderDesc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOrderDesc.Size = new System.Drawing.Size(262, 48);
            this.txtOrderDesc.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(311, 67);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 19);
            this.label10.TabIndex = 0;
            this.label10.Text = "وصف الطلب:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtAccountNumber);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.txtSuppID);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtEmail);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtSuppPhone);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtSuppAddress);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtSuppName);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Location = new System.Drawing.Point(524, 73);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(427, 243);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "بيانات المورد";
            // 
            // txtAccountNumber
            // 
            this.txtAccountNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAccountNumber.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccountNumber.Location = new System.Drawing.Point(122, 184);
            this.txtAccountNumber.Name = "txtAccountNumber";
            this.txtAccountNumber.ReadOnly = true;
            this.txtAccountNumber.Size = new System.Drawing.Size(172, 24);
            this.txtAccountNumber.TabIndex = 12;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(323, 190);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(104, 19);
            this.label20.TabIndex = 13;
            this.label20.Text = "رقم الحساب البنكي:";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(122, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(48, 20);
            this.button1.TabIndex = 11;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtSuppID
            // 
            this.txtSuppID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSuppID.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSuppID.Location = new System.Drawing.Point(176, 27);
            this.txtSuppID.Name = "txtSuppID";
            this.txtSuppID.ReadOnly = true;
            this.txtSuppID.Size = new System.Drawing.Size(118, 24);
            this.txtSuppID.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(321, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "معرف المورد:";
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(122, 146);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(172, 24);
            this.txtEmail.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(321, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "البريد الالكتروني:";
            // 
            // txtSuppPhone
            // 
            this.txtSuppPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSuppPhone.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSuppPhone.Location = new System.Drawing.Point(122, 117);
            this.txtSuppPhone.Name = "txtSuppPhone";
            this.txtSuppPhone.ReadOnly = true;
            this.txtSuppPhone.Size = new System.Drawing.Size(172, 24);
            this.txtSuppPhone.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(321, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "رقم الهاتف:";
            // 
            // txtSuppAddress
            // 
            this.txtSuppAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSuppAddress.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSuppAddress.Location = new System.Drawing.Point(122, 88);
            this.txtSuppAddress.Name = "txtSuppAddress";
            this.txtSuppAddress.ReadOnly = true;
            this.txtSuppAddress.Size = new System.Drawing.Size(172, 24);
            this.txtSuppAddress.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(323, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "العنوان:";
            // 
            // txtSuppName
            // 
            this.txtSuppName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSuppName.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSuppName.Location = new System.Drawing.Point(122, 59);
            this.txtSuppName.Name = "txtSuppName";
            this.txtSuppName.ReadOnly = true;
            this.txtSuppName.Size = new System.Drawing.Size(172, 24);
            this.txtSuppName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(321, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "اسم المورد:";
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(128)))), ((int)(((byte)(182)))));
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrint.ImageKey = "printer.png";
            this.btnPrint.Location = new System.Drawing.Point(621, 612);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(118, 48);
            this.btnPrint.TabIndex = 23;
            this.btnPrint.Text = "طباعة";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(128)))), ((int)(((byte)(182)))));
            this.btnAdd.Enabled = false;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.ImageKey = "(none)";
            this.btnAdd.Location = new System.Drawing.Point(249, 612);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(118, 48);
            this.btnAdd.TabIndex = 22;
            this.btnAdd.Text = "حفظ";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(128)))), ((int)(((byte)(182)))));
            this.btnNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ForeColor = System.Drawing.Color.White;
            this.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNew.ImageKey = "add.png";
            this.btnNew.Location = new System.Drawing.Point(126, 612);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(118, 48);
            this.btnNew.TabIndex = 21;
            this.btnNew.Text = "إضافة";
            this.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // combSearch
            // 
            this.combSearch.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combSearch.FormattingEnabled = true;
            this.combSearch.Location = new System.Drawing.Point(388, 13);
            this.combSearch.Name = "combSearch";
            this.combSearch.Size = new System.Drawing.Size(250, 27);
            this.combSearch.TabIndex = 32;
            this.combSearch.Text = "بحث";
            this.combSearch.SelectedValueChanged += new System.EventHandler(this.combSearch_SelectedValueChanged);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(128)))), ((int)(((byte)(182)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdate.ImageKey = "printer.png";
            this.btnUpdate.Location = new System.Drawing.Point(500, 612);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(118, 48);
            this.btnUpdate.TabIndex = 35;
            this.btnUpdate.Text = "تعديل";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PurchaseSystem.Properties.Resources.Horizontal_Line_48px;
            this.pictureBox1.Location = new System.Drawing.Point(-6, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1145, 18);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // pbFirst
            // 
            this.pbFirst.Image = global::PurchaseSystem.Properties.Resources.Skip_to_Start_48px;
            this.pbFirst.Location = new System.Drawing.Point(1043, 12);
            this.pbFirst.Name = "pbFirst";
            this.pbFirst.Size = new System.Drawing.Size(25, 29);
            this.pbFirst.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFirst.TabIndex = 31;
            this.pbFirst.TabStop = false;
            this.pbFirst.Click += new System.EventHandler(this.pbFirst_Click);
            // 
            // pbBackward
            // 
            this.pbBackward.Image = global::PurchaseSystem.Properties.Resources.Rewind_48px;
            this.pbBackward.Location = new System.Drawing.Point(1015, 12);
            this.pbBackward.Name = "pbBackward";
            this.pbBackward.Size = new System.Drawing.Size(25, 29);
            this.pbBackward.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBackward.TabIndex = 30;
            this.pbBackward.TabStop = false;
            this.pbBackward.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pbForward
            // 
            this.pbForward.Image = global::PurchaseSystem.Properties.Resources.Fast_Forward_48px;
            this.pbForward.Location = new System.Drawing.Point(915, 12);
            this.pbForward.Name = "pbForward";
            this.pbForward.Size = new System.Drawing.Size(25, 29);
            this.pbForward.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbForward.TabIndex = 29;
            this.pbForward.TabStop = false;
            this.pbForward.Click += new System.EventHandler(this.pbForward_Click);
            // 
            // pbEnd
            // 
            this.pbEnd.Image = global::PurchaseSystem.Properties.Resources.End_48px;
            this.pbEnd.Location = new System.Drawing.Point(886, 12);
            this.pbEnd.Name = "pbEnd";
            this.pbEnd.Size = new System.Drawing.Size(25, 29);
            this.pbEnd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbEnd.TabIndex = 28;
            this.pbEnd.TabStop = false;
            this.pbEnd.Click += new System.EventHandler(this.pbEnd_Click);
            // 
            // pbSearch
            // 
            this.pbSearch.Image = global::PurchaseSystem.Properties.Resources.Search_50px;
            this.pbSearch.Location = new System.Drawing.Point(646, 13);
            this.pbSearch.Name = "pbSearch";
            this.pbSearch.Size = new System.Drawing.Size(24, 21);
            this.pbSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSearch.TabIndex = 27;
            this.pbSearch.TabStop = false;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(177, 14);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(95, 25);
            this.label24.TabIndex = 45;
            this.label24.Text = "طلب شراء";
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(128)))), ((int)(((byte)(182)))));
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.ForeColor = System.Drawing.Color.White;
            this.buttonDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonDelete.ImageKey = "printer.png";
            this.buttonDelete.Location = new System.Drawing.Point(376, 612);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(118, 48);
            this.buttonDelete.TabIndex = 46;
            this.buttonDelete.Text = "حذف";
            this.buttonDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // PurchaseOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(1151, 704);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.combSearch);
            this.Controls.Add(this.pbFirst);
            this.Controls.Add(this.pbBackward);
            this.Controls.Add(this.pbForward);
            this.Controls.Add(this.pbEnd);
            this.Controls.Add(this.pbSearch);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnAdd);
            this.Name = "PurchaseOrder";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "اضافة طلب شراء";
            this.Load += new System.EventHandler(this.PurchaseOrder_Load);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFirst)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackward)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbForward)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtOrder;
        private System.Windows.Forms.TextBox txtOderNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtOrderDesc;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtSuppID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSuppPhone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSuppAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSuppName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtDeliveryAddress;
        private System.Windows.Forms.TextBox txtAccountNumber;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtSystemUser;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem حذفToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem تعديلToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem حذفالكلToolStripMenuItem;
        private System.Windows.Forms.PictureBox pbSearch;
        private System.Windows.Forms.PictureBox pbEnd;
        private System.Windows.Forms.PictureBox pbForward;
        private System.Windows.Forms.PictureBox pbBackward;
        private System.Windows.Forms.PictureBox pbFirst;
        private System.Windows.Forms.ComboBox combSearch;
        private System.Windows.Forms.TextBox orderId;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnUpdate;
        public System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.DataGridViewButtonColumn btnDel;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Button buttonDelete;
    }
}