namespace Pharmacy_Management_System
{
    partial class UC_DailySales
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTotalRevenue = new System.Windows.Forms.Label();
            this.dtpSalesDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvDailySales = new System.Windows.Forms.DataGridView();
            this.SaleID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaleDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantitySold = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDailySales)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTotalRevenue
            // 
            this.lblTotalRevenue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalRevenue.AutoSize = true;
            this.lblTotalRevenue.BackColor = System.Drawing.Color.Green;
            this.lblTotalRevenue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalRevenue.ForeColor = System.Drawing.Color.White;
            this.lblTotalRevenue.Location = new System.Drawing.Point(447, 34);
            this.lblTotalRevenue.Name = "lblTotalRevenue";
            this.lblTotalRevenue.Padding = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.lblTotalRevenue.Size = new System.Drawing.Size(236, 48);
            this.lblTotalRevenue.TabIndex = 4;
            this.lblTotalRevenue.Text = "Total Revenue: Rs 0.00";
            // 
            // dtpSalesDate
            // 
            this.dtpSalesDate.Location = new System.Drawing.Point(111, 53);
            this.dtpSalesDate.Name = "dtpSalesDate";
            this.dtpSalesDate.Size = new System.Drawing.Size(305, 26);
            this.dtpSalesDate.TabIndex = 3;
            this.dtpSalesDate.ValueChanged += new System.EventHandler(this.dtpSalesDate_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Date:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblTotalRevenue);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dtpSalesDate);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(763, 100);
            this.panel1.TabIndex = 5;
            // 
            // dgvDailySales
            // 
            this.dgvDailySales.AllowUserToAddRows = false;
            this.dgvDailySales.AllowUserToDeleteRows = false;
            this.dgvDailySales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDailySales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDailySales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SaleID,
            this.SaleDate,
            this.QuantitySold,
            this.TotalPrice});
            this.dgvDailySales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDailySales.Location = new System.Drawing.Point(0, 100);
            this.dgvDailySales.Name = "dgvDailySales";
            this.dgvDailySales.ReadOnly = true;
            this.dgvDailySales.RowHeadersWidth = 62;
            this.dgvDailySales.RowTemplate.Height = 28;
            this.dgvDailySales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDailySales.Size = new System.Drawing.Size(763, 555);
            this.dgvDailySales.TabIndex = 6;
            // 
            // SaleID
            // 
            this.SaleID.HeaderText = "TransactionID";
            this.SaleID.MinimumWidth = 8;
            this.SaleID.Name = "SaleID";
            this.SaleID.ReadOnly = true;
            // 
            // SaleDate
            // 
            this.SaleDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SaleDate.HeaderText = "Time";
            this.SaleDate.MinimumWidth = 8;
            this.SaleDate.Name = "SaleDate";
            this.SaleDate.ReadOnly = true;
            // 
            // QuantitySold
            // 
            this.QuantitySold.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.QuantitySold.HeaderText = "TotalItems";
            this.QuantitySold.MinimumWidth = 8;
            this.QuantitySold.Name = "QuantitySold";
            this.QuantitySold.ReadOnly = true;
            // 
            // TotalPrice
            // 
            this.TotalPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TotalPrice.HeaderText = "TotalAmount";
            this.TotalPrice.MinimumWidth = 8;
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.ReadOnly = true;
            // 
            // UC_DailySales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvDailySales);
            this.Controls.Add(this.panel1);
            this.Name = "UC_DailySales";
            this.Size = new System.Drawing.Size(763, 655);
            this.Load += new System.EventHandler(this.UC_DailySales_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDailySales)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTotalRevenue;
        private System.Windows.Forms.DateTimePicker dtpSalesDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvDailySales;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaleID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaleDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantitySold;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPrice;
    }
}
