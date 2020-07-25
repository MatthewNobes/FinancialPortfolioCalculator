namespace FinancialPortfolioCalculator
{
    partial class NewTransactionStock
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTransactionName = new System.Windows.Forms.TextBox();
            this.txtUnitsObtained = new System.Windows.Forms.TextBox();
            this.txtAmountOut = new System.Windows.Forms.TextBox();
            this.txtAmountIn = new System.Windows.Forms.TextBox();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.txtFundID = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpTransactionDate = new System.Windows.Forms.DateTimePicker();
            this.btnSaveTransaction = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameOfStockFundDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeOfHoldingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberOfUnitsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockHoldingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.moneydbDataSet = new FinancialPortfolioCalculator.MoneydbDataSet();
            this.stockHoldingsTableAdapter = new FinancialPortfolioCalculator.MoneydbDataSetTableAdapters.StockHoldingsTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockHoldingsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moneydbDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name of Transaction:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Date of Transaction:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Amount In:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Amount Out:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Fund ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Type of Transaction";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 192);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(212, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Units Obtained (if applicable)";
            // 
            // txtTransactionName
            // 
            this.txtTransactionName.Location = new System.Drawing.Point(236, 27);
            this.txtTransactionName.Name = "txtTransactionName";
            this.txtTransactionName.Size = new System.Drawing.Size(524, 26);
            this.txtTransactionName.TabIndex = 7;
            // 
            // txtUnitsObtained
            // 
            this.txtUnitsObtained.Location = new System.Drawing.Point(236, 189);
            this.txtUnitsObtained.Name = "txtUnitsObtained";
            this.txtUnitsObtained.Size = new System.Drawing.Size(524, 26);
            this.txtUnitsObtained.TabIndex = 8;
            // 
            // txtAmountOut
            // 
            this.txtAmountOut.Location = new System.Drawing.Point(236, 123);
            this.txtAmountOut.Name = "txtAmountOut";
            this.txtAmountOut.Size = new System.Drawing.Size(524, 26);
            this.txtAmountOut.TabIndex = 9;
            // 
            // txtAmountIn
            // 
            this.txtAmountIn.Location = new System.Drawing.Point(236, 91);
            this.txtAmountIn.Name = "txtAmountIn";
            this.txtAmountIn.Size = new System.Drawing.Size(524, 26);
            this.txtAmountIn.TabIndex = 10;
            // 
            // cmbType
            // 
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "1 - Fees",
            "2 - Re-investment",
            "3 - Initial Investment",
            "4 - Dividend Payment",
            "5 - Loyalty Payment"});
            this.cmbType.Location = new System.Drawing.Point(236, 155);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(524, 28);
            this.cmbType.TabIndex = 12;
            // 
            // txtFundID
            // 
            this.txtFundID.Location = new System.Drawing.Point(236, 221);
            this.txtFundID.Name = "txtFundID";
            this.txtFundID.Size = new System.Drawing.Size(524, 26);
            this.txtFundID.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpTransactionDate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtFundID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbType);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtAmountIn);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtAmountOut);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtUnitsObtained);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtTransactionName);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(779, 266);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Please Enter New Transaction Information";
            // 
            // dtpTransactionDate
            // 
            this.dtpTransactionDate.Location = new System.Drawing.Point(236, 57);
            this.dtpTransactionDate.Name = "dtpTransactionDate";
            this.dtpTransactionDate.Size = new System.Drawing.Size(524, 26);
            this.dtpTransactionDate.TabIndex = 17;
            // 
            // btnSaveTransaction
            // 
            this.btnSaveTransaction.Location = new System.Drawing.Point(616, 284);
            this.btnSaveTransaction.Name = "btnSaveTransaction";
            this.btnSaveTransaction.Size = new System.Drawing.Size(175, 39);
            this.btnSaveTransaction.TabIndex = 15;
            this.btnSaveTransaction.Text = "Save Transaction";
            this.btnSaveTransaction.UseVisualStyleBackColor = true;
            this.btnSaveTransaction.Click += new System.EventHandler(this.btnSaveTransaction_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(12, 284);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(175, 39);
            this.btnClear.TabIndex = 16;
            this.btnClear.Text = "Reset Form";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nameOfStockFundDataGridViewTextBoxColumn,
            this.typeOfHoldingDataGridViewTextBoxColumn,
            this.numberOfUnitsDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.stockHoldingsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(798, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(665, 311);
            this.dataGridView1.TabIndex = 17;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Width = 150;
            // 
            // nameOfStockFundDataGridViewTextBoxColumn
            // 
            this.nameOfStockFundDataGridViewTextBoxColumn.DataPropertyName = "Name of Stock/Fund";
            this.nameOfStockFundDataGridViewTextBoxColumn.HeaderText = "Name of Stock/Fund";
            this.nameOfStockFundDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nameOfStockFundDataGridViewTextBoxColumn.Name = "nameOfStockFundDataGridViewTextBoxColumn";
            this.nameOfStockFundDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameOfStockFundDataGridViewTextBoxColumn.Width = 150;
            // 
            // typeOfHoldingDataGridViewTextBoxColumn
            // 
            this.typeOfHoldingDataGridViewTextBoxColumn.DataPropertyName = "Type of Holding";
            this.typeOfHoldingDataGridViewTextBoxColumn.HeaderText = "Type of Holding";
            this.typeOfHoldingDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.typeOfHoldingDataGridViewTextBoxColumn.Name = "typeOfHoldingDataGridViewTextBoxColumn";
            this.typeOfHoldingDataGridViewTextBoxColumn.ReadOnly = true;
            this.typeOfHoldingDataGridViewTextBoxColumn.Width = 150;
            // 
            // numberOfUnitsDataGridViewTextBoxColumn
            // 
            this.numberOfUnitsDataGridViewTextBoxColumn.DataPropertyName = "Number of Units";
            this.numberOfUnitsDataGridViewTextBoxColumn.HeaderText = "Number of Units";
            this.numberOfUnitsDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.numberOfUnitsDataGridViewTextBoxColumn.Name = "numberOfUnitsDataGridViewTextBoxColumn";
            this.numberOfUnitsDataGridViewTextBoxColumn.ReadOnly = true;
            this.numberOfUnitsDataGridViewTextBoxColumn.Width = 150;
            // 
            // stockHoldingsBindingSource
            // 
            this.stockHoldingsBindingSource.DataMember = "StockHoldings";
            this.stockHoldingsBindingSource.DataSource = this.moneydbDataSet;
            // 
            // moneydbDataSet
            // 
            this.moneydbDataSet.DataSetName = "MoneydbDataSet";
            this.moneydbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stockHoldingsTableAdapter
            // 
            this.stockHoldingsTableAdapter.ClearBeforeFill = true;
            // 
            // NewTransactionStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1477, 340);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSaveTransaction);
            this.Controls.Add(this.groupBox1);
            this.Name = "NewTransactionStock";
            this.Text = "New Transaction";
            this.Load += new System.EventHandler(this.NewTransactionStock_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockHoldingsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moneydbDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTransactionName;
        private System.Windows.Forms.TextBox txtUnitsObtained;
        private System.Windows.Forms.TextBox txtAmountOut;
        private System.Windows.Forms.TextBox txtAmountIn;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.TextBox txtFundID;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSaveTransaction;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DateTimePicker dtpTransactionDate;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MoneydbDataSet moneydbDataSet;
        private System.Windows.Forms.BindingSource stockHoldingsBindingSource;
        private MoneydbDataSetTableAdapters.StockHoldingsTableAdapter stockHoldingsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameOfStockFundDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeOfHoldingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberOfUnitsDataGridViewTextBoxColumn;
    }
}