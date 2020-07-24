namespace FinancialPortfolioCalculator
{
    partial class Form1
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
            this.tbcMain = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnNewValue = new System.Windows.Forms.Button();
            this.tbcStocks = new System.Windows.Forms.TabControl();
            this.tbpHoldings = new System.Windows.Forms.TabPage();
            this.dgvHoldings = new System.Windows.Forms.DataGridView();
            this.tbcTransactions = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.btnNewTrans = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.moneydbDataSet = new FinancialPortfolioCalculator.MoneydbDataSet();
            this.stockHoldingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stockHoldingsTableAdapter = new FinancialPortfolioCalculator.MoneydbDataSetTableAdapters.StockHoldingsTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameOfStockFundDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeOfHoldingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberOfUnitsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.initalInvestmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dividendReinvesmentsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberOfDividendReinvestmentsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockHoldingsTransactionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transactionsTableAdapter = new FinancialPortfolioCalculator.MoneydbDataSetTableAdapters.TransactionsTableAdapter();
            this.iDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameOfTransactionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountInDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountOutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fundIDNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeOfTransactionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitsObtainedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfTransactionsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbcMain.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tbcStocks.SuspendLayout();
            this.tbpHoldings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoldings)).BeginInit();
            this.tbcTransactions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.moneydbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockHoldingsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockHoldingsTransactionsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tbcMain
            // 
            this.tbcMain.Controls.Add(this.tabPage1);
            this.tbcMain.Controls.Add(this.tabPage2);
            this.tbcMain.Location = new System.Drawing.Point(12, 12);
            this.tbcMain.Name = "tbcMain";
            this.tbcMain.SelectedIndex = 0;
            this.tbcMain.Size = new System.Drawing.Size(1300, 913);
            this.tbcMain.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1292, 880);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cash Savings";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(7, 7);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(835, 342);
            this.textBox1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnNewValue);
            this.tabPage2.Controls.Add(this.tbcStocks);
            this.tabPage2.Controls.Add(this.btnNewTrans);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1292, 880);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Stocks & Shares Investments";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnNewValue
            // 
            this.btnNewValue.Location = new System.Drawing.Point(1108, 54);
            this.btnNewValue.Name = "btnNewValue";
            this.btnNewValue.Size = new System.Drawing.Size(178, 41);
            this.btnNewValue.TabIndex = 4;
            this.btnNewValue.Text = "New Valuation";
            this.btnNewValue.UseVisualStyleBackColor = true;
            // 
            // tbcStocks
            // 
            this.tbcStocks.Controls.Add(this.tbpHoldings);
            this.tbcStocks.Controls.Add(this.tbcTransactions);
            this.tbcStocks.Controls.Add(this.tabPage3);
            this.tbcStocks.Location = new System.Drawing.Point(7, 7);
            this.tbcStocks.Name = "tbcStocks";
            this.tbcStocks.SelectedIndex = 0;
            this.tbcStocks.Size = new System.Drawing.Size(1095, 867);
            this.tbcStocks.TabIndex = 3;
            // 
            // tbpHoldings
            // 
            this.tbpHoldings.Controls.Add(this.dgvHoldings);
            this.tbpHoldings.Location = new System.Drawing.Point(4, 29);
            this.tbpHoldings.Name = "tbpHoldings";
            this.tbpHoldings.Padding = new System.Windows.Forms.Padding(3);
            this.tbpHoldings.Size = new System.Drawing.Size(1087, 834);
            this.tbpHoldings.TabIndex = 0;
            this.tbpHoldings.Text = "Holdings";
            this.tbpHoldings.UseVisualStyleBackColor = true;
            // 
            // dgvHoldings
            // 
            this.dgvHoldings.AutoGenerateColumns = false;
            this.dgvHoldings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoldings.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nameOfStockFundDataGridViewTextBoxColumn,
            this.typeOfHoldingDataGridViewTextBoxColumn,
            this.numberOfUnitsDataGridViewTextBoxColumn,
            this.initalInvestmentDataGridViewTextBoxColumn,
            this.dividendReinvesmentsDataGridViewTextBoxColumn,
            this.numberOfDividendReinvestmentsDataGridViewTextBoxColumn});
            this.dgvHoldings.DataSource = this.stockHoldingsBindingSource;
            this.dgvHoldings.Location = new System.Drawing.Point(6, 6);
            this.dgvHoldings.Name = "dgvHoldings";
            this.dgvHoldings.RowHeadersWidth = 62;
            this.dgvHoldings.RowTemplate.Height = 28;
            this.dgvHoldings.Size = new System.Drawing.Size(1075, 822);
            this.dgvHoldings.TabIndex = 0;
            // 
            // tbcTransactions
            // 
            this.tbcTransactions.Controls.Add(this.dataGridView2);
            this.tbcTransactions.Location = new System.Drawing.Point(4, 29);
            this.tbcTransactions.Name = "tbcTransactions";
            this.tbcTransactions.Padding = new System.Windows.Forms.Padding(3);
            this.tbcTransactions.Size = new System.Drawing.Size(1087, 834);
            this.tbcTransactions.TabIndex = 1;
            this.tbcTransactions.Text = "Tansactions";
            this.tbcTransactions.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn1,
            this.nameOfTransactionDataGridViewTextBoxColumn,
            this.amountInDataGridViewTextBoxColumn,
            this.amountOutDataGridViewTextBoxColumn,
            this.fundIDNumberDataGridViewTextBoxColumn,
            this.typeOfTransactionDataGridViewTextBoxColumn,
            this.unitsObtainedDataGridViewTextBoxColumn,
            this.dateOfTransactionsDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.stockHoldingsTransactionsBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(6, 6);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(1075, 822);
            this.dataGridView2.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridView3);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1087, 834);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(6, 6);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 62;
            this.dataGridView3.RowTemplate.Height = 28;
            this.dataGridView3.Size = new System.Drawing.Size(1075, 822);
            this.dataGridView3.TabIndex = 1;
            // 
            // btnNewTrans
            // 
            this.btnNewTrans.Location = new System.Drawing.Point(1108, 7);
            this.btnNewTrans.Name = "btnNewTrans";
            this.btnNewTrans.Size = new System.Drawing.Size(178, 41);
            this.btnNewTrans.TabIndex = 2;
            this.btnNewTrans.Text = "New Transactions";
            this.btnNewTrans.UseVisualStyleBackColor = true;
            this.btnNewTrans.Click += new System.EventHandler(this.btnNewTrans_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(1318, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(220, 395);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Total";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Grand Total:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "______________________";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Shares Total:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cash Total:";
            // 
            // moneydbDataSet
            // 
            this.moneydbDataSet.DataSetName = "MoneydbDataSet";
            this.moneydbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stockHoldingsBindingSource
            // 
            this.stockHoldingsBindingSource.DataMember = "StockHoldings";
            this.stockHoldingsBindingSource.DataSource = this.moneydbDataSet;
            // 
            // stockHoldingsTableAdapter
            // 
            this.stockHoldingsTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Width = 150;
            // 
            // nameOfStockFundDataGridViewTextBoxColumn
            // 
            this.nameOfStockFundDataGridViewTextBoxColumn.DataPropertyName = "Name of Stock/Fund";
            this.nameOfStockFundDataGridViewTextBoxColumn.HeaderText = "Name of Stock/Fund";
            this.nameOfStockFundDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nameOfStockFundDataGridViewTextBoxColumn.Name = "nameOfStockFundDataGridViewTextBoxColumn";
            this.nameOfStockFundDataGridViewTextBoxColumn.Width = 150;
            // 
            // typeOfHoldingDataGridViewTextBoxColumn
            // 
            this.typeOfHoldingDataGridViewTextBoxColumn.DataPropertyName = "Type of Holding";
            this.typeOfHoldingDataGridViewTextBoxColumn.HeaderText = "Type of Holding";
            this.typeOfHoldingDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.typeOfHoldingDataGridViewTextBoxColumn.Name = "typeOfHoldingDataGridViewTextBoxColumn";
            this.typeOfHoldingDataGridViewTextBoxColumn.Width = 150;
            // 
            // numberOfUnitsDataGridViewTextBoxColumn
            // 
            this.numberOfUnitsDataGridViewTextBoxColumn.DataPropertyName = "Number of Units";
            this.numberOfUnitsDataGridViewTextBoxColumn.HeaderText = "Number of Units";
            this.numberOfUnitsDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.numberOfUnitsDataGridViewTextBoxColumn.Name = "numberOfUnitsDataGridViewTextBoxColumn";
            this.numberOfUnitsDataGridViewTextBoxColumn.Width = 150;
            // 
            // initalInvestmentDataGridViewTextBoxColumn
            // 
            this.initalInvestmentDataGridViewTextBoxColumn.DataPropertyName = "Inital Investment";
            this.initalInvestmentDataGridViewTextBoxColumn.HeaderText = "Inital Investment";
            this.initalInvestmentDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.initalInvestmentDataGridViewTextBoxColumn.Name = "initalInvestmentDataGridViewTextBoxColumn";
            this.initalInvestmentDataGridViewTextBoxColumn.Width = 150;
            // 
            // dividendReinvesmentsDataGridViewTextBoxColumn
            // 
            this.dividendReinvesmentsDataGridViewTextBoxColumn.DataPropertyName = "Dividend Re-invesments";
            this.dividendReinvesmentsDataGridViewTextBoxColumn.HeaderText = "Dividend Re-invesments";
            this.dividendReinvesmentsDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.dividendReinvesmentsDataGridViewTextBoxColumn.Name = "dividendReinvesmentsDataGridViewTextBoxColumn";
            this.dividendReinvesmentsDataGridViewTextBoxColumn.Width = 150;
            // 
            // numberOfDividendReinvestmentsDataGridViewTextBoxColumn
            // 
            this.numberOfDividendReinvestmentsDataGridViewTextBoxColumn.DataPropertyName = "Number of dividend re-investments";
            this.numberOfDividendReinvestmentsDataGridViewTextBoxColumn.HeaderText = "Number of dividend re-investments";
            this.numberOfDividendReinvestmentsDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.numberOfDividendReinvestmentsDataGridViewTextBoxColumn.Name = "numberOfDividendReinvestmentsDataGridViewTextBoxColumn";
            this.numberOfDividendReinvestmentsDataGridViewTextBoxColumn.Width = 150;
            // 
            // stockHoldingsTransactionsBindingSource
            // 
            this.stockHoldingsTransactionsBindingSource.DataMember = "StockHoldingsTransactions";
            this.stockHoldingsTransactionsBindingSource.DataSource = this.stockHoldingsBindingSource;
            // 
            // transactionsTableAdapter
            // 
            this.transactionsTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn1
            // 
            this.iDDataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn1.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.iDDataGridViewTextBoxColumn1.Name = "iDDataGridViewTextBoxColumn1";
            this.iDDataGridViewTextBoxColumn1.Width = 150;
            // 
            // nameOfTransactionDataGridViewTextBoxColumn
            // 
            this.nameOfTransactionDataGridViewTextBoxColumn.DataPropertyName = "Name of Transaction";
            this.nameOfTransactionDataGridViewTextBoxColumn.HeaderText = "Name of Transaction";
            this.nameOfTransactionDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nameOfTransactionDataGridViewTextBoxColumn.Name = "nameOfTransactionDataGridViewTextBoxColumn";
            this.nameOfTransactionDataGridViewTextBoxColumn.Width = 150;
            // 
            // amountInDataGridViewTextBoxColumn
            // 
            this.amountInDataGridViewTextBoxColumn.DataPropertyName = "Amount In";
            this.amountInDataGridViewTextBoxColumn.HeaderText = "Amount In";
            this.amountInDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.amountInDataGridViewTextBoxColumn.Name = "amountInDataGridViewTextBoxColumn";
            this.amountInDataGridViewTextBoxColumn.Width = 150;
            // 
            // amountOutDataGridViewTextBoxColumn
            // 
            this.amountOutDataGridViewTextBoxColumn.DataPropertyName = "Amount Out";
            this.amountOutDataGridViewTextBoxColumn.HeaderText = "Amount Out";
            this.amountOutDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.amountOutDataGridViewTextBoxColumn.Name = "amountOutDataGridViewTextBoxColumn";
            this.amountOutDataGridViewTextBoxColumn.Width = 150;
            // 
            // fundIDNumberDataGridViewTextBoxColumn
            // 
            this.fundIDNumberDataGridViewTextBoxColumn.DataPropertyName = "Fund ID Number";
            this.fundIDNumberDataGridViewTextBoxColumn.HeaderText = "Fund ID Number";
            this.fundIDNumberDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.fundIDNumberDataGridViewTextBoxColumn.Name = "fundIDNumberDataGridViewTextBoxColumn";
            this.fundIDNumberDataGridViewTextBoxColumn.Width = 150;
            // 
            // typeOfTransactionDataGridViewTextBoxColumn
            // 
            this.typeOfTransactionDataGridViewTextBoxColumn.DataPropertyName = "Type of Transaction";
            this.typeOfTransactionDataGridViewTextBoxColumn.HeaderText = "Type of Transaction";
            this.typeOfTransactionDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.typeOfTransactionDataGridViewTextBoxColumn.Name = "typeOfTransactionDataGridViewTextBoxColumn";
            this.typeOfTransactionDataGridViewTextBoxColumn.Width = 150;
            // 
            // unitsObtainedDataGridViewTextBoxColumn
            // 
            this.unitsObtainedDataGridViewTextBoxColumn.DataPropertyName = "Units Obtained";
            this.unitsObtainedDataGridViewTextBoxColumn.HeaderText = "Units Obtained";
            this.unitsObtainedDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.unitsObtainedDataGridViewTextBoxColumn.Name = "unitsObtainedDataGridViewTextBoxColumn";
            this.unitsObtainedDataGridViewTextBoxColumn.Width = 150;
            // 
            // dateOfTransactionsDataGridViewTextBoxColumn
            // 
            this.dateOfTransactionsDataGridViewTextBoxColumn.DataPropertyName = "Date of Transactions";
            this.dateOfTransactionsDataGridViewTextBoxColumn.HeaderText = "Date of Transactions";
            this.dateOfTransactionsDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.dateOfTransactionsDataGridViewTextBoxColumn.Name = "dateOfTransactionsDataGridViewTextBoxColumn";
            this.dateOfTransactionsDataGridViewTextBoxColumn.Width = 150;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1550, 937);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbcMain);
            this.Name = "Form1";
            this.Text = "Finance Managment";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tbcMain.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tbcStocks.ResumeLayout(false);
            this.tbpHoldings.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoldings)).EndInit();
            this.tbcTransactions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.moneydbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockHoldingsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockHoldingsTransactionsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcMain;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tbcStocks;
        private System.Windows.Forms.TabPage tbpHoldings;
        private System.Windows.Forms.TabPage tbcTransactions;
        private System.Windows.Forms.Button btnNewTrans;
        private System.Windows.Forms.Button btnNewValue;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dgvHoldings;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private MoneydbDataSet moneydbDataSet;
        private System.Windows.Forms.BindingSource stockHoldingsBindingSource;
        private MoneydbDataSetTableAdapters.StockHoldingsTableAdapter stockHoldingsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameOfStockFundDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeOfHoldingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberOfUnitsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn initalInvestmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dividendReinvesmentsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberOfDividendReinvestmentsDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource stockHoldingsTransactionsBindingSource;
        private MoneydbDataSetTableAdapters.TransactionsTableAdapter transactionsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameOfTransactionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountInDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountOutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fundIDNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeOfTransactionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitsObtainedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfTransactionsDataGridViewTextBoxColumn;
    }
}

