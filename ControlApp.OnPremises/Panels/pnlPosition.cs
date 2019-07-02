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

namespace ControlApp.OnPremises.Panels.Admin
{
    public partial class pnlPosition : pnlSlider
    {
        string pIdSession = MystaticValues.IdSession;
        PositionManagement ApiAccess = new PositionManagement();
        AreaManagement ApiAccessArea = new AreaManagement();
        DepartamentManagement ApiAccessDpt = new DepartamentManagement();
        /// PositionManagement ApiAccessPst = new PositionManagement();
        Position ObjPst = new Position();
        public pnlPosition(Form owner) : base(owner)
        {
            InitializeComponent();
            LoadDataGrid();
            LoadCbDpt(cbId_Dpt);
        }
        private void LoadDataGrid()
        {
            try
            {
                dgvPst.Rows.Clear();
                var ListPst = ApiAccess.RetrieveAllPosition<Position>();
                foreach (Position element in ListPst)
                {
                    string[] RowPst;
                    RowPst = new string[] { element.ID_Position.ToString(),element.Name_Area
                        , element.Name_Position};
                    dgvPst.Rows.Add(RowPst);
                }
            }
            catch (Exception)
            {
                throw;
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
                    if (element.Name_Dpt == NameDpt)
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
        private int GetIDArea()
        {
            int IDArea = 0;
            try
            {
                var NameArea = cbArea_Id.Text;
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
        private bool Checkname(string pPositionName, string pNameArea)
        {
            try
            {
                bool finded = false;
                ObjPst.Name_Position = pPositionName;
                ObjPst.Name_Area = pNameArea;
                var ListPst = ApiAccess.RetrieveAllByNamePosition<Position>(ObjPst);
                foreach (Position element in ListPst)
                {
                    if (element.Name_Position == pPositionName && element.Name_Area == pNameArea)
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
        private bool CheckFields()
        {
            bool finded = false;
            string PositionName = txtNamePosition.Text;
            string NameArea = cbArea_Id.Text;
            if (Checkname(PositionName, NameArea) == true || PositionName.Trim() == string.Empty)
            {
                MetroMessageBox.Show(this, "El Nombre -" + PositionName + "- no es Valido. \n Favor Digite un Nombre Valido",
                    "Error en Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                finded = true;
                txtNamePosition.Focus();
            }
            if (cbArea_Id.SelectedIndex == -1)
            {
                MetroMessageBox.Show(this, "Favor Digite un Nombre Valido",
                    "Error en Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                finded = true;
                cbArea_Id.Focus();
            }
            return finded;
        }
        private void CleanFields()
        {
            txtNamePosition.Text = "";
            cbArea_Id.SelectedIndex = -1;
            cbId_Dpt.SelectedIndex = -1;
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            string PositionName = txtNamePosition.Text;
            string NameArea = cbArea_Id.Text;
            if (CheckFields() == true || PositionName.Trim() == string.Empty)
            {
                MetroMessageBox.Show(this, "El Nombre -" + PositionName + "- no es Valido. \n Favor Digite un Nombre Valido", "Error en Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNamePosition.Focus();
            }

            else
            {
                try
                {
                    ObjPst.ID_Area = GetIDArea();
                    ObjPst.Name_Position = PositionName;
                    ObjPst.CreateBy = pIdSession;
                    ApiAccess.CreatePosition(ObjPst);
                }
                catch (Exception)
                {

                    throw;
                }
                CleanFields();
                LoadDataGrid();
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string PositionName = txtNamePosition.Text;
            string NameArea = cbArea_Id.Text;
            if (CheckFields() == true || PositionName.Trim() == string.Empty)
            {
                MetroMessageBox.Show(this, "El Nombre -" + PositionName + "- no es Valido. \n Favor Digite un Nombre Valido", "Error en Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNamePosition.Focus();
            }
            else
            {
                try
                {
                    int Row = dgvPst.CurrentRow.Index;
                    ObjPst.ID_Position = Convert.ToInt32(dgvPst[0, Row].Value);
                    ObjPst.ID_Area = GetIDArea();
                    ObjPst.Name_Position = PositionName;
                    ObjPst.UpdateBy = pIdSession;
                    ApiAccess.CreatePosition(ObjPst);
                }
                catch (Exception)
                {

                    throw;
                }
                CleanFields();
                LoadDataGrid();
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            int Row = dgvPst.CurrentRow.Index;
            string PositionName = dgvPst[1, Row].Value.ToString();
            if (dgvPst[1, Row].Value == null)
            {
                MetroMessageBox.Show(this, "Debe Seleccionar Al menos Algún Valor para Inactivar. \n Favor Intentelo Nuevamente", "Error en Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dgvPst.Focus();
                return;
            }
            else
            {
                if (MetroFramework.MetroMessageBox.Show(this, "¿Desea Eliminar el Cargo de: " + PositionName + "?", "Confirmación de Acción", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    try
                    {
                        ObjPst.ID_Position = Convert.ToInt32(dgvPst[0, Row].Value);
                        ObjPst.UpdateBy = pIdSession;
                        ApiAccess.DeletePosition(ObjPst);
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
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            CleanFields();
            LoadDataGrid();
            
        }
        private void dgvPst_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int Row = dgvPst.CurrentRow.Index;
                cbArea_Id.Text = dgvPst[1, Row].Value.ToString();
                txtNamePosition.Text = dgvPst[2, Row].Value.ToString();
                btnUpdate.Enabled = true;
            }
            catch (Exception)
            {
                throw;
            }
        }
        private void cbId_Dpt_TextChanged(object sender, EventArgs e)
        {
            LoadCbArea(cbArea_Id);
        }
        private void cbArea_Id_TextChanged(object sender, EventArgs e)
        {
            txtNamePosition.Text = "";
        }



        
    }
}
