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

namespace ControlApp.OnPremises.Panels
{
    public partial class pnlRole : pnlSlider
    {
        RoleManagement ApiAccess = new RoleManagement();
        DepartamentManagement ApiAccessDpt = new DepartamentManagement();
        PermissionManagament ApiAccessPer = new PermissionManagament();
        Role ObjRole = new Role();
        Permission ObjPer = new Permission();
        string pIdSession = MystaticValues.IdSession;
        public pnlRole(Form owner) : base(owner)
        {
            InitializeComponent();
            LoadDataGrid();
            LoadCbDpt(cbDpt_Id);
            LoadDataGridPer();
            LoadDataGridAsgRole();
            LoadDataGridPerAsg();
        }
        private void LoadDataGrid()
        {
            try
            {
                dgvRole.Rows.Clear();
                var ListRole = ApiAccess.RetrieveAllRole<Role>();
                foreach (Role element in ListRole)
                {
                    string[] RowRole;
                    RowRole = new string[] { element.ID_role.ToString(),element.Name_role
                        , element.Descrip_role};
                    dgvRole.Rows.Add(RowRole);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        private void LoadDataGridAsgRole()
        {
            try
            {
                dgvRoleAsg.Rows.Clear();
                var ListRole = ApiAccess.RetrieveAllRole<Role>();
                foreach (Role element in ListRole)
                {
                    string[] RowRole;
                    RowRole = new string[] { element.ID_role.ToString(),element.Name_role
                        , element.Descrip_role};
                    dgvRoleAsg.Rows.Add(RowRole);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        private void LoadDataGridPer()
        {
            try
            {
                dgvPer.Rows.Clear();
                var ListPer = ApiAccessPer.RetrieveAllPermission<Permission>();
                foreach (Permission element in ListPer)
                {
                    string[] RowPer;
                    RowPer = new string[] { element.ID_Per.ToString(),element.Name_Dpt, element.Name_Per,
                        element.Descrip_Per};
                    dgvPer.Rows.Add(RowPer);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        private void LoadDataGridPerAsg()
        {
            try
            {
                dgvPerAsg.Rows.Clear();
                var ListPer = ApiAccessPer.RetrieveAllPermission<Permission>();
                foreach (Permission element in ListPer)
                {
                    string[] RowPer;
                    RowPer = new string[] { element.ID_Per.ToString(),element.Name_Dpt, element.Name_Per,
                        element.Descrip_Per};
                    dgvPerAsg.Rows.Add(RowPer);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        private void CleanFields()
        {
            txtRolename.Text = "";
            txtRetrieveByName.Text = "";
            txtDescripRole.Text = "";
            cbDpt_Id.SelectedIndex = -1;
            txtName_Per.Text = "";
            txtDescrip_Dpt.Text = "";
            txtRetrievePer.Text = "";
        }
        private bool CheckFields()
        {
            bool finded = false;
            string RoleName = txtRolename.Text;
            string DescripRole = txtDescripRole.Text;
            if (Checkname(RoleName) == true || RoleName.Trim() == string.Empty)
            {
                finded = true;
            }
            if (DescripRole.Trim() == string.Empty)
            {

                finded = true;
            }
            return finded;
        }
        private bool CheckFieldsPer()
        {
            bool finded = false;
            string PerName = txtName_Per.Text;
            string DescripPer = txtDescrip_Dpt.Text;
            if (ChecknamePer(PerName) == true || DescripPer.Trim() == string.Empty)
            {
                finded = true;
            }
            if (cbDpt_Id.SelectedIndex == -1)
            {
                finded = true;
            }
            return finded;
        }
        private bool Checkname(string pRoleName)
        {
            try
            {
                bool finded = false;
                ObjRole.Name_role = pRoleName;

                var ListRole = ApiAccess.RetrieveAllByNameRole<Role>(ObjRole);
                foreach (Role element in ListRole)
                {
                    if (element.Name_role == pRoleName)
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
        private bool ChecknamePer(string pPerName)
        {
            try
            {
                bool finded = false;
                ObjPer.Name_Per = pPerName;
                var ListPer = ApiAccessPer.RetrieveAllByNamePermission<Permission>(ObjPer);
                foreach (Permission element in ListPer)
                {
                    if (element.Name_Per == pPerName && element.Name_Dpt == cbDpt_Id.Text)
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
            string RoleName = txtRolename.Text;
            string DescripRole = txtDescripRole.Text;

            if (CheckFields() == true)
            {
                MetroMessageBox.Show(this, "Debe completar todos los campos", "Error en Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                try
                {
                    ObjRole.Name_role = RoleName;
                    ObjRole.Descrip_role = DescripRole;
                    ObjRole.CreateBy = pIdSession;
                    ApiAccess.CreateRole(ObjRole);
                }
                catch (Exception)
                {
                    throw;
                }
                CleanFields();
                LoadDataGrid();
                LoadDataGridAsgRole();
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string RoleName = txtRolename.Text;
            string DescripRole = txtDescripRole.Text;

            if (CheckFields() == true)
            {
                MetroMessageBox.Show(this, "Debe completar todos los campos", "Error en Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                try
                {
                    int Row = dgvRole.CurrentRow.Index;
                    ObjRole.ID_role = Convert.ToInt32(dgvRole[0, Row].Value);
                    ObjRole.Name_role = RoleName;
                    ObjRole.Descrip_role = DescripRole;
                    ObjRole.UpdateBy = pIdSession;
                    ApiAccess.UpdateRole(ObjRole);
                }
                catch (Exception)
                {
                    throw;
                }
                CleanFields();
                LoadDataGrid();
                LoadDataGridAsgRole();
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            int Row = dgvRole.CurrentRow.Index;
            string RoleName = dgvRole[1, Row].Value.ToString();
            if (dgvRole[1, Row].Value == null)
            {
                MetroMessageBox.Show(this, "Debe Seleccionar Al menos Algún Valor para Eliminar. \n Favor Intentelo Nuevamente", "Error en Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dgvRole.Focus();
                return;
            }
            else
            {
                if (MetroFramework.MetroMessageBox.Show(this, "¿Desea Eliminar el Rol de: " + RoleName + "?", "Confirmación de Acción", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    try
                    {
                        ObjRole.ID_role = Convert.ToInt32(dgvRole[0, Row].Value);
                        ObjRole.UpdateBy = pIdSession;
                        ApiAccess.DeleteRole(ObjRole);
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                    CleanFields();
                    LoadDataGrid();
                    LoadDataGridAsgRole();
                }
            }
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            CleanFields();
            LoadDataGrid();
            LoadDataGridAsgRole();
        }
        private void dgvRole_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int Row = dgvRole.CurrentRow.Index;
                txtRolename.Text = dgvRole[1, Row].Value.ToString();
                txtDescripRole.Text = dgvRole[2, Row].Value.ToString();
                btnUpdate.Enabled = true;
            }
            catch (Exception)
            {
                throw;
            }
        }
        private void txtRetrieveByName_TextChanged(object sender, EventArgs e)
        {
            if (txtRetrieveByName.Text == "")
            {
                LoadDataGrid();
                CleanFields();
            }
            else
            {
                try
                {
                    dgvRole.Rows.Clear();
                    ObjRole.Name_role = txtRetrieveByName.Text;
                    var ListRole = ApiAccess.RetrieveAllByNameRole<Role>(ObjRole);
                    foreach (Role element in ListRole)
                    {
                        string[] RowRole;
                        RowRole = new string[] {element.ID_role.ToString(),element.Name_role
                        , element.Descrip_role };
                        dgvRole.Rows.Add(RowRole);
                    }
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }
        private void LoadCbDpt(ComboBox cb)
        {
            try
            {
                var ListDpt = ApiAccessDpt.RetrieveAllDepartament<Departament>();
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
        private void btnCreatePer_Click(object sender, EventArgs e)
        {
            string PerName = txtName_Per.Text;
            string DescripPer = txtDescrip_Dpt.Text;

            if (CheckFieldsPer() == true)
            {
                MetroMessageBox.Show(this, "Debe completar todos los campos", "Error en Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                try
                {
                    ObjPer.ID_Dpt = GetIDDpt();
                    ObjPer.Name_Per = PerName;
                    ObjPer.Descrip_Per = DescripPer;
                    ObjPer.CreateBy = pIdSession;
                    ApiAccessPer.CreatedPermission(ObjPer);
                }
                catch (Exception)
                {
                    throw;
                }
                CleanFields();
                LoadDataGridPer();
                LoadDataGridPerAsg();
            }
        }
        private int GetIDDpt()
        {
            int IdDpt = 0;
            try
            {
                var NameDpt = cbDpt_Id.Text;
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
        private void btnRefreshPer_Click(object sender, EventArgs e)
        {
            LoadDataGridPer();
            LoadDataGridPerAsg();
            CleanFields();
        }
        private void metroTile2_Click(object sender, EventArgs e)
        {
            LoadDataGridAsgRole();
            LoadDataGridPerAsg();
        }
        private void btnUpdatePer_Click(object sender, EventArgs e)
        {
            string PerName = txtName_Per.Text;
            string DescripPer = txtDescrip_Dpt.Text;

            if (CheckFieldsPer() == true)
            {
                MetroMessageBox.Show(this, "Debe completar todos los campos", "Error en Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                try
                {
                    int Row = dgvRole.CurrentRow.Index;
                    ObjPer.ID_Per = Convert.ToInt32(dgvPer[0, Row].Value);
                    ObjPer.ID_Dpt = GetIDDpt();
                    ObjPer.Name_Per = PerName;
                    ObjPer.Descrip_Per = DescripPer;
                    ObjPer.UpdateBy = pIdSession;
                    ApiAccessPer.UpdatePermission(ObjPer);
                }
                catch (Exception)
                {
                    throw;
                }
                CleanFields();
                LoadDataGridPer();
                LoadDataGridPerAsg();
            }
        }
        private void btnDeletePer_Click(object sender, EventArgs e)
        {
            int Row = dgvPer.CurrentRow.Index;
            string PerName = dgvPer[1, Row].Value.ToString();
            if (dgvRole[1, Row].Value == null)
            {
                MetroMessageBox.Show(this, "Debe Seleccionar Al menos Algún Valor para Eliminar. \n Favor Intentelo Nuevamente", "Error en Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dgvPer.Focus();
                return;
            }
            else
            {
                if (MetroFramework.MetroMessageBox.Show(this, "¿Desea Eliminar el Permiso de: " + PerName + "?", "Confirmación de Acción", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    try
                    {
                        ObjPer.ID_Per = Convert.ToInt32(dgvPer[0, Row].Value);
                        ObjRole.UpdateBy = pIdSession;
                        ApiAccessPer.DeletePermission(ObjPer);
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                    CleanFields();
                    LoadDataGrid();
                    LoadDataGridAsgRole();
                }
            }
        }
        private void dgvPer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int Row = dgvPer.CurrentRow.Index;
                cbDpt_Id.Text = dgvPer[1, Row].Value.ToString();
                txtName_Per.Text = dgvPer[2, Row].Value.ToString();
                txtDescrip_Dpt.Text = dgvPer[3, Row].Value.ToString();
                btnUpdate.Enabled = true;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}