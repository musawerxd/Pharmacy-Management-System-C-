using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_Management_System
{
    public partial class UC_Sell : UserControl
    {
        public UC_Sell()
        {
            InitializeComponent();
        }

        private void LoadMedicinesList()
        {
            try
            {
                string query = "SELECT MedicineName FROM Medicines WHERE Quantity > 0";
                DataTable dt = DatabaseHelper.GetData(query);

                cmbSelectMedicine.DataSource = dt;
                cmbSelectMedicine.DisplayMember = "MedicineName";

                cmbSelectMedicine.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading medicines: " + ex.Message);
            }
        }










        private void cmbSelectMedicine_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cmbSelectMedicine.SelectedIndex != -1)
            {
                string selectedMed = cmbSelectMedicine.Text;
                string query = $"SELECT Quantity, Price FROM Medicines WHERE MedicineName = '{selectedMed}'";
                DataTable dt = DatabaseHelper.GetData(query);

                if (dt.Rows.Count > 0)
                {
                    lblInStock.Text = dt.Rows[0]["Quantity"].ToString();
                    lblPricePerUnit.Text = dt.Rows[0]["Price"].ToString();

                    numQuantityToSell.Value = 1;
                }
            }
        }









        private void numQuantityToSell_ValueChanged(object sender, EventArgs e)
        {
            decimal price = decimal.Parse(lblPricePerUnit.Text);
            decimal qty = numQuantityToSell.Value;

            lblSubTotal.Text = "Rs " + (price * qty).ToString("N2");
        }








        private void button2_Click(object sender, EventArgs e)
        {

            if (cmbSelectMedicine.SelectedIndex == -1 || string.IsNullOrEmpty(cmbSelectMedicine.Text) || numQuantityToSell.Value <= 0)
            {
                return;
            }




            int stock = int.Parse(lblInStock.Text);
            if (numQuantityToSell.Value > stock)
            {
                MessageBox.Show("Not enough stock!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            dgvCart.Rows.Add(cmbSelectMedicine.Text, lblPricePerUnit.Text, numQuantityToSell.Value, (decimal.Parse(lblPricePerUnit.Text) * numQuantityToSell.Value));


            lblItemCount.Text = "Items: " + dgvCart.Rows.Count.ToString();
            UpdateGrandTotal();
        }










        private void UC_Sell_Load(object sender, EventArgs e)
        {
            LoadMedicinesList();


        }

        private void dgvCart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCart.Columns[e.ColumnIndex].Name == "sellRemove" && e.RowIndex >= 0)
            {
                dgvCart.Rows.RemoveAt(e.RowIndex);

                lblItemCount.Text = "Items: " + dgvCart.Rows.Count.ToString();
                UpdateGrandTotal();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dgvCart.Rows.Clear();
            lblItemCount.Text = "Items: 0";
            cmbSelectMedicine.SelectedIndex = -1;
            lblInStock.Text = "0";
            lblPricePerUnit.Text = "0.00";
            lblSubTotal.Text = "Rs 0.00";
            numQuantityToSell.Value = 0;
            UpdateGrandTotal();
        }









        private void UpdateGrandTotal()
        {
            decimal total = 0;
            foreach (DataGridViewRow row in dgvCart.Rows)
            {
                if (row.IsNewRow) continue;


                if (row.Cells[3].Value != null)
                {
                    total += Convert.ToDecimal(row.Cells[3].Value);
                }
            }
            grndTotal.Text = "Grand Total: Rs " + total.ToString("N2");
        }









        private void button3_Click(object sender, EventArgs e)
        {
            if (dgvCart.Rows.Count == 0)
            {
                MessageBox.Show("Cart is empty!");
                return;
            }
            string receiptItems = "";
            decimal finalTotal = 0;
            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();


                    foreach (DataGridViewRow row in dgvCart.Rows)
                    {
                        if (row.IsNewRow) continue;

                        string medName = row.Cells[0].Value.ToString();
                        int qtySold = Convert.ToInt32(row.Cells[2].Value);
                        decimal totalPrice = Convert.ToDecimal(row.Cells[3].Value);



                        string insertSale = "INSERT INTO Sales (MedicineName, QuantitySold, TotalPrice, SaleDate) " +
                                            "VALUES (@name, @qty, @total, GETDATE())";

                        using (SqlCommand cmdSale = new SqlCommand(insertSale, conn))
                        {
                            cmdSale.Parameters.AddWithValue("@name", medName);
                            cmdSale.Parameters.AddWithValue("@qty", qtySold);
                            cmdSale.Parameters.AddWithValue("@total", totalPrice);
                            cmdSale.ExecuteNonQuery();
                        }
                        receiptItems += medName + " (x" + qtySold + ") - Rs " + totalPrice + "\n";
                        finalTotal += totalPrice;




                        string updateStock = "UPDATE Medicines SET Quantity = Quantity - @qty WHERE MedicineName = @name";

                        using (SqlCommand cmdUpdate = new SqlCommand(updateStock, conn))
                        {
                            cmdUpdate.Parameters.AddWithValue("@qty", qtySold);
                            cmdUpdate.Parameters.AddWithValue("@name", medName);
                            cmdUpdate.ExecuteNonQuery();
                        }
                    }
                }

                string receipt = "--- TRANSACTION SUCCESS ---\n\n" +
                            receiptItems +
                            "\n---------------------------\n" +
                            "GRAND TOTAL: Rs " + finalTotal.ToString("N2") +
                            "\n---------------------------";

                MessageBox.Show(receipt, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                button4_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
