using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BillCalculatorFormApp
{
    public partial class BillCalculatorUI : Form
    {
        public BillCalculatorUI()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void showTotalButton_Click(object sender, EventArgs e)
        {
            double unitRice = Convert.ToDouble(riceTextBox.Text);
            double unitFish = Convert.ToDouble(fishTextBox.Text);
            double unitMeat = Convert.ToDouble(meatTextBox.Text);
            double total = (unitRice*20) + (unitFish*80) + (unitMeat*100);
            totalTextBox.Text = Convert.ToString(total);
        }

        private void billButton_Click(object sender, EventArgs e)
        {
            double total = Convert.ToDouble(totalTextBox.Text);
            double discount = Convert.ToDouble(discountTextBox.Text);
            double vat=5;
            double netBill = (total - (total*discount)/100) + ((total*vat)/100);
            MessageBox.Show("Your Net Bill is "+Convert.ToString(netBill)+ " tk");
        }
    }
}
