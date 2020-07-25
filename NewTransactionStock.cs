using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancialPortfolioCalculator
{
    public partial class NewTransactionStock : Form
    {
        public NewTransactionStock()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //Clears all Text boxes.
            txtTransactionName.Text = null;
            txtUnitsObtained.Text = null;
            txtFundID.Text = null;
            txtAmountIn.Text = null;
            txtAmountOut.Text = null;

            //Sets Date in date picker to current date. 
            dtpTransactionDate.Value = DateTime.UtcNow.Date;

            //Clears combo box.
            cmbType.Text = null;
        }

        private void NewTransactionStock_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'moneydbDataSet.StockHoldings' table. You can move, or remove it, as needed.
            this.stockHoldingsTableAdapter.Fill(this.moneydbDataSet.StockHoldings);

        }

        private void btnSaveTransaction_Click(object sender, EventArgs e)
        {
            string SQLCommand = "Insert Into Transactions ( NameofTransaction , DateofTransaction, AmountIn, AmountOut, FundIDNumber, TypeofTransaction, UnitsObtained) " +
                "Values ('" + txtTransactionName.Text + "', "  + dtpTransactionDate.Text + "', " + txtAmountIn.Text + "', " + txtAmountOut.Text + "', " + txtFundID.Text + "', "
                + cmbType.Text + "', " + txtUnitsObtained.Text + "');";

            moneydbDataSet.StockHoldings newCustomersRow = moneydbDataSet.StockHoldings.NewCustomersRow();

            newCustomersRow.CustomerID = "ALFKI";
            newCustomersRow.CompanyName = "Alfreds Futterkiste";

            moneydbDataSet.StockHoldings.Rows.Add(newCustomersRow);





        }
    }
}
