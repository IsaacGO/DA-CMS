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
using ControlApp.Util;
using ControlApp.OnPremises.Forms.Report;
using MetroFramework.Controls;

namespace ControlApp.OnPremises.Panels
{
    public partial class pnlReceipt : pnlSlider

    {
        // Variables for ApiCore
        ReceiptManagement ApiAccess = new ReceiptManagement();
        ProductManagement ApiAccess_Product = new ProductManagement();
        StockManagement ApiAccess_Stock = new StockManagement();
        AccountreceivableManagement Apiccess_CXC = new AccountreceivableManagement();
        PrepaidManagement ApiAccess_Prepaid = new PrepaidManagement();
        CustomerManagement ApiAccess_Customer =  new CustomerManagement();
        OrderManagement ApiAccess_Order = new OrderManagement();

        //Entities
        Receipt ObjReceipt = new Receipt();
        Product ObjPrice_Tag = new Product();
        Stock ObjStock = new Stock();
        Accountreceivable ObjCXC = new Accountreceivable();
        Prepaid ObjPrepaid = new Prepaid();
        Customer ObjCustomer = new Customer();
        Order ObjOrder = new Order();

        //ID Session for Security
        string pIdSession = MystaticValues.IdSession;

        //Variables for get the Price and ID of Product
        int gIdPrice_Tag = 0;
        decimal gUnit_Price = 0;

        // Logger Logic Variable
        log4net.ILog log;


        ///Constructor
        public pnlReceipt(Form owner) : base(owner)
        {
            InitializeComponent();
            this.StyleManager.Update();
            txtTotalReceipt.Enabled = false;
            dtBegin.CustomFormat = "yyyy/MM/dd HH:mm:ss";
            dtEnd.CustomFormat = "yyyy/MM/dd HH:mm:ss";
            btnStock.Style = MetroFramework.MetroColorStyle.Green;
            log4net.Config.XmlConfigurator.Configure();
            log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        }
        /// Event Load
        private void pnlReceipt_Load(object sender, EventArgs e)
        {
            LoadDataGrid();
            LoadPriceTag();
            LoadDataGridCustomer();
            LoadDataGridPrepaid();
            LoadtxtCustomerPrepaid(txtNCustomerPrepaid);
            btnPrint.Enabled = false;
            btnDelete.Enabled = false;
        }
        /// <CrudReceipt>
        /// Create
        private void btnCreate_Click(object sender, EventArgs e)
        {
            string NameCustomer = txtNameCustomer.Text;
            string Quantity = txtQuantity.Text;
            string Cash = txtCash.Text;
            string Change = txtCambio.Text;
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
            if (string.IsNullOrEmpty(Cash.Trim()) || Convert.ToInt32(Cash) == 0)
            {
                MetroMessageBox.Show(this, "Debe de Ingresar el monto de Efectivo a Recibir. \n Favor Digite un valor Valido", "Error en Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtQuantity.Focus();
                return;
            }
            try
            {
                ObjReceipt.Customer_name = NameCustomer;
                ObjReceipt.Quantity = Convert.ToInt32(Quantity);
                ObjReceipt.Unit_Price = gUnit_Price;
                ObjReceipt.Cash = Convert.ToDecimal(Cash);
                ObjReceipt.Change = Convert.ToDecimal(Change);
                ObjReceipt.ID_Price_tag = gIdPrice_Tag;
                ObjReceipt.CreateBy = pIdSession;
                ApiAccess.CreateReceipt(ObjReceipt);

            }
            catch (Exception ex)
            {
                log.Error(ex.Message, ex);
            }
            LoadDataGrid();
            CleanFields();
            Print();
        }
        /// Retrieve  
        public void LoadDataGrid()
        {
            try
            {
                dgvReceipt.Rows.Clear();
                ObjReceipt.IdSession = pIdSession;
                var ListReceipt = ApiAccess.RetrieveAllByIdUser<Receipt>(ObjReceipt);
                foreach (Receipt element in ListReceipt)
                {
                    string[] RowPrice;
                    RowPrice = new string[] { element.ID_Receipt.ToString(), element.Customer_name,
                         element.Quantity.ToString(), element.Total_Receipt.ToString(), element.Descrip_Price,
                         element.Unit_Price.ToString(), element.Cash.ToString(), element.Change.ToString(),
                        element.Date_receipt.ToString() };
                    dgvReceipt.Rows.Add(RowPrice);
                }
            }
            catch (Exception)
            {
                throw;
            }

        }
        /// RetrieveByName  
        private void txtRetrieveByName_TextChanged(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
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

                    var ListReceipt = ApiAccess.RetrieveAllByIdReceipt<Receipt>(ObjReceipt);


                    foreach (Receipt element in ListReceipt)
                    {
                        string[] RowPrice;
                        RowPrice = new string[] { element.ID_Receipt.ToString(), element.Customer_name,
                         element.Quantity.ToString(), element.Total_Receipt.ToString(), element.Descrip_Price,
                         element.Unit_Price.ToString(), element.Cash.ToString(), element.Change.ToString(),
                        element.Date_receipt.ToString() };
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
        /// Delete 
        private void btnDelete_Click(object sender, EventArgs e)
        {
            int Row = dgvReceipt.CurrentRow.Index;
            int IdReceipt = Convert.ToInt32(dgvReceipt[0, Row].Value);
            if (dgvReceipt[0, Row].Value == null)
            {
                MetroMessageBox.Show(this, "Debe Seleccionar Al menos Algún Valor para Inactivar. \n Favor Intentelo Nuevamente", 
                    "Error en Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dgvReceipt.Focus();
                return;
            }
            else
            {
                if (MetroFramework.MetroMessageBox.Show(this, "¿Desea Anular el Recibo N-° : " + IdReceipt.ToString() + "?", 
                    "Confirmación de Acción", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    try
                    {
                        ObjReceipt.ID_Receipt = IdReceipt;
                        ObjReceipt.IdSession = pIdSession;
                        ApiAccess.DeleteReceipt(ObjReceipt);
                    }
                    catch (Exception ex)
                    {
                        MetroMessageBox.Show(this, "Error Al momento de Agregar",
                            "Error en Crud" + ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    CleanFields();
                    LoadDataGrid();
                }
            }
        }
        /// </CrudReceipt>

        /// <CrudCustomer>
        /// Create
        private void btnCreateCustomer_Click(object sender, EventArgs e)
        {
            string IDCustomer = txtIDCustomer.Text;
            string NameCustomer = txtNCustomer.Text;
            if (string.IsNullOrEmpty(IDCustomer.Trim()))
            {
                MetroMessageBox.Show(this, "La cédula -" + IDCustomer + "- no es Valida. \n Favor Digite un valor Valido", "Error en Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtIDCustomer.Focus();
                return;
            }
            if (string.IsNullOrEmpty(NameCustomer.Trim()))
            {
                MetroMessageBox.Show(this, "El nombre -" + NameCustomer + "- no es Valido. \n Favor Digite un valor Valido", "Error en Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNCustomer.Focus();
                return;
            }
        
                try
                {
                    ObjCustomer.Customer_name = NameCustomer;
                    ObjCustomer.ID_Customer = IDCustomer;
                    ObjCustomer.CreateBy = pIdSession;
                    ApiAccess_Customer.Create(ObjCustomer);

                }
                catch (Exception ex)
                {
                    MetroMessageBox.Show(this, "Error Al momento de Agregar",
                        "Error en Crud" + ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                btnRefreshCustomer.PerformClick();
        }
        /// Update
        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            string IDCustomer = txtIDCustomer.Text;
            string NameCustomer = txtNCustomer.Text;
            // DGV ROWS
            int Row = dgvCustomer.CurrentRow.Index;
            string update = dgvCustomer[1, Row].Value.ToString();
            if (string.IsNullOrEmpty(IDCustomer.Trim()))
            {
                MetroMessageBox.Show(this, "La cédula -" + IDCustomer + "- no es Valida. \n Favor Digite un valor Valido", "Error en Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtIDCustomer.Focus();
                return;
            }
            if (string.IsNullOrEmpty(NameCustomer.Trim()))
            {
                MetroMessageBox.Show(this, "El nombre -" + NameCustomer + "- no es Valido. \n Favor Digite un valor Valido", "Error en Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNCustomer.Focus();
                return;
            } 
            if (MetroFramework.MetroMessageBox.Show(this, "¿Desea Actualizar el Cliente: " + update + " a " + txtNCustomer.Text + "?",
                   "Confirmación de Acción", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    ObjCustomer.Customer_name = NameCustomer;
                    ObjCustomer.ID_Customer = IDCustomer;
                    ObjCustomer.UpdateBy = pIdSession;
                    ApiAccess_Customer.Update(ObjCustomer);

                }
                catch (Exception ex)
                {
                    MetroMessageBox.Show(this, "Error Al momento de Agregar",
                        "Error en Crud" + ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                btnRefreshCustomer.PerformClick();
            }
        }
        /// Retrieve 
        public void LoadDataGridCustomer()
        {

            try
            {
                dgvCustomer.Rows.Clear();
                var ListCustomer = ApiAccess_Customer.RetrieveAll<Customer>();
                foreach (Customer element in ListCustomer)
                {
                    string[] RowCustomer;
                    RowCustomer = new string[] { element.ID_Customer.ToString(), element.Customer_name };
                    dgvCustomer.Rows.Add(RowCustomer);
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, "Error Al momento de Cargar el Grid",
                    "Error en Busqueda" + ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void txtSearchCustomer_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchCustomer.Text == "")
            {
                LoadDataGridCustomer();
                CleanFieldsCustomer();
            }
            else
            {
                try
                {
                    dgvCustomer.Rows.Clear();


                        ObjCustomer.ID_Customer = txtSearchCustomer.Text;
                        ObjCustomer.Customer_name = txtSearchCustomer.Text;

                    var ListCustomer = ApiAccess_Customer.RetrieveAllById<Customer>(ObjCustomer);


                    foreach (Customer element in ListCustomer)
                    {
                        string[] RowCustomer;
                        RowCustomer = new string[] { element.ID_Customer.ToString(), element.Customer_name };
                        dgvCustomer.Rows.Add(RowCustomer);
                    }
                }
                catch (Exception ex)
                {

                    MetroMessageBox.Show(this, "La Petición -" + txtSearchCustomer.Text +
                        "- no es Valida. ", "Error en Busqueda" + ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
        private string SearchIdCustomer(string pNameCustomer)
        {
            string IdCustomer = "N/A";
            ObjCustomer.Customer_name = pNameCustomer;
            List<Customer> MyList = new List<Customer>();
            try
            {
                MyList = ApiAccess_Customer.RetrieveAllById<Customer>(ObjCustomer);
                foreach (Customer element in MyList)
                {
                    if (element.Customer_name == pNameCustomer)
                    {
                        IdCustomer = element.ID_Customer ;
                    }
                }
                
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, "Error Al momento de Buscar ID Cliente",
                    "Error en Crud" + ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return IdCustomer;
        }
        private void btnRefreshCustomer_Click(object sender, EventArgs e)
        {
            LoadDataGridCustomer();
            CleanFieldsCustomer();
            btnUpdateCustomer.Enabled = false;
        }
        /// </CrudCustomer> 

        /// <CrudPrepaid>
        /// Create - Update
        private void btnCreatePrepaid_Click(object sender, EventArgs e)
        {
            string ID_Customer = SearchIdCustomer(txtNCustomerPrepaid.Text);
            if (btnCreatePrepaid.Text == "Finalizar")
            {
                if (Convert.ToDecimal(txtTotalPrepaid.Text) > Convert.ToDecimal(txtCashPrepaid.Text))
                {
                    MetroMessageBox.Show(this, "El efectivo -" + txtCashPrepaid.Text +
                   "- no es suficiente. \n Se requiere un monto igual o mayor al total", "Error en Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCashPrepaid.Focus();
                }
                else
                {
                    try
                    {

                        int Row = dgvPrepaid.CurrentRow.Index;
                        ObjPrepaid.Id_Prepaid = Convert.ToInt32(dgvPrepaid[0, Row].Value);
                        ObjPrepaid.Id_Customer = SearchIdCustomer(txtNCustomerPrepaid.Text);
                        ObjPrepaid.Id_Product = gIdPrice_Tag;
                        ObjPrepaid.UpdateBy = pIdSession;
                        ObjPrepaid.Prepaid_Quantity = Convert.ToInt32(txtQuantityPrepaid.Text);
                        ObjPrepaid.Prepaid_Total = Convert.ToDecimal(txtTotalPrepaid.Text);
                        ObjPrepaid.Prepaid_Cash = Convert.ToDecimal(txtCashPrepaid.Text);
                        ObjPrepaid.Prepaid_Change = Convert.ToDecimal(txtChangePrepaid.Text);
                        ObjPrepaid.Prepaid_Balance = Convert.ToInt32(txtQuantityPrepaid.Text);
                        ApiAccess_Prepaid.Update(ObjPrepaid);

                        btnCreatePrepaid.Style = MetroFramework.MetroColorStyle.Green;
                        btnCreatePrepaid.Text = "Crear";
                        mpOrder.Visible = false;
                        dgvPrepaid.Enabled = true;
                        CleanFieldsPrepaid();
                        LoadDataGridPrepaid();
                        mtoggleOrder.Checked = false;
                        CleanFieldsOrder();
                    }
                    catch (Exception ex)
                    {
                        MetroMessageBox.Show(this, "Error Al momento de Actualizar",
                            "Error en Crud" + ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            else
            {
                string NameCustomer = txtNCustomerPrepaid.Text;
                if (string.IsNullOrEmpty(NameCustomer.Trim()))
                {
                    MetroMessageBox.Show(this, "El Cliente -" + txtNCustomerPrepaid.Text +
                        "- no es Valido. \n Favor Digite un valor Valido", "Error en Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtIDCustomer.Focus();
                    return;
                }
                if (ID_Customer == "N/A")
                {
                    MetroMessageBox.Show(this, "El Cliente -" + txtNCustomerPrepaid.Text +
                        "- no es Valido. \n Favor Digite un valor Valido", "Error en Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtIDCustomer.Focus();
                    return;
                }
                else
                {
                    try
                    {
                        CleanFieldsOrder();
                        mpOrder.Visible = true;
                        mpOrder.Enabled = true;
                        btnUpdateOrden.Enabled = false;
                        btnDeleteOrder.Enabled = false;
                        mtoggleOrder.Checked = true;
                        //
                        ObjPrepaid.Id_Customer = ID_Customer;
                        ObjPrepaid.CreateBy = pIdSession;
                        ObjPrepaid.Id_Product = gIdPrice_Tag;
                        ApiAccess_Prepaid.Create(ObjPrepaid);
                        btnCreatePrepaid.Text = "Finalizar";
                        btnCreatePrepaid.Style = MetroFramework.MetroColorStyle.Red;
                    }
                    catch (Exception ex)
                    {
                        MetroMessageBox.Show(this, "Error Al momento de Agregar",
                            "Error en Crud" + ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                LoadDataGridPrepaid();
            }
        }
        /// Retrieve
        public void LoadtxtCustomerPrepaid(MetroTextBox txt)
        {
            List<Customer> MyList = new List<Customer>();
            MyList = ApiAccess_Customer.RetrieveAll<Customer>();
            foreach (Customer element in MyList)
            {
                txt.AutoCompleteCustomSource.Add(element.Customer_name);
            }
        }
        public void LoadDataGridPrepaid()
        {

            try
            {
                dgvPrepaid.Rows.Clear();
                var ListPrepaid = ApiAccess_Prepaid.RetrieveAll<Prepaid>();
                foreach (Prepaid element in ListPrepaid)
                {
                    string[] RowPrepaid;
                    RowPrepaid = new string[] { element.Id_Prepaid.ToString(), element.Name_Customer, element.Name_Product,
                        element.Prepaid_Quantity.ToString(),element.Prepaid_Total.ToString(), element.Prepaid_Cash.ToString(),
                        element.Prepaid_Change.ToString(), element.Prepaid_Balance.ToString()};
                    dgvPrepaid.Rows.Add(RowPrepaid);
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, "Error Al momento de Cargar el Grid",
                    "Error en Busqueda" + ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void dgvPrepaid_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                btnPrintPrepaid.Enabled = true;
                btnDeletePrepaid.Enabled = true;
                btnDeletePrepaid.Enabled = true;
                int Row = dgvPrepaid.CurrentRow.Index;
                txtNCustomerPrepaid.Text = dgvPrepaid[1, Row].Value.ToString();
                txtQuantityPrepaid.Text = dgvPrepaid[3, Row].Value.ToString();
                txtCashPrepaid.Text = dgvPrepaid[5, Row].Value.ToString();
                txtChangePrepaid.Text = dgvPrepaid[6, Row].Value.ToString();
                // Flow Principal of permission/buttoms
                mpOrder.Visible = true;
                mpOrder.Enabled = true;
                btnCreateOrden.Enabled = false;
                btnUpdateOrden.Enabled = false;
                btnDeleteOrder.Enabled = false;
                dgvOrder.Enabled = false;
                LoadDataGridOrder();
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void btnRefreshPrepaid_Click(object sender, EventArgs e)
        {
            CleanFieldsPrepaid();
            CleanFieldsOrder();
        }
        private void txtSearchPrepaid_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchPrepaid.Text == "")
            {
                LoadDataGridPrepaid();
                CleanFieldsPrepaid();
            }
            else
            {
                try
                {
                    dgvPrepaid.Rows.Clear();
                    int ejem = 0;//  Trypare
                    if (int.TryParse(txtSearchPrepaid.Text, out ejem))
                    {
                        ObjPrepaid.Id_Prepaid = Convert.ToInt32(txtSearchPrepaid.Text);
                    }
                    else
                    {
                        ObjPrepaid.Name_Customer = txtSearchPrepaid.Text;
                    }
                    var ListPrepaid = ApiAccess_Prepaid.RetrieveAllById<Prepaid>(ObjPrepaid);


                    foreach (Prepaid element in ListPrepaid)
                    {
                        string[] RowPrepaid;
                        RowPrepaid = new string[] { element.Id_Prepaid.ToString(), element.Name_Customer, element.Name_Product,
                            element.Prepaid_Quantity.ToString(), element.Prepaid_Total.ToString(), element.Prepaid_Cash.ToString(),
                        element.Prepaid_Change.ToString(), element.Prepaid_Balance.ToString()};
                        dgvPrepaid.Rows.Add(RowPrepaid);
                    }
                }
                catch (Exception ex)
                {

                    MetroMessageBox.Show(this, "La Petición -" + txtSearchPrepaid.Text +
                        "- no es Valida. ", "Error en Busqueda" + ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        /// Delete
        private void btnDeletePrepaid_Click(object sender, EventArgs e)
        {
            int Row = dgvPrepaid.CurrentRow.Index;
            int IdPrepaid = Convert.ToInt32(dgvPrepaid[0, Row].Value);
            if (dgvPrepaid[0, Row].Value == null)
            {
                MetroMessageBox.Show(this, "Debe Seleccionar Al menos Algún Valor para Inactivar. \n Favor Intentelo Nuevamente",
                    "Error en Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dgvPrepaid.Focus();
                return;
            }
            else
            {
                if (MetroFramework.MetroMessageBox.Show(this, "¿Desea Anular La Cuenta N-° : " + IdPrepaid.ToString() + "?",
                    "Confirmación de Acción", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    try
                    {
                        ObjPrepaid.Id_Prepaid = IdPrepaid;
                        ObjPrepaid.UpdateBy = pIdSession;
                        ApiAccess_Prepaid.Delete(ObjPrepaid);
                    }
                    catch (Exception ex)
                    {
                        MetroMessageBox.Show(this, "Error Al momento de Eliminar",
                            "Error en Crud" + ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    CleanFieldsPrepaid();
                    CleanFieldsOrder();
                    LoadDataGridPrepaid();
                }
            }
        }
        /// </CrudPrepaid>

        /// <CrudStock>
        public void CreateStock()
        {

        }
        /// </CrudStock>

        /// <CrudOrder>
        /// Create
        private void btnCreateOrden_Click(object sender, EventArgs e)
        {
           
            string QuantityOrder = txtQuantityOrder.Text;
            int Row = dgvPrepaid.CurrentRow.Index;
            string Id_Prepaid = dgvPrepaid[0, Row].Value.ToString();
            DateTime DateOrder = Convert.ToDateTime(dtOrder.Text);
            DateTime dateAlert = DateTime.Today;
            int result = DateTime.Compare(DateOrder, dateAlert);

            if (string.IsNullOrEmpty(DateOrder.ToString()) || result <= 0)
            {
                MetroMessageBox.Show(this, "La Fecha - " + DateOrder +
                    " - no es Valida. \n Favor Seleccione un valor Valido", "Error en Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtOrder.Focus();
                return;
            }
            if (string.IsNullOrEmpty(QuantityOrder.Trim()))
            {
                MetroMessageBox.Show(this, "La Cantidad -" + QuantityOrder +
                    "- no es Valida. \n Favor Seleccione un valor Valido", "Error en Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtQuantityOrder.Focus();
                return;
            }
            if (string.IsNullOrEmpty(Id_Prepaid.Trim()))
            {
                MetroMessageBox.Show(this, "Debe de Seleccionar una cuenta en el Grid -" + Id_Prepaid +
                    " \n Favor Seleccione un valor Valido", "Error en Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtQuantityOrder.Focus();
                return;
            }
            else
            {
                try
                {
                    ObjOrder.Id_Prepaid = Convert.ToInt32(Id_Prepaid);
                    ObjOrder.Order_Quantity = Convert.ToInt32(QuantityOrder);
                    ObjOrder.Order_Date = Convert.ToDateTime(DateOrder);
                    ObjOrder.CreateBy = pIdSession;
                    ApiAccess_Order.Create(ObjOrder);
                    btnCreatePrepaid.Text = "Finalizar";
                    txtCashPrepaid_TextChanged(sender, e);
                }
                catch (Exception ex)
                {
                    MetroMessageBox.Show(this, "Error Al momento de Agregar",
                        "Error en Crud" + ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                LoadDataGridOrder();
                //Add days dgv
               // int Rowdate = dgvOrder.CurrentRow.Index;
                //dtOrder.Text = dgvOrder[2, Row].Value.ToString();
                DateTime dateup = Convert.ToDateTime(dtOrder.Text);
                dateup = dateup.AddDays(1);
                dtOrder.Text = dateup.ToString();
            }
        }
        /// Update
        private void btnUpdateOrden_Click(object sender, EventArgs e)
        {
            DateTime DateOrder = Convert.ToDateTime(dtOrder.Text);
            DateTime dateAlert = DateTime.Today.AddDays(-1);
            int result = DateTime.Compare(DateOrder, dateAlert);
            string QuantityOrder = txtQuantityOrder.Text;
            int Row = dgvOrder.CurrentRow.Index;
            string Id_Order = dgvOrder[0, Row].Value.ToString();
            if (string.IsNullOrEmpty(DateOrder.ToString()) || result <= 0)
            {
                MetroMessageBox.Show(this, "La Fecha -" + DateOrder +
                    "- no es Valida. \n Favor Seleccione un valor Valido", "Error en Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtOrder.Focus();
                return;
            }
            if (string.IsNullOrEmpty(QuantityOrder.Trim()))
            {
                MetroMessageBox.Show(this, "La Cantidad -" + QuantityOrder +
                    "- no es Valida. \n Favor Seleccione un valor Valido", "Error en Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtQuantityOrder.Focus();
                return;
            }
            if (string.IsNullOrEmpty(Id_Order.Trim()))
            {
                MetroMessageBox.Show(this, "Debe de Seleccionar una cuenta en el Grid -" + Id_Order +
                    " \n Favor Seleccione un valor Valido", "Error en Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtQuantityOrder.Focus();
                return;
            }
            else
            {
                try
                {
                    ObjOrder.Id_Order = Convert.ToInt32(Id_Order);
                    ObjOrder.Order_Quantity = Convert.ToInt32(QuantityOrder);
                    ObjOrder.Order_Date = Convert.ToDateTime(DateOrder);
                    ObjOrder.UpdateBy = pIdSession;
                    ApiAccess_Order.Update(ObjOrder);
                    txtCashPrepaid_TextChanged(sender, e);
                }
                catch (Exception ex)
                {
                    MetroMessageBox.Show(this, "Error Al momento de Actualizar",
                        "Error en Crud" + ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                LoadDataGridOrder();
            }
        }
        private void btnCreateRetreat_Click(object sender, EventArgs e)
        {
            string DateOrder = dtOrder.Text;
            string QuantityOrder = txtQuantityOrder.Text;
            int Row = dgvOrder.CurrentRow.Index;
            string Id_Order = dgvOrder[0, Row].Value.ToString();
            if (string.IsNullOrEmpty(DateOrder.Trim()))
            {
                MetroMessageBox.Show(this, "La Fecha -" + DateOrder +
                    "- no es Valida. \n Favor Seleccione un valor Valido", "Error en Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtOrder.Focus();
                return;
            }
            if (string.IsNullOrEmpty(QuantityOrder.Trim()))
            {
                MetroMessageBox.Show(this, "La Cantidad -" + QuantityOrder +
                    "- no es Valida. \n Favor Seleccione un valor Valido", "Error en Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtQuantityOrder.Focus();
                return;
            }
            if (string.IsNullOrEmpty(Id_Order.Trim()))
            {
                MetroMessageBox.Show(this, "Debe de Seleccionar una cuenta en el Grid -" + Id_Order +
                    " \n Favor Seleccione un valor Valido", "Error en Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtQuantityOrder.Focus();
                return;
            }
            else
            {
                try
                {
                    ObjOrder.Id_Order = Convert.ToInt32(Id_Order);
                    ObjOrder.Order_Quantity = Convert.ToInt32(QuantityOrder);
                    ObjOrder.Order_Date = Convert.ToDateTime(DateOrder);
                    ObjOrder.UpdateBy = pIdSession;
                    ApiAccess_Order.Update(ObjOrder);
                }
                catch (Exception ex)
                {
                    MetroMessageBox.Show(this, "Error Al momento de Agregar",
                        "Error en Crud" + ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                LoadDataGridOrder();
            }

        }
        /// Retrieve
        public void LoadDataGridOrder()
        {
            try
            {
                CleanFieldsOrder();
                if (mtoggleOrder.Checked == false)
                {
                    btnCreateOrden.Enabled = false;
                }
                dgvOrder.Rows.Clear();
                int Row = dgvPrepaid.CurrentRow.Index;
                ObjOrder.Id_Prepaid = Convert.ToInt32(dgvPrepaid[0, Row].Value);
                var ListOrder = ApiAccess_Order.RetrieveAllById<Order>(ObjOrder);
                foreach (Order element in ListOrder)
                {
                    string[] RowOrder;
                    RowOrder = new string[] { element.Id_Order.ToString(),element.Id_Prepaid.ToString(), element.Order_Quantity.ToString(),
                    element.Order_Date.ToString()};
                    dgvOrder.Rows.Add(RowOrder);
                }
               txtQuantityPrepaid.Text = CalculateRowsQuantity().ToString();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, "Error Al momento de Cargar el Grid",
                    "Error en Busqueda" + ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        public void LoadDataGridROrder()
        {
            try
            {
                dgvROrder.Rows.Clear();
                int Row = dgvROrder.CurrentRow.Index;
                var ListOrder = ApiAccess_Order.RetrieveAll<Order>();
                foreach (Order element in ListOrder)
                {
                    if(element.Order_Date == DateTime.Today)
                    {
                        string[] RowOrder;
                        RowOrder = new string[] { element.Id_Order.ToString(),element.Id_Prepaid.ToString(), element.Order_Quantity.ToString(),
                        element.Order_Date.ToString(), element.Order_Delivery.ToString()};
                        dgvROrder.Rows.Add(RowOrder);
                    }
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, "Error Al momento de Cargar el Grid",
                    "Error en Busqueda" + ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        /// Delete
        private void btnDeleteOrden_Click(object sender, EventArgs e)
        {
            int Row = dgvOrder.CurrentRow.Index;
            string Id_Order = dgvOrder[0, Row].Value.ToString();
           
            if (string.IsNullOrEmpty(Id_Order.Trim()))
            {
                MetroMessageBox.Show(this, "Debe de Seleccionar una cuenta en el Grid -" + Id_Order +
                    " \n Favor Seleccione un valor Valido", "Error en Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtQuantityOrder.Focus();
                return;
            }
            else
            {
                try
                {
                    ObjOrder.Id_Order = Convert.ToInt32(Id_Order);
                    ObjOrder.UpdateBy = pIdSession;
                    ApiAccess_Order.Delete(ObjOrder);
                    txtCashPrepaid_TextChanged(sender, e);
                }
                catch (Exception ex)
                {
                    MetroMessageBox.Show(this, "Error Al momento de Agregar",
                        "Error en Crud" + ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                LoadDataGridOrder();
            }
        }
        private int CalculateRowsQuantity()
        {
            int TotalRows = 0;
            foreach (DataGridViewRow row in dgvOrder.Rows)
            {
                TotalRows += Convert.ToInt32(row.Cells["ORDER_QUANTITY"].Value);
            }
            return TotalRows;
        }
        /// </CrudOrder>
        /// KeyPress
        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtCash_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtIDCustomer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtNCustomer_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
        /// TextChanged
        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            if (txtQuantity.Text == "")
            {
                txtTotalReceipt.Text = "";
                txtCash.Text = "";
            }
            else
            {
                int Quantity = Convert.ToInt32(txtQuantity.Text);
                txtTotalReceipt.Text = Math.Round((Quantity * gUnit_Price), 2).ToString();
            }
        }
        private void txtCash_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtCash.Text == "")
                {
                    txtCash.Text = "";
                    txtCambio.Text = "";
                }
                else
                {
                    decimal TotalReceipt = Convert.ToDecimal(txtTotalReceipt.Text);
                    decimal Cash = Convert.ToDecimal(txtCash.Text);
                    txtCambio.Text = (Cash - TotalReceipt).ToString();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        private void txtTotalReceipt_TextChanged(object sender, EventArgs e)
        {
            if (txtTotalReceipt.Text != string.Empty)
            {
                txtCash.Enabled = true;
            }
        }
        private void dgvReceipt_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                btnPrint.Enabled = true;
                btnDelete.Enabled = true;
                int Row = dgvReceipt.CurrentRow.Index;
                txtNameCustomer.Text = dgvReceipt[1, Row].Value.ToString();
                txtQuantity.Text = dgvReceipt[2, Row].Value.ToString();
                txtTotalReceipt.Text = dgvReceipt[3, Row].Value.ToString();
                txtCash.Text = dgvReceipt[6, Row].Value.ToString();
                txtCambio.Text = dgvReceipt[7, Row].Value.ToString();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, "Error Al momento de Cargar el Grid",
                    "Error en Busqueda" + ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
        private void dgvCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                btnUpdateCustomer.Enabled = true;
                int Row = dgvCustomer.CurrentRow.Index;
                txtIDCustomer.Text = dgvCustomer[0, Row].Value.ToString();
                txtNCustomer.Text = dgvCustomer[1, Row].Value.ToString();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, "Error Al momento de Cargar el Grid",
                    "Error en Busqueda" + ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void dgvOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                btnUpdateOrden.Enabled = true;
                btnDeleteOrder.Enabled = true;
                btnCreateOrden.Enabled = false;
                int Row = dgvOrder.CurrentRow.Index;
                txtQuantityOrder.Text = dgvOrder[2, Row].Value.ToString();
                dtOrder.Text = dgvOrder[3, Row].Value.ToString();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, "Error Al momento de Cargar el Grid",
                    "Error en Busqueda" + ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        /// Click for pnl
        private void btnCleanFields_Click(object sender, EventArgs e)
        {
            CleanFields();
            LoadDataGrid();
        }
        private void btnLoadRpt_Click(object sender, EventArgs e)
        {
            ShowReportByUser();
        }
        public void CleanFields()
        {
            btnPrint.Enabled = false;
            btnDelete.Enabled = false;
            txtNameCustomer.Text = "";
            txtQuantity.Text = "";
            txtRetrieveByName.Text = "";
            txtCambio.Text = "";
            txtCash.Text = "";
            txtCash.Enabled = false;
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
        public void LoadPriceTag()
        {
            try
            {
                var ListPricetag = ApiAccess_Product.RetrieveAllProduct<Product>();
                foreach (Product element in ListPricetag)
                {
                    if (element.ID_Product == 7) // PRECIO ACTUAL DEL PRODUCTO 7= new ID_PRODUCT
                    {
                        gIdPrice_Tag = element.ID_Product;
                        gUnit_Price = element.Total_Product;
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }

        } //get the Price and ID of Product 
        public void CleanFieldsCustomer()
        {
            txtIDCustomer.Text = "";
            txtNCustomer.Text = "";
        }
        public void CleanFieldsPrepaid()
        {
            txtNCustomerPrepaid.Text = "";
            txtQuantityPrepaid.Text = "";
            txtTotalPrepaid.Text = "";
            txtCashPrepaid.Text = "";
            txtChangePrepaid.Text = "";
            mpOrder.Visible = false;
            dgvPrepaid.Enabled = true;
            dgvOrder.Rows.Clear();
            txtQuantityOrder.Text = "";
            txtSearchPrepaid.Text = "";
            btnCreatePrepaid.Text = "Crear";
            btnCreatePrepaid.Style = MetroFramework.MetroColorStyle.Blue;
        }
        public void CleanFieldsOrder()
        {
            btnCreateOrden.Enabled = true;
            btnUpdateOrden.Enabled = false;
            btnDeleteOrder.Enabled = false;
            mtoggleOrder.Checked = false;
            txtQuantityOrder.Text = "";
            dtOrder.Text = DateTime.Today.AddDays(1).ToString();
            dgvOrder.Rows.Clear();
            
        }
        public void CleanFieldsROrder()
        {
            txtSearchRetreat.Text = "";
            txtCustomerRetreat.Text = "";
        }
        /// </Eventpnl> 

        /// <RptEvents>
        private void GetIdSsrs() // Principal Flow
        {
            // int Row = dgvReceipt.CurrentRow.Index;
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
        private void Print() // Principal Flow
        {
            GetIdSsrs();
            frmReport rpt = new frmReport();
            rpt.Show();
        }
        private void GetDatesReport()
        {
            MystaticValues.rptSsrsDateBegin = dtBegin.Text;
            MystaticValues.rptSsrsDateEnd = dtEnd.Text;
            frmReportDaily rpt = new frmReportDaily();
            rpt.Show();

        }
        public void ShowReportByUser()
        {
            GetDatesReport();

        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintAF();
        }
        private void btnStock_Click(object sender, EventArgs e)
        {
            
            pnlStock.Visible = true;
        }
        private void btnOCStock_Click(object sender, EventArgs e)
        {
            btnStock.Style = MetroFramework.MetroColorStyle.Red;
            btnStock.Text = "Cerrar";
            pnlStock.Visible = false;
        }
        private void mtoggleOrder_CheckedChanged(object sender, EventArgs e)
        {
            //mtoggleOrder.Checke
            if(mtoggleOrder.Checked == false)
            {
                dgvOrder.Enabled = false;
                btnCreatePrepaid.Text = "Crear";
                btnCreatePrepaid.Style = MetroFramework.MetroColorStyle.Green;
                dgvPrepaid.Enabled = true;
                CleanFieldsOrder();
                btnCreateOrden.Enabled = false;
            }
            else
            {
                btnCreateOrden.Enabled = true;
                dgvOrder.Enabled = true;
                btnCreatePrepaid.Text = "Finalizar";
                btnCreatePrepaid.Style = MetroFramework.MetroColorStyle.Red;
                dgvPrepaid.Enabled = false;
            }
            
        }
        private void txtQuantityOrder_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtQuantityPrepaid_TextChanged(object sender, EventArgs e)
        {
            if (txtQuantityPrepaid.Text == "")
            {
                txtTotalPrepaid.Text = "";
                txtCashPrepaid.Text = "";
            }
            else
            {
                int Quantity = Convert.ToInt32(txtQuantityPrepaid.Text);
                txtTotalPrepaid.Text = Math.Round((Quantity * gUnit_Price), 2).ToString();
            }
        }
        private void txtCashPrepaid_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtCashPrepaid.Text == "")
                {
                    txtCashPrepaid.Text = "";
                    txtChangePrepaid.Text = "";
                }
                else
                {
                    decimal TotalPrepaid = Convert.ToDecimal(txtTotalPrepaid.Text);
                    decimal CashPrepaid = Convert.ToDecimal(txtCashPrepaid.Text);
                    txtChangePrepaid.Text = (CashPrepaid - TotalPrepaid).ToString();
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, "Error Al momento de Calcular",
                    "Error en Validación" + ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtCashPrepaid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        /// </RptEvents>

    }
}
