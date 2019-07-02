namespace ControlApp.OnPremises.Panels.Admin
{
    partial class pnlAdminReceipt
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.btnCleanFields = new MetroFramework.Controls.MetroTile();
            this.btnActivate = new MetroFramework.Controls.MetroTile();
            this.btnDelete = new MetroFramework.Controls.MetroTile();
            this.btnPrint = new MetroFramework.Controls.MetroTile();
            this.txtRetrieveByName = new MetroFramework.Controls.MetroTextBox();
            this.lblRetrieve = new MetroFramework.Controls.MetroLabel();
            this.lblTotal = new MetroFramework.Controls.MetroLabel();
            this.txtTotalReceipt = new MetroFramework.Controls.MetroTextBox();
            this.txtQuantity = new MetroFramework.Controls.MetroTextBox();
            this.lblCantidad = new MetroFramework.Controls.MetroLabel();
            this.txtNameCustomer = new MetroFramework.Controls.MetroTextBox();
            this.lblNameCustomer = new MetroFramework.Controls.MetroLabel();
            this.dgvReceipt = new MetroFramework.Controls.MetroGrid();
            this.ID_RECEIPT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NAME_CUSTOMER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QUANTITY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOTAL_RECEIPT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CASH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHANGE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_PRODUCT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UNIT_PRICE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATE_RECEIPT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RECEIPT_STATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RECEIPT_CREATEBY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RECEIPT_UPDATEBY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RECEIPT_CREATEDATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RECEIPT_UPDATEDATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCreate = new MetroFramework.Controls.MetroTile();
            this.btnUpdate = new MetroFramework.Controls.MetroTile();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.dtEnd = new System.Windows.Forms.DateTimePicker();
            this.dtBegin = new System.Windows.Forms.DateTimePicker();
            this.btnRefresh = new MetroFramework.Controls.MetroTile();
            this.btnLoadRpt = new MetroFramework.Controls.MetroTile();
            this.lblEnd = new MetroFramework.Controls.MetroLabel();
            this.lblBegin = new MetroFramework.Controls.MetroLabel();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceipt)).BeginInit();
            this.metroTabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Location = new System.Drawing.Point(3, 0);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(694, 568);
            this.metroTabControl1.TabIndex = 55;
            this.metroTabControl1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.btnCleanFields);
            this.metroTabPage1.Controls.Add(this.btnActivate);
            this.metroTabPage1.Controls.Add(this.btnDelete);
            this.metroTabPage1.Controls.Add(this.btnPrint);
            this.metroTabPage1.Controls.Add(this.txtRetrieveByName);
            this.metroTabPage1.Controls.Add(this.lblRetrieve);
            this.metroTabPage1.Controls.Add(this.lblTotal);
            this.metroTabPage1.Controls.Add(this.txtTotalReceipt);
            this.metroTabPage1.Controls.Add(this.txtQuantity);
            this.metroTabPage1.Controls.Add(this.lblCantidad);
            this.metroTabPage1.Controls.Add(this.txtNameCustomer);
            this.metroTabPage1.Controls.Add(this.lblNameCustomer);
            this.metroTabPage1.Controls.Add(this.dgvReceipt);
            this.metroTabPage1.Controls.Add(this.btnCreate);
            this.metroTabPage1.Controls.Add(this.btnUpdate);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(686, 526);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Recibos";
            this.metroTabPage1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // btnCleanFields
            // 
            this.btnCleanFields.ActiveControl = null;
            this.btnCleanFields.Location = new System.Drawing.Point(446, 3);
            this.btnCleanFields.Name = "btnCleanFields";
            this.btnCleanFields.Size = new System.Drawing.Size(83, 60);
            this.btnCleanFields.TabIndex = 69;
            this.btnCleanFields.Text = "Refrescar";
            this.btnCleanFields.UseSelectable = true;
            this.btnCleanFields.Click += new System.EventHandler(this.btnCleanFields_Click);
            // 
            // btnActivate
            // 
            this.btnActivate.ActiveControl = null;
            this.btnActivate.Location = new System.Drawing.Point(357, 3);
            this.btnActivate.Name = "btnActivate";
            this.btnActivate.Size = new System.Drawing.Size(83, 60);
            this.btnActivate.TabIndex = 68;
            this.btnActivate.Text = "Activar";
            this.btnActivate.UseSelectable = true;
            this.btnActivate.Click += new System.EventHandler(this.btnActivate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.ActiveControl = null;
            this.btnDelete.Location = new System.Drawing.Point(268, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(83, 60);
            this.btnDelete.TabIndex = 67;
            this.btnDelete.Text = "Inactivar";
            this.btnDelete.UseSelectable = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.ActiveControl = null;
            this.btnPrint.Location = new System.Drawing.Point(178, 3);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(83, 60);
            this.btnPrint.TabIndex = 66;
            this.btnPrint.Text = "Imprimir";
            this.btnPrint.UseSelectable = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // txtRetrieveByName
            // 
            // 
            // 
            // 
            this.txtRetrieveByName.CustomButton.Image = null;
            this.txtRetrieveByName.CustomButton.Location = new System.Drawing.Point(113, 1);
            this.txtRetrieveByName.CustomButton.Name = "";
            this.txtRetrieveByName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtRetrieveByName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtRetrieveByName.CustomButton.TabIndex = 1;
            this.txtRetrieveByName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtRetrieveByName.CustomButton.UseSelectable = true;
            this.txtRetrieveByName.CustomButton.Visible = false;
            this.txtRetrieveByName.Lines = new string[0];
            this.txtRetrieveByName.Location = new System.Drawing.Point(548, 72);
            this.txtRetrieveByName.MaxLength = 32767;
            this.txtRetrieveByName.Name = "txtRetrieveByName";
            this.txtRetrieveByName.PasswordChar = '\0';
            this.txtRetrieveByName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtRetrieveByName.SelectedText = "";
            this.txtRetrieveByName.SelectionLength = 0;
            this.txtRetrieveByName.SelectionStart = 0;
            this.txtRetrieveByName.ShortcutsEnabled = true;
            this.txtRetrieveByName.Size = new System.Drawing.Size(135, 23);
            this.txtRetrieveByName.TabIndex = 64;
            this.txtRetrieveByName.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtRetrieveByName.UseSelectable = true;
            this.txtRetrieveByName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtRetrieveByName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtRetrieveByName.TextChanged += new System.EventHandler(this.txtRetrieveByName_TextChanged);
            this.txtRetrieveByName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRetrieveByName_KeyPress);
            // 
            // lblRetrieve
            // 
            this.lblRetrieve.AutoSize = true;
            this.lblRetrieve.Location = new System.Drawing.Point(495, 76);
            this.lblRetrieve.Name = "lblRetrieve";
            this.lblRetrieve.Size = new System.Drawing.Size(47, 19);
            this.lblRetrieve.TabIndex = 65;
            this.lblRetrieve.Text = "Buscar";
            this.lblRetrieve.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(29, 134);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(36, 19);
            this.lblTotal.TabIndex = 63;
            this.lblTotal.Text = "Total";
            this.lblTotal.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtTotalReceipt
            // 
            // 
            // 
            // 
            this.txtTotalReceipt.CustomButton.Image = null;
            this.txtTotalReceipt.CustomButton.Location = new System.Drawing.Point(117, 1);
            this.txtTotalReceipt.CustomButton.Name = "";
            this.txtTotalReceipt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTotalReceipt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTotalReceipt.CustomButton.TabIndex = 1;
            this.txtTotalReceipt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTotalReceipt.CustomButton.UseSelectable = true;
            this.txtTotalReceipt.CustomButton.Visible = false;
            this.txtTotalReceipt.Lines = new string[0];
            this.txtTotalReceipt.Location = new System.Drawing.Point(89, 130);
            this.txtTotalReceipt.MaxLength = 32767;
            this.txtTotalReceipt.Name = "txtTotalReceipt";
            this.txtTotalReceipt.PasswordChar = '\0';
            this.txtTotalReceipt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTotalReceipt.SelectedText = "";
            this.txtTotalReceipt.SelectionLength = 0;
            this.txtTotalReceipt.SelectionStart = 0;
            this.txtTotalReceipt.ShortcutsEnabled = true;
            this.txtTotalReceipt.Size = new System.Drawing.Size(139, 23);
            this.txtTotalReceipt.TabIndex = 62;
            this.txtTotalReceipt.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtTotalReceipt.UseSelectable = true;
            this.txtTotalReceipt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTotalReceipt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtQuantity
            // 
            // 
            // 
            // 
            this.txtQuantity.CustomButton.Image = null;
            this.txtQuantity.CustomButton.Location = new System.Drawing.Point(117, 1);
            this.txtQuantity.CustomButton.Name = "";
            this.txtQuantity.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtQuantity.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtQuantity.CustomButton.TabIndex = 1;
            this.txtQuantity.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtQuantity.CustomButton.UseSelectable = true;
            this.txtQuantity.CustomButton.Visible = false;
            this.txtQuantity.Lines = new string[0];
            this.txtQuantity.Location = new System.Drawing.Point(89, 101);
            this.txtQuantity.MaxLength = 32767;
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.PasswordChar = '\0';
            this.txtQuantity.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtQuantity.SelectedText = "";
            this.txtQuantity.SelectionLength = 0;
            this.txtQuantity.SelectionStart = 0;
            this.txtQuantity.ShortcutsEnabled = true;
            this.txtQuantity.Size = new System.Drawing.Size(139, 23);
            this.txtQuantity.TabIndex = 61;
            this.txtQuantity.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtQuantity.UseSelectable = true;
            this.txtQuantity.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtQuantity.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtQuantity.TextChanged += new System.EventHandler(this.txtQuantity_TextChanged);
            this.txtQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantity_KeyPress);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(3, 105);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(62, 19);
            this.lblCantidad.TabIndex = 60;
            this.lblCantidad.Text = "Cantidad";
            this.lblCantidad.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtNameCustomer
            // 
            // 
            // 
            // 
            this.txtNameCustomer.CustomButton.Image = null;
            this.txtNameCustomer.CustomButton.Location = new System.Drawing.Point(117, 1);
            this.txtNameCustomer.CustomButton.Name = "";
            this.txtNameCustomer.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNameCustomer.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNameCustomer.CustomButton.TabIndex = 1;
            this.txtNameCustomer.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNameCustomer.CustomButton.UseSelectable = true;
            this.txtNameCustomer.CustomButton.Visible = false;
            this.txtNameCustomer.Lines = new string[0];
            this.txtNameCustomer.Location = new System.Drawing.Point(89, 72);
            this.txtNameCustomer.MaxLength = 32767;
            this.txtNameCustomer.Name = "txtNameCustomer";
            this.txtNameCustomer.PasswordChar = '\0';
            this.txtNameCustomer.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNameCustomer.SelectedText = "";
            this.txtNameCustomer.SelectionLength = 0;
            this.txtNameCustomer.SelectionStart = 0;
            this.txtNameCustomer.ShortcutsEnabled = true;
            this.txtNameCustomer.Size = new System.Drawing.Size(139, 23);
            this.txtNameCustomer.TabIndex = 59;
            this.txtNameCustomer.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtNameCustomer.UseSelectable = true;
            this.txtNameCustomer.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNameCustomer.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblNameCustomer
            // 
            this.lblNameCustomer.AutoSize = true;
            this.lblNameCustomer.Location = new System.Drawing.Point(16, 76);
            this.lblNameCustomer.Name = "lblNameCustomer";
            this.lblNameCustomer.Size = new System.Drawing.Size(49, 19);
            this.lblNameCustomer.TabIndex = 58;
            this.lblNameCustomer.Text = "Cliente";
            this.lblNameCustomer.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // dgvReceipt
            // 
            this.dgvReceipt.AllowUserToAddRows = false;
            this.dgvReceipt.AllowUserToDeleteRows = false;
            this.dgvReceipt.AllowUserToResizeRows = false;
            this.dgvReceipt.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.dgvReceipt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvReceipt.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvReceipt.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReceipt.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvReceipt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReceipt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_RECEIPT,
            this.NAME_CUSTOMER,
            this.QUANTITY,
            this.TOTAL_RECEIPT,
            this.CASH,
            this.CHANGE,
            this.ID_PRODUCT,
            this.UNIT_PRICE,
            this.DATE_RECEIPT,
            this.RECEIPT_STATE,
            this.RECEIPT_CREATEBY,
            this.RECEIPT_UPDATEBY,
            this.RECEIPT_CREATEDATE,
            this.RECEIPT_UPDATEDATE});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvReceipt.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvReceipt.EnableHeadersVisualStyles = false;
            this.dgvReceipt.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvReceipt.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.dgvReceipt.Location = new System.Drawing.Point(-7, 159);
            this.dgvReceipt.Name = "dgvReceipt";
            this.dgvReceipt.ReadOnly = true;
            this.dgvReceipt.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReceipt.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvReceipt.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvReceipt.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReceipt.Size = new System.Drawing.Size(694, 371);
            this.dgvReceipt.TabIndex = 57;
            this.dgvReceipt.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.dgvReceipt.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReceipt_CellClick);
            // 
            // ID_RECEIPT
            // 
            this.ID_RECEIPT.FillWeight = 60F;
            this.ID_RECEIPT.HeaderText = "Número ";
            this.ID_RECEIPT.Name = "ID_RECEIPT";
            this.ID_RECEIPT.ReadOnly = true;
            this.ID_RECEIPT.Width = 55;
            // 
            // NAME_CUSTOMER
            // 
            this.NAME_CUSTOMER.FillWeight = 65F;
            this.NAME_CUSTOMER.HeaderText = "Cliente";
            this.NAME_CUSTOMER.Name = "NAME_CUSTOMER";
            this.NAME_CUSTOMER.ReadOnly = true;
            this.NAME_CUSTOMER.Width = 70;
            // 
            // QUANTITY
            // 
            this.QUANTITY.FillWeight = 60F;
            this.QUANTITY.HeaderText = "Cantidad";
            this.QUANTITY.Name = "QUANTITY";
            this.QUANTITY.ReadOnly = true;
            this.QUANTITY.Width = 65;
            // 
            // TOTAL_RECEIPT
            // 
            this.TOTAL_RECEIPT.HeaderText = "Total";
            this.TOTAL_RECEIPT.Name = "TOTAL_RECEIPT";
            this.TOTAL_RECEIPT.ReadOnly = true;
            this.TOTAL_RECEIPT.Width = 75;
            // 
            // CASH
            // 
            this.CASH.HeaderText = "Efectivo";
            this.CASH.Name = "CASH";
            this.CASH.ReadOnly = true;
            // 
            // CHANGE
            // 
            this.CHANGE.HeaderText = "Cambio";
            this.CHANGE.Name = "CHANGE";
            this.CHANGE.ReadOnly = true;
            // 
            // ID_PRODUCT
            // 
            this.ID_PRODUCT.FillWeight = 45F;
            this.ID_PRODUCT.HeaderText = "Producto";
            this.ID_PRODUCT.Name = "ID_PRODUCT";
            this.ID_PRODUCT.ReadOnly = true;
            this.ID_PRODUCT.Width = 45;
            // 
            // UNIT_PRICE
            // 
            this.UNIT_PRICE.FillWeight = 45F;
            this.UNIT_PRICE.HeaderText = "UNIT_PRICE";
            this.UNIT_PRICE.Name = "UNIT_PRICE";
            this.UNIT_PRICE.ReadOnly = true;
            this.UNIT_PRICE.Visible = false;
            this.UNIT_PRICE.Width = 45;
            // 
            // DATE_RECEIPT
            // 
            this.DATE_RECEIPT.FillWeight = 75F;
            this.DATE_RECEIPT.HeaderText = "Fecha";
            this.DATE_RECEIPT.Name = "DATE_RECEIPT";
            this.DATE_RECEIPT.ReadOnly = true;
            this.DATE_RECEIPT.Width = 130;
            // 
            // RECEIPT_STATE
            // 
            this.RECEIPT_STATE.FillWeight = 45F;
            this.RECEIPT_STATE.HeaderText = "Estado";
            this.RECEIPT_STATE.Name = "RECEIPT_STATE";
            this.RECEIPT_STATE.ReadOnly = true;
            this.RECEIPT_STATE.Width = 43;
            // 
            // RECEIPT_CREATEBY
            // 
            this.RECEIPT_CREATEBY.HeaderText = "Creado Por";
            this.RECEIPT_CREATEBY.Name = "RECEIPT_CREATEBY";
            this.RECEIPT_CREATEBY.ReadOnly = true;
            // 
            // RECEIPT_UPDATEBY
            // 
            this.RECEIPT_UPDATEBY.HeaderText = "Modificado Por";
            this.RECEIPT_UPDATEBY.Name = "RECEIPT_UPDATEBY";
            this.RECEIPT_UPDATEBY.ReadOnly = true;
            // 
            // RECEIPT_CREATEDATE
            // 
            this.RECEIPT_CREATEDATE.FillWeight = 75F;
            this.RECEIPT_CREATEDATE.HeaderText = "Creado el";
            this.RECEIPT_CREATEDATE.Name = "RECEIPT_CREATEDATE";
            this.RECEIPT_CREATEDATE.ReadOnly = true;
            this.RECEIPT_CREATEDATE.Width = 130;
            // 
            // RECEIPT_UPDATEDATE
            // 
            this.RECEIPT_UPDATEDATE.HeaderText = "Modificado El ";
            this.RECEIPT_UPDATEDATE.Name = "RECEIPT_UPDATEDATE";
            this.RECEIPT_UPDATEDATE.ReadOnly = true;
            this.RECEIPT_UPDATEDATE.Width = 130;
            // 
            // btnCreate
            // 
            this.btnCreate.ActiveControl = null;
            this.btnCreate.Location = new System.Drawing.Point(0, 3);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(83, 60);
            this.btnCreate.TabIndex = 55;
            this.btnCreate.Text = "Agregar";
            this.btnCreate.UseSelectable = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.ActiveControl = null;
            this.btnUpdate.Location = new System.Drawing.Point(89, 3);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(83, 60);
            this.btnUpdate.TabIndex = 56;
            this.btnUpdate.Text = "Actualizar";
            this.btnUpdate.UseSelectable = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.dtEnd);
            this.metroTabPage2.Controls.Add(this.dtBegin);
            this.metroTabPage2.Controls.Add(this.btnRefresh);
            this.metroTabPage2.Controls.Add(this.btnLoadRpt);
            this.metroTabPage2.Controls.Add(this.lblEnd);
            this.metroTabPage2.Controls.Add(this.lblBegin);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(686, 526);
            this.metroTabPage2.TabIndex = 2;
            this.metroTabPage2.Text = "Reportes";
            this.metroTabPage2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // dtEnd
            // 
            this.dtEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtEnd.Location = new System.Drawing.Point(92, 102);
            this.dtEnd.Name = "dtEnd";
            this.dtEnd.Size = new System.Drawing.Size(168, 20);
            this.dtEnd.TabIndex = 21;
            // 
            // dtBegin
            // 
            this.dtBegin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtBegin.Location = new System.Drawing.Point(92, 76);
            this.dtBegin.Name = "dtBegin";
            this.dtBegin.Size = new System.Drawing.Size(168, 20);
            this.dtBegin.TabIndex = 20;
            // 
            // btnRefresh
            // 
            this.btnRefresh.ActiveControl = null;
            this.btnRefresh.Location = new System.Drawing.Point(92, 3);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(83, 60);
            this.btnRefresh.TabIndex = 15;
            this.btnRefresh.Text = "Refrescar";
            this.btnRefresh.UseSelectable = true;
            // 
            // btnLoadRpt
            // 
            this.btnLoadRpt.ActiveControl = null;
            this.btnLoadRpt.Location = new System.Drawing.Point(3, 3);
            this.btnLoadRpt.Name = "btnLoadRpt";
            this.btnLoadRpt.Size = new System.Drawing.Size(83, 60);
            this.btnLoadRpt.TabIndex = 14;
            this.btnLoadRpt.Text = "Generar";
            this.btnLoadRpt.UseSelectable = true;
            this.btnLoadRpt.Click += new System.EventHandler(this.btnLoadRpt_Click);
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Location = new System.Drawing.Point(3, 103);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(64, 19);
            this.lblEnd.TabIndex = 5;
            this.lblEnd.Text = "Fecha Fin";
            this.lblEnd.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // lblBegin
            // 
            this.lblBegin.AutoSize = true;
            this.lblBegin.Location = new System.Drawing.Point(3, 77);
            this.lblBegin.Name = "lblBegin";
            this.lblBegin.Size = new System.Drawing.Size(77, 19);
            this.lblBegin.TabIndex = 3;
            this.lblBegin.Text = "Fecha Inicio";
            this.lblBegin.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // pnlAdminReceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroTabControl1);
            this.Name = "pnlAdminReceipt";
            this.Size = new System.Drawing.Size(697, 574);
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.pnlAdminReceipt_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceipt)).EndInit();
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTile btnActivate;
        private MetroFramework.Controls.MetroTile btnDelete;
        private MetroFramework.Controls.MetroTile btnPrint;
        private MetroFramework.Controls.MetroTextBox txtRetrieveByName;
        private MetroFramework.Controls.MetroLabel lblRetrieve;
        private MetroFramework.Controls.MetroLabel lblTotal;
        private MetroFramework.Controls.MetroTextBox txtTotalReceipt;
        private MetroFramework.Controls.MetroTextBox txtQuantity;
        private MetroFramework.Controls.MetroLabel lblCantidad;
        private MetroFramework.Controls.MetroTextBox txtNameCustomer;
        private MetroFramework.Controls.MetroLabel lblNameCustomer;
        private MetroFramework.Controls.MetroGrid dgvReceipt;
        private MetroFramework.Controls.MetroTile btnCreate;
        private MetroFramework.Controls.MetroTile btnUpdate;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private System.Windows.Forms.DateTimePicker dtEnd;
        private System.Windows.Forms.DateTimePicker dtBegin;
        private MetroFramework.Controls.MetroTile btnRefresh;
        private MetroFramework.Controls.MetroTile btnLoadRpt;
        private MetroFramework.Controls.MetroLabel lblEnd;
        private MetroFramework.Controls.MetroLabel lblBegin;
        private MetroFramework.Controls.MetroTile btnCleanFields;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_RECEIPT;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAME_CUSTOMER;
        private System.Windows.Forms.DataGridViewTextBoxColumn QUANTITY;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOTAL_RECEIPT;
        private System.Windows.Forms.DataGridViewTextBoxColumn CASH;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHANGE;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_PRODUCT;
        private System.Windows.Forms.DataGridViewTextBoxColumn UNIT_PRICE;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATE_RECEIPT;
        private System.Windows.Forms.DataGridViewTextBoxColumn RECEIPT_STATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn RECEIPT_CREATEBY;
        private System.Windows.Forms.DataGridViewTextBoxColumn RECEIPT_UPDATEBY;
        private System.Windows.Forms.DataGridViewTextBoxColumn RECEIPT_CREATEDATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn RECEIPT_UPDATEDATE;
    }
}
