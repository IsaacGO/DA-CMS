using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControlApp.Entities.Objects;
using ControlApp.ApiCore.Management;
using MetroFramework;
using static ControlApp.OnPremises.Program;
using System.Text.RegularExpressions;

namespace ControlApp.OnPremises.Panels
{
    public partial class pnlUser : pnlSlider
    {
        DepartamentManagement ApiAccessDpt = new DepartamentManagement();
        AreaManagement ApiAccessArea = new AreaManagement();
        PositionManagement ApiAccessPst = new PositionManagement();
        RoleManagement ApiAccessRole = new RoleManagement();
        UserManagement ApiAccess = new UserManagement();
        User ObjUser = new User();
        string pIdSession = MystaticValues.IdSession;
        public pnlUser(Form owner) : base(owner)
        {
            InitializeComponent();
            LoadDataGrid();
            LoadCbDpt(cbId_Dpt);
            LoadCbRole(cbRole_Id);
        }
        private void LoadCbDpt(ComboBox cb)
        {
            try
            {
                var ListDpt = ApiAccessDpt.RetrieveAllDepartament<Departament>();
                var ListArea = ApiAccessArea.RetrieveAllArea<Area>();
                foreach (Departament element in ListDpt)
                {
                    cb.Items.Add(element.Name_Dpt);
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, "Ha ocurrido un error:" + ex + "Favor Comunicarse con el equipo de Sistemas",
                    "Error en Acción", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadCbArea(ComboBox cb)
        {
            cb.Items.Clear();
            try
            {
                var NameDpt = cbId_Dpt.Text;
                var ListArea = ApiAccessArea.RetrieveAllArea<Area>();
                foreach (Area element in ListArea)
                {
                    if(element.Name_Dpt == NameDpt)
                    {
                        cb.Items.Add(element.Area_name);
                    }
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, "Ha ocurrido un error:" + ex + "Favor Comunicarse con el equipo de Sistemas",
                    "Error en Acción", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadCbPosition(ComboBox cb)
        {
            cb.Items.Clear();
            try
            {
                var NameArea = cbId_Area.Text;
                var ListPst = ApiAccessPst.RetrieveAllPosition<Position>();
                foreach (Position element in ListPst)
                {
                    if (element.Name_Area == NameArea)
                    {
                        cb.Items.Add(element.Name_Position);
                    }
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, "Ha ocurrido un error:" + ex + "Favor Comunicarse con el equipo de Sistemas",
                    "Error en Acción", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadCbRole(ComboBox cb)
        {
            cb.Items.Clear();
            try
            {
                var ListRole = ApiAccessRole.RetrieveAllRole<Role>();
                foreach (Role element in ListRole)
                {
                        cb.Items.Add(element.Name_role);
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, "Ha ocurrido un error:" + ex + "Favor Comunicarse con el equipo de Sistemas",
                    "Error en Acción", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadDataGrid()
        {
            try
            {
                dgvUser.Rows.Clear();
                var ListUser = ApiAccess.RetrieveAllUser<User>();
                foreach (User element in ListUser)
                {
                    string[] RowPst;
                    RowPst = new string[] { element.ID_User,element.User_name,element.User_email,element.Name_dpt,
                        element.Name_Area,element.Name_Position,element.Name_Role, element.User_nickname, element.User_pass
                       };
                    dgvUser.Rows.Add(RowPst);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        private int GetIDDpt()
        {
            int IdDpt = 0;
            try
            {
                var NameDpt = cbId_Dpt.Text;
                var ListDpt = ApiAccessDpt.RetrieveAllDepartament<Departament>();
                foreach (Departament element in ListDpt)
                {
                    if (NameDpt == element.Name_Dpt)
                    {
                        IdDpt = element.ID_Dpt;
                        break;
                    }
                }

            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, "Ha ocurrido un error:" + ex + "Favor Comunicarse con el equipo de Sistemas",
                    "Error en Acción", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return IdDpt;
        }
        private int GetIDArea()
        {
            int IDArea = 0;
            try
            {
                var NameArea = cbId_Area.Text;
                var ListArea = ApiAccessArea.RetrieveAllArea<Area>();
                foreach (Area element in ListArea)
                {
                    if (NameArea == element.Area_name)
                    {
                        IDArea = element.ID_Area;
                        break;
                    }
                }

            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, "Ha ocurrido un error:" + ex + "Favor Comunicarse con el equipo de Sistemas",
                    "Error en Acción", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return IDArea;
        }
        private int GetIDPosition()
        {
            int IDPst = 0;
            try
            {
                var NamePst = cbPst_id.Text;
                var ListPst = ApiAccessPst.RetrieveAllPosition<Position>();
                foreach (Position element in ListPst)
                {
                    if (NamePst == element.Name_Position)
                    {
                        IDPst = element.ID_Position;
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, "Ha ocurrido un error:" + ex + "Favor Comunicarse con el equipo de Sistemas",
                    "Error en Acción", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return IDPst;
        }
        private int GetIDRole()
        {
            int IDRole = 0;
            try
            {
                var NameRole = cbRole_Id.Text;
                var ListRole = ApiAccessRole.RetrieveAllRole<Role>();
                foreach (Role element in ListRole)
                {
                    if (NameRole == element.Name_role)
                    {
                        IDRole = element.ID_role;
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, "Ha ocurrido un error:" + ex + "Favor Comunicarse con el equipo de Sistemas",
                    "Error en Acción", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return IDRole;
        }
        private bool CheckFields()
        {
            bool finded = false;
            string ID_User = txtID_User.Text;
            string Name_User = txtName_User.Text;
            string Email_User = txtEmail_User.Text;
            string Nickname = txtNickname.Text;
            string Pass_User = txtpass.Text;
            if (ID_User.Trim() == string.Empty)
            {
                finded = true;
                //lblID_USER.Style = MetroFramework.MetroColorStyle.Red;
                //lblID_USER.Refresh();
            }
            if (Name_User.Trim() == string.Empty)
            {
                finded = true;
                //lblID_USER.Style = MetroFramework.MetroColorStyle.Red;
                //lblID_USER.Refresh();
            }
            if (Email_User.Trim() == string.Empty || CheckFormatEmail(Email_User) == false)
            {
                finded = true;
            }
            if (Nickname.Trim() == string.Empty)
            {
                finded = true;
            }
            if (Pass_User.Trim() == string.Empty)
            {
                finded = true;
            }
            if (cbId_Dpt.SelectedIndex == -1)
            {
                finded = true;
            }
            if (cbId_Area.SelectedIndex == -1)
            {
                finded = true;
            }
            if (cbPst_id.SelectedIndex == -1)
            {
                finded = true;
            }
            if (cbRole_Id.SelectedIndex == -1)
            {
                finded = true;
            }
            return finded;
        }
        public bool CheckFormatEmail(string pEmail)
        {
            String sFormato;
            sFormato = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(pEmail, sFormato))
            {
                if (Regex.Replace(pEmail, sFormato, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        private void CleanFields()
        {
            txtID_User.Text = "";
            txtName_User.Text="";
            txtEmail_User.Text="";
            txtNickname.Text="";
            txtpass.Text="";
            cbId_Dpt.SelectedIndex = -1;
            cbId_Area.SelectedIndex = -1;
            cbPst_id.SelectedIndex = -1;
            cbRole_Id.SelectedIndex = -1;
        }
        private bool CheckID(string pID)
        {
            try
            {
                bool finded = false;
                var ListUser = ApiAccess.RetrieveAllUser<User>();
                foreach (User element in ListUser)
                {
                    if (element.ID_User == pID)
                    {
                        finded = true;
                        if (finded == true)
                        {
                            break;
                        }
                    }
                }
                return finded;
            }
            catch (Exception)
            {
                throw;
            }
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            string ID_User = txtID_User.Text;
            string Name_User = txtName_User.Text;
            string Email_User = txtEmail_User.Text;
            string Nickname = txtNickname.Text;
            string Pass_User = txtpass.Text;
            if (CheckID(ID_User) == true)
            {
                MetroMessageBox.Show(this, "Cédula invalida", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (CheckFields() == true)
            {
                MetroMessageBox.Show(this, "Favor Complete todos los Campos", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    ObjUser.ID_User = ID_User;
                    ObjUser.User_name = Name_User;
                    ObjUser.User_email = Email_User;
                    ObjUser.User_nickname = Nickname;
                    ObjUser.User_pass = Pass_User;
                    ObjUser.ID_Dpt = GetIDDpt();
                    ObjUser.ID_area = GetIDArea();
                    ObjUser.ID_position = GetIDPosition();
                    ObjUser.ID_Role = GetIDRole();
                    ObjUser.CreateBy = pIdSession;
                    ApiAccess.CreateUser(ObjUser);
                }
                catch (Exception)
                {

                    throw;
                }
                CleanFields();
                LoadDataGrid();
            }
        }
        private void cbId_Dpt_TextChanged(object sender, EventArgs e)
        {
            cbId_Area.Items.Clear();
            cbPst_id.Items.Clear();
            LoadCbArea(cbId_Area);
        }
        private void cbId_Area_TextChanged(object sender, EventArgs e)
        {
            LoadCbPosition(cbPst_id);
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            CleanFields();
            LoadDataGrid();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string Name_User = txtName_User.Text;
            string Email_User = txtEmail_User.Text;
            string Nickname = txtNickname.Text;
            string Pass_User = txtpass.Text;

            if (CheckFields() == true)
            {
                MetroMessageBox.Show(this, "Favor Complete todos los Campos", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    int Row = dgvUser.CurrentRow.Index;
                    ObjUser.ID_User = dgvUser[0, Row].Value.ToString();
                    ObjUser.User_name = Name_User;
                    ObjUser.User_email = Email_User;
                    ObjUser.User_nickname = Nickname;
                    ObjUser.User_pass = Pass_User;
                    ObjUser.ID_Dpt = GetIDDpt();
                    ObjUser.ID_area = GetIDArea();
                    ObjUser.ID_position = GetIDPosition();
                    ObjUser.ID_Role = GetIDRole();
                    ObjUser.UpdateBy = pIdSession;
                    ApiAccess.UpdateUser(ObjUser);
                }
                catch (Exception)
                {
                    throw;
                }
                CleanFields();
                LoadDataGrid();
            }
        }
        private void dgvUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int Row = dgvUser.CurrentRow.Index;
                txtID_User.Text = dgvUser[0, Row].Value.ToString();
                txtName_User.Text = dgvUser[1, Row].Value.ToString();
                txtEmail_User.Text = dgvUser[2, Row].Value.ToString();
                cbId_Dpt.Text = dgvUser[3, Row].Value.ToString();
                cbId_Area.Text = dgvUser[4, Row].Value.ToString();
                cbPst_id.Text = dgvUser[5, Row].Value.ToString();
                cbRole_Id.Text = dgvUser[6, Row].Value.ToString();
                txtNickname.Text = dgvUser[7, Row].Value.ToString();
                txtpass.Text = dgvUser[8, Row].Value.ToString();
                btnUpdate.Enabled = true;
            }
            catch (Exception)
            {
                throw;
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            int Row = dgvUser.CurrentRow.Index;
            string UserName = dgvUser[1, Row].Value.ToString();
            if (dgvUser[1, Row].Value == null)
            {
                MetroMessageBox.Show(this, "Debe Seleccionar Al menos Algún Valor para Eliminar. \n Favor Intentelo Nuevamente", "Error en Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dgvUser.Focus();
                return;
            }
            else
            {
                if (MetroFramework.MetroMessageBox.Show(this, "¿Desea Eliminar el Usuario de: " + UserName + "?", "Confirmación de Acción", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    try
                    {
                        ObjUser.ID_User = dgvUser[0, Row].Value.ToString();
                        ObjUser.UpdateBy = pIdSession;
                        ApiAccess.DeleteUser(ObjUser);
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                    CleanFields();
                    LoadDataGrid();
                }
            }
        }
    }
}
