namespace ControlApp.OnPremises.Forms.Dashboard
{
    partial class frmDashboard
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
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.btnRole = new MetroFramework.Controls.MetroTile();
            this.btnPosition = new MetroFramework.Controls.MetroTile();
            this.btnDpto = new MetroFramework.Controls.MetroTile();
            this.mtPriceTag = new MetroFramework.Controls.MetroTile();
            this.mtAdPrecios = new MetroFramework.Controls.MetroTile();
            this.btnReceipt = new MetroFramework.Controls.MetroTile();
            this.btnUsers = new MetroFramework.Controls.MetroTile();
            this.mtAdmReceipt = new MetroFramework.Controls.MetroTile();
            this.mtArea = new MetroFramework.Controls.MetroTile();
            this.mtAdmArea = new MetroFramework.Controls.MetroTile();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.btnLogout = new MetroFramework.Controls.MetroTile();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.metroPanel1.Controls.Add(this.btnRole);
            this.metroPanel1.Controls.Add(this.btnPosition);
            this.metroPanel1.Controls.Add(this.btnDpto);
            this.metroPanel1.Controls.Add(this.mtPriceTag);
            this.metroPanel1.Controls.Add(this.mtAdPrecios);
            this.metroPanel1.Controls.Add(this.btnReceipt);
            this.metroPanel1.Controls.Add(this.btnUsers);
            this.metroPanel1.Controls.Add(this.mtAdmReceipt);
            this.metroPanel1.Controls.Add(this.mtArea);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(20, 60);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(200, 574);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // btnRole
            // 
            this.btnRole.ActiveControl = null;
            this.btnRole.Location = new System.Drawing.Point(0, 502);
            this.btnRole.Name = "btnRole";
            this.btnRole.Size = new System.Drawing.Size(200, 48);
            this.btnRole.TabIndex = 12;
            this.btnRole.Text = "Roles";
            this.btnRole.UseSelectable = true;
            this.btnRole.Click += new System.EventHandler(this.btnRole_Click);
            // 
            // btnPosition
            // 
            this.btnPosition.ActiveControl = null;
            this.btnPosition.Location = new System.Drawing.Point(0, 448);
            this.btnPosition.Name = "btnPosition";
            this.btnPosition.Size = new System.Drawing.Size(200, 48);
            this.btnPosition.TabIndex = 11;
            this.btnPosition.Text = "Cargos";
            this.btnPosition.UseSelectable = true;
            this.btnPosition.Click += new System.EventHandler(this.btnPosition_Click);
            // 
            // btnDpto
            // 
            this.btnDpto.ActiveControl = null;
            this.btnDpto.Location = new System.Drawing.Point(0, 394);
            this.btnDpto.Name = "btnDpto";
            this.btnDpto.Size = new System.Drawing.Size(200, 48);
            this.btnDpto.TabIndex = 10;
            this.btnDpto.Text = "Departamentos";
            this.btnDpto.UseSelectable = true;
            this.btnDpto.Click += new System.EventHandler(this.btnDpto_Click);
            // 
            // mtPriceTag
            // 
            this.mtPriceTag.ActiveControl = null;
            this.mtPriceTag.Location = new System.Drawing.Point(0, 286);
            this.mtPriceTag.Name = "mtPriceTag";
            this.mtPriceTag.Size = new System.Drawing.Size(200, 48);
            this.mtPriceTag.TabIndex = 8;
            this.mtPriceTag.Text = "Precios";
            this.mtPriceTag.UseSelectable = true;
            this.mtPriceTag.Click += new System.EventHandler(this.mtPriceTag_Click);
            // 
            // mtAdPrecios
            // 
            this.mtAdPrecios.ActiveControl = null;
            this.mtAdPrecios.Location = new System.Drawing.Point(0, 232);
            this.mtAdPrecios.Name = "mtAdPrecios";
            this.mtAdPrecios.Size = new System.Drawing.Size(200, 48);
            this.mtAdPrecios.TabIndex = 7;
            this.mtAdPrecios.Text = "Ad Precios";
            this.mtAdPrecios.UseSelectable = true;
            this.mtAdPrecios.Click += new System.EventHandler(this.mtAdPrecios_Click);
            // 
            // btnReceipt
            // 
            this.btnReceipt.ActiveControl = null;
            this.btnReceipt.Location = new System.Drawing.Point(0, 16);
            this.btnReceipt.Name = "btnReceipt";
            this.btnReceipt.Size = new System.Drawing.Size(200, 48);
            this.btnReceipt.TabIndex = 4;
            this.btnReceipt.Text = "Recibos";
            this.btnReceipt.UseSelectable = true;
            this.btnReceipt.Click += new System.EventHandler(this.mtReceipt_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.ActiveControl = null;
            this.btnUsers.Location = new System.Drawing.Point(0, 340);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(200, 48);
            this.btnUsers.TabIndex = 9;
            this.btnUsers.Text = "Usuarios";
            this.btnUsers.UseSelectable = true;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // mtAdmReceipt
            // 
            this.mtAdmReceipt.ActiveControl = null;
            this.mtAdmReceipt.Location = new System.Drawing.Point(0, 70);
            this.mtAdmReceipt.Name = "mtAdmReceipt";
            this.mtAdmReceipt.Size = new System.Drawing.Size(200, 48);
            this.mtAdmReceipt.TabIndex = 9;
            this.mtAdmReceipt.Text = "Ad Recibos";
            this.mtAdmReceipt.UseSelectable = true;
            this.mtAdmReceipt.Click += new System.EventHandler(this.mtAdmReceipt_Click);
            // 
            // mtArea
            // 
            this.mtArea.ActiveControl = null;
            this.mtArea.Location = new System.Drawing.Point(0, 124);
            this.mtArea.Name = "mtArea";
            this.mtArea.Size = new System.Drawing.Size(200, 48);
            this.mtArea.TabIndex = 5;
            this.mtArea.Text = "Areas";
            this.mtArea.UseSelectable = true;
            this.mtArea.Click += new System.EventHandler(this.mtArea_Click);
            // 
            // mtAdmArea
            // 
            this.mtAdmArea.ActiveControl = null;
            this.mtAdmArea.Location = new System.Drawing.Point(20, 238);
            this.mtAdmArea.Name = "mtAdmArea";
            this.mtAdmArea.Size = new System.Drawing.Size(200, 48);
            this.mtAdmArea.TabIndex = 3;
            this.mtAdmArea.Text = "Ad Areas";
            this.mtAdmArea.UseSelectable = true;
            this.mtAdmArea.Click += new System.EventHandler(this.mtAdmArea_Click);
            // 
            // metroPanel2
            // 
            this.metroPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(220, 60);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(697, 574);
            this.metroPanel2.TabIndex = 1;
            this.metroPanel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            this.metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // btnLogout
            // 
            this.btnLogout.ActiveControl = null;
            this.btnLogout.Location = new System.Drawing.Point(753, 26);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(184, 37);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Cerrar Sesión";
            this.btnLogout.UseSelectable = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 654);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.metroPanel2);
            this.Controls.Add(this.mtAdmArea);
            this.Controls.Add(this.metroPanel1);
            this.IsMdiContainer = true;
            this.Name = "frmDashboard";
            this.Text = "Dashboard";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.Load += new System.EventHandler(this.frmDashboard_Load);
            this.metroPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        public MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroTile mtAdmArea;
        private MetroFramework.Controls.MetroTile mtAdPrecios;
        private MetroFramework.Controls.MetroTile mtArea;
        private MetroFramework.Controls.MetroTile btnReceipt;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Controls.MetroTile mtPriceTag;
        private MetroFramework.Controls.MetroTile mtAdmReceipt;
        private MetroFramework.Controls.MetroTile btnUsers;
        private MetroFramework.Controls.MetroTile btnRole;
        private MetroFramework.Controls.MetroTile btnPosition;
        private MetroFramework.Controls.MetroTile btnDpto;
        private MetroFramework.Controls.MetroTile btnLogout;
    }
}