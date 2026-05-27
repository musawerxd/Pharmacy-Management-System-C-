using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_Management_System
{
    public partial class UC_DailySales : UserControl
    {
        public UC_DailySales()
        {
            InitializeComponent();
        }


        private void LoadDailySales()
        {
            try
            {
                string selectedDate = dtpSalesDate.Value.ToString("yyyy-MM-dd");


                string query = $"SELECT SaleID, SaleDate, QuantitySold, TotalPrice FROM Sales WHERE SaleDate = '{selectedDate}'";

                DataTable dt = DatabaseHelper.GetData(query);

                dgvDailySales.AutoGenerateColumns = false;


                if (dgvDailySales.Columns.Count >= 4)
                {
                    dgvDailySales.Columns[0].DataPropertyName = "SaleID";
                    dgvDailySales.Columns[1].DataPropertyName = "SaleDate";
                    dgvDailySales.Columns[2].DataPropertyName = "QuantitySold";
                    dgvDailySales.Columns[3].DataPropertyName = "TotalPrice";
                }





                dgvDailySales.DataSource = dt;





                decimal totalRevenue = 0;
                foreach (DataRow row in dt.Rows)
                {
                    totalRevenue += Convert.ToDecimal(row["TotalPrice"]);
                }

                lblTotalRevenue.Text = "Total Revenue: Rs " + totalRevenue.ToString("N2");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading sales: " + ex.Message);
            }
        }











        private void UC_DailySales_Load(object sender, EventArgs e)
        {
            LoadDailySales();
        }









        private void dtpSalesDate_ValueChanged(object sender, EventArgs e)
        {
            LoadDailySales();
        }
    }
}
