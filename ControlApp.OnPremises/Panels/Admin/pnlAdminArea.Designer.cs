namespace ControlApp.OnPremises.Panels.Admin
{
    partial class pnlAdminArea
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.btnRefresh = new MetroFramework.Controls.MetroTile();
            this.btnCreate = new MetroFramework.Controls.MetroTile();
            this.btnActivate = new MetroFramework.Controls.MetroTile();
            this.btnDelete = new MetroFramework.Controls.MetroTile();
            this.txtRetrieveByName = new MetroFramework.Controls.MetroTextBox();
            this.lblRetrieve = new MetroFramework.Controls.MetroLabel();
            this.dgvArea = new MetroFramework.Controls.MetroGrid();
            this.btnUpdate = new MetroFramework.Controls.MetroTile();
            this.txtAreaname = new MetroFramework.Controls.MetroTextBox();
            this.mtlblArea = new MetroFramework.Controls.MetroLabel();
            this.cbDpt_Id = new MetroFramework.Controls.MetroComboBox();
            this.lblDpt_Id = new MetroFramework.Controls.MetroLabel();
            this.ID_AREA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_DPT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AREA_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AREA_STATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AREA_CREATYBY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AREA_UPDATEBY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AREA_CREATEDATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AREA_UPDATEDATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArea)).BeginInit();
            this.SuspendLayout();
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = null;
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Location = new System.Drawing.Point(3, 0);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(694, 574);
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.cbDpt_Id);
            this.metroTabPage1.Controls.Add(this.lblDpt_Id);
            this.metroTabPage1.Controls.Add(this.btnRefresh);
            this.metroTabPage1.Controls.Add(this.btnCreate);
            this.metroTabPage1.Controls.Add(this.btnActivate);
            this.metroTabPage1.Controls.Add(this.btnDelete);
            this.metroTabPage1.Controls.Add(this.txtRetrieveByName);
            this.metroTabPage1.Controls.Add(this.lblRetrieve);
            this.metroTabPage1.Controls.Add(this.dgvArea);
            this.metroTabPage1.Controls.Add(this.btnUpdate);
            this.metroTabPage1.Controls.Add(this.txtAreaname);
            this.metroTabPage1.Controls.Add(this.mtlblArea);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(686, 532);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Areas";
            this.metroTabPage1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // btnRefresh
            // 
            this.btnRefresh.ActiveControl = null;
            this.btnRefresh.Location = new System.Drawing.Point(356, 3);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(83, 60);
            this.btnRefresh.TabIndex = 41;
            this.btnRefresh.Text = "Refrescar";
            this.btnRefresh.UseSelectable = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.ActiveControl = null;
            this.btnCreate.Location = new System.Drawing.Point(0, 3);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(83, 60);
            this.btnCreate.TabIndex = 40;
            this.btnCreate.Text = "Agregar";
            this.btnCreate.UseSelectable = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnActivate
            // 
            this.btnActivate.ActiveControl = null;
            this.btnActivate.Location = new System.Drawing.Point(267, 3);
            this.btnActivate.Name = "btnActivate";
            this.btnActivate.Size = new System.Drawing.Size(83, 60);
            this.btnActivate.TabIndex = 39;
            this.btnActivate.Text = "Activar";
            this.btnActivate.UseSelectable = true;
            this.btnActivate.Click += new System.EventHandler(this.btnActivate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.ActiveControl = null;
            this.btnDelete.Location = new System.Drawing.Point(178, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(83, 60);
            this.btnDelete.TabIndex = 38;
            this.btnDelete.Text = "Inactivar";
            this.btnDelete.UseSelectable = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
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
            this.txtRetrieveByName.Location = new System.Drawing.Point(548, 73);
            this.txtRetrieveByName.MaxLength = 32767;
            this.txtRetrieveByName.Name = "txtRetrieveByName";
            this.txtRetrieveByName.PasswordChar = '\0';
            this.txtRetrieveByName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtRetrieveByName.SelectedText = "";
            this.txtRetrieveByName.SelectionLength = 0;
            this.txtRetrieveByName.SelectionStart = 0;
            this.txtRetrieveByName.ShortcutsEnabled = true;
            this.txtRetrieveByName.Size = new System.Drawing.Size(135, 23);
            this.txtRetrieveByName.TabIndex = 33;
            this.txtRetrieveByName.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtRetrieveByName.UseSelectable = true;
            this.txtRetrieveByName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtRetrieveByName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtRetrieveByName.TextChanged += new System.EventHandler(this.txtRetrieveByName_TextChanged);
            // 
            // lblRetrieve
            // 
            this.lblRetrieve.AutoSize = true;
            this.lblRetrieve.Location = new System.Drawing.Point(495, 77);
            this.lblRetrieve.Name = "lblRetrieve";
            this.lblRetrieve.Size = new System.Drawing.Size(47, 19);
            this.lblRetrieve.TabIndex = 37;
            this.lblRetrieve.Text = "Buscar";
            this.lblRetrieve.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // dgvArea
            // 
            this.dgvArea.AllowUserToAddRows = false;
            this.dgvArea.AllowUserToDeleteRows = false;
            this.dgvArea.AllowUserToResizeRows = false;
            this.dgvArea.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.dgvArea.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvArea.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvArea.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvArea.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvArea.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArea.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_AREA,
            this.ID_DPT,
            this.AREA_NAME,
            this.AREA_STATE,
            this.AREA_CREATYBY,
            this.AREA_UPDATEBY,
            this.AREA_CREATEDATE,
            this.AREA_UPDATEDATE});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvArea.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvArea.EnableHeadersVisualStyles = false;
            this.dgvArea.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvArea.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.dgvArea.Location = new System.Drawing.Point(-4, 133);
            this.dgvArea.Name = "dgvArea";
            this.dgvArea.ReadOnly = true;
            this.dgvArea.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvArea.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvArea.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvArea.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArea.Size = new System.Drawing.Size(690, 403);
            this.dgvArea.TabIndex = 36;
            this.dgvArea.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.dgvArea.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvArea_CellClick);
            // 
            // btnUpdate
            // 
            this.btnUpdate.ActiveControl = null;
            this.btnUpdate.Location = new System.Drawing.Point(89, 3);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(83, 60);
            this.btnUpdate.TabIndex = 34;
            this.btnUpdate.Text = "Actualizar";
            this.btnUpdate.UseSelectable = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtAreaname
            // 
            // 
            // 
            // 
            this.txtAreaname.CustomButton.Image = null;
            this.txtAreaname.CustomButton.Location = new System.Drawing.Point(150, 1);
            this.txtAreaname.CustomButton.Name = "";
            this.txtAreaname.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtAreaname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAreaname.CustomButton.TabIndex = 1;
            this.txtAreaname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAreaname.CustomButton.UseSelectable = true;
            this.txtAreaname.CustomButton.Visible = false;
            this.txtAreaname.Lines = new string[0];
            this.txtAreaname.Location = new System.Drawing.Point(104, 104);
            this.txtAreaname.MaxLength = 32767;
            this.txtAreaname.Name = "txtAreaname";
            this.txtAreaname.PasswordChar = '\0';
            this.txtAreaname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAreaname.SelectedText = "";
            this.txtAreaname.SelectionLength = 0;
            this.txtAreaname.SelectionStart = 0;
            this.txtAreaname.ShortcutsEnabled = true;
            this.txtAreaname.Size = new System.Drawing.Size(172, 23);
            this.txtAreaname.TabIndex = 32;
            this.txtAreaname.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtAreaname.UseSelectable = true;
            this.txtAreaname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAreaname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mtlblArea
            // 
            this.mtlblArea.AutoSize = true;
            this.mtlblArea.Location = new System.Drawing.Point(39, 108);
            this.mtlblArea.Name = "mtlblArea";
            this.mtlblArea.Size = new System.Drawing.Size(59, 19);
            this.mtlblArea.TabIndex = 35;
            this.mtlblArea.Text = "Nombre";
            this.mtlblArea.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // cbDpt_Id
            // 
            this.cbDpt_Id.FormattingEnabled = true;
            this.cbDpt_Id.ItemHeight = 23;
            this.cbDpt_Id.Location = new System.Drawing.Point(104, 69);
            this.cbDpt_Id.Name = "cbDpt_Id";
            this.cbDpt_Id.Size = new System.Drawing.Size(172, 29);
            this.cbDpt_Id.TabIndex = 43;
            this.cbDpt_Id.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cbDpt_Id.UseSelectable = true;
            // 
            // lblDpt_Id
            // 
            this.lblDpt_Id.AutoSize = true;
            this.lblDpt_Id.Location = new System.Drawing.Point(3, 77);
            this.lblDpt_Id.Name = "lblDpt_Id";
            this.lblDpt_Id.Size = new System.Drawing.Size(95, 19);
            this.lblDpt_Id.TabIndex = 42;
            this.lblDpt_Id.Text = "Departamento";
            this.lblDpt_Id.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // ID_AREA
            // 
            this.ID_AREA.FillWeight = 70F;
            this.ID_AREA.HeaderText = "ID";
            this.ID_AREA.Name = "ID_AREA";
            this.ID_AREA.ReadOnly = true;
            this.ID_AREA.Width = 50;
            // 
            // ID_DPT
            // 
            this.ID_DPT.HeaderText = "Departamento";
            this.ID_DPT.Name = "ID_DPT";
            this.ID_DPT.ReadOnly = true;
            // 
            // AREA_NAME
            // 
            this.AREA_NAME.HeaderText = "Nombre";
            this.AREA_NAME.Name = "AREA_NAME";
            this.AREA_NAME.ReadOnly = true;
            // 
            // AREA_STATE
            // 
            this.AREA_STATE.FillWeight = 60F;
            this.AREA_STATE.HeaderText = "Estado";
            this.AREA_STATE.Name = "AREA_STATE";
            this.AREA_STATE.ReadOnly = true;
            this.AREA_STATE.Width = 60;
            // 
            // AREA_CREATYBY
            // 
            this.AREA_CREATYBY.HeaderText = "Creado por";
            this.AREA_CREATYBY.Name = "AREA_CREATYBY";
            this.AREA_CREATYBY.ReadOnly = true;
            // 
            // AREA_UPDATEBY
            // 
            this.AREA_UPDATEBY.HeaderText = "Modificado por";
            this.AREA_UPDATEBY.Name = "AREA_UPDATEBY";
            this.AREA_UPDATEBY.ReadOnly = true;
            // 
            // AREA_CREATEDATE
            // 
            this.AREA_CREATEDATE.HeaderText = "Fecha de Creación";
            this.AREA_CREATEDATE.Name = "AREA_CREATEDATE";
            this.AREA_CREATEDATE.ReadOnly = true;
            // 
            // AREA_UPDATEDATE
            // 
            this.AREA_UPDATEDATE.HeaderText = "Fecha Modificación";
            this.AREA_UPDATEDATE.Name = "AREA_UPDATEDATE";
            this.AREA_UPDATEDATE.ReadOnly = true;
            // 
            // pnlAdminArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroTabControl1);
            this.Name = "pnlAdminArea";
            this.Size = new System.Drawing.Size(697, 574);
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.pnlAdminArea_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArea)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTile btnCreate;
        private MetroFramework.Controls.MetroTile btnActivate;
        private MetroFramework.Controls.MetroTile btnDelete;
        private MetroFramework.Controls.MetroTextBox txtRetrieveByName;
        private MetroFramework.Controls.MetroLabel lblRetrieve;
        private MetroFramework.Controls.MetroGrid dgvArea;
        private MetroFramework.Controls.MetroTile btnUpdate;
        private MetroFramework.Controls.MetroTextBox txtAreaname;
        private MetroFramework.Controls.MetroLabel mtlblArea;
        private MetroFramework.Controls.MetroTile btnRefresh;
        private MetroFramework.Controls.MetroComboBox cbDpt_Id;
        private MetroFramework.Controls.MetroLabel lblDpt_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_AREA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_DPT;
        private System.Windows.Forms.DataGridViewTextBoxColumn AREA_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn AREA_STATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn AREA_CREATYBY;
        private System.Windows.Forms.DataGridViewTextBoxColumn AREA_UPDATEBY;
        private System.Windows.Forms.DataGridViewTextBoxColumn AREA_CREATEDATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn AREA_UPDATEDATE;
    }
}
