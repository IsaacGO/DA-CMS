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
    public partial class pnlDepartament : pnlSlider
    {
        DepartamentManagement ApiAccess = new DepartamentManagement();
        Departament ObjDpt = new Departament();
        string IdSession = MystaticValues.IdSession;
        public pnlDepartament(Form owner) : base(owner)
        {
            InitializeComponent();
            LoadDataGrid();
        }
        public void CleanFields()
        {
            txtName_Dpt.Text = "";
            txtRetrieveByName.Text = "";
        }
        private void LoadDataGrid()
        {
            try
            {
                dgvDpt.Rows.Clear();
                var ListDpt = ApiAccess.RetrieveAllDepartament<Departament>();
                foreach (Departament element in ListDpt)
                {
                    string[] RowDpt;
                    RowDpt = new string[] { element.ID_Dpt.ToString(), element.Name_Dpt };
                    dgvDpt.Rows.Add(RowDpt);
                }
            }
            catch (Exception ex)
            {

                MetroMessageBox.Show(this, "Ha ocurrido un error:" + ex + "Favor Comunicarse con el equipo de Sistemas",
                      "Error en Acción", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            string NameDpt = txtName_Dpt.Text;
            if (Checkname(NameDpt) == true || NameDpt.Trim() == string.Empty)
            {
                MetroMessageBox.Show(this, "El Nombre -" + NameDpt + "- no es Valido. \n Favor Digite un Nombre Valido", "Error en Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblName_Dpt.Style = MetroFramework.MetroColorStyle.Red;
                lblName_Dpt.Refresh();
                txtName_Dpt.Focus();
            }
            else
            {
                try
                {
                    ObjDpt.Name_Dpt = NameDpt;
                    ObjDpt.CreateBy = IdSession;
                    ApiAccess.CreateDepartament(ObjDpt);
                }
                catch (Exception ex)
                {
                    MetroMessageBox.Show(this, "Ha ocurrido un error:" + ex + "Favor Comunicarse con el equipo de Sistemas",
                      "Error en Acción", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                CleanFields();
                LoadDataGrid();
            }
        }
        private bool Checkname(string pDptName)
        {
            bool finded = false;
            try
            {   
                ObjDpt.Name_Dpt = pDptName;
                var ListDpt = ApiAccess.RetrieveAllByNameDepartament<Departament>(ObjDpt);
                foreach (Departament element in ListDpt)
                {
                    if (element.Name_Dpt == pDptName)
                    {
                        finded = true;
                        if (finded == true)
                        {
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
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int Row = dgvDpt.CurrentRow.Index;
            int ID_Dpt = Convert.ToInt32(dgvDpt[0, Row].Value);
            string NameDpt = txtName_Dpt.Text;
            if (NameDpt.Trim() == string.Empty)
            {
                MetroMessageBox.Show(this, "El Nombre -" + NameDpt + "- no es Valido. \n Favor Digite un Nombre Valido", "Error en Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtName_Dpt.Focus();
            }
            else
            {
                try
                {
                    ObjDpt.ID_Dpt = ID_Dpt;
                    ObjDpt.Name_Dpt = NameDpt;
                    ObjDpt.UpdateBy = IdSession;
                    ApiAccess.UpdateDepartament(ObjDpt);
                }
                catch (Exception ex)
                {
                    MetroMessageBox.Show(this, "Ha ocurrido un error:" + ex + "Favor Comunicarse con el equipo de Sistemas",
                      "Error en Acción", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                CleanFields();
                LoadDataGrid();
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            int Row = dgvDpt.CurrentRow.Index;
            string NameDpt = dgvDpt[1, Row].Value.ToString();
            if (dgvDpt[1, Row].Value == null)
            {
                MetroMessageBox.Show(this, "Debe Seleccionar Al menos Algún Valor para Eliminar. \n Favor Intentelo Nuevamente", "Error en Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dgvDpt.Focus();
                return;
            }
            else
            {
                if (MetroFramework.MetroMessageBox.Show(this, "¿Desea Eliminar el Area de: " + NameDpt + "?", "Confirmación de Acción", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    try
                    {
                        ObjDpt.ID_Dpt = Convert.ToInt32(dgvDpt[0, Row].Value);
                        ObjDpt.UpdateBy = IdSession;
                        ApiAccess.DeleteDepartament(ObjDpt);
                    }
                    catch (Exception ex)
                    {
                        MetroMessageBox.Show(this, "Ha ocurrido un error:" + ex + "Favor Comunicarse con el equipo de Sistemas",
                      "Error en Acción", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private void dgvDpt_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int Row = dgvDpt.CurrentRow.Index;
                txtName_Dpt.Text = dgvDpt[1, Row].Value.ToString();
                btnUpdate.Enabled = true;
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, "Ha ocurrido un error:" + ex + "Favor Comunicarse con el equipo de Sistemas",
                       "Error en Acción", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    dgvDpt.Rows.Clear();
                    ObjDpt.Name_Dpt = txtRetrieveByName.Text;
                    var ListDpt = ApiAccess.RetrieveAllByNameDepartament<Departament>(ObjDpt);
                    foreach (Departament element in ListDpt)
                    {
                        string[] RowDpt;
                        RowDpt = new string[] { element.ID_Dpt.ToString(), element.Name_Dpt};
                        dgvDpt.Rows.Add(RowDpt);
                    }
                }
                catch (Exception ex)
                {

                    MetroMessageBox.Show(this, "Ha ocurrido un error:" + ex + "Favor Comunicarse con el equipo de Sistemas",
                      "Error en Acción", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void txtRetrieveByName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }
        private void txtName_Dpt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }
    }
}
