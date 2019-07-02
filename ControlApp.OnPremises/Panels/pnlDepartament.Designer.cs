namespace ControlApp.OnPremises.Panels
{
    partial class pnlDepartament
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
            this.mtDepartament = new MetroFramework.Controls.MetroTabControl();
            this.tabDepartament = new MetroFramework.Controls.MetroTabPage();
            this.btnDelete = new MetroFramework.Controls.MetroTile();
            this.btnRefresh = new MetroFramework.Controls.MetroTile();
            this.btnCreate = new MetroFramework.Controls.MetroTile();
            this.btnUpdate = new MetroFramework.Controls.MetroTile();
            this.txtRetrieveByName = new MetroFramework.Controls.MetroTextBox();
            this.lblRetrieve = new MetroFramework.Controls.MetroLabel();
            this.dgvDpt = new MetroFramework.Controls.MetroGrid();
            this.ID_DPT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NAME_ROLE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtName_Dpt = new MetroFramework.Controls.MetroTextBox();
            this.lblName_Dpt = new MetroFramework.Controls.MetroLabel();
            this.mtDepartament.SuspendLayout();
            this.tabDepartament.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDpt)).BeginInit();
            this.SuspendLayout();
            // 
            // mtDepartament
            // 
            this.mtDepartament.Controls.Add(this.tabDepartament);
            this.mtDepartament.Location = new System.Drawing.Point(0, 0);
            this.mtDepartament.Name = "mtDepartament";
            this.mtDepartament.SelectedIndex = 0;
            this.mtDepartament.Size = new System.Drawing.Size(697, 571);
            this.mtDepartament.TabIndex = 2;
            this.mtDepartament.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mtDepartament.UseSelectable = true;
            // 
            // tabDepartament
            // 
            this.tabDepartament.Controls.Add(this.btnDelete);
            this.tabDepartament.Controls.Add(this.btnRefresh);
            this.tabDepartament.Controls.Add(this.btnCreate);
            this.tabDepartament.Controls.Add(this.btnUpdate);
            this.tabDepartament.Controls.Add(this.txtRetrieveByName);
            this.tabDepartament.Controls.Add(this.lblRetrieve);
            this.tabDepartament.Controls.Add(this.dgvDpt);
            this.tabDepartament.Controls.Add(this.txtName_Dpt);
            this.tabDepartament.Controls.Add(this.lblName_Dpt);
            this.tabDepartament.HorizontalScrollbarBarColor = true;
            this.tabDepartament.HorizontalScrollbarHighlightOnWheel = false;
            this.tabDepartament.HorizontalScrollbarSize = 10;
            this.tabDepartament.Location = new System.Drawing.Point(4, 38);
            this.tabDepartament.Name = "tabDepartament";
            this.tabDepartament.Size = new System.Drawing.Size(689, 529);
            this.tabDepartament.TabIndex = 0;
            this.tabDepartament.Text = "Departamentos";
            this.tabDepartament.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tabDepartament.VerticalScrollbarBarColor = true;
            this.tabDepartament.VerticalScrollbarHighlightOnWheel = false;
            this.tabDepartament.VerticalScrollbarSize = 10;
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
            this.txtRetrieveByName.Location = new System.Drawing.Point(551, 84);
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
            this.txtRetrieveByName.TextChanged += new System.EventHandler(this.txtRetrieveByName_TextChanged);
            this.txtRetrieveByName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRetrieveByName_KeyPress);
            // 
            // lblRetrieve
            // 
            this.lblRetrieve.AutoSize = true;
            this.lblRetrieve.Location = new System.Drawing.Point(498, 88);
            this.lblRetrieve.Name = "lblRetrieve";
            this.lblRetrieve.Size = new System.Drawing.Size(47, 19);
            this.lblRetrieve.TabIndex = 28;
            this.lblRetrieve.Text = "Buscar";
            this.lblRetrieve.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // dgvDpt
            // 
            this.dgvDpt.AllowUserToAddRows = false;
            this.dgvDpt.AllowUserToDeleteRows = false;
            this.dgvDpt.AllowUserToResizeRows = false;
            this.dgvDpt.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.dgvDpt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDpt.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvDpt.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDpt.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDpt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDpt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_DPT,
            this.NAME_ROLE});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDpt.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDpt.EnableHeadersVisualStyles = false;
            this.dgvDpt.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvDpt.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.dgvDpt.Location = new System.Drawing.Point(-4, 125);
            this.dgvDpt.Name = "dgvDpt";
            this.dgvDpt.ReadOnly = true;
            this.dgvDpt.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDpt.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDpt.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvDpt.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDpt.Size = new System.Drawing.Size(697, 405);
            this.dgvDpt.TabIndex = 27;
            this.dgvDpt.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.dgvDpt.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDpt_CellClick);
            // 
            // ID_DPT
            // 
            this.ID_DPT.HeaderText = "ID_DPT";
            this.ID_DPT.Name = "ID_DPT";
            this.ID_DPT.ReadOnly = true;
            this.ID_DPT.Visible = false;
            // 
            // NAME_ROLE
            // 
            this.NAME_ROLE.HeaderText = "Nombre";
            this.NAME_ROLE.Name = "NAME_ROLE";
            this.NAME_ROLE.ReadOnly = true;
            // 
            // txtName_Dpt
            // 
            // 
            // 
            // 
            this.txtName_Dpt.CustomButton.Image = null;
            this.txtName_Dpt.CustomButton.Location = new System.Drawing.Point(132, 1);
            this.txtName_Dpt.CustomButton.Name = "";
            this.txtName_Dpt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtName_Dpt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtName_Dpt.CustomButton.TabIndex = 1;
            this.txtName_Dpt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtName_Dpt.CustomButton.UseSelectable = true;
            this.txtName_Dpt.CustomButton.Visible = false;
            this.txtName_Dpt.Lines = new string[0];
            this.txtName_Dpt.Location = new System.Drawing.Point(68, 84);
            this.txtName_Dpt.MaxLength = 32767;
            this.txtName_Dpt.Name = "txtName_Dpt";
            this.txtName_Dpt.PasswordChar = '\0';
            this.txtName_Dpt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtName_Dpt.SelectedText = "";
            this.txtName_Dpt.SelectionLength = 0;
            this.txtName_Dpt.SelectionStart = 0;
            this.txtName_Dpt.ShortcutsEnabled = true;
            this.txtName_Dpt.Size = new System.Drawing.Size(154, 23);
            this.txtName_Dpt.TabIndex = 22;
            this.txtName_Dpt.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtName_Dpt.UseSelectable = true;
            this.txtName_Dpt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtName_Dpt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtName_Dpt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtName_Dpt_KeyPress);
            // 
            // lblName_Dpt
            // 
            this.lblName_Dpt.AutoSize = true;
            this.lblName_Dpt.Location = new System.Drawing.Point(3, 88);
            this.lblName_Dpt.Name = "lblName_Dpt";
            this.lblName_Dpt.Size = new System.Drawing.Size(59, 19);
            this.lblName_Dpt.TabIndex = 26;
            this.lblName_Dpt.Text = "Nombre";
            this.lblName_Dpt.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // pnlDepartament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mtDepartament);
            this.Name = "pnlDepartament";
            this.Size = new System.Drawing.Size(697, 571);
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mtDepartament.ResumeLayout(false);
            this.tabDepartament.ResumeLayout(false);
            this.tabDepartament.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDpt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl mtDepartament;
        private MetroFramework.Controls.MetroTabPage tabDepartament;
        private MetroFramework.Controls.MetroTile btnDelete;
        private MetroFramework.Controls.MetroTile btnRefresh;
        private MetroFramework.Controls.MetroTile btnCreate;
        private MetroFramework.Controls.MetroTile btnUpdate;
        private MetroFramework.Controls.MetroTextBox txtRetrieveByName;
        private MetroFramework.Controls.MetroLabel lblRetrieve;
        private MetroFramework.Controls.MetroGrid dgvDpt;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_DPT;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAME_ROLE;
        private MetroFramework.Controls.MetroTextBox txtName_Dpt;
        private MetroFramework.Controls.MetroLabel lblName_Dpt;
    }
}
