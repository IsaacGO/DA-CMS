namespace ControlApp.OnPremises.Forms.Security
{
    partial class frmLogin
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
            this.btnLogin = new MetroFramework.Controls.MetroButton();
            this.txtUserID = new MetroFramework.Controls.MetroTextBox();
            this.txtPass = new MetroFramework.Controls.MetroTextBox();
            this.metroLink1 = new MetroFramework.Controls.MetroLink();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(73, 204);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(181, 23);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Login";
            this.btnLogin.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnLogin.UseSelectable = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtUserID
            // 
            // 
            // 
            // 
            this.txtUserID.CustomButton.Image = null;
            this.txtUserID.CustomButton.Location = new System.Drawing.Point(159, 1);
            this.txtUserID.CustomButton.Name = "";
            this.txtUserID.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtUserID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUserID.CustomButton.TabIndex = 1;
            this.txtUserID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUserID.CustomButton.UseSelectable = true;
            this.txtUserID.CustomButton.Visible = false;
            this.txtUserID.Lines = new string[] {
        "ID"};
            this.txtUserID.Location = new System.Drawing.Point(73, 146);
            this.txtUserID.MaxLength = 32767;
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.PasswordChar = '\0';
            this.txtUserID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUserID.SelectedText = "";
            this.txtUserID.SelectionLength = 0;
            this.txtUserID.SelectionStart = 0;
            this.txtUserID.ShortcutsEnabled = true;
            this.txtUserID.Size = new System.Drawing.Size(181, 23);
            this.txtUserID.TabIndex = 1;
            this.txtUserID.Text = "ID";
            this.txtUserID.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtUserID.UseSelectable = true;
            this.txtUserID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUserID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtUserID.Click += new System.EventHandler(this.txtUserID_Click);
            // 
            // txtPass
            // 
            // 
            // 
            // 
            this.txtPass.CustomButton.Image = null;
            this.txtPass.CustomButton.Location = new System.Drawing.Point(159, 1);
            this.txtPass.CustomButton.Name = "";
            this.txtPass.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPass.CustomButton.TabIndex = 1;
            this.txtPass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPass.CustomButton.UseSelectable = true;
            this.txtPass.CustomButton.Visible = false;
            this.txtPass.Lines = new string[] {
        "Contraseña"};
            this.txtPass.Location = new System.Drawing.Point(73, 175);
            this.txtPass.MaxLength = 32767;
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPass.SelectedText = "";
            this.txtPass.SelectionLength = 0;
            this.txtPass.SelectionStart = 0;
            this.txtPass.ShortcutsEnabled = true;
            this.txtPass.Size = new System.Drawing.Size(181, 23);
            this.txtPass.TabIndex = 2;
            this.txtPass.Text = "Contraseña";
            this.txtPass.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtPass.UseSelectable = true;
            this.txtPass.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPass.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtPass.Click += new System.EventHandler(this.txtPass_Click);
            this.txtPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPass_KeyPress);
            // 
            // metroLink1
            // 
            this.metroLink1.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.metroLink1.Location = new System.Drawing.Point(87, 261);
            this.metroLink1.Name = "metroLink1";
            this.metroLink1.Size = new System.Drawing.Size(156, 23);
            this.metroLink1.TabIndex = 3;
            this.metroLink1.Text = "Reestrablecer Contraseña";
            this.metroLink1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLink1.UseSelectable = true;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 370);
            this.Controls.Add(this.metroLink1);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUserID);
            this.Controls.Add(this.btnLogin);
            this.Name = "frmLogin";
            this.Text = "ControlApp";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmLogin_KeyPress);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnLogin;
        private MetroFramework.Controls.MetroTextBox txtUserID;
        private MetroFramework.Controls.MetroTextBox txtPass;
        private MetroFramework.Controls.MetroLink metroLink1;
    }
}