namespace Pharmacy_Management_System
{
    partial class UC_Sell
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grndTotal = new System.Windows.Forms.Label();
            this.dgvCart = new System.Windows.Forms.DataGridView();
            this.sellMedicineName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellSubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellRemove = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lblItemCount = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.grpSelection = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.numQuantityToSell = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.lblPricePerUnit = new System.Windows.Forms.Label();
            this.lblInStock = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbSelectMedicine = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).BeginInit();
            this.grpSelection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantityToSell)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.20594F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.79406F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.grpSelection, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(942, 835);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.grndTotal);
            this.groupBox1.Controls.Add(this.dgvCart);
            this.groupBox1.Controls.Add(this.lblItemCount);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(446, 50);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(40, 50, 40, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(456, 735);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Billing";
            // 
            // grndTotal
            // 
            this.grndTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grndTotal.AutoSize = true;
            this.grndTotal.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grndTotal.Location = new System.Drawing.Point(92, 590);
            this.grndTotal.Name = "grndTotal";
            this.grndTotal.Size = new System.Drawing.Size(185, 38);
            this.grndTotal.TabIndex = 17;
            this.grndTotal.Text = "Grand Total: ";
            // 
            // dgvCart
            // 
            this.dgvCart.AllowUserToAddRows = false;
            this.dgvCart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCart.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            this.dgvCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sellMedicineName,
            this.sellUnitPrice,
            this.sellQuantity,
            this.sellSubTotal,
            this.sellRemove});
            this.dgvCart.Location = new System.Drawing.Point(0, 219);
            this.dgvCart.Name = "dgvCart";
            this.dgvCart.ReadOnly = true;
            this.dgvCart.RowHeadersWidth = 62;
            this.dgvCart.RowTemplate.Height = 28;
            this.dgvCart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCart.Size = new System.Drawing.Size(456, 285);
            this.dgvCart.TabIndex = 16;
            this.dgvCart.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCart_CellContentClick);
            // 
            // sellMedicineName
            // 
            this.sellMedicineName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sellMedicineName.HeaderText = "MedicineName";
            this.sellMedicineName.MinimumWidth = 8;
            this.sellMedicineName.Name = "sellMedicineName";
            this.sellMedicineName.ReadOnly = true;
            // 
            // sellUnitPrice
            // 
            this.sellUnitPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sellUnitPrice.HeaderText = "UnitPrice";
            this.sellUnitPrice.MinimumWidth = 8;
            this.sellUnitPrice.Name = "sellUnitPrice";
            this.sellUnitPrice.ReadOnly = true;
            // 
            // sellQuantity
            // 
            this.sellQuantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sellQuantity.HeaderText = "Quantity";
            this.sellQuantity.MinimumWidth = 8;
            this.sellQuantity.Name = "sellQuantity";
            this.sellQuantity.ReadOnly = true;
            // 
            // sellSubTotal
            // 
            this.sellSubTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sellSubTotal.HeaderText = "SubTotal";
            this.sellSubTotal.MinimumWidth = 8;
            this.sellSubTotal.Name = "sellSubTotal";
            this.sellSubTotal.ReadOnly = true;
            // 
            // sellRemove
            // 
            this.sellRemove.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sellRemove.HeaderText = "Remove";
            this.sellRemove.MinimumWidth = 8;
            this.sellRemove.Name = "sellRemove";
            this.sellRemove.ReadOnly = true;
            this.sellRemove.Text = "Remove";
            this.sellRemove.ToolTipText = "Remove this Entry";
            // 
            // lblItemCount
            // 
            this.lblItemCount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblItemCount.AutoSize = true;
            this.lblItemCount.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemCount.Location = new System.Drawing.Point(173, 96);
            this.lblItemCount.Name = "lblItemCount";
            this.lblItemCount.Size = new System.Drawing.Size(122, 38);
            this.lblItemCount.TabIndex = 14;
            this.lblItemCount.Text = "Items: 0";
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button3.BackColor = System.Drawing.Color.Green;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(216, 658);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(213, 43);
            this.button3.TabIndex = 13;
            this.button3.Text = "Confirm";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button4.BackColor = System.Drawing.Color.Maroon;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(46, 658);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(122, 43);
            this.button4.TabIndex = 12;
            this.button4.Text = "Cancel Sale";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 186);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(109, 21);
            this.label11.TabIndex = 6;
            this.label11.Text = "Items in Cart : ";
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(92, 64);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(274, 38);
            this.label16.TabIndex = 0;
            this.label16.Text = "Current Transaction";
            // 
            // grpSelection
            // 
            this.grpSelection.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpSelection.Controls.Add(this.button2);
            this.grpSelection.Controls.Add(this.lblSubTotal);
            this.grpSelection.Controls.Add(this.label7);
            this.grpSelection.Controls.Add(this.numQuantityToSell);
            this.grpSelection.Controls.Add(this.label6);
            this.grpSelection.Controls.Add(this.lblPricePerUnit);
            this.grpSelection.Controls.Add(this.lblInStock);
            this.grpSelection.Controls.Add(this.label3);
            this.grpSelection.Controls.Add(this.label2);
            this.grpSelection.Controls.Add(this.cmbSelectMedicine);
            this.grpSelection.Controls.Add(this.label1);
            this.grpSelection.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSelection.Location = new System.Drawing.Point(40, 50);
            this.grpSelection.Margin = new System.Windows.Forms.Padding(40, 50, 40, 50);
            this.grpSelection.Name = "grpSelection";
            this.grpSelection.Size = new System.Drawing.Size(326, 735);
            this.grpSelection.TabIndex = 1;
            this.grpSelection.TabStop = false;
            this.grpSelection.Text = "Medicine Selection && Quantity";
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.BackColor = System.Drawing.Color.Green;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(36, 570);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(248, 43);
            this.button2.TabIndex = 12;
            this.button2.Text = "Add to Current Transcation";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTotal.Location = new System.Drawing.Point(121, 438);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(118, 32);
            this.lblSubTotal.TabIndex = 10;
            this.lblSubTotal.Text = "Rs 0.00";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(43, 404);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 21);
            this.label7.TabIndex = 9;
            this.label7.Text = "Calculated SubTotal :";
            // 
            // numQuantityToSell
            // 
            this.numQuantityToSell.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numQuantityToSell.Location = new System.Drawing.Point(119, 322);
            this.numQuantityToSell.Name = "numQuantityToSell";
            this.numQuantityToSell.Size = new System.Drawing.Size(116, 29);
            this.numQuantityToSell.TabIndex = 8;
            this.numQuantityToSell.ValueChanged += new System.EventHandler(this.numQuantityToSell_ValueChanged);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 21);
            this.label6.TabIndex = 6;
            this.label6.Text = "Quantity to Sell :";
            // 
            // lblPricePerUnit
            // 
            this.lblPricePerUnit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPricePerUnit.AutoSize = true;
            this.lblPricePerUnit.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPricePerUnit.Location = new System.Drawing.Point(244, 195);
            this.lblPricePerUnit.Name = "lblPricePerUnit";
            this.lblPricePerUnit.Size = new System.Drawing.Size(58, 30);
            this.lblPricePerUnit.TabIndex = 5;
            this.lblPricePerUnit.Text = "0.00";
            // 
            // lblInStock
            // 
            this.lblInStock.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInStock.AutoSize = true;
            this.lblInStock.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInStock.Location = new System.Drawing.Point(62, 195);
            this.lblInStock.Name = "lblInStock";
            this.lblInStock.Size = new System.Drawing.Size(32, 30);
            this.lblInStock.TabIndex = 4;
            this.lblInStock.Text = "0 ";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(215, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Price/Unit : ";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "InStock : ";
            // 
            // cmbSelectMedicine
            // 
            this.cmbSelectMedicine.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbSelectMedicine.FormattingEnabled = true;
            this.cmbSelectMedicine.Location = new System.Drawing.Point(66, 95);
            this.cmbSelectMedicine.Name = "cmbSelectMedicine";
            this.cmbSelectMedicine.Size = new System.Drawing.Size(240, 29);
            this.cmbSelectMedicine.TabIndex = 1;
            this.cmbSelectMedicine.SelectedIndexChanged += new System.EventHandler(this.cmbSelectMedicine_SelectedIndexChanged_1);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Medicine :";
            // 
            // UC_Sell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UC_Sell";
            this.Size = new System.Drawing.Size(942, 835);
            this.Load += new System.EventHandler(this.UC_Sell_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).EndInit();
            this.grpSelection.ResumeLayout(false);
            this.grpSelection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantityToSell)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox grpSelection;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblPricePerUnit;
        private System.Windows.Forms.Label lblInStock;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbSelectMedicine;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numQuantityToSell;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dgvCart;
        private System.Windows.Forms.Label lblItemCount;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataGridViewTextBoxColumn sellMedicineName;
        private System.Windows.Forms.DataGridViewTextBoxColumn sellUnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn sellQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn sellSubTotal;
        private System.Windows.Forms.DataGridViewButtonColumn sellRemove;
        private System.Windows.Forms.Label grndTotal;
    }
}
