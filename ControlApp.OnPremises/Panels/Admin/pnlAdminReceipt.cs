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
using System.Globalization;
using System.Text.RegularExpressions;
using Microsoft.Reporting.WinForms;
using System.Drawing.Printing;
using System.Drawing.Imaging;
using System.IO;
using ControlApp.OnPremises.Panels.Admin;

using ControlApp.OnPremises.Forms.Dashboard;
using ControlApp.OnPremises.Forms.Report;

namespace ControlApp.OnPremises.Panels.Admin
{
    public partial class pnlAdminReceipt : pnlSlider , IDisposable
    {
        ReceiptManagement ApiAccess = new ReceiptManagement(); //ApiAcces Of Class
        ProductManagement ApiAccess_PriceTag = new ProductManagement(); //ApiAccess Aux
        //Object instance
        Receipt ObjReceipt = new Receipt();
        Product ObjPrice_Tag = new Product();
        string pIdSession = MystaticValues.IdSession;
        //Global Variables
        int gIdPrice_Tag = 0;
        decimal gUnit_Price = 0;
        public pnlAdminReceipt(Form owner) : base(owner)
        {
            InitializeComponent();
            this.StyleManager.Update();
            txtTotalReceipt.Enabled = false;
            dtBegin.CustomFormat = "yyyy/MM/dd HH:mm:ss";
            dtEnd.CustomFormat = "yyyy/MM/dd HH:mm:ss";
        }
        public void CleanFields()
        {
            txtNameCustomer.Text = "";
            txtQuantity.Text = "";
            txtRetrieveByName.Text = "";
            btnUpdate.Enabled = false;
            btnPrint.Enabled = false;
            btnActivate.Enabled = false;
            btnDelete.Enabled = false;
        }
        public void LoadDataGrid()
        {
            try
            {
                dgvReceipt.Rows.Clear();
                var ListReceipt = ApiAccess.SuperRetrieveReceipt<Receipt>();
                foreach (Receipt element in ListReceipt)
                {
                    string[] RowPrice;
                    RowPrice = new string[] { element.ID_Receipt.ToString(), element.Customer_name,
                         element.Quantity.ToString(), element.Total_Receipt.ToString(), element.Cash.ToString(), element.Change.ToString(),
                        element.ID_Price_tag.ToString(),element.Unit_Price.ToString(), element.Date_receipt.ToString(),
                        element.State.ToString(), element.CreateBy,
                        element.UpdateBy, element.CreateDate.ToString(),element.UpdateDate.ToString()};
                    dgvReceipt.Rows.Add(RowPrice);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void LoadPriceTag()
        {
            try
            {
                var ListPricetag = ApiAccess_PriceTag.RetrieveAllProduct<Product>();
                foreach (Product element in ListPricetag)
                {
                    gIdPrice_Tag = element.ID_Product;
                    gUnit_Price = element.Total_Product;
                }
            }
            catch (Exception)
            {
                throw;
            }

        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            string NameCustomer = txtNameCustomer.Text;
            string Quantity = txtQuantity.Text;
            if (string.IsNullOrEmpty(NameCustomer.Trim()))
            {
                MetroMessageBox.Show(this, "El Cliente -" + NameCustomer + "- no es Valido. \n Favor Digite un Nombre Valido", "Error en Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNameCustomer.Focus();
                return;
            }
            if (string.IsNullOrEmpty(Quantity.Trim()) || Convert.ToInt32(Quantity) == 0)
            {
                MetroMessageBox.Show(this, "La Cantidad -" + Quantity + "- no es Valida. \n Favor Digite un valor Valido", "Error en Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtQuantity.Focus();
                return;
            }
            try
            {

                ObjReceipt.Customer_name = NameCustomer;
                ObjReceipt.Quantity = Convert.ToInt32(Quantity);
                ObjReceipt.Unit_Price = gUnit_Price;
                ObjReceipt.ID_Price_tag = gIdPrice_Tag;
                ObjReceipt.IdSession = pIdSession;
                ApiAccess.CreateReceipt(ObjReceipt);
            }
            catch (Exception)
            {

                throw;
            }
            Print();
            LoadDataGrid();
            CleanFields();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int Row = dgvReceipt.CurrentRow.Index;
            int IdReceipt = Convert.ToInt32(dgvReceipt[0, Row].Value);
            string NameCustomer = txtNameCustomer.Text;
            string Quantity = txtQuantity.Text;
            if (string.IsNullOrEmpty(NameCustomer.Trim()))
            {
                MetroMessageBox.Show(this, "El Cliente -" + NameCustomer + "- no es Valido. \n Favor Digite un Nombre Valido", "Error en Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNameCustomer.Focus();
                return;
            }
            if (string.IsNullOrEmpty(Quantity.Trim()) || Convert.ToInt32(Quantity) == 0)
            {
                MetroMessageBox.Show(this, "La Cantidad -" + Quantity + "- no es Valida. \n Favor Digite un valor Valido", "Error en Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtQuantity.Focus();
                return;
            }
            try
            {
                ObjReceipt.ID_Receipt = IdReceipt;
                ObjReceipt.Customer_name = NameCustomer;
                ObjReceipt.Quantity = Convert.ToInt32(Quantity);
                ObjReceipt.Unit_Price = gUnit_Price;
                ObjReceipt.ID_Price_tag = gIdPrice_Tag;
                ObjReceipt.UpdateBy = pIdSession;
                ApiAccess.UpdateReceipt(ObjReceipt);
            }
            catch (Exception)
            {
                throw;
            }
            LoadDataGrid();
            CleanFields();
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            /// THIS FUNTION PRINT ALTERNATIVE FLOW OF THE RECEIPT ////
            PrintAF();
        }
        private void Print() // Principal Flow
        {
            /// THIS FUNTION PRINT PRINCIPAL FLOW OF THE RECEIPT ////
            GetIdSsrs();
            frmReport rpt = new frmReport();
            rpt.Show();
        }
        private void GetIdSsrs() // Principal Flow
        {
            int Row = dgvReceipt.CurrentRow.Index;
            MystaticValues.rptSsrs = GetlastIdReceipt();
        }
        private void PrintAF() // Alternate Flow
        {
            GetIdSsrsAF();
            frmReport rpt = new frmReport();
            rpt.Show();
        }
        private void GetIdSsrsAF() // Alternate Flow
        {
            int Row = dgvReceipt.CurrentRow.Index;
            MystaticValues.rptSsrs = Convert.ToInt32(dgvReceipt[0, Row].Value);

        }
        private void GetDatesReport()
        {
            MystaticValues.rptSsrsDateBegin = dtBegin.Text;
            MystaticValues.rptSsrsDateEnd = dtEnd.Text;
            frmReportDaily rpt = new frmReportDaily();
            rpt.Show();

        }
        public int GetlastIdReceipt()
        {
            try
            {


                int pIdReceipt = 0;
                var ListReceipt = ApiAccess.RetrieveAllByIdUser<Receipt>(ObjReceipt);
                foreach (Receipt element in ListReceipt)
                {

                    pIdReceipt = element.ID_Receipt;
                    break;
                }
                return pIdReceipt;
            }
            catch (Exception)
            {
                throw;
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            int Row = dgvReceipt.CurrentRow.Index;
            int IdReceipt = Convert.ToInt32(dgvReceipt[0, Row].Value);
            if (dgvReceipt[0, Row].Value == null)
            {
                MetroMessageBox.Show(this, "Debe Seleccionar Al menos Algún Valor para Inactivar. \n Favor Intentelo Nuevamente", "Error en Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dgvReceipt.Focus();
                return;
            }
            else
            {
                if (MetroFramework.MetroMessageBox.Show(this, "¿Desea Eliminar el Recibo N-° : " + IdReceipt.ToString() + "?", "Confirmación de Acción", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    try
                    {
                        ObjReceipt.ID_Receipt = IdReceipt;
                        ObjReceipt.IdSession = pIdSession;
                        ApiAccess.DeleteReceipt(ObjReceipt);
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
        private void btnActivate_Click(object sender, EventArgs e)
        {
            int Row = dgvReceipt.CurrentRow.Index;
            int IdReceipt = Convert.ToInt32(dgvReceipt[0, Row].Value);
            if (dgvReceipt[0, Row].Value == null)
            {
                MetroMessageBox.Show(this, "Debe Seleccionar Al menos Algún Valor para Activar. \n Favor Intentelo Nuevamente", "Error en Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dgvReceipt.Focus();
                return;
            }
            else
            {
                if (MetroFramework.MetroMessageBox.Show(this, "¿Desea Activar el Recibo N-° : " + IdReceipt.ToString() + "?", "Confirmación de Acción", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    try
                    {
                        ObjReceipt.ID_Receipt = IdReceipt;
                        ObjReceipt.IdSession = pIdSession;
                        ApiAccess.ActivateReceipt(ObjReceipt);
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
        private void pnlAdminReceipt_Load(object sender, EventArgs e)
        {
            LoadDataGrid();
            LoadPriceTag();
            btnUpdate.Enabled = false;
            btnPrint.Enabled = false;
            btnActivate.Enabled = false;
            btnDelete.Enabled = false;
        }
        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            if (txtQuantity.Text == "")
            {
                txtTotalReceipt.Text = "";
            }
            else
            {
                int Quantity = Convert.ToInt32(txtQuantity.Text);
                txtTotalReceipt.Text = Math.Round((Quantity * gUnit_Price), 2).ToString();
            }
        }
        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void dgvReceipt_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnUpdate.Enabled = true;
            btnPrint.Enabled = true;
            btnActivate.Enabled = true;
            btnDelete.Enabled = true;
            int Row = dgvReceipt.CurrentRow.Index;
            txtNameCustomer.Text = dgvReceipt[1, Row].Value.ToString();
            txtQuantity.Text = dgvReceipt[2, Row].Value.ToString();
        }
        private void btnLoadRpt_Click(object sender, EventArgs e)
        {
            ShowReportByUser();
        }
        public void ShowReportByUser()
        {
            GetDatesReport();

        }
        private void btnCleanFields_Click(object sender, EventArgs e)
        {
            CleanFields();
            LoadDataGrid();
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
                    dgvReceipt.Rows.Clear();

                    int ejem = 0;// Variable para el Trypare
                    if (int.TryParse(txtRetrieveByName.Text, out ejem))
                    {
                        ObjReceipt.ID_Receipt = Convert.ToInt32(txtRetrieveByName.Text);
                    }
                    else
                    {
                        ObjReceipt.Customer_name = txtRetrieveByName.Text;
                    }


                    var ListReceipt = ApiAccess.SuperRetrieveByIdReceipt<Receipt>(ObjReceipt);
                    foreach (Receipt element in ListReceipt)
                    {
                        string[] RowPrice;
                        RowPrice = new string[] { element.ID_Receipt.ToString(), element.Customer_name,
                         element.Quantity.ToString(), element.Total_Receipt.ToString(), element.ID_Price_tag.ToString(),
                         element.Unit_Price.ToString(), element.Date_receipt.ToString(),element.State.ToString(), element.CreateBy,
                        element.UpdateBy, element.CreateDate.ToString(),element.UpdateDate.ToString()};
                        dgvReceipt.Rows.Add(RowPrice);
                    }
                }
                catch (Exception ex)
                {

                    MetroMessageBox.Show(this, "La Petición -" + txtRetrieveByName.Text +
                        "- no es Valida. ", "Error en Busqueda" + ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
        private void txtRetrieveByName_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            //{
            //    e.Handled = true;
            //}
        }
    }
}
