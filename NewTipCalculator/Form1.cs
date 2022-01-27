using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewTipCalculator {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e) {
            var billamount = Convert.ToDecimal(txtBillAmount.Text);

            var tiprate = 0.2m;
            txtTipRate.Text = tiprate.ToString("p0");

            var tipamount = billamount * tiprate;
            txtTipAmount.Text = tipamount.ToString("c");
        
                
        }

        private void btnExit_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
