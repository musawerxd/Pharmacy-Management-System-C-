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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void ShowView(UserControl view)
        {
            foreach (Control ctrl in pnlMain.Controls)
            {
                ctrl.Dispose();
            }

            pnlMain.Controls.Clear();

            view.Dock = DockStyle.Fill;


            pnlMain.Controls.Add(view);
            view.BringToFront();
        }




        private void btnInventory_Click(object sender, EventArgs e) => ShowView(new UC_Inventory());




        private void btnSell_Click(object sender, EventArgs e) => ShowView(new UC_Sell());





        private void btnDailySales_Click(object sender, EventArgs e) => ShowView(new UC_DailySales());








        private void Form1_Load(object sender, EventArgs e)
        {
            ShowView(new UC_Inventory());
        }









        private void systemTimer_Tick_1(object sender, EventArgs e)
        {
            lblDateTime.Text = DateTime.Now.ToString("dddd, MMMM d, yyyy | hh:mm tt");
        }
    }
}
