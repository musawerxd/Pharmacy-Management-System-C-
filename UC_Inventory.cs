using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Pharmacy_Management_System
{
    public partial class UC_Inventory : UserControl
    {



        int selectedID = 0;






        public UC_Inventory()
        {
            InitializeComponent();
        }









        private void UC_Inventory_Load(object sender, EventArgs e)
        {
            cmbCategory.Items.Clear();
            cmbCategory.Items.Add("Tablet");
            cmbCategory.Items.Add("Capsule");
            cmbCategory.Items.Add("Syrup");
            cmbCategory.Items.Add("Injection");
            cmbCategory.Items.Add("Cream/Ointment");
            LoadData();
        }








        private void LoadData()
        {
            try
            {
                string query = "SELECT MedicineID, MedicineName, Category, Quantity, Price, ExpiryDate FROM Medicines";
                DataTable dt = DatabaseHelper.GetData(query);
                dgvInventory.AutoGenerateColumns = false;
                dgvInventory.DataSource = dt;
                UpdateDashboardStats(dt.DefaultView);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading inventory: " + ex.Message);
            }
        }









        private void UpdateDashboardStats(DataView dv)
        {
            int totalRecords = dv.Count;
            int expiredCount = 0;
            int lowStockCount = 0;
            DateTime now = DateTime.Now;

            foreach (DataRowView rowView in dv)
            {
                DataRow row = rowView.Row;
                if (DateTime.TryParse(row["ExpiryDate"].ToString(), out DateTime expiryDate))
                {
                    if (expiryDate < now) expiredCount++;
                }
                if (int.TryParse(row["Quantity"].ToString(), out int qty))
                {
                    if (qty < 10) lowStockCount++;
                }
            }

            label1.Text = $"Total: {totalRecords} Records";
            label2.Text = $"Expired: {expiredCount}";
            label3.Text = $"Low Stock: {lowStockCount}";
        }









        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (dgvInventory.DataSource is DataTable dt)
            {
                DataView dv = dt.DefaultView;
                string filterText = txtSearch.Text.Replace("'", "''");
                dv.RowFilter = $"MedicineName LIKE '%{filterText}%'";
                UpdateDashboardStats(dv);
            }
        }








        private void dgvInventory_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvInventory.Rows[e.RowIndex];


                txtMedicineName.Text = row.Cells[1].Value?.ToString();
                cmbCategory.Text = row.Cells[2].Value?.ToString();
                numStock.Value = Convert.ToDecimal(row.Cells[3].Value ?? 0);
                txtPrice.Text = row.Cells[4].Value?.ToString();
                dtpExpiry.Value = Convert.ToDateTime(row.Cells[5].Value ?? DateTime.Now);

                selectedID = Convert.ToInt32(row.Cells[0].Value);
            }
        }









        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMedicineName.Text) || string.IsNullOrWhiteSpace(txtPrice.Text))
            {
                MessageBox.Show("Please fill all required fields.");
                return;
            }


            string price = txtPrice.Text.Replace(",", ".");
            string query = $@"INSERT INTO Medicines (MedicineName, Category, Quantity, Price, ExpiryDate) 
                              VALUES ('{txtMedicineName.Text.Replace("'", "''")}', '{cmbCategory.Text}', 
                              {numStock.Value}, {price}, '{dtpExpiry.Value:yyyy-MM-dd}')";

            DatabaseHelper.ExecuteQuery(query);
            LoadData();
            ClearFields();
        }








        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedID == 0)
            {
                MessageBox.Show("Please select a record to update.");
                return;
            }

            string price = txtPrice.Text.Replace(",", ".");
            string query = $@"UPDATE Medicines SET 
                              MedicineName = '{txtMedicineName.Text.Replace("'", "''")}', 
                              Category = '{cmbCategory.Text}', 
                              Quantity = {numStock.Value}, 
                              Price = {price}, 
                              ExpiryDate = '{dtpExpiry.Value:yyyy-MM-dd}' 
                              WHERE MedicineID = {selectedID}";

            DatabaseHelper.ExecuteQuery(query);
            LoadData();
            ClearFields();
        }









        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedID == 0) return;

            if (MessageBox.Show("Delete this record?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string query = $"DELETE FROM Medicines WHERE MedicineID = {selectedID}";
                DatabaseHelper.ExecuteQuery(query);
                LoadData();
                ClearFields();
            }
        }








        private void ClearFields()
        {
            txtMedicineName.Clear();
            txtPrice.Clear();
            cmbCategory.SelectedIndex = -1;
            numStock.Value = 0;
            dtpExpiry.Value = DateTime.Now;
            selectedID = 0;
        }



    }
}