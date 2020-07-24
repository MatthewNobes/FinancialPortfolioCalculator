using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace FinancialPortfolioCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'moneydbDataSet.Transactions' table. You can move, or remove it, as needed.
            this.transactionsTableAdapter.Fill(this.moneydbDataSet.Transactions);
            // TODO: This line of code loads data into the 'moneydbDataSet.StockHoldings' table. You can move, or remove it, as needed.
            this.stockHoldingsTableAdapter.Fill(this.moneydbDataSet.StockHoldings);
            //dgvHoldings.DataSource = MoneydbDataSet;
            

            

        }


        private void btnNewTrans_Click(object sender, EventArgs e)
        {

            
        }
    }
}
