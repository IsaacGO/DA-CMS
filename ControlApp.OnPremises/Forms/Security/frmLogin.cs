using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControlApp.Entities.Objects;
using ControlApp.ApiCore.Management;
using MetroFramework;
using static ControlApp.OnPremises.Program;
using ControlApp.OnPremises.Forms.Dashboard;

namespace ControlApp.OnPremises.Forms.Security
{
    public partial class frmLogin : MetroFramework.Forms.MetroForm
    {
        UserManagement ApiAccess = new UserManagement();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string ID = txtUserID.Text;
            if (GetLogin() == true)
            {
                MystaticValues.IdSession = ID;
                Program.SetMainForm(new frmDashboard());
                Program.ShowMainForm();
                this.Close();
            }
            else
            {
                MetroMessageBox.Show(this, "El Id o la Contraseña son Erroneos",
                    "Error en Login", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }
        private bool GetLogin()
        {
            string ID = txtUserID.Text;
            string Pass = txtPass.Text;
            bool finded = false;

            try
            {


                var ListUser = ApiAccess.RetrieveAllUser<User>();
                foreach (User element in ListUser)
                {
                    if (element.State == false)
                    {
                        finded = false;
                    }
                    else
                    {
                        if (ID == element.ID_User && Pass == element.User_pass)
                        {
                            finded = true;
                            break;
                        }
                    }
                    
                }

            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, "Ha ocurrido un error:" + ex + "Favor Comunicarse con el equipo de Sistemas",
                    "Error en Acción", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return finded;
        }
        private void txtUserID_Click(object sender, EventArgs e)
        {
            txtUserID.Text = "";
            txtUserID.Focus();
        }
        private void txtPass_Click(object sender, EventArgs e)
        {
            txtPass.Text = "";
            txtPass.Focus();
        }
        private void frmLogin_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnLogin.PerformClick();
            }
        }
    }
}
