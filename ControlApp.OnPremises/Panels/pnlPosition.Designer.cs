namespace ControlApp.OnPremises.Panels.Admin
{
    partial class pnlPosition
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
            this.mtPosition = new MetroFramework.Controls.MetroTabControl();
            this.tabPosition = new MetroFramework.Controls.MetroTabPage();
            this.lblId_Dpt = new MetroFramework.Controls.MetroLabel();
            this.cbId_Dpt = new MetroFramework.Controls.MetroComboBox();
            this.cbArea_Id = new MetroFramework.Controls.MetroComboBox();
            this.txtNamePosition = new MetroFramework.Controls.MetroTextBox();
            this.lblName_Pst = new MetroFramework.Controls.MetroLabel();
            this.btnDelete = new MetroFramework.Controls.MetroTile();
            this.btnRefresh = new MetroFramework.Controls.MetroTile();
            this.btnCreate = new MetroFramework.Controls.MetroTile();
            this.btnUpdate = new MetroFramework.Controls.MetroTile();
            this.txtRetrieveByName = new MetroFramework.Controls.MetroTextBox();
            this.lblRetrieve = new MetroFramework.Controls.MetroLabel();
            this.dgvPst = new MetroFramework.Controls.MetroGrid();
            this.ID_PST = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Area = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NAME_PST = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblArea_Id = new MetroFramework.Controls.MetroLabel();
            this.mtPosition.SuspendLayout();
            this.tabPosition.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPst)).BeginInit();
            this.SuspendLayout();
            // 
            // mtPosition
            // 
            this.mtPosition.Controls.Add(this.tabPosition);
            this.mtPosition.Location = new System.Drawing.Point(0, 0);
            this.mtPosition.Name = "mtPosition";
            this.mtPosition.SelectedIndex = 0;
            this.mtPosition.Size = new System.Drawing.Size(697, 571);
            this.mtPosition.TabIndex = 2;
            this.mtPosition.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mtPosition.UseSelectable = true;
            // 
            // tabPosition
            // 
            this.tabPosition.Controls.Add(this.lblId_Dpt);
            this.tabPosition.Controls.Add(this.cbId_Dpt);
            this.tabPosition.Controls.Add(this.cbArea_Id);
            this.tabPosition.Controls.Add(this.txtNamePosition);
            this.tabPosition.Controls.Add(this.lblName_Pst);
            this.tabPosition.Controls.Add(this.btnDelete);
            this.tabPosition.Controls.Add(this.btnRefresh);
            this.tabPosition.Controls.Add(this.btnCreate);
            this.tabPosition.Controls.Add(this.btnUpdate);
            this.tabPosition.Controls.Add(this.txtRetrieveByName);
            this.tabPosition.Controls.Add(this.lblRetrieve);
            this.tabPosition.Controls.Add(this.dgvPst);
            this.tabPosition.Controls.Add(this.lblArea_Id);
            this.tabPosition.HorizontalScrollbarBarColor = true;
            this.tabPosition.HorizontalScrollbarHighlightOnWheel = false;
            this.tabPosition.HorizontalScrollbarSize = 10;
            this.tabPosition.Location = new System.Drawing.Point(4, 38);
            this.tabPosition.Name = "tabPosition";
            this.tabPosition.Size = new System.Drawing.Size(689, 529);
            this.tabPosition.TabIndex = 0;
            this.tabPosition.Text = "Cargos";
            this.tabPosition.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tabPosition.VerticalScrollbarBarColor = true;
            this.tabPosition.VerticalScrollbarHighlightOnWheel = false;
            this.tabPosition.VerticalScrollbarSize = 10;
            // 
            // lblId_Dpt
            // 
            this.lblId_Dpt.AutoSize = true;
            this.lblId_Dpt.Location = new System.Drawing.Point(8, 96);
            this.lblId_Dpt.Name = "lblId_Dpt";
            this.lblId_Dpt.Size = new System.Drawing.Size(95, 19);
            this.lblId_Dpt.TabIndex = 41;
            this.lblId_Dpt.Text = "Departamento";
            this.lblId_Dpt.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // cbId_Dpt
            // 
            this.cbId_Dpt.FormattingEnabled = true;
            this.cbId_Dpt.ItemHeight = 23;
            this.cbId_Dpt.Location = new System.Drawing.Point(109, 86);
            this.cbId_Dpt.Name = "cbId_Dpt";
            this.cbId_Dpt.Size = new System.Drawing.Size(200, 29);
            this.cbId_Dpt.TabIndex = 40;
            this.cbId_Dpt.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cbId_Dpt.UseSelectable = true;
            this.cbId_Dpt.TextChanged += new System.EventHandler(this.cbId_Dpt_TextChanged);
            // 
            // cbArea_Id
            // 
            this.cbArea_Id.FormattingEnabled = true;
            this.cbArea_Id.ItemHeight = 23;
            this.cbArea_Id.Location = new System.Drawing.Point(109, 121);
            this.cbArea_Id.Name = "cbArea_Id";
            this.cbArea_Id.Size = new System.Drawing.Size(200, 29);
            this.cbArea_Id.TabIndex = 39;
            this.cbArea_Id.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cbArea_Id.UseSelectable = true;
            this.cbArea_Id.TextChanged += new System.EventHandler(this.cbArea_Id_TextChanged);
            // 
            // txtNamePosition
            // 
            // 
            // 
            // 
            this.txtNamePosition.CustomButton.Image = null;
            this.txtNamePosition.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.txtNamePosition.CustomButton.Name = "";
            this.txtNamePosition.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNamePosition.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNamePosition.CustomButton.TabIndex = 1;
            this.txtNamePosition.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNamePosition.CustomButton.UseSelectable = true;
            this.txtNamePosition.CustomButton.Visible = false;
            this.txtNamePosition.Lines = new string[0];
            this.txtNamePosition.Location = new System.Drawing.Point(109, 156);
            this.txtNamePosition.MaxLength = 32767;
            this.txtNamePosition.Name = "txtNamePosition";
            this.txtNamePosition.PasswordChar = '\0';
            this.txtNamePosition.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNamePosition.SelectedText = "";
            this.txtNamePosition.SelectionLength = 0;
            this.txtNamePosition.SelectionStart = 0;
            this.txtNamePosition.ShortcutsEnabled = true;
            this.txtNamePosition.Size = new System.Drawing.Size(200, 23);
            this.txtNamePosition.TabIndex = 37;
            this.txtNamePosition.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtNamePosition.UseSelectable = true;
            this.txtNamePosition.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNamePosition.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblName_Pst
            // 
            this.lblName_Pst.AutoSize = true;
            this.lblName_Pst.Location = new System.Drawing.Point(8, 160);
            this.lblName_Pst.Name = "lblName_Pst";
            this.lblName_Pst.Size = new System.Drawing.Size(59, 19);
            this.lblName_Pst.TabIndex = 38;
            this.lblName_Pst.Text = "Nombre";
            this.lblName_Pst.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // btnDelete
            // 
            this.btnDelete.ActiveControl = null;
            this.btnDelete.Location = new System.Drawing.Point(179, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(83, 60);
            this.btnDelete.TabIndex = 34;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.UseSelectable = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.ActiveControl = null;
            this.btnRefresh.Location = new System.Drawing.Point(268, 3);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(83, 60);
            this.btnRefresh.TabIndex = 33;
            this.btnRefresh.Text = "Refrescar";
            this.btnRefresh.UseSelectable = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.ActiveControl = null;
            this.btnCreate.Location = new System.Drawing.Point(1, 3);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(83, 60);
            this.btnCreate.TabIndex = 31;
            this.btnCreate.Text = "Agregar";
            this.btnCreate.UseSelectable = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.ActiveControl = null;
            this.btnUpdate.Location = new System.Drawing.Point(90, 3);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(83, 60);
            this.btnUpdate.TabIndex = 32;
            this.btnUpdate.Text = "Actualizar";
            this.btnUpdate.UseSelectable = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
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
            this.txtRetrieveByName.Location = new System.Drawing.Point(551, 86);
            this.txtRetrieveByName.MaxLength = 32767;
            this.txtRetrieveByName.Name = "txtRetrieveByName";
            this.txtRetrieveByName.PasswordChar = '\0';
            this.txtRetrieveByName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtRetrieveByName.SelectedText = "";
            this.txtRetrieveByName.SelectionLength = 0;
            this.txtRetrieveByName.SelectionStart = 0;
            this.txtRetrieveByName.ShortcutsEnabled = true;
            this.txtRetrieveByName.Size = new System.Drawing.Size(135, 23);
            this.txtRetrieveByName.TabIndex = 23;
            this.txtRetrieveByName.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtRetrieveByName.UseSelectable = true;
            this.txtRetrieveByName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtRetrieveByName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblRetrieve
            // 
            this.lblRetrieve.AutoSize = true;
            this.lblRetrieve.Location = new System.Drawing.Point(498, 90);
            this.lblRetrieve.Name = "lblRetrieve";
            this.lblRetrieve.Size = new System.Drawing.Size(47, 19);
            this.lblRetrieve.TabIndex = 28;
            this.lblRetrieve.Text = "Buscar";
            this.lblRetrieve.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // dgvPst
            // 
            this.dgvPst.AllowUserToAddRows = false;
            this.dgvPst.AllowUserToDeleteRows = false;
            this.dgvPst.AllowUserToResizeRows = false;
            this.dgvPst.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.dgvPst.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPst.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvPst.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPst.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPst.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPst.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_PST,
            this.Area,
            this.NAME_PST});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPst.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPst.EnableHeadersVisualStyles = false;
            this.dgvPst.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvPst.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.dgvPst.Location = new System.Drawing.Point(-4, 185);
            this.dgvPst.Name = "dgvPst";
            this.dgvPst.ReadOnly = true;
            this.dgvPst.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPst.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPst.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvPst.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPst.Size = new System.Drawing.Size(697, 345);
            this.dgvPst.TabIndex = 27;
            this.dgvPst.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.dgvPst.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPst_CellClick);
            // 
            // ID_PST
            // 
            this.ID_PST.HeaderText = "ID_PST";
            this.ID_PST.Name = "ID_PST";
            this.ID_PST.ReadOnly = true;
            this.ID_PST.Visible = false;
            // 
            // Area
            // 
            this.Area.HeaderText = "Area";
            this.Area.Name = "Area";
            this.Area.ReadOnly = true;
            // 
            // NAME_PST
            // 
            this.NAME_PST.HeaderText = "Nombre";
            this.NAME_PST.Name = "NAME_PST";
            this.NAME_PST.ReadOnly = true;
            this.NAME_PST.Width = 115;
            // 
            // lblArea_Id
            // 
            this.lblArea_Id.AutoSize = true;
            this.lblArea_Id.Location = new System.Drawing.Point(8, 131);
            this.lblArea_Id.Name = "lblArea_Id";
            this.lblArea_Id.Size = new System.Drawing.Size(37, 19);
            this.lblArea_Id.TabIndex = 26;
            this.lblArea_Id.Text = "Area";
            this.lblArea_Id.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // pnlPosition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mtPosition);
            this.Name = "pnlPosition";
            this.Size = new System.Drawing.Size(697, 571);
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mtPosition.ResumeLayout(false);
            this.tabPosition.ResumeLayout(false);
            this.tabPosition.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPst)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl mtPosition;
        private MetroFramework.Controls.MetroTabPage tabPosition;
        private MetroFramework.Controls.MetroTile btnDelete;
        private MetroFramework.Controls.MetroTile btnRefresh;
        private MetroFramework.Controls.MetroTile btnCreate;
        private MetroFramework.Controls.MetroTile btnUpdate;
        private MetroFramework.Controls.MetroTextBox txtRetrieveByName;
        private MetroFramework.Controls.MetroLabel lblRetrieve;
        private MetroFramework.Controls.MetroGrid dgvPst;
        private MetroFramework.Controls.MetroLabel lblArea_Id;
        private MetroFramework.Controls.MetroTextBox txtNamePosition;
        private MetroFramework.Controls.MetroLabel lblName_Pst;
        private MetroFramework.Controls.MetroComboBox cbArea_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_PST;
        private System.Windows.Forms.DataGridViewTextBoxColumn Area;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAME_PST;
        private MetroFramework.Controls.MetroLabel lblId_Dpt;
        private MetroFramework.Controls.MetroComboBox cbId_Dpt;
    }
}
