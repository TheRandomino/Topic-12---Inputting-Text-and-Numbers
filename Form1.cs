using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Topic_12___Inputting_Text_and_Numbers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnPriceCalc_Click(object sender, EventArgs e)
        {
            double price = Convert.ToDouble(txtItemPrice.Text);
            int quantity = Convert.ToInt32(txtItemQuantity.Text);
            lblFinalPrice.Text = ("Final Price (After 13% Tax): $" + Math.Round((price * quantity)*1.13, 2));
        }
    }
}
